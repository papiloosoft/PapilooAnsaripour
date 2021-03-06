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
	public partial class frmMessage
	{
#region  Variables 
		public enum mIcon: int
		{
			mOk = 0,
			mInfo = 1,
			mQuestion = 2,
			mNo = 3,
			mStop = 4,
			mTools = 5,
			mwarning = 6,
			mKey = 7,
			mRefresh = 8,
			mStandBy = 9,
			mTrash = 10,
			msave = 11,
			medit = 12,
			mflash = 13,
			mlock = 14,
			munlock = 15,
			mclock = 16,
			mserch = 17,
			mzoom = 18,
			mprint = 19
		}
		public enum mButtons: int
		{
			mAbortar_Reintentar_Ignorar = 0,
			mAccept = 1,
			mAceptar_Cancelar = 2,
			mReintentar_Cancelar = 3,
			myes_No = 4,
			myes_No_Cancelar = 5,
			mnb = 6
		}
		public enum mReturnValue: int
		{
			mAbortar = 0,
			mReintentar = 1,
			mIgnorar = 2,
			mAccept = 3,
			mCancelar = 4,
			myes = 5,
			mNo = 6
		}
		private string mVarTitle;
		private string mVarText;
		private mIcon mVarIcono;
		private int mVarIcon;
		private mButtons mVarButtons;
		private mReturnValue mVarReturnValue;
#endregion
#region  کیس بندی
		public frmMessage()
		{
			InitializeComponent();
			mVarTitle = "نمونه سربرگ";
			mVarText = "متن خالی";
			mVarIcono = mIcon.mInfo;
			mVarButtons = mButtons.mAccept;
			mVarReturnValue = (Ansaripour.frmMessage.mReturnValue)4;
			button_03.Visible = false;
			button_02.Visible = false;
			button_01.Visible = true;
		}
		~frmMessage()
		{
//INSTANT C# NOTE: The base class Finalize method is automatically called from the destructor:
			//base.Finalize();
		}
		public string TitleMessage
		{
			//Establece o devuelve el tيtulo del mensaje.
			get
			{
				return mVarTitle;
			}
			set
			{
				mVarTitle = value;
				lblTitle.Text = mVarTitle;
			}
		}
		public string TextMessage
		{
			//Establece o devuelve el texto del mensaje.
			get
			{
				return mVarText;
			}
			set
			{
				mVarText = value;
				txtMessage.Text = value;
			}
		}
		public mIcon IconoMensaje
		{
			//Establece o devuelve el icono del mensaje.
			get
			{
				return (mIcon)mVarIcon;
			}
			set
			{
				mVarIcono = value;
			}
		}
		public mButtons Buttons
		{
			//Establece o devuelve los botones a mostrar.
			get
			{
				return mVarButtons;
			}
			set
			{
				mVarButtons = value;
				ConfigButtons();
			}
		}
		public mReturnValue ReturnValue
		{
			get
			{
				return (mVarReturnValue);
			}
			set
			{
				mVarReturnValue = value;
			}
		}
		public void ConfigForm(string vTitle, string vText, mIcon vIcon, mButtons vButtons)
		{
			mVarTitle = vTitle;
private void frmMessage_Load(object sender, EventArgs e)
        {

        }
//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
