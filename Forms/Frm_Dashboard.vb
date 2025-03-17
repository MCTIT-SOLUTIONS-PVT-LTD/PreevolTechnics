Imports System.Data.OleDb
Imports DevExpress.XtraEditors
'Imports ELCF
Public Class Frm_Dashboard
    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DT As New DataTable

        Dim DA As New OleDbDataAdapter("SELECT FullGoodsName, Description, UOM, OpeningQTY, ClosingQTY, ReOrderLevel, LastUpdated FROM Goods WHERE (ClosingQTY <= ReOrderLevel)", ConStr)
        DA.Fill(DT)
        GridControl1.DataSource = DT
        SetGrid()
    End Sub
    Sub SetGrid()
        With GridView1
            .Columns("FullGoodsName").Caption = "Item"
        End With
    End Sub
    Private Sub MoreHyperlinkLabelControl_Click(sender As Object, e As EventArgs) Handles MoreHyperlinkLabelControl.Click

        Dim ID = ShowRecordStock("SELECT GoodsID, FullGoodsName, Description, UOM, OpeningQTY, ClosingQTY, ReOrderLevel, LastUpdated FROM Goods", "GoodsID")

    End Sub
End Class