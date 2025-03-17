Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_Bank
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
        Dim BS As New BindingSource
        Dim DADetails As New OleDbDataAdapter
        Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()
        ' InitLookup()
        AddNew()
        BankNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Sub SetDataTable()
        DS.Tables.Add("Bank")
        With DS.Tables("Bank").Columns
            .Add("BankID", GetType(Integer))
            .Add("BankName", GetType(String))
            .Add("BranchName", GetType(String))
            .Add("AccountNo", GetType(String))
            .Add("MICRCode", GetType(Integer))
            .Add("IFSCCode", GetType(String))
            .Add("SwiftCode", GetType(String))
            .Add("Company", GetType(String))
        End With
        With DS.Tables("Bank").Columns("BankID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Function SetQuery()

        DA.SelectCommand = New OleDbCommand("Select BankID,BankName,BranchName,AccountNo,MICRCode,IFSCCode,SwiftCode,Company From Bank Where BankID=@BankID", ConStr)
        DA.SelectCommand.Parameters.Add("@BankID", OleDbType.Integer, 4, "BankID")

        DA.InsertCommand = New OleDbCommand("Insert Into Bank (BankName,BranchName,AccountNo,MICRCode,IFSCCode,SwiftCode,Company) Values (@BankName,@BranchName,@AccountNo,@MICRCode,@IFSCCode,@SwiftCode,@Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@BankName", OleDbType.VarChar, 50, "BankName")
        DA.InsertCommand.Parameters.Add("@BranchName", OleDbType.VarChar, 50, "BranchName")
        DA.InsertCommand.Parameters.Add("@AccountNo", OleDbType.VarChar, 25, "AccountNo")
        DA.InsertCommand.Parameters.Add("@MICRCode", OleDbType.Integer, 4, "MICRCode")
        DA.InsertCommand.Parameters.Add("@IFSCCode", OleDbType.VarChar, 25, "IFSCCode")
        DA.InsertCommand.Parameters.Add("@SwiftCode", OleDbType.VarChar, 25, "SwiftCode")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update Bank Set BankName=@BankName,BranchName=@BranchName,AccountNo=@AccountNo,MICRCode=@MICRCode,IFSCCode=@IFSCCode,SwiftCode=@SwiftCode Where BankID=@BankID", ConStr)
        DA.UpdateCommand.Parameters.Add("@BankName", OleDbType.VarChar, 50, "BankName")
        DA.UpdateCommand.Parameters.Add("@BranchName", OleDbType.VarChar, 50, "BranchName")
        DA.UpdateCommand.Parameters.Add("@AccountNo", OleDbType.VarChar, 25, "AccountNo")
        DA.UpdateCommand.Parameters.Add("@MICRCode", OleDbType.Integer, 4, "MICRCode")
        DA.UpdateCommand.Parameters.Add("@IFSCCode", OleDbType.VarChar, 25, "IFSCCode")
        DA.UpdateCommand.Parameters.Add("@SwiftCode", OleDbType.VarChar, 25, "SwiftCode")
        DA.UpdateCommand.Parameters.Add("@BankID", OleDbType.Integer, 4, "BankID")

        DA.DeleteCommand = New OleDbCommand("Delete From Bank Where BankID=@BankID", ConStr)
        DA.DeleteCommand.Parameters.Add("@BankID", OleDbType.Integer, 4, "BankID")
        Return True
    End Function

    Function SetBinding()
        BS.DataSource = DS.Tables("Bank")
        BankNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "BankName"))
        BranchNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "BranchName"))
        AccountNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "AccountNo"))
        MICRCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "MICRCode"))
        IFSCCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "IFSCCode"))
        SwiftCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SwiftCode"))
        Return True
    End Function

    Sub AddNew()
        BS.AddNew()
        BankNameTextEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        BankNameTextEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From Bank Where Company ='" + PubCompanyName + "'", "BankID")
        If ID > 0 Then
            Try
                DS.Tables("Bank").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@BankID").Value = ID
            DA.Fill(DS, "Bank")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("Bank"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ErtOccur(ex)
        End Try
    End Sub

    Function Validation() As Boolean
        If BankNameTextEdit.EditValue Is DBNull.Value Or BankNameTextEdit.EditValue Is "" Then
            BankNameTextEdit.Focus()
            Return False
        ElseIf AccountNoTextEdit.EditValue Is DBNull.Value Or AccountNoTextEdit.EditValue Is "" Then
            AccountNoTextEdit.Focus()
            Return False
        ElseIf IFSCCodeTextEdit.EditValue Is DBNull.Value Or IFSCCodeTextEdit.EditValue Is "" Then
            IFSCCodeTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.EndEdit()
            DA.Update(DS.Tables("Bank"))
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub BankNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BankNameTextEdit.Validating
        If Not BankNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(BankID) FROM Bank WHERE BankName=@BankName AND BankID<>@BankID", ConStr)
                CMD.Parameters.AddWithValue("@BankName", BankNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@BankID", IIf(BS.Current!BankID Is DBNull.Value, -1, BS.Current!BankID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BankNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub

    'Dim iNumber As Integer
    'Private Sub AccountNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AccountNoTextEdit.Validating
    '    If AccountNoTextEdit.Text.Length > 20 Then
    '        XtraMessageBox.Show("Please Enter Valid Account No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        AccountNoTextEdit.Focus()
    '    End If
    'End Sub

    'Private Sub MICRCodeTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MICRCodeTextEdit.Validating
    '    If MICRCodeTextEdit IsNot DBNull.Value Then
    '        If Not Integer.TryParse(MICRCodeTextEdit.Text, iNumber) Then
    '            XtraMessageBox.Show("Please enter Valid MICR Code.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End If
    'End Sub
End Class