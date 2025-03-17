<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_SEZSalesWithLUT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_SEZSalesWithLUT))
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
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
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalGSTCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PackingChargeCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TaxableValLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TaxableValueCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.RoundOffCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GrandTotalLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GrandTotalCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel162 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel163 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel164 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TaxableValueLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel166 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel167 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel168 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel157 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel158 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel159 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel160 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel161 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel115 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel129 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel138 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel139 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel133 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel150 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel143 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel140 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel153 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel141 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel155 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel156 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel107 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel110 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel111 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel106 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel104 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel102 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel103 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel92 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel81 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelMSME = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelIrn = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAck = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabelISO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel101 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel105 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel108 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel109 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel112 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel113 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel114 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel116 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel124 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel125 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel128 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel130 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel131 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel132 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel134 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel135 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel136 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel137 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel142 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel144 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel145 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel146 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel147 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel148 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel149 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel170 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel171 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel172 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel173 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel174 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel76 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel77 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel78 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel117 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel118 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel119 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel120 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel121 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel91 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel90 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel89 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel123 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel122 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBorders = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1})
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.5075734!, 47.91666!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(777.6944!, 2.083336!)
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
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrTable4, Me.XrPictureBox2, Me.XrTable3, Me.XrLabel162, Me.XrLabel163, Me.XrLabel164, Me.TaxableValueLabel, Me.XrLabel166, Me.XrLabel167, Me.XrLabel168, Me.XrLabel157, Me.XrLabel158, Me.XrLabel159, Me.XrLabel160, Me.XrLabel161, Me.XrLabel115, Me.XrLabel129, Me.XrLabel138, Me.XrLabel139, Me.XrLabel133, Me.XrLabel150, Me.XrLabel143, Me.XrLabel140, Me.XrLabel153, Me.XrLabel141, Me.XrLabel155, Me.XrLabel156, Me.XrLabel107, Me.XrLabel110, Me.XrLabel111, Me.XrLabel106, Me.XrLabel104, Me.XrLabel87, Me.XrLabel88, Me.XrLabel102, Me.XrLabel103, Me.XrTable1})
        Me.GroupFooter2.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.GroupFooter2.HeightF = 379.1294!
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.StylePriority.UseBorders = False
        Me.GroupFooter2.StylePriority.UseFont = False
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DiscountVal])")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(486.4871!, 5.000068!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(49.36703!, 17.56259!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel5.Summary = XrSummary1
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel5.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0.5075693!, 0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(777.9406!, 5.0!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UsePadding = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell7, Me.XrTableCell10, Me.XrTableCell12, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell34, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.23688934326172R
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
        Me.XrTableCell23.Weight = 1.1115909411952349R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.Weight = 6.3091817545992885R
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
        Me.XrTableCell10.Weight = 1.8538077473306887R
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
        Me.XrTableCell12.Weight = 1.1157527234953268R
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
        Me.XrTableCell26.Weight = 1.9517284202513747R
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
        Me.XrTableCell27.Weight = 2.2134776454054328R
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
        Me.XrTableCell28.Weight = 2.1916731528377884R
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
        Me.XrTableCell29.Weight = 1.2598030541739873R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell34.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell34.Multiline = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell34.StylePriority.UseBorders = False
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.StylePriority.UsePadding = False
        Me.XrTableCell34.Weight = 1.8343113633859518R
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
        Me.XrTableCell30.Weight = 1.9080492877013713R
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
        Me.XrTableCell31.Weight = 0.963377417589443R
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
        Me.XrTableCell32.Weight = 2.782640319987836R
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
        Me.XrTableCell33.Weight = 3.3296616143129065R
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox2.ImageSource"))
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(614.17!, 283.01!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(63.66998!, 63.11002!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox2.StylePriority.UseBorders = False
        Me.XrPictureBox2.Visible = False
        '
        'XrTable3
        '
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(300.6385!, 22.56263!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow8, Me.XrTableRow9, Me.XrTableRow10})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(477.8095!, 99.99998!)
        Me.XrTable3.StylePriority.UsePadding = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell9, Me.TotalGSTCell})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = " Packing / Courier"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 1.56190032958984R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "Total GST"
        Me.XrTableCell9.Weight = 1.70806243896484R
        '
        'TotalGSTCell
        '
        Me.TotalGSTCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TotalGSTCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalGSTTax]")})
        Me.TotalGSTCell.Name = "TotalGSTCell"
        Me.TotalGSTCell.StylePriority.UseBorders = False
        Me.TotalGSTCell.StylePriority.UseTextAlignment = False
        Me.TotalGSTCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalGSTCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.TotalGSTCell.Weight = 1.5125358670153284R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.PackingChargeCell, Me.TaxableValLabel, Me.TaxableValueCell})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.Text = "Amount"
        Me.XrTableCell11.Weight = 0.714490051269531R
        '
        'PackingChargeCell
        '
        Me.PackingChargeCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PackingCharge]")})
        Me.PackingChargeCell.Name = "PackingChargeCell"
        Me.PackingChargeCell.StylePriority.UseTextAlignment = False
        Me.PackingChargeCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PackingChargeCell.TextFormatString = "{0:f}"
        Me.PackingChargeCell.Weight = 0.847410278320312R
        '
        'TaxableValLabel
        '
        Me.TaxableValLabel.Name = "TaxableValLabel"
        Me.TaxableValLabel.Text = "Taxable Value"
        Me.TaxableValLabel.Weight = 1.70806304931641R
        '
        'TaxableValueCell
        '
        Me.TaxableValueCell.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TaxableValueCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", " ")})
        Me.TaxableValueCell.Name = "TaxableValueCell"
        Me.TaxableValueCell.StylePriority.UseBorders = False
        Me.TaxableValueCell.StylePriority.UseTextAlignment = False
        Me.TaxableValueCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TaxableValueCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.TaxableValueCell.Weight = 1.5125352566637682R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22, Me.RoundOffCell})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PIGSTRate]")})
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.TextFormatString = "(IGST {0}%)"
        Me.XrTableCell20.Weight = 0.714490051269531R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PIGSTAmt]")})
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.TextFormatString = "{0:f}"
        Me.XrTableCell21.Weight = 0.847410278320313R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Text = "Round Off"
        Me.XrTableCell22.Weight = 1.70806365966797R
        '
        'RoundOffCell
        '
        Me.RoundOffCell.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.RoundOffCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RoundOff]")})
        Me.RoundOffCell.Name = "RoundOffCell"
        Me.RoundOffCell.StylePriority.UseBorders = False
        Me.RoundOffCell.StylePriority.UseTextAlignment = False
        Me.RoundOffCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.RoundOffCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.RoundOffCell.Weight = 1.5125346463121983R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell24, Me.XrTableCell25, Me.GrandTotalLabel, Me.GrandTotalCell})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseBorders = False
        Me.XrTableCell24.Weight = 0.714490051269531R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseBorders = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell25.Weight = 0.847410278320313R
        '
        'GrandTotalLabel
        '
        Me.GrandTotalLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.GrandTotalLabel.Name = "GrandTotalLabel"
        Me.GrandTotalLabel.StylePriority.UseBorders = False
        Me.GrandTotalLabel.Text = "Total Taxable Value "
        Me.GrandTotalLabel.Weight = 1.70806365966797R
        '
        'GrandTotalCell
        '
        Me.GrandTotalCell.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.GrandTotalCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GrandTotalAmount]")})
        Me.GrandTotalCell.Name = "GrandTotalCell"
        Me.GrandTotalCell.StylePriority.UseBorders = False
        Me.GrandTotalCell.StylePriority.UseTextAlignment = False
        Me.GrandTotalCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.GrandTotalCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.GrandTotalCell.Weight = 1.5125346463121983R
        '
        'XrLabel162
        '
        Me.XrLabel162.BorderColor = System.Drawing.Color.Black
        Me.XrLabel162.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel162.CanGrow = False
        Me.XrLabel162.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel162.LocationFloat = New DevExpress.Utils.PointFloat(0.4919748!, 4.999977!)
        Me.XrLabel162.Multiline = True
        Me.XrLabel162.Name = "XrLabel162"
        Me.XrLabel162.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel162.SizeF = New System.Drawing.SizeF(280.482!, 17.56264!)
        Me.XrLabel162.StylePriority.UseBorderColor = False
        Me.XrLabel162.StylePriority.UseBorders = False
        Me.XrLabel162.StylePriority.UseFont = False
        Me.XrLabel162.StylePriority.UseTextAlignment = False
        Me.XrLabel162.Text = "Total"
        Me.XrLabel162.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel163
        '
        Me.XrLabel163.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel163.CanGrow = False
        Me.XrLabel163.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Qty])")})
        Me.XrLabel163.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel163.LocationFloat = New DevExpress.Utils.PointFloat(280.974!, 4.999977!)
        Me.XrLabel163.Multiline = True
        Me.XrLabel163.Name = "XrLabel163"
        Me.XrLabel163.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel163.SizeF = New System.Drawing.SizeF(52.4874!, 17.56259!)
        Me.XrLabel163.StylePriority.UseBorders = False
        Me.XrLabel163.StylePriority.UseFont = False
        Me.XrLabel163.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel163.Summary = XrSummary2
        Me.XrLabel163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel163.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel164
        '
        Me.XrLabel164.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel164.CanGrow = False
        Me.XrLabel164.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel164.LocationFloat = New DevExpress.Utils.PointFloat(333.5994!, 4.999977!)
        Me.XrLabel164.Multiline = True
        Me.XrLabel164.Name = "XrLabel164"
        Me.XrLabel164.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel164.SizeF = New System.Drawing.SizeF(152.8877!, 17.56264!)
        Me.XrLabel164.StylePriority.UseBorders = False
        Me.XrLabel164.StylePriority.UseFont = False
        Me.XrLabel164.StylePriority.UseTextAlignment = False
        Me.XrLabel164.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TaxableValueLabel
        '
        Me.TaxableValueLabel.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.TaxableValueLabel.CanGrow = False
        Me.TaxableValueLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TaxableValue])")})
        Me.TaxableValueLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.TaxableValueLabel.LocationFloat = New DevExpress.Utils.PointFloat(535.8541!, 4.999977!)
        Me.TaxableValueLabel.Multiline = True
        Me.TaxableValueLabel.Name = "TaxableValueLabel"
        Me.TaxableValueLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TaxableValueLabel.SizeF = New System.Drawing.SizeF(51.30786!, 17.56259!)
        Me.TaxableValueLabel.StylePriority.UseBorders = False
        Me.TaxableValueLabel.StylePriority.UseFont = False
        Me.TaxableValueLabel.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.TaxableValueLabel.Summary = XrSummary3
        Me.TaxableValueLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TaxableValueLabel.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel166
        '
        Me.XrLabel166.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel166.CanGrow = False
        Me.XrLabel166.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel166.LocationFloat = New DevExpress.Utils.PointFloat(587.3491!, 4.999972!)
        Me.XrLabel166.Multiline = True
        Me.XrLabel166.Name = "XrLabel166"
        Me.XrLabel166.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel166.SizeF = New System.Drawing.SizeF(26.00006!, 17.56264!)
        Me.XrLabel166.StylePriority.UseBorders = False
        Me.XrLabel166.StylePriority.UseFont = False
        Me.XrLabel166.StylePriority.UseTextAlignment = False
        Me.XrLabel166.Text = "-"
        Me.XrLabel166.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel167
        '
        Me.XrLabel167.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel167.CanGrow = False
        Me.XrLabel167.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([IGSTAmt])")})
        Me.XrLabel167.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel167.LocationFloat = New DevExpress.Utils.PointFloat(613.4579!, 5.000008!)
        Me.XrLabel167.Multiline = True
        Me.XrLabel167.Name = "XrLabel167"
        Me.XrLabel167.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel167.SizeF = New System.Drawing.SizeF(74.99011!, 17.56264!)
        Me.XrLabel167.StylePriority.UseBorders = False
        Me.XrLabel167.StylePriority.UseFont = False
        Me.XrLabel167.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel167.Summary = XrSummary4
        Me.XrLabel167.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel167.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel168
        '
        Me.XrLabel168.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel168.CanGrow = False
        Me.XrLabel168.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TaxableValue])")})
        Me.XrLabel168.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel168.LocationFloat = New DevExpress.Utils.PointFloat(688.6401!, 5.000009!)
        Me.XrLabel168.Multiline = True
        Me.XrLabel168.Name = "XrLabel168"
        Me.XrLabel168.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel168.SizeF = New System.Drawing.SizeF(89.80792!, 17.56264!)
        Me.XrLabel168.StylePriority.UseBorders = False
        Me.XrLabel168.StylePriority.UseFont = False
        Me.XrLabel168.StylePriority.UseTextAlignment = False
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel168.Summary = XrSummary5
        Me.XrLabel168.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel168.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel157
        '
        Me.XrLabel157.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel157.CanGrow = False
        Me.XrLabel157.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Underline), DevExpress.Drawing.DXFontStyle))
        Me.XrLabel157.LocationFloat = New DevExpress.Utils.PointFloat(0.4919767!, 263.8767!)
        Me.XrLabel157.Multiline = True
        Me.XrLabel157.Name = "XrLabel157"
        Me.XrLabel157.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel157.SizeF = New System.Drawing.SizeF(515.8085!, 16.91846!)
        Me.XrLabel157.StylePriority.UseBorders = False
        Me.XrLabel157.StylePriority.UseFont = False
        Me.XrLabel157.StylePriority.UseTextAlignment = False
        Me.XrLabel157.Text = "TERMS & CONDITIONS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel158
        '
        Me.XrLabel158.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel158.CanGrow = False
        Me.XrLabel158.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.XrLabel158.LocationFloat = New DevExpress.Utils.PointFloat(516.3005!, 280.9388!)
        Me.XrLabel158.Multiline = True
        Me.XrLabel158.Name = "XrLabel158"
        Me.XrLabel158.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel158.SizeF = New System.Drawing.SizeF(261.8981!, 67.88644!)
        Me.XrLabel158.StylePriority.UseBorders = False
        Me.XrLabel158.StylePriority.UseFont = False
        Me.XrLabel158.StylePriority.UseTextAlignment = False
        Me.XrLabel158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel159
        '
        Me.XrLabel159.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel159.CanGrow = False
        Me.XrLabel159.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel159.LocationFloat = New DevExpress.Utils.PointFloat(516.3004!, 264.0201!)
        Me.XrLabel159.Multiline = True
        Me.XrLabel159.Name = "XrLabel159"
        Me.XrLabel159.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel159.SizeF = New System.Drawing.SizeF(261.8981!, 16.91849!)
        Me.XrLabel159.StylePriority.UseBorders = False
        Me.XrLabel159.StylePriority.UseFont = False
        Me.XrLabel159.StylePriority.UseTextAlignment = False
        Me.XrLabel159.Text = "FOR PREEVOL TECHNICS,"
        Me.XrLabel159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel160
        '
        Me.XrLabel160.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel160.CanGrow = False
        Me.XrLabel160.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!)
        Me.XrLabel160.LocationFloat = New DevExpress.Utils.PointFloat(0.4919767!, 280.7953!)
        Me.XrLabel160.Multiline = True
        Me.XrLabel160.Name = "XrLabel160"
        Me.XrLabel160.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.XrLabel160.SizeF = New System.Drawing.SizeF(515.8085!, 86.63638!)
        Me.XrLabel160.StylePriority.UseBorders = False
        Me.XrLabel160.StylePriority.UseFont = False
        Me.XrLabel160.StylePriority.UsePadding = False
        Me.XrLabel160.StylePriority.UseTextAlignment = False
        Me.XrLabel160.Text = resources.GetString("XrLabel160.Text")
        Me.XrLabel160.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel161
        '
        Me.XrLabel161.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel161.CanGrow = False
        Me.XrLabel161.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.XrLabel161.LocationFloat = New DevExpress.Utils.PointFloat(516.3004!, 348.8251!)
        Me.XrLabel161.Multiline = True
        Me.XrLabel161.Name = "XrLabel161"
        Me.XrLabel161.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel161.SizeF = New System.Drawing.SizeF(261.8981!, 18.60663!)
        Me.XrLabel161.StylePriority.UseBorders = False
        Me.XrLabel161.StylePriority.UseFont = False
        Me.XrLabel161.StylePriority.UseTextAlignment = False
        Me.XrLabel161.Text = "(Authorised Signatory)"
        Me.XrLabel161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel115
        '
        Me.XrLabel115.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel115.CanGrow = False
        Me.XrLabel115.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel115.LocationFloat = New DevExpress.Utils.PointFloat(0.5075793!, 209.7337!)
        Me.XrLabel115.Multiline = True
        Me.XrLabel115.Name = "XrLabel115"
        Me.XrLabel115.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel115.SizeF = New System.Drawing.SizeF(99.98421!, 17.99998!)
        Me.XrLabel115.StylePriority.UseBorders = False
        Me.XrLabel115.StylePriority.UseFont = False
        Me.XrLabel115.StylePriority.UseTextAlignment = False
        Me.XrLabel115.Text = "BANK NAME        :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel129
        '
        Me.XrLabel129.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel129.CanGrow = False
        Me.XrLabel129.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel129.LocationFloat = New DevExpress.Utils.PointFloat(0.4919767!, 227.7337!)
        Me.XrLabel129.Multiline = True
        Me.XrLabel129.Name = "XrLabel129"
        Me.XrLabel129.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel129.SizeF = New System.Drawing.SizeF(99.70644!, 18.14317!)
        Me.XrLabel129.StylePriority.UseBorders = False
        Me.XrLabel129.StylePriority.UseFont = False
        Me.XrLabel129.StylePriority.UseTextAlignment = False
        Me.XrLabel129.Text = "BRANCH NAME  :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel138
        '
        Me.XrLabel138.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel138.CanGrow = False
        Me.XrLabel138.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel138.LocationFloat = New DevExpress.Utils.PointFloat(100.4918!, 209.7338!)
        Me.XrLabel138.Multiline = True
        Me.XrLabel138.Name = "XrLabel138"
        Me.XrLabel138.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel138.SizeF = New System.Drawing.SizeF(177.8354!, 17.99998!)
        Me.XrLabel138.StylePriority.UseBorders = False
        Me.XrLabel138.StylePriority.UseFont = False
        Me.XrLabel138.StylePriority.UseTextAlignment = False
        Me.XrLabel138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel139
        '
        Me.XrLabel139.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel139.CanGrow = False
        Me.XrLabel139.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel139.LocationFloat = New DevExpress.Utils.PointFloat(100.1984!, 227.7339!)
        Me.XrLabel139.Multiline = True
        Me.XrLabel139.Name = "XrLabel139"
        Me.XrLabel139.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel139.SizeF = New System.Drawing.SizeF(178.1288!, 18.14296!)
        Me.XrLabel139.StylePriority.UseBorders = False
        Me.XrLabel139.StylePriority.UseFont = False
        Me.XrLabel139.StylePriority.UseTextAlignment = False
        Me.XrLabel139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel133
        '
        Me.XrLabel133.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel133.CanGrow = False
        Me.XrLabel133.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel133.LocationFloat = New DevExpress.Utils.PointFloat(278.3272!, 209.7338!)
        Me.XrLabel133.Multiline = True
        Me.XrLabel133.Name = "XrLabel133"
        Me.XrLabel133.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel133.SizeF = New System.Drawing.SizeF(89.55991!, 18.14302!)
        Me.XrLabel133.StylePriority.UseBorders = False
        Me.XrLabel133.StylePriority.UseFont = False
        Me.XrLabel133.StylePriority.UseTextAlignment = False
        Me.XrLabel133.Text = "ACCOUNT NO :"
        Me.XrLabel133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel150
        '
        Me.XrLabel150.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel150.CanGrow = False
        Me.XrLabel150.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel150.LocationFloat = New DevExpress.Utils.PointFloat(278.3272!, 227.8769!)
        Me.XrLabel150.Multiline = True
        Me.XrLabel150.Name = "XrLabel150"
        Me.XrLabel150.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel150.SizeF = New System.Drawing.SizeF(89.55988!, 17.99997!)
        Me.XrLabel150.StylePriority.UseBorders = False
        Me.XrLabel150.StylePriority.UseFont = False
        Me.XrLabel150.StylePriority.UseTextAlignment = False
        Me.XrLabel150.Text = "MICR CODE     :"
        Me.XrLabel150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel143
        '
        Me.XrLabel143.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel143.CanGrow = False
        Me.XrLabel143.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel143.LocationFloat = New DevExpress.Utils.PointFloat(367.8871!, 209.7338!)
        Me.XrLabel143.Multiline = True
        Me.XrLabel143.Name = "XrLabel143"
        Me.XrLabel143.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel143.SizeF = New System.Drawing.SizeF(148.4133!, 18.14308!)
        Me.XrLabel143.StylePriority.UseBorders = False
        Me.XrLabel143.StylePriority.UseFont = False
        Me.XrLabel143.StylePriority.UseTextAlignment = False
        Me.XrLabel143.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel140
        '
        Me.XrLabel140.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel140.CanGrow = False
        Me.XrLabel140.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel140.LocationFloat = New DevExpress.Utils.PointFloat(367.8871!, 227.8769!)
        Me.XrLabel140.Multiline = True
        Me.XrLabel140.Name = "XrLabel140"
        Me.XrLabel140.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel140.SizeF = New System.Drawing.SizeF(148.4133!, 17.99995!)
        Me.XrLabel140.StylePriority.UseBorders = False
        Me.XrLabel140.StylePriority.UseFont = False
        Me.XrLabel140.StylePriority.UseTextAlignment = False
        Me.XrLabel140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel153
        '
        Me.XrLabel153.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel153.CanGrow = False
        Me.XrLabel153.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel153.LocationFloat = New DevExpress.Utils.PointFloat(0.5075793!, 245.8768!)
        Me.XrLabel153.Multiline = True
        Me.XrLabel153.Name = "XrLabel153"
        Me.XrLabel153.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel153.SizeF = New System.Drawing.SizeF(99.69085!, 18.00005!)
        Me.XrLabel153.StylePriority.UseBorders = False
        Me.XrLabel153.StylePriority.UseFont = False
        Me.XrLabel153.StylePriority.UseTextAlignment = False
        Me.XrLabel153.Text = "IFSC CODE           :"
        Me.XrLabel153.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel141
        '
        Me.XrLabel141.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel141.CanGrow = False
        Me.XrLabel141.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel141.LocationFloat = New DevExpress.Utils.PointFloat(100.4918!, 245.8768!)
        Me.XrLabel141.Multiline = True
        Me.XrLabel141.Name = "XrLabel141"
        Me.XrLabel141.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel141.SizeF = New System.Drawing.SizeF(177.8354!, 18.00002!)
        Me.XrLabel141.StylePriority.UseBorders = False
        Me.XrLabel141.StylePriority.UseFont = False
        Me.XrLabel141.StylePriority.UseTextAlignment = False
        Me.XrLabel141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel155
        '
        Me.XrLabel155.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel155.CanGrow = False
        Me.XrLabel155.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel155.LocationFloat = New DevExpress.Utils.PointFloat(278.3272!, 245.8768!)
        Me.XrLabel155.Multiline = True
        Me.XrLabel155.Name = "XrLabel155"
        Me.XrLabel155.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel155.SizeF = New System.Drawing.SizeF(237.9732!, 18.0!)
        Me.XrLabel155.StylePriority.UseBorders = False
        Me.XrLabel155.StylePriority.UseFont = False
        Me.XrLabel155.StylePriority.UseTextAlignment = False
        Me.XrLabel155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel156
        '
        Me.XrLabel156.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel156.CanGrow = False
        Me.XrLabel156.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Underline)
        Me.XrLabel156.LocationFloat = New DevExpress.Utils.PointFloat(516.3005!, 210.0202!)
        Me.XrLabel156.Multiline = True
        Me.XrLabel156.Name = "XrLabel156"
        Me.XrLabel156.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel156.SizeF = New System.Drawing.SizeF(261.8981!, 53.99995!)
        Me.XrLabel156.StylePriority.UseBorders = False
        Me.XrLabel156.StylePriority.UseFont = False
        Me.XrLabel156.StylePriority.UseTextAlignment = False
        Me.XrLabel156.Text = "Certified that the particulars given above are true"
        Me.XrLabel156.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel107
        '
        Me.XrLabel107.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel107.CanGrow = False
        Me.XrLabel107.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel107.LocationFloat = New DevExpress.Utils.PointFloat(0.4919767!, 192.1713!)
        Me.XrLabel107.Multiline = True
        Me.XrLabel107.Name = "XrLabel107"
        Me.XrLabel107.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel107.SizeF = New System.Drawing.SizeF(515.8085!, 17.56253!)
        Me.XrLabel107.StylePriority.UseBorders = False
        Me.XrLabel107.StylePriority.UseFont = False
        Me.XrLabel107.StylePriority.UseTextAlignment = False
        Me.XrLabel107.Text = "BANK DETAILS FOR NEFT/ RTGS PAYMENTS"
        Me.XrLabel107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel110
        '
        Me.XrLabel110.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel110.CanGrow = False
        Me.XrLabel110.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel110.LocationFloat = New DevExpress.Utils.PointFloat(516.3005!, 192.1713!)
        Me.XrLabel110.Multiline = True
        Me.XrLabel110.Name = "XrLabel110"
        Me.XrLabel110.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel110.SizeF = New System.Drawing.SizeF(156.3247!, 17.84897!)
        Me.XrLabel110.StylePriority.UseBorders = False
        Me.XrLabel110.StylePriority.UseFont = False
        Me.XrLabel110.StylePriority.UseTextAlignment = False
        Me.XrLabel110.Text = "GST Payable on Reverse Charge"
        Me.XrLabel110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel111
        '
        Me.XrLabel111.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel111.CanGrow = False
        Me.XrLabel111.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GSTReverseCharge]")})
        Me.XrLabel111.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel111.LocationFloat = New DevExpress.Utils.PointFloat(673.4744!, 192.1713!)
        Me.XrLabel111.Multiline = True
        Me.XrLabel111.Name = "XrLabel111"
        Me.XrLabel111.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel111.SizeF = New System.Drawing.SizeF(104.7241!, 17.84897!)
        Me.XrLabel111.StylePriority.UseBorders = False
        Me.XrLabel111.StylePriority.UseFont = False
        Me.XrLabel111.StylePriority.UseTextAlignment = False
        Me.XrLabel111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel111.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel106
        '
        Me.XrLabel106.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel106.CanGrow = False
        Me.XrLabel106.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Remarks]")})
        Me.XrLabel106.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel106.LocationFloat = New DevExpress.Utils.PointFloat(102.2894!, 174.7522!)
        Me.XrLabel106.Multiline = True
        Me.XrLabel106.Name = "XrLabel106"
        Me.XrLabel106.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel106.SizeF = New System.Drawing.SizeF(675.9091!, 17.41913!)
        Me.XrLabel106.StylePriority.UseBorders = False
        Me.XrLabel106.StylePriority.UseFont = False
        Me.XrLabel106.StylePriority.UseTextAlignment = False
        Me.XrLabel106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel104
        '
        Me.XrLabel104.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel104.CanGrow = False
        Me.XrLabel104.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel104.LocationFloat = New DevExpress.Utils.PointFloat(0.5075793!, 174.7522!)
        Me.XrLabel104.Multiline = True
        Me.XrLabel104.Name = "XrLabel104"
        Me.XrLabel104.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel104.SizeF = New System.Drawing.SizeF(101.7819!, 17.41902!)
        Me.XrLabel104.StylePriority.UseBorders = False
        Me.XrLabel104.StylePriority.UseFont = False
        Me.XrLabel104.StylePriority.UseTextAlignment = False
        Me.XrLabel104.Text = "Remarks"
        Me.XrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel87
        '
        Me.XrLabel87.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel87.CanGrow = False
        Me.XrLabel87.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(0.4919767!, 122.5626!)
        Me.XrLabel87.Multiline = True
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(371.1554!, 16.77753!)
        Me.XrLabel87.StylePriority.UseBorders = False
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "Total GST Amount in Words"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel88
        '
        Me.XrLabel88.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel88.CanGrow = False
        Me.XrLabel88.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TaxInWords]")})
        Me.XrLabel88.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel88.LocationFloat = New DevExpress.Utils.PointFloat(0.4919767!, 139.3401!)
        Me.XrLabel88.Multiline = True
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel88.SizeF = New System.Drawing.SizeF(371.1554!, 35.41217!)
        Me.XrLabel88.StylePriority.UseBorders = False
        Me.XrLabel88.StylePriority.UseFont = False
        Me.XrLabel88.StylePriority.UseTextAlignment = False
        Me.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel102
        '
        Me.XrLabel102.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel102.CanGrow = False
        Me.XrLabel102.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel102.LocationFloat = New DevExpress.Utils.PointFloat(371.6474!, 122.5626!)
        Me.XrLabel102.Multiline = True
        Me.XrLabel102.Name = "XrLabel102"
        Me.XrLabel102.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel102.SizeF = New System.Drawing.SizeF(406.5511!, 17.41893!)
        Me.XrLabel102.StylePriority.UseBorders = False
        Me.XrLabel102.StylePriority.UseFont = False
        Me.XrLabel102.StylePriority.UseTextAlignment = False
        Me.XrLabel102.Text = "Total Invoice Amount in Words"
        Me.XrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel103
        '
        Me.XrLabel103.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel103.CanGrow = False
        Me.XrLabel103.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalInWords]")})
        Me.XrLabel103.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel103.LocationFloat = New DevExpress.Utils.PointFloat(371.6474!, 139.9816!)
        Me.XrLabel103.Multiline = True
        Me.XrLabel103.Name = "XrLabel103"
        Me.XrLabel103.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel103.SizeF = New System.Drawing.SizeF(406.6308!, 34.77077!)
        Me.XrLabel103.StylePriority.UseBorders = False
        Me.XrLabel103.StylePriority.UseFont = False
        Me.XrLabel103.StylePriority.UseTextAlignment = False
        Me.XrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.5075791!, 22.56263!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(300.1309!, 47.0!)
        Me.XrTable1.StylePriority.UseBorders = False
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
        Me.XrTableCell1.Weight = 1.0013108219418971R
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
        Me.XrTableCell3.Weight = 1.0044075583291285R
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
        Me.XrTableCell4.Weight = 1.001310821941902R
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
        Me.XrTableCell6.Weight = 1.0044075583291285R
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine4.EndBand = Me.GroupFooter2
        Me.XrCrossBandLine4.EndPointFloat = New DevExpress.Utils.PointFloat(0.4998207!, 122.5626!)
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.GroupFooter2
        Me.XrCrossBandLine4.StartPointFloat = New DevExpress.Utils.PointFloat(0.4998207!, 69.56266!)
        Me.XrCrossBandLine4.WidthF = 1.041667!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel92, Me.XrLabel85, Me.XrLabel84, Me.XrLabel83, Me.XrLabel82, Me.XrLabel81, Me.XrLabel80, Me.XrLabel79, Me.XrLabel30, Me.XrLabel31, Me.XrLabel32, Me.XrLabel33, Me.XrLabel22, Me.XrLabel23, Me.XrLabelMSME, Me.XrLabelIrn, Me.XrLabelAck, Me.XrPictureBox3, Me.XrLabelISO, Me.XrLabel4, Me.XrLabel8, Me.XrLabel27, Me.XrLabel35, Me.XrLabel37, Me.XrLabel40, Me.XrLabel42, Me.XrLabel48, Me.XrLabel51, Me.XrLabel101, Me.XrLabel105, Me.XrLabel108, Me.XrLabel109, Me.XrLabel112, Me.XrLabel113, Me.XrLabel114, Me.XrLabel116, Me.XrLabel124, Me.XrLabel125, Me.XrLabel128, Me.XrLabel130, Me.XrLabel131, Me.XrLabel132, Me.XrLabel134, Me.XrLabel135, Me.XrLabel136, Me.XrLabel137, Me.XrLabel142, Me.XrLabel144, Me.XrLabel145, Me.XrLabel146, Me.XrLabel147, Me.XrLabel148, Me.XrLabel149, Me.XrLabel170, Me.XrLabel171, Me.XrLabel172, Me.XrLabel173, Me.XrLabel174, Me.XrLabel17, Me.XrLabel44, Me.XrLabel45, Me.XrLabel46, Me.XrLabel47, Me.XrLabel14, Me.XrLabel54, Me.XrLabel76, Me.XrLabel77, Me.XrLabel78, Me.XrLabel117, Me.XrLabel118, Me.XrLabel119, Me.XrLabel120, Me.XrLabel121, Me.XrPictureBox1, Me.XrLabel59, Me.XrLabel91, Me.XrLabel16, Me.XrLabel9, Me.XrLabel90, Me.XrLabel89, Me.XrLabel28, Me.XrLabel18, Me.XrLabel1, Me.XrLabel123, Me.XrLabel122, Me.XrLabel43, Me.XrLabel36, Me.XrLabel34, Me.XrLabel13, Me.XrLabel21, Me.XrLabel20, Me.XrLabel3, Me.XrLabel2})
        Me.GroupHeader1.HeightF = 425.6305!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel92
        '
        Me.XrLabel92.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel92.CanGrow = False
        Me.XrLabel92.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel92.LocationFloat = New DevExpress.Utils.PointFloat(688.4482!, 385.6272!)
        Me.XrLabel92.Multiline = True
        Me.XrLabel92.Name = "XrLabel92"
        Me.XrLabel92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel92.SizeF = New System.Drawing.SizeF(90.0!, 40.0!)
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
        Me.XrLabel85.LocationFloat = New DevExpress.Utils.PointFloat(613.3492!, 404.6704!)
        Me.XrLabel85.Multiline = True
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel85.SizeF = New System.Drawing.SizeF(75.09888!, 20.96002!)
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
        Me.XrLabel84.LocationFloat = New DevExpress.Utils.PointFloat(587.3491!, 404.6704!)
        Me.XrLabel84.Multiline = True
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel84.SizeF = New System.Drawing.SizeF(26.0!, 20.96!)
        Me.XrLabel84.StylePriority.UseBorders = False
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        Me.XrLabel84.Text = "Rate"
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel83
        '
        Me.XrLabel83.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel83.CanGrow = False
        Me.XrLabel83.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel83.LocationFloat = New DevExpress.Utils.PointFloat(587.3491!, 385.6276!)
        Me.XrLabel83.Multiline = True
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel83.SizeF = New System.Drawing.SizeF(101.0989!, 19.04297!)
        Me.XrLabel83.StylePriority.UseBorders = False
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        Me.XrLabel83.Text = "IGST"
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel82
        '
        Me.XrLabel82.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel82.CanGrow = False
        Me.XrLabel82.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(535.8541!, 385.6305!)
        Me.XrLabel82.Multiline = True
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(51.49506!, 39.99997!)
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
        Me.XrLabel81.LocationFloat = New DevExpress.Utils.PointFloat(452.3491!, 385.6271!)
        Me.XrLabel81.Multiline = True
        Me.XrLabel81.Name = "XrLabel81"
        Me.XrLabel81.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel81.SizeF = New System.Drawing.SizeF(34.0!, 40.00012!)
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
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(250.7874!, 385.6274!)
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
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(200.6751!, 385.6276!)
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
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(30.67507!, 385.6276!)
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
        'XrLabel31
        '
        Me.XrLabel31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel31.CanGrow = False
        Me.XrLabel31.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(280.7874!, 385.6305!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(52.67398!, 39.99994!)
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
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(333.4614!, 385.6305!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(59.72943!, 40.0!)
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
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(393.1908!, 385.6274!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(59.15826!, 40.0!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Amount"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(486.3491!, 385.6271!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(49.50504!, 40.00012!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Dis." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Val"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(0.6750733!, 385.6305!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(30.0!, 39.99667!)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Sr. No"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabelMSME
        '
        Me.XrLabelMSME.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabelMSME.CanGrow = False
        Me.XrLabelMSME.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabelMSME.LocationFloat = New DevExpress.Utils.PointFloat(0.8693907!, 132.7918!)
        Me.XrLabelMSME.Multiline = True
        Me.XrLabelMSME.Name = "XrLabelMSME"
        Me.XrLabelMSME.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelMSME.SizeF = New System.Drawing.SizeF(262.4125!, 19.91692!)
        Me.XrLabelMSME.StylePriority.UseBorders = False
        Me.XrLabelMSME.StylePriority.UseFont = False
        Me.XrLabelMSME.StylePriority.UseTextAlignment = False
        Me.XrLabelMSME.Text = "MSME Registration No: UDYAM-GJ-01-0008103"
        Me.XrLabelMSME.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelIrn
        '
        Me.XrLabelIrn.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabelIrn.CanGrow = False
        Me.XrLabelIrn.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabelIrn.LocationFloat = New DevExpress.Utils.PointFloat(0.8693905!, 87.99994!)
        Me.XrLabelIrn.Multiline = True
        Me.XrLabelIrn.Name = "XrLabelIrn"
        Me.XrLabelIrn.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelIrn.SizeF = New System.Drawing.SizeF(777.99!, 14.12517!)
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
        Me.XrLabelAck.LocationFloat = New DevExpress.Utils.PointFloat(0.8693774!, 102.1251!)
        Me.XrLabelAck.Multiline = True
        Me.XrLabelAck.Name = "XrLabelAck"
        Me.XrLabelAck.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAck.SizeF = New System.Drawing.SizeF(777.99!, 14.0!)
        Me.XrLabelAck.StylePriority.UseBorders = False
        Me.XrLabelAck.StylePriority.UseFont = False
        Me.XrLabelAck.StylePriority.UseTextAlignment = False
        Me.XrLabelAck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.BorderColor = System.Drawing.Color.Black
        Me.XrPictureBox3.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(688.64!, 0!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(89.55884!, 87.99999!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox3.StylePriority.UseBorderColor = False
        Me.XrPictureBox3.StylePriority.UseBorders = False
        '
        'XrLabelISO
        '
        Me.XrLabelISO.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabelISO.CanGrow = False
        Me.XrLabelISO.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic), DevExpress.Drawing.DXFontStyle), DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabelISO.LocationFloat = New DevExpress.Utils.PointFloat(263.2819!, 132.7918!)
        Me.XrLabelISO.Multiline = True
        Me.XrLabelISO.Name = "XrLabelISO"
        Me.XrLabelISO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelISO.SizeF = New System.Drawing.SizeF(349.8801!, 19.91689!)
        Me.XrLabelISO.StylePriority.UseBorders = False
        Me.XrLabelISO.StylePriority.UseFont = False
        Me.XrLabelISO.StylePriority.UseTextAlignment = False
        Me.XrLabelISO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(245.3744!, 348.4191!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(49.48999!, 18.45844!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "PANNo : "
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(627.85!, 348.4191!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(49.48999!, 18.45844!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "PANNo : "
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsigneePanNo]")})
        Me.XrLabel27.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(677.3401!, 348.4191!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(101.3001!, 18.60425!)
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel35
        '
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel35.CanGrow = False
        Me.XrLabel35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReceiverPanNo]")})
        Me.XrLabel35.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(294.8643!, 348.4187!)
        Me.XrLabel35.Multiline = True
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(98.5401!, 18.45889!)
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel37
        '
        Me.XrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsigneeAddress]")})
        Me.XrLabel37.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(446.4043!, 317.3779!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(332.2357!, 31.04105!)
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseFont = False
        '
        'XrLabel40
        '
        Me.XrLabel40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReceiverAddress]")})
        Me.XrLabel40.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(53.86156!, 317.378!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(339.5081!, 31.04092!)
        Me.XrLabel40.StylePriority.UseFont = False
        '
        'XrLabel42
        '
        Me.XrLabel42.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel42.CanGrow = False
        Me.XrLabel42.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(393.4044!, 317.3779!)
        Me.XrLabel42.Multiline = True
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(53.00006!, 18.60428!)
        Me.XrLabel42.StylePriority.UseBorders = False
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "Address : "
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel48
        '
        Me.XrLabel48.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel48.CanGrow = False
        Me.XrLabel48.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(0.8538008!, 317.3779!)
        Me.XrLabel48.Multiline = True
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(53.00775!, 18.74997!)
        Me.XrLabel48.StylePriority.UseBorders = False
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "Address : "
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel51
        '
        Me.XrLabel51.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel51.CanGrow = False
        Me.XrLabel51.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsigneeState]")})
        Me.XrLabel51.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(446.4043!, 367.023!)
        Me.XrLabel51.Multiline = True
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(181.4456!, 18.6041!)
        Me.XrLabel51.StylePriority.UseBorders = False
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel101
        '
        Me.XrLabel101.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel101.CanGrow = False
        Me.XrLabel101.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsigneeStateCode]")})
        Me.XrLabel101.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel101.LocationFloat = New DevExpress.Utils.PointFloat(700.0475!, 367.0233!)
        Me.XrLabel101.Multiline = True
        Me.XrLabel101.Name = "XrLabel101"
        Me.XrLabel101.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel101.SizeF = New System.Drawing.SizeF(78.59253!, 18.60379!)
        Me.XrLabel101.StylePriority.UseBorders = False
        Me.XrLabel101.StylePriority.UseFont = False
        Me.XrLabel101.StylePriority.UseTextAlignment = False
        Me.XrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel105
        '
        Me.XrLabel105.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel105.CanGrow = False
        Me.XrLabel105.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel105.LocationFloat = New DevExpress.Utils.PointFloat(627.85!, 367.023!)
        Me.XrLabel105.Multiline = True
        Me.XrLabel105.Name = "XrLabel105"
        Me.XrLabel105.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel105.SizeF = New System.Drawing.SizeF(72.19739!, 18.6041!)
        Me.XrLabel105.StylePriority.UseBorders = False
        Me.XrLabel105.StylePriority.UseFont = False
        Me.XrLabel105.StylePriority.UseTextAlignment = False
        Me.XrLabel105.Text = "State Code  :"
        Me.XrLabel105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel108
        '
        Me.XrLabel108.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel108.CanGrow = False
        Me.XrLabel108.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel108.LocationFloat = New DevExpress.Utils.PointFloat(393.4035!, 367.023!)
        Me.XrLabel108.Multiline = True
        Me.XrLabel108.Name = "XrLabel108"
        Me.XrLabel108.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel108.SizeF = New System.Drawing.SizeF(53.00085!, 18.6041!)
        Me.XrLabel108.StylePriority.UseBorders = False
        Me.XrLabel108.StylePriority.UseFont = False
        Me.XrLabel108.StylePriority.UseTextAlignment = False
        Me.XrLabel108.Text = "State      : "
        Me.XrLabel108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel109
        '
        Me.XrLabel109.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel109.CanGrow = False
        Me.XrLabel109.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsigneeGSTIN]")})
        Me.XrLabel109.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel109.LocationFloat = New DevExpress.Utils.PointFloat(446.4043!, 348.4189!)
        Me.XrLabel109.Multiline = True
        Me.XrLabel109.Name = "XrLabel109"
        Me.XrLabel109.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel109.SizeF = New System.Drawing.SizeF(181.4456!, 18.60425!)
        Me.XrLabel109.StylePriority.UseBorders = False
        Me.XrLabel109.StylePriority.UseFont = False
        Me.XrLabel109.StylePriority.UseTextAlignment = False
        Me.XrLabel109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel112
        '
        Me.XrLabel112.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel112.CanGrow = False
        Me.XrLabel112.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel112.LocationFloat = New DevExpress.Utils.PointFloat(393.4044!, 348.4189!)
        Me.XrLabel112.Multiline = True
        Me.XrLabel112.Name = "XrLabel112"
        Me.XrLabel112.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel112.SizeF = New System.Drawing.SizeF(53.00006!, 18.60425!)
        Me.XrLabel112.StylePriority.UseBorders = False
        Me.XrLabel112.StylePriority.UseFont = False
        Me.XrLabel112.StylePriority.UseTextAlignment = False
        Me.XrLabel112.Text = "GSTIN    : "
        Me.XrLabel112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel113
        '
        Me.XrLabel113.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel113.CanGrow = False
        Me.XrLabel113.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsigneeName]")})
        Me.XrLabel113.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel113.LocationFloat = New DevExpress.Utils.PointFloat(446.4043!, 298.7735!)
        Me.XrLabel113.Multiline = True
        Me.XrLabel113.Name = "XrLabel113"
        Me.XrLabel113.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel113.SizeF = New System.Drawing.SizeF(332.2357!, 18.60428!)
        Me.XrLabel113.StylePriority.UseBorders = False
        Me.XrLabel113.StylePriority.UseFont = False
        Me.XrLabel113.StylePriority.UseTextAlignment = False
        Me.XrLabel113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel114
        '
        Me.XrLabel114.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel114.CanGrow = False
        Me.XrLabel114.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel114.LocationFloat = New DevExpress.Utils.PointFloat(393.4044!, 298.7735!)
        Me.XrLabel114.Multiline = True
        Me.XrLabel114.Name = "XrLabel114"
        Me.XrLabel114.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel114.SizeF = New System.Drawing.SizeF(53.0!, 18.6!)
        Me.XrLabel114.StylePriority.UseBorders = False
        Me.XrLabel114.StylePriority.UseFont = False
        Me.XrLabel114.StylePriority.UseTextAlignment = False
        Me.XrLabel114.Text = "Name     : "
        Me.XrLabel114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel116
        '
        Me.XrLabel116.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel116.CanGrow = False
        Me.XrLabel116.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReceiverStateCode]")})
        Me.XrLabel116.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel116.LocationFloat = New DevExpress.Utils.PointFloat(315.3745!, 367.0229!)
        Me.XrLabel116.Multiline = True
        Me.XrLabel116.Name = "XrLabel116"
        Me.XrLabel116.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel116.SizeF = New System.Drawing.SizeF(77.99515!, 18.60422!)
        Me.XrLabel116.StylePriority.UseBorders = False
        Me.XrLabel116.StylePriority.UseFont = False
        Me.XrLabel116.StylePriority.UseTextAlignment = False
        Me.XrLabel116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel124
        '
        Me.XrLabel124.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel124.CanGrow = False
        Me.XrLabel124.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel124.LocationFloat = New DevExpress.Utils.PointFloat(245.3744!, 367.0229!)
        Me.XrLabel124.Multiline = True
        Me.XrLabel124.Name = "XrLabel124"
        Me.XrLabel124.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel124.SizeF = New System.Drawing.SizeF(70.0!, 18.60419!)
        Me.XrLabel124.StylePriority.UseBorders = False
        Me.XrLabel124.StylePriority.UseFont = False
        Me.XrLabel124.StylePriority.UseTextAlignment = False
        Me.XrLabel124.Text = "State Code :"
        Me.XrLabel124.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel125
        '
        Me.XrLabel125.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel125.CanGrow = False
        Me.XrLabel125.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReceiverState]")})
        Me.XrLabel125.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel125.LocationFloat = New DevExpress.Utils.PointFloat(53.86156!, 367.0229!)
        Me.XrLabel125.Multiline = True
        Me.XrLabel125.Name = "XrLabel125"
        Me.XrLabel125.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel125.SizeF = New System.Drawing.SizeF(191.5128!, 18.60419!)
        Me.XrLabel125.StylePriority.UseBorders = False
        Me.XrLabel125.StylePriority.UseFont = False
        Me.XrLabel125.StylePriority.UseTextAlignment = False
        Me.XrLabel125.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel128
        '
        Me.XrLabel128.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel128.CanGrow = False
        Me.XrLabel128.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel128.LocationFloat = New DevExpress.Utils.PointFloat(0.8538008!, 367.0229!)
        Me.XrLabel128.Multiline = True
        Me.XrLabel128.Name = "XrLabel128"
        Me.XrLabel128.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel128.SizeF = New System.Drawing.SizeF(53.00776!, 18.60419!)
        Me.XrLabel128.StylePriority.UseBorders = False
        Me.XrLabel128.StylePriority.UseFont = False
        Me.XrLabel128.StylePriority.UseTextAlignment = False
        Me.XrLabel128.Text = "State      : "
        Me.XrLabel128.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel130
        '
        Me.XrLabel130.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel130.CanGrow = False
        Me.XrLabel130.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReceiverGSTIN]")})
        Me.XrLabel130.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel130.LocationFloat = New DevExpress.Utils.PointFloat(53.86156!, 348.4189!)
        Me.XrLabel130.Multiline = True
        Me.XrLabel130.Name = "XrLabel130"
        Me.XrLabel130.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel130.SizeF = New System.Drawing.SizeF(191.5128!, 18.45862!)
        Me.XrLabel130.StylePriority.UseBorders = False
        Me.XrLabel130.StylePriority.UseFont = False
        Me.XrLabel130.StylePriority.UseTextAlignment = False
        Me.XrLabel130.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel131
        '
        Me.XrLabel131.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel131.CanGrow = False
        Me.XrLabel131.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel131.LocationFloat = New DevExpress.Utils.PointFloat(0.8539915!, 348.4187!)
        Me.XrLabel131.Multiline = True
        Me.XrLabel131.Name = "XrLabel131"
        Me.XrLabel131.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel131.SizeF = New System.Drawing.SizeF(53.00761!, 18.60428!)
        Me.XrLabel131.StylePriority.UseBorders = False
        Me.XrLabel131.StylePriority.UseFont = False
        Me.XrLabel131.StylePriority.UseTextAlignment = False
        Me.XrLabel131.Text = "GSTIN    : "
        Me.XrLabel131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel132
        '
        Me.XrLabel132.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel132.CanGrow = False
        Me.XrLabel132.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReceiverName]")})
        Me.XrLabel132.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel132.LocationFloat = New DevExpress.Utils.PointFloat(53.86156!, 298.7735!)
        Me.XrLabel132.Multiline = True
        Me.XrLabel132.Name = "XrLabel132"
        Me.XrLabel132.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel132.SizeF = New System.Drawing.SizeF(339.5166!, 18.60428!)
        Me.XrLabel132.StylePriority.UseBorders = False
        Me.XrLabel132.StylePriority.UseFont = False
        Me.XrLabel132.StylePriority.UseTextAlignment = False
        Me.XrLabel132.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel134
        '
        Me.XrLabel134.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel134.CanGrow = False
        Me.XrLabel134.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel134.LocationFloat = New DevExpress.Utils.PointFloat(0.8616209!, 298.7735!)
        Me.XrLabel134.Multiline = True
        Me.XrLabel134.Name = "XrLabel134"
        Me.XrLabel134.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel134.SizeF = New System.Drawing.SizeF(53.0!, 18.6!)
        Me.XrLabel134.StylePriority.UseBorders = False
        Me.XrLabel134.StylePriority.UseFont = False
        Me.XrLabel134.StylePriority.UseTextAlignment = False
        Me.XrLabel134.Text = "Name     : "
        Me.XrLabel134.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel135
        '
        Me.XrLabel135.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel135.CanGrow = False
        Me.XrLabel135.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel135.LocationFloat = New DevExpress.Utils.PointFloat(393.4044!, 280.4606!)
        Me.XrLabel135.Multiline = True
        Me.XrLabel135.Name = "XrLabel135"
        Me.XrLabel135.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel135.SizeF = New System.Drawing.SizeF(385.2356!, 18.3129!)
        Me.XrLabel135.StylePriority.UseBorders = False
        Me.XrLabel135.StylePriority.UseFont = False
        Me.XrLabel135.StylePriority.UseTextAlignment = False
        Me.XrLabel135.Text = "Details Of Consignee | Shipped to :"
        Me.XrLabel135.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel136
        '
        Me.XrLabel136.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel136.CanGrow = False
        Me.XrLabel136.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel136.LocationFloat = New DevExpress.Utils.PointFloat(0.8616209!, 280.4606!)
        Me.XrLabel136.Multiline = True
        Me.XrLabel136.Name = "XrLabel136"
        Me.XrLabel136.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel136.SizeF = New System.Drawing.SizeF(392.5166!, 18.31287!)
        Me.XrLabel136.StylePriority.UseBorders = False
        Me.XrLabel136.StylePriority.UseFont = False
        Me.XrLabel136.StylePriority.UseTextAlignment = False
        Me.XrLabel136.Text = "Details Of Receiver | Billed to :"
        Me.XrLabel136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel137
        '
        Me.XrLabel137.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel137.CanGrow = False
        Me.XrLabel137.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SupplyTo]")})
        Me.XrLabel137.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel137.LocationFloat = New DevExpress.Utils.PointFloat(694.3723!, 242.7713!)
        Me.XrLabel137.Multiline = True
        Me.XrLabel137.Name = "XrLabel137"
        Me.XrLabel137.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel137.SizeF = New System.Drawing.SizeF(84.26776!, 18.93942!)
        Me.XrLabel137.StylePriority.UseBorders = False
        Me.XrLabel137.StylePriority.UseFont = False
        Me.XrLabel137.StylePriority.UseTextAlignment = False
        Me.XrLabel137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel142
        '
        Me.XrLabel142.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel142.CanGrow = False
        Me.XrLabel142.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AgainstForm]")})
        Me.XrLabel142.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel142.LocationFloat = New DevExpress.Utils.PointFloat(474.378!, 243.1064!)
        Me.XrLabel142.Multiline = True
        Me.XrLabel142.Name = "XrLabel142"
        Me.XrLabel142.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel142.SizeF = New System.Drawing.SizeF(141.5699!, 18.56059!)
        Me.XrLabel142.StylePriority.UseBorders = False
        Me.XrLabel142.StylePriority.UseFont = False
        Me.XrLabel142.StylePriority.UseTextAlignment = False
        Me.XrLabel142.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel144
        '
        Me.XrLabel144.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel144.CanGrow = False
        Me.XrLabel144.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel144.LocationFloat = New DevExpress.Utils.PointFloat(393.3779!, 243.1064!)
        Me.XrLabel144.Multiline = True
        Me.XrLabel144.Name = "XrLabel144"
        Me.XrLabel144.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel144.SizeF = New System.Drawing.SizeF(81.0!, 18.6!)
        Me.XrLabel144.StylePriority.UseBorders = False
        Me.XrLabel144.StylePriority.UseFont = False
        Me.XrLabel144.StylePriority.UseTextAlignment = False
        Me.XrLabel144.Text = "Way Bill No.  :"
        Me.XrLabel144.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel145
        '
        Me.XrLabel145.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel145.CanGrow = False
        Me.XrLabel145.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel145.LocationFloat = New DevExpress.Utils.PointFloat(615.9745!, 242.7713!)
        Me.XrLabel145.Multiline = True
        Me.XrLabel145.Name = "XrLabel145"
        Me.XrLabel145.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel145.SizeF = New System.Drawing.SizeF(78.39783!, 18.74574!)
        Me.XrLabel145.StylePriority.UseBorders = False
        Me.XrLabel145.StylePriority.UseFont = False
        Me.XrLabel145.StylePriority.UseTextAlignment = False
        Me.XrLabel145.Text = "Supply To       :"
        Me.XrLabel145.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel146
        '
        Me.XrLabel146.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel146.CanGrow = False
        Me.XrLabel146.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel146.LocationFloat = New DevExpress.Utils.PointFloat(278.5425!, 261.7064!)
        Me.XrLabel146.Multiline = True
        Me.XrLabel146.Name = "XrLabel146"
        Me.XrLabel146.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel146.SizeF = New System.Drawing.SizeF(114.8356!, 18.75429!)
        Me.XrLabel146.StylePriority.UseBorders = False
        Me.XrLabel146.StylePriority.UseFont = False
        Me.XrLabel146.StylePriority.UseTextAlignment = False
        Me.XrLabel146.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel147
        '
        Me.XrLabel147.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel147.CanGrow = False
        Me.XrLabel147.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel147.LocationFloat = New DevExpress.Utils.PointFloat(197.5425!, 261.7106!)
        Me.XrLabel147.Multiline = True
        Me.XrLabel147.Name = "XrLabel147"
        Me.XrLabel147.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel147.SizeF = New System.Drawing.SizeF(81.0!, 18.74997!)
        Me.XrLabel147.StylePriority.UseBorders = False
        Me.XrLabel147.StylePriority.UseFont = False
        Me.XrLabel147.StylePriority.UseTextAlignment = False
        Me.XrLabel147.Text = "State Code :"
        Me.XrLabel147.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel148
        '
        Me.XrLabel148.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel148.CanGrow = False
        Me.XrLabel148.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel148.LocationFloat = New DevExpress.Utils.PointFloat(88.86166!, 261.7106!)
        Me.XrLabel148.Multiline = True
        Me.XrLabel148.Name = "XrLabel148"
        Me.XrLabel148.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel148.SizeF = New System.Drawing.SizeF(108.6809!, 18.75002!)
        Me.XrLabel148.StylePriority.UseBorders = False
        Me.XrLabel148.StylePriority.UseFont = False
        Me.XrLabel148.StylePriority.UseTextAlignment = False
        Me.XrLabel148.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel149
        '
        Me.XrLabel149.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel149.CanGrow = False
        Me.XrLabel149.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel149.LocationFloat = New DevExpress.Utils.PointFloat(0.8616209!, 261.7106!)
        Me.XrLabel149.Multiline = True
        Me.XrLabel149.Name = "XrLabel149"
        Me.XrLabel149.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel149.SizeF = New System.Drawing.SizeF(88.0!, 18.75002!)
        Me.XrLabel149.StylePriority.UseBorders = False
        Me.XrLabel149.StylePriority.UseFont = False
        Me.XrLabel149.StylePriority.UseTextAlignment = False
        Me.XrLabel149.Text = "State               :"
        Me.XrLabel149.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel170
        '
        Me.XrLabel170.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel170.CanGrow = False
        Me.XrLabel170.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ARNNo]")})
        Me.XrLabel170.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel170.LocationFloat = New DevExpress.Utils.PointFloat(88.35406!, 242.7712!)
        Me.XrLabel170.Multiline = True
        Me.XrLabel170.Name = "XrLabel170"
        Me.XrLabel170.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel170.SizeF = New System.Drawing.SizeF(151.6122!, 18.93944!)
        Me.XrLabel170.StylePriority.UseBorders = False
        Me.XrLabel170.StylePriority.UseFont = False
        Me.XrLabel170.StylePriority.UseTextAlignment = False
        Me.XrLabel170.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel171
        '
        Me.XrLabel171.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel171.CanGrow = False
        Me.XrLabel171.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel171.LocationFloat = New DevExpress.Utils.PointFloat(0.8616845!, 242.7712!)
        Me.XrLabel171.Multiline = True
        Me.XrLabel171.Name = "XrLabel171"
        Me.XrLabel171.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel171.SizeF = New System.Drawing.SizeF(87.49239!, 18.93944!)
        Me.XrLabel171.StylePriority.UseBorders = False
        Me.XrLabel171.StylePriority.UseFont = False
        Me.XrLabel171.StylePriority.UseTextAlignment = False
        Me.XrLabel171.Text = "ARN No  :"
        Me.XrLabel171.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel172
        '
        Me.XrLabel172.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel172.CanGrow = False
        Me.XrLabel172.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ARNDate]")})
        Me.XrLabel172.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel172.LocationFloat = New DevExpress.Utils.PointFloat(280.9662!, 242.7713!)
        Me.XrLabel172.Multiline = True
        Me.XrLabel172.Name = "XrLabel172"
        Me.XrLabel172.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel172.SizeF = New System.Drawing.SizeF(112.4119!, 18.74574!)
        Me.XrLabel172.StylePriority.UseBorders = False
        Me.XrLabel172.StylePriority.UseFont = False
        Me.XrLabel172.StylePriority.UseTextAlignment = False
        Me.XrLabel172.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel172.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel173
        '
        Me.XrLabel173.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel173.CanGrow = False
        Me.XrLabel173.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel173.LocationFloat = New DevExpress.Utils.PointFloat(239.9663!, 242.7713!)
        Me.XrLabel173.Multiline = True
        Me.XrLabel173.Name = "XrLabel173"
        Me.XrLabel173.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel173.SizeF = New System.Drawing.SizeF(40.99997!, 18.74574!)
        Me.XrLabel173.StylePriority.UseBorders = False
        Me.XrLabel173.StylePriority.UseFont = False
        Me.XrLabel173.StylePriority.UseTextAlignment = False
        Me.XrLabel173.Text = "Date :"
        Me.XrLabel173.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel174
        '
        Me.XrLabel174.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel174.CanGrow = False
        Me.XrLabel174.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel174.LocationFloat = New DevExpress.Utils.PointFloat(393.4044!, 261.7106!)
        Me.XrLabel174.Multiline = True
        Me.XrLabel174.Name = "XrLabel174"
        Me.XrLabel174.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel174.SizeF = New System.Drawing.SizeF(385.2356!, 18.75002!)
        Me.XrLabel174.StylePriority.UseBorders = False
        Me.XrLabel174.StylePriority.UseFont = False
        Me.XrLabel174.StylePriority.UseTextAlignment = False
        Me.XrLabel174.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel174.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Calibri", 14.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0.8693734!, 152.7087!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(612.2926!, 17.0!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "            TAX  INVOICE"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel44.CanGrow = False
        Me.XrLabel44.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(0.8693774!, 205.5626!)
        Me.XrLabel44.Multiline = True
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(85.9659!, 18.60429!)
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "Invoice No.     : "
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel45
        '
        Me.XrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel45.CanGrow = False
        Me.XrLabel45.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(0.8693774!, 224.1669!)
        Me.XrLabel45.Multiline = True
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(85.9659!, 18.60428!)
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "Supply From   :"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel46
        '
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel46.CanGrow = False
        Me.XrLabel46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceNo]")})
        Me.XrLabel46.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(86.8353!, 205.7085!)
        Me.XrLabel46.Multiline = True
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(153.1386!, 18.45853!)
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
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(86.83536!, 224.1669!)
        Me.XrLabel47.Multiline = True
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(306.5507!, 18.60428!)
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
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(642.6147!, 132.7918!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(136.0254!, 54.1665!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Original for Receipant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Duplicate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Triplicate "
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel54
        '
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel54.CanGrow = False
        Me.XrLabel54.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(0.8693774!, 187.1041!)
        Me.XrLabel54.Multiline = True
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(85.96591!, 18.45854!)
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "Challan No.     :"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel76
        '
        Me.XrLabel76.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel76.CanGrow = False
        Me.XrLabel76.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel76.LocationFloat = New DevExpress.Utils.PointFloat(613.162!, 132.7918!)
        Me.XrLabel76.Multiline = True
        Me.XrLabel76.Name = "XrLabel76"
        Me.XrLabel76.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel76.SizeF = New System.Drawing.SizeF(29.45264!, 18.45847!)
        Me.XrLabel76.StylePriority.UseBorders = False
        Me.XrLabel76.StylePriority.UseFont = False
        Me.XrLabel76.StylePriority.UseTextAlignment = False
        Me.XrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel77
        '
        Me.XrLabel77.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel77.CanGrow = False
        Me.XrLabel77.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel77.LocationFloat = New DevExpress.Utils.PointFloat(613.162!, 151.2502!)
        Me.XrLabel77.Multiline = True
        Me.XrLabel77.Name = "XrLabel77"
        Me.XrLabel77.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel77.SizeF = New System.Drawing.SizeF(29.45264!, 18.45847!)
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
        Me.XrLabel78.LocationFloat = New DevExpress.Utils.PointFloat(613.162!, 169.7086!)
        Me.XrLabel78.Multiline = True
        Me.XrLabel78.Name = "XrLabel78"
        Me.XrLabel78.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel78.SizeF = New System.Drawing.SizeF(29.45264!, 17.24971!)
        Me.XrLabel78.StylePriority.UseBorders = False
        Me.XrLabel78.StylePriority.UseFont = False
        Me.XrLabel78.StylePriority.UseTextAlignment = False
        Me.XrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel117
        '
        Me.XrLabel117.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel117.CanGrow = False
        Me.XrLabel117.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChallanNo]")})
        Me.XrLabel117.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel117.LocationFloat = New DevExpress.Utils.PointFloat(86.8353!, 187.1042!)
        Me.XrLabel117.Multiline = True
        Me.XrLabel117.Name = "XrLabel117"
        Me.XrLabel117.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel117.SizeF = New System.Drawing.SizeF(153.1386!, 18.60426!)
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
        Me.XrLabel118.LocationFloat = New DevExpress.Utils.PointFloat(239.974!, 187.3956!)
        Me.XrLabel118.Multiline = True
        Me.XrLabel118.Name = "XrLabel118"
        Me.XrLabel118.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel118.SizeF = New System.Drawing.SizeF(41.0!, 18.31281!)
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
        Me.XrLabel119.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChallanDate]")})
        Me.XrLabel119.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel119.LocationFloat = New DevExpress.Utils.PointFloat(280.9739!, 186.9583!)
        Me.XrLabel119.Multiline = True
        Me.XrLabel119.Name = "XrLabel119"
        Me.XrLabel119.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel119.SizeF = New System.Drawing.SizeF(112.4119!, 18.89587!)
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
        Me.XrLabel120.LocationFloat = New DevExpress.Utils.PointFloat(239.974!, 205.8542!)
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
        Me.XrLabel121.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceDate]")})
        Me.XrLabel121.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel121.LocationFloat = New DevExpress.Utils.PointFloat(280.9739!, 205.8542!)
        Me.XrLabel121.Multiline = True
        Me.XrLabel121.Name = "XrLabel121"
        Me.XrLabel121.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel121.SizeF = New System.Drawing.SizeF(112.4119!, 18.31281!)
        Me.XrLabel121.StylePriority.UseBorders = False
        Me.XrLabel121.StylePriority.UseFont = False
        Me.XrLabel121.StylePriority.UseTextAlignment = False
        Me.XrLabel121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel121.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.5075734!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(88.0!, 88.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox1.StylePriority.UseBorders = False
        '
        'XrLabel59
        '
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel59.CanGrow = False
        Me.XrLabel59.Font = New DevExpress.Drawing.DXFont("Calibri", 20.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(88.50758!, 0!)
        Me.XrLabel59.Multiline = True
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(600.1324!, 33.99998!)
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel91
        '
        Me.XrLabel91.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel91.CanGrow = False
        Me.XrLabel91.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel91.LocationFloat = New DevExpress.Utils.PointFloat(88.50758!, 69.99998!)
        Me.XrLabel91.Multiline = True
        Me.XrLabel91.Name = "XrLabel91"
        Me.XrLabel91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel91.SizeF = New System.Drawing.SizeF(600.1324!, 17.99998!)
        Me.XrLabel91.StylePriority.UseBorders = False
        Me.XrLabel91.StylePriority.UseFont = False
        Me.XrLabel91.StylePriority.UseTextAlignment = False
        Me.XrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(88.50757!, 52.0!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(600.1324!, 17.99998!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(88.50758!, 33.99999!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(599.6608!, 17.99998!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel90
        '
        Me.XrLabel90.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel90.CanGrow = False
        Me.XrLabel90.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel90.LocationFloat = New DevExpress.Utils.PointFloat(681.11!, 116.1251!)
        Me.XrLabel90.Multiline = True
        Me.XrLabel90.Name = "XrLabel90"
        Me.XrLabel90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel90.SizeF = New System.Drawing.SizeF(97.16827!, 16.66667!)
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
        Me.XrLabel89.LocationFloat = New DevExpress.Utils.PointFloat(405.324!, 116.1252!)
        Me.XrLabel89.Multiline = True
        Me.XrLabel89.Name = "XrLabel89"
        Me.XrLabel89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel89.SizeF = New System.Drawing.SizeF(275.786!, 16.66667!)
        Me.XrLabel89.StylePriority.UseBorders = False
        Me.XrLabel89.StylePriority.UseFont = False
        Me.XrLabel89.StylePriority.UseTextAlignment = False
        Me.XrLabel89.Text = "PAN No :"
        Me.XrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel28
        '
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel28.CanGrow = False
        Me.XrLabel28.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(88.50758!, 116.1251!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(316.8163!, 16.66667!)
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.5075693!, 116.1251!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(88.00001!, 16.66667!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "GSTIN: "
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.861622!, 169.7086!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(612.3004!, 17.24969!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "SUPPLY MEANT FOR EXPORT UNDER BOND OR LETTER OF UNDERTAKING WITHOUT  PAYMENT OF I" &
    "NTEGRATED  TAX"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel123
        '
        Me.XrLabel123.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel123.CanGrow = False
        Me.XrLabel123.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PODate]")})
        Me.XrLabel123.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel123.LocationFloat = New DevExpress.Utils.PointFloat(694.3538!, 224.0211!)
        Me.XrLabel123.Multiline = True
        Me.XrLabel123.Name = "XrLabel123"
        Me.XrLabel123.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel123.SizeF = New System.Drawing.SizeF(84.28625!, 18.75006!)
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
        Me.XrLabel122.LocationFloat = New DevExpress.Utils.PointFloat(615.956!, 224.0211!)
        Me.XrLabel122.Multiline = True
        Me.XrLabel122.Name = "XrLabel122"
        Me.XrLabel122.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel122.SizeF = New System.Drawing.SizeF(78.39789!, 18.75006!)
        Me.XrLabel122.StylePriority.UseBorders = False
        Me.XrLabel122.StylePriority.UseFont = False
        Me.XrLabel122.StylePriority.UseTextAlignment = False
        Me.XrLabel122.Text = "PO Date          :"
        Me.XrLabel122.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel43.CanGrow = False
        Me.XrLabel43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PO]")})
        Me.XrLabel43.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(474.386!, 224.1669!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(141.5699!, 18.60429!)
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
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(393.3858!, 224.1669!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(81.00018!, 18.9395!)
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "P. O.                :"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TransportationMode]")})
        Me.XrLabel34.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(516.6624!, 186.9585!)
        Me.XrLabel34.Multiline = True
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(261.9777!, 18.45847!)
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
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(393.3858!, 187.1042!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(123.2764!, 18.45847!)
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Transportation Mode  : "
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PartyDCDate]")})
        Me.XrLabel21.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(694.3538!, 205.4169!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(84.28619!, 18.60414!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel21.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(615.9561!, 205.5626!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(78.39783!, 18.4585!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Party DC Date:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PartyDCNo]")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(474.386!, 205.5626!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(141.5699!, 18.60443!)
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
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(393.4121!, 205.5626!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(80.97397!, 18.60445!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Party DC No   :"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine2.EndBand = Me.GroupHeader1
        Me.XrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(0.8693747!, 348.2722!)
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.GroupHeader1
        Me.XrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(0.8693747!, 336.1279!)
        Me.XrCrossBandLine2.WidthF = 1.041668!
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine3.EndBand = Me.GroupHeader1
        Me.XrCrossBandLine3.EndPointFloat = New DevExpress.Utils.PointFloat(393.4121!, 348.2722!)
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.GroupHeader1
        Me.XrCrossBandLine3.StartPointFloat = New DevExpress.Utils.PointFloat(393.4121!, 335.9822!)
        Me.XrCrossBandLine3.WidthF = 1.041656!
        '
        'XR_SEZSalesWithLUT
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.GroupFooter2, Me.GroupHeader1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine3, Me.XrCrossBandLine2, Me.XrCrossBandLine4, Me.XrCrossBandLine1})
        Me.DataAdapter = Me.DT_InvoiceTableAdapter1
        Me.DataMember = "DT_Invoice"
        Me.DataSource = Me.DS_Invoice2
        Me.FilterString = "[InvoiceID] = ?Invoice"
        Me.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10.0!)
        Me.Margins = New DevExpress.Drawing.DXMargins(22.0!, 25.0!, 50.0!, 0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Invoice})
        Me.Version = "23.2"
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel88 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel102 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel103 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel104 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel106 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel107 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel110 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel111 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel157 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel158 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel159 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel160 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel161 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel115 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel129 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel138 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel139 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel133 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel150 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel143 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel140 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel153 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel141 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel155 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel156 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel162 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel163 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel164 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TaxableValueLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel166 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel167 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel168 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalGSTCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PackingChargeCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TaxableValLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TaxableValueCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents RoundOffCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GrandTotalLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GrandTotalCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel76 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel77 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel78 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel117 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel118 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel119 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel120 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel121 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel91 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel90 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel89 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel123 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel122 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel101 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel105 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel108 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel109 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel112 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel113 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel114 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel116 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel124 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel125 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel128 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel130 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel131 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel132 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel134 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel135 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel136 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel137 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel142 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel144 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel145 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel146 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel147 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel148 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel149 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel170 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel171 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel172 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel173 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel174 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel81 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
End Class
