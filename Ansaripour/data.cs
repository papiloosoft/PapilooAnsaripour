using System;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;

internal static partial class data
{
    public static int no = new int();
    public static DialogResult result = new DialogResult();
    public static DataSet PDataset(string select_statement)
    {
        var _con = new System.Data.SqlClient.SqlConnection();
        _con.ConnectionString = GetConnectionString();
        var ad = new System.Data.SqlClient.SqlDataAdapter(select_statement, _con);
        var ds = new DataSet();
        ad.Fill(ds);
        _con.Close();
        return ds;
    }
    public static string GetConnectionString()
    {
        // سرور شرکت آب و فاضلاب استان سمنان
        // Return "Data Source=172.17.9.23;Initial Catalog=Amval;Integrated Security=false;User ID=sa;Password=amval@1262371732"
        // سرور شرکت آب و فاضلاب استان گلستان
        // Return "Data Source=192.168.20.16;Initial Catalog=Papiloo;Integrated Security=false;User ID=sa;Password=ama@1262371732"
        // سرور هتل گوتکه مال
        // Return "Data Source=192.168.20.24;Initial Catalog=AMA;Integrated Security=false;User ID=Sa;Password=ama@1262371732"
        // Local
        return "Data Source=a3;Initial Catalog=Papiloo;Integrated Security=false;User ID=sa;Password=1262371732";
    }
    public static string Is_Number(string sender)
    {
        try
        {
            sender = sender.Split(' ').Where(f => Information.IsNumeric(f)).FirstOrDefault();
        }
        catch (Exception ex)
        {
            sender = ex.Message;
        }
        return sender;
    }
    public static string Is_Char(string sender)
    {
        try
        {
            sender = sender.Split('-').Where(f => !Information.IsNumeric(f)).FirstOrDefault();
        }
        catch (Exception ex)
        {
            sender = ex.Message;
        }
        return sender.Trim();
    }
    public static bool Is_date(string sender)
    {
        bool Is_dateRet = default(bool);
        try
        {
            var Date_Sh = new PersianCalendar();
            var Date_M = Date_Sh.ToDateTime(Conversions.ToInteger(sender.Substring(0, 4)), Conversions.ToInteger(sender.Substring(5, 2)), Conversions.ToInteger(sender.Substring(8, 2)), 0, 0, 0, 0, PersianCalendar.PersianEra);
            Is_dateRet = true;
        }
        catch (Exception ex)
        {
            Is_dateRet = false;
        }

        return Is_dateRet;
    }
    public static bool Is_Time(string sender)
    {
        bool Is_TimeRet = default(bool);
        DateTime d;
        try
        {
            DateTime.TryParseExact(sender, "HH:mm", null, DateTimeStyles.NoCurrentDateDefault, out d);
            Is_TimeRet = true;
        }
        catch (Exception ex)
        {
            Is_TimeRet = false;
        }

        return Is_TimeRet;
    }
    public static string Diff_Time(string Time1, string Time2)
    {
        string A, B, C, D, E;
        string strHrsString, strMinsString;
        try
        {
            A = Strings.Mid(Time1, 1, 2); // جدا سازی2  رقم  ساعت 
            B = Strings.Mid(Time1, 4, 5); // جدا سازی 2 رقم  دقیقه 
            // ------------------------------------------------- 
            C = Strings.Mid(Time2, 1, 2); // جدا سازی2  رقم  ساعت 
            D = Strings.Mid(Time2, 4, 5); // جدا سازی 2 رقم  دقیقه 
            // ------------------------------------------------- 
            // *********************** 
            strHrsString = Conversions.ToString(Conversion.Val(C) - Conversion.Val(A));
            strMinsString = Conversions.ToString(Conversion.Val(D) - Conversion.Val(B));
            switch (Strings.Len(Strings.Trim(strHrsString.ToString())))
            {
                case 1:
                    {
                        E = "0" + strHrsString.ToString();
                        break;
                    }

                default:
                    {
                        E = strHrsString.ToString();
                        break;
                    }
            }
            switch (Strings.Len(Strings.Trim(strMinsString.ToString())))
            {
                case 1:
                    {
                        E = E + ":" + "0" + strMinsString.ToString();
                        break;
                    }

                default:
                    {
                        E = E + ":" + strMinsString.ToString();
                        break;
                    }
            }
        }
        catch (Exception ex)
        {
            E = Conversions.ToString(-1000000);
        }
        return E;
    }
    public static string today()
    {
        string todayRet = default(string);
        var jc = new PersianCalendar();
        string FarsiYear;
        string FarsiMonth;
        string FarsiDay;
        FarsiYear = jc.GetYear(DateTime.Now).ToString();
        FarsiMonth = jc.GetMonth(DateTime.Now).ToString();
        FarsiDay = jc.GetDayOfMonth(DateTime.Now).ToString();
        todayRet = FarsiYear + "/" + string.Format(Conversion.Val(FarsiMonth), "00") + "/" + string.Format(Conversion.Val(FarsiDay), "00");
        return todayRet;
    }
    public static string Add_day(string day)
    {
        string Add_dayRet = default(string);
        var jc = new PersianCalendar();
        string FarsiYear;
        string FarsiMonth;
        string FarsiDay;
        FarsiYear = jc.GetYear(DateTime.Now).ToString();
        FarsiMonth = jc.GetMonth(DateTime.Now).ToString();
        FarsiDay = Conversions.ToString(Conversion.Val(jc.GetDayOfMonth(DateTime.Now).ToString()) + Conversion.Val(day));
        Add_dayRet = FarsiYear + "/" + string.Format(Conversion.Val(FarsiMonth), "00") + "/" + string.Format(Conversion.Val(FarsiDay), "00");
        return Add_dayRet;
    }
    public static string Next_Month()
    {
        string Next_MonthRet = default(string);
        var jc = new PersianCalendar();
        string FarsiYear;
        string FarsiMonth;
        string FarsiDay;
        FarsiYear = jc.GetYear(DateTime.Now).ToString();
        FarsiMonth = jc.GetMonth(DateTime.Now).ToString();
        FarsiDay = jc.GetDayOfMonth(DateTime.Now).ToString();
        Next_MonthRet = FarsiYear + "/" + string.Format(Convert.Val(FarsiMonth) + 1, "00") + "/" + string.Format(Conversion.Val(FarsiDay), "00");
        return Next_MonthRet;
    }
    public static int date_diff_persian(string d1, string d2)
    {
        string y, m, d, r;
        var g = new PersianCalendar();
        DateTime in_date1, in_date2;
        try
        {
            y = string.Left(d1, 4); // جدا سازی 4 رقم عدد سال 
            m = string.Mid(d1, 6, 2); // جدا سازی دو رقم عدد ماه 
            d = string.Right(d1, 2); // جدا سازی 2 رقم عدد روز 
            // ------------------------------------------------- 
            in_date1 = g.ToDateTime(Conversions.ToInteger(Conversion.Val(y)), Conversions.ToInteger(Conversion.Val(m)), Conversions.ToInteger(Conversion.Val(d)), 0, 0, 0, 0);
            // ********************** 
            y = Strings.Left(d2, 4); // جدا سازی 4 رقم عدد سال 
            m = Strings.Mid(d2, 6, 2); // جدا سازی دو رقم عدد ماه 
            d = Strings.Right(d2, 2); // جدا سازی 2 رقم عدد روز 
            // ------------------------------------------------- 
            in_date2 = g.ToDateTime(Conversions.ToInteger(Conversion.Val(y)), Conversions.ToInteger(Conversion.Val(m)), Conversions.ToInteger(Conversion.Val(d)), 0, 0, 0, 0);
            // *********************** 
            r = Conversions.ToString(DateDiff(Microsoft.VisualBasic.DateInterval.Day, in_date1, in_date2));
        }
        catch (Exception ex)
        {
            r = Conversions.ToString(-1000000);
        }
        return r;
    }
    public static object ImageToBase64String(Image image, ImageFormat imageFormat)
    {
        using (var memStream = new MemoryStream())
        {
            image.Save(memStream, imageFormat);
            string result = Convert.ToBase64String(memStream.ToArray());
            memStream.Close();
            return result;
        }
    }
    public static object ImageFromBase64String(string base64)
    {
        using (var memStream = new MemoryStream(Convert.FromBase64String(base64)))
        {
            Image result = Image.FromStream(memStream);
            memStream.Close();
            return result;
        }
    }
    // --------بررسی کردن وصل بودن اینترنت
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





