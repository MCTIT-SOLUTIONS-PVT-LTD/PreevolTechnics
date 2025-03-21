﻿Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Public Class XR_QuotationNewWithoutDis
    Dim TPump As Decimal
    Dim TSpares As Decimal
    Dim TLabour As Decimal
    Dim TPQty As Decimal
    Dim TSQty As Decimal
    Dim TLQty As Decimal
    Dim TPTaxVal As Decimal
    Dim TSTaxVal As Decimal
    Dim TLTaxVal As Decimal
    Dim TPGst As Decimal
    Dim TSGst As Decimal
    Dim TLGst As Decimal

    Dim myfont As New Font("Calibri", 9.75, FontStyle.Bold)
    Dim myHeading As New Font("Calibri", 12, FontStyle.Bold)
    Private Sub XrTable3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable3.BeforePrint
        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String

        Dim daLI As OleDbDataAdapter
        Dim dtLI As New DataTable
        Dim sqlLineItems As String

        Dim i, j As Integer
        sqlCgst = "SELECT DISTINCT GSTRate from QuotationDetail Where QuotationID = " + Invoice.Value.ToString()
        sqlLineItems = "SELECT TaxableValue,GSTRate,GSTAmt from QuotationDetail Where QuotationID = " + Invoice.Value.ToString()

        Try
            daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
            daCgst.Fill(dtCgst)
            daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
            daLI.Fill(dtLI)
            Dim list1 As New List(Of Object)

            For i = 0 To dtCgst.Rows.Count - 1
                list1.Add(dtCgst.Rows(i).Item(0))
            Next

            For i = 0 To list1.Count - 1
                Dim row As New XRTableRow()
                Dim taxableVal As New XRTableCell()
                Dim gstRate As New XRTableCell()
                Dim gstAmt As New XRTableCell()
                Dim taxVal As Decimal
                Dim gstAmnt As Decimal

                taxVal = 0
                gstAmnt = 0

                For j = 0 To dtLI.Rows.Count - 1
                    If CDec(list1.Item(i).ToString()) = Convert.ToDecimal(dtLI.Rows(j).Item(1)) Then
                        taxVal = taxVal + Convert.ToDecimal(dtLI.Rows(j).Item(0))
                        gstAmnt = gstAmnt + Convert.ToDecimal(dtLI.Rows(j).Item(2))

                    End If
                Next

                taxableVal.Borders = BorderSide.Bottom Or BorderSide.Left
                taxableVal.TextAlignment = TextAlignment.MiddleRight
                taxableVal.Text = Math.Round(taxVal, 2).ToString("F2")
                taxableVal.WidthF = 150

                gstRate.Text = list1.Item(i).ToString() + "%"
                gstRate.Borders = BorderSide.Bottom Or BorderSide.Left
                gstRate.TextAlignment = TextAlignment.MiddleRight
                gstRate.WidthF = 140
                gstAmt.Text = Math.Round(gstAmnt, 2).ToString("F2")
                gstAmt.Borders = BorderSide.Bottom Or BorderSide.Left
                gstAmt.TextAlignment = TextAlignment.MiddleRight
                gstAmt.WidthF = 152.31


                row.Cells.Add(taxableVal)
                row.Cells.Add(gstRate)
                row.Cells.Add(gstAmt)
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
                Dim row As New XRTableRow()

                row.Borders = BorderSide.Bottom
                XrTable1.Rows.Add(row)
            Next

        End If
    End Sub

    Private Sub XrTable4_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable4.BeforePrint
        Dim QTYTotal As Decimal
        'Query for fetch data of Pump category
        Dim daCgstPump As OleDbDataAdapter
        Dim dtCgstPump As New DataTable
        Dim sqlCgstPump As String
        sqlCgstPump = "SELECT ProductName, CategoryID, Description, HSNACS, UOM, Qty, Rate, Amount, Discount, TaxableValue, GSTRate, GSTAmt, TotalAmount from QuotationDetail Where CategoryID = 12 AND QuotationID = " + Invoice.Value.ToString()
        Try
            daCgstPump = New OleDbDataAdapter(sqlCgstPump, ConStr)
            daCgstPump.Fill(dtCgstPump)
            'Add Heading 
            If dtCgstPump.Rows.Count > 0 Then
                Dim row1 As New XRTableRow()
                Dim Ref1 As New XRTableCell()
                Dim Prod1 As New XRTableCell()
                Dim Hsn1 As New XRTableCell()
                Dim UOM1 As New XRTableCell()
                Dim Qty1 As New XRTableCell()
                Dim Rate1 As New XRTableCell()
                Dim Amt1 As New XRTableCell()
                'Dim Dis1 As New XRTableCell()
                Dim TaxVal1 As New XRTableCell()
                Dim cgstRate1 As New XRTableCell()
                Dim cgstAmt1 As New XRTableCell()
                Dim Total1 As New XRTableCell()

                Ref1.Borders = BorderSide.Left Or BorderSide.Top
                Ref1.Text = ""
                Ref1.WidthF = 20


                Prod1.Borders = BorderSide.Top Or BorderSide.Left
                Prod1.Text = "Pumps"
                Prod1.Padding = 2
                Prod1.Font = myHeading
                Prod1.WidthF = 200

                Hsn1.Borders = BorderSide.Top Or BorderSide.Left
                Hsn1.Text = ""
                Hsn1.WidthF = 60

                UOM1.Borders = BorderSide.Top Or BorderSide.Left
                UOM1.Text = ""
                UOM1.WidthF = 31

                Qty1.Borders = BorderSide.Top Or BorderSide.Left
                Qty1.Text = ""
                Qty1.WidthF = 60

                Rate1.Borders = BorderSide.Top Or BorderSide.Left
                Rate1.Text = ""
                Rate1.WidthF = 68

                Amt1.Borders = BorderSide.Top Or BorderSide.Left
                Amt1.Text = ""
                Amt1.WidthF = 68

                'Dis1.Borders = BorderSide.Top Or BorderSide.Left
                'Dis1.Text = ""
                'Dis1.WidthF = 37.48

                TaxVal1.Borders = BorderSide.Top Or BorderSide.Left
                TaxVal1.Text = ""
                TaxVal1.WidthF = 78.74

                cgstRate1.Borders = BorderSide.Top Or BorderSide.Left
                cgstRate1.Text = ""
                cgstRate1.WidthF = 30

                cgstAmt1.Borders = BorderSide.Top Or BorderSide.Left
                cgstAmt1.Text = ""
                cgstAmt1.WidthF = 76

                Total1.Borders = BorderSide.Top Or BorderSide.Left Or BorderSide.Right
                Total1.Text = ""
                Total1.WidthF = 86

                row1.Cells.Add(Ref1)
                row1.Cells.Add(Prod1)
                row1.Cells.Add(Hsn1)
                row1.Cells.Add(UOM1)
                row1.Cells.Add(Qty1)
                row1.Cells.Add(Rate1)
                row1.Cells.Add(Amt1)
                'row1.Cells.Add(Dis1)
                row1.Cells.Add(TaxVal1)
                row1.Cells.Add(cgstRate1)
                row1.Cells.Add(cgstAmt1)
                row1.Cells.Add(Total1)
                XrTable4.Rows.Add(row1)
            End If
            'Add LineItems
            For i = 0 To dtCgstPump.Rows.Count - 1
                Dim RefVal As Integer
                RefVal = i + 1
                Dim rows As New XRTableRow()
                Dim Refs As New XRTableCell()
                Dim Prods As New XRTableCell()
                Dim Hsns As New XRTableCell()
                Dim UOMs As New XRTableCell()
                Dim Qtys As New XRTableCell()
                Dim Rates As New XRTableCell()
                Dim Amts As New XRTableCell()
                'Dim Diss As New XRTableCell()
                Dim TaxVals As New XRTableCell()
                Dim cgstRates As New XRTableCell()
                Dim cgstAmts As New XRTableCell()
                Dim Totals As New XRTableCell()

                Refs.Borders = BorderSide.Left Or BorderSide.Bottom Or BorderSide.Top
                Refs.TextAlignment = TextAlignment.MiddleCenter
                Refs.Text = RefVal.ToString()
                Refs.WidthF = 20

                If (dtCgstPump.Rows(i).Item(1) Is DBNull.Value) Then
                    Prods.Text = dtCgstPump.Rows(i).Item(0).ToString()
                Else
                    Prods.Text = dtCgstPump.Rows(i).Item(0).ToString() & Environment.NewLine & dtCgstPump.Rows(i).Item(2).ToString()
                    Prods.Multiline = True
                End If
                Prods.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Prods.TextAlignment = TextAlignment.MiddleLeft
                Prods.Padding = 2
                Prods.WidthF = 200

                Hsns.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Hsns.TextAlignment = TextAlignment.MiddleCenter
                Hsns.Text = dtCgstPump.Rows(i).Item(3).ToString()
                Hsns.WidthF = 60

                UOMs.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                UOMs.TextAlignment = TextAlignment.MiddleCenter
                UOMs.Padding = 2
                UOMs.Text = dtCgstPump.Rows(i).Item(4).ToString()
                UOMs.WidthF = 31

                Qtys.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim q As Decimal
                q = Convert.ToDecimal(dtCgstPump.Rows(i).Item(5))
                Qtys.Text = Math.Round(q, 2).ToString("F2")
                Qtys.TextAlignment = TextAlignment.MiddleCenter
                Qtys.WidthF = 60
                QTYTotal = QTYTotal + q
                TPQty += q

                Rates.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim rte As Decimal
                rte = Convert.ToDecimal(dtCgstPump.Rows(i).Item(6))
                Rates.Text = Math.Round(rte, 2).ToString("F2")
                Rates.TextAlignment = TextAlignment.MiddleRight
                Rates.Padding = 2
                Rates.WidthF = 68

                Amts.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim amount As Decimal
                amount = Convert.ToDecimal(dtCgstPump.Rows(i).Item(7))
                Amts.Padding = 2
                Amts.Text = Math.Round(amount, 2).ToString("F2")
                Amts.TextAlignment = TextAlignment.MiddleRight
                Amts.WidthF = 68

                'If (dtCgstPump.Rows(i).Item(8) Is DBNull.Value) Then
                '    Diss.Text = dtCgstPump.Rows(i).Item(8).ToString()
                'Else
                '    Dim discount As Decimal
                '    discount = Convert.ToDecimal(dtCgstPump.Rows(i).Item(8))
                '    Diss.Text = Math.Round(discount, 2).ToString("F2")
                'End If
                'Diss.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                'Diss.TextAlignment = TextAlignment.MiddleRight
                'Diss.Padding = 2
                'Diss.WidthF = 37.48

                TaxVals.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim taxableVal As Decimal
                taxableVal = Convert.ToDecimal(dtCgstPump.Rows(i).Item(9))
                TaxVals.Text = Math.Round(taxableVal, 2).ToString("F2")
                TaxVals.TextAlignment = TextAlignment.MiddleRight
                TaxVals.Padding = 2
                TaxVals.WidthF = 78.74
                TPTaxVal += taxableVal

                cgstRates.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                cgstRates.Text = dtCgstPump.Rows(i).Item(10).ToString() + "%"
                cgstRates.TextAlignment = TextAlignment.MiddleRight
                cgstRates.Padding = 2
                cgstRates.WidthF = 30

                cgstAmts.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim camt As Decimal
                camt = Convert.ToDecimal(dtCgstPump.Rows(i).Item(11))
                cgstAmts.Text = Math.Round(camt, 2).ToString("F2")
                cgstAmts.TextAlignment = TextAlignment.MiddleRight
                cgstAmts.Padding = 2
                cgstAmts.WidthF = 76
                TPGst += camt

                Totals.Borders = BorderSide.All
                Dim ttl As Decimal
                ttl = Convert.ToDecimal(dtCgstPump.Rows(i).Item(12))
                Totals.Text = Math.Round(ttl, 2).ToString("F2")
                Totals.TextAlignment = TextAlignment.MiddleRight
                Totals.Padding = 2
                Totals.WidthF = 86
                TPump += ttl

                rows.Cells.Add(Refs)
                rows.Cells.Add(Prods)
                rows.Cells.Add(Hsns)
                rows.Cells.Add(UOMs)
                rows.Cells.Add(Qtys)
                rows.Cells.Add(Rates)
                rows.Cells.Add(Amts)
                'rows.Cells.Add(Diss)
                rows.Cells.Add(TaxVals)
                rows.Cells.Add(cgstRates)
                rows.Cells.Add(cgstAmts)
                rows.Cells.Add(Totals)
                XrTable4.Rows.Add(rows)
            Next
            'Add Grand Total row
            If dtCgstPump.Rows.Count > 0 Then
                Dim GTrow As New XRTableRow()

                Dim GTProd As New XRTableCell()
                Dim GTQty As New XRTableCell()
                Dim GTBlank As New XRTableCell()
                Dim GTTaxVal As New XRTableCell()
                Dim GTGstRate As New XRTableCell()
                Dim GTGst As New XRTableCell()
                Dim GTTotal As New XRTableCell()

                GTProd.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTProd.Text = "Total for Pumps"
                GTProd.Padding = 2
                GTProd.TextAlignment = TextAlignment.MiddleLeft
                GTProd.Font = myfont
                GTProd.WidthF = 311

                GTQty.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTQty.Text = Math.Round(TPQty, 2).ToString("F2")
                GTQty.Padding = 2
                GTQty.TextAlignment = TextAlignment.MiddleCenter
                GTQty.Font = myfont
                GTQty.WidthF = 60

                GTBlank.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTBlank.Text = ""
                GTBlank.WidthF = 135.67

                GTTaxVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTTaxVal.Text = Math.Round(TPTaxVal, 2).ToString("F2")
                GTTaxVal.Padding = 2
                GTTaxVal.TextAlignment = TextAlignment.MiddleRight
                GTTaxVal.Font = myfont
                GTTaxVal.WidthF = 78.74

                GTGstRate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTGstRate.Text = "-"
                GTGstRate.Padding = 2
                GTGstRate.TextAlignment = TextAlignment.MiddleCenter
                GTGstRate.Font = myfont
                GTGstRate.WidthF = 30

                GTGst.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTGst.Text = Math.Round(TPGst, 2).ToString("F2")
                GTGst.Padding = 2
                GTGst.TextAlignment = TextAlignment.MiddleRight
                GTGst.Font = myfont
                GTGst.WidthF = 76

                GTTotal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left Or BorderSide.Right
                GTTotal.Text = Math.Round(TPump, 2).ToString("F2")
                GTTotal.Padding = 2
                GTTotal.TextAlignment = TextAlignment.MiddleRight
                GTTotal.Font = myfont
                GTTotal.WidthF = 86

                GTrow.Cells.Add(GTProd)
                GTrow.Cells.Add(GTQty)
                GTrow.Cells.Add(GTBlank)
                GTrow.Cells.Add(GTTaxVal)
                GTrow.Cells.Add(GTGstRate)
                GTrow.Cells.Add(GTGst)
                GTrow.Cells.Add(GTTotal)
                XrTable4.Rows.Add(GTrow)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Query for fetch data of Spares category
        Dim daCgst1 As OleDbDataAdapter
        Dim dtCgst1 As New DataTable
        Dim sqlCgst1 As String
        sqlCgst1 = "SELECT ProductName, CategoryID, Description, HSNACS, UOM, Qty, Rate, Amount, Discount, TaxableValue, GSTRate, GSTAmt, TotalAmount from QuotationDetail Where CategoryID = 13 AND QuotationID = " + Invoice.Value.ToString()
        Try
            daCgst1 = New OleDbDataAdapter(sqlCgst1, ConStr)
            daCgst1.Fill(dtCgst1)
            'Add Heading 
            If dtCgst1.Rows.Count > 0 Then
                Dim row1 As New XRTableRow()
                Dim Ref1 As New XRTableCell()
                Dim Prod1 As New XRTableCell()
                Dim Hsn1 As New XRTableCell()
                Dim UOM1 As New XRTableCell()
                Dim Qty1 As New XRTableCell()
                Dim Rate1 As New XRTableCell()
                Dim Amt1 As New XRTableCell()
                'Dim Dis1 As New XRTableCell()
                Dim TaxVal1 As New XRTableCell()
                Dim cgstRate1 As New XRTableCell()
                Dim cgstAmt1 As New XRTableCell()
                Dim Total1 As New XRTableCell()

                Ref1.Borders = BorderSide.Left Or BorderSide.Top
                Ref1.Text = ""
                Ref1.WidthF = 20


                Prod1.Borders = BorderSide.Top Or BorderSide.Left
                Prod1.Text = "Spares"
                Prod1.Padding = 2
                Prod1.Font = myHeading
                Prod1.WidthF = 200

                Hsn1.Borders = BorderSide.Top Or BorderSide.Left
                Hsn1.Text = ""
                Hsn1.WidthF = 60

                UOM1.Borders = BorderSide.Top Or BorderSide.Left
                UOM1.Text = ""
                UOM1.WidthF = 31

                Qty1.Borders = BorderSide.Top Or BorderSide.Left
                Qty1.Text = ""
                Qty1.WidthF = 60

                Rate1.Borders = BorderSide.Top Or BorderSide.Left
                Rate1.Text = ""
                Rate1.WidthF = 68

                Amt1.Borders = BorderSide.Top Or BorderSide.Left
                Amt1.Text = ""
                Amt1.WidthF = 68

                'Dis1.Borders = BorderSide.Top Or BorderSide.Left
                'Dis1.Text = ""
                'Dis1.WidthF = 37.48

                TaxVal1.Borders = BorderSide.Top Or BorderSide.Left
                TaxVal1.Text = ""
                TaxVal1.WidthF = 78.74

                cgstRate1.Borders = BorderSide.Top Or BorderSide.Left
                cgstRate1.Text = ""
                cgstRate1.WidthF = 30

                cgstAmt1.Borders = BorderSide.Top Or BorderSide.Left
                cgstAmt1.Text = ""
                cgstAmt1.WidthF = 76

                Total1.Borders = BorderSide.Top Or BorderSide.Left Or BorderSide.Right
                Total1.Text = ""
                Total1.WidthF = 86

                row1.Cells.Add(Ref1)
                row1.Cells.Add(Prod1)
                row1.Cells.Add(Hsn1)
                row1.Cells.Add(UOM1)
                row1.Cells.Add(Qty1)
                row1.Cells.Add(Rate1)
                row1.Cells.Add(Amt1)
                'row1.Cells.Add(Dis1)
                row1.Cells.Add(TaxVal1)
                row1.Cells.Add(cgstRate1)
                row1.Cells.Add(cgstAmt1)
                row1.Cells.Add(Total1)
                XrTable4.Rows.Add(row1)
            End If
            'Add LineItems
            For i = 0 To dtCgst1.Rows.Count - 1
                Dim RefVal As Integer
                RefVal = i + 1
                Dim rows As New XRTableRow()
                Dim Refs As New XRTableCell()
                Dim Prods As New XRTableCell()
                Dim Hsns As New XRTableCell()
                Dim UOMs As New XRTableCell()
                Dim Qtys As New XRTableCell()
                Dim Rates As New XRTableCell()
                Dim Amts As New XRTableCell()
                'Dim Diss As New XRTableCell()
                Dim TaxVals As New XRTableCell()
                Dim cgstRates As New XRTableCell()
                Dim cgstAmts As New XRTableCell()
                Dim Totals As New XRTableCell()

                Refs.Borders = BorderSide.Left Or BorderSide.Bottom Or BorderSide.Top
                Refs.TextAlignment = TextAlignment.MiddleCenter
                Refs.Text = RefVal.ToString()
                Refs.WidthF = 20

                If (dtCgst1.Rows(i).Item(1) Is DBNull.Value) Then
                    Prods.Text = dtCgst1.Rows(i).Item(0).ToString()
                Else
                    Prods.Text = dtCgst1.Rows(i).Item(0).ToString() & Environment.NewLine & dtCgst1.Rows(i).Item(2).ToString()
                    Prods.Multiline = True
                End If
                Prods.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Prods.TextAlignment = TextAlignment.MiddleLeft
                Prods.Padding = 2
                Prods.WidthF = 200

                Hsns.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Hsns.TextAlignment = TextAlignment.MiddleCenter
                Hsns.Text = dtCgst1.Rows(i).Item(3).ToString()
                Hsns.WidthF = 60

                UOMs.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                UOMs.TextAlignment = TextAlignment.MiddleCenter
                UOMs.Padding = 2
                UOMs.Text = dtCgst1.Rows(i).Item(4).ToString()
                UOMs.WidthF = 31

                Qtys.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim q As Decimal
                q = Convert.ToDecimal(dtCgst1.Rows(i).Item(5))
                Qtys.Text = Math.Round(q, 2).ToString("F2")
                Qtys.TextAlignment = TextAlignment.MiddleCenter
                Qtys.WidthF = 60
                QTYTotal = QTYTotal + q
                TSQty += q

                Rates.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim rte As Decimal
                rte = Convert.ToDecimal(dtCgst1.Rows(i).Item(6))
                Rates.Text = Math.Round(rte, 2).ToString("F2")
                Rates.TextAlignment = TextAlignment.MiddleRight
                Rates.Padding = 2
                Rates.WidthF = 68

                Amts.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim amount As Decimal
                amount = Convert.ToDecimal(dtCgst1.Rows(i).Item(7))
                Amts.Padding = 2
                Amts.Text = Math.Round(amount, 2).ToString("F2")
                Amts.TextAlignment = TextAlignment.MiddleRight
                Amts.WidthF = 68

                'If (dtCgst1.Rows(i).Item(8) Is DBNull.Value) Then
                '    Diss.Text = dtCgst1.Rows(i).Item(8).ToString()
                'Else
                '    Dim discount As Decimal
                '    discount = Convert.ToDecimal(dtCgst1.Rows(i).Item(8))
                '    Diss.Text = Math.Round(discount, 2).ToString("F2")
                'End If
                'Diss.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                'Diss.TextAlignment = TextAlignment.MiddleRight
                'Diss.Padding = 2
                'Diss.WidthF = 37.48

                TaxVals.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim taxableVal As Decimal
                taxableVal = Convert.ToDecimal(dtCgst1.Rows(i).Item(9))
                TaxVals.Text = Math.Round(taxableVal, 2).ToString("F2")
                TaxVals.TextAlignment = TextAlignment.MiddleRight
                TaxVals.Padding = 2
                TaxVals.WidthF = 78.74
                TSTaxVal += taxableVal

                cgstRates.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                cgstRates.Text = dtCgst1.Rows(i).Item(10).ToString() + "%"
                cgstRates.TextAlignment = TextAlignment.MiddleRight
                cgstRates.Padding = 2
                cgstRates.WidthF = 30

                cgstAmts.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim camt As Decimal
                camt = Convert.ToDecimal(dtCgst1.Rows(i).Item(11))
                cgstAmts.Text = Math.Round(camt, 2).ToString("F2")
                cgstAmts.TextAlignment = TextAlignment.MiddleRight
                cgstAmts.Padding = 2
                cgstAmts.WidthF = 76
                TSGst += camt

                Totals.Borders = BorderSide.All
                Dim ttl As Decimal
                ttl = Convert.ToDecimal(dtCgst1.Rows(i).Item(12))
                Totals.Text = Math.Round(ttl, 2).ToString("F2")
                Totals.TextAlignment = TextAlignment.MiddleRight
                Totals.Padding = 2
                Totals.WidthF = 86
                TSpares += ttl

                rows.Cells.Add(Refs)
                rows.Cells.Add(Prods)
                rows.Cells.Add(Hsns)
                rows.Cells.Add(UOMs)
                rows.Cells.Add(Qtys)
                rows.Cells.Add(Rates)
                rows.Cells.Add(Amts)
                'rows.Cells.Add(Diss)
                rows.Cells.Add(TaxVals)
                rows.Cells.Add(cgstRates)
                rows.Cells.Add(cgstAmts)
                rows.Cells.Add(Totals)
                XrTable4.Rows.Add(rows)
            Next
            'Add Grand Total row
            If dtCgst1.Rows.Count > 0 Then
                Dim GTrow As New XRTableRow()

                Dim GTProd As New XRTableCell()
                Dim GTQty As New XRTableCell()
                Dim GTBlank As New XRTableCell()
                Dim GTTaxVal As New XRTableCell()
                Dim GTGstRate As New XRTableCell()
                Dim GTGst As New XRTableCell()
                Dim GTTotal As New XRTableCell()

                GTProd.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTProd.Text = "Total for Spares"
                GTProd.Padding = 2
                GTProd.TextAlignment = TextAlignment.MiddleLeft
                GTProd.Font = myfont
                GTProd.WidthF = 311

                GTQty.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTQty.Text = Math.Round(TSQty, 2).ToString("F2")
                GTQty.Padding = 2
                GTQty.TextAlignment = TextAlignment.MiddleCenter
                GTQty.Font = myfont
                GTQty.WidthF = 60

                GTBlank.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTBlank.Text = ""
                GTBlank.WidthF = 135.67

                GTTaxVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTTaxVal.Text = Math.Round(TSTaxVal, 2).ToString("F2")
                GTTaxVal.Padding = 2
                GTTaxVal.TextAlignment = TextAlignment.MiddleRight
                GTTaxVal.Font = myfont
                GTTaxVal.WidthF = 78.74

                GTGstRate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTGstRate.Text = "-"
                GTGstRate.Padding = 2
                GTGstRate.TextAlignment = TextAlignment.MiddleCenter
                GTGstRate.Font = myfont
                GTGstRate.WidthF = 30

                GTGst.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTGst.Text = Math.Round(TSGst, 2).ToString("F2")
                GTGst.Padding = 2
                GTGst.TextAlignment = TextAlignment.MiddleRight
                GTGst.Font = myfont
                GTGst.WidthF = 76

                GTTotal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left Or BorderSide.Right
                GTTotal.Text = Math.Round(TSpares, 2).ToString("F2")
                GTTotal.Padding = 2
                GTTotal.TextAlignment = TextAlignment.MiddleRight
                GTTotal.Font = myfont
                GTTotal.WidthF = 86

                GTrow.Cells.Add(GTProd)
                GTrow.Cells.Add(GTQty)
                GTrow.Cells.Add(GTBlank)
                GTrow.Cells.Add(GTTaxVal)
                GTrow.Cells.Add(GTGstRate)
                GTrow.Cells.Add(GTGst)
                GTrow.Cells.Add(GTTotal)
                XrTable4.Rows.Add(GTrow)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Query for fetch data of Labour category
        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String
        sqlCgst = "SELECT ProductName, CategoryID, Description, HSNACS, UOM, Qty, Rate, Amount, Discount, TaxableValue, GSTRate, GSTAmt, TotalAmount from QuotationDetail Where CategoryID = 15 AND QuotationID = " + Invoice.Value.ToString()
        Try
            daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
            daCgst.Fill(dtCgst)
            'Add Heading        
            If dtCgst.Rows.Count > 0 Then
                Dim row2 As New XRTableRow()
                Dim Ref2 As New XRTableCell()
                Dim Prod2 As New XRTableCell()
                Dim Hsn2 As New XRTableCell()
                Dim UOM2 As New XRTableCell()
                Dim Qty2 As New XRTableCell()
                Dim Rate2 As New XRTableCell()
                Dim Amt2 As New XRTableCell()
                'Dim Dis2 As New XRTableCell()
                Dim TaxVal2 As New XRTableCell()
                Dim cgstRate2 As New XRTableCell()
                Dim cgstAmt2 As New XRTableCell()
                Dim Total2 As New XRTableCell()

                Ref2.Borders = BorderSide.Left Or BorderSide.Top
                Ref2.Text = ""
                Ref2.WidthF = 20


                Prod2.Borders = BorderSide.Top Or BorderSide.Left
                Prod2.Text = "Labour"
                Prod2.Font = myHeading
                Prod2.Padding = 2
                Prod2.WidthF = 200

                Hsn2.Borders = BorderSide.Top Or BorderSide.Left
                Hsn2.Text = ""
                Hsn2.WidthF = 60

                UOM2.Borders = BorderSide.Top Or BorderSide.Left
                UOM2.Text = ""
                UOM2.WidthF = 31

                Qty2.Borders = BorderSide.Top Or BorderSide.Left
                Qty2.Text = ""
                Qty2.WidthF = 60

                Rate2.Borders = BorderSide.Top Or BorderSide.Left
                Rate2.Text = ""
                Rate2.WidthF = 68

                Amt2.Borders = BorderSide.Top Or BorderSide.Left
                Amt2.Text = ""
                Amt2.WidthF = 68

                'Dis2.Borders = BorderSide.Top Or BorderSide.Left
                'Dis2.Text = ""
                'Dis2.WidthF = 37.48

                TaxVal2.Borders = BorderSide.Top Or BorderSide.Left
                TaxVal2.Text = ""
                TaxVal2.WidthF = 78.74

                cgstRate2.Borders = BorderSide.Top Or BorderSide.Left
                cgstRate2.Text = ""
                cgstRate2.WidthF = 30

                cgstAmt2.Borders = BorderSide.Top Or BorderSide.Left
                cgstAmt2.Text = ""
                cgstAmt2.WidthF = 76

                Total2.Borders = BorderSide.Top Or BorderSide.Left Or BorderSide.Right
                Total2.Text = ""
                Total2.WidthF = 86

                row2.Cells.Add(Ref2)
                row2.Cells.Add(Prod2)
                row2.Cells.Add(Hsn2)
                row2.Cells.Add(UOM2)
                row2.Cells.Add(Qty2)
                row2.Cells.Add(Rate2)
                row2.Cells.Add(Amt2)
                'row2.Cells.Add(Dis2)
                row2.Cells.Add(TaxVal2)
                row2.Cells.Add(cgstRate2)
                row2.Cells.Add(cgstAmt2)
                row2.Cells.Add(Total2)
                XrTable4.Rows.Add(row2)
            End If
            'Add LineItems
            For i = 0 To dtCgst.Rows.Count - 1
                Dim RefVal As Integer
                RefVal = i + 1
                Dim row As New XRTableRow()
                Dim Ref As New XRTableCell()
                Dim Prod As New XRTableCell()
                Dim Hsn As New XRTableCell()
                Dim UOM As New XRTableCell()
                Dim Qty As New XRTableCell()
                Dim Rate As New XRTableCell()
                Dim Amt As New XRTableCell()
                'Dim Dis As New XRTableCell()
                Dim TaxVal As New XRTableCell()
                Dim cgstRate As New XRTableCell()
                Dim cgstAmt As New XRTableCell()
                Dim Total As New XRTableCell()

                Ref.Borders = BorderSide.Left Or BorderSide.Bottom Or BorderSide.Top
                Ref.TextAlignment = TextAlignment.MiddleCenter
                Ref.Text = RefVal.ToString()
                Ref.WidthF = 20

                If (dtCgst.Rows(i).Item(1) Is DBNull.Value) Then
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString()
                Else
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString() & Environment.NewLine & dtCgst.Rows(i).Item(2).ToString()
                    Prod.Multiline = True
                End If
                Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Prod.TextAlignment = TextAlignment.MiddleLeft
                Prod.Padding = 2
                Prod.WidthF = 200

                Hsn.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Hsn.TextAlignment = TextAlignment.MiddleCenter
                Hsn.Text = dtCgst.Rows(i).Item(3).ToString()
                Hsn.WidthF = 60

                UOM.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                UOM.TextAlignment = TextAlignment.MiddleCenter
                UOM.Padding = 2
                UOM.Text = dtCgst.Rows(i).Item(4).ToString()
                UOM.WidthF = 31

                Qty.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim q As Decimal
                q = Convert.ToDecimal(dtCgst.Rows(i).Item(5))
                Qty.Text = Math.Round(q, 2).ToString("F2")
                Qty.TextAlignment = TextAlignment.MiddleCenter
                Qty.WidthF = 60
                QTYTotal = QTYTotal + q
                TLQty += q

                Rate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim rte As Decimal
                rte = Convert.ToDecimal(dtCgst.Rows(i).Item(6))
                Rate.Text = Math.Round(rte, 2).ToString("F2")
                Rate.TextAlignment = TextAlignment.MiddleRight
                Rate.Padding = 2
                Rate.WidthF = 68

                Amt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim amount As Decimal
                amount = Convert.ToDecimal(dtCgst.Rows(i).Item(7))
                Amt.Text = Math.Round(amount, 2).ToString("F2")
                Amt.Padding = 2
                Amt.TextAlignment = TextAlignment.MiddleRight
                Amt.WidthF = 68

                'If (dtCgst.Rows(i).Item(8) Is DBNull.Value) Then
                '    Dis.Text = dtCgst.Rows(i).Item(8).ToString()
                'Else
                '    Dim discount As Decimal
                '    discount = Convert.ToDecimal(dtCgst.Rows(i).Item(8))
                '    Dis.Text = Math.Round(discount, 2).ToString("F2")
                'End If
                'Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                'Dis.TextAlignment = TextAlignment.MiddleRight
                'Dis.Padding = 2
                'Dis.WidthF = 37.48

                TaxVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim taxableVal As Decimal
                taxableVal = Convert.ToDecimal(dtCgst.Rows(i).Item(9))
                TaxVal.Text = Math.Round(taxableVal, 2).ToString("F2")
                TaxVal.Padding = 2
                TaxVal.TextAlignment = TextAlignment.MiddleRight
                TaxVal.WidthF = 78.74
                TLTaxVal += taxableVal

                cgstRate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                cgstRate.Text = dtCgst.Rows(i).Item(10).ToString() + "%"
                cgstRate.TextAlignment = TextAlignment.MiddleRight
                cgstRate.Padding = 2
                cgstRate.WidthF = 30

                cgstAmt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim camt As Decimal
                camt = Convert.ToDecimal(dtCgst.Rows(i).Item(11))
                cgstAmt.Text = Math.Round(camt, 2).ToString("F2")
                cgstAmt.TextAlignment = TextAlignment.MiddleRight
                cgstAmt.Padding = 2
                cgstAmt.WidthF = 76
                TLGst += camt

                Total.Borders = BorderSide.All
                Dim ttl As Decimal
                ttl = Convert.ToDecimal(dtCgst.Rows(i).Item(12))
                Total.Text = Math.Round(ttl, 2).ToString("F2")
                Total.Padding = 2
                Total.TextAlignment = TextAlignment.MiddleRight
                Total.WidthF = 86
                TLabour += ttl

                row.Cells.Add(Ref)
                row.Cells.Add(Prod)
                row.Cells.Add(Hsn)
                row.Cells.Add(UOM)
                row.Cells.Add(Qty)
                row.Cells.Add(Rate)
                row.Cells.Add(Amt)
                'row.Cells.Add(Dis)
                row.Cells.Add(TaxVal)
                row.Cells.Add(cgstRate)
                row.Cells.Add(cgstAmt)
                row.Cells.Add(Total)
                XrTable4.Rows.Add(row)
            Next
            'Add Grand Total row
            If dtCgst.Rows.Count > 0 Then
                Dim GTrow As New XRTableRow()
                Dim GTProd As New XRTableCell()
                Dim GTQty As New XRTableCell()
                Dim GTBlank As New XRTableCell()
                Dim GTTaxVal As New XRTableCell()
                Dim GTGstRate As New XRTableCell()
                Dim GTGst As New XRTableCell()
                Dim GTTotal As New XRTableCell()

                GTProd.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTProd.Text = "Total for Labour"
                GTProd.Padding = 2
                GTProd.TextAlignment = TextAlignment.MiddleLeft
                GTProd.Font = myfont
                GTProd.WidthF = 311

                GTQty.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTQty.Text = Math.Round(TLQty, 2).ToString("F2")
                GTQty.Padding = 2
                GTQty.TextAlignment = TextAlignment.MiddleCenter
                GTQty.Font = myfont
                GTQty.WidthF = 60

                GTBlank.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTBlank.Text = ""
                GTBlank.WidthF = 135.67

                GTTaxVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTTaxVal.Text = Math.Round(TLTaxVal, 2).ToString("F2")
                GTTaxVal.Padding = 2
                GTTaxVal.TextAlignment = TextAlignment.MiddleRight
                GTTaxVal.Font = myfont
                GTTaxVal.WidthF = 78.74

                GTGstRate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTGstRate.Text = "-"
                GTGstRate.Padding = 2
                GTGstRate.TextAlignment = TextAlignment.MiddleCenter
                GTGstRate.Font = myfont
                GTGstRate.WidthF = 30

                GTGst.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                GTGst.Text = Math.Round(TLGst, 2).ToString("F2")
                GTGst.Padding = 2
                GTGst.TextAlignment = TextAlignment.MiddleRight
                GTGst.Font = myfont
                GTGst.WidthF = 76

                GTTotal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left Or BorderSide.Right
                GTTotal.Text = Math.Round(TLabour, 2).ToString("F2")
                GTTotal.Padding = 2
                GTTotal.TextAlignment = TextAlignment.MiddleRight
                GTTotal.Font = myfont
                GTTotal.WidthF = 86

                GTrow.Cells.Add(GTProd)
                GTrow.Cells.Add(GTQty)
                GTrow.Cells.Add(GTBlank)
                GTrow.Cells.Add(GTTaxVal)
                GTrow.Cells.Add(GTGstRate)
                GTrow.Cells.Add(GTGst)
                GTrow.Cells.Add(GTTotal)
                XrTable4.Rows.Add(GTrow)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        XrLabel13.Text = Math.Round(QTYTotal, 2).ToString("F2")
    End Sub

    Private Sub TermsXrTable_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TermsXrTable.BeforePrint
        Dim daTerms As OleDbDataAdapter
        Dim dtTerms As New DataTable
        Dim sqlTerms As String
        sqlTerms = "Select PackingCharge,IsGST,DeliveryTime,NewFOR,PaymentTerm,Warranty,Validity From Quotation Where QuotationID = " + Invoice.Value.ToString()

        daTerms = New OleDbDataAdapter(sqlTerms, ConStr)
        daTerms.Fill(dtTerms)

        Dim chkGST = Convert.ToBoolean(dtTerms.Rows(0).Item("IsGST"))
        If Not (dtTerms.Rows(0).Item(0) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(0) Is "") Then
            Dim PCRow As New XRTableRow()
            Dim PCLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim PCVal As New XRTableCell()

            If chkGST = True Then
                PCLbl.Borders = BorderSide.Left
                PCLbl.TextAlignment = TextAlignment.MiddleLeft
                PCLbl.Padding = 2
                PCLbl.Text = " * Packing Charge "
                PCLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
                PCLbl.WidthF = 70.25
                Cln.TextAlignment = TextAlignment.MiddleLeft
                Cln.Padding = 2
                Cln.Text = " : "
                Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
                Cln.WidthF = 12
                PCVal.Borders = BorderSide.Right
                PCVal.TextAlignment = TextAlignment.MiddleLeft
                PCVal.Padding = 2
                PCVal.Text = dtTerms.Rows(0).Item("PackingCharge").ToString + " + GST" & Environment.NewLine
                PCVal.WidthF = 384.22
                PCRow.Cells.Add(PCLbl)
                PCRow.Cells.Add(Cln)
                PCRow.Cells.Add(PCVal)
            Else
                PCLbl.Borders = BorderSide.Left
                PCLbl.TextAlignment = TextAlignment.MiddleLeft
                PCLbl.Padding = 2
                PCLbl.Text = " * Packing Charge "
                PCLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
                PCLbl.WidthF = 70.25
                Cln.TextAlignment = TextAlignment.MiddleLeft
                Cln.Padding = 2
                Cln.Text = " : "
                Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
                Cln.WidthF = 12
                PCVal.Borders = BorderSide.Right
                PCVal.TextAlignment = TextAlignment.MiddleLeft
                PCVal.Padding = 2
                PCVal.Text = dtTerms.Rows(0).Item("PackingCharge").ToString & Environment.NewLine
                PCVal.WidthF = 384.22
                PCRow.Cells.Add(PCLbl)
                PCRow.Cells.Add(Cln)
                PCRow.Cells.Add(PCVal)
            End If
            TermsXrTable.Rows.Add(PCRow)
        End If
        If Not (dtTerms.Rows(0).Item(2) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(2) Is "") Then
            Dim DTRow As New XRTableRow()
            Dim DTLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim DTVal As New XRTableCell()
            DTLbl.Borders = BorderSide.Left
            DTLbl.TextAlignment = TextAlignment.MiddleLeft
            DTLbl.Padding = 2
            DTLbl.Text = " * Delivery Time "
            DTLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            DTLbl.WidthF = 70.25
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = 2
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            DTVal.Borders = BorderSide.Right
            DTVal.TextAlignment = TextAlignment.MiddleLeft
            DTVal.Padding = 2
            DTVal.Text = dtTerms.Rows(0).Item("DeliveryTime").ToString & Environment.NewLine
            DTVal.WidthF = 384.22
            DTRow.Cells.Add(DTLbl)
            DTRow.Cells.Add(Cln)
            DTRow.Cells.Add(DTVal)
            TermsXrTable.Rows.Add(DTRow)
        End If
        If Not (dtTerms.Rows(0).Item(3) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(3) Is "") Then
            Dim FORRow As New XRTableRow()
            Dim FORLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim FORVal As New XRTableCell()
            FORLbl.Borders = BorderSide.Left
            FORLbl.TextAlignment = TextAlignment.MiddleLeft
            FORLbl.Padding = 2
            FORLbl.Text = " * F.O.R "
            FORLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            FORLbl.WidthF = 70.25
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = 2
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            FORVal.Borders = BorderSide.Right
            FORVal.TextAlignment = TextAlignment.MiddleLeft
            FORVal.Padding = 2
            FORVal.Text = dtTerms.Rows(0).Item("NewFOR").ToString & Environment.NewLine
            FORVal.WidthF = 384.22
            FORRow.Cells.Add(FORLbl)
            FORRow.Cells.Add(Cln)
            FORRow.Cells.Add(FORVal)
            TermsXrTable.Rows.Add(FORRow)
        End If
        If Not (dtTerms.Rows(0).Item(4) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(4) Is "") Then
            Dim PTRow As New XRTableRow()
            Dim PTLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim PTVal As New XRTableCell()
            PTLbl.Borders = BorderSide.Left
            PTLbl.TextAlignment = TextAlignment.MiddleLeft
            PTLbl.Padding = 2
            PTLbl.Text = " * Payment Term "
            PTLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            PTLbl.WidthF = 70.25
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = 2
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            PTVal.Borders = BorderSide.Right
            PTVal.TextAlignment = TextAlignment.MiddleLeft
            PTVal.Padding = 2
            PTVal.Text = dtTerms.Rows(0).Item("PaymentTerm").ToString & Environment.NewLine
            PTVal.WidthF = 384.22
            PTRow.Cells.Add(PTLbl)
            PTRow.Cells.Add(Cln)
            PTRow.Cells.Add(PTVal)
            TermsXrTable.Rows.Add(PTRow)
        End If
        If Not (dtTerms.Rows(0).Item(5) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(5) Is "") Then
            Dim WRow As New XRTableRow()
            Dim WLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim WVal As New XRTableCell()
            WLbl.Borders = BorderSide.Left
            WLbl.TextAlignment = TextAlignment.MiddleLeft
            WLbl.Padding = 2
            WLbl.Text = " * Warranty "
            WLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            WLbl.WidthF = 70.25
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = 2
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            WVal.Borders = BorderSide.Right
            WVal.TextAlignment = TextAlignment.MiddleLeft
            WVal.Padding = 2
            WVal.Text = dtTerms.Rows(0).Item("Warranty").ToString & Environment.NewLine
            WVal.WidthF = 384.22
            WRow.Cells.Add(WLbl)
            WRow.Cells.Add(Cln)
            WRow.Cells.Add(WVal)
            TermsXrTable.Rows.Add(WRow)
        End If
        If Not (dtTerms.Rows(0).Item(6) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(6) Is "") Then
            Dim VRow As New XRTableRow()
            Dim VLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim VVal As New XRTableCell()
            VLbl.Borders = BorderSide.Bottom Or BorderSide.Left
            VLbl.TextAlignment = TextAlignment.MiddleLeft
            VLbl.Padding = 2
            VLbl.Text = " * Validity "
            VLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            VLbl.WidthF = 70.25
            Cln.Borders = BorderSide.Bottom
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = 2
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            VVal.Borders = BorderSide.Bottom Or BorderSide.Right
            VVal.TextAlignment = TextAlignment.MiddleLeft
            VVal.Padding = 2
            VVal.Text = dtTerms.Rows(0).Item("Validity").ToString & Environment.NewLine
            VVal.WidthF = 384.22
            VRow.Cells.Add(VLbl)
            VRow.Cells.Add(Cln)
            VRow.Cells.Add(VVal)
            TermsXrTable.Rows.Add(VRow)
        End If
    End Sub
End Class