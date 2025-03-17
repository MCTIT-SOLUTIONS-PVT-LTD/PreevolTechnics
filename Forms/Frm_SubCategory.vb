Imports System.Data.OleDb
Imports DevExpress.XtraEditors
'Imports ELCF
Public Class Frm_SubCategory
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim DADetails As New OleDbDataAdapter
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()
        InitLookup()
        AddNew()
        CategoryIDLookUpEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Function SetDataTable()
        DS.Tables.Add("SubCategory")
        With DS.Tables("SubCategory").Columns
            .Add("SubCategoryID", GetType(Integer))
            .Add("SubCategoryName", GetType(String))
            .Add("CategoryID", GetType(Integer))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("SubCategory").Columns("SubCategoryID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
        Return True
    End Function

    Function SetQuery()
        DA.SelectCommand = New OleDbCommand("Select SubCategoryID,SubCategoryName,CategoryID,Company From SubCategory Where SubCategoryID=@SubCategoryID", ConStr)
        DA.SelectCommand.Parameters.Add("@SubCategoryID", OleDbType.Integer, 4, "SubCategoryID")

        DA.InsertCommand = New OleDbCommand("Insert Into SubCategory (SubCategoryName,CategoryID,Company) Values (@SubCategoryName,@CategoryID,Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@SubCategoryName", OleDbType.VarChar, 50, "SubCategoryName")
        DA.InsertCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update SubCategory Set SubCategoryName=@SubCategoryName,CategoryID=@CategoryID Where SubCategoryID=@SubCategoryID", ConStr)
        DA.UpdateCommand.Parameters.Add("@SubCategoryName", OleDbType.VarChar, 50, "SubCategoryName")
        DA.UpdateCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")
        DA.UpdateCommand.Parameters.Add("@SubCategoryID", OleDbType.Integer, 4, "SubCategoryID")

        DA.DeleteCommand = New OleDbCommand("Delete From SubCategory Where SubCategoryID=@SubCategoryID", ConStr)
        DA.DeleteCommand.Parameters.Add("@SubCategoryID", OleDbType.Integer, 4, "SubCategoryID")
        Return True
    End Function

    Function SetBinding()
        BS.DataSource = DS.Tables("SubCategory")
        CategoryIDLookUpEdit.DataBindings.Add(New Binding("EditValue", BS, "CategoryID"))
        SubCategoryNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "SubCategoryName"))
        Return True
    End Function
    Sub InitLookup()
        SetLookUp("SELECT CategoryID,CategoryName FROM Category", "Category", "CategoryID", "CategoryName", CategoryIDLookUpEdit, "Category")
    End Sub

    Sub AddNew()
        BS.AddNew()
        CategoryIDLookUpEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        CategoryIDLookUpEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From SubCategory Where Company = '" + PubCompanyName + "'", "SubCategoryID")
        If ID > 0 Then
            Try
                DS.Tables("SubCategory").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@SubCategoryID").Value = ID
            DA.Fill(DS, "SubCategory")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("SubCategory"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If SubCategoryNameTextEdit.EditValue Is DBNull.Value Then
            SubCategoryNameTextEdit.Focus()
            Return False
        ElseIf CategoryIDLookUpEdit.EditValue Is DBNull.Value Then
            CategoryIDLookUpEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.EndEdit()
            DA.Update(DS.Tables("SubCategory"))
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub SubCategoryNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SubCategoryNameTextEdit.Validating
        If Not SubCategoryNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(SubCategoryID) FROM SubCategory WHERE SubCategoryName=@SubCategoryName AND CategoryID=@CategoryID AND SubCategoryID<>@SubCategoryID", ConStr)
                CMD.Parameters.AddWithValue("@SubCategoryName", SubCategoryNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@CategoryID", CategoryIDLookUpEdit.EditValue)
                CMD.Parameters.AddWithValue("@SubCategoryID", IIf(BS.Current!SubCategoryID Is DBNull.Value, -1, BS.Current!SubCategoryID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CategoryIDLookUpEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub AddNewSimpleButton_Click(sender As Object, e As EventArgs) Handles AddNewSimpleButton.Click
        Frm_AddCategory.StartPosition = FormStartPosition.CenterParent
        Frm_AddCategory.ShowDialog()
        If Frm_AddCategory.DialogResult = DialogResult.OK Then
            InitLookup()
            Frm_AddCategory.Close()
        Else
            Frm_AddCategory.Close()
        End If
    End Sub
End Class