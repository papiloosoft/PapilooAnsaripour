using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.IO.Directory;
using System.Windows.Forms;
using System.Drawing;

namespace Ansaripour
{
    public class Reception
    {
        private string Id_Reception_Subscription;
        private string Id_Reception_Rooms;
        private bool Add; //جداسازي ذخيره جديد و ويرايش
        private bool Edit;
        private bool test;

    }
    private void B_Reception_Subscription_Click(System.Object sender, System.EventArgs e)
    {
        ShowSerch("فرم جستجو بر اساس اشخاص و طرف حساب ها", "شرح", "کد", "Counterparty", "Counterparty_Detailed", "Counterparty_Subscribe", "", "", "", "Counterparty_Area", "Counterparty_ID", "", "", "", "", "", "", "");
        if (string.IsNullOrEmpty(modMessage.C_H_code.ToString()) == false)
        {
            Reception_Subscription.Text = modMessage.C_C_code.ToString() + " - " + modMessage.C_Sh_code.ToString();
        }
        Id_Reception_Subscription = modMessage.C_H_code.ToString();
    }
    private void B_Reception_Rooms_Click(System.Object sender, System.EventArgs e)
    {
        ShowSerch("فرم جستجو بر اساس شرح و کد اتاق", "شرح اتاق", "کد اتاق", "Accounting_Account", "Acc_Name", "Acc_Code", "", "Acc_Class", "Hotel_Rooms", "", "Acc_Id", "", "", "", "", "", "Acc_Operation", "0");
        if (string.IsNullOrEmpty(modMessage.C_H_code.ToString()) == false)
        {
            Reception_Rooms.Text = modMessage.C_C_code.ToString() + " - " + modMessage.C_Sh_code.ToString();
            Id_Reception_Rooms = modMessage.C_H_code.ToString();
        }
    }
    private void B_Guest_Reception_Click(System.Object sender, System.EventArgs e)
    {
        Reception_Starting_Stay_Date.T_D = DateTime.Today;
        Reception_Starting_Stay_Time.T_Text = DateTime.Now.ToString("HH:mm");
        Reception_End_Stay_Time.T_Text = "12:00";
    }
    private void Reception_Stay_Day_ValueChanged(object sender, System.EventArgs e)
    {
        Reception_End_Stay_Date.T_D = Add_day(Reception_Stay_Day.Value());
    }
    private void reset()
    {
        DV_Restaurant.Rows.Clear();
        DV_Restaurant.Columns.Clear();
        DV_Restaurant.Controls.Clear();
        DV_Restaurant.Columns.Add("row", "رديف");
        DV_Restaurant.Columns.Add("Goods_Code", "کد کالا");
        DV_Restaurant.Columns.Add("Goods_Name", "شرح کالا");
        DV_Restaurant.Columns.Add("Goods_Module", "واحد کالا");
        DV_Restaurant.Columns.Add("Goods_S_Number", "تعداد");
        DV_Restaurant.Columns.Add("Goods_Price", "مبلغ فی");
        DV_Restaurant.Columns.Add("Goods_Price_Total", "مبلغ کل");
        DV_Restaurant.Columns.Add("Description", "توضيحات");
        DV_Restaurant.Columns.Add("Goods_Id", "");
        DV_Restaurant.Columns.Add("Id_Details", "");
        DV_Restaurant.Columns("Id_Details").Visible = false;
        DV_Restaurant.Columns("Goods_Id").Visible = false;
        DV_Restaurant.Columns("row").Width = 80;
        DV_Restaurant.Columns("Goods_Code").Width = 100;
        DV_Restaurant.Columns("Goods_Name").Width = 250;
        DV_Restaurant.Columns("Goods_Module").Width = 100;
        DV_Restaurant.Columns("Goods_S_Number").Width = 100;
        DV_Restaurant.Columns("Goods_Price").Width = 150;
        DV_Restaurant.Columns("Goods_Price_Total").Width = 150;
        DV_Restaurant.Columns("Description").Width = 400;
        DV_Restaurant.AllowUserToAddRows = true;
        DV_Restaurant.EditMode = DataGridViewEditMode.EditOnKeystroke;
        DV_Restaurant.ReadOnly = false;
        DV_Restaurant.SelectionMode = DataGridViewSelectionMode.CellSelect;
        DV_Restaurant.RowsDefaultCellStyle.BackColor = Color.LightGray;
        DV_Restaurant.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
    }
    private void BTN_Click(System.Object sender, System.EventArgs e)
    {
        test = false;
        modMessage.C_C_code = "";
        ShowSerch("فرم جستجو بر اساس کد و شرح کالا", "شرح کالا", "کد کالا", "St_Goods", "Goods_Name", "Goods_Code", "Base_Information", "Goods_Module", "Base_Information_Id", "", "Goods_Id", "Base_Information_Name", "", "", "", "", "", "");
        if (DV_Restaurant.CurrentRow.Index > 0)
        {
            foreach (DataGridViewRow row in DV_Restaurant.Rows)
            {
                if (row.Cells("Goods_Code").Value == modMessage.C_C_code.ToString())
                {
                    test = true;
                }
            }
        }
        if (test)
        {
            ShowMessage("کاربر محترم" + " :" + MDIParent1.I_N.Text, " این کد کالا  تکراری است", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
        }
        else
        {
            if (!string.IsNullOrEmpty(modMessage.C_F_code.ToString()))
            {
                DV_Restaurant.CurrentRow.Cells("Goods_Code").Value = modMessage.C_C_code.ToString();
                DV_Restaurant.CurrentRow.Cells("Goods_Name").Value = modMessage.C_Sh_code.ToString();
                DV_Restaurant.CurrentRow.Cells("Goods_Module").Value = modMessage.C_I_code.ToString();
                DV_Restaurant.CurrentRow.Cells("Goods_Id").Value = modMessage.C_H_code.ToString();
                DV_Restaurant.CurrentRow.Cells("Goods_Name").ReadOnly = true;
                DV_Restaurant.CurrentRow.Cells("Goods_Module").ReadOnly = true;
            }
        }
    }
    private void DV_Restaurant_CellMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
    {
        DV_Restaurant.Controls.Clear();
        if (Add == true || Edit == true)
        {
            switch (DV_Restaurant.CurrentCell.ColumnIndex)
            {
                case 1:
                    System.Windows.Forms.Button MyButton = new System.Windows.Forms.Button();
                    MyButton.Text = "...";
                    MyButton.Visible = true;
                    MyButton.Width = DV_Restaurant.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Height;
                    MyButton.Height = DV_Restaurant.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Height;
                    MyButton.Click += BTN_Click;
                    DV_Restaurant.Controls.Add(MyButton);
                    MyButton.Location = new System.Drawing.Point((DV_Restaurant.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Right) - ((DV_Restaurant.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Width)), DV_Restaurant.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Y);
                    break;
            }
        }
    }
    private void ToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
    {
        Microsoft.VisualBasic.FileSystem.Reset();
        Save_B.Enabled = true;
        Add = true;
    }
    private void DV_Restaurant_CellPainting(object sender, System.Windows.Forms.DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex == 0)
        {
            DV_Restaurant.Rows(e.RowIndex).Cells("ROW").Value = e.RowIndex + 1;
        }
    }

}
