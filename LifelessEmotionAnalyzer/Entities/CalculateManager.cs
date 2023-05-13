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
    internal class CalculateManager
    {
        /// <summary>
        /// Дискретное преобразование Фурье
        /// </summary>
        /// <param name="dataContext"></param>
        /// <param name="maxAmplitude"></param>
        /// <returns></returns>
        public Dictionary<int, DpfModel> DPF(Dictionary<int, WavFileModel> wavFiles)
        {
            var temp = new Dictionary<int, DpfModel>();

            foreach (var file in wavFiles)
            {
                var result = new List<SoundElement>();
                var maxAmplitude = double.MinValue;

                int n = file.Value.soundData.Length;
                if (n > 0)
                {
                    alglib.complex[] dpfResult = new alglib.complex[n];
                    alglib.fftr1d(file.Value.soundData, n, out dpfResult);

                    // частота = частота дискретизации / размер массива
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
            }

            return temp;
        }

        //public void CalculateRequencyRatios(NumericUpDown numUpMaxCount, NumericUpDown numUpIdent)
        //{
        //    dataContext.requencyRatios = new Dictionary<int, List<double>>();
        //    foreach (var resultDpf in DpfResult.dpfResult)
        //    {
        //        var delta = (int)numUpIdent.Value;

        //        var resultLocalMaximum = FindLocalMaximum(resultDpf.Value.resultDpfData, delta, numUpMaxCount);

        //        dataContext.requencyRatios.Add(resultDpf.Key, new List<double>());

        //        for (int k = 0; k < resultLocalMaximum.Count; k++)
        //            for (int l = k + 1; l < resultLocalMaximum.Count; l++)
        //            {
        //                dataContext.requencyRatios[resultDpf.Key].Add(resultLocalMaximum[k].Frecuency / resultLocalMaximum[l].Frecuency >= 1
        //                    ? Math.Round(resultLocalMaximum[l].Frecuency / resultLocalMaximum[k].Frecuency, 2) : Math.Round(resultLocalMaximum[k].Frecuency / resultLocalMaximum[l].Frecuency, 2));
        //            }
        //    }
        //}
    }
}
