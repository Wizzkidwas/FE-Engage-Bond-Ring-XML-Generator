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
			emblemComboBox.SelectedIndex = 0;
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
				// Disable C, B and A rank skill and stat boxes
				enableSkillCRankCheckBox.Enabled = false;
				enableSkillBRankCheckBox.Enabled = false;
				enableSkillARankCheckBox.Enabled = false;
				enableSkillCRankCheckBox.Checked = false;
				enableSkillBRankCheckBox.Checked = false;
				enableSkillARankCheckBox.Checked = false;

				cRankHPNumericUpDown.Enabled  = false;
				cRankSTRNumericUpDown.Enabled = false;
				cRankDEXNumericUpDown.Enabled = false;
				cRankSPDNumericUpDown.Enabled = false;
				cRankLCKNumericUpDown.Enabled = false;
				cRankDEFNumericUpDown.Enabled = false;
				cRankMAGNumericUpDown.Enabled = false;
				cRankRESNumericUpDown.Enabled = false;
				cRankMOVNumericUpDown.Enabled = false;
				cRankBLDNumericUpDown.Enabled = false;

				bRankHPNumericUpDown.Enabled  = false;
				bRankSTRNumericUpDown.Enabled = false;
				bRankDEXNumericUpDown.Enabled = false;
				bRankSPDNumericUpDown.Enabled = false;
				bRankLCKNumericUpDown.Enabled = false;
				bRankDEFNumericUpDown.Enabled = false;
				bRankMAGNumericUpDown.Enabled = false;
				bRankRESNumericUpDown.Enabled = false;
				bRankMOVNumericUpDown.Enabled = false;
				bRankBLDNumericUpDown.Enabled = false;

				aRankHPNumericUpDown.Enabled  = false;
				aRankSTRNumericUpDown.Enabled = false;
				aRankDEXNumericUpDown.Enabled = false;
				aRankSPDNumericUpDown.Enabled = false;
				aRankLCKNumericUpDown.Enabled = false;
				aRankDEFNumericUpDown.Enabled = false;
				aRankMAGNumericUpDown.Enabled = false;
				aRankRESNumericUpDown.Enabled = false;
				aRankMOVNumericUpDown.Enabled = false;
				aRankBLDNumericUpDown.Enabled = false;
			}
			else
			{
				// Enable C, B and A rank skill boxes
				enableSkillCRankCheckBox.Enabled = true;
				enableSkillBRankCheckBox.Enabled = true;
				enableSkillARankCheckBox.Enabled = true;

				cRankHPNumericUpDown.Enabled  = true;
				cRankSTRNumericUpDown.Enabled = true;
				cRankDEXNumericUpDown.Enabled = true;
				cRankSPDNumericUpDown.Enabled = true;
				cRankLCKNumericUpDown.Enabled = true;
				cRankDEFNumericUpDown.Enabled = true;
				cRankMAGNumericUpDown.Enabled = true;
				cRankRESNumericUpDown.Enabled = true;
				cRankMOVNumericUpDown.Enabled = true;
				cRankBLDNumericUpDown.Enabled = true;

				bRankHPNumericUpDown.Enabled  = true;
				bRankSTRNumericUpDown.Enabled = true;
				bRankDEXNumericUpDown.Enabled = true;
				bRankSPDNumericUpDown.Enabled = true;
				bRankLCKNumericUpDown.Enabled = true;
				bRankDEFNumericUpDown.Enabled = true;
				bRankMAGNumericUpDown.Enabled = true;
				bRankRESNumericUpDown.Enabled = true;
				bRankMOVNumericUpDown.Enabled = true;
				bRankBLDNumericUpDown.Enabled = true;

				aRankHPNumericUpDown.Enabled  = true;
				aRankSTRNumericUpDown.Enabled = true;
				aRankDEXNumericUpDown.Enabled = true;
				aRankSPDNumericUpDown.Enabled = true;
				aRankLCKNumericUpDown.Enabled = true;
				aRankDEFNumericUpDown.Enabled = true;
				aRankMAGNumericUpDown.Enabled = true;
				aRankRESNumericUpDown.Enabled = true;
				aRankMOVNumericUpDown.Enabled = true;
				aRankBLDNumericUpDown.Enabled = true;
			}
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			string charName		  = nameTextBox.Text.ToString();
			string selectedEmblem = emblemComboBox.SelectedItem.ToString();
			string skillID		  = skillIDTextBox.Text.ToString();

			string jewelRed	  = jewelRedNumericUpDown.Value.ToString();
			string jewelGreen = jewelGreenNumericUpDown.Value.ToString();
			string jewelBlue  = jewelBlueNumericUpDown.Value.ToString();
			string rimRed   = rimRedNumericUpDown.Value.ToString();
			string rimGreen = rimGreenNumericUpDown.Value.ToString();
			string rimBlue  = rimBlueNumericUpDown.Value.ToString();

			string ringModel = "";
			if (fehRingModelCheckBox.Checked)
			{
				ringModel = "Item/Acc/uAcc/ring/Com13/Prefabs/uAcc_ring_Com13";
			}

			string cRankHP  = "0";
			string cRankSTR = "0";
			string cRankDEX = "0";
			string cRankSPD = "0";
			string cRankLCK = "0";
			string cRankDEF = "0";
			string cRankMAG = "0";
			string cRankRES = "0";
			string cRankBLD = "0";
			string cRankMOV = "0";

			string bRankHP  = "0";
			string bRankSTR = "0";
			string bRankDEX = "0";
			string bRankSPD = "0";
			string bRankLCK = "0";
			string bRankDEF = "0";
			string bRankMAG = "0";
			string bRankRES = "0";
			string bRankBLD = "0";
			string bRankMOV = "0";

			string aRankHP  = "0";
			string aRankSTR = "0";
			string aRankDEX = "0";
			string aRankSPD = "0";
			string aRankLCK = "0";
			string aRankDEF = "0";
			string aRankMAG = "0";
			string aRankRES = "0";
			string aRankBLD = "0";
			string aRankMOV = "0";

			if (singleRankCheckBox.Checked == false)
			{
				cRankHP  = cRankHPNumericUpDown.Value.ToString();
				cRankSTR = cRankSTRNumericUpDown.Value.ToString();
				cRankDEX = cRankDEXNumericUpDown.Value.ToString();
				cRankSPD = cRankSPDNumericUpDown.Value.ToString();
				cRankLCK = cRankLCKNumericUpDown.Value.ToString();
				cRankDEF = cRankDEFNumericUpDown.Value.ToString();
				cRankMAG = cRankMAGNumericUpDown.Value.ToString();
				cRankRES = cRankRESNumericUpDown.Value.ToString();
				cRankBLD = cRankBLDNumericUpDown.Value.ToString();
				cRankMOV = cRankMOVNumericUpDown.Value.ToString();
				
				bRankHP  = bRankHPNumericUpDown.Value.ToString();
				bRankSTR = bRankSTRNumericUpDown.Value.ToString();
				bRankDEX = bRankDEXNumericUpDown.Value.ToString();
				bRankSPD = bRankSPDNumericUpDown.Value.ToString();
				bRankLCK = bRankLCKNumericUpDown.Value.ToString();
				bRankDEF = bRankDEFNumericUpDown.Value.ToString();
				bRankMAG = bRankMAGNumericUpDown.Value.ToString();
				bRankRES = bRankRESNumericUpDown.Value.ToString();
				bRankBLD = bRankBLDNumericUpDown.Value.ToString();
				bRankMOV = bRankMOVNumericUpDown.Value.ToString();
				
				aRankHP  = aRankHPNumericUpDown.Value.ToString();
				aRankSTR = aRankSTRNumericUpDown.Value.ToString();
				aRankDEX = aRankDEXNumericUpDown.Value.ToString();
				aRankSPD = aRankSPDNumericUpDown.Value.ToString();
				aRankLCK = aRankLCKNumericUpDown.Value.ToString();
				aRankDEF = aRankDEFNumericUpDown.Value.ToString();
				aRankMAG = aRankMAGNumericUpDown.Value.ToString();
				aRankRES = aRankRESNumericUpDown.Value.ToString();
				aRankBLD = aRankBLDNumericUpDown.Value.ToString();
				aRankMOV = aRankMOVNumericUpDown.Value.ToString();
			}
			
			string sRankHP  = sRankHPNumericUpDown.Value.ToString();
			string sRankSTR = sRankSTRNumericUpDown.Value.ToString();
			string sRankDEX = sRankDEXNumericUpDown.Value.ToString();
			string sRankSPD = sRankSPDNumericUpDown.Value.ToString();
			string sRankLCK = sRankLCKNumericUpDown.Value.ToString();
			string sRankDEF = sRankDEFNumericUpDown.Value.ToString();
			string sRankMAG = sRankMAGNumericUpDown.Value.ToString();
			string sRankRES = sRankRESNumericUpDown.Value.ToString();
			string sRankBLD = sRankBLDNumericUpDown.Value.ToString();
			string sRankMOV = sRankMOVNumericUpDown.Value.ToString();

			string emblemCode;
			string emblemID;
			if (selectedEmblem == "Custom")
			{
				emblemID = customGIDTextBox.Text.ToString();
				emblemCode = customGIDTextBox.Text.ToString();
			}
			else
			{
				emblemID = ParseEmblemID(selectedEmblem);
				emblemCode = ParseEmblemCode(selectedEmblem);
			}


			string sRankText;
			if (singleRankCheckBox.Checked)
			{
				if (enableSkillSRankCheckBox.Checked)
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_S\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"3\" Icon=\"{charName}\" Enhance.Hp=\"{sRankHP}\" Enhance.Str=\"{sRankSTR}\" Enhance.Tech=\"{sRankDEX}\" Enhance.Quick=\"{sRankSPD}\" Enhance.Luck=\"{sRankLCK}\" Enhance.Def=\"{sRankDEF}\" Enhance.Magic=\"{sRankMAG}\" Enhance.Mdef=\"{sRankRES}\" Enhance.Phys=\"{sRankBLD}\" Enhance.Move=\"{sRankMOV}\" EquipSids=\"{skillID}\" IsSingleRank=\"true\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_S\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"3\" Icon=\"{charName}\" Enhance.Hp=\"{sRankHP}\" Enhance.Str=\"{sRankSTR}\" Enhance.Tech=\"{sRankDEX}\" Enhance.Quick=\"{sRankSPD}\" Enhance.Luck=\"{sRankLCK}\" Enhance.Def=\"{sRankDEF}\" Enhance.Magic=\"{sRankMAG}\" Enhance.Mdef=\"{sRankRES}\" Enhance.Phys=\"{sRankBLD}\" Enhance.Move=\"{sRankMOV}\" EquipSids=\"\" IsSingleRank=\"true\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				outputTextBox.Text = sRankText;
			}
			else
			{
				string cRankText;
				string bRankText;
				string aRankText;

				if (enableSkillCRankCheckBox.Checked)
				{
					cRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_C\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"0\" Icon=\"{charName}\" Enhance.Hp=\"{cRankHP}\" Enhance.Str=\"{cRankSTR}\" Enhance.Tech=\"{cRankDEX}\" Enhance.Quick=\"{cRankSPD}\" Enhance.Luck=\"{cRankLCK}\" Enhance.Def=\"{cRankDEF}\" Enhance.Magic=\"{cRankMAG}\" Enhance.Mdef=\"{cRankRES}\" Enhance.Phys=\"{cRankBLD}\" Enhance.Move=\"{cRankMOV}\" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					cRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_C\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"0\" Icon=\"{charName}\" Enhance.Hp=\"{cRankHP}\" Enhance.Str=\"{cRankSTR}\" Enhance.Tech=\"{cRankDEX}\" Enhance.Quick=\"{cRankSPD}\" Enhance.Luck=\"{cRankLCK}\" Enhance.Def=\"{cRankDEF}\" Enhance.Magic=\"{cRankMAG}\" Enhance.Mdef=\"{cRankRES}\" Enhance.Phys=\"{cRankBLD}\" Enhance.Move=\"{cRankMOV}\" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillBRankCheckBox.Checked)
				{
					bRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_B\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"1\" Icon=\"{charName}\" Enhance.Hp=\"{bRankHP}\" Enhance.Str=\"{bRankSTR}\" Enhance.Tech=\"{bRankDEX}\" Enhance.Quick=\"{bRankSPD}\" Enhance.Luck=\"{bRankLCK}\" Enhance.Def=\"{bRankDEF}\" Enhance.Magic=\"{bRankMAG}\" Enhance.Mdef=\"{bRankRES}\" Enhance.Phys=\"{bRankBLD}\" Enhance.Move=\"{bRankMOV}\" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					bRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_B\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"1\" Icon=\"{charName}\" Enhance.Hp=\"{bRankHP}\" Enhance.Str=\"{bRankSTR}\" Enhance.Tech=\"{bRankDEX}\" Enhance.Quick=\"{bRankSPD}\" Enhance.Luck=\"{bRankLCK}\" Enhance.Def=\"{bRankDEF}\" Enhance.Magic=\"{bRankMAG}\" Enhance.Mdef=\"{bRankRES}\" Enhance.Phys=\"{bRankBLD}\" Enhance.Move=\"{bRankMOV}\" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillARankCheckBox.Checked)
				{
					aRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_A\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"2\" Icon=\"{charName}\" Enhance.Hp=\"{aRankHP}\" Enhance.Str=\"{aRankSTR}\" Enhance.Tech=\"{aRankDEX}\" Enhance.Quick=\"{aRankSPD}\" Enhance.Luck=\"{aRankLCK}\" Enhance.Def=\"{aRankDEF}\" Enhance.Magic=\"{aRankMAG}\" Enhance.Mdef=\"{aRankRES}\" Enhance.Phys=\"{aRankBLD}\" Enhance.Move=\"{aRankMOV}\" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					aRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_A\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"2\" Icon=\"{charName}\" Enhance.Hp=\"{aRankHP}\" Enhance.Str=\"{aRankSTR}\" Enhance.Tech=\"{aRankDEX}\" Enhance.Quick=\"{aRankSPD}\" Enhance.Luck=\"{aRankLCK}\" Enhance.Def=\"{aRankDEF}\" Enhance.Magic=\"{aRankMAG}\" Enhance.Mdef=\"{aRankRES}\" Enhance.Phys=\"{aRankBLD}\" Enhance.Move=\"{aRankMOV}\" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillSRankCheckBox.Checked)
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_S\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"3\" Icon=\"{charName}\" Enhance.Hp=\"{sRankHP}\" Enhance.Str=\"{sRankSTR}\" Enhance.Tech=\"{sRankDEX}\" Enhance.Quick=\"{sRankSPD}\" Enhance.Luck=\"{sRankLCK}\" Enhance.Def=\"{sRankDEF}\" Enhance.Magic=\"{sRankMAG}\" Enhance.Mdef=\"{sRankRES}\" Enhance.Phys=\"{sRankBLD}\" Enhance.Move=\"{sRankMOV}\" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}_S\" Name=\"MID_BONDSRING_{charName}\" Help=\"MID_BONDSRING_H_{charName}\" Gid=\"GID_{emblemID}\" RingModel=\"{ringModel}\" Rank=\"3\" Icon=\"{charName}\" Enhance.Hp=\"{sRankHP}\" Enhance.Str=\"{sRankSTR}\" Enhance.Tech=\"{sRankDEX}\" Enhance.Quick=\"{sRankSPD}\" Enhance.Luck=\"{sRankLCK}\" Enhance.Def=\"{sRankDEF}\" Enhance.Magic=\"{sRankMAG}\" Enhance.Mdef=\"{sRankRES}\" Enhance.Phys=\"{sRankBLD}\" Enhance.Move=\"{sRankMOV}\" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				outputTextBox.Text = cRankText + "\n" + bRankText + "\n" + aRankText + "\n" + sRankText;
			}
		}

		private void jewelColourButton_Click(object sender, EventArgs e)
		{
			if (jewelColourDialog.ShowDialog() == DialogResult.OK)
			{
				jewelRedNumericUpDown.Value		= jewelColourDialog.Color.R;
				jewelGreenNumericUpDown.Value	= jewelColourDialog.Color.G;
				jewelBlueNumericUpDown.Value	= jewelColourDialog.Color.B;
				jewelColourPictureBox.BackColor = jewelColourDialog.Color;
			}			
		}

		private void jewelRedNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetJewelColourBoxColour((int)jewelRedNumericUpDown.Value, (int)jewelGreenNumericUpDown.Value, (int)jewelBlueNumericUpDown.Value);
		}

		private void jewelGreenNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetJewelColourBoxColour((int)jewelRedNumericUpDown.Value, (int)jewelGreenNumericUpDown.Value, (int)jewelBlueNumericUpDown.Value);
		}

		private void jewelBlueNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetJewelColourBoxColour((int)jewelRedNumericUpDown.Value, (int)jewelGreenNumericUpDown.Value, (int)jewelBlueNumericUpDown.Value);
		}

		private void rimColourButton_Click(object sender, EventArgs e)
		{
			if (rimColourDialog.ShowDialog() == DialogResult.OK)
			{	
				rimRedNumericUpDown.Value	  = rimColourDialog.Color.R;
				rimGreenNumericUpDown.Value   = rimColourDialog.Color.G;
				rimBlueNumericUpDown.Value	  = rimColourDialog.Color.B;
				rimColourPictureBox.BackColor = rimColourDialog.Color;
			}
		}

		private void rimRedNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetRimColourBoxColour((int)rimRedNumericUpDown.Value, (int)rimGreenNumericUpDown.Value, (int)rimBlueNumericUpDown.Value);
		}

		private void rimGreenNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetRimColourBoxColour((int)rimRedNumericUpDown.Value, (int)rimGreenNumericUpDown.Value, (int)rimBlueNumericUpDown.Value);
		}

		private void rimBlueNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetRimColourBoxColour((int)rimRedNumericUpDown.Value, (int)rimGreenNumericUpDown.Value, (int)rimBlueNumericUpDown.Value);
		}

		private void resetStatsButton_Click(object sender, EventArgs e)
		{
			cRankHPNumericUpDown.Value  = 0;
			cRankSTRNumericUpDown.Value = 0;
			cRankDEXNumericUpDown.Value = 0;
			cRankSPDNumericUpDown.Value = 0;
			cRankLCKNumericUpDown.Value = 0;
			cRankDEFNumericUpDown.Value = 0;
			cRankMAGNumericUpDown.Value = 0;
			cRankRESNumericUpDown.Value = 0;
			cRankBLDNumericUpDown.Value = 0;
			cRankMOVNumericUpDown.Value = 0;

			bRankHPNumericUpDown.Value  = 0;
			bRankSTRNumericUpDown.Value = 0;
			bRankDEXNumericUpDown.Value = 0;
			bRankSPDNumericUpDown.Value = 0;
			bRankLCKNumericUpDown.Value = 0;
			bRankDEFNumericUpDown.Value = 0;
			bRankMAGNumericUpDown.Value = 0;
			bRankRESNumericUpDown.Value = 0;
			bRankBLDNumericUpDown.Value = 0;
			bRankMOVNumericUpDown.Value = 0;

			aRankHPNumericUpDown.Value  = 0;
			aRankSTRNumericUpDown.Value = 0;
			aRankDEXNumericUpDown.Value = 0;
			aRankSPDNumericUpDown.Value = 0;
			aRankLCKNumericUpDown.Value = 0;
			aRankDEFNumericUpDown.Value = 0;
			aRankMAGNumericUpDown.Value = 0;
			aRankRESNumericUpDown.Value = 0;
			aRankBLDNumericUpDown.Value = 0;
			aRankMOVNumericUpDown.Value = 0;

			sRankHPNumericUpDown.Value  = 0;
			sRankSTRNumericUpDown.Value = 0;
			sRankDEXNumericUpDown.Value = 0;
			sRankSPDNumericUpDown.Value = 0;
			sRankLCKNumericUpDown.Value = 0;
			sRankDEFNumericUpDown.Value = 0;
			sRankMAGNumericUpDown.Value = 0;
			sRankRESNumericUpDown.Value = 0;
			sRankBLDNumericUpDown.Value = 0;
			sRankMOVNumericUpDown.Value = 0;
		}

		private string ParseEmblemID(string emblemName)
		{
			switch (emblemName)
			{
				case "Marth":
					return "マルス";
				case "Celica":
					return "セリカ";
				case "Sigurd":
					return "シグルド";
				case "Leif":
					return "リーフ";
				case "Roy":
					return "ロイ";
				case "Lyn":
					return "リン";
				case "Eirika":
					return "エイリーク";
				case "Ike":
					return "アイク";
				case "Micaiah":
					return "ミカヤ";
				case "Lucina":
					return "ルキナ";
				case "Corrin":
					return "カムイ";
				case "Byleth":
					return "ベレト";
				case "Alear":
					return "リュール";
				case "Tiki":
					return "チキ";
				case "Hector":
					return "ヘクトル";
				case "Soren":
					return "セネリオ";
				case "Chrom":
					return "クロム";
				case "Camilla":
					return "カミラ";
				case "Veronica":
					return "ヴェロニカ";
				case "3 Houses":
					return "エーデルガルト";
				default:
					return "ERROR";
			}
		}

		private string ParseEmblemCode(string emblemName)
		{
			switch (emblemName)
			{
				case "Marth":
					return "紋章";
				case "Celica":
					return "外伝";
				case "Sigurd":
					return "聖戦";
				case "Leif":
					return "トラキア";
				case "Roy":
					return "封印";
				case "Lyn":
					return "烈火";
				case "Eirika":
					return "聖魔";
				case "Ike":
					return "蒼炎";
				case "Micaiah":
					return "暁";
				case "Lucina":
					return "覚醒";
				case "Corrin":
					return "IF";
				case "Byleth":
					return "風花";
				case "Alear":
					return "Engage";
				case "Tiki":
					return "紋章";
				case "Hector":
					return "烈火";
				case "Soren":
					return "蒼炎";
				case "Chrom":
					return "覚醒";
				case "Camilla":
					return "IF";
				case "Veronica":
					return "Heroes";
				case "3 Houses":
					return "風花";
				default:
					return "ERROR";
			}
		}

		private void SetJewelColourBoxColour(int R, int G, int B)
		{
			jewelColourPictureBox.BackColor = Color.FromArgb(R, G, B);
		}

		private void SetRimColourBoxColour(int R, int G, int B)
		{
			rimColourPictureBox.BackColor = Color.FromArgb(R, G, B);
		}

		private void copyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(outputTextBox.Text);
		}

		private void singleRankEnableDisableThread_DoWork(object sender, DoWorkEventArgs e, bool check)
		{
			if (check)
			{
				// Disable C, B and A rank skill and stat boxes
				enableSkillCRankCheckBox.Enabled = false;
				enableSkillBRankCheckBox.Enabled = false;
				enableSkillARankCheckBox.Enabled = false;
				enableSkillCRankCheckBox.Checked = false;
				enableSkillBRankCheckBox.Checked = false;
				enableSkillARankCheckBox.Checked = false;

				cRankHPNumericUpDown.Enabled  = false;
				cRankSTRNumericUpDown.Enabled = false;
				cRankDEXNumericUpDown.Enabled = false;
				cRankSPDNumericUpDown.Enabled = false;
				cRankLCKNumericUpDown.Enabled = false;
				cRankDEFNumericUpDown.Enabled = false;
				cRankMAGNumericUpDown.Enabled = false;
				cRankRESNumericUpDown.Enabled = false;
				cRankMOVNumericUpDown.Enabled = false;
				cRankBLDNumericUpDown.Enabled = false;

				bRankHPNumericUpDown.Enabled  = false;
				bRankSTRNumericUpDown.Enabled = false;
				bRankDEXNumericUpDown.Enabled = false;
				bRankSPDNumericUpDown.Enabled = false;
				bRankLCKNumericUpDown.Enabled = false;
				bRankDEFNumericUpDown.Enabled = false;
				bRankMAGNumericUpDown.Enabled = false;
				bRankRESNumericUpDown.Enabled = false;
				bRankMOVNumericUpDown.Enabled = false;
				bRankBLDNumericUpDown.Enabled = false;

				aRankHPNumericUpDown.Enabled  = false;
				aRankSTRNumericUpDown.Enabled = false;
				aRankDEXNumericUpDown.Enabled = false;
				aRankSPDNumericUpDown.Enabled = false;
				aRankLCKNumericUpDown.Enabled = false;
				aRankDEFNumericUpDown.Enabled = false;
				aRankMAGNumericUpDown.Enabled = false;
				aRankRESNumericUpDown.Enabled = false;
				aRankMOVNumericUpDown.Enabled = false;
				aRankBLDNumericUpDown.Enabled = false;
			}
			else
			{
				// Enable C, B and A rank skill boxes
				enableSkillCRankCheckBox.Enabled = true;
				enableSkillBRankCheckBox.Enabled = true;
				enableSkillARankCheckBox.Enabled = true;

				cRankHPNumericUpDown.Enabled  = true;
				cRankSTRNumericUpDown.Enabled = true;
				cRankDEXNumericUpDown.Enabled = true;
				cRankSPDNumericUpDown.Enabled = true;
				cRankLCKNumericUpDown.Enabled = true;
				cRankDEFNumericUpDown.Enabled = true;
				cRankMAGNumericUpDown.Enabled = true;
				cRankRESNumericUpDown.Enabled = true;
				cRankMOVNumericUpDown.Enabled = true;
				cRankBLDNumericUpDown.Enabled = true;

				bRankHPNumericUpDown.Enabled  = true;
				bRankSTRNumericUpDown.Enabled = true;
				bRankDEXNumericUpDown.Enabled = true;
				bRankSPDNumericUpDown.Enabled = true;
				bRankLCKNumericUpDown.Enabled = true;
				bRankDEFNumericUpDown.Enabled = true;
				bRankMAGNumericUpDown.Enabled = true;
				bRankRESNumericUpDown.Enabled = true;
				bRankMOVNumericUpDown.Enabled = true;
				bRankBLDNumericUpDown.Enabled = true;

				aRankHPNumericUpDown.Enabled  = true;
				aRankSTRNumericUpDown.Enabled = true;
				aRankDEXNumericUpDown.Enabled = true;
				aRankSPDNumericUpDown.Enabled = true;
				aRankLCKNumericUpDown.Enabled = true;
				aRankDEFNumericUpDown.Enabled = true;
				aRankMAGNumericUpDown.Enabled = true;
				aRankRESNumericUpDown.Enabled = true;
				aRankMOVNumericUpDown.Enabled = true;
				aRankBLDNumericUpDown.Enabled = true;
			}
		}
	}
}
