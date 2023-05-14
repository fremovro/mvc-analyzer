using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Neuro.Learning;
using Accord.Neuro;
using System.Windows.Forms;
using LifelessEmotionAnalyzer.Models;
using LifelessEmotionAnalyzer.Models.Network;

namespace LifelessEmotionAnalyzer.Entities
{
    public class NetworkManager
    {
        public void NetworkSample(DataContext dataContext)
        {
            double[][] input = new double[dataContext.frequencyRatios.ToArray().Length][];
            double[][] output = new double[dataContext.frequencyRatios.ToArray().Length][];

            foreach (var el in dataContext.wavFiles)
            {
                output[el.Key] = new double[3];
                output[el.Key][0] = 0;
                output[el.Key][1] = 0;
                output[el.Key][2] = 0;
                output[el.Key][dataContext.wavFiles.Where(e => e.Key == el.Key).FirstOrDefault().Value.emotionNum - 1] = 1;
            }

            foreach (var reqVector in dataContext.frequencyRatios)
            {
                input[reqVector.Key] = new double[10];

                for (var i = 0; i < MusIntervals.musIntervals.Count(); i++)
                {
                    if (reqVector.Value.Contains(MusIntervals.musIntervals.ToArray()[i].Key))
                        input[reqVector.Key][i] = 1;
                    else
                        input[reqVector.Key][i] = 0;
                }
            }
            dataContext.neuronNetwork = new NetworkModel(input, output);
        }

        public void LerningNetwork(DataContext dataContext, NumericUpDown neuronsCount, NumericUpDown iterationsCount, ProgressBar progressLearning, TextBox errorTextBox)
        {
            dataContext.neuronNetwork.network = new ActivationNetwork(
                new BipolarSigmoidFunction(),
                NetworkModel.inputCount,
                new int[2] { Convert.ToInt32(neuronsCount.Value), NetworkModel.outputCount }
                );

            dataContext.neuronNetwork.teacher0 = new BackPropagationLearning(dataContext.neuronNetwork.network);

            double error = 1.0;
            Console.WriteLine("learning error  ===>  {0}", error);

            int iterations = 0;
            while (error > 0.01 && iterations < iterationsCount.Value)
            {
                progressLearning.Value = (int)(((double)iterations / (double)iterationsCount.Value) * 100.0);
                error = dataContext.neuronNetwork.teacher0.RunEpoch(dataContext.neuronNetwork.input, dataContext.neuronNetwork.output);
                Console.WriteLine("learning error  ===>  {0}", error);
                iterations++;
            }
            progressLearning.Value = 100;
            Console.WriteLine("iterations  ===>  {0}", iterations);

            errorTextBox.Text = error.ToString();
            //dataContext.neuronNetworkModel.network.Save("learnedNetwork");
        }

        public void PrognozeByFile(DataContext dataContext, RichTextBox resText)
        {
            double[][] input = new double[dataContext.frequencyRatios.ToArray().Length][];
            double[][] output = new double[dataContext.frequencyRatios.ToArray().Length][];

            foreach (var el in dataContext.wavFiles)
            {
                output[el.Key] = new double[3];
                output[el.Key][0] = 0;
                output[el.Key][1] = 0;
                output[el.Key][2] = 0;
                output[el.Key][dataContext.wavFiles.Where(e => e.Key == el.Key).FirstOrDefault().Value.emotionNum - 1] = 1;
            }

            foreach (var reqVector in dataContext.frequencyRatios)
            {
                input[reqVector.Key] = new double[10];

                for (var i = 0; i < MusIntervals.musIntervals.Count(); i++)
                {
                    if (reqVector.Value.Contains(MusIntervals.musIntervals.ToArray()[i].Key))
                        input[reqVector.Key][i] = 1;
                    else
                        input[reqVector.Key][i] = 0;
                }
            }

            string res = "";
            for (int i = 0; i < input.Length; i++)
            {
                var result = new List<double>
                {
                    dataContext.neuronNetwork.network.Compute(input[i])[0],
                    dataContext.neuronNetwork.network.Compute(input[i])[1],
                    dataContext.neuronNetwork.network.Compute(input[i])[2]
                };

                var emotion = i.ToString() + ") " + (result[0] == result.Max() ? "Радость" : (result[1] == result.Max() ? "Страх" : "Отвращение")) + "\n";
                resText.SelectionStart = resText.Text.Length;
                resText.SelectionLength = emotion.Length;
                if ((emotion.Contains("Радость") && output[i][0] == 1) || (emotion.Contains("Страх") && output[i][1] == 1)
                     || (emotion.Contains("Отвращение") && output[i][2] == 1))
                    resText.SelectionColor = Color.Green;
                else resText.SelectionColor = Color.Red;
                resText.AppendText(emotion);
                resText.SelectionColor = resText.ForeColor;
            }
        }
    }
}
