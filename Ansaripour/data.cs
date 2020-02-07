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

using System.Threading;
using System.Globalization;
using System.IO;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Net;

namespace Ansaripour
{
	internal static class data
	{
		public static int no = new int();
		public static DialogResult result = new DialogResult();
		public static DataSet PDataset(string select_statement)
		{
			System.Data.SqlClient.SqlConnection _con = new System.Data.SqlClient.SqlConnection();
			_con.ConnectionString = GetConnectionString();
			System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(select_statement, _con);
			DataSet ds = new DataSet();
			ad.Fill(ds);
			_con.Close();
			return ds;
		}
		public static string GetConnectionString()
		{
			//سرور شرکت آب و فاضلاب استان سمنان
			//Return "Data Source=172.17.9.23;Initial Catalog=Amval;Integrated Security=false;User ID=sa;Password=amval@1262371732"
			//سرور شرکت آب و فاضلاب استان گلستان
			//Return "Data Source=192.168.20.16;Initial Catalog=Papiloo;Integrated Security=false;User ID=sa;Password=ama@1262371732"
			//سرور هتل گوتکه مال
			//Return "Data Source=192.168.20.24;Initial Catalog=AMA;Integrated Security=false;User ID=Sa;Password=ama@1262371732"
			//Local
			return "Data Source=a3;Initial Catalog=Papiloo;Integrated Security=false;User ID=sa;Password=1262371732";
			//نقشین ساز امید
			//Return "Data Source=Papiloo;Initial Catalog=Papiloo;Integrated Security=false;User ID=sa;Password=1262371732"
			//
			//Return "Data Source=(Local);Initial Catalog=Papiloo;Integrated Security=false;User ID=sa;Password=1262371732"
			//
			//Return "Data Source=DESKTOP-NJ2H7SA;Initial Catalog=Papiloo;Integrated Security=false;User ID=sa;Password=Papiloo@8198"
		}
		public static string Is_Number(string sender)
		{
			try
			{
				sender = sender.Split(' ').Where((f) => NumericHelper.IsNumeric(f)).FirstOrDefault();
			}
			catch (Exception ex)
			{
				sender = "0";
			}
			return sender;
		}
		public static string Is_Char(string sender)
		{
			try
			{
				sender = sender.Split('-').Where((f) => !NumericHelper.IsNumeric(f)).FirstOrDefault();
			}
			catch (Exception ex)
			{
				sender = "0";
			}
			return sender.Trim();
		}
		public static bool Is_date(string sender)
		{
			bool tempIs_date = false;
			try
			{
				System.Globalization.PersianCalendar Date_Sh = new System.Globalization.PersianCalendar();
				DateTime Date_M = Date_Sh.ToDateTime(Convert.ToInt32(sender.Substring(0, 4)), Convert.ToInt32(sender.Substring(5, 2)), Convert.ToInt32(sender.Substring(8, 2)), 0, 0, 0, 0, System.Globalization.PersianCalendar.PersianEra);
				tempIs_date = true;
			}
			catch (Exception ex)
			{
				tempIs_date = false;
			}
			return tempIs_date;
		}
		public static bool Is_Time(string sender)
		{
			bool tempIs_Time = false;
			DateTime d = default(DateTime);
			try
			{
				DateTime.TryParseExact(sender, "HH:mm", null, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out d);
				tempIs_Time = true;
			}
			catch (Exception ex)
			{
				tempIs_Time = false;
			}
			return tempIs_Time;
		}
		public static string Diff_Time(string Time1, string Time2)
		{
			string A = null;
			string B = null;
			string C = null;
			string D = null;
			string E = null;
			string strHrsString = null;
			string strMinsString = null;
			try
			{
				A = Time1.Substring(0, 2); //جدا سازی2 رقم ساعت
				B = Time1.Substring(3, 5); //جدا سازی 2 رقم دقیقه
				//------------------------------------------------- 
				C = Time2.Substring(0, 2); //جدا سازی2 رقم ساعت
				D = Time2.Substring(3, 5); //جدا سازی 2 رقم دقیقه
				//------------------------------------------------- 
				//*********************** 
				strHrsString = (NumericHelper.Val(C) - NumericHelper.Val(A)).ToString();
				strMinsString = (NumericHelper.Val(D) - NumericHelper.Val(B)).ToString();
				switch (strHrsString.ToString().Trim(' ').Length)
				{
					case 1:
						E = "0" + strHrsString.ToString();
						break;
					default:
						E = strHrsString.ToString();
						break;
				}
				switch (strMinsString.ToString().Trim(' ').Length)
				{
					case 1:
						E = E + ":" + "0" + strMinsString.ToString();
						break;
					default:
						E = E + ":" + strMinsString.ToString();
						break;
				}
			}
			catch (Exception ex)
			{
				E = "-1000000";
			}
			return E;
		}
		public static string today()
		{
			PersianCalendar jc = new PersianCalendar();
			string FarsiYear = null;
			string FarsiMonth = null;
			string FarsiDay = null;
			FarsiYear = jc.GetYear(DateTime.Now).ToString();
			FarsiMonth = jc.GetMonth(DateTime.Now).ToString();
			FarsiDay = jc.GetDayOfMonth(DateTime.Now).ToString();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
