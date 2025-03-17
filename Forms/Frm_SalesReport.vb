Imports System.Data.OleDb
Public Class Frm_SalesReport
    Dim sqlCgst As String
    Dim sqlLineItems As String
    Dim sqlPacking As String
    Private Sub FrmMasterConceptFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InvoiceTypeLabel.Text = PubInvoiceType
        InitLookup()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
        FromDateDateEdit.Text = Date.Today()
        ToDateDateEdit.Text = Date.Today()
    End Sub
    Sub InitLookup()
        SetGridCommboBox("SELECT DISTINCT PartyName FROM Party", "Party", PartyNameComboBoxEdit)
    End Sub
    Private Sub GetDataSimpleButton_Click(sender As Object, e As EventArgs) Handles GetDataSimpleButton.Click
        SetData()
        InvoiceDetailGridView.AddNewRow()
    End Sub
    Public Sub SetData()
        Try
            Dim daCgst As OleDbDataAdapter
            Dim dtCgst As New DataTable
            Dim daLI As OleDbDataAdapter
            Dim dtLI As New DataTable
            Dim daPacking As OleDbDataAdapter
            Dim dtPacking As New DataTable

            Dim taxAmnt As Decimal
            Dim taxAmt As String
            Dim gstAmnt As Decimal
            Dim gstAmt As String
            Dim sgstAmnt As Decimal
            Dim sgstAmt As String
            If PubIGST Then
                If PartyNameComboBoxEdit.EditValue Is DBNull.Value Or PartyNameComboBoxEdit.Text Is Nothing Or PartyNameComboBoxEdit.Text Is "" Then
                    Dim i, j As Integer
                    sqlCgst = "Select distinct InvoiceDetail.IGSTRate from Invoice,InvoiceDetail where Invoice.InvoiceID = InvoiceDetail.InvoiceID And (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And Invoice.InvoiceType='" + PubInvoiceType + "'"
                    sqlLineItems = "Select Invoice.InvoiceNo, Invoice.InvoiceDate, Invoice.ReceiverName,InvoiceDetail.HSNACS, SUM(InvoiceDetail.Qty) As Quantity, SUM(InvoiceDetail.TaxableValue) As TaxableValue, InvoiceDetail.IGSTRate As IGSTRate, SUM(InvoiceDetail.IGSTAmt) As IGSTAmt, Invoice.PackingCharge, Invoice.PIGSTRate, Invoice.PIGSTAmt, InvoiceDetail.ProductName,Invoice.ModelNo
                            FROM (Invoice INNER JOIN
                            InvoiceDetail ON Invoice.InvoiceID = InvoiceDetail.InvoiceID)
                            WHERE (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And Invoice.InvoiceType='" + PubInvoiceType + "'
                            GROUP BY Invoice.InvoiceNo, Invoice.InvoiceDate, Invoice.ReceiverName, InvoiceDetail.IGSTRate, Invoice.PackingCharge, Invoice.PIGSTRate, Invoice.PIGSTAmt,InvoiceDetail.HSNACS,InvoiceDetail.ProductName,Invoice.ModelNo
                            ORDER BY Invoice.InvoiceDate ASC"
                    sqlPacking = "SELECT PackingCharge,PIGSTRate,PIGSTAmt from Invoice Where (InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And InvoiceType='" + PubInvoiceType + "'"

                    daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
                    daCgst.Fill(dtCgst)

                    daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
                    daLI.Fill(dtLI)

                    daPacking = New OleDbDataAdapter(sqlPacking, ConStr)
                    daPacking.Fill(dtPacking)

                    Dim list1 As New List(Of Object)

                    For i = 0 To dtCgst.Rows.Count - 1
                        If Not dtCgst.Rows(i).Item(0) Is DBNull.Value Then
                            list1.Add(dtCgst.Rows(i).Item(0))
                        End If
                    Next
                    For j = 0 To dtPacking.Rows.Count - 1
                        Dim Pcharge As Double
                        Pcharge = CDec(dtPacking.Rows(j).Item(0))

                        If Not list1.Contains(dtPacking.Rows(j).Item(1)) And Not Pcharge = 0 Then
                            list1.Add(dtPacking.Rows(j).Item(1))
                        End If
                    Next

                    Dim TaxvalLabel As String
                    Dim IGSTAmtLabel As String

                    For i = 0 To list1.Count - 1
                        TaxvalLabel = "Taxable Value @" + list1.Item(i).ToString() + "%"
                        IGSTAmtLabel = "IGST Amt @" + list1.Item(i).ToString() + "%"

                        dtLI.Columns.Add(TaxvalLabel)
                        dtLI.Columns.Add(IGSTAmtLabel)
                    Next
                    For j = 0 To dtLI.Rows.Count - 1
                        If 5 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @5%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @5%", gstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("IGSTRate").Visible = False
                                .Columns("IGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PIGSTRate").Visible = False
                                .Columns("PIGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @5%").Width = 120
                                .Columns("Taxable Value @5%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("IGST Amt @5%").Width = 100
                                .Columns("IGST Amt @5%").OptionsColumn.ReadOnly = True
                                .Columns("IGST Amt @5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("IGST Amt @5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 12 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")

                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @12%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @12%", gstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("IGSTRate").Visible = False
                                .Columns("IGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PIGSTRate").Visible = False
                                .Columns("PIGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @12%").Width = 120
                                .Columns("Taxable Value @12%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("IGST Amt @12%").Width = 100
                                .Columns("IGST Amt @12%").OptionsColumn.ReadOnly = True
                                .Columns("IGST Amt @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("IGST Amt @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 18 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @18%", gstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("IGSTRate").Visible = False
                                .Columns("IGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PIGSTRate").Visible = False
                                .Columns("PIGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @18%").Width = 120
                                .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("IGST Amt @18%").Width = 100
                                .Columns("IGST Amt @18%").OptionsColumn.ReadOnly = True
                                .Columns("IGST Amt @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("IGST Amt @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 28 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")

                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @28%", gstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("IGSTRate").Visible = False
                                .Columns("IGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PIGSTRate").Visible = False
                                .Columns("PIGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @28%").Width = 120
                                .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("IGST Amt @28%").Width = 100
                                .Columns("IGST Amt @28%").OptionsColumn.ReadOnly = True
                                .Columns("IGST Amt @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("IGST Amt @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        End If
                        If 18 = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(8))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")

                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @18%", gstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("IGSTRate").Visible = False
                                    .Columns("IGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PIGSTRate").Visible = False
                                    .Columns("PIGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @18%").Width = 120
                                    .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("IGST Amt @18%").Width = 100
                                    .Columns("IGST Amt @18%").OptionsColumn.ReadOnly = True
                                    .Columns("IGST Amt @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("IGST Amt @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(8))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @18%", gstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("IGSTRate").Visible = False
                                    .Columns("IGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PIGSTRate").Visible = False
                                    .Columns("PIGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @18%").Width = 120
                                    .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("IGST Amt @18%").Width = 100
                                    .Columns("IGST Amt @18%").OptionsColumn.ReadOnly = True
                                    .Columns("IGST Amt @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("IGST Amt @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 28 = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(8))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @28%", gstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("IGSTRate").Visible = False
                                    .Columns("IGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PIGSTRate").Visible = False
                                    .Columns("PIGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @28%").Width = 120
                                    .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("IGST Amt @28%").Width = 100
                                    .Columns("IGST Amt @28%").OptionsColumn.ReadOnly = True
                                    .Columns("IGST Amt @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("IGST Amt @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(8))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @28%", gstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("IGSTRate").Visible = False
                                    .Columns("IGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PIGSTRate").Visible = False
                                    .Columns("PIGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @28%").Width = 120
                                    .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("IGST Amt @28%").Width = 100
                                    .Columns("IGST Amt @28%").OptionsColumn.ReadOnly = True
                                    .Columns("IGST Amt @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("IGST Amt @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 0 = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                            'Skip
                        End If
                    Next
                Else
                    Dim i, j As Integer
                    sqlCgst = "Select distinct InvoiceDetail.IGSTRate from Invoice,InvoiceDetail where Invoice.InvoiceID = InvoiceDetail.InvoiceID And (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And (ReceiverName='" + PartyNameComboBoxEdit.Text + "')And Invoice.InvoiceType='" + PubInvoiceType + "'"
                    sqlLineItems = "SELECT Invoice.InvoiceNo, Invoice.InvoiceDate, Invoice.ReceiverName,InvoiceDetail.HSNACS, SUM(InvoiceDetail.Qty) AS Quantity, SUM(InvoiceDetail.TaxableValue) AS TaxableValue, InvoiceDetail.IGSTRate AS IGSTRate, SUM(InvoiceDetail.IGSTAmt) AS IGSTAmt, Invoice.PackingCharge, Invoice.PIGSTRate, Invoice.PIGSTAmt,InvoiceDetail.ProductName,Invoice.ModelNo
                            FROM (Invoice INNER JOIN
                            InvoiceDetail ON Invoice.InvoiceID = InvoiceDetail.InvoiceID)
                            WHERE (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And (ReceiverName='" + PartyNameComboBoxEdit.Text + "') And Invoice.InvoiceType='" + PubInvoiceType + "'
                            GROUP BY Invoice.InvoiceNo, Invoice.InvoiceDate, Invoice.ReceiverName, InvoiceDetail.IGSTRate, Invoice.PackingCharge, Invoice.PIGSTRate, Invoice.PIGSTAmt,InvoiceDetail.HSNACS,InvoiceDetail.ProductName,Invoice.ModelNo
                            ORDER BY Invoice.InvoiceDate ASC"
                    sqlPacking = "SELECT PackingCharge,PIGSTRate,PIGSTAmt from Invoice Where (InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And (ReceiverName='" + PartyNameComboBoxEdit.Text + "') And InvoiceType='" + PubInvoiceType + "'"

                    daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
                    daCgst.Fill(dtCgst)

                    daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
                    daLI.Fill(dtLI)

                    daPacking = New OleDbDataAdapter(sqlPacking, ConStr)
                    daPacking.Fill(dtPacking)

                    Dim list1 As New List(Of Object)

                    For i = 0 To dtCgst.Rows.Count - 1
                        If Not dtCgst.Rows(i).Item(0) Is DBNull.Value Then
                            list1.Add(dtCgst.Rows(i).Item(0))
                        End If
                        'list1.Add(dtCgst.Rows(i).Item(0))
                    Next
                    For j = 0 To dtPacking.Rows.Count - 1
                        Dim Pcharge As Double
                        Pcharge = CDec(dtPacking.Rows(j).Item(0))

                        If Not list1.Contains(dtPacking.Rows(j).Item(1)) And Not Pcharge = 0 Then
                            list1.Add(dtPacking.Rows(j).Item(1))
                        End If
                    Next

                    Dim TaxvalLabel As String
                    Dim IGSTAmtLabel As String

                    For i = 0 To list1.Count - 1
                        TaxvalLabel = "Taxable Value @" + list1.Item(i).ToString() + "%"
                        IGSTAmtLabel = "IGST Amt @" + list1.Item(i).ToString() + "%"

                        dtLI.Columns.Add(TaxvalLabel)
                        dtLI.Columns.Add(IGSTAmtLabel)
                    Next
                    For j = 0 To dtLI.Rows.Count - 1
                        If 5 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")

                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @5%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @5%", gstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("IGSTRate").Visible = False
                                .Columns("IGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PIGSTRate").Visible = False
                                .Columns("PIGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @5%").Width = 120
                                .Columns("Taxable Value @5%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("IGST Amt @5%").Width = 100
                                .Columns("IGST Amt @5%").OptionsColumn.ReadOnly = True
                                .Columns("IGST Amt @5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("IGST Amt @5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 12 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")

                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @12%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @12%", gstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("IGSTRate").Visible = False
                                .Columns("IGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PIGSTRate").Visible = False
                                .Columns("PIGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @12%").Width = 120
                                .Columns("Taxable Value @12%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("IGST Amt @12%").Width = 100
                                .Columns("IGST Amt @12%").OptionsColumn.ReadOnly = True
                                .Columns("IGST Amt @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("IGST Amt @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 18 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @18%", gstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("IGSTRate").Visible = False
                                .Columns("IGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PIGSTRate").Visible = False
                                .Columns("PIGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @18%").Width = 120
                                .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("IGST Amt @18%").Width = 100
                                .Columns("IGST Amt @18%").OptionsColumn.ReadOnly = True
                                .Columns("IGST Amt @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("IGST Amt @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 28 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")

                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @28%", gstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("IGSTRate").Visible = False
                                .Columns("IGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PIGSTRate").Visible = False
                                .Columns("PIGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @28%").Width = 120
                                .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("IGST Amt @28%").Width = 100
                                .Columns("IGST Amt @28%").OptionsColumn.ReadOnly = True
                                .Columns("IGST Amt @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("IGST Amt @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        End If
                        If 18 = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(8))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")

                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @18%", gstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("IGSTRate").Visible = False
                                    .Columns("IGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PIGSTRate").Visible = False
                                    .Columns("PIGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @18%").Width = 120
                                    .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("IGST Amt @18%").Width = 100
                                    .Columns("IGST Amt @18%").OptionsColumn.ReadOnly = True
                                    .Columns("IGST Amt @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("IGST Amt @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(8))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @18%", gstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("IGSTRate").Visible = False
                                    .Columns("IGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PIGSTRate").Visible = False
                                    .Columns("PIGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @18%").Width = 120
                                    .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("IGST Amt @18%").Width = 100
                                    .Columns("IGST Amt @18%").OptionsColumn.ReadOnly = True
                                    .Columns("IGST Amt @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("IGST Amt @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 28 = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(8))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @28%", gstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("IGSTRate").Visible = False
                                    .Columns("IGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PIGSTRate").Visible = False
                                    .Columns("PIGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @28%").Width = 120
                                    .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("IGST Amt @28%").Width = 100
                                    .Columns("IGST Amt @28%").OptionsColumn.ReadOnly = True
                                    .Columns("IGST Amt @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("IGST Amt @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(8))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(11))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(12))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "IGST Amt @28%", gstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("IGSTRate").Visible = False
                                    .Columns("IGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PIGSTRate").Visible = False
                                    .Columns("PIGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @28%").Width = 120
                                    .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("IGST Amt @28%").Width = 100
                                    .Columns("IGST Amt @28%").OptionsColumn.ReadOnly = True
                                    .Columns("IGST Amt @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("IGST Amt @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 0 = Convert.ToDecimal(dtLI.Rows(j).Item(9)) Then
                            'Skip
                        End If
                    Next
                End If
            Else
                If PartyNameComboBoxEdit.EditValue Is DBNull.Value Or PartyNameComboBoxEdit.Text Is Nothing Or PartyNameComboBoxEdit.Text Is "" Then
                    Dim i, j As Integer
                    sqlCgst = "Select distinct InvoiceDetail.CGSTRate from Invoice,InvoiceDetail where Invoice.InvoiceID = InvoiceDetail.InvoiceID And (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And Invoice.InvoiceType='" + PubInvoiceType + "'"
                    sqlLineItems = "SELECT Invoice.InvoiceNo, Invoice.InvoiceDate, Invoice.ReceiverName,  InvoiceDetail.HSNACS, SUM(InvoiceDetail.Qty) AS Quantity, SUM(InvoiceDetail.TaxableValue) AS TaxableValue, InvoiceDetail.CGSTRate AS CGSTRate, SUM(InvoiceDetail.CGSTAmt) AS CGSTAmt, 
                            InvoiceDetail.SGSTRate AS SGSTRate, SUM(InvoiceDetail.SGSTAmt) AS SGSTAmt, Invoice.PackingCharge, Invoice.PCGSTRate, Invoice.PCGSTAmt, Invoice.PSGSTRate, Invoice.PSGSTAmt,InvoiceDetail.ProductName,Invoice.ModelNo
                            FROM (Invoice INNER JOIN
                            InvoiceDetail ON Invoice.InvoiceID = InvoiceDetail.InvoiceID)
                            WHERE (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And Invoice.InvoiceType='" + PubInvoiceType + "'
                            GROUP BY Invoice.InvoiceNo, Invoice.InvoiceDate, Invoice.ReceiverName, InvoiceDetail.HSNACS, InvoiceDetail.CGSTRate, InvoiceDetail.SGSTRate, Invoice.PackingCharge, Invoice.PCGSTRate, Invoice.PCGSTAmt, Invoice.PSGSTRate, Invoice.PSGSTAmt, InvoiceDetail.ProductName, Invoice.ModelNo
                            ORDER BY Invoice.InvoiceDate ASC"
                    sqlPacking = "SELECT PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt From Invoice Where (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And Invoice.InvoiceType='" + PubInvoiceType + "'"

                    daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
                    daCgst.Fill(dtCgst)

                    daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
                    daLI.Fill(dtLI)

                    daPacking = New OleDbDataAdapter(sqlPacking, ConStr)
                    daPacking.Fill(dtPacking)
                    Dim list1 As New List(Of Object)

                    For i = 0 To dtCgst.Rows.Count - 1
                        If Not dtCgst.Rows(i).Item(0) Is DBNull.Value Then
                            list1.Add(dtCgst.Rows(i).Item(0))
                        End If
                    Next
                    For j = 0 To dtPacking.Rows.Count - 1
                        Dim Pcharge As Double
                        Pcharge = CDec(dtPacking.Rows(j).Item(0))

                        If Not list1.Contains(dtPacking.Rows(j).Item(1)) And Not Pcharge = 0 Then
                            list1.Add(dtPacking.Rows(j).Item(1))
                        End If
                    Next

                    Dim TaxvalLabel As String
                    Dim CGSTAmtLabel As String
                    Dim SGSTAmtLabel As String
                    Dim TaxValPer As Decimal

                    For i = 0 To list1.Count - 1
                        TaxValPer = CDec(list1.Item(i)) + CDec(list1.Item(i))
                        TaxvalLabel = "Taxable Value @" + TaxValPer.ToString() + "%"
                        CGSTAmtLabel = "CGST Amt @" + list1.Item(i).ToString() + "%"
                        SGSTAmtLabel = "SGST Amt @" + list1.Item(i).ToString() + "%"
                        dtLI.Columns.Add(TaxvalLabel)
                        dtLI.Columns.Add(CGSTAmtLabel)
                        dtLI.Columns.Add(SGSTAmtLabel)
                    Next
                    For j = 0 To dtLI.Rows.Count - 1
                        If 2.5 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9))
                            sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @5%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @2.5%", gstAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @2.5%", sgstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("CGSTRate").Visible = False
                                .Columns("CGSTAmt").Visible = False
                                .Columns("SGSTRate").Visible = False
                                .Columns("SGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PCGSTRate").Visible = False
                                .Columns("PCGSTAmt").Visible = False
                                .Columns("PSGSTRate").Visible = False
                                .Columns("PSGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @5%").Width = 120
                                .Columns("Taxable Value @5%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("CGST Amt @2.5%").Width = 100
                                .Columns("CGST Amt @2.5%").OptionsColumn.ReadOnly = True
                                .Columns("CGST Amt @2.5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("SGST Amt @2.5%").Width = 100
                                .Columns("SGST Amt @2.5%").OptionsColumn.ReadOnly = True
                                .Columns("SGST Amt @2.5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("CGST Amt @2.5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("SGST Amt @2.5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 6 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9))
                            sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @12%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @6%", gstAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @6%", sgstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("CGSTRate").Visible = False
                                .Columns("CGSTAmt").Visible = False
                                .Columns("SGSTRate").Visible = False
                                .Columns("SGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("Quantity").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PCGSTRate").Visible = False
                                .Columns("PCGSTAmt").Visible = False
                                .Columns("PSGSTRate").Visible = False
                                .Columns("PSGSTAmt").Visible = False
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @12%").Width = 120
                                .Columns("Taxable Value @12%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("CGST Amt @6%").Width = 100
                                .Columns("CGST Amt @6%").OptionsColumn.ReadOnly = True
                                .Columns("CGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("SGST Amt @6%").Width = 100
                                .Columns("SGST Amt @6%").OptionsColumn.ReadOnly = True
                                .Columns("SGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("CGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("SGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 9 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9))
                            sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @9%", gstAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @9%", sgstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("CGSTRate").Visible = False
                                .Columns("CGSTAmt").Visible = False
                                .Columns("SGSTRate").Visible = False
                                .Columns("SGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("ProductName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PCGSTRate").Visible = False
                                .Columns("PCGSTAmt").Visible = False
                                .Columns("PSGSTRate").Visible = False
                                .Columns("PSGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @18%").Width = 120
                                .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("CGST Amt @9%").Width = 100
                                .Columns("CGST Amt @9%").OptionsColumn.ReadOnly = True
                                .Columns("CGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("SGST Amt @9%").Width = 100
                                .Columns("SGST Amt @9%").OptionsColumn.ReadOnly = True
                                .Columns("SGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("CGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("SGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 14 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9))
                            sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @14%", gstAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @14%", sgstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("CGSTRate").Visible = False
                                .Columns("CGSTAmt").Visible = False
                                .Columns("SGSTRate").Visible = False
                                .Columns("SGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PCGSTRate").Visible = False
                                .Columns("PCGSTAmt").Visible = False
                                .Columns("PSGSTRate").Visible = False
                                .Columns("PSGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @28%").Width = 120
                                .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("CGST Amt @14%").Width = 100
                                .Columns("CGST Amt @14%").OptionsColumn.ReadOnly = True
                                .Columns("CGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("SGST Amt @14%").Width = 100
                                .Columns("SGST Amt @14%").OptionsColumn.ReadOnly = True
                                .Columns("SGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("CGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("SGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        End If
                        If 6 = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9)) + Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @12%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @6%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @6%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @12%").Width = 120
                                    .Columns("Taxable Value @12%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @6%").Width = 100
                                    .Columns("CGST Amt @6%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @6%").Width = 100
                                    .Columns("SGST Amt @6%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @12%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @6%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @6%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @12%").Width = 120
                                    .Columns("Taxable Value @12%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @6%").Width = 100
                                    .Columns("CGST Amt @6%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @6%").Width = 100
                                    .Columns("SGST Amt @6%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 9 = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9)) + Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @9%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @9%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("ProductName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @18%").Width = 120
                                    .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @9%").Width = 100
                                    .Columns("CGST Amt @9%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @9%").Width = 100
                                    .Columns("SGST Amt @9%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @9%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @9%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @18%").Width = 120
                                    .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @9%").Width = 100
                                    .Columns("CGST Amt @9%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @9%").Width = 100
                                    .Columns("SGST Amt @9%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 14 = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9)) + Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @14%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @14%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @28%").Width = 120
                                    .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @14%").Width = 100
                                    .Columns("CGST Amt @14%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @14%").Width = 100
                                    .Columns("SGST Amt @14%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")

                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @14%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @14%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @28%").Width = 120
                                    .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @14%").Width = 100
                                    .Columns("CGST Amt @14%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @14%").Width = 100
                                    .Columns("SGST Amt @14%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 0 = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                            'Skip
                        End If
                    Next
                Else
                    Dim i, j As Integer
                    sqlCgst = "Select distinct InvoiceDetail.CGSTRate from Invoice,InvoiceDetail where Invoice.InvoiceID = InvoiceDetail.InvoiceID And (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And (ReceiverName='" + PartyNameComboBoxEdit.Text + "') And Invoice.InvoiceType='" + PubInvoiceType + "'"
                    sqlLineItems = "SELECT Invoice.InvoiceNo, Invoice.InvoiceDate, Invoice.ReceiverName, InvoiceDetail.HSNACS, SUM(InvoiceDetail.Qty) AS Quantity, SUM(InvoiceDetail.TaxableValue) AS TaxableValue, InvoiceDetail.CGSTRate AS CGSTRate, SUM(InvoiceDetail.CGSTAmt) AS CGSTAmt, 
                            InvoiceDetail.SGSTRate AS SGSTRate, SUM(InvoiceDetail.SGSTAmt) AS SGSTAmt, Invoice.PackingCharge, Invoice.PCGSTRate, Invoice.PCGSTAmt, Invoice.PSGSTRate, Invoice.PSGSTAmt, InvoiceDetail.ProductName, Invoice.ModelNo
                            FROM (Invoice INNER JOIN
                            InvoiceDetail ON Invoice.InvoiceID = InvoiceDetail.InvoiceID)
                            WHERE (Invoice.InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And (ReceiverName='" + PartyNameComboBoxEdit.Text + "') And Invoice.InvoiceType='" + PubInvoiceType + "'
                            GROUP BY Invoice.InvoiceNo, Invoice.InvoiceDate, Invoice.ReceiverName, InvoiceDetail.CGSTRate, InvoiceDetail.SGSTRate, Invoice.PackingCharge, Invoice.PCGSTRate, Invoice.PCGSTAmt, Invoice.PSGSTRate, Invoice.PSGSTAmt,InvoiceDetail.HSNACS, InvoiceDetail.ProductName, Invoice.ModelNo
                            ORDER BY Invoice.InvoiceDate ASC"
                    sqlPacking = "SELECT PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt from Invoice Where (InvoiceDate between #" & FromDateDateEdit.Text & "# And #" & ToDateDateEdit.Text & "#) And (ReceiverName='" + PartyNameComboBoxEdit.Text + "') And InvoiceType='" + PubInvoiceType + "'"

                    daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
                    daCgst.Fill(dtCgst)

                    daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
                    daLI.Fill(dtLI)

                    daPacking = New OleDbDataAdapter(sqlPacking, ConStr)
                    daPacking.Fill(dtPacking)
                    Dim list1 As New List(Of Object)

                    For i = 0 To dtCgst.Rows.Count - 1
                        If Not dtCgst.Rows(i).Item(0) Is DBNull.Value Then
                            list1.Add(dtCgst.Rows(i).Item(0))
                        End If
                    Next
                    For j = 0 To dtPacking.Rows.Count - 1
                        Dim Pcharge As Double
                        Pcharge = CDec(dtPacking.Rows(j).Item(0))

                        If Not list1.Contains(dtPacking.Rows(j).Item(1)) And Not Pcharge = 0 Then
                            list1.Add(dtPacking.Rows(j).Item(1))
                        End If
                    Next
                    Dim TaxvalLabel As String
                    Dim CGSTAmtLabel As String
                    Dim SGSTAmtLabel As String
                    Dim TaxValPer As Decimal

                    For i = 0 To list1.Count - 1
                        TaxValPer = CDec(list1.Item(i)) + CDec(list1.Item(i))
                        TaxvalLabel = "Taxable Value @" + TaxValPer.ToString() + "%"
                        CGSTAmtLabel = "CGST Amt @" + list1.Item(i).ToString() + "%"
                        SGSTAmtLabel = "SGST Amt @" + list1.Item(i).ToString() + "%"
                        dtLI.Columns.Add(TaxvalLabel)
                        dtLI.Columns.Add(CGSTAmtLabel)
                        dtLI.Columns.Add(SGSTAmtLabel)
                    Next
                    For j = 0 To dtLI.Rows.Count - 1
                        If 2.5 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9))
                            sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @5%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @2.5%", gstAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @2.5%", sgstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("CGSTRate").Visible = False
                                .Columns("CGSTAmt").Visible = False
                                .Columns("SGSTRate").Visible = False
                                .Columns("SGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PCGSTRate").Visible = False
                                .Columns("PCGSTAmt").Visible = False
                                .Columns("PSGSTRate").Visible = False
                                .Columns("PSGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @5%").Width = 120
                                .Columns("Taxable Value @5%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("CGST Amt @2.5%").Width = 100
                                .Columns("CGST Amt @2.5%").OptionsColumn.ReadOnly = True
                                .Columns("CGST Amt @2.5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("SGST Amt @2.5%").Width = 100
                                .Columns("SGST Amt @2.5%").OptionsColumn.ReadOnly = True
                                .Columns("SGST Amt @2.5%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("CGST Amt @2.5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("SGST Amt @2.5%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 6 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9))
                            sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @12%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @6%", gstAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @6%", sgstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("CGSTRate").Visible = False
                                .Columns("CGSTAmt").Visible = False
                                .Columns("SGSTRate").Visible = False
                                .Columns("SGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("Quantity").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PCGSTRate").Visible = False
                                .Columns("PCGSTAmt").Visible = False
                                .Columns("PSGSTRate").Visible = False
                                .Columns("PSGSTAmt").Visible = False
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @12%").Width = 120
                                .Columns("Taxable Value @12%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("CGST Amt @6%").Width = 100
                                .Columns("CGST Amt @6%").OptionsColumn.ReadOnly = True
                                .Columns("CGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("SGST Amt @6%").Width = 100
                                .Columns("SGST Amt @6%").OptionsColumn.ReadOnly = True
                                .Columns("SGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("CGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("SGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 9 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9))
                            sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(5))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @9%", gstAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @9%", sgstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("CGSTRate").Visible = False
                                .Columns("CGSTAmt").Visible = False
                                .Columns("SGSTRate").Visible = False
                                .Columns("SGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PCGSTRate").Visible = False
                                .Columns("PCGSTAmt").Visible = False
                                .Columns("PSGSTRate").Visible = False
                                .Columns("PSGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @18%").Width = 120
                                .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("CGST Amt @9%").Width = 100
                                .Columns("CGST Amt @9%").OptionsColumn.ReadOnly = True
                                .Columns("CGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("SGST Amt @9%").Width = 100
                                .Columns("SGST Amt @9%").OptionsColumn.ReadOnly = True
                                .Columns("SGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("CGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("SGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        ElseIf 14 = Convert.ToDecimal(dtLI.Rows(j).Item(6)) Then
                            taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5))
                            taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                            gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7))
                            gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                            sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9))
                            sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                            With InvoiceDetailGridView
                                InvoiceDetailGridControl.DataSource = dtLI
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @14%", gstAmt)
                                InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @14%", sgstAmt)
                                .Columns("TaxableValue").Visible = False
                                .Columns("CGSTRate").Visible = False
                                .Columns("CGSTAmt").Visible = False
                                .Columns("SGSTRate").Visible = False
                                .Columns("SGSTAmt").Visible = False
                                .Columns("InvoiceNo").Visible = True
                                .Columns("InvoiceDate").Visible = True
                                .Columns("ReceiverName").Visible = True
                                .Columns("HSNACS").Visible = True
                                .Columns("PackingCharge").Visible = False
                                .Columns("PCGSTRate").Visible = False
                                .Columns("PCGSTAmt").Visible = False
                                .Columns("PSGSTRate").Visible = False
                                .Columns("PSGSTAmt").Visible = False
                                .Columns("Quantity").Visible = True
                                .Columns("InvoiceNo").Width = 120
                                .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                .Columns("InvoiceDate").Width = 100
                                .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Width = 200
                                .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                .Columns("ReceiverName").Caption = "Party Name"
                                .Columns("Quantity").OptionsColumn.ReadOnly = True
                                .Columns("Quantity").Width = 80
                                .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                .Columns("Taxable Value @28%").Width = 120
                                .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("CGST Amt @14%").Width = 100
                                .Columns("CGST Amt @14%").OptionsColumn.ReadOnly = True
                                .Columns("CGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .Columns("SGST Amt @14%").Width = 100
                                .Columns("SGST Amt @14%").OptionsColumn.ReadOnly = True
                                .Columns("SGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                .OptionsView.ShowFooter = True
                                .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("CGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                .Columns("SGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            End With
                        End If
                        If 6 = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9)) + Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @12%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @6%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @6%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @12%").Width = 120
                                    .Columns("Taxable Value @12%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @6%").Width = 100
                                    .Columns("CGST Amt @6%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @6%").Width = 100
                                    .Columns("SGST Amt @6%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @12%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @6%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @6%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @12%").Width = 120
                                    .Columns("Taxable Value @12%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @12%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @6%").Width = 100
                                    .Columns("CGST Amt @6%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @6%").Width = 100
                                    .Columns("SGST Amt @6%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @6%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @12%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @6%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 9 = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9)) + Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @9%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @9%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @18%").Width = 120
                                    .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @9%").Width = 100
                                    .Columns("CGST Amt @9%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @9%").Width = 100
                                    .Columns("SGST Amt @9%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @18%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @9%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @9%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("ProductName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @18%").Width = 120
                                    .Columns("Taxable Value @18%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @18%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @9%").Width = 100
                                    .Columns("CGST Amt @9%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @9%").Width = 100
                                    .Columns("SGST Amt @9%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @9%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @18%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @9%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 14 = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                            If Convert.ToDecimal(dtLI.Rows(j).Item(6)) = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(5)) + Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(7)) + Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(9)) + Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")
                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @14%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @14%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @28%").Width = 120
                                    .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @14%").Width = 100
                                    .Columns("CGST Amt @14%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @14%").Width = 100
                                    .Columns("SGST Amt @14%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            Else
                                taxAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(10))
                                taxAmt = Math.Round(taxAmnt, 2).ToString("F2")
                                gstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(12))
                                gstAmt = Math.Round(gstAmnt, 2).ToString("F2")
                                sgstAmnt = Convert.ToDecimal(dtLI.Rows(j).Item(14))
                                sgstAmt = Math.Round(sgstAmnt, 2).ToString("F2")

                                With InvoiceDetailGridView
                                    InvoiceDetailGridControl.DataSource = dtLI
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceNo", dtLI.Rows(j).Item(0))
                                    InvoiceDetailGridView.SetRowCellValue(j, "InvoiceDate", dtLI.Rows(j).Item(1))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ReceiverName", dtLI.Rows(j).Item(2))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ProductName", dtLI.Rows(j).Item(15))
                                    InvoiceDetailGridView.SetRowCellValue(j, "HSNACS", dtLI.Rows(j).Item(3))
                                    InvoiceDetailGridView.SetRowCellValue(j, "ModelNo", dtLI.Rows(j).Item(16))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Quantity", dtLI.Rows(j).Item(4))
                                    InvoiceDetailGridView.SetRowCellValue(j, "Taxable Value @28%", taxAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "CGST Amt @14%", gstAmt)
                                    InvoiceDetailGridView.SetRowCellValue(j, "SGST Amt @14%", sgstAmt)
                                    .Columns("TaxableValue").Visible = False
                                    .Columns("CGSTRate").Visible = False
                                    .Columns("CGSTAmt").Visible = False
                                    .Columns("SGSTRate").Visible = False
                                    .Columns("SGSTAmt").Visible = False
                                    .Columns("InvoiceNo").Visible = True
                                    .Columns("InvoiceDate").Visible = True
                                    .Columns("ReceiverName").Visible = True
                                    .Columns("HSNACS").Visible = True
                                    .Columns("PackingCharge").Visible = False
                                    .Columns("PCGSTRate").Visible = False
                                    .Columns("PCGSTAmt").Visible = False
                                    .Columns("PSGSTRate").Visible = False
                                    .Columns("PSGSTAmt").Visible = False
                                    .Columns("Quantity").Visible = True
                                    .Columns("InvoiceNo").Width = 120
                                    .Columns("InvoiceNo").OptionsColumn.ReadOnly = True
                                    .Columns("InvoiceDate").Width = 100
                                    .Columns("InvoiceDate").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Width = 200
                                    .Columns("ReceiverName").OptionsColumn.ReadOnly = True
                                    .Columns("ReceiverName").Caption = "Party Name"
                                    .Columns("Quantity").OptionsColumn.ReadOnly = True
                                    .Columns("Quantity").Width = 80
                                    .Columns("Quantity").AppearanceCell.TextOptions.HAlignment = HorizontalAlignment.Center
                                    .Columns("Taxable Value @28%").Width = 120
                                    .Columns("Taxable Value @28%").OptionsColumn.ReadOnly = True
                                    .Columns("Taxable Value @28%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("CGST Amt @14%").Width = 100
                                    .Columns("CGST Amt @14%").OptionsColumn.ReadOnly = True
                                    .Columns("CGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .Columns("SGST Amt @14%").Width = 100
                                    .Columns("SGST Amt @14%").OptionsColumn.ReadOnly = True
                                    .Columns("SGST Amt @14%").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                                    .OptionsView.ShowFooter = True
                                    .Columns("Quantity").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("Taxable Value @28%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("CGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .Columns("SGST Amt @14%").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                End With
                            End If
                        ElseIf 0 = Convert.ToDecimal(dtLI.Rows(j).Item(11)) Then
                            'Skip
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ResetSimpleButton_Click(sender As Object, e As EventArgs) Handles ResetSimpleButton.Click
        InvoiceDetailGridControl.DataSource = Nothing
        InvoiceDetailGridView.Columns.Clear()
        InvoiceDetailGridControl.Refresh()
        FromDateDateEdit.Text = Date.Today()
        ToDateDateEdit.Text = Date.Today()
        PartyNameComboBoxEdit.Text = ""
    End Sub

    Private Sub ExportExcelSimpleButton_Click(sender As Object, e As EventArgs) Handles ExportExcelSimpleButton.Click
        InvoiceDetailGridControl.ExportToXlsx("SalesReport.xlsx")
        Process.Start("SalesReport.xlsx")
    End Sub
End Class

