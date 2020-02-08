using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ansaripour
{
    public class Pricing
    {
        private bool Add; //جداسازی ذخیره جدید و ویرایش
        private string f_serch; //تابع متغیر فرمول جستجو
        private string Pricing_Reference;
        public string Var_Data;
        public string Var_Clas;
        MDIParent1 mdiparent = new MDIParent1();


        private void reset()
        {
            Pricing_Code.Text = "";
            Pricing_Explained.Text = "";
            Pricing_Fixed.Text = "";
            Pricing_Sale.Text = "";
            Add = false;
        }
        private void New_B_Click(System.Object sender, System.EventArgs e)
        {
            Save_B.Enabled = true;
            reset();
            Microsoft.VisualBasic.FileSystem.Reset();
            if (Add)
            {
                DataSet PrSet = PDataset("select max(Pricing_Code) from " + Var_Data + " where Pricing_Class = '" + Var_Clas + "'");
                foreach (DataRow Dr in PrSet.Tables[0].Rows)
                {
                    switch (Var_Clas)
                    {
                        case "Rooms":
                            if (Convert.IsDBNull(Dr[0]))
                            {
                                Pricing_Code.Text = "01";
                            }
                            else
                            {
                                switch (((string)((Dr[0].ToString() + 1).Trim(' '))).Length)
                                {
                                    case 1:
                                        Pricing_Code.Text = "0" + (Dr[0].ToString() + 1);
                                        break;
                                    default:
                                        Pricing_Code.Text = Dr[0].ToString() + 1;
                                        break;
                                }
                            }
                            break;
                        case 12:
                            if (Convert.IsDBNull(Dr[0]))
                            {
                                Pricing_Code.Text = "00001";
                            }
                            else
                            {
                                switch (((string)((Dr[0].ToString() + 1).Trim(' '))).Length)
                                {
                                    case 1:
                                        Pricing_Code.Text = "0000" + (Dr[0].ToString() + 1);
                                        break;
                                    case 2:
                                        Pricing_Code.Text = "000" + (Dr[0].ToString() + 1);
                                        break;
                                    case 3:
                                        Pricing_Code.Text = "00" + (Dr[0].ToString() + 1);
                                        break;
                                    case 4:
                                        Pricing_Code.Text = "0" + (Dr[0].ToString() + 1);
                                        break;
                                    default:
                                        Pricing_Code.Text = Dr[0].ToString() + 1;
                                        break;
                                }
                            }
                            break;
                    }
                }
            }

        }
        private void Pricing_Fixed_TextChanged(dynamic sender, System.EventArgs e)
        {
            if (NumericHelper.IsNumeric(Pricing_Fixed.Text))
            {
                sender.Text = NumericHelper.Val(sender.Text.Trim().Replace(",", "")).ToString("#,0"); //& aa
                sender.SelectionStart = sender.TextLength;
                double _Value = Convert.ToInt64(sender.Text.Replace(",", ""));
            }
        }
        private void Pricing_Sale_TextChanged(dynamic sender, System.EventArgs e)
        {
            if (NumericHelper.IsNumeric(Pricing_Sale.Text))
            {
                sender.Text = NumericHelper.Val(sender.Text.Trim().Replace(",", "")).ToString("#,0"); //& aa
                sender.SelectionStart = sender.TextLength;
                double _Value = Convert.ToInt64(sender.Text.Replace(",", ""));
            }
        }
        private void B_Pricing_Explained_Click(System.Object sender, System.EventArgs e)
        {
            ShowSerch("فرم جستجو بر اساس کد و نوع اتاق ها", "نوع اتاق", "کد ", "Base_Information", "Base_Information_Name", "Base_Information_Code", "", "Base_Information_Class", "Case_Rooms", "Base_Information_Area", "Base_Information_Id", "", "", "", "", "", "", "");
            if (string.IsNullOrEmpty(modMessage.C_H_code.ToString()) == false)
            {
                Pricing_Explained.Text = modMessage.C_Sh_code.ToString();
            }
            Pricing_Reference = modMessage.C_H_code.ToString();
        }
        private void Save_B_Click(System.Object sender, System.EventArgs e)
        {
            if (Add)
            {
                f_serch = "";
                f_serch = "INSERT INTO " + Var_Data + "  (Pricing_Code,Pricing_Explained,";
                f_serch += "Pricing_Reference,Pricing_Class,Pricing_Fixed,Pricing_Sale,";
                f_serch += "Pricing_Area,user_id)  VALUES  (N'" + Pricing_Code.Text + "',N'" + Pricing_Explained.Text + "',";
                f_serch += "N'" + Pricing_Reference + "',N'" + Var_Clas + "',";
                f_serch += "N'" + Pricing_Fixed.Text.Replace(",", "") + "',N'" + Pricing_Sale.Text.Replace(",", "") + "',";
                f_serch += "N'" + mdiparent.N_Id_Area.Text + "',N'" + mdiparent.ID.Text + "')";
                DataSet Save = data.PDataset("" + f_serch + "");
                ShowMessage("کاربر محترم" + " :" + mdiparent.I_N.Text, " اطلاعات با موفقیت ثبت شدند", frmMessage.mIcon.msave, frmMessage.mButtons.mAccept);
                Save_B.Enabled = false;
            }
            else
            {
                f_serch = "";
                f_serch = "UPDATE " + Var_Data + " SET Pricing_Code=N'" + Pricing_Code.Text + "',Pricing_Explained=N'" + Pricing_Explained.Text + "',";
                f_serch += "Pricing_Reference=N'" + Pricing_Reference + "',Pricing_Class=N'" + Var_Clas + "',Pricing_Fixed=N'" + Pricing_Fixed.Text.Replace(",", "") + "',";
                f_serch += "Pricing_Sale=N'" + Pricing_Sale.Text.Replace(",", "") + "',Pricing_Area=N'" + MDIParent1.N_Id_Area.Text + "',user_id=N'" + mdiparent.ID.Text + "'";
                DataSet update = PDataset("" + f_serch + "");
                ShowMessage("کاربر محترم" + " :" + mdiparent.I_N.Text, " اطلاعات با موفقیت ویرایش شدند", frmMessage.mIcon.medit, frmMessage.mButtons.mAccept);
                Save_B.Enabled = false;
            }
        }
    }
}