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
	public partial class AuthorCodeImageGalleryVB : System.Windows.Forms.UserControl
	{
		//UserControl overrides dispose to clean up the component list.
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorCodeImageGalleryVB));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.icons = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			//
			//icons
			//
			this.icons.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("icons.ImageStream");
			this.icons.TransparentColor = System.Drawing.Color.Transparent;
			this.icons.Images.SetKeyName(0, "shield_ok.png");
			this.icons.Images.SetKeyName(1, "shield_info.png");
			this.icons.Images.SetKeyName(2, "shield_question.png");
			this.icons.Images.SetKeyName(3, "shield_no.png");
			this.icons.Images.SetKeyName(4, "shield_stop.png");
			this.icons.Images.SetKeyName(5, "shield_tools.png");
			this.icons.Images.SetKeyName(6, "shield_warning.png");
			this.icons.Images.SetKeyName(7, "shield_key.png");
			this.icons.Images.SetKeyName(8, "shield_refresh.png");
			this.icons.Images.SetKeyName(9, "shield_standby.png");
			this.icons.Images.SetKeyName(10, "shield_trash.png");
			this.icons.Images.SetKeyName(11, "shield_save.png");
			this.icons.Images.SetKeyName(12, "shield_edit.png");
			this.icons.Images.SetKeyName(13, "shield_flash.png");
			this.icons.Images.SetKeyName(14, "shield_lock.png");
			this.icons.Images.SetKeyName(15, "shield_unlock.png");
			this.icons.Images.SetKeyName(16, "shield_clock.png");
			this.icons.Images.SetKeyName(17, "shield_search.png");
			this.icons.Images.SetKeyName(18, "shield_zoom.png");
			this.icons.Images.SetKeyName(19, "Marvin-icon_print.png");
			//
			//AuthorCodeImageGalleryVB
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Name = "AuthorCodeImageGalleryVB";
			this.Size = new System.Drawing.Size(553, 333);
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.Resize += new System.EventHandler(AuthorCodeImageGalleryVB_Resize);
		}
		internal System.Windows.Forms.ToolTip ToolTip1;
		internal System.Windows.Forms.ImageList icons;

	}

}