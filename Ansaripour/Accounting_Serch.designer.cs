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
	public partial class Accounting_Serch : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Serch));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button_04 = new System.Windows.Forms.Button();
			this.button_03 = new System.Windows.Forms.Button();
			this.button_01 = new System.Windows.Forms.Button();
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.B_Serch = new System.Windows.Forms.Button();
			this.CTi = new System.Windows.Forms.Label();
			this.Code_Hesab = new System.Windows.Forms.TextBox();
			this.BTi = new System.Windows.Forms.Label();
			this.Name_Hesab = new System.Windows.Forms.TextBox();
			this.Dv = new System.Windows.Forms.DataGridView();
			this.Label2 = new System.Windows.Forms.Label();
			this.Id_Code = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.button_02 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.picIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Dv).BeginInit();
			this.SuspendLayout();
			//
			//button_04
			//
			this.button_04.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button_04.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button_04.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.button_04.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_04.ImageIndex = 2;
			this.button_04.Location = new System.Drawing.Point(302, 298);
			this.button_04.Name = "button_04";
			this.button_04.Size = new System.Drawing.Size(100, 28);
			this.button_04.TabIndex = 0;
			this.button_04.Text = "خروج";
			this.button_04.UseVisualStyleBackColor = false;
			//
			//button_03
			//
			this.button_03.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button_03.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button_03.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.button_03.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_03.ImageKey = "retry.png";
			this.button_03.Location = new System.Drawing.Point(202, 298);
			this.button_03.Name = "button_03";
			this.button_03.Size = new System.Drawing.Size(100, 28);
			this.button_03.TabIndex = 1;
			this.button_03.Text = "انصراف";
			this.button_03.UseVisualStyleBackColor = false;
			//
			//button_01
			//
			this.button_01.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button_01.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button_01.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.button_01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_01.ImageIndex = 0;
			this.button_01.Location = new System.Drawing.Point(2, 298);
			this.button_01.Name = "button_01";
			this.button_01.Size = new System.Drawing.Size(100, 28);
			this.button_01.TabIndex = 2;
			this.button_01.Text = "تایید";
			this.button_01.UseVisualStyleBackColor = false;
			//
			//picIcon
			//
			this.picIcon.Image = (System.Drawing.Image)resources.GetObject("picIcon.Image");
			this.picIcon.Location = new System.Drawing.Point(4, 10);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(60, 62);
			this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picIcon.TabIndex = 3;
			this.picIcon.TabStop = false;
			//
			//B_Serch
			//
			this.B_Serch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.B_Serch.Location = new System.Drawing.Point(459, 47);
			this.B_Serch.Name = "B_Serch";
			this.B_Serch.Size = new System.Drawing.Size(105, 30);
			this.B_Serch.TabIndex = 71;
			this.B_Serch.Text = "جستجو";
			this.B_Serch.UseVisualStyleBackColor = true;
			//
			//CTi
			//
			this.CTi.AutoEllipsis = true;
			this.CTi.ForeColor = System.Drawing.Color.Blue;
			this.CTi.Location = new System.Drawing.Point(70, 53);
			this.CTi.Name = "CTi";
			this.CTi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.CTi.Size = new System.Drawing.Size(115, 19);
			this.CTi.TabIndex = 70;
			this.CTi.Text = "الگوی حساب :";
			this.CTi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Code_Hesab
			//
			this.Code_Hesab.BackColor = System.Drawing.Color.White;
			this.Code_Hesab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
