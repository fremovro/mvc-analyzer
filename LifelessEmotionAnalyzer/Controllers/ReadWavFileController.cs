using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LifelessEmotionAnalyzer.Entities;
using LifelessEmotionAnalyzer.Models.File;

namespace LifelessEmotionAnalyzer.Controllers
{
    public class ReadWavFileController : BaseController
    {
        private FileManager fileManager;

        public ReadWavFileController(Form1 form) : base(form) {
            form.openFiles.Click += OpenFiles_Click;
          
            fileManager = new FileManager();
		}

        private Form1 form1 => form as Form1;
        private void OpenFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Title = "Select .wav files"
                
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                form1.dataContext.wavFiles = fileManager.ReadWavFiles(fileDialog, form1.numUpTimeStart, form1.numUpTimeRange);
            }
        }

    }
}
