Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_Category
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()

        AddNew()

        CategoryNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Sub SetDataTable()
        DS.Tables.Add("Category")
        With DS.Tables("Category").Columns
            .Add("CategoryID", GetType(Integer))
            .Add("CategoryName", GetType(String))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("Category").Columns("CategoryID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetQuery()
        DA.SelectCommand = New OleDbCommand("Select CategoryID,CategoryName,Company From Category Where CategoryID=@CategoryID", ConStr)
        DA.SelectCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")

        DA.InsertCommand = New OleDbCommand("Insert Into Category (CategoryName,Company) Values (@CategoryName,@Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@CategoryName", OleDbType.VarChar, 50, "CategoryName")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update Category Set CategoryName=@CategoryName Where CategoryID=@CategoryID", ConStr)
        DA.UpdateCommand.Parameters.Add("@CategoryName", OleDbType.VarChar, 50, "CategoryName")
        DA.UpdateCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")

        DA.DeleteCommand = New OleDbCommand("Delete From Category Where CategoryID=@CategoryID", ConStr)
        DA.DeleteCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")
    End Sub

    Sub SetBinding()
        BS.DataSource = DS
        BS.DataMember = "Category"
        CategoryNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "CategoryName"))
    End Sub

    Sub AddNew()
        BS.AddNew()
        CategoryNameTextEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        CategoryNameTextEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From Category Where Company ='" + PubCompanyName + "'", "CategoryID")
        If ID > 0 Then
            Try
                DS.Tables("Category").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@CategoryID").Value = ID
            DA.Fill(DS, "Category")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("Category"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If CategoryNameTextEdit.EditValue Is DBNull.Value Then
            CategoryNameTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.EndEdit()
            DA.Update(DS.Tables("Category"))
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub CategoryNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CategoryNameTextEdit.Validating
        If Not CategoryNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(CategoryID) FROM Category WHERE CategoryName=@CategoryName AND CategoryID<>@CategoryID", ConStr)
                CMD.Parameters.AddWithValue("@CategoryName", CategoryNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@CategoryID", IIf(BS.Current!CategoryID Is DBNull.Value, -1, BS.Current!CategoryID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CategoryNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub
End Class