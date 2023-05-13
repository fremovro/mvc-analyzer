using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LifelessEmotionAnalyzer.Controllers
{
    public class BaseController 
	{
		protected Form form;
		protected List<Action<object, EventArgs>> actions = new List<Action<object, EventArgs>>();

		public BaseController(Form form) 
		{
			this.form = form;
		}
	}
}
