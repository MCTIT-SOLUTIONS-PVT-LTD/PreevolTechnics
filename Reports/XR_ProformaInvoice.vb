﻿Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Public Class XR_ProformaInvoice
    Private Sub XrTable3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable3.BeforePrint
        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String

        Dim daLI As OleDbDataAdapter
        Dim dtLI As New DataTable
        Dim sqlLineItems As String

        Dim daPacking As OleDbDataAdapter
        Dim dtPacking As New DataTable
        Dim sqlPacking As String

        Dim i, j As Integer
        sqlCgst = "SELECT DISTINCT CGSTRate from ProformaInvoiceDetail Where ProformaInvoiceID = " + Invoice.Value.ToString()
        sqlLineItems = "SELECT TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt from ProformaInvoiceDetail Where ProformaInvoiceID = " + Invoice.Value.ToString()
        sqlPacking = "SELECT PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt from ProformaInvoice Where ProformaInvoiceID = " + Invoice.Value.ToString()

        Try
            daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
            daCgst.Fill(dtCgst)
            daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
            daLI.Fill(dtLI)
            daPacking = New OleDbDataAdapter(sqlPacking, ConStr)
            daPacking.Fill(dtPacking)
            Dim list1 As New List(Of Object)
            Dim list2 As New List(Of Object)
            For i = 0 To dtCgst.Rows.Count - 1
                list1.Add(dtCgst.Rows(i).Item(0))
            Next
            For j = 0 To dtPacking.Rows.Count - 1
                Dim Pcharge As Double
                Pcharge = CDec(dtPacking.Rows(j).Item(0))

                If Not list1.Contains(dtPacking.Rows(j).Item(1)) And Not Pcharge = 0 Then
                    list1.Add(dtPacking.Rows(j).Item(1))
                End If
            Next
            'For i = 0 To list1.Count - 1
            '    MsgBox("Value = " + list1.Item(i).ToString())
            'Next

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
                For j = 0 To dtPacking.Rows.Count - 1
                    If CDec(list1.Item(i).ToString()) = Convert.ToDecimal(dtPacking.Rows(j).Item(1)) Then
                        taxVal = taxVal + Convert.ToDecimal(dtPacking.Rows(j).Item(0))
                        cgstAmnt = cgstAmnt + Convert.ToDecimal(dtPacking.Rows(j).Item(2))
                        sgstAmnt = sgstAmnt + Convert.ToDecimal(dtPacking.Rows(j).Item(4))
                    End If
                Next


                taxableVal.Borders = BorderSide.Bottom Or BorderSide.Left
                taxableVal.TextAlignment = TextAlignment.MiddleRight
                taxableVal.Text = Math.Round(taxVal, 2).ToString("F2")
                taxableVal.WidthF = 83.71

                cgstRate.Text = list1.Item(i).ToString() + "%"
                cgstRate.Borders = BorderSide.Bottom Or BorderSide.Left
                cgstRate.TextAlignment = TextAlignment.MiddleRight
                cgstRate.WidthF = 80
                cgstAmt.Text = Math.Round(cgstAmnt, 2).ToString("F2")
                cgstAmt.Borders = BorderSide.Bottom Or BorderSide.Left
                cgstAmt.TextAlignment = TextAlignment.MiddleRight
                cgstAmt.WidthF = 82

                sgstRate.Text = list1.Item(i).ToString() + "%"
                sgstRate.Borders = BorderSide.Bottom Or BorderSide.Left
                sgstRate.TextAlignment = TextAlignment.MiddleRight
                sgstRate.WidthF = 78
                sgstAmt.Text = Math.Round(sgstAmnt, 2).ToString("F2")
                sgstAmt.Borders = BorderSide.Bottom Or BorderSide.Left
                sgstAmt.TextAlignment = TextAlignment.MiddleRight
                sgstAmt.WidthF = 82.9

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
    End Sub

    Private Sub XrTable2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable2.BeforePrint
        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String
        sqlCgst = "SELECT ProductName, Description, HSNACS, UOM, Qty, Rate, Amount, Discount,  DiscountVal, TaxableValue, CGSTRate, CGSTAmt, SGSTRate, SGSTAmt, TotalAmount from ProformaInvoiceDetail Where ProformaInvoiceID = " + Invoice.Value.ToString()
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
                Ref.WidthF = 20

                If (dtCgst.Rows(i).Item(1) Is DBNull.Value) Then
                    Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = (2)
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString()
                    Prod.WidthF = 132.91
                Else
                    Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = (2)
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString() & Environment.NewLine & dtCgst.Rows(i).Item(1).ToString()
                    Prod.Multiline = True
                    Prod.WidthF = 132.91
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
                Amt.WidthF = 60

                If (dtCgst.Rows(i).Item(7) Is DBNull.Value) Then
                    Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dis.TextAlignment = TextAlignment.MiddleRight
                    Dis.Text = dtCgst.Rows(i).Item(7).ToString()
                    Dis.WidthF = 32.14
                Else
                    Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dim discount As Decimal
                    discount = Convert.ToDecimal(dtCgst.Rows(i).Item(7))
                    Dis.Text = Math.Round(discount, 2).ToString("F2")
                    Dis.TextAlignment = TextAlignment.MiddleRight
                    Dis.WidthF = 32.14
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
                Total.WidthF = 65

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
                XrTable2.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class