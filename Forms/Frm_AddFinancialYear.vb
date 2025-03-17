Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_AddFinancialYear
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()
        AddNew()
        StartDateDateEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
        ' AddressTextEdit.EnterMoveNextControl = False
    End Sub

    Function SetDataTable()
        DS.Tables.Add("FinancialSettings")
        With DS.Tables("FinancialSettings").Columns
            .Add("FinancialYearID", GetType(Integer))
            .Add("StartDate", GetType(Date))
            .Add("EndDate", GetType(Date))
            .Add("FinancialYear", GetType(String))
            .Add("SalesInvoiceCount", GetType(String))
            .Add("ServiceInvoiceCount", GetType(String))
            .Add("ProformaSalesInvoiceCount", GetType(String))
            .Add("ProformaServiceInvoiceCount", GetType(String))
            .Add("QuotationCount", GetType(String))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("FinancialSettings").Columns("FinancialYearID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
        Return True
    End Function

    Function SetQuery()
        'DA.SelectCommand = New OleDbCommand("Select FinancialYearID, StartDate, EndDate, FinancialYear, SalesInvoiceCount, ServiceInvoiceCount, Company From FinancialSettings Where FinancialYearID=@FinancialYearID", ConStr)
        'DA.SelectCommand.Parameters.Add("@FinancialYearID", OleDbType.Integer, 4, "FinancialYearID")

        DA.InsertCommand = New OleDbCommand("Insert Into FinancialSettings  (StartDate, EndDate, FinancialYear, SalesInvoiceCount, ServiceInvoiceCount, ProformaSalesInvoiceCount, ProformaServiceInvoiceCount, QuotationCount, Company) Values (@StartDate, @EndDate, @FinancialYear, @SalesInvoiceCount, @ServiceInvoiceCount, @ProformaSalesInvoiceCount , @ProformaServiceInvoiceCount, @QuotationCount, @Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@StartDate", OleDbType.Date, 3, "StartDate")
        DA.InsertCommand.Parameters.Add("@EndDate", OleDbType.Date, 3, "EndDate")
        DA.InsertCommand.Parameters.Add("@FinancialYear", OleDbType.VarChar, 50, "FinancialYear")
        DA.InsertCommand.Parameters.Add("@SalesInvoiceCount", OleDbType.VarChar, 50, "SalesInvoiceCount")
        DA.InsertCommand.Parameters.Add("@ServiceInvoiceCount", OleDbType.VarChar, 300, "ServiceInvoiceCount")
        DA.InsertCommand.Parameters.Add("@ProformaSalesInvoiceCount", OleDbType.VarChar, 50, "ProformaSalesInvoiceCount")
        DA.InsertCommand.Parameters.Add("@ProformaServiceInvoiceCount", OleDbType.VarChar, 300, "ProformaServiceInvoiceCount")
        DA.InsertCommand.Parameters.Add("@QuotationCount", OleDbType.VarChar, 300, "QuotationCount")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        'DA.UpdateCommand = New OleDbCommand("Update FinancialSettings  Set PartyName=@PartyName,ContactPerson=@ContactPerson,Contact1=@Contact1,Contact2=@Contact2,Address=@Address,City=@City,State=@State,StateCode=@StateCode,Email=@Email,Website=@Website,GSTStatus=@GSTStatus,GSTIN=@GSTIN,PANNo=@PANNo,VATNo=@VATNo,CSTNO=@CSTNO,ECCNo=@ECCNo,IECCode=@IECCode Where PartyID=@PartyID", ConStr)
        'DA.UpdateCommand.Parameters.Add("@PartyName", OleDbType.VarChar, 80, "PartyName")
        'DA.UpdateCommand.Parameters.Add("@ContactPerson", OleDbType.VarChar, 80, "ContactPerson")
        'DA.UpdateCommand.Parameters.Add("@Contact1", OleDbType.VarChar, 50, "Contact1")
        'DA.UpdateCommand.Parameters.Add("@Contact2", OleDbType.VarChar, 50, "Contact2")
        'DA.UpdateCommand.Parameters.Add("@Address", OleDbType.VarChar, 300, "Address")
        'DA.UpdateCommand.Parameters.Add("@City", OleDbType.VarChar, 150, "City")
        'DA.UpdateCommand.Parameters.Add("@State", OleDbType.VarChar, 150, "State")
        'DA.UpdateCommand.Parameters.Add("@StateCode", OleDbType.Integer, 4, "StateCode")
        'DA.UpdateCommand.Parameters.Add("@Email", OleDbType.VarChar, 100, "Email")
        'DA.UpdateCommand.Parameters.Add("@Website", OleDbType.VarChar, 100, "Website")
        'DA.UpdateCommand.Parameters.Add("@GSTStatus", OleDbType.VarChar, 50, "GSTStatus")
        'DA.UpdateCommand.Parameters.Add("@GSTIN", OleDbType.VarChar, 25, "GSTIN")
        'DA.UpdateCommand.Parameters.Add("@PANNo", OleDbType.VarChar, 25, "PANNo")
        'DA.UpdateCommand.Parameters.Add("@VATNo", OleDbType.Integer, 20, "VATNo")
        'DA.UpdateCommand.Parameters.Add("@CSTNO", OleDbType.Integer, 20, "CSTNO")
        'DA.UpdateCommand.Parameters.Add("@ECCNO", OleDbType.VarChar, 25, "ECCNO")
        'DA.UpdateCommand.Parameters.Add("@IECCode", OleDbType.VarChar, 25, "IECCode")
        'DA.UpdateCommand.Parameters.Add("@PartyID", OleDbType.Integer, 4, "PartyID")

        'DA.DeleteCommand = New OleDbCommand("Delete From Party Where PartyID=@PartyID", ConStr)
        'DA.DeleteCommand.Parameters.Add("@PartyID", OleDbType.Integer, 4, "PartyID")
        Return True
    End Function

    Function SetBinding()
        BS.DataSource = DS.Tables("FinancialSettings")
        StartDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "StartDate"))
        EndDateDateEdit.DataBindings.Add(New Binding("EditValue", BS, "EndDate"))
        FinancialYearTextEdit.DataBindings.Add(New Binding("EditValue", BS, "FinancialYear"))
        SetSalesInvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SalesInvoiceCount"))
        SetServiceInvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ServiceInvoiceCount"))
        SetProformaSalesInvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ProformaSalesInvoiceCount"))
        SetProformaServiceInvoiceNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ProformaServiceInvoiceCount"))
        SetQuotationNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "QuotationCount"))
        Return True
    End Function

    Sub AddNew()
        BS.AddNew()
        StartDateDateEdit.Focus()
    End Sub

    'Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
    '    BS.CancelEdit()
    '    DS.RejectChanges()
    '    AddNew()
    '    StartDateDateEdit.Focus()
    'End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From FinancialSettings Where Company = '" + PubCompanyName + "'", "FinancialYearID")
        If ID > 0 Then
            Try
                DS.Tables("FinancialSettings").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@FinancialYearID").Value = ID
            DA.Fill(DS, "FinancialSettings")
        End If
    End Sub

    'Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
    '    Try
    '        Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '        If Delete = 1 Then
    '            BS.RemoveCurrent()
    '            DA.Update(DS.Tables("Party"))
    '            AddNew()
    '        End If
    '    Catch ex As Exception
    '        BS.CancelEdit()
    '        DS.RejectChanges()
    '        XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Function Validation() As Boolean
        If StartDateDateEdit.EditValue Is DBNull.Value Then
            StartDateDateEdit.Focus()
            Return False
        ElseIf EndDateDateEdit.EditValue Is DBNull.Value Then
            EndDateDateEdit.Focus()
            Return False
        ElseIf FinancialYearTextEdit.EditValue Is DBNull.Value Then
            FinancialYearTextEdit.Focus()
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
        ElseIf SetQuotationNoTextEdit.EditValue Is DBNull.Value Then
            SetQuotationNoTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.EndEdit()
            DA.Update(DS.Tables("FinancialSettings"))
            Me.DialogResult = DialogResult.OK
            XtraMessageBox.Show("Financial Settings added successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EndDateDateEdit_Leave(sender As Object, e As EventArgs) Handles EndDateDateEdit.Leave
        If Not StartDateDateEdit.EditValue Is DBNull.Value And Not EndDateDateEdit.EditValue Is DBNull.Value Then
            Dim StartDate As String = StartDateDateEdit.Text
            Dim SubStart As String = (StartDate.Substring(8, 2))
            Dim EndDate As String = EndDateDateEdit.Text
            Dim SubEnd As String = (EndDate.Substring(8, 2))
            FinancialYearTextEdit.Text = SubStart + "-" + SubEnd
        Else
            StartDateDateEdit.Focus()
        End If
    End Sub

    Private Sub EndDateDateEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EndDateDateEdit.Validating
        If Not EndDateDateEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(FinancialYearID) FROM FinancialSettings WHERE FinancialYear=@FinancialYear AND FinancialYearID<>@FinancialYearID", ConStr)
                CMD.Parameters.AddWithValue("@FinancialYear", FinancialYearTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@FinancialYearID", IIf(BS.Current!FinancialYearID Is DBNull.Value, -1, BS.Current!FinancialYearID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    StartDateDateEdit.Focus()
                    e.Cancel = True

                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub
End Class