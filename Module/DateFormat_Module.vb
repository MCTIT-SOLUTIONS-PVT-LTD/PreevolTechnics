#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors.Repository' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraEditors.Repository
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors.Repository' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.

#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraGrid.Views.Grid' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraGrid.Views.Grid
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraGrid.Views.Grid' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraGrid' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraGrid
Imports System.Globalization
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraGrid' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.

Module DateFormat_Module

#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
    Sub DateFormatFunc(ByRef Column As String, ByRef Caption As String, ByRef FormatStr As String, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByRef GridControl As DevExpress.XtraGrid.GridControl)
#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.

        Dim Edit As New RepositoryItemDateEdit
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.
        Edit.NullText = " -NULL- "
        Edit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Edit.DisplayFormat.FormatString = FormatStr

        GridControl.RepositoryItems.Add(Edit)
        GridView.Columns(Column).ColumnEdit = Edit

        With GridView
            .Columns(Column).Caption = Caption
        End With

    End Sub
    Sub SetCurrencyFormat(ByRef ColmName As String, ByRef Formt As String, ByRef GridView As GridView, ByRef GridControl As GridControl)
        With GridView.Columns(ColmName)
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .DisplayFormat.FormatString = Formt
        End With
    End Sub

#Disable Warning BC30002 ' Type 'GridControl' is not defined.
    Sub SetCustomFormat(ByRef ColmName As String, ByRef Formt As String, ByRef GridView As GridView, ByRef GridControl As GridControl)
#Disable Warning BC30002 ' Type 'GridView' is not defined.
#Enable Warning BC30002 ' Type 'GridControl' is not defined.
        With GridView.Columns(ColmName)
#Enable Warning BC30002 ' Type 'GridView' is not defined.
            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            .DisplayFormat.FormatString = Formt
        End With
    End Sub

End Module
