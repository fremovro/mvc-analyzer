using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifelessEmotionAnalyzer.Models.DPF;
using LifelessEmotionAnalyzer.Models.File;

namespace LifelessEmotionAnalyzer.Models
{
    public class DataContext
    {
        public Dictionary<int, WavFileModel> wavFiles = new Dictionary<int, WavFileModel>();

        public Dictionary<int, DpfModel> dpfResult = new Dictionary<int, DpfModel>();
    }
}
