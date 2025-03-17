Public Class Frm_SelectInvoiceTypeForReport
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
        If InvoiceTypeComboBoxEdit.Text = "Sales Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            If PubIGST Then
                PubInvoiceType = "Sales Invoice IGST"
            Else
                PubInvoiceType = "Sales Invoice"
            End If
            OpenForm(Frm_SalesReport)
            With Frm_SalesReport
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "Service Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            If PubIGST Then
                PubInvoiceType = "Service Invoice IGST"
            Else
                PubInvoiceType = "Service Invoice"
            End If
            OpenForm(Frm_ServiceReportNew)
            With Frm_ServiceReportNew
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "SEZ Sales Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            'PubWithLUT = WithLUTRadioButton.Checked
            If PubIGST Then
                PubInvoiceType = "SEZ Sales Invoice IGST"
            Else
                PubInvoiceType = "SEZ Sales Invoice"
            End If
            OpenForm(Frm_SalesReport)
            With Frm_SalesReport
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "SEZ Service Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            'PubWithLUT = WithLUTRadioButton.Checked
            If PubIGST Then
                PubInvoiceType = "SEZ Service Invoice IGST"
            Else
                PubInvoiceType = "SEZ Service Invoice"
            End If
            OpenForm(Frm_ServiceReportNew)
            With Frm_ServiceReportNew
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "Export Sales Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            'PubWithLUT = WithLUTRadioButton.Checked
            If PubIGST Then
                PubInvoiceType = "Export Sales Invoice IGST"
            Else
                PubInvoiceType = "Export Sales Invoice"
            End If
            OpenForm(Frm_SalesReport)
            With Frm_SalesReport
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "Export Service Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            'PubWithLUT = WithLUTRadioButton.Checked
            If PubIGST Then
                PubInvoiceType = "Export Service Invoice IGST"
            Else
                PubInvoiceType = "Export Service Invoice"
            End If
            OpenForm(Frm_ServiceReportNew)
            With Frm_ServiceReportNew
                .InitLookup()
            End With
            End_Waiting()
        End If
        Me.Close()
    End Sub
    Private Sub Frm_SelectInvoiceType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InvoiceTypeComboBoxEdit.Text = "Sales Invoice"
    End Sub

    Private Sub InvoiceTypeComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvoiceTypeComboBoxEdit.SelectedIndexChanged
        If InvoiceTypeComboBoxEdit.Text = "Export Sales Invoice" Or InvoiceTypeComboBoxEdit.Text = "Export Service Invoice" Or InvoiceTypeComboBoxEdit.Text = "SEZ Sales Invoice" Or InvoiceTypeComboBoxEdit.Text = "SEZ Service Invoice" Then
            LocalStateRadioButton.Enabled = False
            InterStateRadioButton.Enabled = True
            InterStateRadioButton.Checked = True
            'WithLUTRadioButton.Enabled = True
            'WithoutLUTRadioButton.Enabled = True
            'WithLUTRadioButton.Checked = True
            'ElseIf InvoiceTypeComboBoxEdit.Text = "SEZ Sales Invoice" Or InvoiceTypeComboBoxEdit.Text = "SEZ Service Invoice" Then
            '    'LocalStateRadioButton.Checked = True
            '    'InterStateRadioButton.Enabled = False
            '    'WithLUTRadioButton.Enabled = True
            '    'WithoutLUTRadioButton.Enabled = True
            '    'WithLUTRadioButton.Checked = True
            'ElseIf InvoiceTypeComboBoxEdit.Text = "SEZ Sales Invoice" Or InvoiceTypeComboBoxEdit.Text = "SEZ Service Invoice" Then
            '    LocalStateRadioButton.Enabled = False
            '    InterStateRadioButton.Enabled = False
            '    InterStateRadioButton.Checked = True
            '    'WithLUTRadioButton.Enabled = False
            '    'WithoutLUTRadioButton.Enabled = False
        Else
            LocalStateRadioButton.Enabled = True
            InterStateRadioButton.Enabled = True
            LocalStateRadioButton.Checked = True
        End If
    End Sub
End Class