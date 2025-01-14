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

				cRankHPNumericUpDown.Enabled = false;
				cRankSTRNumericUpDown.Enabled = false;
				cRankDEXNumericUpDown.Enabled = false;
				cRankSPDNumericUpDown.Enabled = false;
				cRankLCKNumericUpDown.Enabled = false;
				cRankDEFNumericUpDown.Enabled = false;
				cRankMAGNumericUpDown.Enabled = false;
				cRankRESNumericUpDown.Enabled = false;
				cRankMOVNumericUpDown.Enabled = false;
				cRankBLDNumericUpDown.Enabled = false;

				bRankHPNumericUpDown.Enabled = false;
				bRankSTRNumericUpDown.Enabled = false;
				bRankDEXNumericUpDown.Enabled = false;
				bRankSPDNumericUpDown.Enabled = false;
				bRankLCKNumericUpDown.Enabled = false;
				bRankDEFNumericUpDown.Enabled = false;
				bRankMAGNumericUpDown.Enabled = false;
				bRankRESNumericUpDown.Enabled = false;
				bRankMOVNumericUpDown.Enabled = false;
				bRankBLDNumericUpDown.Enabled = false;

				aRankHPNumericUpDown.Enabled = false;
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

				cRankHPNumericUpDown.Enabled = true;
				cRankSTRNumericUpDown.Enabled = true;
				cRankDEXNumericUpDown.Enabled = true;
				cRankSPDNumericUpDown.Enabled = true;
				cRankLCKNumericUpDown.Enabled = true;
				cRankDEFNumericUpDown.Enabled = true;
				cRankMAGNumericUpDown.Enabled = true;
				cRankRESNumericUpDown.Enabled = true;
				cRankMOVNumericUpDown.Enabled = true;
				cRankBLDNumericUpDown.Enabled = true;

				bRankHPNumericUpDown.Enabled = true;
				bRankSTRNumericUpDown.Enabled = true;
				bRankDEXNumericUpDown.Enabled = true;
				bRankSPDNumericUpDown.Enabled = true;
				bRankLCKNumericUpDown.Enabled = true;
				bRankDEFNumericUpDown.Enabled = true;
				bRankMAGNumericUpDown.Enabled = true;
				bRankRESNumericUpDown.Enabled = true;
				bRankMOVNumericUpDown.Enabled = true;
				bRankBLDNumericUpDown.Enabled = true;

				aRankHPNumericUpDown.Enabled = true;
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
			// TO-DO: Get RGB Values for jewel and rim

			string charName		  = nameTextBox.Text.ToString();
			string selectedEmblem = emblemComboBox.SelectedItem.ToString();
			string skillID		  = skillIDTextBox.Text.ToString();

			string jewelRed	  = jewelRedNumericUpDown.Value.ToString();
			string jewelGreen = jewelGreenNumericUpDown.Value.ToString();
			string jewelBlue  = jewelBlueNumericUpDown.Value.ToString();
			string rimRed   = rimRedNumericUpDown.Value.ToString();
			string rimGreen = rimGreenNumericUpDown.Value.ToString();
			string rimBlue  = rimBlueNumericUpDown.Value.ToString();

			// maybe change to int?
			// Figure out how to assign the right stats based on primary, secondary and tertiary
			string HP  = "0";
			string Str = "0";
			string Dex = "0";
			string Spd = "0";
			string Lck = "0";
			string Def = "0";
			string Mag = "0";
			string Res = "0";
			string Bld = "0";
			string Mov = "0";


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


			if (singleRankCheckBox.Checked)
			{
				string sRankText;
				if (enableSkillSRankCheckBox.Checked)
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_S\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"3\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"true\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_S\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"3\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"true\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				outputTextBox.Text = sRankText;
			}
			else
			{
				string cRankText;
				string bRankText;
				string aRankText;
				string sRankText;

				if (enableSkillCRankCheckBox.Checked)
				{
					cRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_C\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"0\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					cRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_C\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"0\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillBRankCheckBox.Checked)
				{
					bRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_B\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"1\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					bRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_B\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"1\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillARankCheckBox.Checked)
				{
					aRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_A\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"2\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					aRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_A\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"2\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillSRankCheckBox.Checked)
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_S\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"3\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_S\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"3\" Icon=\"{charName}\" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
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
					return "チキ";
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

				cRankHPNumericUpDown.Enabled = false;
				cRankSTRNumericUpDown.Enabled = false;
				cRankDEXNumericUpDown.Enabled = false;
				cRankSPDNumericUpDown.Enabled = false;
				cRankLCKNumericUpDown.Enabled = false;
				cRankDEFNumericUpDown.Enabled = false;
				cRankMAGNumericUpDown.Enabled = false;
				cRankRESNumericUpDown.Enabled = false;
				cRankMOVNumericUpDown.Enabled = false;
				cRankBLDNumericUpDown.Enabled = false;

				bRankHPNumericUpDown.Enabled = false;
				bRankSTRNumericUpDown.Enabled = false;
				bRankDEXNumericUpDown.Enabled = false;
				bRankSPDNumericUpDown.Enabled = false;
				bRankLCKNumericUpDown.Enabled = false;
				bRankDEFNumericUpDown.Enabled = false;
				bRankMAGNumericUpDown.Enabled = false;
				bRankRESNumericUpDown.Enabled = false;
				bRankMOVNumericUpDown.Enabled = false;
				bRankBLDNumericUpDown.Enabled = false;

				aRankHPNumericUpDown.Enabled = false;
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

				cRankHPNumericUpDown.Enabled = true;
				cRankSTRNumericUpDown.Enabled = true;
				cRankDEXNumericUpDown.Enabled = true;
				cRankSPDNumericUpDown.Enabled = true;
				cRankLCKNumericUpDown.Enabled = true;
				cRankDEFNumericUpDown.Enabled = true;
				cRankMAGNumericUpDown.Enabled = true;
				cRankRESNumericUpDown.Enabled = true;
				cRankMOVNumericUpDown.Enabled = true;
				cRankBLDNumericUpDown.Enabled = true;

				bRankHPNumericUpDown.Enabled = true;
				bRankSTRNumericUpDown.Enabled = true;
				bRankDEXNumericUpDown.Enabled = true;
				bRankSPDNumericUpDown.Enabled = true;
				bRankLCKNumericUpDown.Enabled = true;
				bRankDEFNumericUpDown.Enabled = true;
				bRankMAGNumericUpDown.Enabled = true;
				bRankRESNumericUpDown.Enabled = true;
				bRankMOVNumericUpDown.Enabled = true;
				bRankBLDNumericUpDown.Enabled = true;

				aRankHPNumericUpDown.Enabled = true;
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
