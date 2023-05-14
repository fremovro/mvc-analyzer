using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using LifelessEmotionAnalyzer.Models.DPF;
using LifelessEmotionAnalyzer.Models.File;
using LifelessEmotionAnalyzer.Models.Network;

namespace LifelessEmotionAnalyzer.Models
{
    public class DataContext
    {
        public Dictionary<int, WavFileModel> wavFiles { get; set; }
        public Dictionary<int, DpfModel> dpfResult { get; set; }
        public Dictionary<int, List<double>> frequencyRatios { get; set; }
        public NetworkModel neuronNetwork { get; set; }
        public Chart dpfDataChart { get; set; }
        public int chosenIndex { get; set; }
    }
}
