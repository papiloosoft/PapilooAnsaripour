
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
    public partial class H_Serch : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H_Serch));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_04 = new System.Windows.Forms.Button();
            this.button_03 = new System.Windows.Forms.Button();
            this.button_01 = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.B_Serch = new System.Windows.Forms.Button();
            this.CTi = new System.Windows.Forms.Label();
            this.C_Hesab = new System.Windows.Forms.TextBox();
            this.BTi = new System.Windows.Forms.Label();
            this.S_Hesab = new System.Windows.Forms.TextBox();
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
            //C_Hesab
            //
            this.C_Hesab.BackColor = System.Drawing.Color.White;
            this.C_Hesab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            //
            //C_Hesab
            //
            this.C_Hesab.BackColor = System.Drawing.Color.White;
            this.C_Hesab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.C_Hesab.Location = new System.Drawing.Point(191, 47);
            this.C_Hesab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.C_Hesab.Name = "C_Hesab";
            this.C_Hesab.Size = new System.Drawing.Size(262, 30);
            this.C_Hesab.TabIndex = 69;
            //
            //BTi
            //
            this.BTi.AutoEllipsis = true;
            this.BTi.ForeColor = System.Drawing.Color.Blue;
            this.BTi.Location = new System.Drawing.Point(70, 11);
            this.BTi.Name = "BTi";
            this.BTi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTi.Size = new System.Drawing.Size(115, 19);
            this.BTi.TabIndex = 68;
            this.BTi.Text = "شرح حساب :";
            this.BTi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //S_Hesab
            //
            this.S_Hesab.BackColor = System.Drawing.Color.White;
            this.S_Hesab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.S_Hesab.Location = new System.Drawing.Point(191, 7);
            this.S_Hesab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.S_Hesab.Name = "S_Hesab";
            this.S_Hesab.Size = new System.Drawing.Size(373, 30);
            this.S_Hesab.TabIndex = 67;
            //
            //Dv
            //
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            this.Dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv.DefaultCellStyle = DataGridViewCellStyle2;
            this.Dv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv.Location = new System.Drawing.Point(4, 82);
            this.Dv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dv.Name = "Dv";
            this.Dv.Size = new System.Drawing.Size(560, 214);
            this.Dv.TabIndex = 72;
            //
            //Label2
            //
            this.Label2.AutoEllipsis = true;
            this.Label2.ForeColor = System.Drawing.Color.Blue;
            this.Label2.Location = new System.Drawing.Point(409, 303);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(66, 19);
            this.Label2.TabIndex = 73;
            this.Label2.Text = "یافته ها :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Id_Code
            //
            this.Id_Code.AutoEllipsis = true;
            this.Id_Code.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Id_Code.ForeColor = System.Drawing.Color.Red;
            this.Id_Code.Location = new System.Drawing.Point(476, 302);
            this.Id_Code.Name = "Id_Code";
            this.Id_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Id_Code.Size = new System.Drawing.Size(81, 19);
            this.Id_Code.TabIndex = 74;
            this.Id_Code.Text = "0";
            this.Id_Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label1
            //
            this.Label1.AutoEllipsis = true;
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(174, 12);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(14, 19);
            this.Label1.TabIndex = 75;
            this.Label1.Text = ":";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label3
            //
            this.Label3.AutoEllipsis = true;
            this.Label3.ForeColor = System.Drawing.Color.Blue;
            this.Label3.Location = new System.Drawing.Point(175, 53);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(14, 19);
            this.Label3.TabIndex = 76;
            this.Label3.Text = ":";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //button_02
            //
            this.button_02.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_02.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_02.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button_02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_02.ImageIndex = 0;
            this.button_02.Location = new System.Drawing.Point(102, 298);
            this.button_02.Name = "button_02";
            this.button_02.Size = new System.Drawing.Size(100, 28);
            this.button_02.TabIndex = 77;
            this.button_02.Text = "نمایش کلی";
            this.button_02.UseVisualStyleBackColor = false;
            //
            //H_Serch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(569, 328);
            this.ControlBox = false;
            this.Controls.Add(this.button_02);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Id_Code);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Dv);
            this.Controls.Add(this.B_Serch);
            this.Controls.Add(this.CTi);
            this.Controls.Add(this.C_Hesab);
            this.Controls.Add(this.BTi);
            this.Controls.Add(this.S_Hesab);
            this.Controls.Add(this.button_04);
            this.Controls.Add(this.button_03);
            this.Controls.Add(this.button_01);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "H_Serch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessage";
            ((System.ComponentModel.ISupportInitialize)this.picIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.Dv).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Button button_04;
        internal System.Windows.Forms.Button button_03;
        internal System.Windows.Forms.Button button_01;
        internal System.Windows.Forms.PictureBox picIcon;
        internal System.Windows.Forms.Button B_Serch;
        internal System.Windows.Forms.Label CTi;
        internal System.Windows.Forms.TextBox C_Hesab;
        internal System.Windows.Forms.Label BTi;
        internal System.Windows.Forms.TextBox S_Hesab;
        internal System.Windows.Forms.DataGridView Dv;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Id_Code;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button button_02;
    }

}