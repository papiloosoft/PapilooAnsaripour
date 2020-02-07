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
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using System.Drawing;

namespace Ansaripour
{
    public partial class MDIParent1
    {
        public MDIParent1()
        {
            InitializeComponent();
        }

        private string f_serch; //تابع متغیر فرمول جستجو
        private string f_select; //تابع متغیر فرمول جستجو
        private int err;
        private string num;
        private void Warranty()
        {
            f_select = "";
            f_select = "select A.*,B.*,C.* from Warranty_Document A left join Base_Information B on A.Warranty_Document_Case=B.Base_Information_Id left join Counterparty C on A.Warranty_Document_Subscription=C.Counterparty_ID where ";
            f_select += "Warranty_Document_Operation not in (2) ";
            f_select += "and Warranty_Document_Extended_Date >= '" + NumericHelper.Val(data.today().Replace("/", "")) + "'";
            f_select += "and Warranty_Document_Extended_Date <= '" + NumericHelper.Val(data.Next_Month().Replace("/", "")) + "'";
            if (this.N_Admin.Text == "False")
            {
                f_select += "and Warranty_Document_Area = " + this.N_Id_Area.Text + "";
            }
            f_select += "UNION select A.*,B.*,C.* from Warranty_Document A left join Base_Information B on A.Warranty_Document_Case=B.Base_Information_Id left join Counterparty C on A.Warranty_Document_Subscription=C.Counterparty_ID where ";
            f_select += "Warranty_Document_Operation not in (1,2) ";
            f_select += "and Warranty_Document_Due_Date >= '" + NumericHelper.Val(data.today().Replace("/", "")) + "'";
            f_select += "and Warranty_Document_Due_Date <= '" + NumericHelper.Val(data.Next_Month().Replace("/", "")) + "'";
            if (this.N_Admin.Text == "False")
            {
                f_select += "and Warranty_Document_Area = " + this.N_Id_Area.Text + "";
            }
            DataSet Warranty = data.PDataset("" + f_select + "");
            Label_Warranty.Text = (Warranty.Tables[0].Rows.Count).ToString();
            f_select = "";
            f_select += "select A.*,B.*,C.*,D.* from Recovery_Documents A ";
            f_select += "left join Base_Information B on Recovery_Documents_Case=Base_Information_Id ";
            f_select += "left join Counterparty C on Recovery_Documents_Subscription=Counterparty_ID ";
            f_select += "left join Bank D on Recovery_Documents_Collecting_Bank=Bank_ID ";
            f_select += "where Recovery_Documents_Operation not in (2,3,4) ";
            f_select += "and Recovery_Documents_Due_Date >= '" + NumericHelper.Val(data.today().Replace("/", "")) + "'";
            f_select += "and Recovery_Documents_Due_Date <= '" + NumericHelper.Val(data.Next_Month().Replace("/", "")) + "'";
            if (this.N_Admin.Text == "False")
            {
                f_select += "and Recovery_Documents_Area = " + this.N_Id_Area.Text + "";
            }
            DataSet Collection = data.PDataset("" + f_select + "");
            Label_Collection.Text = (Collection.Tables[0].Rows.Count).ToString();
        }
        private void tvData_AfterSelect(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            //INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal, range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
            //			Select Case tvData.SelectedNode.Text
            //ORIGINAL LINE: Case "N_R_Inventory"
            if (tvData.SelectedNode.Text == "N_R_Inventory")
            {
                this.tvData.Visible = false;
                ST_Request_Goods OBJCHILD = new ST_Request_Goods();
                OBJCHILD.Text = "گزارش موجودی کالا در انبار";
                OBJCHILD.Var_Clas = "20";
                OBJCHILD.SplitContainer2.Panel2Collapsed = true;
                OBJCHILD.B_Product.Visible = false;
                OBJCHILD.Edit_B.Visible = false;
                OBJCHILD.Delet_B.Visible = false;
                OBJCHILD.Save_B.Visible = false;
                OBJCHILD.Visible = true;
                OBJCHILD.Location = new Point(Convert.ToInt32((SplitContainer1.Panel2.Width - OBJCHILD.Width) / 2.0), Convert.ToInt32((SplitContainer1.Panel2.Height - OBJCHILD.Height) / 2.0));
                OBJCHILD.TopLevel = false;
                OBJCHILD.Parent = this.SplitContainer1.Panel2;
                OBJCHILD.Dock = DockStyle.None;
                OBJCHILD.BringToFront();
                OBJCHILD.Show();
            }
            //ORIGINAL LINE: Case Report_Accounting_Account_Note_Book.Text
            else if (tvData.SelectedNode.Text == Report_Accounting_Account_Note_Book.Text)
            {
                this.tvData.Visible = false;
                Accounting_Report OBJCHILD = new Accounting_Report();
                OBJCHILD.Text = Report_Accounting_Account_Note_Book.Text;
                OBJCHILD.Reports = "Rpt_Balance_Acc.rpt";
                OBJCHILD.Visible = true;
                OBJCHILD.Location = new Point(Convert.ToInt32((SplitContainer1.Panel2.Width - OBJCHILD.Width) / 2.0), Convert.ToInt32((SplitContainer1.Panel2.Height - OBJCHILD.Height) / 2.0));
                OBJCHILD.TopLevel = false;
                OBJCHILD.Parent = this.SplitContainer1.Panel2;
                OBJCHILD.Dock = DockStyle.None;
                OBJCHILD.BringToFront();
                OBJCHILD.Show();
            }
            //ORIGINAL LINE: Case Report_Accounting_Details_Note_One_Book.Text
            else if (tvData.SelectedNode.Text == Report_Accounting_Details_Note_One_Book.Text)
            {
                this.tvData.Visible = false;
                Accounting_Report OBJCHILD = new Accounting_Report();
                OBJCHILD.Text = Report_Accounting_Details_Note_One_Book.Text;
                OBJCHILD.Reports = "Rpt_Balance_One_Detailed.rpt";
                OBJCHILD.Visible = true;
                OBJCHILD.Location = new Point(Convert.ToInt32((SplitContainer1.Panel2.Width - OBJCHILD.Width) / 2.0), Convert.ToInt32((SplitContainer1.Panel2.Height - OBJCHILD.Height) / 2.0));
                OBJCHILD.TopLevel = false;
                OBJCHILD.Parent = this.SplitContainer1.Panel2;
                OBJCHILD.Dock = DockStyle.None;
                OBJCHILD.BringToFront();
                OBJCHILD.Show();
            }
            //ORIGINAL LINE: Case Report_Accounting_Details_Note_Two_Book.Text
            else if (tvData.SelectedNode.Text == Report_Accounting_Details_Note_Two_Book.Text)
            {
                this.tvData.Visible = false;
                Accounting_Report OBJCHILD = new Accounting_Report();
                OBJCHILD.Text = Report_Accounting_Details_Note_Two_Book.Text;
                OBJCHILD.Reports = "Rpt_Balance_Two_Detailed.rpt";
                OBJCHILD.Visible = true;
                OBJCHILD.Location = new Point(Convert.ToInt32((SplitContainer1.Panel2.Width - OBJCHILD.Width) / 2.0), Convert.ToInt32((SplitContainer1.Panel2.Height - OBJCHILD.Height) / 2.0));
                OBJCHILD.TopLevel = false;
                OBJCHILD.Parent = this.SplitContainer1.Panel2;
                OBJCHILD.Dock = DockStyle.None;
            }
        }
    }
}


