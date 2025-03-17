Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_Company
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()
        InitLookup()
        AddNew()
        CompanyNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Sub SetDataTable()
        DS.Tables.Add("Company")
        With DS.Tables("Company").Columns
            .Add("CompanyID", GetType(Integer))
            .Add("Name", GetType(String))
            .Add("Address", GetType(String))
            .Add("Phone1", GetType(String))
            .Add("Phone2", GetType(String))
            .Add("State", GetType(String))
            .Add("StateCode", GetType(Integer))
            .Add("EmailID1", GetType(String))
            .Add("EmailID2", GetType(String))
            .Add("Website", GetType(String))
            .Add("GSTIN", GetType(String))
            .Add("PANNo", GetType(String))
            .Add("VATNo", GetType(Integer))
            .Add("CSTNo", GetType(Integer))
            .Add("ECCNo", GetType(String))
            .Add("IECCode", GetType(String))
            .Add("SupplyFrom", GetType(String))
            .Add("FinancialYear", GetType(String))
            .Add("StartDate", GetType(Date))
            .Add("EndDate", GetType(Date))
            .Add("SalesInvoiceStarts", GetType(String))
            .Add("ServiceInvoiceStarts", GetType(String))
            .Add("ProformaSalesInvoiceStarts", GetType(String))
            .Add("ProformaServiceInvoiceStarts", GetType(String))
            .Add("SalesInvoicePrefix", GetType(String))
            .Add("ServiceInvoicePrefix", GetType(String))
            .Add("ProformaSalesInvoicePrefix", GetType(String))
            .Add("ProformaServiceInvoicePrefix", GetType(String))
            .Add("QuotationStarts", GetType(String))
            .Add("QuotationPrefix", GetType(String))
            .Add("ISOText", GetType(String))
            .Add("Loc", GetType(String))
            .Add("Pin", GetType(Integer))
        End With

        With DS.Tables("Company").Columns("CompanyID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetQuery()
        DA.SelectCommand = New OleDbCommand("Select CompanyID,Name,Address,Phone1,Phone2,State,StateCode,EmailID1,EmailID2,Website,GSTIN,PANNo,VATNo,CSTNo,ECCNo,IECCode,SupplyFrom,FinancialYear,StartDate,EndDate,SalesInvoiceStarts,ServiceInvoiceStarts,ProformaSalesInvoiceStarts,ProformaServiceInvoiceStarts,SalesInvoicePrefix,ServiceInvoicePrefix,ProformaSalesInvoicePrefix,ProformaServiceInvoicePrefix,QuotationStarts,QuotationPrefix,ISOText,Loc,Pin From Company Where CompanyID=@CompanyID", ConStr)
        DA.SelectCommand.Parameters.Add("@CompanyID", OleDbType.Integer, 4, "CompanyID")

        DA.InsertCommand = New OleDbCommand("Insert Into Company (Name,Address,Phone1,Phone2,State,StateCode,EmailID1,EmailID2,Website,GSTIN,PANNo,VATNo,CSTNo,ECCNo,IECCode,SupplyFrom,FinancialYear,StartDate,EndDate,SalesInvoiceStarts,ServiceInvoiceStarts,ProformaSalesInvoiceStarts,ProformaServiceInvoiceStarts,SalesInvoicePrefix,ServiceInvoicePrefix,ProformaSalesInvoicePrefix,ProformaServiceInvoicePrefix,QuotationStarts,QuotationPrefix,ISOText,Loc,Pin) Values (@Name,@Address,@Phone1,@Phone2,@State,@StateCode,@EmailID1,@EmailID2,@Website,@GSTIN,@PANNo,@VATNo,@CSTNo,@ECCNo,@IECCode,@SupplyFrom,@FinancialYear,@StartDate,@EndDate,@SalesInvoiceStarts,@ServiceInvoiceStarts,@ProformaSalesInvoiceStarts,@ProformaServiceInvoiceStarts,@SalesInvoicePrefix,@ServiceInvoicePrefix,@ProformaSalesInvoicePrefix,@ProformaServiceInvoicePrefix,@QuotationStarts,@QuotationPrefix,@ISOText,@Loc,@Pin)", ConStr)
        DA.InsertCommand.Parameters.Add("@Name", OleDbType.VarChar, 50, "Name")
        DA.InsertCommand.Parameters.Add("@Address", OleDbType.VarChar, 250, "Address")
        DA.InsertCommand.Parameters.Add("@Phone1", OleDbType.VarChar, 50, "Phone1")
        DA.InsertCommand.Parameters.Add("@Phone2", OleDbType.VarChar, 50, "Phone2")
        DA.InsertCommand.Parameters.Add("@State", OleDbType.VarChar, 100, "State")
        DA.InsertCommand.Parameters.Add("@StateCode", OleDbType.Integer, 4, "StateCode")
        DA.InsertCommand.Parameters.Add("@EmailID1", OleDbType.VarChar, 150, "EmailID1")
        DA.InsertCommand.Parameters.Add("@EmailID2", OleDbType.VarChar, 150, "EmailID2")
        DA.InsertCommand.Parameters.Add("@Website", OleDbType.VarChar, 150, "Website")
        DA.InsertCommand.Parameters.Add("@GSTIN", OleDbType.VarChar, 50, "GSTIN")
        DA.InsertCommand.Parameters.Add("@PANNo", OleDbType.VarChar, 50, "PANNo")
        DA.InsertCommand.Parameters.Add("@VATNo", OleDbType.Integer, 4, "VATNo")
        DA.InsertCommand.Parameters.Add("@CSTNo", OleDbType.Integer, 4, "CSTNo")
        DA.InsertCommand.Parameters.Add("@ECCNo", OleDbType.VarChar, 50, "ECCNo")
        DA.InsertCommand.Parameters.Add("@IECCode", OleDbType.VarChar, 50, "IECCode")
        DA.InsertCommand.Parameters.Add("@SupplyFrom", OleDbType.VarChar, 50, "SupplyFrom")
        DA.InsertCommand.Parameters.Add("@FinancialYear", OleDbType.VarChar, 10, "FinancialYear")
        DA.InsertCommand.Parameters.Add("@StartDate", OleDbType.Date, 3, "StartDate")
        DA.InsertCommand.Parameters.Add("@EndDate", OleDbType.Date, 3, "EndDate")
        DA.InsertCommand.Parameters.Add("@SalesInvoiceStarts", OleDbType.VarChar, 10, "SalesInvoiceStarts")
        DA.InsertCommand.Parameters.Add("@ServiceInvoiceStarts", OleDbType.VarChar, 10, "ServiceInvoiceStarts")
        DA.InsertCommand.Parameters.Add("@ProformaSalesInvoiceStarts", OleDbType.VarChar, 10, "ProformaSalesInvoiceStarts")
        DA.InsertCommand.Parameters.Add("@ProformaServiceInvoiceStarts", OleDbType.VarChar, 10, "ProformaServiceInvoiceStarts")
        DA.InsertCommand.Parameters.Add("@SalesInvoicePrefix", OleDbType.VarChar, 20, "SalesInvoicePrefix")
        DA.InsertCommand.Parameters.Add("@ServiceInvoicePrefix", OleDbType.VarChar, 20, "ServiceInvoicePrefix")
        DA.InsertCommand.Parameters.Add("@ProformaSalesInvoicePrefix", OleDbType.VarChar, 20, "ProformaSalesInvoicePrefix")
        DA.InsertCommand.Parameters.Add("@ProformaServiceInvoicePrefix", OleDbType.VarChar, 20, "ProformaServiceInvoicePrefix")
        DA.InsertCommand.Parameters.Add("@QuotationStarts", OleDbType.VarChar, 20, "QuotationStarts")
        DA.InsertCommand.Parameters.Add("@QuotationPrefix", OleDbType.VarChar, 20, "QuotationPrefix")
        DA.InsertCommand.Parameters.Add("@ISOText", OleDbType.VarChar, 50, "ISOText")
        DA.InsertCommand.Parameters.Add("@Loc", OleDbType.VarChar, 50, "Loc")
        DA.InsertCommand.Parameters.Add("@Pin", OleDbType.Integer, 8, "Pin")


        DA.UpdateCommand = New OleDbCommand("Update Company Set Name=@Name,Address=@Address,Phone1=@Phone1,Phone2=@Phone2,State=@State,StateCode=@StateCode,EmailID1=@EmailID1,EmailID2=@EmailID2,Website=@Website,GSTIN=@GSTIN,PANNo=@PANNo,VATNo=@VATNo,CSTNo=@CSTNo,ECCNo=@ECCNo,IECCode=@IECCode,SupplyFrom=@SupplyFrom,FinancialYear=@FinancialYear,StartDate=@StartDate,EndDate=@EndDate,SalesInvoiceStarts=@SalesInvoiceStarts,ServiceInvoiceStarts=@ServiceInvoiceStarts,ProformaSalesInvoiceStarts=@ProformaSalesInvoiceStarts,ProformaServiceInvoiceStarts=@ProformaServiceInvoiceStarts,SalesInvoicePrefix=@SalesInvoicePrefix,ServiceInvoicePrefix=@ServiceInvoicePrefix,ProformaSalesInvoicePrefix=@ProformaSalesInvoicePrefix,ProformaServiceInvoicePrefix=@ProformaServiceInvoicePrefix,QuotationStarts=@QuotationStarts,QuotationPrefix=@QuotationPrefix,ISOText=@ISOText,Loc=@Loc,Pin=@Pin Where CompanyID=@CompanyID", ConStr)
        DA.UpdateCommand.Parameters.Add("@Name", OleDbType.VarChar, 50, "Name")
        DA.UpdateCommand.Parameters.Add("@Address", OleDbType.VarChar, 250, "Address")
        DA.UpdateCommand.Parameters.Add("@Phone1", OleDbType.VarChar, 50, "Phone1")
        DA.UpdateCommand.Parameters.Add("@Phone2", OleDbType.VarChar, 50, "Phone2")
        DA.UpdateCommand.Parameters.Add("@State", OleDbType.VarChar, 100, "State")
        DA.UpdateCommand.Parameters.Add("@StateCode", OleDbType.Integer, 4, "StateCode")
        DA.UpdateCommand.Parameters.Add("@EmailID1", OleDbType.VarChar, 150, "EmailID1")
        DA.UpdateCommand.Parameters.Add("@EmailID2", OleDbType.VarChar, 150, "EmailID2")
        DA.UpdateCommand.Parameters.Add("@Website", OleDbType.VarChar, 150, "Website")
        DA.UpdateCommand.Parameters.Add("@GSTIN", OleDbType.VarChar, 50, "GSTIN")
        DA.UpdateCommand.Parameters.Add("@PANNo", OleDbType.VarChar, 50, "PANNo")
        DA.UpdateCommand.Parameters.Add("@VATNo", OleDbType.Integer, 4, "VATNo")
        DA.UpdateCommand.Parameters.Add("@CSTNo", OleDbType.Integer, 4, "CSTNo")
        DA.UpdateCommand.Parameters.Add("@ECCNo", OleDbType.VarChar, 50, "ECCNo")
        DA.UpdateCommand.Parameters.Add("@IECCode", OleDbType.VarChar, 50, "IECCode")
        DA.UpdateCommand.Parameters.Add("@SupplyFrom", OleDbType.VarChar, 50, "SupplyFrom")
        DA.UpdateCommand.Parameters.Add("@FinancialYear", OleDbType.VarChar, 10, "FinancialYear")
        DA.UpdateCommand.Parameters.Add("@StartDate", OleDbType.Date, 3, "StartDate")
        DA.UpdateCommand.Parameters.Add("@EndDate", OleDbType.Date, 3, "EndDate")
        DA.UpdateCommand.Parameters.Add("@SalesInvoiceStarts", OleDbType.VarChar, 10, "SalesInvoiceStarts")
        DA.UpdateCommand.Parameters.Add("@ServiceInvoiceStarts", OleDbType.VarChar, 10, "ServiceInvoiceStarts")
        DA.UpdateCommand.Parameters.Add("@ProformaSalesInvoiceStarts", OleDbType.VarChar, 10, "ProformaSalesInvoiceStarts")
        DA.UpdateCommand.Parameters.Add("@ProformaServiceInvoiceStarts", OleDbType.VarChar, 10, "ProformaServiceInvoiceStarts")
        DA.UpdateCommand.Parameters.Add("@SalesInvoicePrefix", OleDbType.VarChar, 20, "SalesInvoicePrefix")
        DA.UpdateCommand.Parameters.Add("@ServiceInvoicePrefix", OleDbType.VarChar, 20, "ServiceInvoicePrefix")
        DA.UpdateCommand.Parameters.Add("@ProformaSalesInvoicePrefix", OleDbType.VarChar, 20, "ProformaSalesInvoicePrefix")
        DA.UpdateCommand.Parameters.Add("@ProformaServiceInvoicePrefix", OleDbType.VarChar, 20, "ProformaServiceInvoicePrefix")
        DA.UpdateCommand.Parameters.Add("@QuotationStarts", OleDbType.VarChar, 20, "QuotationStarts")
        DA.UpdateCommand.Parameters.Add("@QuotationPrefix", OleDbType.VarChar, 20, "QuotationPrefix")
        DA.UpdateCommand.Parameters.Add("@ISOText", OleDbType.VarChar, 50, "ISOText")
        DA.UpdateCommand.Parameters.Add("@Loc", OleDbType.VarChar, 50, "Loc")
        DA.UpdateCommand.Parameters.Add("@Pin", OleDbType.Integer, 8, "Pin")
        DA.UpdateCommand.Parameters.Add("@CompanyID", OleDbType.Integer, 4, "CompanyID")


        DA.DeleteCommand = New OleDbCommand("Delete From Company Where CompanyID=@CompanyID", ConStr)
        DA.DeleteCommand.Parameters.Add("@CompanyID", OleDbType.Integer, 4, "CompanyID")
    End Sub

    Sub SetBinding()
        BS.DataSource = DS.Tables("Company")
        CompanyNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Name"))
        AddressMemoEdit.DataBindings.Add(New Binding("EditValue", BS, "Address"))
        PhoneNo1TextEdit.DataBindings.Add(New Binding("EditValue", BS, "Phone1"))
        PhoneNo2TextEdit.DataBindings.Add(New Binding("EditValue", BS, "Phone2"))
        CmpStateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "State"))
        StateCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "StateCode"))
        EmailID1TextEdit.DataBindings.Add(New Binding("EditValue", BS, "EmailID1"))
        EmailID2TextEdit.DataBindings.Add(New Binding("EditValue", BS, "EmailID2"))
        WebsiteTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Website"))
        CmpGSTINTextEdit.DataBindings.Add(New Binding("EditValue", BS, "GSTIN"))
        PANNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PANNo"))
        VATNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "VATNo"))
        CSTNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "CSTNo"))
        ECCNoText.DataBindings.Add(New Binding("EditValue", BS, "ECCNo"))
        IECCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "IECCode"))
        SupplyFromTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SupplyFrom"))
        FinancialYearComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "FinancialYear"))
        StartDateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "StartDate"))
        EndDateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "EndDate"))
        SetSalesInvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SalesInvoiceStarts"))
        SetServiceInvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ServiceInvoiceStarts"))
        SetProformaSalesInvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ProformaSalesInvoiceStarts"))
        SetProformaServiceInvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ProformaServiceInvoiceStarts"))
        SalesPrefixTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SalesInvoicePrefix"))
        ServicePrefixTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ServiceInvoicePrefix"))
        ProformaPrefixTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ProformaSalesInvoicePrefix"))
        ProformaServicePrefixTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ProformaServiceInvoicePrefix"))
        SetQuotationNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "QuotationStarts"))
        QuotationPrefixTextEdit.DataBindings.Add(New Binding("EditValue", BS, "QuotationPrefix"))
        ISOTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ISOText"))
        LocTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Loc"))
        PinTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Pin"))


    End Sub
    Sub InitLookup()
        SetGridCommboBox("SELECT DISTINCT FinancialYear FROM FinancialSettings", "FinancialSettings", FinancialYearComboBoxEdit)
    End Sub
    Sub AddNew()
        BS.AddNew()
        Status = 0
        CompanyNameTextEdit.Focus()
        'SETSimpleButton.Visible = False
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        CompanyNameTextEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From Company", "CompanyID")
        If ID > 0 Then
            Try
                DS.Tables("Company").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@CompanyID").Value = ID
            DA.Fill(DS, "Company")
            Status = 1
            'SETSimpleButton.Visible = True
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("Company"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If CompanyNameTextEdit.EditValue Is DBNull.Value Then
            CompanyNameTextEdit.Focus()
            Return False
        ElseIf PhoneNo1TextEdit.EditValue Is DBNull.Value Then
            PhoneNo1TextEdit.Focus()
            Return False
        ElseIf AddressMemoEdit.EditValue Is DBNull.Value Then
            AddressMemoEdit.Focus()
            Return False
        ElseIf CmpStateTextEdit.EditValue Is DBNull.Value Then
            CmpStateTextEdit.Focus()
            Return False
        ElseIf StateCodeTextEdit.EditValue Is DBNull.Value Then
            StateCodeTextEdit.Focus()
            Return False
        ElseIf EmailID1TextEdit.EditValue Is DBNull.Value Then
            EmailID1TextEdit.Focus()
            Return False
        ElseIf CmpGSTINTextEdit.EditValue Is DBNull.Value Then
            CmpGSTINTextEdit.Focus()
            Return False
        ElseIf PANNoTextEdit.EditValue Is DBNull.Value Then
            PANNoTextEdit.Focus()
            Return False
        ElseIf SupplyFromTextEdit.EditValue Is DBNull.Value Then
            SupplyFromTextEdit.Focus()
            Return False
        ElseIf FinancialYearComboBoxEdit.EditValue Is DBNull.Value Then
            FinancialYearComboBoxEdit.Focus()
            Return False
        ElseIf SetSalesInvoiceNoTextEdit.EditValue Is DBNull.Value Then
            SetSalesInvoiceNoTextEdit.Focus()
            Return False
        ElseIf SetServiceInvoiceNoTextEdit.EditValue Is DBNull.Value Then
            SetServiceInvoiceNoTextEdit.Focus()
            Return False
        ElseIf SetProformaSalesInvoiceNoTextEdit.EditValue Is DBNull.Value Then
            SetProformaSalesInvoiceNoTextEdit.Focus()
            Return False
        ElseIf SetProformaServiceInvoiceNoTextEdit.EditValue Is DBNull.Value Then
            SetProformaServiceInvoiceNoTextEdit.Focus()
            Return False
        ElseIf SalesPrefixTextEdit.EditValue Is DBNull.Value Then
            SalesPrefixTextEdit.Focus()
            Return False
        ElseIf ServicePrefixTextEdit.EditValue Is DBNull.Value Then
            ServicePrefixTextEdit.Focus()
            Return False
        ElseIf ProformaPrefixTextEdit.EditValue Is DBNull.Value Then
            ProformaPrefixTextEdit.Focus()
            Return False
        ElseIf ProformaServicePrefixTextEdit.EditValue Is DBNull.Value Then
            ProformaServicePrefixTextEdit.Focus()
            Return False
        ElseIf SetQuotationNoTextEdit.EditValue Is DBNull.Value Then
            SetQuotationNoTextEdit.Focus()
            Return False
        ElseIf QuotationPrefixTextEdit.EditValue Is DBNull.Value Then
            QuotationPrefixTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.EndEdit()
            DA.Update(DS.Tables("Company"))
            If Status = 0 Then
                'SETFinancial()
            End If
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Function IsValidEmail(value As String) As Boolean
        Dim RE As Object
        RE = CreateObject("vbscript.RegExp")
        RE.Pattern = "^[a-zA-Z0-9\._-]+@([a-zA-Z0-9_-]+\.)+([a-zA-Z]{2,3})$"
        IsValidEmail = RE.Test(value)
        RE = Nothing
    End Function
    Private Sub EmailID1TextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmailID1TextEdit.Validating
        If EmailID1TextEdit.EditValue IsNot DBNull.Value Then
            If Not IsValidEmail(EmailID1TextEdit.Text) Then
                XtraMessageBox.Show("Not an Email! Enter Valid Email Address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmailID1TextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub EmailID2TextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmailID2TextEdit.Validating
        If EmailID2TextEdit.EditValue IsNot DBNull.Value Then
            If Not IsValidEmail(EmailID2TextEdit.Text) Then
                XtraMessageBox.Show("Not an Email! Enter Valid Email Address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmailID1TextEdit.Focus()
            End If
        End If
    End Sub

    'Dim iNumber As Integer
    'Private Sub PhoneNo1TextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PhoneNo1TextEdit.Validating
    '    If PhoneNo1TextEdit.EditValue IsNot DBNull.Value Then
    '        If PhoneNo1TextEdit.Text.Length > 12 Then
    '            If Not Integer.TryParse(PhoneNo1TextEdit.Text, iNumber) Then
    '                XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                PhoneNo1TextEdit.Focus()
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub PhoneNo2TextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PhoneNo2TextEdit.Validating
    '    If PhoneNo2TextEdit.EditValue IsNot DBNull.Value Then
    '        If PhoneNo2TextEdit.Text.Length > 12 Then
    '            If Not Integer.TryParse(PhoneNo2TextEdit.Text, iNumber) Then
    '                XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                PhoneNo2TextEdit.Focus()
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub VATNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VATNoTextEdit.Validating
    '    If VATNoTextEdit.EditValue IsNot DBNull.Value Then
    '        If Not Integer.TryParse(VATNoTextEdit.Text, iNumber) Then
    '            XtraMessageBox.Show("Please enter Numeric VAT No.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            VATNoTextEdit.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub CSTNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CSTNoTextEdit.Validating
    '    If CSTNoTextEdit.EditValue IsNot DBNull.Value Then
    '        If Not Integer.TryParse(CSTNoTextEdit.Text, iNumber) Then
    '            XtraMessageBox.Show("Please enter Numeric CST No.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            CSTNoTextEdit.Focus()
    '        End If
    '    End If
    'End Sub

    Private Sub CmpGSTINTextEdit_Leave(sender As Object, e As EventArgs) Handles CmpGSTINTextEdit.Leave
        If CmpGSTINTextEdit.EditValue IsNot DBNull.Value Then
            If CmpGSTINTextEdit.Text.Length <> 15 Then
                XtraMessageBox.Show("Please Enter Valid 15 Character GSTIN", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CmpGSTINTextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub PANNoTextEdit_Leave(sender As Object, e As EventArgs) Handles PANNoTextEdit.Leave
        If PANNoTextEdit.EditValue IsNot DBNull.Value Then
            If PANNoTextEdit.Text.Length <> 10 Then
                XtraMessageBox.Show("Please Enter Valid 10 Character PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PANNoTextEdit.Focus()
            End If
        End If
    End Sub
    'Private Sub CmpGSTINTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmpGSTINTextEdit.KeyPress
    '    If CmpGSTINTextEdit.EditValue IsNot DBNull.Value Then
    '        If CmpGSTINTextEdit.Text.Length <> 15 Then
    '            XtraMessageBox.Show("Please Enter Valid 15 Character GSTIN", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            CmpGSTINTextEdit.Focus()
    '        End If
    '    End If

    '    If CmpGSTINTextEdit.EditValue IsNot DBNull.Value Then
    '        Dim allowed As String = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
    '        For Each c As Char In CmpGSTINTextEdit.Text
    '            If allowed.Contains(c) = False Then
    '                XtraMessageBox.Show("Please Enter Valid GSTIN", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                CmpGSTINTextEdit.Focus()
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub PANNoTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PANNoTextEdit.KeyPress
    '    If PANNoTextEdit.Text.Length > 10 Then
    '        XtraMessageBox.Show("Please Enter Valid PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        PANNoTextEdit.Focus()
    '    End If
    '    If PANNoTextEdit.EditValue IsNot DBNull.Value Then
    '        Dim allowed As String = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
    '        For Each c As Char In PANNoTextEdit.Text
    '            If allowed.Contains(c) = False Then
    '                XtraMessageBox.Show("Please Enter Valid PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                PANNoTextEdit.Focus()
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub StateCodeTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles StateCodeTextEdit.Validating
    '    If StateCodeTextEdit.EditValue IsNot DBNull.Value Then
    '        If Not Integer.TryParse(StateCodeTextEdit.Text, iNumber) Then
    '            XtraMessageBox.Show("Not a Number! Please enter Valid State Code.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            StateCodeTextEdit.Focus()
    '            'e.Cancel = True
    '        End If
    '    End If
    'End Sub

    Private Sub CompanyNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CompanyNameTextEdit.Validating
        If Not CompanyNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(CompanyID) FROM Company WHERE Name=@Name AND CompanyID<>@CompanyID", ConStr)
                CMD.Parameters.AddWithValue("@Name", CompanyNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@CompanyID", IIf(BS.Current!CompanyID Is DBNull.Value, -1, BS.Current!CompanyID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CompanyNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub

    'Private Sub CmpStateTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmpStateTextEdit.KeyPress
    '    If Not (Asc(e.KeyChar) = 8) Then
    '        If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
    '            e.KeyChar = ChrW(0)
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Function FinancialValidation() As Boolean
    '    If SetSalesInvoiceNoTextEdit.EditValue Is DBNull.Value Then
    '        SetSalesInvoiceNoTextEdit.Focus()
    '        Return False
    '    ElseIf SetServiceInvoiceNoTextEdit.EditValue Is DBNull.Value Then
    '        SetServiceInvoiceNoTextEdit.Focus()
    '        Return False
    '    ElseIf SetFinancialYearTextEdit.EditValue Is DBNull.Value Then
    '        SetFinancialYearTextEdit.Focus()
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

    'Private Sub SETSimpleButton_Click(sender As Object, e As EventArgs) Handles SETSimpleButton.Click
    '    If FinancialValidation() Then
    '        If Status = 1 Then
    '            Dim NewCmd As New OleDbCommand("Update FinancialSettings Set FinancialYear=@FinancialYear,SalesInvoiceCount=@SalesInvoiceCount,ServiceInvoiceCount=@ServiceInvoiceCount Where Company='" + BS.Current!Name + "'", ConStr)
    '            NewCmd.Parameters.AddWithValue("@FinancialYear", BS.Current!FinancialYear)
    '            NewCmd.Parameters.AddWithValue("@SalesInvoiceCount", BS.Current!SalesInvoiceStarts)
    '            NewCmd.Parameters.AddWithValue("@ServiceInvoiceCount", BS.Current!ServiceInvoiceStarts)
    '            CnnOpen()
    '            Dim chk = NewCmd.ExecuteNonQuery()
    '            If chk = 1 Then
    '                XtraMessageBox.Show("Invoice No. and Financial Year Set Successfully", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '            CnnClose()
    '        End If
    '    End If
    'End Sub

    'Sub SETFinancial()
    '    If FinancialValidation() Then
    '        Dim NewCmd As New OleDbCommand("Insert Into FinancialSettings (FinancialYear,SalesInvoiceCount,ServiceInvoiceCount,Company) Values (@FinancialYear,@SalesInvoiceCount,@ServiceInvoiceCount,@Company)", ConStr)
    '        NewCmd.Parameters.AddWithValue("@FinancialYear", BS.Current!FinancialYear)
    '        NewCmd.Parameters.AddWithValue("@SalesInvoiceCount", BS.Current!SalesInvoiceStarts)
    '        NewCmd.Parameters.AddWithValue("@ServiceInvoiceCount", BS.Current!ServiceInvoiceStarts)
    '        NewCmd.Parameters.AddWithValue("@Company", BS.Current!Name)
    '        CnnOpen()
    '        NewCmd.ExecuteNonQuery()
    '        CnnClose()
    '    End If
    'End Sub
    Private Sub FinancialYearComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinancialYearComboBoxEdit.SelectedIndexChanged
        Dim sda As New OleDbDataAdapter("Select StartDate,EndDate,SalesInvoiceCount,ServiceInvoiceCount,ProformaSalesInvoiceCount,ProformaServiceInvoiceCount,QuotationCount From FinancialSettings Where FinancialYear='" + FinancialYearComboBoxEdit.Text + "'", ConStr)
        Dim dt As New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Dim StartDate As String = dt.Rows(0).Item("StartDate").ToString
            Dim SubStart As String = (StartDate.Substring(0, 9))
            StartDateTextEdit.Text = SubStart
            Dim EndDate As String = dt.Rows(0).Item("EndDate").ToString
            Dim SubEnd As String = (EndDate.Substring(0, 9))
            EndDateTextEdit.Text = SubEnd

            SetSalesInvoiceNoTextEdit.Text = dt.Rows(0).Item("SalesInvoiceCount").ToString
            SetServiceInvoiceNoTextEdit.Text = dt.Rows(0).Item("ServiceInvoiceCount").ToString
            SetProformaSalesInvoiceNoTextEdit.Text = dt.Rows(0).Item("ProformaSalesInvoiceCount").ToString
            SetProformaServiceInvoiceNoTextEdit.Text = dt.Rows(0).Item("ProformaServiceInvoiceCount").ToString
            SetQuotationNoTextEdit.Text = dt.Rows(0).Item("QuotationCount").ToString
        End If
    End Sub

    Private Sub AddNewFinancialYearSimpleButton_Click(sender As Object, e As EventArgs) Handles AddNewFinancialYearSimpleButton.Click
        Frm_AddFinancialYear.StartPosition = FormStartPosition.CenterParent
        Frm_AddFinancialYear.ShowDialog()
        If Frm_AddFinancialYear.DialogResult = DialogResult.OK Then
            InitLookup()
            Frm_AddFinancialYear.Close()
        Else
            Frm_AddFinancialYear.Close()
        End If
    End Sub
    Private Sub FinancialYearComboBoxEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FinancialYearComboBoxEdit.KeyPress
        InitLookup()
    End Sub

End Class