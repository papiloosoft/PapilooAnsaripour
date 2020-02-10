
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System;

namespace Ansaripour
{
    namespace WT
    {
        public sealed class ToWords
        {
            private static string[] cvtText = new string[1000];
            private static void BuildMapping()
            {
                cvtText[1] = "يک";
                cvtText[2] = "دو";
                cvtText[3] = "سه";
                cvtText[4] = "چهار";
                cvtText[5] = "پنج";
                cvtText[6] = "شش";
                cvtText[7] = "هفت";
                cvtText[8] = "هشت";
                cvtText[9] = "نه";
                cvtText[10] = "ده";
                cvtText[11] = "یازده";
                cvtText[12] = "دوازده";
                cvtText[13] = "سیزده";
                cvtText[14] = "چهارده";
                cvtText[15] = "پانزده";
                cvtText[16] = "شانزده";
                cvtText[17] = "هفده";
                cvtText[18] = "هجده";
                cvtText[19] = "نوزده";
                cvtText[20] = "بيست ";
                cvtText[21] = "سی";
                cvtText[22] = "چهل";
                cvtText[23] = "پنجاه";
                cvtText[24] = "شصت";
                cvtText[25] = "هفتاد";
                cvtText[26] = "هشتاد";
                cvtText[27] = "نود";
                cvtText[28] = "صد";
                cvtText[29] = "هزار";
                cvtText[30] = "میلیون";
                cvtText[31] = "میلیارد";
                cvtText[100] = "صد";
                cvtText[200] = "دویست";
                cvtText[300] = "سیصد";
                cvtText[400] = "چهارصد";
                cvtText[500] = "پانصد";
                cvtText[600] = "ششصد";
                cvtText[700] = "هفتصد";
                cvtText[800] = "هشتصد";
                cvtText[900] = "نهصد";
            }
            private static string cvt100(long Number)
            {
                int x = Convert.ToInt32((int)(Number));
                int t = 0;
                string result = string.Empty;
                if (x > 999)
                {
                    throw new ArgumentOutOfRangeException("Number is larger than 999");
                }
                if (x > 99)
                {
                    t = x / 100;
                    switch (t)
                    {
                        case 1:
                            result = cvtText[100];
                            break;
                        case 2:
                            result = cvtText[200];
                            break;
                        case 3:
                            result = cvtText[300];
                            break;
                        case 4:
                            result = cvtText[400];
                            break;
                        case 5:
                            result = cvtText[500];
                            break;
                        case 6:
                            result = cvtText[600];
                            break;
                        case 7:
                            result = cvtText[700];
                            break;
                        case 8:
                            result = cvtText[800];
                            break;
                        case 9:
                            result = cvtText[900];
                            break;
                    }
                    x = x - (t * 100);
                    if (x <= 0)
                    {
                        return result;
                    }
                    else
                    {
                        result += string.Format("{0}", " " + "و");
                    }
                }
                if (x > 20)
                {
                    t = x / 10;
                    result = result + cvtText[t + 18];
                    x = x - (t * 10);
                    if (x <= 0)
                    {
                        return result;
                    }
                    else
                    {
                        result += string.Format("{0}", " " + "و");
                    }
                }
                if (x > 0)
                {
                    result += cvtText[x];
                }
                return result;
            }
            public static string ToString(int x)
            {
                return (ToString((int)long.Parse(x.ToString())));
            }
            public static string ToString(long x)
            {
                //Build array for number to words mapping
                BuildMapping();
                long t = 0;
                string result = string.Empty;
                if (x > 999999999999)
                {
                    throw new ArgumentOutOfRangeException("Number is too large to process");
                }
                if (x > 999999999)
                {
                    t = x / 1000000000;
                    result += cvt100(t) + " " + cvtText[31];
                    x = x - (t * 1000000000);
                    if (x <= 0)
                    {
                        return result;
                    }
                    else
                    {
                        result += string.Format("{0}", "و");
                    }
                }
                if (x > 999999)
                {
                    t = x / 1000000;
                    result += cvt100(t) + " " + cvtText[30];
                    x = x - (t * 1000000);
                    if (x <= 0)
                    {
                        return result;
                    }
                    else
                    {
                        result += string.Format("{0}", " " + "و");
                    }
                }
                if (x > 999)
                {
                    t = x / 1000;
                    result += cvt100(t) + " " + cvtText[29];
                    x = x - (t * 1000);
                    if (x <= 0)
                    {
                        return result;
                    }
                    else
                    {
                        result += string.Format("{0}", "و");
                    }
                }
                if (x > 0)
                {
                    result += cvt100(x);
                }
                return result;
            }
            //کلاس تبدیل تاریخ به حروف
            private static void BuildDay()
            {
                cvtText[1] = "يکم";
                cvtText[2] = "دوم";
                cvtText[3] = "سوم";
                cvtText[4] = "چهارم";
                cvtText[5] = "پنجم";
                cvtText[6] = "ششم";
                cvtText[7] = "هفتم";
                cvtText[8] = "هشتم";
                cvtText[9] = "نهم";
                cvtText[10] = "دهم";
                cvtText[11] = "یازدهم";
                cvtText[12] = "دوازدهم";
                cvtText[13] = "سیزدهم";
                cvtText[14] = "چهاردهم";
                cvtText[15] = "پانزدهم";
                cvtText[16] = "شانزدهم";
                cvtText[17] = "هفدهم";
                cvtText[18] = "هجدهم";
                cvtText[19] = "نوزدهم";
                cvtText[20] = "بيستم ";
                cvtText[21] = "بیست و یکم";
                cvtText[22] = "بیست و دوم";
                cvtText[23] = "بیست و سوم";
                cvtText[24] = "بیست و چهارم";
                cvtText[25] = "بیست و پنجم";
                cvtText[26] = "بیست و ششم";
                cvtText[27] = "بیست و هفتم";
                cvtText[28] = "بیست و هشتم";
                cvtText[29] = "بیست و نهم";
                cvtText[30] = "سی ام";
                cvtText[31] = "سی و یکم";
            }
            private static void BuildManth()
            {
                cvtText[1] = "فروردین";
                cvtText[2] = "اردیبهشت";
                cvtText[3] = "خرداد";
                cvtText[4] = "تیر";
                cvtText[5] = "مرداد";
                cvtText[6] = "شهریور";
                cvtText[7] = "مهر";
                cvtText[8] = "آبان";
                cvtText[9] = "آذر";
                cvtText[10] = "دی";
                cvtText[11] = "بهمن";
                cvtText[12] = "اسفند";
            }
            public static string Todate(int x)
            {
                return (Todate((int)long.Parse(x.ToString())));
            }
            public static string Tomanth(int x)
            {
                return (Tomanth((int)long.Parse(x.ToString())));
            }
            public static string ToRoz(long x)
            {
                //Build array for number to words mapping
                BuildDay();
                string result = string.Empty;
                result += cvtText[x];
                return result;
            }
            public static string Tomah(long x)
            {
                //Build array for manth to words mapping
                BuildManth();
                string result = string.Empty;
                result += cvtText[x];
                return result;
            }
        }
    }
}