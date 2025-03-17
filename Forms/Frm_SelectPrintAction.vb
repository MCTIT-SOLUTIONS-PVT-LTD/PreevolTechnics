Public Class Frm_SelectPrintAction
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Public Sub OpenForm(Form As DevExpress.XtraEditors.XtraForm, Optional Index As Boolean = False, Optional ByRef Index1 As Boolean = False)
        If Index1 = False Then Start_Waiting()
        Form.MdiParent = Frm_Main
        If Index = False Then Form.WindowState = FormWindowState.Maximized Else Form.WindowState = FormWindowState.Normal
        Form.Show()
        Form.BringToFront()
    End Sub

    Private Sub OkSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click

        If EWBRadioButton.Checked Then
            PubPrintAction = "printewb"
        ElseIf CEWBRadioButton.Checked Then
            PubPrintAction = "printcewb"
        ElseIf DetailedRadioButton.Checked Then
            PubPrintAction = "printdetailewb"
        End If
        Me.Close()
    End Sub

End Class