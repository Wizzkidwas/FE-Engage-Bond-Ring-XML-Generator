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
			// TO-DO: Get RGB Values for jewel and rim

			string charName = nameTextBox.Text.ToString();
			string selectedEmblem = emblemComboBox.SelectedItem.ToString();
			string emblemCode;
			string skillID = skillIDTextBox.Text.ToString();

			// Maybe change to int?
			string jewelRed = "0";
			string jewelGreen = "0";
			string jewelBlue = "0";
			string rimRed = "0";
			string rimGreen = "0";
			string rimBlue = "0";

			// maybe change to int?
			// Figure out how to assign the right stats based on primary, secondary and tertiary
			string HP = "0";
			string Str = "0";
			string Dex = "0";
			string Spd = "0";
			string Lck = "0";
			string Def = "0";
			string Mag = "0";
			string Res = "0";
			string Bld = "0";
			string Mov = "0";


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
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_S\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"3\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"true\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_S\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"3\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"true\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
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
					cRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_C\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"0\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					cRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_C\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"0\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillBRankCheckBox.Checked)
				{
					bRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_B\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"1\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					bRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_B\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"1\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillARankCheckBox.Checked)
				{
					aRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_A\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"2\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					aRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_A\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"2\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				if (enableSkillSRankCheckBox.Checked)
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_S\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"3\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"{skillID}\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}
				else
				{
					sRankText = $"<Param Out=\"\" Rnid=\"RNID_{emblemCode}_{charName}\" Name=\"MID_BONDSRING_{charName}_S\" Help=\"MID_BONDSRING_H_{charName}_S\" Gid=\"GID_{emblemID}\" RingModel=\"\" Rank=\"3\" Icon=\" \" Enhance.Hp=\" \" Enhance.Str=\" \" Enhance.Tech=\" \" Enhance.Quick=\" \" Enhance.Luck=\" \" Enhance.Def=\" \" Enhance.Magic=\" \" Enhance.Mdef=\" \" Enhance.Phys=\" \" Enhance.Move=\" \" EquipSids=\"\" IsSingleRank=\"false\" JewelColorR=\"{jewelRed}\" JewelColorG=\"{jewelGreen}\" JewelColorB=\"{jewelBlue}\" RimColorR=\"{rimRed}\" RimColorG=\"{rimGreen}\" RimColorB=\"{rimBlue}\" />";
				}

				outputTextBox.Text = cRankText + "\n" + bRankText + "\n" + aRankText + "\n" + sRankText;
			}
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
	}
}
