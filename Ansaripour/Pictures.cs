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
using System.Linq;
using System.Xml.Linq;

using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace Ansaripour
{
	public partial class Pictures
	{
		public Pictures()
		{
			InitializeComponent();
		}

		public static Image Image;
		private Bitmap img;
		private Bitmap img_Old;
		private string maText;
		private string mbText;
		private string mcText;
		private string str_7 = "";
		private int i_num = 0;
		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private Resizer rs = new Resizer();
		  public void ConfigForm(string ATitle, string AText, string BText)
		  {
			this.Text = ATitle;
			maText = AText;
			mbText = BText;
		}
		private void Pic_Load()
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png";
			open.Title = "الصاق تصویر ";
			open.Multiselect = false;
			open.RestoreDirectory = true;
			if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				str_7 = open.FileName;
				img = new Bitmap(Image.FromFile(str_7), new Size(Convert.ToInt32(Image.FromFile(str_7).Size.Width * (Convert.ToSingle(CurrentSize.Text) / 100)), Convert.ToInt32(Image.FromFile(str_7).Size.Height * (Convert.ToSingle(CurrentSize.Text) / 100))));
				P_Pic.Image = img;
				img_Old = P_Pic.Image;
				string SizeKb = null;
				MemoryStream ms = new MemoryStream();
				img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				SizeKb = (ms.Length / 1024).ToString() + "کیلو بایت";
				lblCurrentSize.Text = "سایز عکس: " + SizeKb + "(" + img.Width + "x" + img.Height + ") [" + img.Width / (double)img.Height + "]";
				Microsoft.VisualBasic.VBMath.Randomize();
			}
			Save_B.Enabled = true;
		}
		private void New_B_Click(System.Object sender, System.EventArgs e)
		{
			Add = true;
			lblCurrentSize.Text = "";
			Pic_Load();
		}
		private void Edit_B_Click(System.Object sender, System.EventArgs e)
		{
			Add = false;
			Pic_Load();
		}
		private void Save_B_Click(System.Object sender, System.EventArgs e)
		{
			str_7 = Convert.ToString(data.ImageToBase64String(P_Pic.Image, ImageFormat.Jpeg));
			if (Add)
			{
				DataSet insert = data.PDataset("INSERT INTO Pictures(" + "Name_Data_Picture," + "Id_Data_Picture," + "Picture," + "Id_User )" + "VALUES  (N'" + maText + "',N'" + mbText + "'," + "N'" + str_7 + "',N'" + MDIParent1.DefaultInstance.ID.Text + "')");
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " اطلاعات با موفقیت ثبت شدند", frmMessage.mIcon.msave, frmMessage.mButtons.mAccept);
				Save_B.Enabled = false;
				Add = false;
			}
			else
			{
				DataSet update = data.PDataset("UPDATE  Pictures  SET  " + "Picture='" + str_7 + "'," + "Id_User='" + MDIParent1.DefaultInstance.ID.Text + "' where Id_Picture LIKE N'" + mcText + "'");
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " اطلاعات با موفقیت ویرایش شدند", frmMessage.mIcon.medit, frmMessage.mButtons.mAccept);
				Save_B.Enabled = false;
			}
		}
		private void Delet_B_Click(System.Object sender, System.EventArgs e)
		{
			modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " آیا از حذف اطلاعات خود مطمئن هستید؟", frmMessage.mIcon.mQuestion, frmMessage.mButtons.myes_No);
			if (modMessage.MessageValue == 5)
			{
				DataSet delete = data.PDataset("DELETE  FROM  Pictures  where Id_Picture LIKE N'" + mcText + "'");
				P_Pic.Image.Dispose();
				P_Pic.Image = null;
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "اطلاعات مورد نظر شما از سیستم حذف شده است", frmMessage.mIcon.mTrash, frmMessage.mButtons.mAccept);
			}
		}
		private void B_First_Click(System.Object sender, System.EventArgs e)
		{
			DataSet serch = data.PDataset("select * from Pictures where Id_Picture=(select Min(Id_Picture) FROM Pictures where Name_Data_Picture=N'" + maText + "' and Id_Data_Picture=N'" + mbText + "')");
			foreach (DataRow Dr in serch.Tables[0].Rows)
			{
				if (!Convert.IsDBNull(Dr[0]))
				{
					CurrentSize.Text = "100";
					img = new Bitmap(data.ImageFromBase64String(Convert.ToString(Dr["Picture"])), new Size(Convert.ToInt32(data.ImageFromBase64String(Convert.ToString(Dr["Picture"])).Size.Width * (Convert.ToSingle(CurrentSize.Text) / 100)), Convert.ToInt32(data.ImageFromBase64String(Convert.ToString(Dr["Picture"])).Size.Height * (Convert.ToSingle(CurrentSize.Text) / 100))));
					P_Pic.Image = img;
					img_Old = P_Pic.Image;
					string SizeKb = null;
					MemoryStream ms = new MemoryStream();
					img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					SizeKb = (ms.Length / 1024).ToString() + "کیلو بایت";
					lblCurrentSize.Text = "سایز عکس: " + SizeKb + "(" + img.Width + "x" + img.Height + ") [" + img.Width / (double)img.Height + "]";
					mcText = Convert.ToString(Dr["Id_Picture"]);
					Number_Text.Text = "1" + "از" + i_num;
				}
			}
		}
		private void Pictures_Load(object sender, System.EventArgs e)
		{
			rs.FindAllControls(this);
			DataSet serch = data.PDataset("select * from Pictures where Name_Data_Picture=N'" + maText + "' and Id_Data_Picture=N'" + mbText + "'");
			foreach (DataRow Dr in serch.Tables[0].Rows)
			{
				if (!Convert.IsDBNull(Dr[0]))
				{
					CurrentSize.Text = "100";
					img = new Bitmap(data.ImageFromBase64String(Convert.ToString(Dr["Picture"])), new Size(Convert.ToInt32(data.ImageFromBase64String(Convert.ToString(Dr["Picture"])).Size.Width * (Convert.ToSingle(CurrentSize.Text) / 100)), Convert.ToInt32(data.ImageFromBase64String(Convert.ToString(Dr["Picture"])).Size.Height * (Convert.ToSingle(CurrentSize.Text) / 100))));
					P_Pic.Image = img;
					img_Old = P_Pic.Image;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
