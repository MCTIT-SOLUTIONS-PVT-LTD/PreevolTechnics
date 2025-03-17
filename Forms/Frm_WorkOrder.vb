Imports System.Configuration
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports EASendMail
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Public Class Frm_WorkOrder
    Dim DS As New DataSet
    Dim DA As New OleDbDataAdapter
    Dim BS As New BindingSource
    Dim DADetails As New OleDbDataAdapter
    Dim BSDetails As New BindingSource
    Dim Status As Integer = 0
    Dim NetAmtLabel As New LabelControl
    Dim CurrentWONo As Integer = 0
    Dim IsDis As Boolean
    Private Sub FrmMasterConceptFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetRelation()
        SetQuery()
        SetBinding()
        SetGrid()
        InitLookup()

        AddNew()

        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Sub SetDataTable()
        'WorkOrder
        DS.Tables.Add("WorkOrder")
        With DS.Tables("WorkOrder").Columns
            .Add("WorkOrderID", GetType(Integer))
            .Add("WO", GetType(String))
            .Add("WODate", GetType(Date))
            .Item("WODate").DefaultValue = Date.Today
            .Add("DeliverySchedule", GetType(String))
            .Add("QuotRef", GetType(String))
            .Add("TransportorFOR", GetType(String))
            .Add("PaymentDays", GetType(String))
            .Add("AgainstForm", GetType(String))
            .Add("ConsignorName", GetType(String))
            .Add("ConsignorAddress", GetType(String))
            .Add("ConsignorGSTIN", GetType(String))
            .Add("ConsignorState", GetType(String))
            .Add("ConsignorStateCode", GetType(String))
            .Add("ConsignorPanNo", GetType(String))
            .Add("TotalAmtBeforeTax", GetType(Double))
            .Add("CGST", GetType(Double))
            .Add("SGST", GetType(Double))
            .Add("IGST", GetType(Double))
            .Add("TotalGSTTax", GetType(Double))
            .Add("TotalAmtAfterTax", GetType(Double))
            .Add("GSTReverseCharge", GetType(Double))
            .Add("TotalInWords", GetType(String))
            .Add("TaxInWords", GetType(String))
            .Add("Remarks", GetType(String))
            .Add("GrandTotalAmount", GetType(Double))
            .Add("RoundOff", GetType(Double))
            .Add("CreatedBy", GetType(String))
            .Add("ModifiedBy", GetType(String))
            .Add("Company", GetType(String))
            .Add("WOType", GetType(String))
            .Item("Company").DefaultValue = PubCompanyName

        End With

        With DS.Tables("WorkOrder").Columns("WorkOrderID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With

        'Work Order Detail
        DS.Tables.Add("WorkOrderDetail")
        With DS.Tables("WorkOrderDetail").Columns
            .Add("WorkOrderDetailID", GetType(Integer))
            .Add("WorkOrderID", GetType(Integer))
            .Add("ProductName", GetType(String))
            .Add("Description", GetType(String))
            .Add("HSNACS", GetType(String))
            .Add("UOM", GetType(String))
            .Add("Qty", GetType(Double))
            .Add("Rate", GetType(Double))
            .Add("Amount", GetType(Double))
            .Add("Discount", GetType(Double))
            .Add("DiscountVal", GetType(Double))
            .Add("TaxableValue", GetType(Double))
            .Add("CGSTRate", GetType(Double))
            .Add("CGSTAmt", GetType(Double))
            .Add("SGSTRate", GetType(Double))
            .Add("SGSTAmt", GetType(Double))
            .Add("IGSTRate", GetType(Double))
            .Add("IGSTAmt", GetType(Double))
            .Add("TotalAmount", GetType(Double))
        End With

        With DS.Tables("WorkOrderDetail").Columns("WorkOrderDetailID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetRelation()
        DS.Relations.Add(New DataRelation("RelationWorkOrder", DS.Tables("WorkOrder").Columns("WorkOrderID"), DS.Tables("WorkOrderDetail").Columns("WorkOrderID"), False))
        Dim FK_WorkOrderDetail As New Global.System.Data.ForeignKeyConstraint("FK_WorkOrder", DS.Tables("WorkOrder").Columns("WorkOrderID"), DS.Tables("WorkOrderDetail").Columns("WorkOrderID"))
        DS.Tables("WorkOrderDetail").Constraints.Add(FK_WorkOrderDetail)
        With FK_WorkOrderDetail
            .AcceptRejectRule = AcceptRejectRule.None
            .DeleteRule = Rule.Cascade
            .UpdateRule = Rule.Cascade
        End With

        BS.DataSource = DS
        BS.DataMember = "WorkOrder"

        BSDetails.DataSource = BS
        BSDetails.DataMember = "RelationWorkOrder"

        WorkOrderDetailGridControl.DataSource = BSDetails
    End Sub

    Sub SetQuery()
        ' Work Order ......................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................
        DA.SelectCommand = New OleDbCommand("Select WorkOrderID,WO,WODate,DeliverySchedule,QuotRef,TransportorFOR,PaymentDays,AgainstForm,ConsignorName,ConsignorAddress,ConsignorGSTIN,ConsignorState,ConsignorStateCode,ConsignorPanNo,TotalAmtBeforeTax,CGST,SGST,IGST,TotalGSTTax,TotalAmtAfterTax,GSTReverseCharge,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,Company,WOType From WorkOrder Where WorkOrderID=@WorkOrderID", ConStr)
        DA.SelectCommand.Parameters.Add("@WorkOrderID", OleDbType.Integer, 4, "WorkOrderID")

        DA.InsertCommand = New OleDbCommand("Insert Into WorkOrder (WO,WODate,DeliverySchedule,QuotRef,TransportorFOR,PaymentDays,AgainstForm,ConsignorName,ConsignorAddress,ConsignorGSTIN,ConsignorState,ConsignorStateCode,ConsignorPanNo,TotalAmtBeforeTax,CGST,SGST,IGST,TotalGSTTax,TotalAmtAfterTax,GSTReverseCharge,TotalInWords,TaxInWords,Remarks,GrandTotalAmount,RoundOff,CreatedBy,ModifiedBy,Company,WOType) Values (@WO,@WODate,@DeliverySchedule,@QuotRef,@TransportorFOR,@PaymentDays,@AgainstForm,@ConsignorName,@ConsignorAddress,@ConsignorGSTIN,@ConsignorState,@ConsignorStateCode,@ConsignorPanNo,@TotalAmtBeforeTax,@CGST,@SGST,@IGST,@TotalGSTTax,@TotalAmtAfterTax,@GSTReverseCharge,@TotalInWords,@TaxInWords,@Remarks,@GrandTotalAmount,@RoundOff,@CreatedBy,@ModifiedBy,@Company,@WOType)", ConStr)
        DA.InsertCommand.Parameters.Add("@WO", OleDbType.VarChar, 50, "WO")
        DA.InsertCommand.Parameters.Add("@WODate", OleDbType.Date, 3, "WODate")
        DA.InsertCommand.Parameters.Add("@DeliverySchedule", OleDbType.VarChar, 50, "DeliverySchedule")
        DA.InsertCommand.Parameters.Add("@QuotRef", OleDbType.VarChar, 50, "QuotRef")
        DA.InsertCommand.Parameters.Add("@TransportorFOR", OleDbType.VarChar, 50, "TransportorFOR")
        DA.InsertCommand.Parameters.Add("@PaymentDays", OleDbType.VarChar, 50, "PaymentDays")
        DA.InsertCommand.Parameters.Add("@AgainstForm", OleDbType.VarChar, 50, "AgainstForm")
        DA.InsertCommand.Parameters.Add("@ConsignorName", OleDbType.VarChar, 100, "ConsignorName")
        DA.InsertCommand.Parameters.Add("@ConsignorAddress", OleDbType.VarChar, 200, "ConsignorAddress")
        DA.InsertCommand.Parameters.Add("@ConsignorGSTIN", OleDbType.VarChar, 50, "ConsignorGSTIN")
        DA.InsertCommand.Parameters.Add("@ConsignorState", OleDbType.VarChar, 50, "ConsignorState")
        DA.InsertCommand.Parameters.Add("@ConsignorStateCode", OleDbType.VarChar, 50, "ConsignorStateCode")
        DA.InsertCommand.Parameters.Add("@ConsignorPanNo", OleDbType.VarChar, 50, "ConsignorPanNo")
        DA.InsertCommand.Parameters.Add("@TotalAmtBeforeTax", OleDbType.Double, 8, "TotalAmtBeforeTax")
        DA.InsertCommand.Parameters.Add("@CGST", OleDbType.Double, 8, "CGST")
        DA.InsertCommand.Parameters.Add("@SGST", OleDbType.Double, 8, "SGST")
        DA.InsertCommand.Parameters.Add("@IGST", OleDbType.Double, 8, "IGST")
        DA.InsertCommand.Parameters.Add("@TotalGSTTax", OleDbType.Double, 8, "TotalGSTTax")
        DA.InsertCommand.Parameters.Add("@TotalAmtAfterTax", OleDbType.Double, 8, "TotalAmtAfterTax")
        DA.InsertCommand.Parameters.Add("@GSTReverseCharge", OleDbType.Double, 8, "GSTReverseCharge")
        DA.InsertCommand.Parameters.Add("@TotalInWords", OleDbType.VarChar, 150, "TotalInWords")
        DA.InsertCommand.Parameters.Add("@TaxInWords", OleDbType.VarChar, 150, "TaxInWords")
        DA.InsertCommand.Parameters.Add("@Remarks", OleDbType.VarChar, 500, "Remarks")
        DA.InsertCommand.Parameters.Add("@GrandTotalAmount", OleDbType.Double, 8, "GrandTotalAmount")
        DA.InsertCommand.Parameters.Add("@RoundOff", OleDbType.Double, 8, "RoundOff")
        DA.InsertCommand.Parameters.Add("@CreatedBy", OleDbType.VarChar, 50, "CreatedBy")
        DA.InsertCommand.Parameters.Add("@ModifiedBy", OleDbType.VarChar, 50, "ModifiedBy")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")
        DA.InsertCommand.Parameters.Add("@WOType", OleDbType.VarChar, 50, "WOType")

        DA.UpdateCommand = New OleDbCommand("Update WorkOrder Set WO=@WO,WODate=@WODate,DeliverySchedule=@DeliverySchedule,QuotRef=@QuotRef,TransportorFOR=@TransportorFOR,PaymentDays=@PaymentDays,AgainstForm=@AgainstForm,ConsignorName=@ConsignorName,ConsignorAddress=@ConsignorAddress,ConsignorGSTIN=@ConsignorGSTIN,ConsignorState=@ConsignorState,ConsignorStateCode=@ConsignorStateCode,ConsignorPanNo=@ConsignorPanNo,TotalAmtBeforeTax=@TotalAmtBeforeTax,CGST=@CGST,SGST=@SGST,IGST=@IGST,TotalGSTTax=@TotalGSTTax,TotalAmtAfterTax=@TotalAmtAfterTax,GSTReverseCharge=@GSTReverseCharge,TotalInWords=@TotalInWords,TaxInWords=@TaxInWords,Remarks=@Remarks,GrandTotalAmount=@GrandTotalAmount,RoundOff=@RoundOff,ModifiedBy=@ModifiedBy Where WorkOrderID=@WorkOrderID", ConStr)
        DA.UpdateCommand.Parameters.Add("@WO", OleDbType.VarChar, 50, "WO")
        DA.UpdateCommand.Parameters.Add("@WODate", OleDbType.Date, 3, "WODate")
        DA.UpdateCommand.Parameters.Add("@DeliverySchedule", OleDbType.VarChar, 50, "DeliverySchedule")
        DA.UpdateCommand.Parameters.Add("@QuotRef", OleDbType.VarChar, 50, "QuotRef")
        DA.UpdateCommand.Parameters.Add("@TransportorFOR", OleDbType.VarChar, 50, "TransportorFOR")
        DA.UpdateCommand.Parameters.Add("@PaymentDays", OleDbType.VarChar, 50, "PaymentDays")
        DA.UpdateCommand.Parameters.Add("@AgainstForm", OleDbType.VarChar, 50, "AgainstForm")
        DA.UpdateCommand.Parameters.Add("@ConsignorName", OleDbType.VarChar, 100, "ConsignorName")
        DA.UpdateCommand.Parameters.Add("@ConsignorAddress", OleDbType.VarChar, 200, "ConsignorAddress")
        DA.UpdateCommand.Parameters.Add("@ConsignorGSTIN", OleDbType.VarChar, 50, "ConsignorGSTIN")
        DA.UpdateCommand.Parameters.Add("@ConsignorState", OleDbType.VarChar, 50, "ConsignorState")
        DA.UpdateCommand.Parameters.Add("@ConsignorStateCode", OleDbType.VarChar, 50, "ConsignorStateCode")
        DA.UpdateCommand.Parameters.Add("@ConsignorPanNo", OleDbType.VarChar, 50, "ConsignorPanNo")
        DA.UpdateCommand.Parameters.Add("@TotalAmtBeforeTax", OleDbType.Double, 8, "TotalAmtBeforeTax")
        DA.UpdateCommand.Parameters.Add("@CGST", OleDbType.Double, 8, "CGST")
        DA.UpdateCommand.Parameters.Add("@SGST", OleDbType.Double, 8, "SGST")
        DA.UpdateCommand.Parameters.Add("@IGST", OleDbType.Double, 8, "IGST")
        DA.UpdateCommand.Parameters.Add("@TotalGSTTax", OleDbType.Double, 8, "TotalGSTTax")
        DA.UpdateCommand.Parameters.Add("@TotalAmtAfterTax", OleDbType.Double, 8, "TotalAmtAfterTax")
        DA.UpdateCommand.Parameters.Add("@GSTReverseCharge", OleDbType.Double, 8, "GSTReverseCharge")
        DA.UpdateCommand.Parameters.Add("@TotalInWords", OleDbType.VarChar, 150, "TotalInWords")
        DA.UpdateCommand.Parameters.Add("@TaxInWords", OleDbType.VarChar, 150, "TaxInWords")
        DA.UpdateCommand.Parameters.Add("@Remarks", OleDbType.VarChar, 500, "Remarks")
        DA.UpdateCommand.Parameters.Add("@GrandTotalAmount", OleDbType.Double, 8, "GrandTotalAmount")
        DA.UpdateCommand.Parameters.Add("@RoundOff", OleDbType.Double, 8, "RoundOff")
        DA.UpdateCommand.Parameters.Add("@ModifiedBy", OleDbType.VarChar, 50, "ModifiedBy")
        DA.UpdateCommand.Parameters.Add("@WorkOrderID", OleDbType.Integer, 4, "WorkOrderID")

        DA.DeleteCommand = New OleDbCommand("Delete From WorkOrder Where WorkOrderID=@WorkOrderID", ConStr)
        DA.DeleteCommand.Parameters.Add("@WorkOrderID", OleDbType.Integer, 4, "WorkOrderID")

        ' WorkOrder Detail ..............................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................

        DADetails.SelectCommand = New OleDbCommand("Select WorkOrderDetailID,WorkOrderID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount From WorkOrderDetail Where WorkOrderID=@WorkOrderID", ConStr)
        DADetails.SelectCommand.Parameters.Add("@WorkOrderID", OleDbType.Integer, 4, "WorkOrderID")

        DADetails.InsertCommand = New OleDbCommand("Insert Into WorkOrderDetail (WorkOrderID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@WorkOrderID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
        DADetails.InsertCommand.Parameters.Add("@WorkOrderID", OleDbType.Integer, 4, "WorkOrderID")
        DADetails.InsertCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 5000, "ProductName")
        DADetails.InsertCommand.Parameters.Add("@Description", OleDbType.VarChar, 5000, "Description")
        DADetails.InsertCommand.Parameters.Add("@HSNACS", OleDbType.VarChar, 50, "HSNACS")
        DADetails.InsertCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DADetails.InsertCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DADetails.InsertCommand.Parameters.Add("@Rate", OleDbType.Double, 8, "Rate")
        DADetails.InsertCommand.Parameters.Add("@Amount", OleDbType.Double, 8, "Amount")
        DADetails.InsertCommand.Parameters.Add("@Discount", OleDbType.Double, 8, "Discount")
        DADetails.InsertCommand.Parameters.Add("@DiscountVal", OleDbType.Double, 8, "DiscountVal")
        DADetails.InsertCommand.Parameters.Add("@TaxableValue", OleDbType.Double, 8, "TaxableValue")
        DADetails.InsertCommand.Parameters.Add("@CGSTRate", OleDbType.Double, 8, "CGSTRate")
        DADetails.InsertCommand.Parameters.Add("@CGSTAmt", OleDbType.Double, 8, "CGSTAmt")
        DADetails.InsertCommand.Parameters.Add("@SGSTRate", OleDbType.Double, 8, "SGSTRate")
        DADetails.InsertCommand.Parameters.Add("@SGSTAmt", OleDbType.Double, 8, "SGSTAmt")
        DADetails.InsertCommand.Parameters.Add("@IGSTRate", OleDbType.Double, 8, "IGSTRate")
        DADetails.InsertCommand.Parameters.Add("@IGSTAmt", OleDbType.Double, 8, "IGSTAmt")
        DADetails.InsertCommand.Parameters.Add("@TotalAmount", OleDbType.Double, 8, "TotalAmount")

        DADetails.UpdateCommand = New OleDbCommand("Update WorkOrderDetail Set WorkOrderID=@WorkOrderID,ProductName=@ProductName,Description=@Description,HSNACS=@HSNACS,UOM=@UOM,Qty=@Qty,Rate=@Rate,Amount=@Amount,Discount=@Discount,DiscountVal=@DiscountVal,TaxableValue=@TaxableValue,CGSTRate=@CGSTRate,CGSTAmt=@CGSTAmt,SGSTRate=@SGSTRate,SGSTAmt=@SGSTAmt,IGSTRate=@IGSTRate,IGSTAmt=@IGSTAmt,TotalAmount=@TotalAmount Where WorkOrderDetailID=@WorkOrderDetailID", ConStr)
        DADetails.UpdateCommand.Parameters.Add("@WorkOrderID", OleDbType.Integer, 4, "WorkOrderID")
        DADetails.UpdateCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 5000, "ProductName")
        DADetails.UpdateCommand.Parameters.Add("@Description", OleDbType.VarChar, 5000, "Description")
        DADetails.UpdateCommand.Parameters.Add("@HSNACS", OleDbType.VarChar, 50, "HSNACS")
        DADetails.UpdateCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DADetails.UpdateCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DADetails.UpdateCommand.Parameters.Add("@Rate", OleDbType.Double, 8, "Rate")
        DADetails.UpdateCommand.Parameters.Add("@Amount", OleDbType.Double, 8, "Amount")
        DADetails.UpdateCommand.Parameters.Add("@Discount", OleDbType.Double, 8, "Discount")
        DADetails.UpdateCommand.Parameters.Add("@DiscountVal", OleDbType.Double, 8, "DiscountVal")
        DADetails.UpdateCommand.Parameters.Add("@TaxableValue", OleDbType.Double, 8, "TaxableValue")
        DADetails.UpdateCommand.Parameters.Add("@CGSTRate", OleDbType.Double, 8, "CGSTRate")
        DADetails.UpdateCommand.Parameters.Add("@CGSTAmt", OleDbType.Double, 8, "CGSTAmt")
        DADetails.UpdateCommand.Parameters.Add("@SGSTRate", OleDbType.Double, 8, "SGSTRate")
        DADetails.UpdateCommand.Parameters.Add("@SGSTAmt", OleDbType.Double, 8, "SGSTAmt")
        DADetails.UpdateCommand.Parameters.Add("@IGSTRate", OleDbType.Double, 8, "IGSTRate")
        DADetails.UpdateCommand.Parameters.Add("@IGSTAmt", OleDbType.Double, 8, "IGSTAmt")
        DADetails.UpdateCommand.Parameters.Add("@TotalAmount", OleDbType.Double, 8, "TotalAmount")
        DADetails.UpdateCommand.Parameters.Add("@WorkOrderDetailID", OleDbType.Integer, 4, "WorkOrderDetailID")

        DADetails.DeleteCommand = New OleDbCommand("Delete From WorkOrderDetail Where WorkOrderDetailID=@WorkOrderDetailID", ConStr)
        DADetails.DeleteCommand.Parameters.Add("@WorkOrderDetailID", OleDbType.Integer, 4, "WorkOrderDetailID")
    End Sub

    Sub SetBinding()

        WOTextEdit.DataBindings.Add(New Binding("EditValue", BS, "WO"))
        WODateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "WODate"))
        DeliveryScheduleTextEdit.DataBindings.Add(New Binding("EditValue", BS, "DeliverySchedule"))
        QuotRefTextEdit.DataBindings.Add(New Binding("EditValue", BS, "QuotRef"))
        TransportTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TransportorFOR"))
        PaymentDaysTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PaymentDays"))
        AgainstFormTextEdit.DataBindings.Add(New Binding("EditValue", BS, "AgainstForm"))
        ConsignorNameComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsignorName"))
        ConsignorAddressTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsignorAddress"))
        ConsignorGSTINTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsignorGSTIN"))
        ConsignorStateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsignorState"))
        ConsignorStateCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsignorStateCode"))
        ConsignorPANNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ConsignorPanNo"))
        TotalAmtBeforeTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalAmtBeforeTax"))
        CGSTTextEdit.DataBindings.Add(New Binding("EditValue", BS, "CGST"))
        SGSTTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SGST"))
        IGSTTextEdit.DataBindings.Add(New Binding("EditValue", BS, "IGST"))
        TotalGSTTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalGSTTax"))
        TotalAmtAfterTaxTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalAmtAfterTax"))
        GSTReverseChargeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "GSTReverseCharge"))
        TotalInWordsTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TotalInWords"))
        TaxInWordsTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TaxInWords"))
        RemarksTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Remarks"))
        NetAmtLabel.DataBindings.Add(New Binding("Text", BS, "GrandTotalAmount"))
        CreatedByTextEdit.DataBindings.Add(New Binding("Text", BS, "CreatedBy"))
        ModifiedByTextEdit.DataBindings.Add(New Binding("Text", BS, "ModifiedBy"))
    End Sub

    Sub InitLookup()
        If PubIGST = False Then
            SetGridCommboBox("Select DISTINCT VendorName FROM Vendor Where StateCode = 24", "Vendor", ConsignorNameComboBoxEdit)
        ElseIf PubIGST = True Then
            SetGridCommboBox("Select DISTINCT VendorName FROM Vendor Where StateCode <> 24", "Vendor", ConsignorNameComboBoxEdit)
        End If
        'SetGridCommboBox("Select DISTINCT VendorName FROM Vendor", "Vendor", ConsignorNameComboBoxEdit)
        GridComboBoxFunc("Select DISTINCT ProductName FROM POProduct", "POProduct", WorkOrderDetailGridControl, InvoiceDetailGridView, "ProductName", "POProduct")
        GridMemoEditFunc(WorkOrderDetailGridControl, InvoiceDetailGridView, "Description")
        'GridButtonEditFunc(WorkOrderDetailGridControl, InvoiceDetailGridView, "AddProduct")
    End Sub

    Sub SetGrid()
        With InvoiceDetailGridView
            .Columns("WorkOrderDetailID").Visible = False
            .Columns("WorkOrderID").Visible = False
            .Columns("Amount").OptionsColumn.AllowFocus = False
            .Columns("Amount").OptionsColumn.ReadOnly = True
            .Columns("TaxableValue").OptionsColumn.AllowFocus = False
            .Columns("TaxableValue").OptionsColumn.ReadOnly = True
            .Columns("CGSTAmt").OptionsColumn.AllowFocus = False
            .Columns("CGSTAmt").OptionsColumn.ReadOnly = True
            .Columns("SGSTAmt").OptionsColumn.AllowFocus = False
            .Columns("SGSTAmt").OptionsColumn.ReadOnly = True
            .Columns("IGSTAmt").OptionsColumn.AllowFocus = False
            .Columns("IGSTAmt").OptionsColumn.ReadOnly = True
            .Columns("TotalAmount").OptionsColumn.AllowFocus = False
            .Columns("TotalAmount").OptionsColumn.ReadOnly = True
            .Columns("ProductName").Width = 200
            .Columns("ProductName").Caption = "Product"
            .Columns("Description").Caption = "Description"
            .Columns("Description").Width = 200
            .Columns("HSNACS").Caption = "HSN"
            .Columns("Discount").Caption = "Dis.(%)"
            .Columns("DiscountVal").Caption = "Dis.(Value)"
            .Columns("CGSTRate").Caption = "CGST(%)"
            .Columns("SGSTRate").Caption = "SGST(%)"
            .Columns("IGSTRate").Caption = "IGST(%)"

            .OptionsView.ShowFooter = True
            .Columns("TaxableValue").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("CGSTAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("SGSTAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("IGSTAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("TotalAmount").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum

            .Columns("Qty").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("DiscountVal").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        End With

        InvoiceDetailGridView.BestFitColumns()
        InvoiceDetailGridView.FocusedColumn = InvoiceDetailGridView.Columns(2)
        BSDetails.ResetBindings(True)


        If PubIGST = False Then
            InvoiceDetailGridView.Columns("IGSTRate").Visible = False
            InvoiceDetailGridView.Columns("IGSTAmt").Visible = False
        ElseIf PubIGST = True Then
            InvoiceDetailGridView.Columns("CGSTRate").Visible = False
            InvoiceDetailGridView.Columns("CGSTAmt").Visible = False
            InvoiceDetailGridView.Columns("SGSTRate").Visible = False
            InvoiceDetailGridView.Columns("SGSTAmt").Visible = False
        End If
        'SetCurrencyFormat("Rate", "c", BillDetailGridView, BillDetailGridControl)
        'SetCurrencyFormat("Amount", "c", BillDetailGridView, BillDetailGridControl)
    End Sub

    Function Validation() As Boolean

        If WOTextEdit.EditValue Is DBNull.Value Then
            WOTextEdit.Focus()
            Return False
        ElseIf WODateDateEdit.EditValue Is DBNull.Value Then
            WODateDateEdit.Focus()
            Return False
        ElseIf ConsignorNameComboBoxEdit.EditValue Is DBNull.Value Then
            ConsignorNameComboBoxEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Sub AddNew()
        BS.AddNew()
        BS.Current!CreatedBy = CurrentUserName
        BS.Current!ModifiedBy = CurrentUserName
        BS.Current!Company = PubCompanyName
        BS.Current!WOType = PubWOType

        BS.Current!WO = GenerateNo()
        BS.Current!WODate = Date.Today()
        BS.Current!TotalAmtBeforeTax = 0
        BS.Current!CGST = 0
        BS.Current!SGST = 0
        BS.Current!IGST = 0
        BS.Current!TotalGSTTax = 0
        BS.Current!TotalAmtAfterTax = 0
        BS.Current!GSTReverseCharge = 0
        BS.Current!RoundOff = 0
        BS.Current!GrandTotalAmount = 0
        BS.EndEdit()

        'If PubIGST = False Then
        '    PIGSTRateTextEdit.Properties.ReadOnly = True
        '    PIGSTRateTextEdit.TabStop = False
        'ElseIf PubIGST = True Then
        '    PCGSTRateTextEdit.Properties.ReadOnly = True
        '    PCGSTRateTextEdit.TabStop = False
        '    PSGSTRateTextEdit.Properties.ReadOnly = True
        '    PSGSTRateTextEdit.TabStop = False
        'End If

        Status = 0
        Dim bz As New CultureInfo("hi-In")
        Dim GTotal As Double = BS.Current!GrandTotalAmount
        NetAmtLabelControl.Text = "Grand Amt: " + GTotal.ToString("c", bz)
        InitLookup()
    End Sub
    Function GetCurrentYear() As String
        Dim DACompany As New OleDbDataAdapter("Select CompanyID,FinancialYear From Company Where Name ='" + PubCompanyName + "'", ConStr)
        Dim DTCompany As New DataTable
        DACompany.Fill(DTCompany)

        Dim FinancialYear As String = DTCompany.Rows(0).Item("FinancialYear").ToString
        Return FinancialYear
    End Function
    Function GenerateNo() As String
        Dim DAFinance As New OleDbDataAdapter("Select FinancialYearID,FinancialYear From FinancialSettings Where Company ='" + PubCompanyName + "' AND FinancialYear = '" + GetCurrentYear() + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)

        Dim WOCMD As New OleDbCommand("SELECT COUNT(WorkOrderID) FROM WorkOrder Where Company = '" + PubCompanyName + "'", ConStr)
        CnnOpen() : Dim autoWO = Val(WOCMD.ExecuteScalar & "") : CnnClose()
        autoWO = autoWO + 1

        Dim FinancialYear As String = DTFinance.Rows(0).Item("FinancialYear").ToString
        Dim SalesInvoicePrefix As String = "PREEVOL/WO"

        Dim newWO As String = SalesInvoicePrefix + "/" + autoWO.ToString() + "/" + FinancialYear
        Return newWO
    End Function

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        BSDetails.CancelEdit()
        DS.RejectChanges()
        AddNew()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim DAFinance As New OleDbDataAdapter("Select StartDate,EndDate From Company Where name ='" + PubCompanyName + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)

        Dim StartDate As String = DTFinance.Rows(0).Item("StartDate").ToString()
        Dim SubStart As DateTime = Convert.ToDateTime(StartDate.Substring(0, 9))
        Dim EndDate As String = DTFinance.Rows(0).Item("EndDate").ToString()
        Dim SubEnd As DateTime = Convert.ToDateTime(EndDate.Substring(0, 9))

        Dim ID = ShowRecord("SELECT * FROM WorkOrder Where WOType='" + PubWOType + "'  AND (WorkOrder.WODate between #" & SubStart & "# And #" & SubEnd & "#)  AND Company='" + PubCompanyName + "' ORDER BY WODate DESC", "WorkOrderID")
        If ID > 0 Then
            Try
                DS.Tables("WorkOrderDetail").Clear()
                DS.Tables("WorkOrder").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@WorkOrderID").Value = ID
            DA.Fill(DS, "WorkOrder")
            Status = 1
            DADetails.SelectCommand.Parameters("@WorkOrderID").Value = ID
            DADetails.Fill(DS, "WorkOrderDetail")

            Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)

            CurrentWONo = ID
        End If
    End Sub

    Sub SetCurrentData()
        Dim ID = CurrentWONo
        If ID > 0 Then
            Try
                DS.Tables("WorkOrderDetail").Clear()
                DS.Tables("WorkOrder").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@WorkOrderID").Value = ID
            DA.Fill(DS, "WorkOrder")
            Status = 1
            DADetails.SelectCommand.Parameters("@WorkOrderID").Value = ID
            DADetails.Fill(DS, "WorkOrderDetail")

            Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt:  " + GTotal.ToString("c", bz)
        End If
    End Sub


    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record ?" + vbNewLine + "If You Delete This Record then Related Items Record also Delete..", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                For Each row In DS.Tables("WorkOrderDetail").Select("WorkOrderID =" & BS.Current!WorkOrderID)
                    BSDetails.RemoveCurrent()
                    DADetails.Update(DS.Tables("WorkOrderDetail"))
                Next

                BS.RemoveCurrent()
                DA.Update(DS.Tables("WorkOrder"))

                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ErtOccur(ex)
        End Try
    End Sub

    Private Sub SaveNewSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveNewSimpleButton.Click
        If Validation() Then
            If BSDetails.Count = 0 Then
                XtraMessageBox.Show("Please Enter WorkOrder Items", "Info")
            Else
                BS.Current!ModifiedBy = CurrentUserName
                BS.EndEdit()
                DA.Update(DS.Tables("WorkOrder"))
                If Status = 0 Then
                    Dim NewCMD As New OleDbCommand("SELECT MAX(WorkOrderID) FROM WorkOrder", ConStr)
                    CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
                    BSDetails.MoveFirst()
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim InsertCMD As New OleDbCommand("Insert Into WorkOrderDetail (WorkOrderID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@WorkOrderID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
                        InsertCMD.Parameters.AddWithValue("@WorkOrderID", CurrentID)
                        InsertCMD.Parameters.AddWithValue("@ProductName", BSDetails.Current!ProductName)
                        InsertCMD.Parameters.AddWithValue("@Description", BSDetails.Current!Description)
                        InsertCMD.Parameters.AddWithValue("@HSNACS", BSDetails.Current!HSNACS)
                        InsertCMD.Parameters.AddWithValue("@UOM", BSDetails.Current!UOM)
                        InsertCMD.Parameters.AddWithValue("@Qty", BSDetails.Current!Qty)
                        InsertCMD.Parameters.AddWithValue("@Rate", BSDetails.Current!Rate)
                        InsertCMD.Parameters.AddWithValue("@Amount", BSDetails.Current!Amount)
                        InsertCMD.Parameters.AddWithValue("@Discount", BSDetails.Current!Discount)
                        InsertCMD.Parameters.AddWithValue("@DiscountVal", BSDetails.Current!DiscountVal)
                        InsertCMD.Parameters.AddWithValue("@TaxableValue", BSDetails.Current!TaxableValue)
                        InsertCMD.Parameters.AddWithValue("@CGSTRate", BSDetails.Current!CGSTRate)
                        InsertCMD.Parameters.AddWithValue("@CGSTAmt", BSDetails.Current!CGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@SGSTRate", BSDetails.Current!SGSTRate)
                        InsertCMD.Parameters.AddWithValue("@SGSTAmt", BSDetails.Current!SGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@IGSTRate", BSDetails.Current!IGSTRate)
                        InsertCMD.Parameters.AddWithValue("@IGSTAmt", BSDetails.Current!IGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@TotalAmount", BSDetails.Current!TotalAmount)

                        CnnOpen() : InsertCMD.ExecuteNonQuery() : CnnClose()

                        BSDetails.MoveNext()
                    Next
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                ElseIf Status = 1 Then
                    BSDetails.EndEdit()
                    DADetails.Update(DS.Tables("WorkOrderDetail"))
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                End If
                AddNew()
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Validation() Then
            If BSDetails.Count = 0 Then
                XtraMessageBox.Show("Please Enter WorkOrder Items", "Info")
            Else
                BS.Current!ModifiedBy = CurrentUserName
                BS.EndEdit()
                DA.Update(DS.Tables("WorkOrder"))
                If Status = 0 Then
                    Dim NewCMD As New OleDbCommand("SELECT MAX(WorkOrderID) FROM WorkOrder", ConStr)
                    CnnOpen() : Dim CurrentID = Val(NewCMD.ExecuteScalar & "") : CnnClose()
                    BSDetails.MoveFirst()
                    CurrentWONo = CurrentID
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim InsertCMD As New OleDbCommand("Insert Into WorkOrderDetail (WorkOrderID,ProductName,Description,HSNACS,UOM,Qty,Rate,Amount,Discount,DiscountVal,TaxableValue,CGSTRate,CGSTAmt,SGSTRate,SGSTAmt,IGSTRate,IGSTAmt,TotalAmount) Values (@WorkOrderID,@ProductName,@Description,@HSNACS,@UOM,@Qty,@Rate,@Amount,@Discount,@DiscountVal,@TaxableValue,@CGSTRate,@CGSTAmt,@SGSTRate,@SGSTAmt,@IGSTRate,@IGSTAmt,@TotalAmount)", ConStr)
                        InsertCMD.Parameters.AddWithValue("@WorkOrderID", CurrentID)
                        InsertCMD.Parameters.AddWithValue("@ProductName", BSDetails.Current!ProductName)
                        InsertCMD.Parameters.AddWithValue("@Description", BSDetails.Current!Description)
                        InsertCMD.Parameters.AddWithValue("@HSNACS", BSDetails.Current!HSNACS)
                        InsertCMD.Parameters.AddWithValue("@UOM", BSDetails.Current!UOM)
                        InsertCMD.Parameters.AddWithValue("@Qty", BSDetails.Current!Qty)
                        InsertCMD.Parameters.AddWithValue("@Rate", BSDetails.Current!Rate)
                        InsertCMD.Parameters.AddWithValue("@Amount", BSDetails.Current!Amount)
                        InsertCMD.Parameters.AddWithValue("@Discount", BSDetails.Current!Discount)
                        InsertCMD.Parameters.AddWithValue("@DiscountVal", BSDetails.Current!DiscountVal)
                        InsertCMD.Parameters.AddWithValue("@TaxableValue", BSDetails.Current!TaxableValue)
                        InsertCMD.Parameters.AddWithValue("@CGSTRate", BSDetails.Current!CGSTRate)
                        InsertCMD.Parameters.AddWithValue("@CGSTAmt", BSDetails.Current!CGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@SGSTRate", BSDetails.Current!SGSTRate)
                        InsertCMD.Parameters.AddWithValue("@SGSTAmt", BSDetails.Current!SGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@IGSTRate", BSDetails.Current!IGSTRate)
                        InsertCMD.Parameters.AddWithValue("@IGSTAmt", BSDetails.Current!IGSTAmt)
                        InsertCMD.Parameters.AddWithValue("@TotalAmount", BSDetails.Current!TotalAmount)

                        CnnOpen() : InsertCMD.ExecuteNonQuery() : CnnClose()

                        BSDetails.MoveNext()
                    Next
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                    'Dim myString As String = invoiceCount
                    'Dim countOfZeros As String = ""
                    'For Each c As Char In myString
                    '    If c = "0"c Then
                    '        countOfZeros += "0"
                    '    Else
                    '        Exit For
                    '    End If
                    'Next

                    'Dim X As Integer = CInt(myString) + 1
                    'Dim reCount As String = countOfZeros + X.ToString

                    ''Dim CmpCmd As New OleDbCommand("Update FinancialSettings Set SalesInvoiceCount=@SalesInvoiceCount Where Company ='" + PubCompanyName + "'", ConStr)
                    ''CmpCmd.Parameters.AddWithValue("@SalesInvoiceCount", reCount)
                    ''CnnOpen()
                    ''CmpCmd.ExecuteNonQuery()
                    'CnnClose()

                ElseIf Status = 1 Then
                    BSDetails.EndEdit()
                    DADetails.Update(DS.Tables("WorkOrderDetail"))
                    For item As Integer = 0 To BSDetails.Count - 1
                        Dim rowView As DataRowView = BSDetails(item)
                        If Not rowView("Discount") Is DBNull.Value Then
                            Dim discount As Integer = Convert.ToInt32(rowView("Discount")) ' Assuming Discount is an Integer, adjust type accordingly
                            If discount > 0 Then
                                IsDis = True
                                Exit For
                            Else
                                IsDis = False
                            End If
                        End If
                    Next
                End If
                XtraMessageBox.Show("WorkOrder Saved Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AddNew()
                SetCurrentData()
            End If
        End If
    End Sub
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub WorkOrderDetailGridControl_Leave(sender As Object, e As EventArgs) Handles WorkOrderDetailGridControl.Leave
        BS.Current!TotalAmtBeforeTax = InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue

        BS.Current!CGST = InvoiceDetailGridView.Columns("CGSTAmt").SummaryItem.SummaryValue
        BS.Current!SGST = InvoiceDetailGridView.Columns("SGSTAmt").SummaryItem.SummaryValue
        BS.Current!IGST = InvoiceDetailGridView.Columns("IGSTAmt").SummaryItem.SummaryValue

        BS.Current!TotalGSTTax = BS.Current!CGST + BS.Current!SGST + BS.Current!IGST
        BS.Current!TotalAmtAfterTax = InvoiceDetailGridView.Columns("TotalAmount").SummaryItem.SummaryValue
        BS.EndEdit()
        Calc()
    End Sub

    Private Sub InvoiceDetailGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles InvoiceDetailGridView.CellValueChanged
        Try
            If e.Column.FieldName = "Rate" Or e.Column.FieldName = "Qty" Or e.Column.FieldName = "Discount" Or e.Column.FieldName = "DiscountVal" Or e.Column.FieldName = "CGSTRate" Or e.Column.FieldName = "SGSTRate" Or e.Column.FieldName = "IGSTRate" Then
                Dim qty As Double = IIf(BSDetails.Current!Qty Is DBNull.Value, 0, BSDetails.Current!Qty)
                BSDetails.Current!Qty = Math.Round(qty, 2)

                BSDetails.Current!Amount = IIf(BSDetails.Current!Rate Is DBNull.Value, 0, BSDetails.Current!Rate) * IIf(BSDetails.Current!Qty Is DBNull.Value, 0, BSDetails.Current!Qty)

                If e.Column.FieldName = "Rate" Or e.Column.FieldName = "Qty" Or e.Column.FieldName = "Discount" Or e.Column.FieldName = "CGSTRate" Or e.Column.FieldName = "SGSTRate" Or e.Column.FieldName = "IGSTRate" Then
                    Dim Amt As Double = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) * IIf(BSDetails.Current!Discount Is DBNull.Value, 0, BSDetails.Current!Discount) / 100
                    BSDetails.Current!TaxableValue = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) - Amt
                    BSDetails.Current!DiscountVal = Math.Round(Amt, 2)
                    'New change for cal dis
                    BSDetails.Current!Discount = IIf(BSDetails.Current!Discount Is DBNull.Value, 0, BSDetails.Current!Discount)
                End If

                If e.Column.FieldName = "DiscountVal" Then
                    Dim Dis As Double = IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal) / IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) * 100
                    BSDetails.Current!TaxableValue = IIf(BSDetails.Current!Amount Is DBNull.Value, 0, BSDetails.Current!Amount) - IIf(BSDetails.Current!DiscountVal Is DBNull.Value, 0, BSDetails.Current!DiscountVal)
                    BSDetails.Current!Discount = Math.Round(Dis, 2)
                End If

                BSDetails.Current!CGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!CGSTRate Is DBNull.Value, 0, BSDetails.Current!CGSTRate) / 100
                BSDetails.Current!SGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!SGSTRate Is DBNull.Value, 0, BSDetails.Current!SGSTRate) / 100
                BSDetails.Current!IGSTAmt = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) * IIf(BSDetails.Current!IGSTRate Is DBNull.Value, 0, BSDetails.Current!IGSTRate) / 100

                BSDetails.Current!TotalAmount = IIf(BSDetails.Current!TaxableValue Is DBNull.Value, 0, BSDetails.Current!TaxableValue) + IIf(BSDetails.Current!CGSTAmt Is DBNull.Value, 0, BSDetails.Current!CGSTAmt) + IIf(BSDetails.Current!SGSTAmt Is DBNull.Value, 0, BSDetails.Current!SGSTAmt) + IIf(BSDetails.Current!IGSTAmt Is DBNull.Value, 0, BSDetails.Current!IGSTAmt)
                BSDetails.EndEdit()
            End If

            If e.Column.FieldName = "ProductName" Then
                Dim Pname As String
                Pname = DirectCast(BSDetails.Current, DataRowView).Item("ProductName").ToString

                Dim sda As New OleDbDataAdapter("Select UOM, HSNNoOrSACNo, Price, ProductName From POProduct Where ProductName='" + Pname + "'", ConStr)
                Dim dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count > 0 Then
                    BSDetails.Current!UOM = dt.Rows(0).Item("UOM").ToString
                    BSDetails.Current!HSNACS = dt.Rows(0).Item("HSNNoOrSACNo").ToString
                    BSDetails.Current!Rate = dt.Rows(0).Item("Price").ToString
                    BSDetails.Current!ProductName = dt.Rows(0).Item("ProductName").ToString
                End If
                BSDetails.EndEdit()
            End If
        Catch ex As Exception
            'ErtOccur(ex)
        End Try
    End Sub

    Private Sub InvoiceDetailGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles InvoiceDetailGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            BSDetails.RemoveCurrent()
            BSDetails.EndEdit()
        End If
    End Sub

    Private Sub InvoiceDetailGridView_LostFocus(sender As Object, e As EventArgs) Handles InvoiceDetailGridView.LostFocus
        Try
            BS.Current!GrandTotalAmount = Math.Round((IIf(BS.Current!TotalAmtAfterTax Is DBNull.Value, 0, BS.Current!TotalAmtAfterTax))) ' + IIf(BS.Current!IntAmt Is DBNull.Value, 0, BS.Current!IntAmt)))
            BS.EndEdit()
            Calc()
            Dim bz As New CultureInfo("hi-In")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            NetAmtLabelControl.Text = "Grand Amt: " + GTotal.ToString("c", bz)

        Catch ex As Exception
            'ErtOccur(ex)
        End Try
    End Sub



    Dim ciUSA As CultureInfo = New CultureInfo("hi-IN")

    Private Sub InvoiceDetailGridView_CustomColumnDisplayText(ByVal sender As Object, ByVal e As CustomColumnDisplayTextEventArgs) Handles InvoiceDetailGridView.CustomColumnDisplayText
        Try
            Dim view As ColumnView = TryCast(sender, ColumnView)
            If e.Column.FieldName = "Rate" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim Rate As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", Rate)
            End If
            If e.Column.FieldName = "Amount" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim Amt As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", Amt)
            End If
            If e.Column.FieldName = "TaxableValue" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim TV As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", TV)
            End If
            If e.Column.FieldName = "CGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim CGST As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", CGST)
            End If
            If e.Column.FieldName = "SGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim SGST As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", SGST)
            End If
            If e.Column.FieldName = "IGSTAmt" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim IGST As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", IGST)
            End If
            If e.Column.FieldName = "TotalAmount" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
                Dim TAmt As Decimal = Convert.ToDecimal(e.Value)
                e.DisplayText = String.Format(ciUSA, "{0:c}", TAmt)
            End If
        Catch
        End Try
    End Sub


    'Private Sub PCGSTRateTextEdit_LostFocus(sender As Object, e As EventArgs)
    '    BS.EndEdit()
    '    Calc()
    'End Sub


    Private Sub Calc()
        Try
            BS.Current!TotalAmtBeforeTax = Math.Round(IIf(InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue Is DBNull.Value, 0, InvoiceDetailGridView.Columns("TaxableValue").SummaryItem.SummaryValue), 2)

            'BS.Current!PCGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PCGSTRate Is DBNull.Value, 0, BS.Current!PCGSTRate) / 100
            'BS.Current!PSGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PSGSTRate Is DBNull.Value, 0, BS.Current!PSGSTRate) / 100
            'BS.Current!PIGSTAmt = IIf(BS.Current!PackingCharge Is DBNull.Value, 0, BS.Current!PackingCharge) * IIf(BS.Current!PIGSTRate Is DBNull.Value, 0, BS.Current!PIGSTRate) / 100

            BS.Current!CGST = Math.Round(InvoiceDetailGridView.Columns("CGSTAmt").SummaryItem.SummaryValue, 2)
            BS.Current!SGST = Math.Round(InvoiceDetailGridView.Columns("SGSTAmt").SummaryItem.SummaryValue, 2)
            BS.Current!IGST = Math.Round(InvoiceDetailGridView.Columns("IGSTAmt").SummaryItem.SummaryValue, 2)

            BS.Current!TotalGSTTax = Math.Round(BS.Current!CGST + BS.Current!SGST + BS.Current!IGST, 2)
            BS.Current!TotalAmtAfterTax = Math.Round(BS.Current!TotalAmtBeforeTax + BS.Current!TotalGSTTax, 2)

            BS.Current!GrandTotalAmount = Math.Round(BS.Current!TotalAmtAfterTax)

            BS.Current!RoundOff = BS.Current!GrandTotalAmount - BS.Current!TotalAmtAfterTax


            Dim bz As New CultureInfo("hi-IN")
            Dim GTotal As Double = BS.Current!GrandTotalAmount
            Dim TotalTax As Double = BS.Current!TotalGSTTax
            NetAmtLabelControl.Text = "Grand Amt: " + GTotal.ToString("c", bz)

            'BS.Current!TotalInWords = AmtInWord(Convert.ToDecimal(GTotal.ToString("c", bz).Remove(0, 1)))
            'BS.Current!TaxInWords = AmtInWord(Convert.ToDecimal(TotalTax.ToString("c", bz).Remove(0, 1)))
            BS.Current!TotalInWords = AmtInWord(Convert.ToDecimal(GTotal))
            BS.Current!TaxInWords = AmtInWord(Convert.ToDecimal(TotalTax))

            BS.EndEdit()
        Catch

        End Try

    End Sub


    'Public Flag As Integer



    Private Sub PrintBarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintOriginalPrintBarButtonItem.ItemClick
        'SimpleButton1.PerformClick()
        Dim DACompany As New OleDbDataAdapter
        Dim DTCompany As New DataTable
        Dim WONo As String = BS.Current!WorkOrderID

        DACompany.SelectCommand = New OleDbCommand("Select CompanyID,Name,Address,Phone1,State,StateCode,EmailID1,Website,GSTIN,PANNo From Company Where Name='" + PubCompanyName + "'", ConStr)
        DACompany.Fill(DTCompany)
        'Flag = 1
        'Dim Bank As New Frm_SelectPOBank(PONo, Flag, PubIGST, PubPOType)
        'Bank.StartPosition = FormStartPosition.CenterScreen
        'Bank.ShowDialog()
        If PubIGST = False Then
            If IsDis = True Then
                Dim Rpt As New XR_WorkOrder
                Rpt.WO.Value = WONo
                Rpt.WO.Visible = False
                Rpt.FillDataSource()
                'Rpt.XrLabel76.Text = "✔"
                'Company Info----
                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("ISOText").ToString

                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Work Order -")
                End_Waiting()

                Rpt.ShowRibbonPreviewDialog()
            Else
                Dim Rpt As New XR_WorkOrderWithoutDis
                Rpt.WO.Value = WONo
                Rpt.WO.Visible = False
                Rpt.FillDataSource()
                'Rpt.XrLabel76.Text = "✔"
                'Company Info----
                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("ISOText").ToString

                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Work Order -")
                End_Waiting()

                Rpt.ShowRibbonPreviewDialog()
            End If
        Else
            If IsDis = True Then
                Dim Rpt As New XR_WorkOrderIGST
                Rpt.WO.Value = WONo
                Rpt.WO.Visible = False
                Rpt.FillDataSource()
                'Rpt.XrLabel76.Text = "✔"
                'Company Info----
                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("ISOText").ToString

                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Work Order -")
                End_Waiting()

                Rpt.ShowRibbonPreviewDialog()
            Else
                Dim Rpt As New XR_WorkOrderIGSTWithoutDis
                Rpt.WO.Value = WONo
                Rpt.WO.Visible = False
                Rpt.FillDataSource()
                'Rpt.XrLabel76.Text = "✔"
                'Company Info----
                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("ISOText").ToString

                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Work Order -")
                End_Waiting()

                Rpt.ShowRibbonPreviewDialog()
            End If

        End If
    End Sub

    Private Sub PrintOriginalSignBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintOriginalSignBarButtonItem.ItemClick
        Dim DACompany As New OleDbDataAdapter
        Dim DTCompany As New DataTable
        Dim WONo As String = BS.Current!WorkOrderID

        DACompany.SelectCommand = New OleDbCommand("Select CompanyID,Name,Address,Phone1,State,StateCode,EmailID1,Website,GSTIN,PANNo From Company Where Name='" + PubCompanyName + "'", ConStr)
        DACompany.Fill(DTCompany)
        'Flag = 1
        'Dim Bank As New Frm_SelectPOBank(PONo, Flag, PubIGST, PubPOType)
        'Bank.StartPosition = FormStartPosition.CenterScreen
        'Bank.ShowDialog()
        If PubIGST = False Then
            If IsDis = True Then
                Dim Rpt As New XR_WorkOrder
                Rpt.WO.Value = WONo
                Rpt.WO.Visible = False
                Rpt.FillDataSource()
                'Rpt.XrLabel76.Text = "✔"
                'Company Info----
                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("ISOText").ToString
                Rpt.XrPictureBox2.Visible = True
                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Work Order -")
                End_Waiting()

                Rpt.ShowRibbonPreviewDialog()
            Else
                Dim Rpt As New XR_WorkOrderWithoutDis
                Rpt.WO.Value = WONo
                Rpt.WO.Visible = False
                Rpt.FillDataSource()
                'Rpt.XrLabel76.Text = "✔"
                'Company Info----
                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("ISOText").ToString
                Rpt.XrPictureBox2.Visible = True
                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Work Order -")
                End_Waiting()

                Rpt.ShowRibbonPreviewDialog()
            End If
        Else
            If IsDis = True Then
                Dim Rpt As New XR_WorkOrderIGST
                Rpt.WO.Value = WONo
                Rpt.WO.Visible = False
                Rpt.FillDataSource()
                'Rpt.XrLabel76.Text = "✔"
                'Company Info----
                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("ISOText").ToString
                Rpt.XrPictureBox2.Visible = True
                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Work Order -")
                End_Waiting()

                Rpt.ShowRibbonPreviewDialog()
            Else
                Dim Rpt As New XR_WorkOrderIGSTWithoutDis
                Rpt.WO.Value = WONo
                Rpt.WO.Visible = False
                Rpt.FillDataSource()
                'Rpt.XrLabel76.Text = "✔"
                'Company Info----
                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("ISOText").ToString
                Rpt.XrPictureBox2.Visible = True
                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Work Order -")
                End_Waiting()

                Rpt.ShowRibbonPreviewDialog()
            End If
        End If
    End Sub
    Private Sub ConsignorNameComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConsignorNameComboBoxEdit.SelectedIndexChanged

        Dim sda As New OleDbDataAdapter("Select Address,State,StateCode,GSTIN,PANNo From Vendor Where VendorName='" + ConsignorNameComboBoxEdit.Text + "'", ConStr)
        Dim dt As New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            ConsignorAddressTextEdit.Text = dt.Rows(0).Item("Address").ToString
            ConsignorStateTextEdit.Text = dt.Rows(0).Item("State").ToString
            ConsignorStateCodeTextEdit.Text = dt.Rows(0).Item("StateCode").ToString
            ConsignorGSTINTextEdit.Text = dt.Rows(0).Item("GSTIN").ToString
            ConsignorPANNoTextEdit.Text = dt.Rows(0).Item("PANNo").ToString
        End If
    End Sub

    Private Sub AddNewProduct_Click(sender As Object, e As EventArgs) Handles AddNewProductSimpleButton.Click
        Frm_AddPOProduct.StartPosition = FormStartPosition.CenterParent
        Frm_AddPOProduct.ShowDialog()
        If Frm_AddPOProduct.DialogResult = DialogResult.OK Then
            GridComboBoxFunc("Select DISTINCT ProductName FROM POProduct", "POProduct", WorkOrderDetailGridControl, InvoiceDetailGridView, "ProductName", "POProduct")
            Frm_AddPOProduct.Close()
        Else
            Frm_AddPOProduct.Close()
        End If
    End Sub
    Private Sub InvoiceDetailGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles InvoiceDetailGridView.InitNewRow
        BSDetails.EndEdit()
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub RemarksTextEdit_Leave(sender As Object, e As EventArgs) Handles RemarksTextEdit.Leave
        If RemarksTextEdit.EditValue IsNot DBNull.Value Then
            If RemarksTextEdit.Text.Length > 111 Then
                XtraMessageBox.Show("You can enter upto 110 characters.", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RemarksTextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub ConsignorPANNoTextEdit_Leave(sender As Object, e As EventArgs) Handles ConsignorPANNoTextEdit.Leave
        If ConsignorPANNoTextEdit.EditValue IsNot DBNull.Value Then
            If ConsignorPANNoTextEdit.Text.Length <> 10 Then
                XtraMessageBox.Show("Please Enter Valid 10 Character PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ConsignorPANNoTextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub AddNewVendorSimpleButton_Click(sender As Object, e As EventArgs) Handles AddNewVendorSimpleButton.Click
        Frm_AddVendor.StartPosition = FormStartPosition.CenterParent
        Frm_AddVendor.ShowDialog()
        If Frm_AddVendor.DialogResult = DialogResult.OK Then
            InitLookup()
            Frm_AddVendor.Close()
        Else
            Frm_AddVendor.Close()
        End If
    End Sub

    Private Sub ConsignorNameComboBoxEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ConsignorNameComboBoxEdit.KeyPress
        InitLookup()
    End Sub

    Private Sub POTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WOTextEdit.Validating

        If Not WOTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(WorkOrderID) FROM WorkOrder WHERE WO=@WO AND WorkOrderID<>@WorkOrderID", ConStr)
                CMD.Parameters.AddWithValue("@wO", WOTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@WorkOrderID", IIf(BS.Current!WorkOrderID Is DBNull.Value, -1, BS.Current!WorkOrderID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    WOTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub
    Dim iNumber As Integer
    Private Sub PaymentDaysTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PaymentDaysTextEdit.Validating
        If PaymentDaysTextEdit IsNot DBNull.Value Then
            If Not Integer.TryParse(PaymentDaysTextEdit.Text, iNumber) Then
                XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PaymentDaysTextEdit.Text = ""
            End If
        End If
    End Sub

    Private Sub WODateDateEdit_Leave(sender As Object, e As EventArgs) Handles WODateDateEdit.Leave
        Dim DAFinance As New OleDbDataAdapter("Select StartDate,EndDate From Company Where name ='" + PubCompanyName + "'", ConStr)
        Dim DTFinance As New DataTable
        DAFinance.Fill(DTFinance)
        Dim iDate As String = WODateDateEdit.Text
        Dim oDate As DateTime = Convert.ToDateTime(iDate)

        Dim StartDate As String = DTFinance.Rows(0).Item("StartDate").ToString()
        Dim SubStart As DateTime = Convert.ToDateTime(StartDate.Substring(0, 9))
        Dim EndDate As String = DTFinance.Rows(0).Item("EndDate").ToString()
        Dim SubEnd As DateTime = Convert.ToDateTime(EndDate.Substring(0, 9))

        If iDate >= SubStart And iDate <= SubEnd Then
        Else
            XtraMessageBox.Show("Date is out of Range! Please Enter a Valid Date or check your Financial Period.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox("Not between")
            WODateDateEdit.Focus()
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each filePath As String In OpenFileDialog1.FileNames
            If File.Exists(filePath) Then
                Dim fileName As String = Path.GetFileName(filePath)
                lblAttachment.Text += fileName + Environment.NewLine
            End If
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SendEmailSimpleButton_Click(sender As Object, e As EventArgs) Handles SendEmailSimpleButton.Click
        Dim DAParty As New OleDbDataAdapter("Select Email From Party Where PartyName ='" + ConsignorNameComboBoxEdit.Text + "'", ConStr)
        Dim DTParty As New DataTable
        DAParty.Fill(DTParty)
        Dim partyEmail As String = DTParty.Rows(0).Item("Email").ToString()
        If DTParty.Rows(0).Item("Email") IsNot DBNull.Value Then
            partyEmail = DTParty.Rows(0).Item("Email").ToString()
            'Dim DACompany As New OleDbDataAdapter("Select EmailID1 From Company Where Name ='" + PubCompanyName + "'", ConStr)
            'Dim DTCompany As New DataTable
            'DACompany.Fill(DTCompany)

            'Dim fromEmail As String = DTCompany.Rows(0).Item("EmailID1").ToString


            Dim oMail As New SmtpMail("TryIt")
            oMail.From = ConfigurationManager.AppSettings("Username")
            oMail.To = partyEmail
            oMail.Subject = "WorkOrder Copy"
            oMail.TextBody = " Hi Team
                                Please find attachment of WorkOrder copy for your reference.
                                Let me know if you have any query.
                                Regards,
                                For, Preevol Technics
                                MS Brahmbhatt
                                Mob. 93270 11740"
            For Each filePath As String In OpenFileDialog1.FileNames
                If File.Exists(filePath) Then
                    Dim fileName As String = Path.GetFileName(filePath)
                    oMail.AddAttachment(filePath)
                End If
            Next
            Dim oServer As New SmtpServer("smtp.mail.yahoo.com")
            oServer.User = ConfigurationManager.AppSettings("Username")
            oServer.Password = ConfigurationManager.AppSettings("Password")
            oServer.Port = 465
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto
            'Console.WriteLine("start to send email over SSL ...")
            Dim oSmtp As New SmtpClient()

            Try
                oSmtp.SendMail(oServer, oMail)
                MsgBox("Email was sent successfully!")
                Threading.Thread.Sleep(3000)
            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try
        Else
            XtraMessageBox.Show("Please enter party's email to send email", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub CloseBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CloseBarButtonItem.ItemClick
        Me.Close()
    End Sub
End Class

