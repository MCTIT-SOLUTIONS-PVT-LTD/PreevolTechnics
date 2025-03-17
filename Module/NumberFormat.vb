Imports DevExpress.XtraEditors
Module NumberFormat
    Sub ISnumber(ByVal TextEdit As TextEdit)
        Dim iNumber As Integer
        If Not Integer.TryParse(TextEdit.Text, iNumber) Then
            XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextEdit.Focus()
        End If
    End Sub
End Module
