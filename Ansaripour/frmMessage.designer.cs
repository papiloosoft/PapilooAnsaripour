//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

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
	public partial class frmMessage : System.Windows.Forms.Form
	{
		//Form reemplaza a Dispose para limpiar la lista de componentes.
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

		//Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components;

		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
		//Se puede modificar usando el Diseñador de Windows Forms.  
		//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
			this.button_03 = new System.Windows.Forms.Button();
			this.imlButtons = new System.Windows.Forms.ImageList(this.components);
			this.button_02 = new System.Windows.Forms.Button();
			this.button_01 = new System.Windows.Forms.Button();
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.imlIcons = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)this.picIcon).BeginInit();
			this.SuspendLayout();
			//
			//button_03
			//
			this.button_03.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button_03.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button_03.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.button_03.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_03.ImageIndex = 2;
			this.button_03.ImageList = this.imlButtons;
			this.button_03.Location = new System.Drawing.Point(12, 91);
			this.button_03.Name = "button_03";
			this.button_03.Size = new System.Drawing.Size(112, 28);
			this.button_03.TabIndex = 0;
			this.button_03.Text = "button#3";
			this.button_03.UseVisualStyleBackColor = false;
			this.button_03.Visible = false;
			//
			//imlButtons
			//
			this.imlButtons.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imlButtons.ImageStream");
			this.imlButtons.TransparentColor = System.Drawing.Color.Transparent;
			this.imlButtons.Images.SetKeyName(0, "button_ok.png");
			this.imlButtons.Images.SetKeyName(1, "button_cancel.png");
			this.imlButtons.Images.SetKeyName(2, "exit_b.png");
			this.imlButtons.Images.SetKeyName(3, "button_reintent.png");
			this.imlButtons.Images.SetKeyName(4, "button_ignore.png");
			//
			//button_02
			//
			this.button_02.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button_02.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button_02.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.button_02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_02.ImageKey = "retry.png";
			this.button_02.Location = new System.Drawing.Point(132, 91);
			this.button_02.Name = "button_02";
			this.button_02.Size = new System.Drawing.Size(112, 28);
			this.button_02.TabIndex = 1;
			this.button_02.Text = "button#2";
			this.button_02.UseVisualStyleBackColor = false;
			this.button_02.Visible = false;
			//
			//button_01
			//
			this.button_01.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button_01.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button_01.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.button_01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_01.ImageIndex = 0;
			this.button_01.ImageList = this.imlButtons;
			this.button_01.Location = new System.Drawing.Point(250, 91);
			this.button_01.Name = "button_01";
			this.button_01.Size = new System.Drawing.Size(112, 28);
			this.button_01.TabIndex = 2;
			this.button_01.Text = "button#1";
			this.button_01.UseVisualStyleBackColor = false;
			//
			//picIcon
			//
			this.picIcon.Image = (System.Drawing.Image)resources.GetObject("picIcon.Image");
			this.picIcon.Location = new System.Drawing.Point(1, 0);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(54, 41);
			this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIcon.TabIndex = 3;
			this.picIcon.TabStop = false;
			//
			//lblTitle
			//
			this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.lblTitle.ForeColor = System.Drawing.Color.Blue;
			this.lblTitle.Location = new System.Drawing.Point(61, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(304, 33);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Título";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//txtMessage
			//
			this.txtMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.txtMessage.ForeColor = System.Drawing.Color.Green;
			this.txtMessage.Location = new System.Drawing.Point(3, 45);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ReadOnly = true;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
