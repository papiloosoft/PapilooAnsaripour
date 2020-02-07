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
	public partial class B_Control
	{
		public B_Control()
		{
			InitializeComponent();
		}

		public delegate void b_First_ClickedEventHandler(object sender, System.EventArgs e);
		public event b_First_ClickedEventHandler b_First_Clicked;
		public delegate void b_Last_ClickedEventHandler(object sender, System.EventArgs e);
		public event b_Last_ClickedEventHandler b_Last_Clicked;
		public delegate void b_Next_ClickedEventHandler(object sender, System.EventArgs e);
		public event b_Next_ClickedEventHandler b_Next_Clicked;
		public delegate void b_Per_ClickedEventHandler(object sender, System.EventArgs e);
		public event b_Per_ClickedEventHandler b_Per_Clicked;
		private void B_First_Click(System.Object sender, System.EventArgs e)
		{
			if (b_First_Clicked != null)
				b_First_Clicked(sender, e);
		}
		private void B_Next_Click(System.Object sender, System.EventArgs e)
		{
			if (b_Next_Clicked != null)
				b_Next_Clicked(sender, e);
		}
		private void B_Per_Click(System.Object sender, System.EventArgs e)
		{
			if (b_Per_Clicked != null)
				b_Per_Clicked(sender, e);
		}
		private void B_Last_Click(System.Object sender, System.EventArgs e)
		{
			if (b_Last_Clicked != null)
				b_Last_Clicked(sender, e);
		}
	}

}