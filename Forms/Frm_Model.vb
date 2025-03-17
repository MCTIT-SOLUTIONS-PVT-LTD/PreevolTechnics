Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_Model
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()

        AddNew()

        ModelNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Sub SetDataTable()
        DS.Tables.Add("Model")
        With DS.Tables("Model").Columns
            .Add("ModelID", GetType(Integer))
            .Add("ModelName", GetType(String))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("Model").Columns("ModelID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetQuery()
        DA.SelectCommand = New OleDbCommand("Select ModelID,ModelName,Company From Model Where ModelID=@ModelID", ConStr)
        DA.SelectCommand.Parameters.Add("@ModelID", OleDbType.Integer, 4, "ModelID")

        DA.InsertCommand = New OleDbCommand("Insert Into Model (ModelName,Company) Values (@ModelName,@Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@ModelName", OleDbType.VarChar, 50, "ModelName")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update Model Set ModelName=@ModelName Where ModelID=@ModelID", ConStr)
        DA.UpdateCommand.Parameters.Add("@ModelName", OleDbType.VarChar, 50, "ModelName")
        DA.UpdateCommand.Parameters.Add("@ModelID", OleDbType.Integer, 4, "ModelID")

        DA.DeleteCommand = New OleDbCommand("Delete From Model Where ModelID=@ModelID", ConStr)
        DA.DeleteCommand.Parameters.Add("@ModelID", OleDbType.Integer, 4, "ModelID")
    End Sub

    Sub SetBinding()
        BS.DataSource = DS
        BS.DataMember = "Model"
        ModelNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ModelName"))
    End Sub

    Sub AddNew()
        BS.AddNew()
        ModelNameTextEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        ModelNameTextEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From Model Where Company ='" + PubCompanyName + "'", "ModelID")
        If ID > 0 Then
            Try
                DS.Tables("Model").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@ModelID").Value = ID
            DA.Fill(DS, "Model")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("Model"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If ModelNameTextEdit.EditValue Is DBNull.Value Then
            ModelNameTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.EndEdit()
            DA.Update(DS.Tables("Model"))
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub TypeNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ModelNameTextEdit.Validating
        If Not ModelNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(ModelID) FROM Model WHERE ModelName=@ModelName AND ModelID<>@ModelID", ConStr)
                CMD.Parameters.AddWithValue("@ModelName", ModelNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@ModelID", IIf(BS.Current!ModelID Is DBNull.Value, -1, BS.Current!ModelID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ModelNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub
End Class