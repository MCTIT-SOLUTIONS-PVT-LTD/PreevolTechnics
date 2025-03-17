Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Public Class XR_WorkOrder
    Private Sub XrTable3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable3.BeforePrint

        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String

        Dim daLI As OleDbDataAdapter
        Dim dtLI As New DataTable
        Dim sqlLineItems As String

        Dim i, j As Integer
        sqlCgst = "SELECT DISTINCT CGSTRate from WorkOrderDetail Where WorkOrderID = " + WO.Value.ToString()
        sqlLineItems = "SELECT TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt from WorkOrderDetail Where WorkOrderID = " + WO.Value.ToString()

        Try
            daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
            daCgst.Fill(dtCgst)
            daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
            daLI.Fill(dtLI)

            Dim list1 As New List(Of Object)
            Dim list2 As New List(Of Object)
            For i = 0 To dtCgst.Rows.Count - 1
                list1.Add(dtCgst.Rows(i).Item(0))
            Next

            For i = 0 To list1.Count - 1
                Dim row As New DevExpress.XtraReports.UI.XRTableRow()
                Dim taxableVal As New DevExpress.XtraReports.UI.XRTableCell()
                Dim cgstRate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim cgstAmt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim sgstRate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim sgstAmt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim taxVal As Decimal
                Dim cgstAmnt As Decimal
                Dim sgstAmnt As Decimal
                taxVal = 0
                cgstAmnt = 0
                sgstAmnt = 0

                For j = 0 To dtLI.Rows.Count - 1
                    If CDec(list1.Item(i).ToString()) = Convert.ToDecimal(dtLI.Rows(j).Item(1)) Then
                        taxVal = taxVal + Convert.ToDecimal(dtLI.Rows(j).Item(0))
                        cgstAmnt = cgstAmnt + Convert.ToDecimal(dtLI.Rows(j).Item(2))
                        sgstAmnt = sgstAmnt + Convert.ToDecimal(dtLI.Rows(j).Item(4))
                    End If
                Next

                taxableVal.Borders = BorderSide.Bottom Or BorderSide.Left
                taxableVal.WidthF = 84
                If PubPrice Then
                    taxableVal.TextAlignment = TextAlignment.MiddleCenter
                    taxableVal.Text = "-"
                Else
                    taxableVal.Text = Math.Round(taxVal, 2).ToString("F2")
                    taxableVal.TextAlignment = TextAlignment.MiddleRight
                End If

                cgstRate.Borders = BorderSide.Bottom Or BorderSide.Left
                cgstRate.Text = list1.Item(i).ToString() + "%"
                cgstRate.TextAlignment = TextAlignment.MiddleRight
                cgstRate.WidthF = 80

                cgstAmt.Borders = BorderSide.Bottom Or BorderSide.Left
                cgstAmt.WidthF = 82
                If PubPrice Then
                    cgstAmt.Text = "-"
                    cgstAmt.TextAlignment = TextAlignment.MiddleCenter
                Else
                    cgstAmt.Text = Math.Round(cgstAmnt, 2).ToString("F2")
                    cgstAmt.TextAlignment = TextAlignment.MiddleRight
                End If

                sgstRate.Borders = BorderSide.Bottom Or BorderSide.Left
                sgstRate.Text = list1.Item(i).ToString() + "%"
                sgstRate.TextAlignment = TextAlignment.MiddleRight
                sgstRate.WidthF = 78

                sgstAmt.Borders = BorderSide.Bottom Or BorderSide.Left
                sgstAmt.WidthF = 82.61
                If PubPrice Then
                    sgstAmt.Text = "-"
                    sgstAmt.TextAlignment = TextAlignment.MiddleCenter
                Else
                    sgstAmt.Text = Math.Round(sgstAmnt, 2).ToString("F2")
                    sgstAmt.TextAlignment = TextAlignment.MiddleRight
                End If

                row.Cells.Add(taxableVal)
                row.Cells.Add(cgstRate)
                row.Cells.Add(cgstAmt)
                row.Cells.Add(sgstRate)
                row.Cells.Add(sgstAmt)
                'row.Borders = BorderSide.All
                XrTable3.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub XrTable1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable1.BeforePrint
        If Not PubPrice Then
            Dim i, j, diff As Integer
            i = XrTable1.Rows.Count
            j = XrTable3.Rows.Count
            If i <> j Then
                diff = j - i
                Dim k As Integer

                For k = 1 To diff - 1
                    Dim row As New DevExpress.XtraReports.UI.XRTableRow()

                    row.Borders = BorderSide.Bottom
                    XrTable1.Rows.Add(row)
                Next

            End If
        End If
    End Sub

    Private Sub XrLabel42_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrLabel42.BeforePrint
        If PubPrice Then
            XrLabel42.Text = "-"
            XrLabel42.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrLabel128_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrLabel128.BeforePrint
        If PubPrice Then
            XrLabel128.Text = "-"
            XrLabel128.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrLabel130_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrLabel130.BeforePrint
        If PubPrice Then
            XrLabel130.Text = "-"
            XrLabel130.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrLabel131_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrLabel131.BeforePrint
        If PubPrice Then
            XrLabel131.Text = "-"
            XrLabel131.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrTableCell3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTableCell3.BeforePrint
        If PubPrice Then
            XrTableCell3.Text = "-"
            XrTableCell3.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrTableCell31_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTableCell31.BeforePrint
        If PubPrice Then
            XrTableCell31.Text = "-"
            XrTableCell31.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrTableCell36_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTableCell36.BeforePrint
        If PubPrice Then
            XrTableCell36.Text = "-"
            XrTableCell36.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrTableCell40_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTableCell40.BeforePrint
        If PubPrice Then
            XrTableCell40.Text = "-"
            XrTableCell40.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrLabel2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrLabel2.BeforePrint
        If PubPrice Then
            XrLabel2.Text = "-"
            XrLabel2.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrLabel5_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrLabel5.BeforePrint
        If PubPrice Then
            XrLabel5.Text = "-"
            XrLabel5.TextAlignment = TextAlignment.MiddleCenter
        End If
    End Sub

    Private Sub XrTable4_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable4.BeforePrint
        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String
        sqlCgst = "SELECT ProductName, Description, HSNACS, UOM, Qty, Rate, Amount, Discount, DiscountVal, TaxableValue, CGSTRate, CGSTAmt, SGSTRate, SGSTAmt, TotalAmount from WorkOrderDetail Where WorkOrderID = " + WO.Value.ToString()
        Try
            daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
            daCgst.Fill(dtCgst)

            For i = 0 To dtCgst.Rows.Count - 1
                Dim RefVal As Integer
                RefVal = i + 1
                Dim row As New DevExpress.XtraReports.UI.XRTableRow()
                Dim Ref As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Prod As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Hsn As New DevExpress.XtraReports.UI.XRTableCell()
                Dim UOM As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Qty As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Rate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Amt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Dis As New DevExpress.XtraReports.UI.XRTableCell()
                Dim DisVal As New DevExpress.XtraReports.UI.XRTableCell()
                Dim TaxVal As New DevExpress.XtraReports.UI.XRTableCell()
                Dim cgstRate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim cgstAmt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim sgstRate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim sgstAmt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Total As New DevExpress.XtraReports.UI.XRTableCell()

                Ref.Borders = BorderSide.Left Or BorderSide.Bottom Or BorderSide.Top
                Ref.TextAlignment = TextAlignment.MiddleCenter
                Ref.Text = RefVal.ToString()
                Ref.WidthF = 19.2

                If (dtCgst.Rows(i).Item(1) Is DBNull.Value) Then
                    Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = (2)
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString()
                    Prod.WidthF = 133.59
                Else
                    Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = (2)
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString() & Environment.NewLine & dtCgst.Rows(i).Item(1).ToString()
                    Prod.Multiline = True
                    Prod.WidthF = 133.59
                End If

                Hsn.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Hsn.TextAlignment = TextAlignment.MiddleCenter
                Hsn.Text = dtCgst.Rows(i).Item(2).ToString()
                Hsn.WidthF = 50

                UOM.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                UOM.TextAlignment = TextAlignment.MiddleCenter
                UOM.Padding = (2)
                UOM.Text = dtCgst.Rows(i).Item(3).ToString()
                UOM.WidthF = 30

                Qty.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Qty.TextAlignment = TextAlignment.MiddleCenter
                Qty.Text = dtCgst.Rows(i).Item(4).ToString()
                Qty.WidthF = 35

                Rate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim rte As Decimal
                rte = Convert.ToDecimal(dtCgst.Rows(i).Item(5))
                Rate.Text = Math.Round(rte, 2).ToString("F2")
                Rate.TextAlignment = TextAlignment.MiddleRight
                Rate.WidthF = 60

                Amt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim amount As Decimal
                amount = Convert.ToDecimal(dtCgst.Rows(i).Item(6))
                Amt.Text = Math.Round(amount, 2).ToString("F2")
                Amt.TextAlignment = TextAlignment.MiddleRight
                Amt.WidthF = 59.14

                If (dtCgst.Rows(i).Item(7) Is DBNull.Value) Then
                    Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dis.TextAlignment = TextAlignment.MiddleRight
                    Dis.Text = dtCgst.Rows(i).Item(7).ToString()
                    Dis.WidthF = 33
                Else
                    Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dim discount As Decimal
                    discount = Convert.ToDecimal(dtCgst.Rows(i).Item(7))
                    Dis.Text = Math.Round(discount, 2).ToString("F2")
                    Dis.TextAlignment = TextAlignment.MiddleRight
                    Dis.WidthF = 33
                End If
                If (dtCgst.Rows(i).Item(8) Is DBNull.Value) Then
                    DisVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    DisVal.TextAlignment = TextAlignment.MiddleRight
                    DisVal.Text = dtCgst.Rows(i).Item(8).ToString()
                    DisVal.WidthF = 51.82
                Else
                    DisVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dim discount As Decimal
                    discount = Convert.ToDecimal(dtCgst.Rows(i).Item(8))
                    DisVal.Text = Math.Round(discount, 2).ToString("F2")
                    DisVal.TextAlignment = TextAlignment.MiddleRight
                    DisVal.WidthF = 51.82
                End If
                TaxVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim taxableVal As Decimal
                taxableVal = Convert.ToDecimal(dtCgst.Rows(i).Item(9))
                TaxVal.Text = Math.Round(taxableVal, 2).ToString("F2")
                TaxVal.TextAlignment = TextAlignment.MiddleRight
                TaxVal.WidthF = 63

                cgstRate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                cgstRate.Text = dtCgst.Rows(i).Item(10).ToString() + "%"
                cgstRate.TextAlignment = TextAlignment.MiddleRight
                cgstRate.WidthF = 26

                cgstAmt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim camt As Decimal
                camt = Convert.ToDecimal(dtCgst.Rows(i).Item(11))
                cgstAmt.Text = Math.Round(camt, 2).ToString("F2")
                cgstAmt.TextAlignment = TextAlignment.MiddleRight
                cgstAmt.WidthF = 63.73

                sgstRate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                sgstRate.Text = dtCgst.Rows(i).Item(12).ToString() + "%"
                sgstRate.TextAlignment = TextAlignment.MiddleRight
                sgstRate.WidthF = 26

                sgstAmt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim samt As Decimal
                samt = Convert.ToDecimal(dtCgst.Rows(i).Item(13))
                sgstAmt.Text = Math.Round(samt, 2).ToString("F2")
                sgstAmt.TextAlignment = TextAlignment.MiddleRight
                sgstAmt.WidthF = 62.4

                Total.Borders = BorderSide.All
                Dim ttl As Decimal
                ttl = Convert.ToDecimal(dtCgst.Rows(i).Item(14))
                Total.Text = Math.Round(ttl, 2).ToString("F2")
                Total.TextAlignment = TextAlignment.MiddleRight
                Total.WidthF = 64.76

                row.Cells.Add(Ref)
                row.Cells.Add(Prod)
                row.Cells.Add(Hsn)
                row.Cells.Add(UOM)
                row.Cells.Add(Qty)
                row.Cells.Add(Rate)
                row.Cells.Add(Amt)
                row.Cells.Add(Dis)
                row.Cells.Add(DisVal)
                row.Cells.Add(TaxVal)
                row.Cells.Add(cgstRate)
                row.Cells.Add(cgstAmt)
                row.Cells.Add(sgstRate)
                row.Cells.Add(sgstAmt)
                row.Cells.Add(Total)
                'row.Borders = BorderSide.All
                XrTable4.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class