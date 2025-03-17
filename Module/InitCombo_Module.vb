Imports System.Data.OleDb
#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraEditors
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.

Module InitCombo_Module

#Disable Warning BC30002 ' Type 'ComboBoxEdit' is not defined.
    Public Sub InitCombo(ByRef Query As String, ByRef DataTable As String, ByRef DM As Object, ByRef ComboBox As ComboBoxEdit)
#Enable Warning BC30002 ' Type 'ComboBoxEdit' is not defined.
        Try
            'For Each OldData In ComboBox.Properties.Items
            '    Dim str As String = OldData
            '    ComboBox.Properties.Items.Remove(str)
            'Next
            ComboBox.Properties.Items.Clear()
            Dim DA_InitCombo As New OleDbDataAdapter
            Dim DS_InitCombo As New DataSet : Dim Exist As Boolean = False

            DA_InitCombo.SelectCommand = New OleDbCommand(Query, ConStr)
            DA_InitCombo.Fill(DS_InitCombo, DataTable)

            For Each MyData In DS_InitCombo.Tables(0).Rows
                ComboBox.Properties.Items.Add(MyData(DM))
            Next

            ComboBox.Properties.ImmediatePopup = True
            ComboBox.Properties.AutoComplete = True
        Catch

        End Try
    End Sub

#Disable Warning BC30002 ' Type 'LookUpEdit' is not defined.
    Public Sub InitLookUp(ByRef Query As String, ByRef DataTable As String, ByRef VM As String, ByRef DM As String, ByRef LookUpEdit As LookUpEdit, ByRef Caption As String)
#Enable Warning BC30002 ' Type 'LookUpEdit' is not defined.
        Try
            Dim DA_InitCombo As New OleDbDataAdapter
            Dim DS_InitCombo As New DataSet

            DA_InitCombo.SelectCommand = New OleDbCommand(Query, ConStr)
            DA_InitCombo.Fill(DS_InitCombo, DataTable)

            With LookUpEdit.Properties
                .DataSource = DS_InitCombo.Tables(DataTable)
                .ValueMember = VM
                .DisplayMember = DM
                If .Columns.Count = 0 Then .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(DM, Caption))
                .SearchMode = Controls.SearchMode.AutoFilter
                .ImmediatePopup = True
                .AllowNullInput = DevExpress.Utils.DefaultBoolean.True
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Disable Warning BC30002 ' Type 'LookUpEdit' is not defined.
    Public Sub InitLookUp_TwoColumn(ByRef Query As String, ByRef DataTable As String, ByRef VM As String, ByRef Col1 As String, ByRef Col2 As String, ByRef LookUpEdit As LookUpEdit, ByRef Caption1 As String, ByRef Caption2 As String, ByRef FirstColIsCol1 As Boolean)
#Enable Warning BC30002 ' Type 'LookUpEdit' is not defined.
        Try
            Dim DA_InitCombo As New OleDbDataAdapter
            Dim DS_InitCombo As New DataSet

            DA_InitCombo.SelectCommand = New OleDbCommand(Query, ConStr)
            DA_InitCombo.Fill(DS_InitCombo, DataTable)


            With LookUpEdit.Properties
                .DataSource = DS_InitCombo.Tables(DataTable)
                .ValueMember = VM

                If FirstColIsCol1 = True Then
                    .DisplayMember = Col1
                Else
                    .DisplayMember = Col2
                End If

                If .Columns.Count = 0 Then
                    If FirstColIsCol1 = True Then
                        .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Col1, Caption1))
                        .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Col2, Caption2))
                    Else
                        .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Col2, Caption2))
                        .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Col1, Caption1))
                    End If
                End If

                .SearchMode = Controls.SearchMode.AutoFilter
                .ImmediatePopup = True
                .AllowNullInput = DevExpress.Utils.DefaultBoolean.True
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
