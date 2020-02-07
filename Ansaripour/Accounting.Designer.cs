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
    public partial class Accounting : System.Windows.Forms.Form
    {
        //Form overrides dispose to clean up the component list.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.First_B = new System.Windows.Forms.ToolStripButton();
            this.Next_B = new System.Windows.Forms.ToolStripButton();
            this.Accounting_Header_Number = new System.Windows.Forms.ToolStripTextBox();
            this.Preview_B = new System.Windows.Forms.ToolStripButton();
            this.Last_B = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Print_B = new System.Windows.Forms.ToolStripButton();
            this.Accounting_Header_Class = new System.Windows.Forms.ToolStripComboBox();
            this.Picture_B = new System.Windows.Forms.ToolStripButton();
            this.Excel_B = new System.Windows.Forms.ToolStripButton();
            this.Log_File = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.B_Header_Number = new System.Windows.Forms.Button();
            this.Label21 = new System.Windows.Forms.Label();
            this.Header_Number = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Accounting_Header_Description = new System.Windows.Forms.TextBox();
            this.Accounting_Header_Date = new Ansaripour.Rtl_Date();
            this.Label1 = new System.Windows.Forms.Label();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Dv_Accounting = new Ansaripour.MyDataGridView();
            this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
            this.Types = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Total_Debtor = new System.Windows.Forms.TextBox();
            this.Total_Creditor = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Accounting_Details_Detailed_Five_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Five_Main = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Four_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Four_Main = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Three_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Three_Main = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Two_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Two_Main = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_One_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_One_Main = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Accounting_Details_Acc_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Acc_Main = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.Accounting_Details_Description_Main = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Accounting_Details_Number_Turning_Main = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Accounting_Details_Number_Due_Main = new System.Windows.Forms.TextBox();
            this.Estehlak_Label = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Accounting_Details_Date_Due_Main = new Ansaripour.Rtl_Date();
            this.Accounting_Details_Date_Cost_Main = new Ansaripour.Rtl_Date();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.TextBox9 = new System.Windows.Forms.TextBox();
        }
    }
}
//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
