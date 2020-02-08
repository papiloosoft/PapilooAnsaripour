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
	public class MyDataGridView : DataGridView
	{
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			//Add your custom paint code here
		}
		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				base.ProcessTabKey(Keys.Tab);
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}
		protected override bool ProcessDataGridViewKey(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				base.ProcessTabKey(Keys.Tab);
				return true;
			}
			return base.ProcessDataGridViewKey(e);
		}
		//Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
		//    If keyData = Keys.Tab Then
		//        Dim iCol = MyBase.CurrentCell.ColumnIndex + 1
		//        Do While iCol < MyBase.Columns.Count
		//            If MyBase.Columns(iCol).ReadOnly = False Then Exit Do
		//            iCol = iCol + 1
		//        Loop
		//        If iCol < MyBase.Columns.Count Then
		//            MyBase.CurrentCell = MyBase.Rows(MyBase.CurrentCell.RowIndex).Cells(iCol)
		//        Else
		//            If MyBase.CurrentCell.RowIndex = MyBase.Rows.Count - 1 Then
		//                For iCol = 0 To MyBase.CurrentCell.ColumnIndex
		//                    If MyBase.Columns(iCol).ReadOnly = False Then Exit For
		//                Next
		//                If iCol <= MyBase.CurrentCell.ColumnIndex Then
		//                    If MyBase.CurrentCell.RowIndex + 1 < MyBase.Rows.Count Then
		//                        MyBase.CurrentCell = MyBase.Rows(MyBase.CurrentCell.RowIndex + 1).Cells(iCol)
		//                    Else
		//                        MyBase.CurrentCell = MyBase.Rows(0).Cells(iCol)
		//                    End If
		//                End If
		//            End If
		//        End If
		//        Return True
		//    End If
		//    Return MyBase.ProcessDialogKey(keyData)
		//End Function
		//Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
		//    If e.KeyData = Keys.Tab Then
		//        Dim iCol As Integer = MyBase.CurrentCell.ColumnIndex + 1
		//        Do While iCol < MyBase.Columns.Count
		//            If MyBase.Columns(iCol).ReadOnly = False Then Exit Do
		//            iCol = iCol + 1
		//        Loop
		//        If iCol < MyBase.Columns.Count Then
		//            MyBase.CurrentCell = MyBase.Rows(MyBase.CurrentCell.RowIndex).Cells(iCol)
		//        Else
		//            For iCol = 0 To MyBase.CurrentCell.ColumnIndex
		//                If MyBase.Columns(iCol).ReadOnly = False Then
		//                    Exit For
		//                End If
		//            Next
		//            If iCol <= MyBase.CurrentCell.ColumnIndex Then
		//                If MyBase.CurrentCell.RowIndex + 1 < MyBase.Rows.Count Then
		//                    MyBase.CurrentCell = MyBase.Rows(MyBase.CurrentCell.RowIndex + 1).Cells(iCol)
		//                Else
		//                    MyBase.CurrentCell = MyBase.Rows(0).Cells(iCol)
		//                End If
		//            End If
		//        End If
		//        Return True
		//    End If
		//    Return MyBase.ProcessDataGridViewKey(e)
		//End Function
	}

}