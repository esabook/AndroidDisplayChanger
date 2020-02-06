namespace AVD_display_changer
{
	partial class AVDDC
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ch_adb = new System.Windows.Forms.CheckBox();
			this.tx_adbLocation = new System.Windows.Forms.TextBox();
			this.od = new System.Windows.Forms.OpenFileDialog();
			this.bt_openAdbLocation = new System.Windows.Forms.Button();
			this.ls_ds = new System.Windows.Forms.ListBox();
			this.bt_rm = new System.Windows.Forms.Button();
			this.bt_add = new System.Windows.Forms.Button();
			this.bt_set = new System.Windows.Forms.Button();
			this.bt_rst = new System.Windows.Forms.Button();
			this.p = new System.Diagnostics.Process();
			this.tip = new System.Windows.Forms.ToolTip(this.components);
			this.ls_dv = new System.Windows.Forms.ListBox();
			this.bt_rfs = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ch_adb
			// 
			this.ch_adb.AutoSize = true;
			this.ch_adb.Location = new System.Drawing.Point(27, 29);
			this.ch_adb.Name = "ch_adb";
			this.ch_adb.Size = new System.Drawing.Size(15, 14);
			this.ch_adb.TabIndex = 0;
			this.tip.SetToolTip(this.ch_adb, "Check this if prefer using ADB file has choosen in right form.");
			this.ch_adb.UseVisualStyleBackColor = true;
			this.ch_adb.CheckedChanged += new System.EventHandler(this.ch_customADB);
			// 
			// tx_adbLocation
			// 
			this.tx_adbLocation.Location = new System.Drawing.Point(48, 26);
			this.tx_adbLocation.Name = "tx_adbLocation";
			this.tx_adbLocation.ReadOnly = true;
			this.tx_adbLocation.Size = new System.Drawing.Size(300, 20);
			this.tx_adbLocation.TabIndex = 1;
			this.tx_adbLocation.Tag = "";
			this.tx_adbLocation.Text = "Choose other ADB location if you want.";
			this.tip.SetToolTip(this.tx_adbLocation, "If colored green that mean default ADB file on system path available.");
			// 
			// od
			// 
			this.od.FileName = "adb";
			this.od.Filter = "adb.exe|*.exe";
			this.od.Title = "Select ADB executable file";
			// 
			// bt_openAdbLocation
			// 
			this.bt_openAdbLocation.Location = new System.Drawing.Point(354, 26);
			this.bt_openAdbLocation.Name = "bt_openAdbLocation";
			this.bt_openAdbLocation.Size = new System.Drawing.Size(96, 20);
			this.bt_openAdbLocation.TabIndex = 2;
			this.bt_openAdbLocation.Text = "BROWSE ADB";
			this.bt_openAdbLocation.UseVisualStyleBackColor = true;
			this.bt_openAdbLocation.Click += new System.EventHandler(this.bt_openAdbLocation_Click);
			// 
			// ls_ds
			// 
			this.ls_ds.FormattingEnabled = true;
			this.ls_ds.Location = new System.Drawing.Point(28, 174);
			this.ls_ds.Name = "ls_ds";
			this.ls_ds.Size = new System.Drawing.Size(320, 82);
			this.ls_ds.TabIndex = 5;
			// 
			// bt_rm
			// 
			this.bt_rm.Location = new System.Drawing.Point(355, 218);
			this.bt_rm.Name = "bt_rm";
			this.bt_rm.Size = new System.Drawing.Size(95, 38);
			this.bt_rm.TabIndex = 6;
			this.bt_rm.Text = "REMOVE";
			this.bt_rm.UseVisualStyleBackColor = true;
			this.bt_rm.Click += new System.EventHandler(this.bt_rm_Click);
			// 
			// bt_add
			// 
			this.bt_add.Location = new System.Drawing.Point(355, 174);
			this.bt_add.Name = "bt_add";
			this.bt_add.Size = new System.Drawing.Size(95, 38);
			this.bt_add.TabIndex = 7;
			this.bt_add.Text = "ADD";
			this.bt_add.UseVisualStyleBackColor = true;
			this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
			// 
			// bt_set
			// 
			this.bt_set.Location = new System.Drawing.Point(130, 293);
			this.bt_set.Name = "bt_set";
			this.bt_set.Size = new System.Drawing.Size(320, 42);
			this.bt_set.TabIndex = 8;
			this.bt_set.Text = "SET";
			this.bt_set.UseVisualStyleBackColor = true;
			this.bt_set.Click += new System.EventHandler(this.bt_set_Click);
			// 
			// bt_rst
			// 
			this.bt_rst.Location = new System.Drawing.Point(28, 293);
			this.bt_rst.Name = "bt_rst";
			this.bt_rst.Size = new System.Drawing.Size(96, 42);
			this.bt_rst.TabIndex = 9;
			this.bt_rst.Text = "RESET";
			this.bt_rst.UseVisualStyleBackColor = true;
			this.bt_rst.Click += new System.EventHandler(this.bt_rst_Click);
			// 
			// p
			// 
			this.p.StartInfo.Arguments = "version";
			this.p.StartInfo.CreateNoWindow = true;
			this.p.StartInfo.Domain = "";
			this.p.StartInfo.FileName = "adb.exe";
			this.p.StartInfo.LoadUserProfile = false;
			this.p.StartInfo.Password = null;
			this.p.StartInfo.RedirectStandardOutput = true;
			this.p.StartInfo.StandardErrorEncoding = null;
			this.p.StartInfo.StandardOutputEncoding = null;
			this.p.StartInfo.UserName = "";
			this.p.StartInfo.UseShellExecute = false;
			this.p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			this.p.SynchronizingObject = this;
			// 
			// ls_dv
			// 
			this.ls_dv.FormattingEnabled = true;
			this.ls_dv.HorizontalScrollbar = true;
			this.ls_dv.Location = new System.Drawing.Point(27, 81);
			this.ls_dv.Name = "ls_dv";
			this.ls_dv.Size = new System.Drawing.Size(321, 56);
			this.ls_dv.TabIndex = 10;
			// 
			// bt_rfs
			// 
			this.bt_rfs.Location = new System.Drawing.Point(355, 81);
			this.bt_rfs.Name = "bt_rfs";
			this.bt_rfs.Size = new System.Drawing.Size(95, 56);
			this.bt_rfs.TabIndex = 11;
			this.bt_rfs.Text = "REFRESH";
			this.bt_rfs.UseVisualStyleBackColor = true;
			this.bt_rfs.Click += new System.EventHandler(this.bt_rfs_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Device target:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Display size:";
			// 
			// AVDDC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 363);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bt_rfs);
			this.Controls.Add(this.ls_dv);
			this.Controls.Add(this.bt_rst);
			this.Controls.Add(this.bt_set);
			this.Controls.Add(this.bt_add);
			this.Controls.Add(this.bt_rm);
			this.Controls.Add(this.ls_ds);
			this.Controls.Add(this.bt_openAdbLocation);
			this.Controls.Add(this.tx_adbLocation);
			this.Controls.Add(this.ch_adb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AVDDC";
			this.Text = "AVD Display Changer";
			this.Load += new System.EventHandler(this.AVDDC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox ch_adb;
		private System.Windows.Forms.TextBox tx_adbLocation;
		private System.Windows.Forms.OpenFileDialog od;
		private System.Windows.Forms.Button bt_openAdbLocation;
		private System.Windows.Forms.ListBox ls_ds;
		private System.Windows.Forms.Button bt_rm;
		private System.Windows.Forms.Button bt_add;
		private System.Windows.Forms.Button bt_set;
		private System.Windows.Forms.Button bt_rst;
		private System.Diagnostics.Process p;
		private System.Windows.Forms.ToolTip tip;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bt_rfs;
		private System.Windows.Forms.ListBox ls_dv;
	}
}

