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
	public partial class AuthorCodeImageGalleryVB
	{
		public AuthorCodeImageGalleryVB()
		{
			InitializeComponent();
		}

		private int CtrlWidth;
		private int CtrlHeight;
		private int PicWidth;
		private int PicHeight;
		private int XLocation;
		private int YLocation;

		private void AuthorCodeImageGalleryVB_Resize(System.Object sender, System.EventArgs e)
		{
			CtrlHeight = this.Height;
			CtrlWidth = this.Width;
		}
		private string _Directory_Path;
		public string Directorypath
		{
			get
			{
				return _Directory_Path;
			}
			set
			{

				_Directory_Path = value;
				XLocation = 25;
				YLocation = 25;
				PicWidth = 117;
				PicHeight = 109;
				CreateGallery();
			}
		}
		private int i = 0;
		private void DrawPictureBox(string _filename, string _displayname)
		{
			PictureBox Pic1 = new PictureBox();
			Pic1.Location = new System.Drawing.Point(XLocation, YLocation);
			XLocation = XLocation + PicWidth + 20;
			if (XLocation + PicWidth >= CtrlWidth)
			{
				XLocation = 25;
				YLocation = YLocation + PicHeight + 20;
			}
			Pic1.Name = "PictureBox" + i;
			i += 1;
			Pic1.Size = new System.Drawing.Size(PicWidth, PicHeight);
			Pic1.TabIndex = 0;
			Pic1.TabStop = false;
			Pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ToolTip1.SetToolTip(Pic1, _displayname);
			Pic1.MouseEnter += Pic1_MouseEnter;
			Pic1.MouseLeave += Pic1_MouseLeave;
			this.Controls.Add(Pic1);
			Pic1.Image = icons.Images[_filename];
			Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		}
		private void CreateGallery()
		{
			i = 0;
			RemoveControls();
			if (Directorypath != null)
			{
				System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Directorypath);
				System.IO.FileInfo[] diar1 = di.GetFiles("*.jpg").Concat(di.GetFiles("*.bmp")).Concat(di.GetFiles("*.png")).Concat(di.GetFiles("*.gif")).ToArray();
//INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
//				Dim dra As IO.FileInfo
				foreach (System.IO.FileInfo dra in diar1)
				{
					DrawPictureBox(dra.FullName, dra.Name);
				}
			}
		}

		private void Pic1_MouseEnter(System.Object sender, System.EventArgs e)
		{
			PictureBox Pic = (PictureBox)sender;
			Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		}
		private void Pic1_MouseLeave(System.Object sender, System.EventArgs e)
		{
			PictureBox Pic = (PictureBox)sender;
			Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		}
		private void RemoveControls()
		{
	Again:
	foreach (Control ctrl in this.Controls)
	{
				if ((ctrl) is PictureBox)
				{
					this.Controls.Remove(ctrl);
				}
			}
			if (this.Controls.Count > 0)
			{
				goto Again;
			}
		}
	}

}