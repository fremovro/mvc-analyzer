using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LifelessEmotionAnalyzer.Models;

namespace LifelessEmotionAnalyzer.Entities
{
    public class AccessoryManager
    {
        public void PrintResultDataGraphByKey(DataContext dataContext, Panel panel, NumericUpDown NumUpSmooth, TextBox Name)
        {
            var chosenFile = dataContext.wavFiles
                .Where(el => el.Key == dataContext.chosenIndex).FirstOrDefault();

            var chosenDpfResult = dataContext.dpfResult
                .Where(el => el.Key == dataContext.chosenIndex).FirstOrDefault();

            if (dataContext.dpfDataChart is null)
            {
                // Создание элемента Chart
                dataContext.dpfDataChart = new Chart();

                // Растягивание элемента Chart на панели
                dataContext.dpfDataChart.Parent = panel;
                dataContext.dpfDataChart.Dock = DockStyle.Fill;
            }
            else
            {
                dataContext.dpfDataChart.Series.Clear();
                dataContext.dpfDataChart.ChartAreas.Clear();
            }

            // Добавление области для отрисовки графика
            dataContext.dpfDataChart.ChartAreas.Add(new ChartArea(chosenFile.Value.fileName));

            // Создаем и настраиваем набор точек для рисования графика
            Series pointSeries = new Series("Sound");
            pointSeries.ChartType = SeriesChartType.Line;
            pointSeries.ChartArea = chosenFile.Value.fileName;

            // Сглаживание
            for (int k = 0; k < NumUpSmooth.Value; k++)
                for (int j = 0, m = 4; j < m; j++)
                    for (int i = 2, l = chosenDpfResult.Value.resultDpfData.Count - 1; i < l; i++)
                        chosenDpfResult.Value.resultDpfData[i].Amplitude = 0.5 * (0.5 * (chosenDpfResult.Value.resultDpfData[i - 1].Amplitude
                            + chosenDpfResult.Value.resultDpfData[i + 1].Amplitude) + chosenDpfResult.Value.resultDpfData[i].Amplitude);

            // Заполнение набора точек
            foreach (var data in chosenDpfResult.Value.resultDpfData)
                if (data.Frecuency > 0)
                    pointSeries.Points.AddXY(data.Frecuency, data.Amplitude);

            // Добавление созданного набора точек к графику
            dataContext.dpfDataChart.Series.Add(pointSeries);

            Name.Text = chosenFile.Value.fileName;
        }

        public void ChoseNextFile(DataContext dataContext, Panel panel, NumericUpDown NumUpSmooth, TextBox chosenFileName, bool left)
        {
            string newName = string.Empty;

            var chosenFile = dataContext.wavFiles
                    .Where(el => el.Key == dataContext.chosenIndex).FirstOrDefault();

            var newChosenFile = left
                ? dataContext.wavFiles.Where(el => el.Key == chosenFile.Key - 1).FirstOrDefault()
                : dataContext.wavFiles.Where(el => el.Key == chosenFile.Key + 1).FirstOrDefault();

            dataContext.chosenIndex = newChosenFile.Key;

            if (newChosenFile.Value != null)
            {
                if (dataContext.dpfResult.Any())
                    PrintResultDataGraphByKey(dataContext, panel, NumUpSmooth, chosenFileName);

                //if (dataContext.requencyRatios.Any())
                //    PrintRequencyRatiosByKey(dataContext, chosenRequency, chosenFileName);
            }
        }

        public void PrintRequencyRatiosByKey(DataContext dataContext, RichTextBox resText)
        {
            var chosenFile = dataContext.wavFiles
                .Where(el => el.Key == dataContext.chosenIndex).FirstOrDefault();

            var chosenResultFR = dataContext.frequencyRatios
                .Where(el => el.Key == dataContext.chosenIndex).FirstOrDefault();

            resText.Text = "Полученные отношения частот:\r\n";

            foreach (var e in chosenResultFR.Value)
            {
                var flag = MusIntervals.musIntervals.Keys.Contains(e);

                if(flag)
                {
                    var temp = e.ToString();
                    var len = temp.Length;
                    resText.SelectionStart = resText.Text.Length;
                    resText.SelectionLength = e.ToString().Length;
                    resText.SelectionColor = Color.Green;
                }

                resText.AppendText(e.ToString() + "\r\n");

                if (flag)
                    resText.SelectionColor = resText.ForeColor;
            }
        }
    }
}
