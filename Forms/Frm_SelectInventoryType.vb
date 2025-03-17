Public Class Frm_SelectInventoryType

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
        If InventoryTypeComboBoxEdit.Text = "IN" Then
            'PubIGST = InterStateRadioButton.Checked
            'If PubIGST Then
            '    PubInvoiceType = "Sales Invoice IGST"
            'Else
            '    PubInvoiceType = "Sales Invoice"
            'End If
            PubInventoryType = "IN"
            OpenForm(Frm_InventoryManagement)
            With Frm_InventoryManagement
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InventoryTypeComboBoxEdit.Text = "OUT" Then
            'PubIGST = InterStateRadioButton.Checked
            'If PubIGST Then
            '    PubInvoiceType = "Service Invoice IGST"
            'Else
            '    PubInvoiceType = "Service Invoice"
            'End If
            PubInventoryType = "OUT"
            OpenForm(Frm_InventoryManagement)
            With Frm_InventoryManagement
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InventoryTypeComboBoxEdit.Text = "RETURN" Then
            'PubIGST = InterStateRadioButton.Checked
            'PubWithLUT = WithLUTRadioButton.Checked
            'If PubIGST Then
            '    PubInvoiceType = "SEZ Sales Invoice IGST"
            'Else
            '    PubInvoiceType = "SEZ Sales Invoice"
            'End If
            PubInventoryType = "RETURN"
            OpenForm(Frm_InventoryManagement)
            With Frm_InventoryManagement
                .InitLookup()
            End With
            End_Waiting()
        End If
        Me.Close()
    End Sub
    Private Sub Frm_SelectInvoiceType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InventoryTypeComboBoxEdit.Text = "IN"
    End Sub

    'Private Sub InvoiceTypeComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InventoryTypeComboBoxEdit.SelectedIndexChanged
    '    If InventoryTypeComboBoxEdit.Text = "SEZ Sales Invoice" Or InventoryTypeComboBoxEdit.Text = "SEZ Service Invoice" Or InventoryTypeComboBoxEdit.Text = "Export Sales Invoice" Or InventoryTypeComboBoxEdit.Text = "Export Service Invoice" Then
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