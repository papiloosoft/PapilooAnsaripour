//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System;
using System.Globalization;

namespace Ansaripour
{
	public partial class RTLMonthCalendar
	{
		private bool InstanceFieldsInitialized = false;

		public RTLMonthCalendar()
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
				_FarsiDate = M2S(DateTime.Now);
			}

		private int _SelectedDay;
		private DateTime _ThisDate = DateTime.Now;
		private string _FarsiDate;
		private System.Windows.Forms.Label lblToday = null;
		public delegate void AfterClickedEventHandler();
		public event AfterClickedEventHandler AfterClicked;
		public object SelectedDay
		{
			get
			{
				return _SelectedDay;
			}
			set
			{
				_SelectedDay = Convert.ToInt32(value);
			}
		}
		public DateTime ThisDate
		{
			get
			{
				return _ThisDate;
			}
			set
			{
				_ThisDate = value;
				_FarsiDate = M2S(_ThisDate);
				SelectedDay = _FarsiDate.Substring(8, 2);
				FillThisMonth();
			}
		}
		public string FarsiDate
		{
			get
			{
				return _FarsiDate;
			}
		}
		public DateTime S2M(string ConvDate)
		{
			PersianCalendar jc = new PersianCalendar();
			return jc.ToDateTime(Convert.ToInt32(ConvDate.Substring(0, 4)), Convert.ToInt32(ConvDate.Substring(5, 2)), Convert.ToInt32(ConvDate.Substring(8, 2)), 1, 1, 1, 1);
		}
		public string M2S(DateTime ConvDate)
		{
			PersianCalendar jc = new PersianCalendar();
			string FarsiYear = null;
			string FarsiMonth = null;
			string FarsiDay = null;
			FarsiYear = jc.GetYear(ConvDate).ToString();
			FarsiMonth = jc.GetMonth(ConvDate).ToString();
			FarsiDay = jc.GetDayOfMonth(ConvDate).ToString();
			return FarsiYear + "/" + NumericHelper.Val(FarsiMonth).ToString("00") + "/" + NumericHelper.Val(FarsiDay).ToString("00");
		}
		public void Today()
		{
			PersianCalendar jc = new PersianCalendar();
			string FarsiYear = null;
			string FarsiMonth = null;
			string FarsiDay = null;
			string ConvDate = null;
			FarsiYear = jc.GetYear(DateTime.Now).ToString();
			FarsiMonth = jc.GetMonth(DateTime.Now).ToString();
			FarsiDay = jc.GetDayOfMonth(DateTime.Now).ToString();
			ConvDate = FarsiYear + "/" + NumericHelper.Val(FarsiMonth).ToString("00") + "/" + NumericHelper.Val(FarsiDay).ToString("00");
			lblTodayTitle.Text = "امروز : " + ConvDate;
			ThisDate = DateTime.Now;
			lblToday = SelectDay(Convert.ToInt32(FarsiDay));
		}
		private void ClearAllSelection()
		{
			int i = 0;
			for (i = 1; i <= 42; i++)
			{
				if (this.Controls["lblday" + i].BackColor == Color.Blue)
				{
					this.Controls["lblday" + i].BackColor = Color.White;
				}
				if (!(((System.Windows.Forms.Label)this.Controls["lblday" + i]).Image == null))
				{
					((System.Windows.Forms.Label)this.Controls["lblday" + i]).Image = null;
				}
			}
		}
		public void ClearSelection()
		{
			string ControlName = FindControlIndex(Convert.ToString(SelectedDay));
			if (!string.IsNullOrEmpty(ControlName))
			{
				((Label)this.Controls[ControlName]).Image = null;
				((Label)this.Controls[ControlName]).ForeColor = Color.Black;
				((Label)this.Controls[ControlName]).BackColor = Color.White;
			}
		}
		public System.Windows.Forms.Label SelectDay(int TFarsiDay, bool GrayForeColor = false)
		{
			System.Windows.Forms.Label tempSelectDay = null;
			string ControlName = null;
			int No = 0;
			string FarsiYear = null;
			string FarsiMonth = null;
			string FarsiDay = null;
			FarsiYear = _FarsiDate.ToString().Substring(0, 4);
			FarsiMonth = _FarsiDate.ToString().Substring(5, 2);
			FarsiDay = _FarsiDate.ToString().Substring(8, 2);
			ControlName = FindControlIndex(TFarsiDay.ToString(), GrayForeColor);
			tempSelectDay = (Label)this.Controls[ControlName];
			if (tempSelectDay.ForeColor == Color.LightGray)
			{
				No = Convert.ToInt32(((Label)tempSelectDay).Name.Substring(6));
				if (No > 7)
				{
					btnNextMonth_Click(new object(), new System.EventArgs());
					if (FarsiMonth == "12")
					{
						FarsiYear = FarsiYear + 1;
						FarsiMonth = "1";
					}

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
