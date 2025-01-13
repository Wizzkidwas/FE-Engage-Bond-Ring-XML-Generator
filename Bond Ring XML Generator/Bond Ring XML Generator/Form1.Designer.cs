
namespace Bond_Ring_XML_Generator
{
	partial class Form1
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
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBoxLabel = new System.Windows.Forms.Label();
			this.emblemSelectLabel = new System.Windows.Forms.Label();
			this.customGIDLabel = new System.Windows.Forms.Label();
			this.customGIDTextBox = new System.Windows.Forms.TextBox();
			this.emblemComboBox = new System.Windows.Forms.ComboBox();
			this.singleRankCheckBox = new System.Windows.Forms.CheckBox();
			this.outputTextBox = new System.Windows.Forms.RichTextBox();
			this.outputLabel = new System.Windows.Forms.Label();
			this.skillIDLabel = new System.Windows.Forms.Label();
			this.skillIDTextBox = new System.Windows.Forms.TextBox();
			this.enableSkillCRankCheckBox = new System.Windows.Forms.CheckBox();
			this.gIDToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.enableSkillBRankCheckBox = new System.Windows.Forms.CheckBox();
			this.enableSkillARankCheckBox = new System.Windows.Forms.CheckBox();
			this.enableSkillSRankCheckBox = new System.Windows.Forms.CheckBox();
			this.skillGroupBox = new System.Windows.Forms.GroupBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.skillGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(103, 10);
			this.nameTextBox.MaxLength = 30;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(147, 20);
			this.nameTextBox.TabIndex = 0;
			// 
			// nameTextBoxLabel
			// 
			this.nameTextBoxLabel.AutoSize = true;
			this.nameTextBoxLabel.Location = new System.Drawing.Point(13, 13);
			this.nameTextBoxLabel.Name = "nameTextBoxLabel";
			this.nameTextBoxLabel.Size = new System.Drawing.Size(87, 13);
			this.nameTextBoxLabel.TabIndex = 1;
			this.nameTextBoxLabel.Text = "Character Name:";
			// 
			// emblemSelectLabel
			// 
			this.emblemSelectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.emblemSelectLabel.AutoSize = true;
			this.emblemSelectLabel.Location = new System.Drawing.Point(478, 13);
			this.emblemSelectLabel.Name = "emblemSelectLabel";
			this.emblemSelectLabel.Size = new System.Drawing.Size(47, 13);
			this.emblemSelectLabel.TabIndex = 2;
			this.emblemSelectLabel.Text = "Emblem:";
			// 
			// customGIDLabel
			// 
			this.customGIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.customGIDLabel.AutoSize = true;
			this.customGIDLabel.Location = new System.Drawing.Point(479, 45);
			this.customGIDLabel.Name = "customGIDLabel";
			this.customGIDLabel.Size = new System.Drawing.Size(67, 13);
			this.customGIDLabel.TabIndex = 5;
			this.customGIDLabel.Text = "Custom GID:";
			this.gIDToolTip.SetToolTip(this.customGIDLabel, "\"GID\" refers to the internal ID of the emblem used in the XML files. \nDo not incl" +
        "ude the \"GID_\" in the text box.");
			// 
			// customGIDTextBox
			// 
			this.customGIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.customGIDTextBox.Enabled = false;
			this.customGIDTextBox.Location = new System.Drawing.Point(552, 42);
			this.customGIDTextBox.MaxLength = 30;
			this.customGIDTextBox.Name = "customGIDTextBox";
			this.customGIDTextBox.Size = new System.Drawing.Size(220, 20);
			this.customGIDTextBox.TabIndex = 6;
			this.gIDToolTip.SetToolTip(this.customGIDTextBox, "\"GID\" refers to the internal ID of the emblem used in the XML files. \nDo not incl" +
        "ude the \"GID_\" in the text box.");
			// 
			// emblemComboBox
			// 
			this.emblemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.emblemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.emblemComboBox.FormattingEnabled = true;
			this.emblemComboBox.Items.AddRange(new object[] {
            "Marth",
            "Celica",
            "Sigurd",
            "Leif",
            "Roy",
            "Lyn",
            "Eirika",
            "Ike",
            "Micaiah",
            "Lucina",
            "Corrin",
            "Byleth",
            "Alear",
            "Tiki",
            "Hector",
            "Soren",
            "Chrom",
            "Camilla",
            "Veronica",
            "3 Houses",
            "Custom"});
			this.emblemComboBox.Location = new System.Drawing.Point(528, 10);
			this.emblemComboBox.Name = "emblemComboBox";
			this.emblemComboBox.Size = new System.Drawing.Size(244, 21);
			this.emblemComboBox.TabIndex = 7;
			this.emblemComboBox.SelectedIndexChanged += new System.EventHandler(this.emblemComboBox_SelectedIndexChanged);
			// 
			// singleRankCheckBox
			// 
			this.singleRankCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.singleRankCheckBox.AutoSize = true;
			this.singleRankCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.singleRankCheckBox.Location = new System.Drawing.Point(479, 70);
			this.singleRankCheckBox.Name = "singleRankCheckBox";
			this.singleRankCheckBox.Size = new System.Drawing.Size(101, 17);
			this.singleRankCheckBox.TabIndex = 8;
			this.singleRankCheckBox.Text = "Is Single Rank?";
			this.singleRankCheckBox.UseVisualStyleBackColor = true;
			this.singleRankCheckBox.CheckedChanged += new System.EventHandler(this.singleRankCheckBox_CheckedChanged);
			// 
			// outputTextBox
			// 
			this.outputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.outputTextBox.DetectUrls = false;
			this.outputTextBox.Location = new System.Drawing.Point(16, 482);
			this.outputTextBox.Name = "outputTextBox";
			this.outputTextBox.ReadOnly = true;
			this.outputTextBox.Size = new System.Drawing.Size(756, 67);
			this.outputTextBox.TabIndex = 9;
			this.outputTextBox.Text = "";
			this.outputTextBox.WordWrap = false;
			// 
			// outputLabel
			// 
			this.outputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(16, 463);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(39, 13);
			this.outputLabel.TabIndex = 10;
			this.outputLabel.Text = "Output";
			// 
			// skillIDLabel
			// 
			this.skillIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.skillIDLabel.AutoSize = true;
			this.skillIDLabel.Location = new System.Drawing.Point(7, 23);
			this.skillIDLabel.Name = "skillIDLabel";
			this.skillIDLabel.Size = new System.Drawing.Size(43, 13);
			this.skillIDLabel.TabIndex = 12;
			this.skillIDLabel.Text = "Skill ID:";
			// 
			// skillIDTextBox
			// 
			this.skillIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.skillIDTextBox.Location = new System.Drawing.Point(56, 20);
			this.skillIDTextBox.MaxLength = 40;
			this.skillIDTextBox.Name = "skillIDTextBox";
			this.skillIDTextBox.Size = new System.Drawing.Size(212, 20);
			this.skillIDTextBox.TabIndex = 11;
			// 
			// enableSkillCRankCheckBox
			// 
			this.enableSkillCRankCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.enableSkillCRankCheckBox.AutoSize = true;
			this.enableSkillCRankCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.enableSkillCRankCheckBox.Location = new System.Drawing.Point(7, 44);
			this.enableSkillCRankCheckBox.Name = "enableSkillCRankCheckBox";
			this.enableSkillCRankCheckBox.Size = new System.Drawing.Size(141, 17);
			this.enableSkillCRankCheckBox.TabIndex = 13;
			this.enableSkillCRankCheckBox.Text = "Enable Skill for C Rank?";
			this.enableSkillCRankCheckBox.UseVisualStyleBackColor = true;
			// 
			// gIDToolTip
			// 
			this.gIDToolTip.AutomaticDelay = 100;
			this.gIDToolTip.AutoPopDelay = 99999999;
			this.gIDToolTip.InitialDelay = 100;
			this.gIDToolTip.ReshowDelay = 20;
			// 
			// enableSkillBRankCheckBox
			// 
			this.enableSkillBRankCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.enableSkillBRankCheckBox.AutoSize = true;
			this.enableSkillBRankCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.enableSkillBRankCheckBox.Location = new System.Drawing.Point(7, 67);
			this.enableSkillBRankCheckBox.Name = "enableSkillBRankCheckBox";
			this.enableSkillBRankCheckBox.Size = new System.Drawing.Size(141, 17);
			this.enableSkillBRankCheckBox.TabIndex = 14;
			this.enableSkillBRankCheckBox.Text = "Enable Skill for B Rank?";
			this.enableSkillBRankCheckBox.UseVisualStyleBackColor = true;
			// 
			// enableSkillARankCheckBox
			// 
			this.enableSkillARankCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.enableSkillARankCheckBox.AutoSize = true;
			this.enableSkillARankCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.enableSkillARankCheckBox.Location = new System.Drawing.Point(7, 90);
			this.enableSkillARankCheckBox.Name = "enableSkillARankCheckBox";
			this.enableSkillARankCheckBox.Size = new System.Drawing.Size(141, 17);
			this.enableSkillARankCheckBox.TabIndex = 15;
			this.enableSkillARankCheckBox.Text = "Enable Skill for A Rank?";
			this.enableSkillARankCheckBox.UseVisualStyleBackColor = true;
			// 
			// enableSkillSRankCheckBox
			// 
			this.enableSkillSRankCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.enableSkillSRankCheckBox.AutoSize = true;
			this.enableSkillSRankCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.enableSkillSRankCheckBox.Checked = true;
			this.enableSkillSRankCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableSkillSRankCheckBox.Location = new System.Drawing.Point(7, 113);
			this.enableSkillSRankCheckBox.Name = "enableSkillSRankCheckBox";
			this.enableSkillSRankCheckBox.Size = new System.Drawing.Size(141, 17);
			this.enableSkillSRankCheckBox.TabIndex = 16;
			this.enableSkillSRankCheckBox.Text = "Enable Skill for S Rank?";
			this.enableSkillSRankCheckBox.UseVisualStyleBackColor = true;
			// 
			// skillGroupBox
			// 
			this.skillGroupBox.Controls.Add(this.enableSkillSRankCheckBox);
			this.skillGroupBox.Controls.Add(this.enableSkillARankCheckBox);
			this.skillGroupBox.Controls.Add(this.enableSkillBRankCheckBox);
			this.skillGroupBox.Controls.Add(this.skillIDTextBox);
			this.skillGroupBox.Controls.Add(this.enableSkillCRankCheckBox);
			this.skillGroupBox.Controls.Add(this.skillIDLabel);
			this.skillGroupBox.Location = new System.Drawing.Point(472, 93);
			this.skillGroupBox.Name = "skillGroupBox";
			this.skillGroupBox.Size = new System.Drawing.Size(300, 146);
			this.skillGroupBox.TabIndex = 17;
			this.skillGroupBox.TabStop = false;
			this.skillGroupBox.Text = "Skill";
			// 
			// generateButton
			// 
			this.generateButton.Location = new System.Drawing.Point(697, 453);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(75, 23);
			this.generateButton.TabIndex = 18;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.singleRankCheckBox);
			this.Controls.Add(this.outputTextBox);
			this.Controls.Add(this.emblemComboBox);
			this.Controls.Add(this.customGIDTextBox);
			this.Controls.Add(this.customGIDLabel);
			this.Controls.Add(this.emblemSelectLabel);
			this.Controls.Add(this.nameTextBoxLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.skillGroupBox);
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Form1";
			this.Text = "FE Engage Bond Ring XML Generator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.skillGroupBox.ResumeLayout(false);
			this.skillGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameTextBoxLabel;
		private System.Windows.Forms.Label emblemSelectLabel;
		private System.Windows.Forms.Label customGIDLabel;
		private System.Windows.Forms.TextBox customGIDTextBox;
		private System.Windows.Forms.ComboBox emblemComboBox;
		private System.Windows.Forms.CheckBox singleRankCheckBox;
		private System.Windows.Forms.RichTextBox outputTextBox;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.Label skillIDLabel;
		private System.Windows.Forms.TextBox skillIDTextBox;
		private System.Windows.Forms.CheckBox enableSkillCRankCheckBox;
		private System.Windows.Forms.ToolTip gIDToolTip;
		private System.Windows.Forms.CheckBox enableSkillBRankCheckBox;
		private System.Windows.Forms.CheckBox enableSkillARankCheckBox;
		private System.Windows.Forms.CheckBox enableSkillSRankCheckBox;
		private System.Windows.Forms.GroupBox skillGroupBox;
		private System.Windows.Forms.Button generateButton;
	}
}

