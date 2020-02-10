
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