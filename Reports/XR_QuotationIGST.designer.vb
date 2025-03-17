<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_QuotationIGST
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
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_QuotationIGST))
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
        Me.TermsXrTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel162 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel164 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel163 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel151 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel138 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel153 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel143 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel155 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel139 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel157 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel140 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel159 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel141 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel161 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel148 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel146 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel147 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel129 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel130 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel131 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel89 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel90 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel81 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel92 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel117 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel118 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel119 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel120 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel121 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel126 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel91 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsXrTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 14.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBorders = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1})
        Me.TopMargin.HeightF = 50.39743!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.007947285!, 48.39423!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(777.9925!, 2.003204!)
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
        Me.PageFooter.HeightF = 23.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPageInfo1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(678.0!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseBorders = False
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.TermsXrTable, Me.XrLabel162, Me.XrLabel164, Me.XrLabel12, Me.XrLabel163, Me.XrTable4, Me.XrLabel1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel5, Me.XrLabel151, Me.XrLabel138, Me.XrLabel153, Me.XrLabel143, Me.XrLabel155, Me.XrLabel139, Me.XrLabel157, Me.XrLabel140, Me.XrLabel159, Me.XrLabel141, Me.XrLabel161, Me.XrLabel148, Me.XrLabel146, Me.XrLabel147, Me.XrTable1, Me.XrLabel25, Me.XrLabel37, Me.XrLabel41, Me.XrLabel42, Me.XrLabel129, Me.XrLabel130, Me.XrLabel131, Me.XrTable3})
        Me.GroupFooter2.Expanded = False
        Me.GroupFooter2.HeightF = 274.3801!
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.StylePriority.UseBorders = False
        '
        'TermsXrTable
        '
        Me.TermsXrTable.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.TermsXrTable.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.TermsXrTable.LocationFloat = New DevExpress.Utils.PointFloat(0.06796265!, 268.2247!)
        Me.TermsXrTable.Name = "TermsXrTable"
        Me.TermsXrTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.TermsXrTable.SizeF = New System.Drawing.SizeF(777.9324!, 2.083313!)
        Me.TermsXrTable.StylePriority.UseBorders = False
        Me.TermsXrTable.StylePriority.UseFont = False
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell11, Me.XrTableCell10})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Weight = 0.0803605894145589R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.Weight = 1.92003365561758R
        '
        'XrLabel162
        '
        Me.XrLabel162.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel162.CanGrow = False
        Me.XrLabel162.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Underline)
        Me.XrLabel162.LocationFloat = New DevExpress.Utils.PointFloat(515.4705!, 155.5298!)
        Me.XrLabel162.Multiline = True
        Me.XrLabel162.Name = "XrLabel162"
        Me.XrLabel162.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel162.SizeF = New System.Drawing.SizeF(262.53!, 17.70583!)
        Me.XrLabel162.StylePriority.UseBorders = False
        Me.XrLabel162.StylePriority.UseFont = False
        Me.XrLabel162.StylePriority.UseTextAlignment = False
        Me.XrLabel162.Text = "Certified that the particulars given above are true"
        Me.XrLabel162.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel164
        '
        Me.XrLabel164.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel164.CanGrow = False
        Me.XrLabel164.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel164.LocationFloat = New DevExpress.Utils.PointFloat(515.606!, 173.2356!)
        Me.XrLabel164.Multiline = True
        Me.XrLabel164.Name = "XrLabel164"
        Me.XrLabel164.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel164.SizeF = New System.Drawing.SizeF(262.394!, 53.84912!)
        Me.XrLabel164.StylePriority.UseBorders = False
        Me.XrLabel164.StylePriority.UseFont = False
        Me.XrLabel164.StylePriority.UseTextAlignment = False
        Me.XrLabel164.Text = "FOR PREEVOL TECHNICS,"
        Me.XrLabel164.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(515.47!, 227.0846!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(262.5305!, 41.13713!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "This is a computer generated document hence does not require a signature."
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel163
        '
        Me.XrLabel163.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel163.CanGrow = False
        Me.XrLabel163.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel163.LocationFloat = New DevExpress.Utils.PointFloat(0!, 227.0847!)
        Me.XrLabel163.Multiline = True
        Me.XrLabel163.Name = "XrLabel163"
        Me.XrLabel163.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel163.SizeF = New System.Drawing.SizeF(515.47!, 41.14!)
        Me.XrLabel163.StylePriority.UseBorders = False
        Me.XrLabel163.StylePriority.UseFont = False
        Me.XrLabel163.StylePriority.UseTextAlignment = False
        Me.XrLabel163.Text = "TERMS & CONDITIONS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(778.0004!, 5.0!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell1, Me.XrTableCell4, Me.XrTableCell7, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.23688934326172R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.Weight = 0.959191052716807R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.Weight = 5.17937747953104R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UsePadding = False
        Me.XrTableCell4.Weight = 1.68909907249339R
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
        Me.XrTableCell7.Weight = 1.07320793357209R
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
        Me.XrTableCell12.Weight = 1.09536554629173R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell13.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.Weight = 1.95332829936388R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell14.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UsePadding = False
        Me.XrTableCell14.Weight = 2.72162085463886R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell15.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UsePadding = False
        Me.XrTableCell15.Weight = 1.89396618683912R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell16.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UseBorders = False
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.Weight = 3.66831775711439R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell17.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UsePadding = False
        Me.XrTableCell17.Weight = 1.08954730690893R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell18.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UsePadding = False
        Me.XrTableCell18.Weight = 2.5158441142579R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell19.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UsePadding = False
        Me.XrTableCell19.Weight = 3.37618439306915R
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 86.5627!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(371.449!, 16.16515!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Total GST Amount in Words"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TaxInWords]")})
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 102.7278!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(371.449!, 35.41216!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(371.449!, 86.56259!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(406.5514!, 16.16512!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Total Invoice Amount in Words"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalInWords]")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(371.449!, 102.7278!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(406.5514!, 35.41216!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "0"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel151
        '
        Me.XrLabel151.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel151.CanGrow = False
        Me.XrLabel151.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel151.LocationFloat = New DevExpress.Utils.PointFloat(0!, 173.2358!)
        Me.XrLabel151.Multiline = True
        Me.XrLabel151.Name = "XrLabel151"
        Me.XrLabel151.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel151.SizeF = New System.Drawing.SizeF(99.9765!, 17.85677!)
        Me.XrLabel151.StylePriority.UseBorders = False
        Me.XrLabel151.StylePriority.UseFont = False
        Me.XrLabel151.StylePriority.UseTextAlignment = False
        Me.XrLabel151.Text = "BANK NAME      :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel151.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel138
        '
        Me.XrLabel138.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel138.CanGrow = False
        Me.XrLabel138.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel138.LocationFloat = New DevExpress.Utils.PointFloat(99.97651!, 173.2358!)
        Me.XrLabel138.Multiline = True
        Me.XrLabel138.Name = "XrLabel138"
        Me.XrLabel138.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel138.SizeF = New System.Drawing.SizeF(177.6886!, 17.85681!)
        Me.XrLabel138.StylePriority.UseBorders = False
        Me.XrLabel138.StylePriority.UseFont = False
        Me.XrLabel138.StylePriority.UseTextAlignment = False
        Me.XrLabel138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel153
        '
        Me.XrLabel153.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel153.CanGrow = False
        Me.XrLabel153.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel153.LocationFloat = New DevExpress.Utils.PointFloat(277.8034!, 173.2356!)
        Me.XrLabel153.Multiline = True
        Me.XrLabel153.Name = "XrLabel153"
        Me.XrLabel153.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel153.SizeF = New System.Drawing.SizeF(90.0!, 18.43008!)
        Me.XrLabel153.StylePriority.UseBorders = False
        Me.XrLabel153.StylePriority.UseFont = False
        Me.XrLabel153.StylePriority.UseTextAlignment = False
        Me.XrLabel153.Text = "ACCOUNT NO:"
        Me.XrLabel153.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel143
        '
        Me.XrLabel143.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel143.CanGrow = False
        Me.XrLabel143.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel143.LocationFloat = New DevExpress.Utils.PointFloat(367.8034!, 173.2356!)
        Me.XrLabel143.Multiline = True
        Me.XrLabel143.Name = "XrLabel143"
        Me.XrLabel143.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel143.SizeF = New System.Drawing.SizeF(147.667!, 18.43008!)
        Me.XrLabel143.StylePriority.UseBorders = False
        Me.XrLabel143.StylePriority.UseFont = False
        Me.XrLabel143.StylePriority.UseTextAlignment = False
        Me.XrLabel143.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel155
        '
        Me.XrLabel155.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel155.CanGrow = False
        Me.XrLabel155.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel155.LocationFloat = New DevExpress.Utils.PointFloat(0!, 191.0927!)
        Me.XrLabel155.Multiline = True
        Me.XrLabel155.Name = "XrLabel155"
        Me.XrLabel155.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel155.SizeF = New System.Drawing.SizeF(99.97649!, 18.28665!)
        Me.XrLabel155.StylePriority.UseBorders = False
        Me.XrLabel155.StylePriority.UseFont = False
        Me.XrLabel155.StylePriority.UseTextAlignment = False
        Me.XrLabel155.Text = "BRANCH NAME :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel139
        '
        Me.XrLabel139.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel139.CanGrow = False
        Me.XrLabel139.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel139.LocationFloat = New DevExpress.Utils.PointFloat(99.97651!, 191.0926!)
        Me.XrLabel139.Multiline = True
        Me.XrLabel139.Name = "XrLabel139"
        Me.XrLabel139.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel139.SizeF = New System.Drawing.SizeF(177.6886!, 18.2867!)
        Me.XrLabel139.StylePriority.UseBorders = False
        Me.XrLabel139.StylePriority.UseFont = False
        Me.XrLabel139.StylePriority.UseTextAlignment = False
        Me.XrLabel139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel157
        '
        Me.XrLabel157.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel157.CanGrow = False
        Me.XrLabel157.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel157.LocationFloat = New DevExpress.Utils.PointFloat(277.8035!, 191.6657!)
        Me.XrLabel157.Multiline = True
        Me.XrLabel157.Name = "XrLabel157"
        Me.XrLabel157.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel157.SizeF = New System.Drawing.SizeF(89.99991!, 18.0!)
        Me.XrLabel157.StylePriority.UseBorders = False
        Me.XrLabel157.StylePriority.UseFont = False
        Me.XrLabel157.StylePriority.UseTextAlignment = False
        Me.XrLabel157.Text = "MICR CODE    :"
        Me.XrLabel157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel140
        '
        Me.XrLabel140.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel140.CanGrow = False
        Me.XrLabel140.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel140.LocationFloat = New DevExpress.Utils.PointFloat(367.8034!, 191.6657!)
        Me.XrLabel140.Multiline = True
        Me.XrLabel140.Name = "XrLabel140"
        Me.XrLabel140.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel140.SizeF = New System.Drawing.SizeF(147.667!, 17.99997!)
        Me.XrLabel140.StylePriority.UseBorders = False
        Me.XrLabel140.StylePriority.UseFont = False
        Me.XrLabel140.StylePriority.UseTextAlignment = False
        Me.XrLabel140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel159
        '
        Me.XrLabel159.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel159.CanGrow = False
        Me.XrLabel159.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel159.LocationFloat = New DevExpress.Utils.PointFloat(0!, 209.3791!)
        Me.XrLabel159.Multiline = True
        Me.XrLabel159.Name = "XrLabel159"
        Me.XrLabel159.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel159.SizeF = New System.Drawing.SizeF(99.97649!, 17.70563!)
        Me.XrLabel159.StylePriority.UseBorders = False
        Me.XrLabel159.StylePriority.UseFont = False
        Me.XrLabel159.StylePriority.UseTextAlignment = False
        Me.XrLabel159.Text = "IFSC CODE          :"
        Me.XrLabel159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel141
        '
        Me.XrLabel141.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel141.CanGrow = False
        Me.XrLabel141.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel141.LocationFloat = New DevExpress.Utils.PointFloat(99.9765!, 209.3791!)
        Me.XrLabel141.Multiline = True
        Me.XrLabel141.Name = "XrLabel141"
        Me.XrLabel141.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel141.SizeF = New System.Drawing.SizeF(177.827!, 17.70563!)
        Me.XrLabel141.StylePriority.UseBorders = False
        Me.XrLabel141.StylePriority.UseFont = False
        Me.XrLabel141.StylePriority.UseTextAlignment = False
        Me.XrLabel141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel161
        '
        Me.XrLabel161.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel161.CanGrow = False
        Me.XrLabel161.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel161.LocationFloat = New DevExpress.Utils.PointFloat(277.8034!, 209.6657!)
        Me.XrLabel161.Multiline = True
        Me.XrLabel161.Name = "XrLabel161"
        Me.XrLabel161.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel161.SizeF = New System.Drawing.SizeF(237.667!, 17.41901!)
        Me.XrLabel161.StylePriority.UseBorders = False
        Me.XrLabel161.StylePriority.UseFont = False
        Me.XrLabel161.StylePriority.UseTextAlignment = False
        Me.XrLabel161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel148
        '
        Me.XrLabel148.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel148.CanGrow = False
        Me.XrLabel148.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel148.LocationFloat = New DevExpress.Utils.PointFloat(0!, 155.5298!)
        Me.XrLabel148.Multiline = True
        Me.XrLabel148.Name = "XrLabel148"
        Me.XrLabel148.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel148.SizeF = New System.Drawing.SizeF(515.4704!, 17.70586!)
        Me.XrLabel148.StylePriority.UseBorders = False
        Me.XrLabel148.StylePriority.UseFont = False
        Me.XrLabel148.StylePriority.UseTextAlignment = False
        Me.XrLabel148.Text = "BANK DETAILS FOR NEFT/ RTGS PAYMENTS"
        Me.XrLabel148.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel146
        '
        Me.XrLabel146.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel146.CanGrow = False
        Me.XrLabel146.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Remarks]")})
        Me.XrLabel146.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel146.LocationFloat = New DevExpress.Utils.PointFloat(93.73426!, 138.1399!)
        Me.XrLabel146.Multiline = True
        Me.XrLabel146.Name = "XrLabel146"
        Me.XrLabel146.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel146.SizeF = New System.Drawing.SizeF(684.2662!, 17.39001!)
        Me.XrLabel146.StylePriority.UseBorders = False
        Me.XrLabel146.StylePriority.UseFont = False
        Me.XrLabel146.StylePriority.UseTextAlignment = False
        Me.XrLabel146.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel147
        '
        Me.XrLabel147.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel147.CanGrow = False
        Me.XrLabel147.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel147.LocationFloat = New DevExpress.Utils.PointFloat(0!, 138.1402!)
        Me.XrLabel147.Multiline = True
        Me.XrLabel147.Name = "XrLabel147"
        Me.XrLabel147.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel147.SizeF = New System.Drawing.SizeF(93.73425!, 17.38974!)
        Me.XrLabel147.StylePriority.UseBorders = False
        Me.XrLabel147.StylePriority.UseFont = False
        Me.XrLabel147.StylePriority.UseTextAlignment = False
        Me.XrLabel147.Text = "Remarks"
        Me.XrLabel147.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(473.5504!, 22.5626!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow8, Me.XrTableRow9, Me.XrTableRow10})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(304.45!, 63.99999!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UsePadding = False
        Me.XrTableCell2.Text = "Total GST"
        Me.XrTableCell2.Weight = 1.83369276714151R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalGSTTax]")})
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell3.TextFormatString = "{0:f}"
        Me.XrTableCell3.Weight = 1.52346838054115R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.XrTableCell31})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.Text = "Sub Total"
        Me.XrTableCell5.Weight = 1.83369154641904R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalAmtAfterTax]")})
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.StylePriority.UseBorders = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell31.TextFormatString = "{0:f}"
        Me.XrTableCell31.Weight = 1.5234696012636R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell35, Me.XrTableCell36})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTableCell35.StylePriority.UseBorders = False
        Me.XrTableCell35.StylePriority.UsePadding = False
        Me.XrTableCell35.Text = "Round Off"
        Me.XrTableCell35.Weight = 1.83369154641904R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RoundOff]")})
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseBorders = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell36.TextFormatString = "{0:f}"
        Me.XrTableCell36.Weight = 1.5234696012636R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell39, Me.XrTableCell40})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTableCell39.StylePriority.UseBorders = False
        Me.XrTableCell39.StylePriority.UsePadding = False
        Me.XrTableCell39.Text = "Grand Total"
        Me.XrTableCell39.Weight = 1.83369154638022R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GrandTotalAmount]")})
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StylePriority.UseBorders = False
        Me.XrTableCell40.StylePriority.UseTextAlignment = False
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell40.TextFormatString = "{0:f}"
        Me.XrTableCell40.Weight = 1.52346960130243R
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel25.CanGrow = False
        Me.XrLabel25.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.000022!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(254.4506!, 17.56264!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Total"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel37
        '
        Me.XrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel37.CanGrow = False
        Me.XrLabel37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Qty])")})
        Me.XrLabel37.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(254.4533!, 5.000135!)
        Me.XrLabel37.Multiline = True
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(31.31067!, 17.56259!)
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel37.Summary = XrSummary1
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel37.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel41
        '
        Me.XrLabel41.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel41.CanGrow = False
        Me.XrLabel41.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(285.764!, 5.000019!)
        Me.XrLabel41.Multiline = True
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(187.7864!, 17.56264!)
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel42
        '
        Me.XrLabel42.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel42.CanGrow = False
        Me.XrLabel42.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TaxableValue])")})
        Me.XrLabel42.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(473.5504!, 5.000019!)
        Me.XrLabel42.Multiline = True
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(104.8667!, 17.56259!)
        Me.XrLabel42.StylePriority.UseBorders = False
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel42.Summary = XrSummary2
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel42.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel129
        '
        Me.XrLabel129.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel129.CanGrow = False
        Me.XrLabel129.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel129.LocationFloat = New DevExpress.Utils.PointFloat(578.4171!, 4.999987!)
        Me.XrLabel129.Multiline = True
        Me.XrLabel129.Name = "XrLabel129"
        Me.XrLabel129.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel129.SizeF = New System.Drawing.SizeF(31.14697!, 17.56264!)
        Me.XrLabel129.StylePriority.UseBorders = False
        Me.XrLabel129.StylePriority.UseFont = False
        Me.XrLabel129.StylePriority.UseTextAlignment = False
        Me.XrLabel129.Text = "-"
        Me.XrLabel129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel130
        '
        Me.XrLabel130.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel130.CanGrow = False
        Me.XrLabel130.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([IGSTAmt])")})
        Me.XrLabel130.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel130.LocationFloat = New DevExpress.Utils.PointFloat(609.5641!, 4.999987!)
        Me.XrLabel130.Multiline = True
        Me.XrLabel130.Name = "XrLabel130"
        Me.XrLabel130.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel130.SizeF = New System.Drawing.SizeF(71.92078!, 17.56264!)
        Me.XrLabel130.StylePriority.UseBorders = False
        Me.XrLabel130.StylePriority.UseFont = False
        Me.XrLabel130.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel130.Summary = XrSummary3
        Me.XrLabel130.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel130.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel131
        '
        Me.XrLabel131.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel131.CanGrow = False
        Me.XrLabel131.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalAmount])")})
        Me.XrLabel131.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel131.LocationFloat = New DevExpress.Utils.PointFloat(681.4849!, 4.999987!)
        Me.XrLabel131.Multiline = True
        Me.XrLabel131.Name = "XrLabel131"
        Me.XrLabel131.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel131.SizeF = New System.Drawing.SizeF(96.5155!, 17.56264!)
        Me.XrLabel131.StylePriority.UseBorders = False
        Me.XrLabel131.StylePriority.UseFont = False
        Me.XrLabel131.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel131.Summary = XrSummary4
        Me.XrLabel131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel131.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrTable3
        '
        Me.XrTable3.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.56268!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6, Me.XrTableRow7})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(473.5504!, 33.8!)
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UsePadding = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell21.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.Text = "Taxable Value"
        Me.XrTableCell21.Weight = 1.59999991424042R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.Text = "IGST Rate"
        Me.XrTableCell22.Weight = 1.5873357456166R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.Text = "IGST Amt"
        Me.XrTableCell23.Weight = 1.54816917268664R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell26, Me.XrTableCell28, Me.XrTableCell30})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell26.CanGrow = False
        Me.XrTableCell26.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseBorders = False
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.Weight = 1.59999994824763R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell28.CanGrow = False
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell28.Weight = 1.58733573731144R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell30.CanGrow = False
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseBorders = False
        Me.XrTableCell30.Weight = 1.54816914698458R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.CanGrow = False
        Me.XrTableCell8.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UsePadding = False
        XrSummary5.FormatString = "{0:#}"
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        Me.XrTableCell8.Summary = XrSummary5
        Me.XrTableCell8.Weight = 1.75190101896473R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrLabel8, Me.XrLabel19, Me.XrLabel40, Me.XrLabel89, Me.XrLabel90, Me.XrLabel33, Me.XrLabel32, Me.XrLabel31, Me.XrLabel23, Me.XrLabel30, Me.XrLabel17, Me.XrLabel44, Me.XrLabel46, Me.XrLabel4, Me.XrLabel6, Me.XrLabel7, Me.XrLabel11, Me.XrLabel43, Me.XrLabel36, Me.XrLabel54, Me.XrLabel55, Me.XrLabel57, Me.XrLabel58, Me.XrLabel61, Me.XrLabel62, Me.XrLabel63, Me.XrLabel64, Me.XrLabel66, Me.XrLabel65, Me.XrLabel79, Me.XrLabel80, Me.XrLabel81, Me.XrLabel82, Me.XrLabel83, Me.XrLabel84, Me.XrLabel85, Me.XrLabel92, Me.XrLabel117, Me.XrLabel118, Me.XrLabel119, Me.XrLabel120, Me.XrLabel121, Me.XrLabel126, Me.XrLabel9, Me.XrLabel59, Me.XrPictureBox1, Me.XrLabel29, Me.XrLabel91, Me.XrLabel70, Me.XrLabel10, Me.XrLabel21, Me.XrLabel20, Me.XrLabel18, Me.XrLabel16})
        Me.GroupHeader1.HeightF = 356.1463!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic), DevExpress.Drawing.DXFontStyle), DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(0!, 126.8505!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(777.9999!, 20.83315!)
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(609.5637!, 260.6255!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(49.48999!, 18.45824!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "PANNo : "
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.CanGrow = False
        Me.XrLabel19.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(0.003753662!, 103.9337!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(52.0!, 22.91667!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "GSTIN: "
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel40
        '
        Me.XrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel40.CanGrow = False
        Me.XrLabel40.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(52.00377!, 103.9337!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(352.8164!, 22.91667!)
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel89
        '
        Me.XrLabel89.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel89.CanGrow = False
        Me.XrLabel89.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel89.LocationFloat = New DevExpress.Utils.PointFloat(404.8202!, 103.9338!)
        Me.XrLabel89.Multiline = True
        Me.XrLabel89.Name = "XrLabel89"
        Me.XrLabel89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel89.SizeF = New System.Drawing.SizeF(276.6647!, 22.91666!)
        Me.XrLabel89.StylePriority.UseBorders = False
        Me.XrLabel89.StylePriority.UseFont = False
        Me.XrLabel89.StylePriority.UseTextAlignment = False
        Me.XrLabel89.Text = "PAN No :"
        Me.XrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel90
        '
        Me.XrLabel90.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel90.CanGrow = False
        Me.XrLabel90.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel90.LocationFloat = New DevExpress.Utils.PointFloat(681.4849!, 103.9337!)
        Me.XrLabel90.Multiline = True
        Me.XrLabel90.Name = "XrLabel90"
        Me.XrLabel90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel90.SizeF = New System.Drawing.SizeF(96.51544!, 22.91667!)
        Me.XrLabel90.StylePriority.UseBorders = False
        Me.XrLabel90.StylePriority.UseFont = False
        Me.XrLabel90.StylePriority.UseTextAlignment = False
        Me.XrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.CanGrow = False
        Me.XrLabel33.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(341.6075!, 315.8542!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(77.79941!, 40.29196!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Amount"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.CanGrow = False
        Me.XrLabel32.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(285.7635!, 315.8542!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(55.84!, 40.29196!)
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Rate"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel31
        '
        Me.XrLabel31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel31.CanGrow = False
        Me.XrLabel31.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(254.4528!, 315.8541!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(31.31003!, 40.29205!)
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Qty"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(0!, 315.8542!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(27.42053!, 40.29193!)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Sr. No"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.CanGrow = False
        Me.XrLabel30.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(27.42053!, 315.8542!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(148.0631!, 40.29196!)
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Description"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Calibri", 14.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 147.6836!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(778.0004!, 37.64998!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "            QUOTATION"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel44.CanGrow = False
        Me.XrLabel44.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(0.007152557!, 185.3336!)
        Me.XrLabel44.Multiline = True
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(102.0833!, 19.77029!)
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "Quotation No.    : "
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel46
        '
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel46.CanGrow = False
        Me.XrLabel46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuotationNo]")})
        Me.XrLabel46.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(102.0906!, 185.3336!)
        Me.XrLabel46.Multiline = True
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(137.0211!, 19.47894!)
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.007152557!, 222.9794!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(102.0833!, 19.18719!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "State                    :"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(102.0906!, 222.9793!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(137.0211!, 19.18726!)
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
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(239.1117!, 222.9793!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(68.15588!, 19.18723!)
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
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(307.2676!, 222.9794!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(85.25613!, 19.18721!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel43.CanGrow = False
        Me.XrLabel43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KindlyAttentionTo]")})
        Me.XrLabel43.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(517.2339!, 205.104!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(260.766!, 37.06258!)
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel36
        '
        Me.XrLabel36.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel36.CanGrow = False
        Me.XrLabel36.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(392.5497!, 205.104!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(124.6842!, 37.06258!)
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "Kindly Attention To :"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel54
        '
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel54.CanGrow = False
        Me.XrLabel54.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(0.007358252!, 205.1039!)
        Me.XrLabel54.Multiline = True
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(102.0833!, 17.87547!)
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "Inquiry/ By No.  :"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.CanGrow = False
        Me.XrLabel55.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(0.03336122!, 242.1666!)
        Me.XrLabel55.Multiline = True
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(777.9667!, 18.31296!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Details Of Buyer"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel57
        '
        Me.XrLabel57.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel57.CanGrow = False
        Me.XrLabel57.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(0.007152557!, 260.4796!)
        Me.XrLabel57.Multiline = True
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(63.71876!, 18.60428!)
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "Name      : "
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel58
        '
        Me.XrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel58.CanGrow = False
        Me.XrLabel58.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BuyerName]")})
        Me.XrLabel58.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(63.72594!, 260.4796!)
        Me.XrLabel58.Multiline = True
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(328.7978!, 18.60428!)
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
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(392.5235!, 260.6255!)
        Me.XrLabel61.Multiline = True
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(53.9375!, 18.45842!)
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "GSTIN  : "
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel62
        '
        Me.XrLabel62.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel62.CanGrow = False
        Me.XrLabel62.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BuyerGSTIN]")})
        Me.XrLabel62.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(446.461!, 260.6253!)
        Me.XrLabel62.Multiline = True
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(163.1026!, 18.45865!)
        Me.XrLabel62.StylePriority.UseBorders = False
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel63
        '
        Me.XrLabel63.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel63.CanGrow = False
        Me.XrLabel63.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(393.5651!, 279.0839!)
        Me.XrLabel63.Multiline = True
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(52.8959!, 36.77026!)
        Me.XrLabel63.StylePriority.UseBorders = False
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        Me.XrLabel63.Text = "State    : "
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel64
        '
        Me.XrLabel64.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel64.CanGrow = False
        Me.XrLabel64.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BuyerState]")})
        Me.XrLabel64.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(446.461!, 279.0839!)
        Me.XrLabel64.Multiline = True
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(163.1027!, 36.77026!)
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
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(609.5636!, 279.0838!)
        Me.XrLabel66.Multiline = True
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(84.21783!, 36.77032!)
        Me.XrLabel66.StylePriority.UseBorders = False
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "State Code :"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel65
        '
        Me.XrLabel65.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel65.CanGrow = False
        Me.XrLabel65.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BuyerStateCode]")})
        Me.XrLabel65.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(693.7814!, 279.0842!)
        Me.XrLabel65.Multiline = True
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(84.21869!, 36.76996!)
        Me.XrLabel65.StylePriority.UseBorders = False
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel79
        '
        Me.XrLabel79.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel79.CanGrow = False
        Me.XrLabel79.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(175.4835!, 315.8542!)
        Me.XrLabel79.Multiline = True
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel79.SizeF = New System.Drawing.SizeF(48.28667!, 40.29193!)
        Me.XrLabel79.StylePriority.UseBorders = False
        Me.XrLabel79.StylePriority.UseFont = False
        Me.XrLabel79.StylePriority.UseTextAlignment = False
        Me.XrLabel79.Text = "HSN/SAC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel80
        '
        Me.XrLabel80.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel80.CanGrow = False
        Me.XrLabel80.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(223.7701!, 315.8541!)
        Me.XrLabel80.Multiline = True
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(30.67999!, 40.29199!)
        Me.XrLabel80.StylePriority.UseBorders = False
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.StylePriority.UseTextAlignment = False
        Me.XrLabel80.Text = "UOM"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel81
        '
        Me.XrLabel81.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel81.CanGrow = False
        Me.XrLabel81.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel81.LocationFloat = New DevExpress.Utils.PointFloat(419.4069!, 315.8542!)
        Me.XrLabel81.Multiline = True
        Me.XrLabel81.Name = "XrLabel81"
        Me.XrLabel81.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel81.SizeF = New System.Drawing.SizeF(54.14297!, 40.29196!)
        Me.XrLabel81.StylePriority.UseBorders = False
        Me.XrLabel81.StylePriority.UseFont = False
        Me.XrLabel81.StylePriority.UseTextAlignment = False
        Me.XrLabel81.Text = "Dis.(%)"
        Me.XrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel82
        '
        Me.XrLabel82.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel82.CanGrow = False
        Me.XrLabel82.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(473.5499!, 315.8542!)
        Me.XrLabel82.Multiline = True
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(104.8667!, 40.29199!)
        Me.XrLabel82.StylePriority.UseBorders = False
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        Me.XrLabel82.Text = "Taxable Value"
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel83
        '
        Me.XrLabel83.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel83.CanGrow = False
        Me.XrLabel83.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel83.LocationFloat = New DevExpress.Utils.PointFloat(578.4166!, 315.8542!)
        Me.XrLabel83.Multiline = True
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel83.SizeF = New System.Drawing.SizeF(101.9457!, 19.48184!)
        Me.XrLabel83.StylePriority.UseBorders = False
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        Me.XrLabel83.Text = "IGST"
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel84
        '
        Me.XrLabel84.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel84.CanGrow = False
        Me.XrLabel84.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel84.LocationFloat = New DevExpress.Utils.PointFloat(578.4166!, 335.3361!)
        Me.XrLabel84.Multiline = True
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel84.SizeF = New System.Drawing.SizeF(31.14697!, 20.81012!)
        Me.XrLabel84.StylePriority.UseBorders = False
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        Me.XrLabel84.Text = "Rate"
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel85
        '
        Me.XrLabel85.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel85.CanGrow = False
        Me.XrLabel85.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel85.LocationFloat = New DevExpress.Utils.PointFloat(609.5637!, 335.3361!)
        Me.XrLabel85.Multiline = True
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel85.SizeF = New System.Drawing.SizeF(70.79877!, 20.81015!)
        Me.XrLabel85.StylePriority.UseBorders = False
        Me.XrLabel85.StylePriority.UseFont = False
        Me.XrLabel85.StylePriority.UseTextAlignment = False
        Me.XrLabel85.Text = "Amt"
        Me.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel92
        '
        Me.XrLabel92.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel92.CanGrow = False
        Me.XrLabel92.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel92.LocationFloat = New DevExpress.Utils.PointFloat(680.3624!, 315.8542!)
        Me.XrLabel92.Multiline = True
        Me.XrLabel92.Name = "XrLabel92"
        Me.XrLabel92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel92.SizeF = New System.Drawing.SizeF(97.63751!, 40.2919!)
        Me.XrLabel92.StylePriority.UseBorders = False
        Me.XrLabel92.StylePriority.UseFont = False
        Me.XrLabel92.StylePriority.UseTextAlignment = False
        Me.XrLabel92.Text = "Total Amount"
        Me.XrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel117
        '
        Me.XrLabel117.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel117.CanGrow = False
        Me.XrLabel117.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InquiryNo]")})
        Me.XrLabel117.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel117.LocationFloat = New DevExpress.Utils.PointFloat(102.0906!, 204.8125!)
        Me.XrLabel117.Multiline = True
        Me.XrLabel117.Name = "XrLabel117"
        Me.XrLabel117.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel117.SizeF = New System.Drawing.SizeF(137.0213!, 18.16685!)
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
        Me.XrLabel118.LocationFloat = New DevExpress.Utils.PointFloat(239.1119!, 205.1039!)
        Me.XrLabel118.Multiline = True
        Me.XrLabel118.Name = "XrLabel118"
        Me.XrLabel118.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel118.SizeF = New System.Drawing.SizeF(40.99998!, 17.8755!)
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
        Me.XrLabel119.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InquiryDate]")})
        Me.XrLabel119.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel119.LocationFloat = New DevExpress.Utils.PointFloat(280.1117!, 205.1039!)
        Me.XrLabel119.Multiline = True
        Me.XrLabel119.Name = "XrLabel119"
        Me.XrLabel119.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel119.SizeF = New System.Drawing.SizeF(112.4119!, 17.87549!)
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
        Me.XrLabel120.LocationFloat = New DevExpress.Utils.PointFloat(239.1117!, 185.3336!)
        Me.XrLabel120.Multiline = True
        Me.XrLabel120.Name = "XrLabel120"
        Me.XrLabel120.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel120.SizeF = New System.Drawing.SizeF(40.99998!, 19.77028!)
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
        Me.XrLabel121.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuotationDate]")})
        Me.XrLabel121.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel121.LocationFloat = New DevExpress.Utils.PointFloat(280.1117!, 185.3336!)
        Me.XrLabel121.Multiline = True
        Me.XrLabel121.Name = "XrLabel121"
        Me.XrLabel121.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel121.SizeF = New System.Drawing.SizeF(112.4119!, 19.77029!)
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
        Me.XrLabel126.LocationFloat = New DevExpress.Utils.PointFloat(0!, 279.0837!)
        Me.XrLabel126.Multiline = True
        Me.XrLabel126.Name = "XrLabel126"
        Me.XrLabel126.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel126.SizeF = New System.Drawing.SizeF(63.7264!, 18.60428!)
        Me.XrLabel126.StylePriority.UseBorders = False
        Me.XrLabel126.StylePriority.UseFont = False
        Me.XrLabel126.StylePriority.UseTextAlignment = False
        Me.XrLabel126.Text = "Address  :"
        Me.XrLabel126.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(102.0911!, 34.00004!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(675.9089!, 17.99999!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel59
        '
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel59.CanGrow = False
        Me.XrLabel59.Font = New DevExpress.Drawing.DXFont("Calibri", 20.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(102.0911!, 0!)
        Me.XrLabel59.Multiline = True
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(675.909!, 34.00003!)
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.007765334!, 0.00001673113!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(102.0834!, 103.9337!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox1.StylePriority.UseBorders = False
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel29.CanGrow = False
        Me.XrLabel29.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(102.0911!, 52.0!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(675.9092!, 17.99999!)
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel91
        '
        Me.XrLabel91.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel91.CanGrow = False
        Me.XrLabel91.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel91.LocationFloat = New DevExpress.Utils.PointFloat(102.0911!, 70.0!)
        Me.XrLabel91.Multiline = True
        Me.XrLabel91.Name = "XrLabel91"
        Me.XrLabel91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel91.SizeF = New System.Drawing.SizeF(675.9088!, 33.93371!)
        Me.XrLabel91.StylePriority.UseBorders = False
        Me.XrLabel91.StylePriority.UseFont = False
        Me.XrLabel91.StylePriority.UseTextAlignment = False
        Me.XrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrLabel70
        '
        Me.XrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel70.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BuyerAddress]")})
        Me.XrLabel70.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(63.7264!, 279.0842!)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(329.8387!, 36.76993!)
        Me.XrLabel70.StylePriority.UseBorders = False
        Me.XrLabel70.StylePriority.UseFont = False
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel10.CanGrow = False
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BuyerPanNo]")})
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(659.0537!, 260.4796!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(118.9463!, 18.60425!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PartyDCDate]")})
        Me.XrLabel21.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(693.7814!, 185.3336!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(84.21863!, 19.77037!)
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
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(615.3837!, 185.3336!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(78.39771!, 19.77029!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Party DC Date:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PartyDCNo]")})
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(473.5499!, 185.3336!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(141.8334!, 19.77045!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(392.5235!, 185.3336!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(81.0264!, 19.77043!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Party DC No :"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine4.EndBand = Me.GroupFooter2
        Me.XrCrossBandLine4.EndPointFloat = New DevExpress.Utils.PointFloat(388.6029!, 0!)
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.GroupFooter2
        Me.XrCrossBandLine4.StartPointFloat = New DevExpress.Utils.PointFloat(388.6029!, 0!)
        Me.XrCrossBandLine4.WidthF = 1.000012!
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine2.EndBand = Me.GroupFooter2
        Me.XrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 86.56264!)
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.GroupFooter2
        Me.XrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 56.36269!)
        Me.XrCrossBandLine2.WidthF = 1.116071!
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine3.EndBand = Me.GroupHeader1
        Me.XrCrossBandLine3.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 315.8542!)
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.GroupHeader1
        Me.XrCrossBandLine3.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 297.688!)
        Me.XrCrossBandLine3.WidthF = 1.108123!
        '
        'XR_QuotationIGST
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.GroupFooter2, Me.GroupHeader1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine3, Me.XrCrossBandLine2, Me.XrCrossBandLine1, Me.XrCrossBandLine4})
        Me.DataMember = "DataTable1"
        Me.FilterString = "[QuotationID] = ?Invoice"
        Me.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.0!)
        Me.Margins = New DevExpress.Drawing.DXMargins(22.0!, 27.0!, 50.39743!, 0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Invoice})
        Me.Version = "23.2"
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsXrTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel81 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel84 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel85 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel92 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel120 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel121 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel126 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel91 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel117 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel118 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel119 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel89 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel90 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents TermsXrTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel162 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel164 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel163 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel151 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel138 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel153 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel143 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel155 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel139 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel157 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel140 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel159 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel141 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel161 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel148 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel146 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel147 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel129 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel130 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel131 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine3 As DevExpress.XtraReports.UI.XRCrossBandLine
End Class
