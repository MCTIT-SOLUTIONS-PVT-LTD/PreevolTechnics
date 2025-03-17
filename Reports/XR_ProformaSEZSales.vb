Imports System.Data.OleDb
Imports DevExpress.XtraPrinting

Public Class XR_ProformaSEZSales

    Dim daIgst As OleDbDataAdapter
    Dim dtIgst As New DataTable
    Dim daLI As OleDbDataAdapter
    Dim dtLI As New DataTable
    Dim daPacking As OleDbDataAdapter
    Dim dtPacking As New DataTable
    Dim sqlIgst As String
    Dim sqlLineItems As String
    Dim sqlPacking As String
    Dim i, j As Integer

    Private Sub XrTable1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable1.BeforePrint
        'Dim daIgst As OleDbDataAdapter
        'Dim dtIgst As New DataTable
        'Dim sqlIgst As String

        'Dim daLI As OleDbDataAdapter
        'Dim dtLI As New DataTable
        'Dim sqlLineItems As String

        'Dim daPacking As OleDbDataAdapter
        'Dim dtPacking As New DataTable
        'Dim sqlPacking As String

        'Dim i, j As Integer
        sqlIgst = "SELECT DISTINCT IGSTRate from ProformaInvoiceDetail Where ProformaInvoiceID = " + Invoice.Value.ToString()
        sqlLineItems = "SELECT TaxableValue,IGSTRate,IGSTAmt from ProformaInvoiceDetail Where ProformaInvoiceID = " + Invoice.Value.ToString()
        sqlPacking = "SELECT PackingCharge,PIGSTRate,PIGSTAmt from ProformaInvoice Where ProformaInvoiceID = " + Invoice.Value.ToString()

        Try
            daIgst = New OleDbDataAdapter(sqlIgst, ConStr)
            daIgst.Fill(dtIgst)
            daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
            daLI.Fill(dtLI)
            daPacking = New OleDbDataAdapter(sqlPacking, ConStr)
            daPacking.Fill(dtPacking)
            Dim list1 As New List(Of Object)
            Dim list2 As New List(Of Object)
            For i = 0 To dtIgst.Rows.Count - 1
                list1.Add(dtIgst.Rows(i).Item(0))
            Next
            For j = 0 To dtPacking.Rows.Count - 1
                Dim Pcharge As Double
                Pcharge = CDec(dtPacking.Rows(j).Item(0))

                If Not list1.Contains(dtPacking.Rows(j).Item(1)) And Not Pcharge = 0 Then
                    list1.Add(dtPacking.Rows(j).Item(1))
                End If
            Next
            For i = 0 To list1.Count - 1
                Dim row As New DevExpress.XtraReports.UI.XRTableRow()
                Dim taxableVal As New DevExpress.XtraReports.UI.XRTableCell()
                Dim igstRate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim igstAmt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim taxVal As Decimal
                Dim igstAmnt As Decimal
                taxVal = 0
                igstAmnt = 0

                For j = 0 To dtLI.Rows.Count - 1
                    If CDec(list1.Item(i).ToString()) = Convert.ToDecimal(dtLI.Rows(j).Item(1)) Then
                        taxVal = taxVal + Convert.ToDecimal(dtLI.Rows(j).Item(0))
                        igstAmnt = igstAmnt + Convert.ToDecimal(dtLI.Rows(j).Item(2))

                    End If
                Next
                For j = 0 To dtPacking.Rows.Count - 1
                    If CDec(list1.Item(i).ToString()) = Convert.ToDecimal(dtPacking.Rows(j).Item(1)) Then
                        taxVal = taxVal + Convert.ToDecimal(dtPacking.Rows(j).Item(0))
                        igstAmnt = igstAmnt + Convert.ToDecimal(dtPacking.Rows(j).Item(2))
                    End If
                Next

                taxableVal.Borders = BorderSide.Left Or BorderSide.Bottom
                taxableVal.TextAlignment = TextAlignment.MiddleRight
                taxableVal.Text = Math.Round(taxVal, 2).ToString("F2")
                taxableVal.WidthF = 100.1

                igstRate.Text = list1.Item(i).ToString() + "%"
                igstRate.Borders = BorderSide.Left Or BorderSide.Bottom
                igstRate.TextAlignment = TextAlignment.MiddleRight
                igstRate.WidthF = 100.1

                igstAmt.Text = Math.Round(igstAmnt, 2).ToString("F2")
                igstAmt.Borders = BorderSide.Left Or BorderSide.Bottom
                igstAmt.TextAlignment = TextAlignment.MiddleRight
                igstAmt.WidthF = 99.44

                row.Cells.Add(taxableVal)
                row.Cells.Add(igstRate)
                row.Cells.Add(igstAmt)

                XrTable1.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub XrTable4_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable4.BeforePrint
        Dim daIgst As OleDbDataAdapter
        Dim dtIgst As New DataTable
        Dim sqlIgst As String
        sqlIgst = "SELECT ProductName, Description, HSNACS, UOM, Qty, Rate, Amount, Discount, DiscountVal, TaxableValue, IGSTRate, IGSTAmt, TotalAmount from ProformaInvoiceDetail Where ProformaInvoiceID = " + Invoice.Value.ToString()
        Try
            daIgst = New OleDbDataAdapter(sqlIgst, ConStr)
            daIgst.Fill(dtIgst)

            For i = 0 To dtIgst.Rows.Count - 1
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
                Dim igstRate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim igstAmt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Total As New DevExpress.XtraReports.UI.XRTableCell()

                Ref.Borders = BorderSide.Left Or BorderSide.Bottom Or BorderSide.Top
                Ref.TextAlignment = TextAlignment.MiddleCenter
                Ref.Text = RefVal.ToString()
                Ref.WidthF = 30

                If (dtIgst.Rows(i).Item(1) Is DBNull.Value) Then
                    Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = (2)
                    Prod.Text = dtIgst.Rows(i).Item(0).ToString()
                    Prod.WidthF = 170
                Else
                    Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = (2)
                    Prod.Text = dtIgst.Rows(i).Item(0).ToString() & Environment.NewLine & dtIgst.Rows(i).Item(1).ToString()
                    Prod.Multiline = True
                    Prod.WidthF = 170
                End If

                Hsn.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Hsn.TextAlignment = TextAlignment.MiddleCenter
                Hsn.Text = dtIgst.Rows(i).Item(2).ToString()
                Hsn.WidthF = 50

                UOM.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                UOM.TextAlignment = TextAlignment.MiddleCenter
                UOM.Padding = (2)
                UOM.Text = dtIgst.Rows(i).Item(3).ToString()
                UOM.WidthF = 30

                Qty.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Qty.TextAlignment = TextAlignment.MiddleCenter
                Qty.Text = dtIgst.Rows(i).Item(4).ToString()
                Qty.WidthF = 52.67
                Rate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim rte As Decimal
                rte = Convert.ToDecimal(dtIgst.Rows(i).Item(5))
                Rate.Text = Math.Round(rte, 2).ToString("F2")
                Rate.TextAlignment = TextAlignment.MiddleRight
                Rate.WidthF = 59.73

                Amt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim amount As Decimal
                amount = Convert.ToDecimal(dtIgst.Rows(i).Item(6))
                Amt.Text = Math.Round(amount, 2).ToString("F2")
                Amt.TextAlignment = TextAlignment.MiddleRight
                Amt.WidthF = 59.16

                If (dtIgst.Rows(i).Item(7) Is DBNull.Value) Then
                    Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dis.TextAlignment = TextAlignment.MiddleRight
                    Dis.Text = dtIgst.Rows(i).Item(7).ToString()
                    Dis.WidthF = 34
                Else
                    Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dim discount As Decimal
                    discount = Convert.ToDecimal(dtIgst.Rows(i).Item(7))
                    Dis.Text = Math.Round(discount, 2).ToString("F2")
                    Dis.TextAlignment = TextAlignment.MiddleRight
                    Dis.WidthF = 34
                End If
                If (dtIgst.Rows(i).Item(8) Is DBNull.Value) Then
                    DisVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    DisVal.TextAlignment = TextAlignment.MiddleRight
                    DisVal.Text = dtIgst.Rows(i).Item(8).ToString()
                    DisVal.WidthF = 49.51
                Else
                    DisVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dim discount As Decimal
                    discount = Convert.ToDecimal(dtIgst.Rows(i).Item(8))
                    DisVal.Text = Math.Round(discount, 2).ToString("F2")
                    DisVal.TextAlignment = TextAlignment.MiddleRight
                    DisVal.WidthF = 49.51
                End If
                TaxVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim taxableVal As Decimal
                taxableVal = Convert.ToDecimal(dtIgst.Rows(i).Item(9))
                TaxVal.Text = Math.Round(taxableVal, 2).ToString("F2")
                TaxVal.TextAlignment = TextAlignment.MiddleRight
                TaxVal.WidthF = 51.5

                igstRate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                igstRate.Text = dtIgst.Rows(i).Item(10).ToString() + "%"
                igstRate.TextAlignment = TextAlignment.MiddleRight
                igstRate.WidthF = 26

                igstAmt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim iamt As Decimal
                iamt = Convert.ToDecimal(dtIgst.Rows(i).Item(11))
                igstAmt.Text = Math.Round(iamt, 2).ToString("F2")
                igstAmt.TextAlignment = TextAlignment.MiddleRight
                igstAmt.WidthF = 75.1

                Total.Borders = BorderSide.All
                Dim ttl As Decimal
                ttl = Convert.ToDecimal(dtIgst.Rows(i).Item(12))
                Total.Text = Math.Round(ttl, 2).ToString("F2")
                Total.TextAlignment = TextAlignment.MiddleRight
                Total.WidthF = 90

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
                row.Cells.Add(igstRate)
                row.Cells.Add(igstAmt)
                row.Cells.Add(Total)
                'row.Borders = BorderSide.All
                XrTable4.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub XrLabel1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrLabel1.BeforePrint
        XrLabel1.Text = "(""Supply meant for Export with payment of IGST"")"
    End Sub
End Class