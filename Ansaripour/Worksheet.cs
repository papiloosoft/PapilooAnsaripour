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
	internal class Worksheet
	{

		private string _cells;

//INSTANT C# NOTE: C# does not support parameterized properties - the following property has been divided into two methods:
//ORIGINAL LINE: Property Cells(ByVal p1 As Integer, ByVal p2 As Integer) As String
		public string Cells(int p1, int p2)
		{
			return _cells;
		}
			public void setCells(int p1, int p2, string value)
			{
				_cells = value;
			}

	}

}