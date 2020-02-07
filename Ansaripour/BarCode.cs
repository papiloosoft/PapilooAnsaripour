//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System.Collections;
using System.ComponentModel;


namespace Ansaripour
{
	public class BarCode : System.Windows.Forms.UserControl
	{
#region GUI Members 
		private System.Windows.Forms.Panel panel1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.ComponentModel.Container components = null;
#endregion

#region Instance Members

		private AlignType align = AlignType.Center;
		private string code = "1AA66831";
		//INSTANT VB NOTE: The variable leftMargin was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private int leftMargin_Renamed = 10;
		//INSTANT VB NOTE: The variable topMargin was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private int topMargin_Renamed = 10;
		//INSTANT VB NOTE: The variable height was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private int height_Renamed = 50;
		//INSTANT VB NOTE: The variable showHeader was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private bool showHeader_Renamed;
		//INSTANT VB NOTE: The variable showFooter was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private bool showFooter_Renamed;
		//INSTANT VB NOTE: The variable headerText was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private string headerText_Renamed = "UGD";
		//INSTANT VB NOTE: The variable weight was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private BarCodeWeight weight_Renamed = BarCodeWeight.Small;
		//INSTANT VB NOTE: The variable headerFont was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private Font headerFont_Renamed = new Font("Courier", 18);
		//INSTANT VB NOTE: The variable footerFont was renamed since Visual Basic does not allow variables and other class members to have the same name:
		private Font footerFont_Renamed = new Font("Courier", 8);

#endregion

#region Public Properties

#region VerAlign
		public virtual AlignType VertAlign
		{
			get
			{
				return align;
			}
			set
			{
				align = value;
				panel1.Invalidate();
			}
		}
#endregion

#region BarCode
//INSTANT C# NOTE: This member was renamed since members cannot have the same name as their enclosing type in C#:
		public virtual string BarCode_Conflict
		{
			get
			{
				return code;
			}
			set
			{
				code = value.ToUpper();
				panel1.Invalidate();
			}
		}
#endregion

#region BarCodeHeight
		public virtual int BarCodeHeight
		{
			get
			{
				return height_Renamed;
			}
			set
			{
				height_Renamed = value;
				panel1.Invalidate();
			}
		}
#endregion

#region LeftMargin
		public virtual int LeftMargin
		{
			get
			{
				return leftMargin_Renamed;
			}
			set
			{
				leftMargin_Renamed = value;
				panel1.Invalidate();
			}
		}
#endregion

#region TopMargin
		public virtual int TopMargin
		{
			get
			{
				return topMargin_Renamed;
			}
			set
			{
				topMargin_Renamed = value;
				panel1.Invalidate();
			}
		}
#endregion

#region ShowHeader
		public virtual bool ShowHeader
		{
			get
			{
				return showHeader_Renamed;
			}
			set
			{
				showHeader_Renamed = value;
				panel1.Invalidate();
			}
		}
#endregion

#region ShowFooter
		public virtual bool ShowFooter
		{
			get
			{
				return showFooter_Renamed;
			}
			set
			{
				showFooter_Renamed = value;
				panel1.Invalidate();
			}
		}
#endregion

#region HeaderText
		public virtual string HeaderText
		{
			get
			{
				return headerText_Renamed;
			}
			set
			{
				headerText_Renamed = value;
				panel1.Invalidate();
			}
		}
#endregion

#region Weight
		public virtual BarCodeWeight Weight
		{
			get
			{
				return weight_Renamed;
			}

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
