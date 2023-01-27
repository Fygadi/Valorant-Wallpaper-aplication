namespace Gui_Valorant_Wallper_Changer
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ButtOpenFileExplorer = new System.Windows.Forms.Button();
			this.TxtBoxSelectedPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CheckBoxFolder = new System.Windows.Forms.CheckBox();
			this.CheckBoxFile = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TrackBarTimer = new System.Windows.Forms.TrackBar();
			this.CheckBoxSeconds = new System.Windows.Forms.CheckBox();
			this.CheckBoxMinutes = new System.Windows.Forms.CheckBox();
			this.TxtBoxTimer = new System.Windows.Forms.TextBox();
			this.groupBoxTimer = new System.Windows.Forms.GroupBox();
			this.ButtOkTime = new System.Windows.Forms.Button();
			this.groupBoxWallpaperSelecteur = new System.Windows.Forms.GroupBox();
			this.lblInformation = new System.Windows.Forms.Label();
			this.lblCreatedBy = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.TrackBarTimer)).BeginInit();
			this.groupBoxTimer.SuspendLayout();
			this.groupBoxWallpaperSelecteur.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtOpenFileExplorer
			// 
			this.ButtOpenFileExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.ButtOpenFileExplorer, "ButtOpenFileExplorer");
			this.ButtOpenFileExplorer.Name = "ButtOpenFileExplorer";
			this.ButtOpenFileExplorer.UseVisualStyleBackColor = true;
			this.ButtOpenFileExplorer.Click += new System.EventHandler(this.ButtOpenFileExplorer_Click);
			// 
			// TxtBoxSelectedPath
			// 
			this.TxtBoxSelectedPath.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.TxtBoxSelectedPath, "TxtBoxSelectedPath");
			this.TxtBoxSelectedPath.Name = "TxtBoxSelectedPath";
			this.TxtBoxSelectedPath.ReadOnly = true;
			this.TxtBoxSelectedPath.TabStop = false;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// CheckBoxFolder
			// 
			resources.ApplyResources(this.CheckBoxFolder, "CheckBoxFolder");
			this.CheckBoxFolder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CheckBoxFolder.Name = "CheckBoxFolder";
			this.CheckBoxFolder.UseVisualStyleBackColor = true;
			this.CheckBoxFolder.Click += new System.EventHandler(this.CheckBoxFolder_Click);
			// 
			// CheckBoxFile
			// 
			resources.ApplyResources(this.CheckBoxFile, "CheckBoxFile");
			this.CheckBoxFile.Checked = true;
			this.CheckBoxFile.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CheckBoxFile.Name = "CheckBoxFile";
			this.CheckBoxFile.UseVisualStyleBackColor = true;
			this.CheckBoxFile.Click += new System.EventHandler(this.CheckBoxFile_Click);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// TrackBarTimer
			// 
			this.TrackBarTimer.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.TrackBarTimer, "TrackBarTimer");
			this.TrackBarTimer.Maximum = 60;
			this.TrackBarTimer.Name = "TrackBarTimer";
			this.TrackBarTimer.TabStop = false;
			this.TrackBarTimer.TickFrequency = 10;
			this.TrackBarTimer.Value = 5;
			this.TrackBarTimer.Scroll += new System.EventHandler(this.TrackBarTimer_Scroll);
			// 
			// CheckBoxSeconds
			// 
			resources.ApplyResources(this.CheckBoxSeconds, "CheckBoxSeconds");
			this.CheckBoxSeconds.Checked = true;
			this.CheckBoxSeconds.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxSeconds.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CheckBoxSeconds.Name = "CheckBoxSeconds";
			this.CheckBoxSeconds.UseVisualStyleBackColor = true;
			this.CheckBoxSeconds.Click += new System.EventHandler(this.checkBoxSeconds_Click);
			// 
			// CheckBoxMinutes
			// 
			resources.ApplyResources(this.CheckBoxMinutes, "CheckBoxMinutes");
			this.CheckBoxMinutes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CheckBoxMinutes.Name = "CheckBoxMinutes";
			this.CheckBoxMinutes.UseVisualStyleBackColor = true;
			this.CheckBoxMinutes.Click += new System.EventHandler(this.checkBoxMinutes_Click);
			// 
			// TxtBoxTimer
			// 
			this.TxtBoxTimer.Cursor = System.Windows.Forms.Cursors.IBeam;
			resources.ApplyResources(this.TxtBoxTimer, "TxtBoxTimer");
			this.TxtBoxTimer.Name = "TxtBoxTimer";
			this.TxtBoxTimer.TextChanged += new System.EventHandler(this.TxtBoxTimer_TextChanged);
			this.TxtBoxTimer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxTimer_KeyDown);
			this.TxtBoxTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxTimer_KeyPress);
			// 
			// groupBoxTimer
			// 
			this.groupBoxTimer.Controls.Add(this.ButtOkTime);
			this.groupBoxTimer.Controls.Add(this.label2);
			this.groupBoxTimer.Controls.Add(this.TxtBoxTimer);
			this.groupBoxTimer.Controls.Add(this.TrackBarTimer);
			this.groupBoxTimer.Controls.Add(this.CheckBoxMinutes);
			this.groupBoxTimer.Controls.Add(this.CheckBoxSeconds);
			resources.ApplyResources(this.groupBoxTimer, "groupBoxTimer");
			this.groupBoxTimer.Name = "groupBoxTimer";
			this.groupBoxTimer.TabStop = false;
			// 
			// ButtOkTime
			// 
			this.ButtOkTime.Cursor = System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.ButtOkTime, "ButtOkTime");
			this.ButtOkTime.Name = "ButtOkTime";
			this.ButtOkTime.UseVisualStyleBackColor = true;
			this.ButtOkTime.Click += new System.EventHandler(this.ButtOkTime_Click);
			// 
			// groupBoxWallpaperSelecteur
			// 
			this.groupBoxWallpaperSelecteur.Controls.Add(this.TxtBoxSelectedPath);
			this.groupBoxWallpaperSelecteur.Controls.Add(this.ButtOpenFileExplorer);
			this.groupBoxWallpaperSelecteur.Controls.Add(this.CheckBoxFile);
			this.groupBoxWallpaperSelecteur.Controls.Add(this.label1);
			this.groupBoxWallpaperSelecteur.Controls.Add(this.CheckBoxFolder);
			resources.ApplyResources(this.groupBoxWallpaperSelecteur, "groupBoxWallpaperSelecteur");
			this.groupBoxWallpaperSelecteur.Name = "groupBoxWallpaperSelecteur";
			this.groupBoxWallpaperSelecteur.TabStop = false;
			// 
			// lblInformation
			// 
			resources.ApplyResources(this.lblInformation, "lblInformation");
			this.lblInformation.Name = "lblInformation";
			// 
			// lblCreatedBy
			// 
			resources.ApplyResources(this.lblCreatedBy, "lblCreatedBy");
			this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.lblCreatedBy.Name = "lblCreatedBy";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblCreatedBy);
			this.Controls.Add(this.lblInformation);
			this.Controls.Add(this.groupBoxWallpaperSelecteur);
			this.Controls.Add(this.groupBoxTimer);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.TrackBarTimer)).EndInit();
			this.groupBoxTimer.ResumeLayout(false);
			this.groupBoxTimer.PerformLayout();
			this.groupBoxWallpaperSelecteur.ResumeLayout(false);
			this.groupBoxWallpaperSelecteur.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button ButtOpenFileExplorer;
		private TextBox TxtBoxSelectedPath;
		private Label label1;
		private CheckBox CheckBoxFolder;
		private CheckBox CheckBoxFile;
		private Label label2;
		private TrackBar TrackBarTimer;
		private CheckBox CheckBoxSeconds;
		private CheckBox CheckBoxMinutes;
		private TextBox TxtBoxTimer;
		private GroupBox groupBoxTimer;
		private GroupBox groupBoxWallpaperSelecteur;
		private Button ButtOkTime;
		private Label lblInformation;
		private Label lblCreatedBy;
	}
}