//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace Ansaripour
{
	public partial class H_Serch
	{
		public H_Serch()
		{
			InitializeComponent();
		}

		private string f_serch; //تابع متغیر فرمول جستجو
		private string fh_serch; //تابع متغیر فرمول جستجو
		private string maText;
		private string mbText;
		private string mcText;
		private string mdText;
		private string meText;
		private string mfText;
		private string mgText;
		private string mhText;
		private string miText;
		private string mmText;
		private string mnText;
		private string mOText;
		private string mPText;
		private string mLText;
		private string mSText;
		public void ConfigForm(string ATitle, string BTitle, string CTitle, string AText, string BText, string CText, string DText, string EText, string FText, string GText, string HText, string IText, string MText, string NText, string OText, string PText, string LText, string SText)
		{
			this.Text = ATitle;
			BTi.Text = BTitle;
			CTi.Text = CTitle;
			maText = AText;
			mbText = BText;
			mcText = CText;
			mdText = DText;
			meText = EText;
			mfText = FText;
			mgText = GText;
			mhText = HText;
			miText = IText;
			mmText = MText;
			mnText = NText;
			mOText = OText;
			mPText = PText;
			mLText = LText;
			mSText = SText;
		}
		private void Dv_Get()
		{
			Dv.Rows.Clear();
			Dv.Columns.Clear();
			Dv.Columns.Add("row", "ردیف");
			Dv.Columns.Add("mcText", BTi.Text);
			Dv.Columns.Add("mbText", CTi.Text);
			Dv.Columns.Add("Way", "");
			Dv.Columns.Add("Acc_level", "");
			Dv.Columns.Add("meText", "");
			Dv.Columns.Add("mfText", "");
			Dv.Columns.Add("mgText", "");
			Dv.Columns.Add("mhText", "");
			Dv.Columns.Add("miText", "");
			Dv.Columns.Add("mmText", "");
			Dv.Columns.Add("mnText", "");
			Dv.Columns["row"].Width = 50;
			Dv.Columns["mcText"].Width = 100;
			Dv.Columns["mbText"].Width = 365;
			Dv.Columns["Way"].Visible = false;
			Dv.Columns["Acc_level"].Visible = false;
			Dv.Columns["meText"].Visible = false;
			Dv.Columns["mfText"].Visible = false;
			Dv.Columns["mgText"].Visible = false;
			Dv.Columns["mhText"].Visible = false;
			Dv.Columns["miText"].Visible = false;
			Dv.Columns["mmText"].Visible = false;
			Dv.Columns["mnText"].Visible = false;
			Dv.AllowUserToAddRows = false;
			Dv.EditMode = DataGridViewEditMode.EditProgrammatically;
		}
		private void B_Serch_Click(System.Object sender, System.EventArgs e)
		{
			Dv_Get();
			f_serch = "";
			if (S_Hesab.Text.Length != 0)
			{
				f_serch += " and " + mbText + " LIKE  N'%" + S_Hesab.Text + "%'";
			}
			if (C_Hesab.Text.Length != 0)
			{
				f_serch += " and " + mcText + " LIKE  N'%" + C_Hesab.Text + "%'";
			}
			if (MDIParent1.DefaultInstance.N_Admin.Text == "False" && mgText.Length != 0)
			{
				f_serch += " and " + mgText + " ='" + MDIParent1.DefaultInstance.N_Id_Area.Text + "'";
			}
			 if (mmText.Length != 0)
			 {
				 f_serch += " and " + mmText + " ='" + mnText + "'";
			 }
			if (mOText.Length != 0)
			{
				f_serch += " and " + mOText + " =" + mPText + " ";
			}
			if (mLText.Length != 0)
			{
				f_serch += " and " + mLText + " =" + mSText + " ";
			}
			f_serch = Microsoft.VisualBasic.Strings.Replace(f_serch, "and", "", 1, 1);
			if (string.IsNullOrEmpty(f_serch))
			{
				this.Cursor = Cursors.Default;
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "موردي براي جستجو مشخص نشده است", frmMessage.mIcon.mzoom, frmMessage.mButtons.mAccept);
				return;
			}
			if (mdText.Length == 0)
			{

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
