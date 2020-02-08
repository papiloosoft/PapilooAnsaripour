
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
    public partial class Log_File : System.Windows.Forms.Form
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
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_File));
            this.button_3 = new System.Windows.Forms.Button();
            this.Dv = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.Id_Code = new System.Windows.Forms.Label();
            this.Log_Details = new System.Windows.Forms.RichTextBox();
            this.Button_1 = new System.Windows.Forms.Button();
            this.L_User = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.B_User = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.Dv).BeginInit();
            this.SuspendLayout();
            //
            //button_3
            //
            this.button_3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_3.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_3.ImageIndex = 2;
            this.button_3.Location = new System.Drawing.Point(512, 306);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(62, 28);
            this.button_3.TabIndex = 0;
            this.button_3.Text = "خروج";
            this.button_3.UseVisualStyleBackColor = false;
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
            this.Dv.Location = new System.Drawing.Point(4, 5);
            this.Dv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dv.Name = "Dv";
            this.Dv.Size = new System.Drawing.Size(720, 238);
            this.Dv.TabIndex = 72;
            //
            //Label2
            //
            this.Label2.AutoEllipsis = true;
            this.Label2.ForeColor = System.Drawing.Color.Blue;
            this.Label2.Location = new System.Drawing.Point(574, 310);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(52, 19);
            this.Label2.TabIndex = 73;
            this.Label2.Text = "یافته ها :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Id_Code
            //
            this.Id_Code.AutoEllipsis = true;
            this.Id_Code.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Id_Code.ForeColor = System.Drawing.Color.Red;
            this.Id_Code.Location = new System.Drawing.Point(620, 309);
            this.Id_Code.Name = "Id_Code";
            this.Id_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Id_Code.Size = new System.Drawing.Size(105, 19);
            this.Id_Code.TabIndex = 74;
            this.Id_Code.Text = "0";
            this.Id_Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Log_Details
            //
            this.Log_Details.Location = new System.Drawing.Point(4, 246);
            this.Log_Details.Name = "Log_Details";
            this.Log_Details.Size = new System.Drawing.Size(720, 54);
            this.Log_Details.TabIndex = 75;
            this.Log_Details.Text = "";
            //
            //Button_1
            //
            this.Button_1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button_1.Enabled = false;
            this.Button_1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Button_1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Button_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_1.ImageIndex = 2;
            this.Button_1.Location = new System.Drawing.Point(380, 306);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(73, 28);
            this.Button_1.TabIndex = 76;
            this.Button_1.Text = "جستجو";
            this.Button_1.UseVisualStyleBackColor = false;
            //
            //L_User
            //
            this.L_User.AutoSize = true;
            this.L_User.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_User.Location = new System.Drawing.Point(8, 310);
            this.L_User.Name = "L_User";
            this.L_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_User.Size = new System.Drawing.Size(70, 19);
            this.L_User.TabIndex = 338;
            this.L_User.Text = " پرسنل :";
            //
            //User
            //
            this.User.Enabled = false;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.User.Location = new System.Drawing.Point(81, 304);
            this.User.Name = "User";
            this.User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.User.Size = new System.Drawing.Size(262, 31);
            this.User.TabIndex = 339;
            //
            //B_User
            //
            this.B_User.Enabled = false;
            this.B_User.Image = (System.Drawing.Image)resources.GetObject("B_User.Image");
            this.B_User.Location = new System.Drawing.Point(345, 307);
            this.B_User.Name = "B_User";
            this.B_User.Size = new System.Drawing.Size(29, 27);
            this.B_User.TabIndex = 340;
            this.B_User.UseVisualStyleBackColor = true;
            //
            //Button_2
            //
            this.Button_2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button_2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Button_2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Button_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_2.ImageIndex = 2;
            this.Button_2.Location = new System.Drawing.Point(451, 306);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(62, 28);
            this.Button_2.TabIndex = 341;
            this.Button_2.Text = "انصراف";
            this.Button_2.UseVisualStyleBackColor = false;
            //
            //Log_File
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(729, 337);
            this.ControlBox = false;
            this.Controls.Add(this.Button_2);
            this.Controls.Add(this.User);
            this.Controls.Add(this.B_User);
            this.Controls.Add(this.L_User);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.Log_Details);
            this.Controls.Add(this.Id_Code);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Dv);
            this.Controls.Add(this.button_3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log_File";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessage";
            ((System.ComponentModel.ISupportInitialize)this.Dv).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Button button_3;
        internal System.Windows.Forms.DataGridView Dv;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Id_Code;
        internal System.Windows.Forms.RichTextBox Log_Details;
        internal System.Windows.Forms.Button Button_1;
        internal System.Windows.Forms.Label L_User;
        internal System.Windows.Forms.TextBox User;
        internal System.Windows.Forms.Button B_User;
        internal System.Windows.Forms.Button Button_2;
    }
}