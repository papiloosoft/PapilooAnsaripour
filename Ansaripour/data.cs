
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
            return FarsiYear + "/" + NumericHelper.Val(FarsiMonth).ToString("00") + "/" + NumericHelper.Val(FarsiDay).ToString("00");
        }
        public static string Add_day(string day)
        {
            PersianCalendar jc = new PersianCalendar();
            string FarsiYear = null;
            string FarsiMonth = null;
            string FarsiDay = null;
            FarsiYear = jc.GetYear(DateTime.Now).ToString();
            FarsiMonth = jc.GetMonth(DateTime.Now).ToString();
            FarsiDay = (NumericHelper.Val(jc.GetDayOfMonth(DateTime.Now).ToString()) + NumericHelper.Val(day)).ToString();
            return FarsiYear + "/" + NumericHelper.Val(FarsiMonth).ToString("00") + "/" + NumericHelper.Val(FarsiDay).ToString("00");
        }
        public static string Next_Month()
        {
            PersianCalendar jc = new PersianCalendar();
            string FarsiYear = null;
            string FarsiMonth = null;
            string FarsiDay = null;
            FarsiYear = jc.GetYear(DateTime.Now).ToString();
            FarsiMonth = jc.GetMonth(DateTime.Now).ToString();
            FarsiDay = jc.GetDayOfMonth(DateTime.Now).ToString();
            return FarsiYear + "/" + (NumericHelper.Val(FarsiMonth) + 1).ToString("00") + "/" + NumericHelper.Val(FarsiDay).ToString("00");
        }
        public static int date_diff_persian(string d1, string d2)
        {
            string y = null;
            string m = null;
            string d = null;
            string r = null;
            System.Globalization.PersianCalendar g = new System.Globalization.PersianCalendar();
            DateTime in_date1 = default(DateTime);
            DateTime in_date2 = default(DateTime);
            try
            {
                y = d1.Substring(0, 4); //جدا سازی 4 رقم عدد سال
                m = d1.Substring(5, 2); //جدا سازی دو رقم عدد ماه
                d = d1.Substring(d1.Length - 2); //جدا سازی 2 رقم عدد روز
                                                 //------------------------------------------------- 
                in_date1 = g.ToDateTime(Convert.ToInt32(NumericHelper.Val(y)), Convert.ToInt32(NumericHelper.Val(m)), Convert.ToInt32(NumericHelper.Val(d)), 0, 0, 0, 0);
                //********************** 
                y = d2.Substring(0, 4); //جدا سازی 4 رقم عدد سال
                m = d2.Substring(5, 2); //جدا سازی دو رقم عدد ماه
                d = d2.Substring(d2.Length - 2); //جدا سازی 2 رقم عدد روز
                                                 //------------------------------------------------- 
                in_date2 = g.ToDateTime(Convert.ToInt32(NumericHelper.Val(y)), Convert.ToInt32(NumericHelper.Val(m)), Convert.ToInt32(NumericHelper.Val(d)), 0, 0, 0, 0);
                //*********************** 
                r = DateHelper.DateDiff(DateHelper.DateInterval.Day, in_date1, in_date2).ToString();
            }
            catch (Exception ex)
            {
                r = "-1000000";
            }
            return Convert.ToInt32(r);
        }
        public static object ImageToBase64String(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                image.Save(memStream, imageFormat);
                string result = Convert.ToBase64String(memStream.ToArray());
                memStream.Close();
                return result;
            }
        }
        public static object ImageFromBase64String(string base64)
        {
            using (MemoryStream memStream = new MemoryStream(Convert.FromBase64String(base64)))
            {
                Image result = Image.FromStream(memStream);
                memStream.Close();
                return result;
            }
        }
        //--------بررسی کردن وصل بودن اینترنت
        public static bool IsInternetConnected()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
            }
            return false;
        }
    }
}
