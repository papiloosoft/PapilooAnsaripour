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
	public partial class Rtl_Time
	{
		public Rtl_Time()
		{
			InitializeComponent();
		}

		public string T_Text
		{
			get
			{
				return S_Time.Text;
			}
			set
			{
				S_Time.Text = value;
			}
		}
		private void S_Time_Leave(object sender, System.EventArgs e)
		{
			//If S_Time.Text.Length <> 5 Then
			//    ShowMessage("کاربر محترم" & " :" & MDIParent1.I_N.Text, " زمان وارد شده معتبر نمی باشد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept)
			//    S_Time.Text = ""
			//    S_Time.Focus()
			//End If
		}
		private void S_Time_TextChanged(object sender, System.EventArgs e)
		{
			//Dim d As Date
			//If S_Time.Text.Length = 5 And Not Date.TryParseExact(S_Time.Text, "HH:mm", Nothing, Globalization.DateTimeStyles.NoCurrentDateDefault, d) Then
			//    ShowMessage("کاربر محترم" & " :" & MDIParent1.I_N.Text, " زمان وارد شده معتبر نمی باشد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept)
			//    S_Time.Text = ""
			//    S_Time.Focus()
			//End If
			if (S_Time.Text.Length == 5 && !DateHelper.IsDate(S_Time.Text))
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " زمان وارد شده معتبر نمی باشد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
				S_Time.Text = "";
				S_Time.Focus();
			}
		}
	}

}