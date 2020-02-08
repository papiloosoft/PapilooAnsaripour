
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
	public partial class Report : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.CrViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			//
			//CrViewer
			//
			this.CrViewer.ActiveViewIndex = -1;
			this.CrViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrViewer.Cursor = System.Windows.Forms.Cursors.Default;
			this.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CrViewer.Location = new System.Drawing.Point(0, 0);
			this.CrViewer.Name = "CrViewer";
			this.CrViewer.ShowGroupTreeButton = false;
			this.CrViewer.ShowParameterPanelButton = false;
			this.CrViewer.ShowRefreshButton = false;
			this.CrViewer.Size = new System.Drawing.Size(767, 471);
			this.CrViewer.TabIndex = 23;
			this.CrViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
			this.CrViewer.ViewTimeSelectionFormula = "";
			//
			//Report
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 471);
			this.Controls.Add(this.CrViewer);
			this.Name = "Report";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}
		internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer;
	}

}