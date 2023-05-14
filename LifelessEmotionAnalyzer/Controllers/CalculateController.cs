using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LifelessEmotionAnalyzer.Entities;
using LifelessEmotionAnalyzer.Models;
using LifelessEmotionAnalyzer.Models.DPF;
using LifelessEmotionAnalyzer.Models.File;

namespace LifelessEmotionAnalyzer.Controllers
{
    public class CalculateController : BaseController
    {
        private CalculateManager calculateManager;
        private AccessoryManager accessoryManager;
        private Form1 form1 => form as Form1;

        public CalculateController(Form1 form) : base(form)
        {
            form.CalculateButton.Click += Calculate_Click;
            form.BackButton.Click += choseBack_Click;
            form.NextButton.Click += choseNext_Click;

            calculateManager = new CalculateManager();
            accessoryManager = new AccessoryManager();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            form1.dataContext.dpfResult = calculateManager.DPF(form1.dataContext, form1.FRProgressBar);

            form1.dataContext.chosenIndex = form1.dataContext.dpfResult.First().Key;
            accessoryManager.PrintResultDataGraphByKey(form1.dataContext, form1.SpectrumPanel, form1.NumUpSmooth, form1.chosenDpfName);

            form1.dataContext.frequencyRatios = calculateManager.CalculateRequencyRatios(form1.dataContext, form1.NumUpMaxCount, form1.numUpIdent, form1.FRProgressBar);

            accessoryManager.PrintRequencyRatiosByKey(form1.dataContext, form1.ResultTextBox);
        }

        private void choseBack_Click(object sender, EventArgs e)
        {
            accessoryManager.ChoseNextFile(form1.dataContext, form1.SpectrumPanel, form1.NumUpSmooth, form1.chosenDpfName, true);

            accessoryManager.PrintRequencyRatiosByKey(form1.dataContext, form1.ResultTextBox);
        }

        private void choseNext_Click(object sender, EventArgs e)
        {
            accessoryManager.ChoseNextFile(form1.dataContext, form1.SpectrumPanel, form1.NumUpSmooth, form1.chosenDpfName, false);

            accessoryManager.PrintRequencyRatiosByKey(form1.dataContext, form1.ResultTextBox);
        }
    }
}
