<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_ExportServiceIGST

    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_ExportServiceIGST))
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.DS_Invoice2 = New PreevolTechnics.DS_Invoice()
        Me.DT_InvoiceTableAdapter1 = New PreevolTechnics.DS_InvoiceTableAdapters.DT_InvoiceTableAdapter()
        Me.Invoice = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.DS_ServiceInvoice1 = New PreevolTechnics.DS_ServiceInvoice()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.TaxableValueLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.IGSTAmtLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalGSTCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PackingChargeCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TaxableValLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TaxableValueCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PackingGSTCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.RoundOffCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GrandTotalLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GrandTotalCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel103 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel102 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel104 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel106 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel111 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel110 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel107 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel156 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel155 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel141 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel153 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel140 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel143 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel150 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel133 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel139 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel138 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel152 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel154 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel161 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel160 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel159 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel158 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel157 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel166 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel164 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel163 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel162 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.DT_ServiceInvoiceTableAdapter = New PreevolTechnics.DS_ServiceInvoiceTableAdapters.DT_ServiceInvoiceTableAdapter()
        Me.DS_ServiceInvoice2 = New PreevolTechnics.DS_ServiceInvoice()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel92 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel81 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelMSME = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabelIrn = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAck = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelISO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel72 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel75 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel76 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel77 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel78 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel93 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel117 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel118 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel119 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel120 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel121 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel126 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel127 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel91 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel90 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel89 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel123 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel122 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ServiceInvoice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ServiceInvoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 2.000003!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBorders = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1})
        Me.TopMargin.HeightF = 50.00001!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.1672687!, 47.91667!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(777.5562!, 2.083336!)
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine1.EndBand = Nothing
        Me.XrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Nothing
        Me.XrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandLine1.WidthF = 9.375!
        '
        'DS_Invoice2
        '
        Me.DS_Invoice2.DataSetName = "DS_Invoice"
        Me.DS_Invoice2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_InvoiceTableAdapter1
        '
        Me.DT_InvoiceTableAdapter1.ClearBeforeFill = True
        '
        'Invoice
        '
        Me.Invoice.Description = "Invoice"
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Type = GetType(Integer)
        Me.Invoice.ValueInfo = "0"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Expanded = False
        Me.PageFooter.HeightF = 23.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(677.7236!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'DS_ServiceInvoice1
        '
        Me.DS_ServiceInvoice1.DataSetName = "DS_ServiceInvoice"
        Me.DS_ServiceInvoice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrPictureBox2, Me.TaxableValueLabel, Me.IGSTAmtLabel, Me.TotalLabel, Me.XrTable4, Me.XrTable1, Me.XrTable2, Me.XrLabel103, Me.XrLabel102, Me.XrLabel88, Me.XrLabel87, Me.XrLabel104, Me.XrLabel106, Me.XrLabel111, Me.XrLabel110, Me.XrLabel107, Me.XrLabel156, Me.XrLabel155, Me.XrLabel141, Me.XrLabel153, Me.XrLabel140, Me.XrLabel143, Me.XrLabel150, Me.XrLabel133, Me.XrLabel139, Me.XrLabel138, Me.XrLabel152, Me.XrLabel154, Me.XrLabel161, Me.XrLabel160, Me.XrLabel159, Me.XrLabel158, Me.XrLabel157, Me.XrLabel166, Me.XrLabel164, Me.XrLabel163, Me.XrLabel162})
        Me.GroupFooter2.HeightF = 375.2792!
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.StylePriority.UseBorders = False
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DiscountVal])")})
        Me.XrLabel27.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(480.8497!, 5.000078!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(49.99994!, 17.56259!)
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel27.Summary = XrSummary1
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel27.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox2.ImageSource"))
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(614.76!, 282.94!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(63.66998!, 63.11002!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox2.StylePriority.UseBorders = False
        Me.XrPictureBox2.Visible = False
        '
        'TaxableValueLabel
        '
        Me.TaxableValueLabel.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.TaxableValueLabel.CanGrow = False
        Me.TaxableValueLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TaxableValue])")})
        Me.TaxableValueLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.TaxableValueLabel.LocationFloat = New DevExpress.Utils.PointFloat(530.8496!, 5.000031!)
        Me.TaxableValueLabel.Name = "TaxableValueLabel"
        Me.TaxableValueLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TaxableValueLabel.SizeF = New System.Drawing.SizeF(60.00006!, 17.5626!)
        Me.TaxableValueLabel.StylePriority.UseBorders = False
        Me.TaxableValueLabel.StylePriority.UseFont = False
        Me.TaxableValueLabel.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.TaxableValueLabel.Summary = XrSummary2
        Me.TaxableValueLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TaxableValueLabel.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'IGSTAmtLabel
        '
        Me.IGSTAmtLabel.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.IGSTAmtLabel.CanGrow = False
        Me.IGSTAmtLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.IGSTAmtLabel.LocationFloat = New DevExpress.Utils.PointFloat(616.8496!, 4.999984!)
        Me.IGSTAmtLabel.Name = "IGSTAmtLabel"
        Me.IGSTAmtLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.IGSTAmtLabel.SizeF = New System.Drawing.SizeF(74.86707!, 17.5626!)
        Me.IGSTAmtLabel.StylePriority.UseBorders = False
        Me.IGSTAmtLabel.StylePriority.UseFont = False
        Me.IGSTAmtLabel.StylePriority.UseTextAlignment = False
        Me.IGSTAmtLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalLabel
        '
        Me.TotalLabel.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.TotalLabel.CanGrow = False
        Me.TotalLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalAmount])")})
        Me.TotalLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.TotalLabel.LocationFloat = New DevExpress.Utils.PointFloat(691.7167!, 4.999985!)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalLabel.SizeF = New System.Drawing.SizeF(86.28363!, 17.5626!)
        Me.TotalLabel.StylePriority.UseBorders = False
        Me.TotalLabel.StylePriority.UseFont = False
        Me.TotalLabel.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.TotalLabel.Summary = XrSummary3
        Me.TotalLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalLabel.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0.07284546!, 0.0000500679!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(777.9271!, 5.0!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell12, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell11, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.23688934326172R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell23.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UsePadding = False
        Me.XrTableCell23.Weight = 1.0426220946199942R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.Weight = 6.2480253783271076R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell10.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UsePadding = False
        Me.XrTableCell10.Weight = 1.8201415114551196R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell12.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.Weight = 1.0982627163718342R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell26.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell26.StylePriority.UseBorders = False
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UsePadding = False
        Me.XrTableCell26.Weight = 1.6501481532093973R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell27.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell27.StylePriority.UseBorders = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UsePadding = False
        Me.XrTableCell27.Weight = 2.1841704852465758R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell28.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UsePadding = False
        Me.XrTableCell28.Weight = 2.1841710516468353R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell29.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell29.StylePriority.UseBorders = False
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UsePadding = False
        Me.XrTableCell29.Weight = 1.2740995268205533R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell11.Multiline = True
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.Weight = 1.8201420218170177R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell30.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell30.StylePriority.UseBorders = False
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.StylePriority.UsePadding = False
        Me.XrTableCell30.Weight = 2.1841706661767639R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell31.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell31.StylePriority.UseBorders = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UsePadding = False
        Me.XrTableCell31.Weight = 0.946473053514929R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell32.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell32.StylePriority.UseBorders = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UsePadding = False
        Me.XrTableCell32.Weight = 2.7253717567983924R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell33.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell33.StylePriority.UseBorders = False
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UsePadding = False
        Me.XrTableCell33.Weight = 3.1409599676403062R
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.56264!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(300.5246!, 30.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.Text = "Taxable Value"
        Me.XrTableCell1.Weight = 0.999999999999995R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.Text = "IGST Rate"
        Me.XrTableCell2.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.Text = "IGST Amt"
        Me.XrTableCell3.Weight = 1.0R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.Weight = 1.0R
        '
        'XrTable2
        '
        Me.XrTable2.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(300.5246!, 22.56265!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow6})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(477.4756!, 100.0!)
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UsePadding = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.TotalGSTCell})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = " Packing / Courier"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 1.56190032958984R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.Text = "Total GST"
        Me.XrTableCell8.Weight = 1.6048267089284827R
        '
        'TotalGSTCell
        '
        Me.TotalGSTCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TotalGSTCell.Name = "TotalGSTCell"
        Me.TotalGSTCell.StylePriority.UseBorders = False
        Me.TotalGSTCell.StylePriority.UseTextAlignment = False
        Me.TotalGSTCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalGSTCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.TotalGSTCell.Weight = 1.6132760132394872R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.PackingChargeCell, Me.TaxableValLabel, Me.TaxableValueCell})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.Text = "Amount"
        Me.XrTableCell13.Weight = 0.714490051269531R
        '
        'PackingChargeCell
        '
        Me.PackingChargeCell.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PackingChargeCell.Name = "PackingChargeCell"
        Me.PackingChargeCell.StylePriority.UseBorders = False
        Me.PackingChargeCell.StylePriority.UseTextAlignment = False
        Me.PackingChargeCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PackingChargeCell.TextFormatString = "{0:f}"
        Me.PackingChargeCell.Weight = 0.847410278320312R
        '
        'TaxableValLabel
        '
        Me.TaxableValLabel.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TaxableValLabel.Name = "TaxableValLabel"
        Me.TaxableValLabel.StylePriority.UseBorders = False
        Me.TaxableValLabel.Text = "Sub Total"
        Me.TaxableValLabel.Weight = 1.6048257923950349R
        '
        'TaxableValueCell
        '
        Me.TaxableValueCell.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TaxableValueCell.Name = "TaxableValueCell"
        Me.TaxableValueCell.StylePriority.UseBorders = False
        Me.TaxableValueCell.StylePriority.UseTextAlignment = False
        Me.TaxableValueCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TaxableValueCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.TaxableValueCell.Weight = 1.613276929772945R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14, Me.PackingGSTCell, Me.XrTableCell16, Me.RoundOffCell})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.PIGSTRate]")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.TextFormatString = "(IGST {0}%)"
        Me.XrTableCell14.Weight = 0.714490051269531R
        '
        'PackingGSTCell
        '
        Me.PackingGSTCell.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PackingGSTCell.Name = "PackingGSTCell"
        Me.PackingGSTCell.StylePriority.UseBorders = False
        Me.PackingGSTCell.StylePriority.UseTextAlignment = False
        Me.PackingGSTCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PackingGSTCell.TextFormatString = "{0:f}"
        Me.PackingGSTCell.Weight = 0.847410278320313R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.Text = "Round Off"
        Me.XrTableCell16.Weight = 1.6048257917242899R
        '
        'RoundOffCell
        '
        Me.RoundOffCell.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.RoundOffCell.Name = "RoundOffCell"
        Me.RoundOffCell.StylePriority.UseBorders = False
        Me.RoundOffCell.StylePriority.UseTextAlignment = False
        Me.RoundOffCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.RoundOffCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.RoundOffCell.Weight = 1.61327693044368R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell18, Me.XrTableCell19, Me.GrandTotalLabel, Me.GrandTotalCell})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.Weight = 0.714491577148438R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.Weight = 0.847408752441406R
        '
        'GrandTotalLabel
        '
        Me.GrandTotalLabel.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.GrandTotalLabel.Multiline = True
        Me.GrandTotalLabel.Name = "GrandTotalLabel"
        Me.GrandTotalLabel.StylePriority.UseBorders = False
        Me.GrandTotalLabel.Text = "Grand Total"
        Me.GrandTotalLabel.Weight = 1.6048257923950351R
        '
        'GrandTotalCell
        '
        Me.GrandTotalCell.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.GrandTotalCell.Name = "GrandTotalCell"
        Me.GrandTotalCell.StylePriority.UseBorders = False
        Me.GrandTotalCell.StylePriority.UseTextAlignment = False
        Me.GrandTotalCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.GrandTotalCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.GrandTotalCell.Weight = 1.6132769297729348R
        '
        'XrLabel103
        '
        Me.XrLabel103.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel103.CanGrow = False
        Me.XrLabel103.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.TotalInWords]")})
        Me.XrLabel103.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel103.LocationFloat = New DevExpress.Utils.PointFloat(371.4488!, 139.3403!)
        Me.XrLabel103.Multiline = True
        Me.XrLabel103.Name = "XrLabel103"
        Me.XrLabel103.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel103.SizeF = New System.Drawing.SizeF(406.5514!, 36.05348!)
        Me.XrLabel103.StylePriority.UseBorders = False
        Me.XrLabel103.StylePriority.UseFont = False
        Me.XrLabel103.StylePriority.UseTextAlignment = False
        Me.XrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel102
        '
        Me.XrLabel102.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel102.CanGrow = False
        Me.XrLabel102.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel102.LocationFloat = New DevExpress.Utils.PointFloat(371.4489!, 122.5627!)
        Me.XrLabel102.Multiline = True
        Me.XrLabel102.Name = "XrLabel102"
        Me.XrLabel102.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel102.SizeF = New System.Drawing.SizeF(406.5513!, 16.77754!)
        Me.XrLabel102.StylePriority.UseBorders = False
        Me.XrLabel102.StylePriority.UseFont = False
        Me.XrLabel102.StylePriority.UseTextAlignment = False
        Me.XrLabel102.Text = "Total Invoice Amount in Words"
        Me.XrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel88
        '
        Me.XrLabel88.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel88.CanGrow = False
        Me.XrLabel88.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.TaxInWords]")})
        Me.XrLabel88.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel88.LocationFloat = New DevExpress.Utils.PointFloat(0!, 139.3402!)
        Me.XrLabel88.Multiline = True
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel88.SizeF = New System.Drawing.SizeF(371.449!, 36.05362!)
        Me.XrLabel88.StylePriority.UseBorders = False
        Me.XrLabel88.StylePriority.UseFont = False
        Me.XrLabel88.StylePriority.UseTextAlignment = False
        Me.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel87
        '
        Me.XrLabel87.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel87.CanGrow = False
        Me.XrLabel87.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(0!, 122.5627!)
        Me.XrLabel87.Multiline = True
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(371.449!, 16.77755!)
        Me.XrLabel87.StylePriority.UseBorders = False
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "Total GST Amount in Words"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel104
        '
        Me.XrLabel104.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel104.CanGrow = False
        Me.XrLabel104.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel104.LocationFloat = New DevExpress.Utils.PointFloat(0.007616149!, 175.3938!)
        Me.XrLabel104.Multiline = True
        Me.XrLabel104.Name = "XrLabel104"
        Me.XrLabel104.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel104.SizeF = New System.Drawing.SizeF(102.0833!, 16.77756!)
        Me.XrLabel104.StylePriority.UseBorders = False
        Me.XrLabel104.StylePriority.UseFont = False
        Me.XrLabel104.StylePriority.UseTextAlignment = False
        Me.XrLabel104.Text = "Remarks"
        Me.XrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel106
        '
        Me.XrLabel106.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel106.CanGrow = False
        Me.XrLabel106.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.Remarks]")})
        Me.XrLabel106.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel106.LocationFloat = New DevExpress.Utils.PointFloat(102.091!, 175.3938!)
        Me.XrLabel106.Multiline = True
        Me.XrLabel106.Name = "XrLabel106"
        Me.XrLabel106.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel106.SizeF = New System.Drawing.SizeF(675.9091!, 16.77754!)
        Me.XrLabel106.StylePriority.UseBorders = False
        Me.XrLabel106.StylePriority.UseFont = False
        Me.XrLabel106.StylePriority.UseTextAlignment = False
        Me.XrLabel106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel111
        '
        Me.XrLabel111.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel111.CanGrow = False
        Me.XrLabel111.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.GSTReverseCharge]")})
        Me.XrLabel111.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel111.LocationFloat = New DevExpress.Utils.PointFloat(672.8358!, 192.1713!)
        Me.XrLabel111.Multiline = True
        Me.XrLabel111.Name = "XrLabel111"
        Me.XrLabel111.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel111.SizeF = New System.Drawing.SizeF(105.1641!, 17.84901!)
        Me.XrLabel111.StylePriority.UseBorders = False
        Me.XrLabel111.StylePriority.UseFont = False
        Me.XrLabel111.StylePriority.UseTextAlignment = False
        Me.XrLabel111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel111.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel110
        '
        Me.XrLabel110.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel110.CanGrow = False
        Me.XrLabel110.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel110.LocationFloat = New DevExpress.Utils.PointFloat(515.6617!, 192.1713!)
        Me.XrLabel110.Multiline = True
        Me.XrLabel110.Name = "XrLabel110"
        Me.XrLabel110.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel110.SizeF = New System.Drawing.SizeF(156.7648!, 17.84904!)
        Me.XrLabel110.StylePriority.UseBorders = False
        Me.XrLabel110.StylePriority.UseFont = False
        Me.XrLabel110.StylePriority.UseTextAlignment = False
        Me.XrLabel110.Text = "GST Payable on Reverse Charge"
        Me.XrLabel110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel107
        '
        Me.XrLabel107.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel107.CanGrow = False
        Me.XrLabel107.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel107.LocationFloat = New DevExpress.Utils.PointFloat(0!, 192.1714!)
        Me.XrLabel107.Multiline = True
        Me.XrLabel107.Name = "XrLabel107"
        Me.XrLabel107.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel107.SizeF = New System.Drawing.SizeF(515.6617!, 17.56252!)
        Me.XrLabel107.StylePriority.UseBorders = False
        Me.XrLabel107.StylePriority.UseFont = False
        Me.XrLabel107.StylePriority.UseTextAlignment = False
        Me.XrLabel107.Text = "BANK DETAILS FOR NEFT/ RTGS PAYMENTS"
        Me.XrLabel107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel156
        '
        Me.XrLabel156.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel156.CanGrow = False
        Me.XrLabel156.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Underline)
        Me.XrLabel156.LocationFloat = New DevExpress.Utils.PointFloat(515.6619!, 210.0203!)
        Me.XrLabel156.Multiline = True
        Me.XrLabel156.Name = "XrLabel156"
        Me.XrLabel156.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel156.SizeF = New System.Drawing.SizeF(262.338!, 53.99994!)
        Me.XrLabel156.StylePriority.UseBorders = False
        Me.XrLabel156.StylePriority.UseFont = False
        Me.XrLabel156.StylePriority.UseTextAlignment = False
        Me.XrLabel156.Text = "Certified that the particulars given above are true"
        Me.XrLabel156.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel155
        '
        Me.XrLabel155.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel155.CanGrow = False
        Me.XrLabel155.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel155.LocationFloat = New DevExpress.Utils.PointFloat(277.6885!, 245.8769!)
        Me.XrLabel155.Multiline = True
        Me.XrLabel155.Name = "XrLabel155"
        Me.XrLabel155.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel155.SizeF = New System.Drawing.SizeF(237.9735!, 18.0!)
        Me.XrLabel155.StylePriority.UseBorders = False
        Me.XrLabel155.StylePriority.UseFont = False
        Me.XrLabel155.StylePriority.UseTextAlignment = False
        Me.XrLabel155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel141
        '
        Me.XrLabel141.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel141.CanGrow = False
        Me.XrLabel141.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel141.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 245.8769!)
        Me.XrLabel141.Multiline = True
        Me.XrLabel141.Name = "XrLabel141"
        Me.XrLabel141.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel141.SizeF = New System.Drawing.SizeF(177.6887!, 17.99998!)
        Me.XrLabel141.StylePriority.UseBorders = False
        Me.XrLabel141.StylePriority.UseFont = False
        Me.XrLabel141.StylePriority.UseTextAlignment = False
        Me.XrLabel141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel153
        '
        Me.XrLabel153.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel153.CanGrow = False
        Me.XrLabel153.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel153.LocationFloat = New DevExpress.Utils.PointFloat(0!, 245.8769!)
        Me.XrLabel153.Multiline = True
        Me.XrLabel153.Name = "XrLabel153"
        Me.XrLabel153.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel153.SizeF = New System.Drawing.SizeF(99.99994!, 17.99998!)
        Me.XrLabel153.StylePriority.UseBorders = False
        Me.XrLabel153.StylePriority.UseFont = False
        Me.XrLabel153.StylePriority.UseTextAlignment = False
        Me.XrLabel153.Text = "IFSC CODE          :"
        Me.XrLabel153.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel140
        '
        Me.XrLabel140.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel140.CanGrow = False
        Me.XrLabel140.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel140.LocationFloat = New DevExpress.Utils.PointFloat(367.6885!, 227.877!)
        Me.XrLabel140.Multiline = True
        Me.XrLabel140.Name = "XrLabel140"
        Me.XrLabel140.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel140.SizeF = New System.Drawing.SizeF(147.9734!, 17.99997!)
        Me.XrLabel140.StylePriority.UseBorders = False
        Me.XrLabel140.StylePriority.UseFont = False
        Me.XrLabel140.StylePriority.UseTextAlignment = False
        Me.XrLabel140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel143
        '
        Me.XrLabel143.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel143.CanGrow = False
        Me.XrLabel143.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel143.LocationFloat = New DevExpress.Utils.PointFloat(367.6885!, 209.877!)
        Me.XrLabel143.Multiline = True
        Me.XrLabel143.Name = "XrLabel143"
        Me.XrLabel143.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel143.SizeF = New System.Drawing.SizeF(147.9732!, 17.99997!)
        Me.XrLabel143.StylePriority.UseBorders = False
        Me.XrLabel143.StylePriority.UseFont = False
        Me.XrLabel143.StylePriority.UseTextAlignment = False
        Me.XrLabel143.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel150
        '
        Me.XrLabel150.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel150.CanGrow = False
        Me.XrLabel150.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel150.LocationFloat = New DevExpress.Utils.PointFloat(277.6885!, 227.877!)
        Me.XrLabel150.Multiline = True
        Me.XrLabel150.Name = "XrLabel150"
        Me.XrLabel150.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel150.SizeF = New System.Drawing.SizeF(89.99997!, 17.99997!)
        Me.XrLabel150.StylePriority.UseBorders = False
        Me.XrLabel150.StylePriority.UseFont = False
        Me.XrLabel150.StylePriority.UseTextAlignment = False
        Me.XrLabel150.Text = "MICR CODE    :"
        Me.XrLabel150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel133
        '
        Me.XrLabel133.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel133.CanGrow = False
        Me.XrLabel133.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel133.LocationFloat = New DevExpress.Utils.PointFloat(277.6885!, 209.877!)
        Me.XrLabel133.Multiline = True
        Me.XrLabel133.Name = "XrLabel133"
        Me.XrLabel133.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel133.SizeF = New System.Drawing.SizeF(90.0!, 17.99994!)
        Me.XrLabel133.StylePriority.UseBorders = False
        Me.XrLabel133.StylePriority.UseFont = False
        Me.XrLabel133.StylePriority.UseTextAlignment = False
        Me.XrLabel133.Text = "ACCOUNT NO:"
        Me.XrLabel133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel139
        '
        Me.XrLabel139.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel139.CanGrow = False
        Me.XrLabel139.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel139.LocationFloat = New DevExpress.Utils.PointFloat(99.99994!, 227.734!)
        Me.XrLabel139.Multiline = True
        Me.XrLabel139.Name = "XrLabel139"
        Me.XrLabel139.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel139.SizeF = New System.Drawing.SizeF(177.6886!, 18.14296!)
        Me.XrLabel139.StylePriority.UseBorders = False
        Me.XrLabel139.StylePriority.UseFont = False
        Me.XrLabel139.StylePriority.UseTextAlignment = False
        Me.XrLabel139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel138
        '
        Me.XrLabel138.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel138.CanGrow = False
        Me.XrLabel138.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel138.LocationFloat = New DevExpress.Utils.PointFloat(100.1749!, 209.7339!)
        Me.XrLabel138.Multiline = True
        Me.XrLabel138.Name = "XrLabel138"
        Me.XrLabel138.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel138.SizeF = New System.Drawing.SizeF(177.5137!, 17.99998!)
        Me.XrLabel138.StylePriority.UseBorders = False
        Me.XrLabel138.StylePriority.UseFont = False
        Me.XrLabel138.StylePriority.UseTextAlignment = False
        Me.XrLabel138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel152
        '
        Me.XrLabel152.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel152.CanGrow = False
        Me.XrLabel152.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel152.LocationFloat = New DevExpress.Utils.PointFloat(0!, 227.7339!)
        Me.XrLabel152.Multiline = True
        Me.XrLabel152.Name = "XrLabel152"
        Me.XrLabel152.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel152.SizeF = New System.Drawing.SizeF(100.0!, 18.14307!)
        Me.XrLabel152.StylePriority.UseBorders = False
        Me.XrLabel152.StylePriority.UseFont = False
        Me.XrLabel152.StylePriority.UseTextAlignment = False
        Me.XrLabel152.Text = "BRANCH NAME :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel152.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel154
        '
        Me.XrLabel154.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel154.CanGrow = False
        Me.XrLabel154.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel154.LocationFloat = New DevExpress.Utils.PointFloat(0.007633185!, 209.7339!)
        Me.XrLabel154.Multiline = True
        Me.XrLabel154.Name = "XrLabel154"
        Me.XrLabel154.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel154.SizeF = New System.Drawing.SizeF(100.1672!, 18.0!)
        Me.XrLabel154.StylePriority.UseBorders = False
        Me.XrLabel154.StylePriority.UseFont = False
        Me.XrLabel154.StylePriority.UseTextAlignment = False
        Me.XrLabel154.Text = "BANK NAME      :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel154.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel161
        '
        Me.XrLabel161.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel161.CanGrow = False
        Me.XrLabel161.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.XrLabel161.LocationFloat = New DevExpress.Utils.PointFloat(515.6616!, 348.8252!)
        Me.XrLabel161.Multiline = True
        Me.XrLabel161.Name = "XrLabel161"
        Me.XrLabel161.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel161.SizeF = New System.Drawing.SizeF(262.3383!, 18.60663!)
        Me.XrLabel161.StylePriority.UseBorders = False
        Me.XrLabel161.StylePriority.UseFont = False
        Me.XrLabel161.StylePriority.UseTextAlignment = False
        Me.XrLabel161.Text = "(Authorised Signatory)"
        Me.XrLabel161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel160
        '
        Me.XrLabel160.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel160.CanGrow = False
        Me.XrLabel160.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!)
        Me.XrLabel160.LocationFloat = New DevExpress.Utils.PointFloat(0!, 280.7955!)
        Me.XrLabel160.Multiline = True
        Me.XrLabel160.Name = "XrLabel160"
        Me.XrLabel160.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.XrLabel160.SizeF = New System.Drawing.SizeF(515.6619!, 86.63643!)
        Me.XrLabel160.StylePriority.UseBorders = False
        Me.XrLabel160.StylePriority.UseFont = False
        Me.XrLabel160.StylePriority.UsePadding = False
        Me.XrLabel160.StylePriority.UseTextAlignment = False
        Me.XrLabel160.Text = resources.GetString("XrLabel160.Text")
        Me.XrLabel160.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel159
        '
        Me.XrLabel159.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel159.CanGrow = False
        Me.XrLabel159.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel159.LocationFloat = New DevExpress.Utils.PointFloat(515.6616!, 264.0202!)
        Me.XrLabel159.Multiline = True
        Me.XrLabel159.Name = "XrLabel159"
        Me.XrLabel159.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel159.SizeF = New System.Drawing.SizeF(262.3383!, 16.9185!)
        Me.XrLabel159.StylePriority.UseBorders = False
        Me.XrLabel159.StylePriority.UseFont = False
        Me.XrLabel159.StylePriority.UseTextAlignment = False
        Me.XrLabel159.Text = "FOR PREEVOL TECHNICS,"
        Me.XrLabel159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel158
        '
        Me.XrLabel158.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel158.CanGrow = False
        Me.XrLabel158.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.XrLabel158.LocationFloat = New DevExpress.Utils.PointFloat(515.6617!, 280.9388!)
        Me.XrLabel158.Multiline = True
        Me.XrLabel158.Name = "XrLabel158"
        Me.XrLabel158.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel158.SizeF = New System.Drawing.SizeF(262.3383!, 67.88643!)
        Me.XrLabel158.StylePriority.UseBorders = False
        Me.XrLabel158.StylePriority.UseFont = False
        Me.XrLabel158.StylePriority.UseTextAlignment = False
        Me.XrLabel158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel157
        '
        Me.XrLabel157.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel157.CanGrow = False
        Me.XrLabel157.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Underline), DevExpress.Drawing.DXFontStyle))
        Me.XrLabel157.LocationFloat = New DevExpress.Utils.PointFloat(0.007603446!, 264.0204!)
        Me.XrLabel157.Multiline = True
        Me.XrLabel157.Name = "XrLabel157"
        Me.XrLabel157.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel157.SizeF = New System.Drawing.SizeF(515.654!, 16.77505!)
        Me.XrLabel157.StylePriority.UseBorders = False
        Me.XrLabel157.StylePriority.UseFont = False
        Me.XrLabel157.StylePriority.UseTextAlignment = False
        Me.XrLabel157.Text = "TERMS & CONDITIONS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel166
        '
        Me.XrLabel166.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel166.CanGrow = False
        Me.XrLabel166.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel166.LocationFloat = New DevExpress.Utils.PointFloat(590.8497!, 5.000031!)
        Me.XrLabel166.Multiline = True
        Me.XrLabel166.Name = "XrLabel166"
        Me.XrLabel166.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel166.SizeF = New System.Drawing.SizeF(25.99994!, 17.56264!)
        Me.XrLabel166.StylePriority.UseBorders = False
        Me.XrLabel166.StylePriority.UseFont = False
        Me.XrLabel166.StylePriority.UseTextAlignment = False
        Me.XrLabel166.Text = "-"
        Me.XrLabel166.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel164
        '
        Me.XrLabel164.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel164.CanGrow = False
        Me.XrLabel164.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel164.LocationFloat = New DevExpress.Utils.PointFloat(325.8496!, 5.000031!)
        Me.XrLabel164.Multiline = True
        Me.XrLabel164.Name = "XrLabel164"
        Me.XrLabel164.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel164.SizeF = New System.Drawing.SizeF(155.0!, 17.56264!)
        Me.XrLabel164.StylePriority.UseBorders = False
        Me.XrLabel164.StylePriority.UseFont = False
        Me.XrLabel164.StylePriority.UseTextAlignment = False
        Me.XrLabel164.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel163
        '
        Me.XrLabel163.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel163.CanGrow = False
        Me.XrLabel163.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Qty])")})
        Me.XrLabel163.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel163.LocationFloat = New DevExpress.Utils.PointFloat(280.5194!, 5.000031!)
        Me.XrLabel163.Multiline = True
        Me.XrLabel163.Name = "XrLabel163"
        Me.XrLabel163.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel163.SizeF = New System.Drawing.SizeF(45.33023!, 17.56259!)
        Me.XrLabel163.StylePriority.UseBorders = False
        Me.XrLabel163.StylePriority.UseFont = False
        Me.XrLabel163.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel163.Summary = XrSummary4
        Me.XrLabel163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel163.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel162
        '
        Me.XrLabel162.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel162.CanGrow = False
        Me.XrLabel162.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel162.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.000031!)
        Me.XrLabel162.Multiline = True
        Me.XrLabel162.Name = "XrLabel162"
        Me.XrLabel162.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel162.SizeF = New System.Drawing.SizeF(280.5194!, 17.56264!)
        Me.XrLabel162.StylePriority.UseBorders = False
        Me.XrLabel162.StylePriority.UseFont = False
        Me.XrLabel162.StylePriority.UseTextAlignment = False
        Me.XrLabel162.Text = "Total"
        Me.XrLabel162.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine4.EndBand = Me.GroupFooter2
        Me.XrCrossBandLine4.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 122.5627!)
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.GroupFooter2
        Me.XrCrossBandLine4.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 52.56262!)
        Me.XrCrossBandLine4.WidthF = 1.116071!
        '
        'DT_ServiceInvoiceTableAdapter
        '
        Me.DT_ServiceInvoiceTableAdapter.ClearBeforeFill = True
        '
        'DS_ServiceInvoice2
        '
        Me.DS_ServiceInvoice2.DataSetName = "DS_ServiceInvoice"
        Me.DS_ServiceInvoice2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel92, Me.XrLabel85, Me.XrLabel84, Me.XrLabel82, Me.XrLabel81, Me.XrLabel80, Me.XrLabel79, Me.XrLabel30, Me.XrLabel23, Me.XrLabel31, Me.XrLabel32, Me.XrLabel33, Me.XrLabel26, Me.XrLabel83, Me.XrLabelMSME, Me.XrPictureBox3, Me.XrLabelIrn, Me.XrLabelAck, Me.XrLabelISO, Me.XrLabel24, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLabel25, Me.XrLabel44, Me.XrLabel45, Me.XrLabel46, Me.XrLabel47, Me.XrLabel14, Me.XrLabel4, Me.XrLabel6, Me.XrLabel7, Me.XrLabel11, Me.XrLabel54, Me.XrLabel55, Me.XrLabel56, Me.XrLabel57, Me.XrLabel58, Me.XrLabel61, Me.XrLabel62, Me.XrLabel63, Me.XrLabel64, Me.XrLabel66, Me.XrLabel65, Me.XrLabel67, Me.XrLabel69, Me.XrLabel71, Me.XrLabel72, Me.XrLabel73, Me.XrLabel74, Me.XrLabel75, Me.XrLabel76, Me.XrLabel77, Me.XrLabel78, Me.XrLabel93, Me.XrLabel117, Me.XrLabel118, Me.XrLabel119, Me.XrLabel120, Me.XrLabel121, Me.XrLabel126, Me.XrLabel127, Me.XrPictureBox1, Me.XrLabel91, Me.XrLabel29, Me.XrLabel9, Me.XrLabel59, Me.XrLabel90, Me.XrLabel89, Me.XrLabel18, Me.XrLabel16, Me.XrLabel60, Me.XrLabel70, Me.XrLabel10, Me.XrLabel8, Me.XrLabel15, Me.XrLabel12, Me.XrLabel1, Me.XrLabel17, Me.XrLabel53, Me.XrLabel49, Me.XrLabel52, Me.XrLabel50, Me.XrLabel123, Me.XrLabel122, Me.XrLabel43, Me.XrLabel36, Me.XrLabel19, Me.XrLabel5, Me.XrLabel3, Me.XrLabel2, Me.XrLabel34, Me.XrLabel13})
        Me.GroupHeader1.HeightF = 430.0143!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel92
        '
        Me.XrLabel92.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel92.CanGrow = False
        Me.XrLabel92.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel92.LocationFloat = New DevExpress.Utils.PointFloat(691.7167!, 389.9289!)
        Me.XrLabel92.Multiline = True
        Me.XrLabel92.Name = "XrLabel92"
        Me.XrLabel92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel92.SizeF = New System.Drawing.SizeF(86.28375!, 40.00003!)
        Me.XrLabel92.StylePriority.UseBorders = False
        Me.XrLabel92.StylePriority.UseFont = False
        Me.XrLabel92.StylePriority.UseTextAlignment = False
        Me.XrLabel92.Text = "Total Amount"
        Me.XrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel85
        '
        Me.XrLabel85.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel85.CanGrow = False
        Me.XrLabel85.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel85.LocationFloat = New DevExpress.Utils.PointFloat(616.8497!, 408.9073!)
        Me.XrLabel85.Multiline = True
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel85.SizeF = New System.Drawing.SizeF(74.867!, 20.96002!)
        Me.XrLabel85.StylePriority.UseBorders = False
        Me.XrLabel85.StylePriority.UseFont = False
        Me.XrLabel85.StylePriority.UseTextAlignment = False
        Me.XrLabel85.Text = "Amount"
        Me.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel84
        '
        Me.XrLabel84.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel84.CanGrow = False
        Me.XrLabel84.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel84.LocationFloat = New DevExpress.Utils.PointFloat(590.8497!, 408.9073!)
        Me.XrLabel84.Multiline = True
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel84.SizeF = New System.Drawing.SizeF(26.0!, 20.96!)
        Me.XrLabel84.StylePriority.UseBorders = False
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        Me.XrLabel84.Text = "Rate"
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel82
        '
        Me.XrLabel82.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel82.CanGrow = False
        Me.XrLabel82.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(530.8496!, 389.8643!)
        Me.XrLabel82.Multiline = True
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(60.0!, 40.15!)
        Me.XrLabel82.StylePriority.UseBorders = False
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        Me.XrLabel82.Text = "Taxable Value"
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel81
        '
        Me.XrLabel81.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel81.CanGrow = False
        Me.XrLabel81.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel81.LocationFloat = New DevExpress.Utils.PointFloat(445.8496!, 389.9289!)
        Me.XrLabel81.Multiline = True
        Me.XrLabel81.Name = "XrLabel81"
        Me.XrLabel81.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel81.SizeF = New System.Drawing.SizeF(35.0!, 40.0!)
        Me.XrLabel81.StylePriority.UseBorders = False
        Me.XrLabel81.StylePriority.UseFont = False
        Me.XrLabel81.StylePriority.UseTextAlignment = False
        Me.XrLabel81.Text = "Dis.(%)"
        Me.XrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel80
        '
        Me.XrLabel80.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel80.CanGrow = False
        Me.XrLabel80.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(250.3497!, 389.8644!)
        Me.XrLabel80.Multiline = True
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(30.0!, 40.0!)
        Me.XrLabel80.StylePriority.UseBorders = False
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.StylePriority.UseTextAlignment = False
        Me.XrLabel80.Text = "UOM"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel79
        '
        Me.XrLabel79.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel79.CanGrow = False
        Me.XrLabel79.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(200.3497!, 389.8644!)
        Me.XrLabel79.Multiline = True
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel79.SizeF = New System.Drawing.SizeF(50.0!, 40.0!)
        Me.XrLabel79.StylePriority.UseBorders = False
        Me.XrLabel79.StylePriority.UseFont = False
        Me.XrLabel79.StylePriority.UseTextAlignment = False
        Me.XrLabel79.Text = "HSN/SAC"
        Me.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.CanGrow = False
        Me.XrLabel30.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(30.34973!, 389.8643!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(170.0!, 40.0!)
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Description"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(0.349723!, 389.8643!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(30.0!, 40.0!)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Sr. No"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel31.CanGrow = False
        Me.XrLabel31.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(280.3496!, 389.8643!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(45.5!, 40.0!)
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Qty"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.CanGrow = False
        Me.XrLabel32.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(325.8496!, 389.8643!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(60.0!, 40.0!)
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Rate"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.CanGrow = False
        Me.XrLabel33.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(385.8496!, 389.8643!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(60.0!, 40.0!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Amount"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel26
        '
        Me.XrLabel26.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel26.CanGrow = False
        Me.XrLabel26.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(480.8497!, 389.9289!)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(50.0!, 40.0!)
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "Dis." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Val"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel83
        '
        Me.XrLabel83.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel83.CanGrow = False
        Me.XrLabel83.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel83.LocationFloat = New DevExpress.Utils.PointFloat(590.8497!, 389.8643!)
        Me.XrLabel83.Multiline = True
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel83.SizeF = New System.Drawing.SizeF(100.867!, 19.04001!)
        Me.XrLabel83.StylePriority.UseBorders = False
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        Me.XrLabel83.Text = "IGST"
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabelMSME
        '
        Me.XrLabelMSME.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabelMSME.CanGrow = False
        Me.XrLabelMSME.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabelMSME.LocationFloat = New DevExpress.Utils.PointFloat(0!, 131.7501!)
        Me.XrLabelMSME.Multiline = True
        Me.XrLabelMSME.Name = "XrLabelMSME"
        Me.XrLabelMSME.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelMSME.SizeF = New System.Drawing.SizeF(262.4125!, 20.83311!)
        Me.XrLabelMSME.StylePriority.UseBorders = False
        Me.XrLabelMSME.StylePriority.UseFont = False
        Me.XrLabelMSME.StylePriority.UseTextAlignment = False
        Me.XrLabelMSME.Text = "MSME Registration No: UDYAM-GJ-01-0008103"
        Me.XrLabelMSME.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.BorderColor = System.Drawing.Color.Black
        Me.XrPictureBox3.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(687.493!, 0!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(90.23047!, 85.7502!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox3.StylePriority.UseBorderColor = False
        Me.XrPictureBox3.StylePriority.UseBorders = False
        '
        'XrLabelIrn
        '
        Me.XrLabelIrn.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabelIrn.CanGrow = False
        Me.XrLabelIrn.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabelIrn.LocationFloat = New DevExpress.Utils.PointFloat(0!, 85.75039!)
        Me.XrLabelIrn.Multiline = True
        Me.XrLabelIrn.Name = "XrLabelIrn"
        Me.XrLabelIrn.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelIrn.SizeF = New System.Drawing.SizeF(777.99!, 15.0!)
        Me.XrLabelIrn.StylePriority.UseBorders = False
        Me.XrLabelIrn.StylePriority.UseFont = False
        Me.XrLabelIrn.StylePriority.UseTextAlignment = False
        Me.XrLabelIrn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelAck
        '
        Me.XrLabelAck.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabelAck.CanGrow = False
        Me.XrLabelAck.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabelAck.LocationFloat = New DevExpress.Utils.PointFloat(0!, 100.7504!)
        Me.XrLabelAck.Multiline = True
        Me.XrLabelAck.Name = "XrLabelAck"
        Me.XrLabelAck.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAck.SizeF = New System.Drawing.SizeF(777.99!, 15.0!)
        Me.XrLabelAck.StylePriority.UseBorders = False
        Me.XrLabelAck.StylePriority.UseFont = False
        Me.XrLabelAck.StylePriority.UseTextAlignment = False
        Me.XrLabelAck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelISO
        '
        Me.XrLabelISO.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabelISO.CanGrow = False
        Me.XrLabelISO.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic), DevExpress.Drawing.DXFontStyle), DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabelISO.LocationFloat = New DevExpress.Utils.PointFloat(262.4125!, 131.7501!)
        Me.XrLabelISO.Multiline = True
        Me.XrLabelISO.Name = "XrLabelISO"
        Me.XrLabelISO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelISO.SizeF = New System.Drawing.SizeF(333.6419!, 20.83308!)
        Me.XrLabelISO.StylePriority.UseBorders = False
        Me.XrLabelISO.StylePriority.UseFont = False
        Me.XrLabelISO.StylePriority.UseTextAlignment = False
        Me.XrLabelISO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel24.CanGrow = False
        Me.XrLabel24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ARNDate]")})
        Me.XrLabel24.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(278.1034!, 241.7293!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(112.9571!, 18.60442!)
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel24.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(237.1033!, 241.7294!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(40.99998!, 18.6044!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Date :"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ARNNo]")})
        Me.XrLabel21.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(77.41489!, 241.7293!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(159.6884!, 18.60451!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(0.2768119!, 241.7294!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(77.13806!, 18.60428!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "ARN No.   : "
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel25.CanGrow = False
        Me.XrLabel25.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(391.0948!, 260.4793!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(386.8713!, 18.60423!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel44
        '
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel44.CanGrow = False
        Me.XrLabel44.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(0.2844413!, 204.5211!)
        Me.XrLabel44.Multiline = True
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(77.13043!, 18.60428!)
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "Invoice No.   : "
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel45
        '
        Me.XrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel45.CanGrow = False
        Me.XrLabel45.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(0.2844413!, 223.1254!)
        Me.XrLabel45.Multiline = True
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(77.13043!, 18.60428!)
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "Supply From :"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel46
        '
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel46.CanGrow = False
        Me.XrLabel46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceNo]")})
        Me.XrLabel46.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(77.41489!, 204.6668!)
        Me.XrLabel46.Multiline = True
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(161.9743!, 18.45854!)
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel47
        '
        Me.XrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel47.CanGrow = False
        Me.XrLabel47.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(77.41489!, 223.1252!)
        Me.XrLabel47.Multiline = True
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(313.6457!, 18.60428!)
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(625.5062!, 131.7501!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(152.4941!, 54.16653!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Original for Receipant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Duplicate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Triplicate "
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.2768119!, 260.3338!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(77.13807!, 18.75!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "State              :"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(77.41489!, 260.3336!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(194.9668!, 18.75!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(272.3817!, 260.3338!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(69.0!, 18.74997!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "State Code :"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(341.3817!, 260.3338!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(49.67883!, 18.75!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel54
        '
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel54.CanGrow = False
        Me.XrLabel54.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(0.2844413!, 185.9165!)
        Me.XrLabel54.Multiline = True
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(77.13045!, 18.60443!)
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "Challan No.   :"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.CanGrow = False
        Me.XrLabel55.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(0.2768119!, 279.4384!)
        Me.XrLabel55.Multiline = True
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(390.7837!, 18.3129!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Details Of Receiver | Billed to :"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel56
        '
        Me.XrLabel56.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel56.CanGrow = False
        Me.XrLabel56.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(391.0605!, 279.0838!)
        Me.XrLabel56.Multiline = True
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(386.9056!, 18.31287!)
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "Details Of Consignee | Shipped to :"
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel57
        '
        Me.XrLabel57.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel57.CanGrow = False
        Me.XrLabel57.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(0.2768119!, 297.7513!)
        Me.XrLabel57.Multiline = True
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(53.0!, 18.6!)
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "Name     : "
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel58
        '
        Me.XrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel58.CanGrow = False
        Me.XrLabel58.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ReceiverName]")})
        Me.XrLabel58.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(53.27682!, 297.7513!)
        Me.XrLabel58.Multiline = True
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(337.7836!, 18.60431!)
        Me.XrLabel58.StylePriority.UseBorders = False
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel61
        '
        Me.XrLabel61.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel61.CanGrow = False
        Me.XrLabel61.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(0.2768119!, 353.0933!)
        Me.XrLabel61.Multiline = True
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(52.99237!, 18.60428!)
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "GSTIN    : "
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel62
        '
        Me.XrLabel62.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel62.CanGrow = False
        Me.XrLabel62.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ReceiverGSTIN]")})
        Me.XrLabel62.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(53.27682!, 353.0933!)
        Me.XrLabel62.Multiline = True
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(195.7378!, 17.95779!)
        Me.XrLabel62.StylePriority.UseBorders = False
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel63
        '
        Me.XrLabel63.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel63.CanGrow = False
        Me.XrLabel63.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(0.2768119!, 371.6976!)
        Me.XrLabel63.Multiline = True
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(53.0!, 18.16675!)
        Me.XrLabel63.StylePriority.UseBorders = False
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        Me.XrLabel63.Text = "State      : "
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel64
        '
        Me.XrLabel64.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel64.CanGrow = False
        Me.XrLabel64.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ReceiverState]")})
        Me.XrLabel64.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(53.27682!, 371.6976!)
        Me.XrLabel64.Multiline = True
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(195.7378!, 18.16675!)
        Me.XrLabel64.StylePriority.UseBorders = False
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.StylePriority.UseTextAlignment = False
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel66
        '
        Me.XrLabel66.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel66.CanGrow = False
        Me.XrLabel66.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(249.0146!, 371.6976!)
        Me.XrLabel66.Multiline = True
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(68.0!, 18.16672!)
        Me.XrLabel66.StylePriority.UseBorders = False
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "State Code :"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel65
        '
        Me.XrLabel65.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel65.CanGrow = False
        Me.XrLabel65.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ReceiverStateCode]")})
        Me.XrLabel65.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(317.0146!, 371.6976!)
        Me.XrLabel65.Multiline = True
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(74.0459!, 18.16675!)
        Me.XrLabel65.StylePriority.UseBorders = False
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel67
        '
        Me.XrLabel67.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel67.CanGrow = False
        Me.XrLabel67.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(391.0948!, 297.3967!)
        Me.XrLabel67.Multiline = True
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(51.9657!, 18.60001!)
        Me.XrLabel67.StylePriority.UseBorders = False
        Me.XrLabel67.StylePriority.UseFont = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "Name     : "
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel69
        '
        Me.XrLabel69.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel69.CanGrow = False
        Me.XrLabel69.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ConsigneeName]")})
        Me.XrLabel69.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel69.LocationFloat = New DevExpress.Utils.PointFloat(443.0605!, 297.3967!)
        Me.XrLabel69.Multiline = True
        Me.XrLabel69.Name = "XrLabel69"
        Me.XrLabel69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel69.SizeF = New System.Drawing.SizeF(334.9056!, 18.60428!)
        Me.XrLabel69.StylePriority.UseBorders = False
        Me.XrLabel69.StylePriority.UseFont = False
        Me.XrLabel69.StylePriority.UseTextAlignment = False
        Me.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel71
        '
        Me.XrLabel71.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel71.CanGrow = False
        Me.XrLabel71.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel71.LocationFloat = New DevExpress.Utils.PointFloat(391.0946!, 352.5927!)
        Me.XrLabel71.Multiline = True
        Me.XrLabel71.Name = "XrLabel71"
        Me.XrLabel71.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel71.SizeF = New System.Drawing.SizeF(51.966!, 19.10483!)
        Me.XrLabel71.StylePriority.UseBorders = False
        Me.XrLabel71.StylePriority.UseFont = False
        Me.XrLabel71.StylePriority.UseTextAlignment = False
        Me.XrLabel71.Text = "GSTIN    : "
        Me.XrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel72
        '
        Me.XrLabel72.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel72.CanGrow = False
        Me.XrLabel72.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ConsigneeGSTIN]")})
        Me.XrLabel72.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel72.LocationFloat = New DevExpress.Utils.PointFloat(444.0263!, 352.5928!)
        Me.XrLabel72.Multiline = True
        Me.XrLabel72.Name = "XrLabel72"
        Me.XrLabel72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel72.SizeF = New System.Drawing.SizeF(190.894!, 18.45865!)
        Me.XrLabel72.StylePriority.UseBorders = False
        Me.XrLabel72.StylePriority.UseFont = False
        Me.XrLabel72.StylePriority.UseTextAlignment = False
        Me.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel73
        '
        Me.XrLabel73.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel73.CanGrow = False
        Me.XrLabel73.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel73.LocationFloat = New DevExpress.Utils.PointFloat(391.0948!, 371.6976!)
        Me.XrLabel73.Multiline = True
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel73.SizeF = New System.Drawing.SizeF(51.9657!, 18.16669!)
        Me.XrLabel73.StylePriority.UseBorders = False
        Me.XrLabel73.StylePriority.UseFont = False
        Me.XrLabel73.StylePriority.UseTextAlignment = False
        Me.XrLabel73.Text = "State      : "
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel74
        '
        Me.XrLabel74.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel74.CanGrow = False
        Me.XrLabel74.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel74.LocationFloat = New DevExpress.Utils.PointFloat(634.9202!, 371.0511!)
        Me.XrLabel74.Multiline = True
        Me.XrLabel74.Name = "XrLabel74"
        Me.XrLabel74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel74.SizeF = New System.Drawing.SizeF(69.0!, 18.81332!)
        Me.XrLabel74.StylePriority.UseBorders = False
        Me.XrLabel74.StylePriority.UseFont = False
        Me.XrLabel74.StylePriority.UseTextAlignment = False
        Me.XrLabel74.Text = "State Code :"
        Me.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel75
        '
        Me.XrLabel75.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel75.CanGrow = False
        Me.XrLabel75.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ConsigneeStateCode]")})
        Me.XrLabel75.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel75.LocationFloat = New DevExpress.Utils.PointFloat(703.9204!, 371.0516!)
        Me.XrLabel75.Multiline = True
        Me.XrLabel75.Name = "XrLabel75"
        Me.XrLabel75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel75.SizeF = New System.Drawing.SizeF(74.04578!, 18.81287!)
        Me.XrLabel75.StylePriority.UseBorders = False
        Me.XrLabel75.StylePriority.UseFont = False
        Me.XrLabel75.StylePriority.UseTextAlignment = False
        Me.XrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel76
        '
        Me.XrLabel76.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel76.CanGrow = False
        Me.XrLabel76.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel76.LocationFloat = New DevExpress.Utils.PointFloat(596.0538!, 131.7501!)
        Me.XrLabel76.Multiline = True
        Me.XrLabel76.Name = "XrLabel76"
        Me.XrLabel76.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel76.SizeF = New System.Drawing.SizeF(29.2998!, 20.91678!)
        Me.XrLabel76.StylePriority.UseBorders = False
        Me.XrLabel76.StylePriority.UseFont = False
        Me.XrLabel76.StylePriority.UseTextAlignment = False
        Me.XrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel77
        '
        Me.XrLabel77.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel77.CanGrow = False
        Me.XrLabel77.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel77.LocationFloat = New DevExpress.Utils.PointFloat(596.0538!, 152.6669!)
        Me.XrLabel77.Multiline = True
        Me.XrLabel77.Name = "XrLabel77"
        Me.XrLabel77.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel77.SizeF = New System.Drawing.SizeF(29.3562!, 16.00005!)
        Me.XrLabel77.StylePriority.UseBorders = False
        Me.XrLabel77.StylePriority.UseFont = False
        Me.XrLabel77.StylePriority.UseTextAlignment = False
        Me.XrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel78
        '
        Me.XrLabel78.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel78.CanGrow = False
        Me.XrLabel78.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel78.LocationFloat = New DevExpress.Utils.PointFloat(596.0536!, 168.6669!)
        Me.XrLabel78.Multiline = True
        Me.XrLabel78.Name = "XrLabel78"
        Me.XrLabel78.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel78.SizeF = New System.Drawing.SizeF(29.45264!, 17.24969!)
        Me.XrLabel78.StylePriority.UseBorders = False
        Me.XrLabel78.StylePriority.UseFont = False
        Me.XrLabel78.StylePriority.UseTextAlignment = False
        Me.XrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel93
        '
        Me.XrLabel93.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel93.CanGrow = False
        Me.XrLabel93.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ConsigneeState]")})
        Me.XrLabel93.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel93.LocationFloat = New DevExpress.Utils.PointFloat(443.0604!, 371.0513!)
        Me.XrLabel93.Multiline = True
        Me.XrLabel93.Name = "XrLabel93"
        Me.XrLabel93.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel93.SizeF = New System.Drawing.SizeF(191.8599!, 18.81314!)
        Me.XrLabel93.StylePriority.UseBorders = False
        Me.XrLabel93.StylePriority.UseFont = False
        Me.XrLabel93.StylePriority.UseTextAlignment = False
        Me.XrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel117
        '
        Me.XrLabel117.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel117.CanGrow = False
        Me.XrLabel117.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChallanNo]")})
        Me.XrLabel117.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel117.LocationFloat = New DevExpress.Utils.PointFloat(77.41489!, 185.9165!)
        Me.XrLabel117.Multiline = True
        Me.XrLabel117.Name = "XrLabel117"
        Me.XrLabel117.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel117.SizeF = New System.Drawing.SizeF(161.9741!, 18.60428!)
        Me.XrLabel117.StylePriority.UseBorders = False
        Me.XrLabel117.StylePriority.UseFont = False
        Me.XrLabel117.StylePriority.UseTextAlignment = False
        Me.XrLabel117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel118
        '
        Me.XrLabel118.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel118.CanGrow = False
        Me.XrLabel118.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel118.LocationFloat = New DevExpress.Utils.PointFloat(239.3891!, 185.9165!)
        Me.XrLabel118.Multiline = True
        Me.XrLabel118.Name = "XrLabel118"
        Me.XrLabel118.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel118.SizeF = New System.Drawing.SizeF(40.99998!, 18.75023!)
        Me.XrLabel118.StylePriority.UseBorders = False
        Me.XrLabel118.StylePriority.UseFont = False
        Me.XrLabel118.StylePriority.UseTextAlignment = False
        Me.XrLabel118.Text = "Date :"
        Me.XrLabel118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel119
        '
        Me.XrLabel119.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel119.CanGrow = False
        Me.XrLabel119.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ChallanDate]")})
        Me.XrLabel119.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel119.LocationFloat = New DevExpress.Utils.PointFloat(280.3891!, 185.9165!)
        Me.XrLabel119.Multiline = True
        Me.XrLabel119.Name = "XrLabel119"
        Me.XrLabel119.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel119.SizeF = New System.Drawing.SizeF(110.679!, 18.89603!)
        Me.XrLabel119.StylePriority.UseBorders = False
        Me.XrLabel119.StylePriority.UseFont = False
        Me.XrLabel119.StylePriority.UseTextAlignment = False
        Me.XrLabel119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel119.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel120
        '
        Me.XrLabel120.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel120.CanGrow = False
        Me.XrLabel120.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel120.LocationFloat = New DevExpress.Utils.PointFloat(239.5194!, 204.8126!)
        Me.XrLabel120.Multiline = True
        Me.XrLabel120.Name = "XrLabel120"
        Me.XrLabel120.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel120.SizeF = New System.Drawing.SizeF(41.0!, 18.31281!)
        Me.XrLabel120.StylePriority.UseBorders = False
        Me.XrLabel120.StylePriority.UseFont = False
        Me.XrLabel120.StylePriority.UseTextAlignment = False
        Me.XrLabel120.Text = "Date :"
        Me.XrLabel120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel121
        '
        Me.XrLabel121.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel121.CanGrow = False
        Me.XrLabel121.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.InvoiceDate]")})
        Me.XrLabel121.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel121.LocationFloat = New DevExpress.Utils.PointFloat(280.5194!, 204.8126!)
        Me.XrLabel121.Multiline = True
        Me.XrLabel121.Name = "XrLabel121"
        Me.XrLabel121.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel121.SizeF = New System.Drawing.SizeF(110.5412!, 18.31281!)
        Me.XrLabel121.StylePriority.UseBorders = False
        Me.XrLabel121.StylePriority.UseFont = False
        Me.XrLabel121.StylePriority.UseTextAlignment = False
        Me.XrLabel121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel121.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel126
        '
        Me.XrLabel126.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel126.CanGrow = False
        Me.XrLabel126.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel126.LocationFloat = New DevExpress.Utils.PointFloat(0.2768119!, 316.3557!)
        Me.XrLabel126.Multiline = True
        Me.XrLabel126.Name = "XrLabel126"
        Me.XrLabel126.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel126.SizeF = New System.Drawing.SizeF(53.0!, 18.60428!)
        Me.XrLabel126.StylePriority.UseBorders = False
        Me.XrLabel126.StylePriority.UseFont = False
        Me.XrLabel126.StylePriority.UseTextAlignment = False
        Me.XrLabel126.Text = "Address : "
        Me.XrLabel126.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel127
        '
        Me.XrLabel127.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel127.CanGrow = False
        Me.XrLabel127.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel127.LocationFloat = New DevExpress.Utils.PointFloat(391.0948!, 316.0009!)
        Me.XrLabel127.Multiline = True
        Me.XrLabel127.Name = "XrLabel127"
        Me.XrLabel127.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel127.SizeF = New System.Drawing.SizeF(51.96579!, 18.60428!)
        Me.XrLabel127.StylePriority.UseBorders = False
        Me.XrLabel127.StylePriority.UseFont = False
        Me.XrLabel127.StylePriority.UseTextAlignment = False
        Me.XrLabel127.Text = "Address : "
        Me.XrLabel127.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.007616845!, 0.0002175046!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(88.0!, 85.75018!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox1.StylePriority.UseBorders = False
        '
        'XrLabel91
        '
        Me.XrLabel91.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel91.CanGrow = False
        Me.XrLabel91.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel91.LocationFloat = New DevExpress.Utils.PointFloat(88.00763!, 70.00042!)
        Me.XrLabel91.Multiline = True
        Me.XrLabel91.Name = "XrLabel91"
        Me.XrLabel91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel91.SizeF = New System.Drawing.SizeF(599.4856!, 15.74998!)
        Me.XrLabel91.StylePriority.UseBorders = False
        Me.XrLabel91.StylePriority.UseFont = False
        Me.XrLabel91.StylePriority.UseTextAlignment = False
        Me.XrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel29.CanGrow = False
        Me.XrLabel29.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(88.00763!, 52.00041!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(599.4856!, 18.00001!)
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(88.28326!, 34.00041!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(599.2098!, 18.0!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel59
        '
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel59.CanGrow = False
        Me.XrLabel59.Font = New DevExpress.Drawing.DXFont("Calibri", 20.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(88.28326!, 0.0002175046!)
        Me.XrLabel59.Multiline = True
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(599.2098!, 34.00019!)
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel90
        '
        Me.XrLabel90.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel90.CanGrow = False
        Me.XrLabel90.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel90.LocationFloat = New DevExpress.Utils.PointFloat(682.2771!, 115.7503!)
        Me.XrLabel90.Multiline = True
        Me.XrLabel90.Name = "XrLabel90"
        Me.XrLabel90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel90.SizeF = New System.Drawing.SizeF(95.72333!, 16.00001!)
        Me.XrLabel90.StylePriority.UseBorders = False
        Me.XrLabel90.StylePriority.UseFont = False
        Me.XrLabel90.StylePriority.UseTextAlignment = False
        Me.XrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel89
        '
        Me.XrLabel89.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel89.CanGrow = False
        Me.XrLabel89.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel89.LocationFloat = New DevExpress.Utils.PointFloat(406.0933!, 115.7503!)
        Me.XrLabel89.Multiline = True
        Me.XrLabel89.Name = "XrLabel89"
        Me.XrLabel89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel89.SizeF = New System.Drawing.SizeF(276.18!, 16.0!)
        Me.XrLabel89.StylePriority.UseBorders = False
        Me.XrLabel89.StylePriority.UseFont = False
        Me.XrLabel89.StylePriority.UseTextAlignment = False
        Me.XrLabel89.Text = "PAN No :"
        Me.XrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(53.27682!, 115.7501!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(352.82!, 16.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 115.7501!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(53.27682!, 16.0!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "GSTIN: "
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel60
        '
        Me.XrLabel60.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ReceiverAddress]")})
        Me.XrLabel60.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(53.27682!, 316.3557!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(336.7836!, 36.23712!)
        Me.XrLabel60.StylePriority.UseFont = False
        '
        'XrLabel70
        '
        Me.XrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel70.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.ConsigneeAddress]")})
        Me.XrLabel70.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(443.0605!, 316.0009!)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(334.9056!, 36.59192!)
        Me.XrLabel70.StylePriority.UseBorders = False
        Me.XrLabel70.StylePriority.UseFont = False
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.CanGrow = False
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReceiverPanNo]")})
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(298.5106!, 353.0933!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(92.55!, 18.31244!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(249.0146!, 353.0933!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(49.49603!, 18.60428!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "PANNo : "
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsigneePanNo]")})
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(685.4105!, 352.5928!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(92.55573!, 18.45834!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(634.9205!, 352.5928!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(50.48993!, 18.45825!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "PANNo  : "
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.2844413!, 168.6669!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(595.77!, 17.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Calibri", 14.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0.284439!, 152.6669!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(595.77!, 16.0!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "            TAX  INVOICE"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel53
        '
        Me.XrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel53.CanGrow = False
        Me.XrLabel53.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.SupplyTo]")})
        Me.XrLabel53.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(692.3522!, 241.7293!)
        Me.XrLabel53.Multiline = True
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(85.64819!, 18.74988!)
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel49.CanGrow = False
        Me.XrLabel49.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(613.6683!, 241.875!)
        Me.XrLabel49.Multiline = True
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(78.6839!, 18.60431!)
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "Supply To       :"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel52
        '
        Me.XrLabel52.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel52.CanGrow = False
        Me.XrLabel52.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.AgainstForm]")})
        Me.XrLabel52.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(472.0945!, 241.7294!)
        Me.XrLabel52.Multiline = True
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(141.5737!, 18.74991!)
        Me.XrLabel52.StylePriority.UseBorders = False
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel50
        '
        Me.XrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel50.CanGrow = False
        Me.XrLabel50.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(391.0948!, 241.875!)
        Me.XrLabel50.Multiline = True
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(80.99979!, 18.60422!)
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "Way Bill No.  :"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel123
        '
        Me.XrLabel123.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel123.CanGrow = False
        Me.XrLabel123.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.PODate]")})
        Me.XrLabel123.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel123.LocationFloat = New DevExpress.Utils.PointFloat(692.3522!, 223.125!)
        Me.XrLabel123.Multiline = True
        Me.XrLabel123.Name = "XrLabel123"
        Me.XrLabel123.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel123.SizeF = New System.Drawing.SizeF(85.64825!, 18.60451!)
        Me.XrLabel123.StylePriority.UseBorders = False
        Me.XrLabel123.StylePriority.UseFont = False
        Me.XrLabel123.StylePriority.UseTextAlignment = False
        Me.XrLabel123.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel123.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel122
        '
        Me.XrLabel122.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel122.CanGrow = False
        Me.XrLabel122.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel122.LocationFloat = New DevExpress.Utils.PointFloat(613.6682!, 223.125!)
        Me.XrLabel122.Multiline = True
        Me.XrLabel122.Name = "XrLabel122"
        Me.XrLabel122.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel122.SizeF = New System.Drawing.SizeF(78.68408!, 18.74992!)
        Me.XrLabel122.StylePriority.UseBorders = False
        Me.XrLabel122.StylePriority.UseFont = False
        Me.XrLabel122.StylePriority.UseTextAlignment = False
        Me.XrLabel122.Text = "WO Date        :"
        Me.XrLabel122.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel43.CanGrow = False
        Me.XrLabel43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.PO]")})
        Me.XrLabel43.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(472.0945!, 223.1252!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(141.5737!, 18.60426!)
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel36
        '
        Me.XrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel36.CanGrow = False
        Me.XrLabel36.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(391.0847!, 223.2707!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(81.00989!, 18.60428!)
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "W. O.              :"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel19.CanGrow = False
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PartyDCDate]")})
        Me.XrLabel19.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(692.3522!, 204.5208!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(85.64819!, 18.60434!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel19.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(613.9545!, 204.5208!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(78.39771!, 18.60423!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Party DC Date:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PartyDCNo]")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(472.0945!, 204.5208!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(141.8598!, 18.60425!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(391.0946!, 204.5208!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(81.0!, 18.74988!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Party DC No  :"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ServiceInvoice.TransportationMode]")})
        Me.XrLabel34.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(515.9388!, 185.9167!)
        Me.XrLabel34.Multiline = True
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(262.0616!, 18.60406!)
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(391.0946!, 185.9165!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(124.8442!, 18.6044!)
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Transportation Mode  : "
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine2.EndBand = Me.GroupHeader1
        Me.XrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(0.2844413!, 353.093!)
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.GroupHeader1
        Me.XrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(0.2844413!, 334.96!)
        Me.XrCrossBandLine2.WidthF = 1.041667!
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine3.EndBand = Me.GroupHeader1
        Me.XrCrossBandLine3.EndPointFloat = New DevExpress.Utils.PointFloat(391.0948!, 352.5927!)
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.GroupHeader1
        Me.XrCrossBandLine3.StartPointFloat = New DevExpress.Utils.PointFloat(391.0948!, 334.6052!)
        Me.XrCrossBandLine3.WidthF = 1.0!
        '
        'XR_ExportServiceIGST
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.GroupFooter2, Me.GroupHeader1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine3, Me.XrCrossBandLine2, Me.XrCrossBandLine4, Me.XrCrossBandLine1})
        Me.DataAdapter = Me.DT_ServiceInvoiceTableAdapter
        Me.DataMember = "DT_ServiceInvoice"
        Me.DataSource = Me.DS_ServiceInvoice2
        Me.FilterString = "[ServiceInvoiceID] = ?Invoice"
        Me.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.Margins = New DevExpress.Drawing.DXMargins(22.0!, 27.0!, 50.00001!, 0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Invoice})
        Me.Version = "23.2"
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ServiceInvoice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ServiceInvoice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher

    Friend WithEvents DS_Invoice1 As DS_Invoice
    Friend WithEvents DT_InvoiceTableAdapter As DS_InvoiceTableAdapters.DT_InvoiceTableAdapter
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents DS_Invoice2 As DS_Invoice
    Friend WithEvents DT_InvoiceTableAdapter1 As DS_InvoiceTableAdapters.DT_InvoiceTableAdapter
    Friend WithEvents Invoice As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents DS_ServiceInvoice1 As DS_ServiceInvoice
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalGSTCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PackingChargeCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TaxableValLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TaxableValueCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PackingGSTCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents RoundOffCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GrandTotalLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GrandTotalCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel103 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel102 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel88 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel104 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel106 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel111 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel110 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel107 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel156 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel155 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel141 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel153 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel140 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel143 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel150 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel133 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel139 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel138 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel152 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel154 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel161 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel160 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel159 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel158 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel157 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel166 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel164 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel163 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel162 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents DT_ServiceInvoiceTableAdapter As DS_ServiceInvoiceTableAdapters.DT_ServiceInvoiceTableAdapter
    Friend WithEvents DS_ServiceInvoice2 As DS_ServiceInvoice
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel69 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel71 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel72 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel73 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel74 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel75 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel76 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel77 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel78 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel93 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel117 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel118 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel119 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel120 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel121 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel126 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel127 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel91 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel90 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel89 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel123 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel122 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TaxableValueLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IGSTAmtLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelISO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine3 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabelIrn As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAck As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelMSME As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel92 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel85 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel84 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel81 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
End Class
