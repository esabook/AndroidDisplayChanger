using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVD_display_changer
{
	public partial class AVDDC : Form
	{
		string path = Application.StartupPath+ @"\display-size.ini";
		public AVDDC()
		{
			InitializeComponent();
		}

		private void bt_openAdbLocation_Click(object sender, EventArgs e)
		{
			if(od.ShowDialog() == DialogResult.OK)
				tx_adbLocation.Text = od.FileName;
		}

		private void ch_customADB(object sender, EventArgs e)
		{
			ch_adb.Checked = File.Exists(tx_adbLocation.Text) && ch_adb.Checked;
		}

		private void AVDDC_Load(object sender, EventArgs e)
		{

			bt_rfs.PerformClick();
			ls_ds.Items.Clear();

			foreach (string s in File.ReadAllLines(path))
			{
				if (s != null || s.Contains("x"))
				{
					ls_ds.Items.Add(s);
				}
			}
			p.StartInfo.Arguments = "version";
			p.Start();
			p.WaitForExit();
			using (StreamReader sr = p.StandardOutput)
			{
				var rs = sr.ReadToEnd();
				if (rs.Contains("Android Debug Bridge version"))
					tx_adbLocation.BackColor = Color.Lime;
				else
					tx_adbLocation.BackColor = DefaultBackColor;
			}


		}

		private void bt_rfs_Click(object sender, EventArgs e)
		{
			if (ch_adb.Checked) { p.StartInfo.FileName = tx_adbLocation.Text; }

			p.StartInfo.Arguments = "devices";
			string[] arg= { "ro.product.brand", "ro.product.model", "ro.build.version.release", "ro.build.version.sdk" };

			var n = new List<string>();
			ls_dv.Items.Clear();
			p.Start();
			foreach(var c in Regex.Split( p.StandardOutput.ReadToEnd(),"\r\n"))
			{
				if (c.Contains("OFFLINE") || c.Contains("List of ") || !c.Contains(":")) { continue; }

				n.Clear();
				var port = Regex.Split(c, "	")[0];
				foreach (string v in arg)
				{
					p.StartInfo.Arguments = String.Format("-s {0} shell getprop {1}",port , v);
					p.Start();
					n.Add( p.StandardOutput.ReadToEnd());
					
				}
				ls_dv.Items.Add(port+" # "+ String.Join(" - ", n));
			}
		}

		private void bt_add_Click(object sender, EventArgs e)
		{
			Add_Display_Size d = new Add_Display_Size();
			d.ShowDialog();

			AVDDC_Load(null, null);
		}

		private void bt_rm_Click(object sender, EventArgs e)
		{
			ls_ds.Items.RemoveAt(ls_ds.SelectedIndex);
		
				File.WriteAllLines(path,ls_ds.Items.OfType<string>().ToArray());
		}

		private void bt_rst_Click(object sender, EventArgs e)
		{
			wm( "reset");
		}

		private void bt_set_Click(object sender, EventArgs e)
		{
			if (ls_ds.SelectedItem == null) { MessageBox.Show("Please choose device and display size"); return; }
			wm( ls_ds.SelectedItem.ToString());
		}

		private void wm(string dimen)
		{
			if (ls_dv.SelectedItem == null ) { return; }
			var port = Regex.Split(ls_dv.SelectedItem.ToString(), " # ")[0];
			
			p.StartInfo.Arguments = String.Format("-s {0} shell wm size {1}",port,dimen);
			p.Start();
		}
	}
}
