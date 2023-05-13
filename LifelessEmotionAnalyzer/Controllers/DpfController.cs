using System;
using System.Collections.Generic;
using LifelessEmotionAnalyzer.Entities;
using LifelessEmotionAnalyzer.Models.DPF;
using LifelessEmotionAnalyzer.Models.File;

namespace LifelessEmotionAnalyzer.Controllers
{
    public class DpfController : BaseController
    {
        private CalculateManager calculateManager;

        public DpfController(Form1 form) : base(form)
        {
            form.DPF.Click += DPF_Click;

            calculateManager = new CalculateManager();
        }

        private Form1 form1 => form as Form1;

        private void DPF_Click(object sender, EventArgs e)
        {
            form1.dataContext.dpfResult = calculateManager.DPF(form1.dataContext.wavFiles);
        }
    }
}
