Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_User
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()

        AddNew()
        UserNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)

        'Dim NewString As String = My.Settings.dbPreevolTechnicsConnectionString1
        'Dim prefix As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Chr(34)
        'Dim suffix As String = Chr(34)
        'My.Settings.dbPreevolTechnicsConnectionString1 = prefix + "E:\Preevol Technics Software\Preevol Technics\dbPreevolTechnics.accdb" + suffix
        'My.Settings.Save()


        If PubIsAdmin = False Then
            NewBarButtonItem.Enabled = False
            OpenBarButtonItem.Enabled = False
            DeleteBarButtonItem.Enabled = False
            IsAdminCheckEdit.Enabled = False
            user()
        End If
    End Sub

    Sub user()
        Try
            DS.Tables("LoginUser").Clear()
        Catch
        End Try
        DA.SelectCommand.Parameters("@UserID").Value = PubUserID
        DA.Fill(DS, "LoginUser")
    End Sub

    Function SetDataTable()
        DS.Tables.Add("LoginUser")
        With DS.Tables("LoginUser").Columns
            .Add("UserID", GetType(Integer))
            .Add("UserName", GetType(String))
            .Add("Pwd", GetType(String))
            .Add("IsAdmin", GetType(Boolean))
            .Item("IsAdmin").DefaultValue = False
        End With

        With DS.Tables("LoginUser").Columns("UserID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
        Return True
    End Function

    Function SetQuery()
        DA.SelectCommand = New OleDbCommand("Select UserID,UserName,Pwd,IsAdmin From LoginUser Where UserID=@UserID", ConStr)
        DA.SelectCommand.Parameters.Add("@UserID", OleDbType.Integer, 4, "UserID")

        DA.InsertCommand = New OleDbCommand("Insert Into LoginUser (UserName,Pwd,IsAdmin) Values (@UserName,@Pwd,@IsAdmin)", ConStr)
        DA.InsertCommand.Parameters.Add("@UserName", OleDbType.VarChar, 50, "UserName")
        DA.InsertCommand.Parameters.Add("@Pwd", OleDbType.VarChar, 50, "Pwd")
        DA.InsertCommand.Parameters.Add("@IsAdmin", OleDbType.Boolean, 1, "IsAdmin")

        DA.UpdateCommand = New OleDbCommand("Update LoginUser Set UserName=@UserName,Pwd=@Pwd,IsAdmin=@IsAdmin Where UserID=@UserID", ConStr)
        DA.UpdateCommand.Parameters.Add("@UserName", OleDbType.VarChar, 50, "UserName")
        DA.UpdateCommand.Parameters.Add("@Pwd", OleDbType.VarChar, 50, "Pwd")
        DA.UpdateCommand.Parameters.Add("@IsAdmin", OleDbType.Boolean, 1, "IsAdmin")
        DA.UpdateCommand.Parameters.Add("@UserID", OleDbType.Integer, 4, "UserID")

        DA.DeleteCommand = New OleDbCommand("Delete From LoginUser Where UserID=@UserID", ConStr)
        DA.DeleteCommand.Parameters.Add("@UserID", OleDbType.Integer, 4, "UserID")
        Return True
    End Function

    Function SetBinding()
        BS.DataSource = DS.Tables("LoginUser")
        UserNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "UserName"))
        PasswordTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Pwd"))
        IsAdminCheckEdit.DataBindings.Add(New Binding("EditValue", BS, "IsAdmin"))
        Return True
    End Function

    Sub AddNew()
        BS.AddNew()
        UserNameTextEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        UserNameTextEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From LoginUser", "UserID")
        If ID > 0 Then
            Try
                DS.Tables("LoginUser").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@UserID").Value = ID
            DA.Fill(DS, "LoginUser")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("LoginUser"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If UserNameTextEdit.EditValue Is DBNull.Value Then
            UserNameTextEdit.Focus()
            Return False
        ElseIf PasswordTextEdit.EditValue Is DBNull.Value Then
            PasswordTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.EndEdit()
            DA.Update(DS.Tables("LoginUser"))
            'If PubIsAdmin = True Then
            AddNew()
            'Else
            '    Dim Delete = XtraMessageBox.Show("Password changed successfully ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    If Delete = 1 Then
            '        Me.Close()
            '    End If
            'End If
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub UserNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UserNameTextEdit.Validating
        If Not UserNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(UserID) FROM LoginUser WHERE UserName=@UserName AND UserID<>@UserID", ConStr)
                CMD.Parameters.AddWithValue("@UserName", UserNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@UserID", IIf(BS.Current!UserID Is DBNull.Value, -1, BS.Current!UserID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Username Exist! Enter Unique Username.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UserNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class