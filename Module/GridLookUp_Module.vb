#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors.Repository' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraEditors.Repository
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors.Repository' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.

#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraEditors
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports System.Data.OleDb

Module GridLookUp_Module

    Sub GridLookUpFunc(ByRef Query As String, ByRef DataTable As String, ByRef ValueMember As String, ByRef DisplayMember As String, ByRef GridControl As DevExpress.XtraGrid.GridControl, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByRef GridViewColumnName As String, ByRef ColumnCaption As String)
        Dim DS_LookUp As New DataSet
        Dim DA_LookUp As New OleDbDataAdapter(Query, ConStr)
        DA_LookUp.Fill(DS_LookUp, DataTable)

        Dim Edit As New RepositoryItemLookUpEdit
        Edit.DataSource = DS_LookUp.Tables(DataTable)
        Edit.DisplayMember = DisplayMember
        Edit.ValueMember = ValueMember
        Edit.NullText = " -NULL- "
        Edit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(DisplayMember, DisplayMember))
        GridControl.RepositoryItems.Add(Edit)
        GridView.Columns(GridViewColumnName).ColumnEdit = Edit

        With GridView
            .Columns(GridViewColumnName).Caption = ColumnCaption
        End With
    End Sub

#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.
    Sub GridLookUpFunc_TwoColumn(ByRef Query As String, ByRef DataTable As String, ByRef VM As String, ByRef Col1 As String, ByRef Col2 As String, ByRef GridControl As DevExpress.XtraGrid.GridControl, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByRef Caption1 As String, ByRef Caption2 As String, ByRef GridColumn As String, ByRef FirstColIsCol1 As Boolean)
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
        Try
            Dim DA_InitCombo As New OleDbDataAdapter
            Dim DS_InitCombo As New DataSet

            DA_InitCombo.SelectCommand = New OleDbCommand(Query, ConStr)
            DA_InitCombo.Fill(DS_InitCombo, DataTable)

            Dim Edit As New RepositoryItemLookUpEdit
            Edit.DataSource = DS_InitCombo.Tables(DataTable)
            Edit.ValueMember = VM
            Edit.NullText = " -NULL- "

            If FirstColIsCol1 = True Then
                Edit.DisplayMember = Col1
                GridView.Columns(GridColumn).Caption = Caption1
            Else
                Edit.DisplayMember = Col2
                GridView.Columns(GridColumn).Caption = Caption2
            End If

            If FirstColIsCol1 = True Then
                Edit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Col1, Caption1))
                Edit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Col2, Caption2))
            Else
                Edit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Col2, Caption2))
                Edit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Col1, Caption1))
            End If

            GridControl.RepositoryItems.Add(Edit)
            GridView.Columns(GridColumn).ColumnEdit = Edit

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function SetGridCommboBox(SelectString As String, TableName As String, ByVal GridComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit)
        Dim DS As New DataSet
        Try
            DS.Tables(TableName).Clear()
        Catch
        End Try
        Dim DA As New OleDbDataAdapter(SelectString, ConStr)
        DA.Fill(DS, TableName)
        GridComboBoxEdit.Properties.Items.Clear()

        For Each item As DataRow In DS.Tables(TableName).Rows
            GridComboBoxEdit.Properties.Items.Add(item(0).ToString)
        Next

        Return True

    End Function

    Sub GridComboBoxFunc(ByRef Query As String, ByRef DataTable As String, ByRef GridControl As DevExpress.XtraGrid.GridControl, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByRef GridViewColumnName As String, ByRef ColumnCaption As String)
        Dim DS_ComboBox As New DataSet
        Dim DA_ComboBox As New OleDbDataAdapter(Query, ConStr)
        DA_ComboBox.Fill(DS_ComboBox, DataTable)

        Dim Edit As New RepositoryItemComboBox
        For Each item As DataRow In DS_ComboBox.Tables(DataTable).Rows
            Edit.Items.Add(item(0).ToString)
        Next
        Edit.NullText = ""
        Edit.TextEditStyle = Controls.TextEditStyles.DisableTextEditor
        GridControl.RepositoryItems.Add(Edit)
        GridView.Columns(GridViewColumnName).ColumnEdit = Edit

        With GridView
            .Columns(GridViewColumnName).Caption = ColumnCaption
        End With

    End Sub

    Sub GridMemoEditFunc(ByRef GridControl As DevExpress.XtraGrid.GridControl, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByRef GridViewColumnName As String)

        Dim Edit As New RepositoryItemMemoEdit

        Edit.NullText = ""

        GridControl.RepositoryItems.Add(Edit)
        GridView.Columns(GridViewColumnName).ColumnEdit = Edit

    End Sub

    Sub GridButtonEditFunc(ByRef GridControl As DevExpress.XtraGrid.GridControl, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByRef GridViewColumnName As String)

        Dim Edit As New RepositoryItemButtonEdit

        Edit.NullText = ""
        Edit.TextEditStyle = Controls.TextEditStyles.HideTextEditor

        GridControl.RepositoryItems.Add(Edit)
        GridView.Columns(GridViewColumnName).ColumnEdit = Edit

    End Sub
End Module
