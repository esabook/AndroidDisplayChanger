using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVD_display_changer
{
	public partial class Add_Display_Size : Form
	{
		public Add_Display_Size()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var path = Application.StartupPath+@"\display-size.ini";
			var val = numericUpDown1.Value + "x" + numericUpDown2.Value;

			if (File.Exists(path) && File.ReadAllText(path).Contains(val))
			{
				InvokeLostFocus(null, e);
			}
			else
			{
				using (StreamWriter fl = new StreamWriter(path, true))
				{
					fl.WriteLine(val);
					fl.Close();
				}
			}
			
		}
	}
}
