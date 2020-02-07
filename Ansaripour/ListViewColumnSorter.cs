//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

using System.Collections;
using System.Windows.Forms;

namespace Ansaripour
{
	public class ListViewColumnSorter : System.Collections.IComparer
	{
		private int ColumnToSort;
		private SortOrder OrderOfSort;
		private CaseInsensitiveComparer ObjectCompare;
		public ListViewColumnSorter()
		{
			// Initialize the column to '0'.
			ColumnToSort = 0;
			// Initialize the sort order to 'none'.
			OrderOfSort = SortOrder.None;
			// Initialize the CaseInsensitiveComparer object.
			ObjectCompare = new CaseInsensitiveComparer();
		}
		public int Compare(object x, object y)
		{
//INSTANT C# TODO TASK: The 'On Error Resume Next' statement is not converted by Instant C#:
			On Error Resume Next
			int compareResult = 0;
			ListViewItem listviewX = null;
			ListViewItem listviewY = null;
			// Cast the objects to be compared to ListViewItem objects.
			listviewX = (ListViewItem)x;
			listviewY = (ListViewItem)y;
			// Compare the two items.
			compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
			// Calculate the correct return value based on the object 
			// comparison.
			if (OrderOfSort == SortOrder.Ascending)
			{
				// Ascending sort is selected, return typical result of 
				// compare operation.
				return compareResult;
			}
			else if (OrderOfSort == SortOrder.Descending)
			{
				// Descending sort is selected, return negative result of 
				// compare operation.
				return (-compareResult);
			}
			else
			{
				// Return '0' to indicate that they are equal.
				return 0;
			}
		}
		public int SortColumn
		{
			set
			{
				ColumnToSort = value;
			}
			get
			{
				return ColumnToSort;
			}
		}
		public SortOrder Order
		{
			set
			{
				OrderOfSort = value;
			}
			get
			{
				return OrderOfSort;
			}
		}
	}

}