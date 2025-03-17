Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_PlungerDia
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()

        AddNew()

        DiameterNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Sub SetDataTable()
        DS.Tables.Add("PlungerDia")
        With DS.Tables("PlungerDia").Columns
            .Add("PlungerDiaID", GetType(Integer))
            .Add("PlungerDiaName", GetType(String))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("PlungerDia").Columns("PlungerDiaID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetQuery()
        DA.SelectCommand = New OleDbCommand("Select PlungerDiaID,PlungerDiaName,Company From PlungerDia Where PlungerDiaID=@PlungerDiaID", ConStr)
        DA.SelectCommand.Parameters.Add("@PlungerDiaID", OleDbType.Integer, 4, "PlungerDiaID")

        DA.InsertCommand = New OleDbCommand("Insert Into PlungerDia (PlungerDiaName,Company) Values (@PlungerDiaName,@Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@PlungerDiaName", OleDbType.VarChar, 50, "PlungerDiaName")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update PlungerDia Set PlungerDiaName=@PlungerDiaName Where PlungerDiaID=@PlungerDiaID", ConStr)
        DA.UpdateCommand.Parameters.Add("@PlungerDiaName", OleDbType.VarChar, 50, "PlungerDiaName")
        DA.UpdateCommand.Parameters.Add("@PlungerDiaID", OleDbType.Integer, 4, "PlungerDiaID")

        DA.DeleteCommand = New OleDbCommand("Delete From PlungerDia Where PlungerDiaID=@PlungerDiaID", ConStr)
        DA.DeleteCommand.Parameters.Add("@PlungerDiaID", OleDbType.Integer, 4, "PlungerDiaID")
    End Sub

    Sub SetBinding()
        BS.DataSource = DS
        BS.DataMember = "PlungerDia"
        DiameterNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PlungerDiaName"))
    End Sub

    Sub AddNew()
        BS.AddNew()
        DiameterNameTextEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        DiameterNameTextEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From PlungerDia Where Company ='" + PubCompanyName + "'", "PlungerDiaID")
        If ID > 0 Then
            Try
                DS.Tables("PlungerDia").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@PlungerDiaID").Value = ID
            DA.Fill(DS, "PlungerDia")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("PlungerDia"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If DiameterNameTextEdit.EditValue Is DBNull.Value Then
            DiameterNameTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.EndEdit()
            DA.Update(DS.Tables("PlungerDia"))
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub TypeNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DiameterNameTextEdit.Validating
        If Not DiameterNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(PlungerDiaID) FROM PlungerDia WHERE PlungerDiaName=@PlungerDiaName AND PlungerDiaID<>@PlungerDiaID", ConStr)
                CMD.Parameters.AddWithValue("@PlungerDiaName", DiameterNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@PlungerDiaID", IIf(BS.Current!PlungerDiaID Is DBNull.Value, -1, BS.Current!PlungerDiaID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DiameterNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub
End Class