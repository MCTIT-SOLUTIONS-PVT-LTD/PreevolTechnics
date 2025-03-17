
Imports DevExpress.XtraEditors

Public Class Frm_Connection
    Private Sub OKSimpleButton_Click(sender As Object, e As EventArgs) Handles OKSimpleButton.Click
        If Not ConnectionStringTextEdit.Text = String.Empty Then
            Dim prefix As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Chr(34)
            Dim suffix As String = Chr(34)
            My.Settings.dbPreevolTechnicsConnectionString1 = prefix + ConnectionStringTextEdit.Text + suffix
            My.Settings.Save()
            Current()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            Dim result As DialogResult = XtraMessageBox.Show("You don't have enter the connection. Do you want to close this Window?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Me.Close()
            Else
                ConnectionStringTextEdit.Focus()
            End If
            'XtraMessageBox.Show("Close")
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub Frm_Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Current()
    End Sub

    Sub Current()
        CurrentPathTextEdit.Text = My.Settings.dbPreevolTechnicsConnectionString1.Replace("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=", "")
    End Sub
End Class