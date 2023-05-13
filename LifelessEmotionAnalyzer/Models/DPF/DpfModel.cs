using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifelessEmotionAnalyzer.Models.DPF
{
    public class DpfModel
    {
        public List<SoundElement> resultDpfData;
        public double maxDpfAmplitude;

        public DpfModel(List<SoundElement> ResultDpfData, double MaxDpfAmplitude)
        {
            resultDpfData = ResultDpfData;
            maxDpfAmplitude = MaxDpfAmplitude;
        }
    }
}
