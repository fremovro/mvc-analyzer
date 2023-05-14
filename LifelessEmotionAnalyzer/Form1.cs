using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifelessEmotionAnalyzer.Models.File;
using System.Runtime.Remoting.Messaging;
using LifelessEmotionAnalyzer.Controllers;
using LifelessEmotionAnalyzer.Models;

namespace LifelessEmotionAnalyzer
{
    public partial class Form1 : Form
    {
        public DataContext dataContext = new DataContext();
        List<BaseController> controllers = new List<BaseController>();

		public Form1()
        {
            InitializeComponent();

            controllers.Add(new ReadWavFileController(this));
            controllers.Add(new CalculateController(this));
            controllers.Add(new NetworkController(this));
        }
    }
}
