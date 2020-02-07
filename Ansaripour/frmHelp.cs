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
	public partial class frmHelp
	{

		public frmHelp()
		{
			InitializeComponent();
		}

		private void frmHelp_Load(System.Object sender, System.EventArgs e)
		{
			this.Location = new Point(178, 127);
			RichTextBox1.Text = "";
		}
		private void TreeView1_AfterSelect(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			switch (TreeView1.SelectedNode.Text.ToString())
			{
				case "حسابداری":
					RichTextBox1.Text = "";
					RichTextBox1.AppendText(Environment.NewLine + " -> نرم افزار حسابداری");
					break;
				case "ثبت اموال جدید":
					RichTextBox1.Text = "";
					RichTextBox1.AppendText(Environment.NewLine + " -> کلیه اطلاعات اموال در ابتدا باید در این قسمت ثبت شوند");
					break;
			}
		}
	}
}