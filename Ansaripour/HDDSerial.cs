
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
	internal static class HDDSerialL
	{
		[System.Runtime.InteropServices.DllImport("Kernel32", EntryPoint="GetVolumeInformationA", ExactSpelling=true, CharSet=System.Runtime.InteropServices.CharSet.Ansi, SetLastError=true)]
		private static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
		//this function returns the specified logical drive's serial no.
		//if no drive parameter is specified it returns drive C:\'s serial.
		//u can use the function GetCurrentDrive() below to retrieve current
		//drive for the Drive parameter
		public static string SerialNumber(string Drive = "C:\\")
		{
			int Serial = 0; //Serialno
			string VName = null;
			string FSName = null;
			//Create buffers
			VName = new string('\0', 255); //Volume name
			FSName = new string('\0', 255); //File system
			//Get the volume information
			int tempVar = 0;
			int tempVar2 = 0;
			GetVolumeInformation(Drive, VName, 255, ref Serial, ref tempVar, ref tempVar2, FSName, 255);
			//Strip the extra chr$(0)'s
			VName = VName.Substring(0, VName.IndexOf('\0'));
			FSName = FSName.Substring(0, FSName.IndexOf('\0'));
			//Return Trim(Str(Serial))
			return Serial.ToString().Trim();
		}
		public static string GetCurrentDrive()
		{
			return System.IO.Directory.GetCurrentDirectory().Substring(0, 3);
		}
	}

}