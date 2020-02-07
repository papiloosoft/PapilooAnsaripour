using System.Globalization;

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
	public partial class Rtl_Date
	{
		private bool InstanceFieldsInitialized = false;

		public Rtl_Date()
		{
			if (!InstanceFieldsInitialized)
			{
				InitializeInstanceFields();
				InstanceFieldsInitialized = true;
			}

			InitializeComponent();
		}

			private void InitializeInstanceFields()
			{
				rtl = new RTLMonthCalendar();
			}

		private Popup popup;
		[System.Runtime.CompilerServices.AccessedThroughProperty(nameof(rtl))]
		private RTLMonthCalendar _rtl;
		private RTLMonthCalendar rtl
		{
			[System.Diagnostics.DebuggerNonUserCode]
			get
			{
				return _rtl;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized), System.Diagnostics.DebuggerNonUserCode]
			set
			{
				if (_rtl != null)
				{
					_rtl.AfterClicked -= rtl_AfterClicked;
				}

				_rtl = value;

				if (value != null)
				{
					_rtl.AfterClicked += rtl_AfterClicked;
				}
			}
		}
		public string T_D
		{
			get
			{
				return S_Date.Text;
			}
			set
			{
				S_Date.Text = value;
			}
		}
		private void rtl_AfterClicked()
		{
			S_Date.Text = rtl.FarsiDate;
			popup.close();
		}
		private void T_Date_Click(System.Object sender, System.EventArgs e)
		{
			popup = new Popup(rtl, T_Date);
			popup.Show();
		}
		private void S_Date_TextChanged(System.Object sender, System.EventArgs e)
		{
//INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal, range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
//			Select Case S_Date.Text.Length
//ORIGINAL LINE: Case 4
			if (S_Date.Text.Length == 4)
			{
					S_Date.Text += "/";
					S_Date.SelectionStart = S_Date.Text.Length + 1;
			}
//ORIGINAL LINE: Case 7
			else if (S_Date.Text.Length == 7)
			{
					S_Date.Text += "/";
					S_Date.SelectionStart = S_Date.Text.Length + 1;
			}
//ORIGINAL LINE: Case 10
			else if (S_Date.Text.Length == 10)
			{
					if (!data.Is_date(S_Date.Text))
					{
						modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " تاریخ وارد شده معتبر نمی باشد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
						S_Date.Text = "";
						S_Date.Focus();
					}
			}
//ORIGINAL LINE: Case Is > 10
			else if (S_Date.Text.Length > 10)
			{
					modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " تاریخ وارد شده معتبر نمی باشد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
					S_Date.Text = "";
					S_Date.Focus();
			}
		}
	}

}