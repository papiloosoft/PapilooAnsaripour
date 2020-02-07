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
	public sealed partial class AboutBox1
	{
		public AboutBox1()
		{
			InitializeComponent();
		}

		private void AboutBox1_Load(object sender, System.EventArgs e)
		{
			Label2.Text = "کد سیستم جهت فعال سازی نرم افزار " + HDDSerialL.SerialNumber().ToString().Replace("-", "") + "B1358A11M17A";
		}
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
            MDIParent1 mdiparent = new MDIParent1();
            if (TextBox1.Text == "6a5m6a2" + (NumericHelper.Val(HDDSerialL.SerialNumber().ToString().Replace("-","")) - 999999).ToString())
			{
				//قانونی کردن برنامه
				DataSet update = data.PDataset("UPDATE  R_S  SET   D_R='" + (NumericHelper.Val(HDDSerialL.SerialNumber().ToString().Replace("-", "")) + 131113581117) + "'");
				modMessage.ShowMessage("کاربر محترم" + " :" + mdiparent.I_N.Text, "سیستم با تمام امکانات در اختیار شماست", frmMessage.mIcon.munlock, frmMessage.mButtons.mAccept);
				this.Close();
                mdiparent.Today_Date.Text = data.today();
                mdiparent.Information.Text = "<---------------------------->" + "(( برنامه مکانیزه الماس بصورت قانونی فعال شده است و کلیه امکانات در اختیار کاربر می باشد ))";
                mdiparent.System_Activation_Menu.Visible = false;
			}
			else
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + mdiparent.I_N.Text, "در وارد کردن کد سیستم خود دقت نمائید ", frmMessage.mIcon.mlock, frmMessage.mButtons.mAccept);
			}
		}
	}


}