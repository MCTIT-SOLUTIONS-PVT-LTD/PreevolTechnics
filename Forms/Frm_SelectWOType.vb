Public Class Frm_SelectWOType
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

        PubIGST = InterStateRadioButton.Checked
        PubPrice = WithoutPriceRadioButton.Checked
        If PubIGST Then
            PubWOType = "Work Order IGST"
        Else
            PubWOType = "Work Order"
        End If
        OpenForm(Frm_WorkOrder)
        With Frm_WorkOrder
            .InitLookup()
        End With
        End_Waiting()
        Me.Close()
    End Sub
    'Private Sub Frm_SelectInvoiceType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    InvoiceTypeComboBoxEdit.Text = "Sales Invoice"
    'End Sub

    'Private Sub InvoiceTypeComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If InvoiceTypeComboBoxEdit.Text = "SEZ Sales Invoice" Or InvoiceTypeComboBoxEdit.Text = "SEZ Service Invoice" Or InvoiceTypeComboBoxEdit.Text = "Export Sales Invoice" Or InvoiceTypeComboBoxEdit.Text = "Export Service Invoice" Then
    '        LocalStateRadioButton.Enabled = False
    '        InterStateRadioButton.Checked = True
    '        WithLUTRadioButton.Enabled = True
    '        WithoutLUTRadioButton.Enabled = True
    '        WithLUTRadioButton.Checked = True
    '    Else
    '        LocalStateRadioButton.Enabled = True
    '        LocalStateRadioButton.Checked = True
    '        InterStateRadioButton.Checked = False
    '        WithLUTRadioButton.Enabled = False
    '        WithoutLUTRadioButton.Enabled = False
    '    End If
    'End Sub
End Class