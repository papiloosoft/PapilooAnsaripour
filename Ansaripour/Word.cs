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

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
