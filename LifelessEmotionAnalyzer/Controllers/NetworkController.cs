using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifelessEmotionAnalyzer.Entities;
using LifelessEmotionAnalyzer.Models;
using LifelessEmotionAnalyzer.Models.File;

namespace LifelessEmotionAnalyzer.Controllers
{
    public class NetworkController : BaseController
    {
        private CalculateManager calculateManager;
        private AccessoryManager accessoryManager;
        private NetworkManager networkManager;
        private FileManager fileManager;
        private Form1 form1 => form as Form1;

        public NetworkController(Form1 form) : base(form)
        {
            form.LearnNetworkButton.Click += Learn_Click;
            form.PrognozeButton.Click += Prognoze_Click;

            calculateManager = new CalculateManager();
            accessoryManager = new AccessoryManager();
            networkManager = new NetworkManager();
            fileManager = new FileManager();
        }

        private void Learn_Click(object sender, EventArgs e)
        {
            networkManager.NetworkSample(form1.dataContext);

            networkManager.LerningNetwork(form1.dataContext, form1.NeuronCountNumUp, form1.IterationCountNumUp, form1.LearnNetworkProgressBar, form1.ErrorTextBox);
        }

        private void Prognoze_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Title = "Select .wav files"

            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var prognozeDataContext = new DataContext();

                form1.PrognozeProgressBar.Value = 0;
                form1.PrognozeProgressBar.Maximum = 4;

                prognozeDataContext.wavFiles = new Dictionary<int, WavFileModel>();
                prognozeDataContext.wavFiles = fileManager.ReadWavFiles(fileDialog, form1.numUpTimeStart, form1.numUpTimeRange, form1.FileProgressBar);
                form1.PrognozeProgressBar.PerformStep();

                prognozeDataContext.dpfResult = calculateManager.DPF(prognozeDataContext, form1.FRProgressBar);
                form1.PrognozeProgressBar.PerformStep();

                prognozeDataContext.frequencyRatios = calculateManager.CalculateRequencyRatios(prognozeDataContext, form1.NumUpMaxCount, form1.numUpIdent, form1.FRProgressBar);
                form1.PrognozeProgressBar.PerformStep();

                prognozeDataContext.neuronNetwork = form1.dataContext.neuronNetwork;
                networkManager.PrognozeByFile(prognozeDataContext, form1.PrognozeResultRichTextBox);
                form1.PrognozeProgressBar.PerformStep();
            }
        }
    }
}
