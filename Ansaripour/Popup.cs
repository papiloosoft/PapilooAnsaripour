//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

//Title:       Display any usercontrol as a popup menu
//Author:      Pascal GANAYE
//Email:       pascalcp@ganaye.com
//Environment: VB.NET 2003
//Keywords:    Popup, Contextual, Menu, Tooltip
//Level:       Beginner
//Description: This class let you show any usercontrol in XP style popup menu.

// feb 12, 2005 - Modification by Stumpy842 alias Steven Stover
//           Added line to prevent showing in taskbar 
//           Changed 4 dockpadding into one dockpadding.all


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

using System.ComponentModel;

namespace Ansaripour
{
	public class Popup : System.ComponentModel.Component
	{
		public Popup()
		{
			InitializeComponent();
		}

		public interface IPopupUserControl
		{
			bool AcceptPopupClosing();
		}
		public enum ePlacement
		{
			Left = 1,
			Right = 2,
			Top = 4,
			Bottom = 8,
			TopLeft = Top | Left,
			TopRight = Top | Right,
			BottomLeft = Bottom | Left,
			BottomRight = Bottom | Right
		}
		private bool mResizable = false;
		private Control mUserControl;
		private Control mParent;
		private ePlacement mPlacement = ePlacement.BottomLeft;
		private Color mBorderColor = Color.DarkGray;
		private int mAnimationSpeed = 150;
		private bool mShowShadow = true;
		private PopupForm mForm;
		public Popup(Control UserControl = null, Control parent = null)
		{
			mParent = parent;
			mUserControl = UserControl;
		}
		public void Show()
		{
			// I use a shared variable in PopupForm class level for this ShowShadow
			// because the CreateParams is called from within the form constructor 
			// and we need a way to inform the form if a shadow is nescessary or not
			PopupForm.mShowShadow = this.mShowShadow;
			if (mForm != null)
			{
				mForm.DoClose();
			}
			mForm = new PopupForm(this);
			OnDropDown(mParent, new EventArgs());
		}
		public void close()
		{
			// I use a shared variable in PopupForm class level for this ShowShadow
			// because the CreateParams is called from within the form constructor 
			// and we need a way to inform the form if a shadow is nescessary or not
			mForm.DoClose();
		}
		// This internal class is a borderless form used to show the popup
		private class PopupForm : Form
		{
			public static bool mShowShadow;
			private bool mClosing;
			private const int BORDER_MARGIN = 1;
			private Timer mTimer;
			private Size mControlSize;
			private Size mWindowSize;
			private Point mNormalPos;
			private Rectangle mCurrentBounds;
			private Popup mPopup;
			private ePlacement mPlacement;
			private DateTime mTimerStarted;
			private double mProgress;
			private int mx;
			private int my;
			private bool mResizing;
			[System.Runtime.CompilerServices.AccessedThroughProperty(nameof(mResizingPanel))]
			private Panel _mResizingPanel;
			internal Panel mResizingPanel
			{
				[System.Diagnostics.DebuggerNonUserCode]
				get
				{
					return _mResizingPanel;
				}
				[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized), System.Diagnostics.DebuggerNonUserCode]
				set
				{
					if (_mResizingPanel != null)
					{
						_mResizingPanel.MouseUp -= mResizingPanel_MouseUp;
						_mResizingPanel.MouseMove -= mResizingPanel_MouseMove;
						_mResizingPanel.MouseDown -= mResizingPanel_MouseDown;
					}

					_mResizingPanel = value;

					if (value != null)
					{
						_mResizingPanel.MouseUp += mResizingPanel_MouseUp;
						_mResizingPanel.MouseMove += mResizingPanel_MouseMove;
						_mResizingPanel.MouseDown += mResizingPanel_MouseDown;
					}
				}
			}
			private const int CS_DROPSHADOW = 0x20000;
			private static System.Drawing.Image mBackgroundImage;
			public delegate void DropDownEventHandler(object Sender, EventArgs e);
			public event DropDownEventHandler DropDown;
			public delegate void DropDownClosedEventHandler(object Sender, EventArgs e);
			public event DropDownClosedEventHandler DropDownClosed;
			public PopupForm(Popup popup)
			{
				mPopup = popup;
				SetStyle(ControlStyles.ResizeRedraw, true);
				FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
				StartPosition = FormStartPosition.Manual;
				this.ShowInTaskbar = false;
				this.DockPadding.All = BORDER_MARGIN;
				mControlSize = mPopup.mUserControl.Size;
				mPopup.mUserControl.Dock = DockStyle.Fill;
				Controls.Add(mPopup.mUserControl);
				mWindowSize.Width = mControlSize.Width + 2 * BORDER_MARGIN;
				mWindowSize.Height = mControlSize.Height + 2 * BORDER_MARGIN;
				Form parentForm = mPopup.mParent.FindForm();
				if (parentForm != null)
				{
					parentForm.AddOwnedForm(this);
				}

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
