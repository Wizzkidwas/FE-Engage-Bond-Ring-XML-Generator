using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bond_Ring_XML_Generator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void emblemComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string curItem = emblemComboBox.SelectedItem.ToString();

			if (curItem == "Custom")
			{
				// customGIDLabel.Visible = true;
				// customGIDTextBox.Visible = true;
				customGIDTextBox.Enabled = true;
			}
			else
			{
				// customGIDLabel.Visible = false;
				// customGIDTextBox.Visible = false;
				customGIDTextBox.Enabled = false;
			}
		}

		private void singleRankCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool check = singleRankCheckBox.Checked;

			if (check)
			{
				// Disable C, B and A rank skill boxes
				enableSkillCRankCheckBox.Enabled = false;
				enableSkillBRankCheckBox.Enabled = false;
				enableSkillARankCheckBox.Enabled = false;
				enableSkillCRankCheckBox.Checked = false;
				enableSkillBRankCheckBox.Checked = false;
				enableSkillARankCheckBox.Checked = false;
			}
			else
			{
				// Enable C, B and A rank skill boxes
				enableSkillCRankCheckBox.Enabled = true;
				enableSkillBRankCheckBox.Enabled = true;
				enableSkillARankCheckBox.Enabled = true;
			}
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			// Grab all fields and create the output in the bottom text box

			
			if (singleRankCheckBox.Checked)
			{
				string  sRankText = "<Param Out=\"\" Rnid=\"RNID_ _ \" Name=\"MID_BONDSRING_ _S\" Help=\"MID_BONDSRING_H_ _S\" Gid=\"GID_ \" RingModel=\"\" Rank=\"3\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\" \" IsSingleRank=\"true\" JewelColorR=\" \" JewelColorG=\" \" JewelColorB=\" \" RimColorR=\" \" RimColorG=\" \" RimColorB=\" \" />";
				outputTextBox.Text = sRankText;
			}
			else
			{
				string cRankText = "<Param Out=\"\" Rnid=\"RNID_ _ \" Name=\"MID_BONDSRING_ _C\" Help=\"MID_BONDSRING_H_ _S\" Gid=\"GID_ \" RingModel=\"\" Rank=\"0\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\" \" IsSingleRank=\"false\" JewelColorR=\" \" JewelColorG=\" \" JewelColorB=\" \" RimColorR=\" \" RimColorG=\" \" RimColorB=\" \" />";
				string bRankText = "<Param Out=\"\" Rnid=\"RNID_ _ \" Name=\"MID_BONDSRING_ _B\" Help=\"MID_BONDSRING_H_ _S\" Gid=\"GID_ \" RingModel=\"\" Rank=\"1\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\" \" IsSingleRank=\"false\" JewelColorR=\" \" JewelColorG=\" \" JewelColorB=\" \" RimColorR=\" \" RimColorG=\" \" RimColorB=\" \" />";
				string aRankText = "<Param Out=\"\" Rnid=\"RNID_ _ \" Name=\"MID_BONDSRING_ _A\" Help=\"MID_BONDSRING_H_ _S\" Gid=\"GID_ \" RingModel=\"\" Rank=\"2\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\" \" IsSingleRank=\"false\" JewelColorR=\" \" JewelColorG=\" \" JewelColorB=\" \" RimColorR=\" \" RimColorG=\" \" RimColorB=\" \" />";
				string sRankText = "<Param Out=\"\" Rnid=\"RNID_ _ \" Name=\"MID_BONDSRING_ _S\" Help=\"MID_BONDSRING_H_ _S\" Gid=\"GID_ \" RingModel=\"\" Rank=\"3\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\" \" IsSingleRank=\"false\" JewelColorR=\" \" JewelColorG=\" \" JewelColorB=\" \" RimColorR=\" \" RimColorG=\" \" RimColorB=\" \" />";

				outputTextBox.Text = cRankText + "\n" + bRankText + "\n" + aRankText + "\n" + sRankText;
			}
		}
	}
}
