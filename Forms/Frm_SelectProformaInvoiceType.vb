Public Class Frm_SelectProformaInvoiceType
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
        If InvoiceTypeComboBoxEdit.Text = "Sales Proforma Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            If PubIGST Then
                PubProformaInvoiceType = "Sales Proforma Invoice IGST"
            Else
                PubProformaInvoiceType = "Sales Proforma Invoice"
            End If

            OpenForm(Frm_ProformaInvoiceNew)
            With Frm_ProformaInvoiceNew
                .InitLookup()
            End With
            End_Waiting()

        ElseIf InvoiceTypeComboBoxEdit.Text = "Service Proforma Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            If PubIGST Then
                PubProformaInvoiceType = "Service Proforma Invoice IGST"
            Else
                PubProformaInvoiceType = "Service Proforma Invoice"
            End If
            OpenForm(Frm_ProformaServiceInvoice)
            With Frm_ProformaServiceInvoice
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "SEZ Sales Proforma Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            PubWithLUT = WithLUTRadioButton.Checked
            If PubIGST Then
                PubProformaInvoiceType = "SEZ Sales Proforma Invoice IGST"
            Else
                PubProformaInvoiceType = "SEZ Sales Proforma Invoice"
            End If
            OpenForm(Frm_ProformaInvoiceNew)
            With Frm_ProformaInvoiceNew
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "SEZ Service Proforma Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            PubWithLUT = WithLUTRadioButton.Checked
            If PubIGST Then
                PubProformaInvoiceType = "SEZ Service Proforma Invoice IGST"
            Else
                PubProformaInvoiceType = "SEZ Service Proforma Invoice"
            End If
            OpenForm(Frm_ProformaServiceInvoice)
            With Frm_ProformaServiceInvoice
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "Export Sales Proforma Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            PubWithLUT = WithLUTRadioButton.Checked
            If PubIGST Then
                PubProformaInvoiceType = "Export Sales Proforma Invoice IGST"
            Else
                PubProformaInvoiceType = "Export Sales Proforma Invoice"
            End If
            OpenForm(Frm_ProformaInvoiceNew)
            With Frm_ProformaInvoiceNew
                .InitLookup()
            End With
            End_Waiting()
        ElseIf InvoiceTypeComboBoxEdit.Text = "Export Service Proforma Invoice" Then
            PubIGST = InterStateRadioButton.Checked
            PubWithLUT = WithLUTRadioButton.Checked
            If PubIGST Then
                PubProformaInvoiceType = "Export Service Proforma Invoice IGST"
            Else
                PubProformaInvoiceType = "Export Service Proforma Invoice"
            End If
            OpenForm(Frm_ProformaServiceInvoice)
            With Frm_ProformaServiceInvoice
                .InitLookup()
            End With
            End_Waiting()
        End If
        Me.Close()
    End Sub
    Private Sub Frm_SelectInvoiceType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InvoiceTypeComboBoxEdit.Text = "Sales Proforma Invoice"
    End Sub

    Private Sub InvoiceTypeComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvoiceTypeComboBoxEdit.SelectedIndexChanged
        If InvoiceTypeComboBoxEdit.Text = "SEZ Sales Proforma Invoice" Or InvoiceTypeComboBoxEdit.Text = "SEZ Service Proforma Invoice" Or InvoiceTypeComboBoxEdit.Text = "Export Sales Proforma Invoice" Or InvoiceTypeComboBoxEdit.Text = "Export Service Proforma Invoice" Then
            LocalStateRadioButton.Enabled = False
            InterStateRadioButton.Checked = True
            WithLUTRadioButton.Enabled = True
            WithoutLUTRadioButton.Enabled = True
            WithLUTRadioButton.Checked = True
        Else
            LocalStateRadioButton.Enabled = True
            LocalStateRadioButton.Checked = True
            InterStateRadioButton.Checked = False
            WithLUTRadioButton.Enabled = False
            WithoutLUTRadioButton.Enabled = False
        End If
    End Sub
End Class