namespace Ansaripour
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Check_Pass = new System.Windows.Forms.CheckBox();
            this.P_Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.P_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(43, 143);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(146, 20);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(43, 181);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(146, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(131, 256);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(76, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "تائید";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(59, 256);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "انصراف";
            // 
            // Check_Pass
            // 
            this.Check_Pass.AutoSize = true;
            this.Check_Pass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Check_Pass.Location = new System.Drawing.Point(71, 223);
            this.Check_Pass.Name = "Check_Pass";
            this.Check_Pass.Size = new System.Drawing.Size(15, 14);
            this.Check_Pass.TabIndex = 6;
            this.Check_Pass.UseVisualStyleBackColor = true;
            // 
            // P_Pic
            // 
            this.P_Pic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.P_Pic.Location = new System.Drawing.Point(73, 30);
            this.P_Pic.Name = "P_Pic";
            this.P_Pic.Size = new System.Drawing.Size(110, 83);
            this.P_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Pic.TabIndex = 232;
            this.P_Pic.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(472, 292);
            this.Controls.Add(this.P_Pic);
            this.Controls.Add(this.Check_Pass);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.P_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox Check_Pass;
        private System.Windows.Forms.PictureBox P_Pic;
    }
}