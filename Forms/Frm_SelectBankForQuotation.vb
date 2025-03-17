Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
'Imports ELCF
Public Class Frm_SelectBankForQuotation
    Dim Invoice As String
    Dim Val As Integer
    'Dim ChkIGST As Boolean
    Dim ChkDis As Boolean
    Dim InvoiceType As String

    Public Sub New(ByVal QuotationID As String, ByVal Flag As Integer, ByVal isDis As Boolean, ByVal type As String)
        InitializeComponent()
        Invoice = QuotationID
        Val = Flag
        'ChkIGST = isIGST
        ChkDis = isDis
        InvoiceType = type
    End Sub

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitLookup()
        Bank1IDLookUpEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub
    Sub InitLookup()
        SetLookUp("SELECT BankID,BankName FROM Bank", "Bank", "BankID", "BankName", Bank1IDLookUpEdit, "Bank")
    End Sub
    Function Validation() As Boolean
        If Bank1IDLookUpEdit.EditValue Is Nothing Then
            Bank1IDLookUpEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click
        If Validation() Then
            Dim DA As New OleDbDataAdapter
            Dim DT As New DataTable

            DA.SelectCommand = New OleDbCommand("Select BankID,CompanyID,BankName,BranchName,AccountNo,MICRCode,IFSCCode,SwiftCode From Bank Where BankID=" + Bank1IDLookUpEdit.EditValue.ToString, ConStr)
            DA.Fill(DT)

            Dim DACompany As New OleDbDataAdapter
            Dim DTCompany As New DataTable

            DACompany.SelectCommand = New OleDbCommand("Select CompanyID,Name,Address,Phone1,State,StateCode,EmailID1,Website,GSTIN,PANNo,SupplyFrom,ISOText From Company Where Name='" + PubCompanyName + "'", ConStr)
            DACompany.Fill(DTCompany)

            Dim DACreated As New OleDbDataAdapter
            Dim DTCreated As New DataTable

            DACreated.SelectCommand = New OleDbCommand("Select PreparedBy,Mobile From Quotation Where QuotationID=" + Invoice.ToString, ConStr)
            DACreated.Fill(DTCreated)

            Me.Close()
            If ChkDis = False Then
                If Val = 1 Then
                    Dim Rpt As New XR_QuotationNew
                    Rpt.Invoice.Value = Invoice
                    Rpt.Invoice.Visible = False
                    Rpt.FillDataSource()
                    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "  Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString + "  Website: " + DTCompany.Rows(0).Item("Website").ToString
                    'Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                    Rpt.XrLabel91.Text = "Prepared By: " + DTCreated.Rows(0).Item("PreparedBy").ToString + ", Mobile : " + DTCreated.Rows(0).Item("Mobile").ToString
                    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                    Rpt.XrLabel27.Text = DTCompany.Rows(0).Item("ISOText").ToString

                    'Bank Info----
                    Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                    Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                    Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                    Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                    Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
                    End_Waiting()

                    Rpt.ShowRibbonPreviewDialog()
                ElseIf Val = 2 Then
                    Dim Rpt As New XR_QuotationNew
                    Rpt.Invoice.Value = Invoice
                    Rpt.Invoice.Visible = False
                    Rpt.FillDataSource()
                    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "  Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString + "  Website: " + DTCompany.Rows(0).Item("Website").ToString
                    'Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                    Rpt.XrLabel91.Text = "Prepared By: " + DTCreated.Rows(0).Item("PreparedBy").ToString + ", Mobile : " + DTCreated.Rows(0).Item("Mobile").ToString
                    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                    Rpt.XrLabel27.Text = DTCompany.Rows(0).Item("ISOText").ToString

                    'Bank Info----
                    Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                    Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                    Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                    Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                    Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                    Rpt.XrPictureBox2.Visible = True

                    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
                    End_Waiting()

                    Rpt.ShowRibbonPreviewDialog()
                End If
            Else
                If Val = 1 Then
                    Dim Rpt As New XR_QuotationNewWithoutDis
                    Rpt.Invoice.Value = Invoice
                    Rpt.Invoice.Visible = False
                    Rpt.FillDataSource()
                    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "  Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString + "  Website: " + DTCompany.Rows(0).Item("Website").ToString
                    'Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                    Rpt.XrLabel91.Text = "Prepared By: " + DTCreated.Rows(0).Item("PreparedBy").ToString + ", Mobile : " + DTCreated.Rows(0).Item("Mobile").ToString
                    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                    Rpt.XrLabel27.Text = DTCompany.Rows(0).Item("ISOText").ToString

                    'Bank Info----
                    Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                    Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                    Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                    Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                    Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
                    End_Waiting()

                    Rpt.ShowRibbonPreviewDialog()
                ElseIf Val = 2 Then
                    Dim Rpt As New XR_QuotationNewWithoutDis
                    Rpt.Invoice.Value = Invoice
                    Rpt.Invoice.Visible = False
                    Rpt.FillDataSource()
                    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "  Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString + "  Website: " + DTCompany.Rows(0).Item("Website").ToString
                    'Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                    Rpt.XrLabel91.Text = "Prepared By: " + DTCreated.Rows(0).Item("PreparedBy").ToString + ", Mobile : " + DTCreated.Rows(0).Item("Mobile").ToString
                    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                    Rpt.XrLabel27.Text = DTCompany.Rows(0).Item("ISOText").ToString

                    'Bank Info----
                    Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                    Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                    Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                    Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                    Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                    Rpt.XrPictureBox2.Visible = True

                    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
                    End_Waiting()

                    Rpt.ShowRibbonPreviewDialog()
                End If
            End If
                'If ChkIGST = False Then
                'If InvoiceType = "Quotation" Then
                'If ChkDis = False Then
                '    Dim Rpt As New XR_QuotationNew
                '    Rpt.Invoice.Value = Invoice
                '    Rpt.Invoice.Visible = False
                '    Rpt.FillDataSource()
                '    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                '    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                '    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "  Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString + "  Website: " + DTCompany.Rows(0).Item("Website").ToString
                '    'Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                '    Rpt.XrLabel91.Text = "Prepared By: " + DTCreated.Rows(0).Item("PreparedBy").ToString + ", Mobile : " + DTCreated.Rows(0).Item("Mobile").ToString
                '    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                '    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                '    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                '    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString

                '    'Bank Info----
                '    Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                '    Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                '    Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                '    Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                '    Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                '    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                '    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
                '    End_Waiting()

                '    Rpt.ShowRibbonPreviewDialog()
                'Else
                '    Dim Rpt As New XR_QuotationNewWithoutDis
                '    Rpt.Invoice.Value = Invoice
                '    Rpt.Invoice.Visible = False
                '    Rpt.FillDataSource()
                '    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                '    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                '    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "  Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString + "  Website: " + DTCompany.Rows(0).Item("Website").ToString
                '    'Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                '    Rpt.XrLabel91.Text = "Prepared By: " + DTCreated.Rows(0).Item("PreparedBy").ToString + ", Mobile : " + DTCreated.Rows(0).Item("Mobile").ToString
                '    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                '    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                '    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                '    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString

                '    'Bank Info----
                '    Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                '    Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                '    Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                '    Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                '    Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                '    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                '    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
                '    End_Waiting()

                '    Rpt.ShowRibbonPreviewDialog()
                'End If
                'Else
                '    'InvoiceType = "Quotation IGST" Then
                '    Dim Rpt As New XR_QuotationIGST
                '    Rpt.Invoice.Value = Invoice
                '    Rpt.Invoice.Visible = False
                '    Rpt.FillDataSource()
                '    Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                '    Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                '    Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "  Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString + "  Website: " + DTCompany.Rows(0).Item("Website").ToString
                '    Rpt.XrLabel91.Text = "Prepared By: " + DTCreated.Rows(0).Item("PreparedBy").ToString + ", Mobile : " + DTCreated.Rows(0).Item("Mobile").ToString
                '    'Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                '    Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                '    Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                '    Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                '    Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString

                '    'Bank Info----
                '    Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                '    Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                '    Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                '    Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                '    Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                '    Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                '    ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Quotation -")
                '    End_Waiting()

                '    Rpt.ShowRibbonPreviewDialog()
            End If
        'End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub
End Class