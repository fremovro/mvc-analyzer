using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifelessEmotionAnalyzer.Models;
using LifelessEmotionAnalyzer.Models.DPF;
using LifelessEmotionAnalyzer.Models.File;

namespace LifelessEmotionAnalyzer.Entities
{
    public class CalculateManager
    {
        /// <summary>
        /// Дискретное преобразование Фурье
        /// </summary>
        /// <param name="dataContext"></param>
        /// <param name="maxAmplitude"></param>
        /// <returns></returns>
        public Dictionary<int, DpfModel> DPF(DataContext dataContext, ProgressBar fRProgressBar)
        {
            var temp = new Dictionary<int, DpfModel>();

            fRProgressBar.Value = 0;
            fRProgressBar.Maximum = dataContext.wavFiles.Count() * 2;
            foreach (var file in dataContext.wavFiles)
            {
                var result = new List<SoundElement>();
                var maxAmplitude = double.MinValue;

                int n = file.Value.soundData.Length;
                if (n > 0)
                {
                    alglib.complex[] dpfResult = new alglib.complex[n];
                    alglib.fftr1d(file.Value.soundData, n, out dpfResult);

                    // Частота = частота дискретизации / размер массива
                    var frequency = (double)file.Value.sampleRate / n;

                    for (int k = 0; k < n / 2; k++)
                    {
                        var amplitudeValue = (2 * Math.Sqrt(Math.Pow(dpfResult[k].x, 2) + Math.Pow(dpfResult[k].y, 2))) / n;
                        var frequencyValue = frequency * k;

                        maxAmplitude = amplitudeValue > maxAmplitude ? amplitudeValue : maxAmplitude;

                        result.Add(new SoundElement(amplitudeValue, frequencyValue));
                    }
                }

                temp.Add(file.Key, new DpfModel(result, maxAmplitude));
                fRProgressBar.PerformStep();
            }

            return temp;
        }

        /// <summary>
        /// Вычисление отношений частот
        /// </summary>
        /// <param name="dataContext"></param>
        /// <param name="numUpMaxCount"></param>
        /// <param name="numUpIdent"></param>
        /// <returns></returns>
        public Dictionary<int, List<double>> CalculateRequencyRatios(DataContext dataContext, NumericUpDown numUpMaxCount, NumericUpDown numUpIdent, ProgressBar fRProgressBar)
        {
            var temp = new Dictionary<int, List<double>>();
            foreach (var dpfElement in dataContext.dpfResult)
            {
                var delta = (int)numUpIdent.Value;

                var resultLocalMaximum = FindLocalMaximum(dpfElement.Value.resultDpfData, delta, numUpMaxCount);

                temp.Add(dpfElement.Key, new List<double>());

                for (int k = 0; k < resultLocalMaximum.Count; k++)
                    for (int l = k + 1; l < resultLocalMaximum.Count; l++)
                    {
                        temp[dpfElement.Key].Add(resultLocalMaximum[k].Frecuency / resultLocalMaximum[l].Frecuency >= 1
                            ? Math.Round(resultLocalMaximum[l].Frecuency / resultLocalMaximum[k].Frecuency, 2) : Math.Round(resultLocalMaximum[k].Frecuency / resultLocalMaximum[l].Frecuency, 2));
                    }
                fRProgressBar.PerformStep();
            }
            return temp;
        }

        /// <summary>
        /// Поиск локальных максимумов
        /// </summary>
        /// <param name="resultData"></param>
        /// <param name="separatorCount"></param>
        /// <param name="numUpMaxCount"></param>
        /// <returns></returns>
        private List<SoundElement> FindLocalMaximum(List<SoundElement> resultData, int separatorCount, NumericUpDown numUpMaxCount)
        {
            var resultTemp = new List<SoundElement>();
            var res = new List<SoundElement>();
            SoundElement temp;
            for (int i = 2; i < resultData.Count() - 1; i++)
                if (resultData[i].Amplitude > resultData[i + 1].Amplitude && resultData[i].Amplitude > resultData[i - 1].Amplitude)
                    resultTemp.Add(resultData[i]);

            for (int i = 0; i < resultTemp.Count() - 1; i++)
                for (int j = i + 1; j < resultTemp.Count(); j++)
                    if (resultTemp[i].Amplitude < resultTemp[j].Amplitude)
                    {
                        temp = resultTemp[j];
                        resultTemp[j] = resultTemp[i];
                        resultTemp[i] = temp;
                    }

            for (int i = 0; i < resultTemp.Count(); i++)
                if (i == 0)
                    res.Add(resultTemp[i]);
                else
                {
                    bool f = true;
                    for (int j = 0; j < res.Count(); j++)
                        if (Math.Abs(resultTemp[i].Frecuency - res[j].Frecuency) < separatorCount)
                            f = false;
                    if (f) res.Add(resultTemp[i]);
                }
            res.RemoveRange((int)numUpMaxCount.Value, res.Count() - (int)numUpMaxCount.Value);

            return res;
        }
    }
}
