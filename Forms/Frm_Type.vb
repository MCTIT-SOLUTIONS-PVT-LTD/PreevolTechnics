Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_Type
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()

        AddNew()

        TypeNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Sub SetDataTable()
        DS.Tables.Add("Type")
        With DS.Tables("Type").Columns
            .Add("TypeID", GetType(Integer))
            .Add("TypeName", GetType(String))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("Type").Columns("TypeID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetQuery()
        DA.SelectCommand = New OleDbCommand("Select TypeID,TypeName,Company From Type Where TypeID=@TypeID", ConStr)
        DA.SelectCommand.Parameters.Add("@TypeID", OleDbType.Integer, 4, "TypeID")

        DA.InsertCommand = New OleDbCommand("Insert Into Type (TypeName,Company) Values (@TypeName,@Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@TypeName", OleDbType.VarChar, 50, "TypeName")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update Type Set TypeName=@TypeName Where TypeID=@TypeID", ConStr)
        DA.UpdateCommand.Parameters.Add("@TypeName", OleDbType.VarChar, 50, "TypeName")
        DA.UpdateCommand.Parameters.Add("@TypeID", OleDbType.Integer, 4, "TypeID")

        DA.DeleteCommand = New OleDbCommand("Delete From Type Where TypeID=@TypeID", ConStr)
        DA.DeleteCommand.Parameters.Add("@TypeID", OleDbType.Integer, 4, "TypeID")
    End Sub

    Sub SetBinding()
        BS.DataSource = DS
        BS.DataMember = "Type"
        TypeNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "TypeName"))
    End Sub

    Sub AddNew()
        BS.AddNew()
        TypeNameTextEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        TypeNameTextEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From Type Where Company ='" + PubCompanyName + "'", "TypeID")
        If ID > 0 Then
            Try
                DS.Tables("Type").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@TypeID").Value = ID
            DA.Fill(DS, "Type")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("Type"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If TypeNameTextEdit.EditValue Is DBNull.Value Then
            TypeNameTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.EndEdit()
            DA.Update(DS.Tables("Type"))
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub TypeNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TypeNameTextEdit.Validating
        If Not TypeNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(TypeID) FROM Type WHERE TypeName=@TypeName AND TypeID<>@TypeID", ConStr)
                CMD.Parameters.AddWithValue("@TypeName", TypeNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@TypeID", IIf(BS.Current!TypeID Is DBNull.Value, -1, BS.Current!TypeID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TypeNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub
End Class