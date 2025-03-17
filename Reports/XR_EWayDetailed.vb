Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Public Class XR_EWayDetailed
    Private Sub XrTable2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable2.BeforePrint
        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String
        sqlCgst = "SELECT ProductName, Description, HSNACS, UOM, Qty, TaxableValue, CGSTRate, SGSTRate, IGSTRate from InvoiceDetail Where InvoiceID = " + Invoice.Value.ToString()
        Try
            daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
            daCgst.Fill(dtCgst)

            For i = 0 To dtCgst.Rows.Count - 1
                Dim RefVal As Integer
                RefVal = i + 1
                Dim row As New DevExpress.XtraReports.UI.XRTableRow()
                Dim Prod As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Hsn As New DevExpress.XtraReports.UI.XRTableCell()
                Dim UOM As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Qty As New DevExpress.XtraReports.UI.XRTableCell()
                Dim TaxVal As New DevExpress.XtraReports.UI.XRTableCell()
                Dim TaxRt As New DevExpress.XtraReports.UI.XRTableCell()
                Hsn.Borders = BorderSide.Bottom
                Hsn.TextAlignment = TextAlignment.MiddleCenter
                Hsn.Text = dtCgst.Rows(i).Item(2).ToString()
                Hsn.WidthF = 80.02

                If (dtCgst.Rows(i).Item(1) Is DBNull.Value) Then
                    Prod.Borders = BorderSide.Bottom
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = 2
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString()
                    Prod.WidthF = 350
                Else
                    Prod.Borders = BorderSide.Bottom
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = 2
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString() & Environment.NewLine & dtCgst.Rows(i).Item(1).ToString()
                    Prod.Multiline = True
                    Prod.WidthF = 350
                End If

                Qty.Borders = BorderSide.Bottom
                Qty.TextAlignment = TextAlignment.MiddleCenter
                Qty.Text = dtCgst.Rows(i).Item(4).ToString()
                Qty.WidthF = 60

                UOM.Borders = BorderSide.Bottom
                UOM.TextAlignment = TextAlignment.MiddleCenter
                UOM.Padding = 2
                UOM.Text = dtCgst.Rows(i).Item(3).ToString()
                UOM.WidthF = 35

                TaxVal.Borders = BorderSide.Bottom
                Dim taxableVal As Decimal
                taxableVal = Convert.ToDecimal(dtCgst.Rows(i).Item(5))
                TaxVal.Text = Math.Round(taxableVal, 2).ToString("F2")
                TaxVal.TextAlignment = TextAlignment.MiddleRight
                TaxVal.WidthF = 120
                If dtCgst.Rows(i).Item(6) <> 0 Then
                    TaxRt.Borders = BorderSide.Bottom
                    TaxRt.Text = dtCgst.Rows(i).Item(6).ToString + "+" + dtCgst.Rows(i).Item(7).ToString + "+NE+NE+0.00"
                    TaxRt.TextAlignment = TextAlignment.MiddleCenter
                    TaxRt.WidthF = 130.41
                Else
                    TaxRt.Borders = BorderSide.Bottom
                    TaxRt.Text = dtCgst.Rows(i).Item(8) + "+NE+NE+0.00"
                    TaxRt.TextAlignment = TextAlignment.MiddleCenter
                    TaxRt.WidthF = 130.41
                End If

                row.Cells.Add(Hsn)
                row.Cells.Add(Prod)
                row.Cells.Add(Qty)
                row.Cells.Add(UOM)
                row.Cells.Add(TaxVal)
                row.Cells.Add(TaxRt)
                XrTable2.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class