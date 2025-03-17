Imports System.Data.OleDb

Public Class FrmOpenStock
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Public BS As New BindingSource


    Public Sub New(ByVal SelectQuery As String)
        InitializeComponent()

        DA.SelectCommand = New OleDbCommand(SelectQuery, ConStr)
        DA.Fill(DS)
        BS.DataSource = DS.Tables(0)
        GridControl1.DataSource = BS
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
    '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    '    Me.Close()
    'End Sub

    Private Sub FrmOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class