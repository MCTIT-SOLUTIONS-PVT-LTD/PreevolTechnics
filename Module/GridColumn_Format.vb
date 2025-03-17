#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors.Repository' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraEditors.Repository
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors.Repository' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.

Module GridColumn_Format


#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
    Sub GridClmFormatFunc(ByRef ClmFormat As String, ByRef Column As String, ByRef Caption As String, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByRef GridControl As DevExpress.XtraGrid.GridControl)
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.

        Dim Edit As New RepositoryItemDateEdit
        Edit.NullText = " -NULL- "
        Edit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Edit.DisplayFormat.FormatString = ClmFormat

        GridControl.RepositoryItems.Add(Edit)
        GridView.Columns(Column).ColumnEdit = Edit

        With GridView
            .Columns(Column).Caption = Caption
        End With
    End Sub



End Module
