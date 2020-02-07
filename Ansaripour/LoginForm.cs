using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ansaripour
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Test_Conection()
        {
            try
            {
                DataSet HostName = data.PDataset("select * from Security_Users where Host_Name=N'" + System.Net.Dns.GetHostName() + "'");
                foreach (DataRow Dr in HostName.Tables[0].Rows)
                {
                    if (!IsDBNull(Dr[0]))
                    {
                        string[] dtVal;
                        dtVal = Dr["Host_String"].ToString().Split('/');
                        Check_Pass.Checked = dtVal[2];
                        if ((dtVal[2] ?? "") == "True")
                        {
                            UsernameTextBox.Text = Dr["username"].ToString();
                            Host = Dr["username"];
                            DataSet serch = data.PDataset("select * from Pictures where Name_Data_Picture=N'" + dtVal[0] + "' and Id_Data_Picture=N'" + dtVal[1] + "'");
                            foreach (DataRow Drr in serch.Tables(0).Rows)
                            {
                                if (!IsDBNull(Drr[0]))
                                    P_Pic.Image = ImageFromBase64String[Drr["Picture"]];
                            }
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("اشکال در اتصال با بانک اطلاعاتی", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("مشکل در اجرای برنامه", "مدیر سیستم را مطلع سازید", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
            }
        }
        private void AutocomplateCustomSource()
        {
            DataSet test = data.PDataset("Select username From Security_Users ");
            foreach (DataRow Dr in test.Tables[0].Rows)
            {
                UsernameTextBox.AutoCompleteCustomSource.Add(Dr["USERNAME"].ToString());
            }
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length == 0)
                UsernameTextBox.Focus();
            //-----
            if (PasswordTextBox.Text.Length == 0)
                PasswordTextBox.Focus();
            //-----
            if (UsernameTextBox.Text == "Admin" && PasswordTextBox.Text == "1311")
                this.Hide();
            MDIParent1.ID.Text = "1311";
            MDIParent1.I_N.Text = "مدیر سیستم";
            MDIParent1.N_Id_Area.Text = "مرکزی";
            MDIParent1.N_Company_Area.Text = "بدون تمرکز";
            MDIParent1.N_Admin.Text = "True";
            MDIParent1.Description.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // تغییر زبان صفحه کلید به فارس
            locInputType = new System.Globalization.CultureInfo("FA-IR");
            Application.CurrentInputLanguage = InputLanguage.FromCulture(locInputType);
            Test_Conection();
            UsernameTextBox.TextAlign = HorizontalAlignment.Left;
            UsernameTextBox.AutoCompleteMode = AutoCompleteMode.UsernameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutocomplateCustomSource();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
