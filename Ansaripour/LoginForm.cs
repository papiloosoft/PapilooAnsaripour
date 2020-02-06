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
                        dtVal = Dr["Host_String"].Split('/');
                        Check_Pass.Checked = dtVal[2];
                        if ((dtVal[2] ?? "") == "True")
                        {
                            UsernameTextBox.Text = Dr["username"];
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
                MessageBox.Show("اشکال در اتصال با بانک اطلاعاتی", ex.Message , MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("مشکل در اجرای برنامه", "مدیر سیستم را مطلع سازید",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
            }
        }
        private void OK_Click(object sender, EventArgs e)
        {

        }
    }
}
