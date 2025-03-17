<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_EWayBillA
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
        Dim XrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
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
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.UniqXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.EntDtXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.EntByXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ValidXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SupGSTXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DispXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.RecGSTXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DelXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DocNoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.DocDtXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TransTypeXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ValGoodsXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.HSNXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TransporterXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReaTransportationXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.EWNoXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 0!
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
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.007947286!, 48.39423!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(777.4193!, 2.003204!)
        Me.XrLine1.Visible = False
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 1.0!
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
        Me.XrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPageInfo1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(678.0!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(89.00012!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseBorders = False
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupFooter2.Expanded = False
        Me.GroupFooter2.HeightF = 16.4124!
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.StylePriority.UseBorders = False
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
        XrSummary1.FormatString = "{0:#}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        Me.XrTableCell8.Summary = XrSummary1
        Me.XrTableCell8.Weight = 1.75190101896473R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel17, Me.UniqXrLabel, Me.XrLabel4, Me.EntDtXrLabel, Me.XrLabel7, Me.EntByXrLabel, Me.XrLabel12, Me.XrLabel15, Me.ValidXrLabel, Me.XrLabel16, Me.SupGSTXrLabel, Me.XrLabel18, Me.XrLabel22, Me.DispXrLabel, Me.XrLabel24, Me.RecGSTXrLabel, Me.XrLabel30, Me.DelXrLabel, Me.XrLabel32, Me.DocNoXrLabel, Me.DocDtXrLabel, Me.XrLabel33, Me.TransTypeXrLabel, Me.XrLabel35, Me.ValGoodsXrLabel, Me.XrLabel38, Me.HSNXrLabel, Me.XrLabel43, Me.TransporterXrLabel, Me.ReaTransportationXrLabel, Me.XrLabel56, Me.XrLabel55, Me.EWNoXrLabel})
        Me.GroupHeader1.HeightF = 752.1119!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.3533681!, 715.9166!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(777.7068!, 30.00006!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Note*: If any discrepancy in information please try after some time"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel1.Visible = False
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Calibri", 15.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0.01678013!, 25.0!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(778.0245!, 54.16682!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Part - A Slip"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'UniqXrLabel
        '
        Me.UniqXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.UniqXrLabel.CanGrow = False
        Me.UniqXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.UniqXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5396!, 79.16679!)
        Me.UniqXrLabel.Multiline = True
        Me.UniqXrLabel.Name = "UniqXrLabel"
        Me.UniqXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.UniqXrLabel.SizeF = New System.Drawing.SizeF(560.4613!, 30.0!)
        Me.UniqXrLabel.StylePriority.UseBorders = False
        Me.UniqXrLabel.StylePriority.UseFont = False
        Me.UniqXrLabel.StylePriority.UseTextAlignment = False
        Me.UniqXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.2939738!, 79.16679!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Unique No:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'EntDtXrLabel
        '
        Me.EntDtXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EntDtXrLabel.CanGrow = False
        Me.EntDtXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.EntDtXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 109.1668!)
        Me.EntDtXrLabel.Multiline = True
        Me.EntDtXrLabel.Name = "EntDtXrLabel"
        Me.EntDtXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.EntDtXrLabel.SizeF = New System.Drawing.SizeF(560.4613!, 30.0!)
        Me.EntDtXrLabel.StylePriority.UseBorders = False
        Me.EntDtXrLabel.StylePriority.UseFont = False
        Me.EntDtXrLabel.StylePriority.UseTextAlignment = False
        Me.EntDtXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.323674!, 109.1668!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Entered Date:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'EntByXrLabel
        '
        Me.EntByXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EntByXrLabel.CanGrow = False
        Me.EntByXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.EntByXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 139.1668!)
        Me.EntByXrLabel.Multiline = True
        Me.EntByXrLabel.Name = "EntByXrLabel"
        Me.EntByXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.EntByXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.EntByXrLabel.StylePriority.UseBorders = False
        Me.EntByXrLabel.StylePriority.UseFont = False
        Me.EntByXrLabel.StylePriority.UseTextAlignment = False
        Me.EntByXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 139.1668!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Entered By:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 169.1668!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Valid From:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ValidXrLabel
        '
        Me.ValidXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ValidXrLabel.CanGrow = False
        Me.ValidXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.ValidXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 169.1669!)
        Me.ValidXrLabel.Multiline = True
        Me.ValidXrLabel.Name = "ValidXrLabel"
        Me.ValidXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ValidXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.ValidXrLabel.StylePriority.UseBorders = False
        Me.ValidXrLabel.StylePriority.UseFont = False
        Me.ValidXrLabel.StylePriority.UseTextAlignment = False
        Me.ValidXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0.3533539!, 199.1668!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(777.7069!, 30.0!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Part - A"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SupGSTXrLabel
        '
        Me.SupGSTXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.SupGSTXrLabel.CanGrow = False
        Me.SupGSTXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.SupGSTXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 229.1668!)
        Me.SupGSTXrLabel.Multiline = True
        Me.SupGSTXrLabel.Name = "SupGSTXrLabel"
        Me.SupGSTXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SupGSTXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.SupGSTXrLabel.StylePriority.UseBorders = False
        Me.SupGSTXrLabel.StylePriority.UseFont = False
        Me.SupGSTXrLabel.StylePriority.UseTextAlignment = False
        Me.SupGSTXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 229.1668!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "GSTIN of Supplier:"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 259.1668!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Place of Dispatch:"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DispXrLabel
        '
        Me.DispXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.DispXrLabel.CanGrow = False
        Me.DispXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.DispXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 259.1668!)
        Me.DispXrLabel.Multiline = True
        Me.DispXrLabel.Name = "DispXrLabel"
        Me.DispXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DispXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.DispXrLabel.StylePriority.UseBorders = False
        Me.DispXrLabel.StylePriority.UseFont = False
        Me.DispXrLabel.StylePriority.UseTextAlignment = False
        Me.DispXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel24.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 289.1668!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "GSTIN of Recipient: "
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RecGSTXrLabel
        '
        Me.RecGSTXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.RecGSTXrLabel.CanGrow = False
        Me.RecGSTXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.RecGSTXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 289.1668!)
        Me.RecGSTXrLabel.Multiline = True
        Me.RecGSTXrLabel.Name = "RecGSTXrLabel"
        Me.RecGSTXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RecGSTXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.RecGSTXrLabel.StylePriority.UseBorders = False
        Me.RecGSTXrLabel.StylePriority.UseFont = False
        Me.RecGSTXrLabel.StylePriority.UseTextAlignment = False
        Me.RecGSTXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 319.1668!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Place of Delivery:"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DelXrLabel
        '
        Me.DelXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.DelXrLabel.CanGrow = False
        Me.DelXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.DelXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 319.1668!)
        Me.DelXrLabel.Multiline = True
        Me.DelXrLabel.Name = "DelXrLabel"
        Me.DelXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DelXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.DelXrLabel.StylePriority.UseBorders = False
        Me.DelXrLabel.StylePriority.UseFont = False
        Me.DelXrLabel.StylePriority.UseTextAlignment = False
        Me.DelXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 349.1668!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Document No:"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DocNoXrLabel
        '
        Me.DocNoXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.DocNoXrLabel.CanGrow = False
        Me.DocNoXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.DocNoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 349.1668!)
        Me.DocNoXrLabel.Multiline = True
        Me.DocNoXrLabel.Name = "DocNoXrLabel"
        Me.DocNoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DocNoXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.DocNoXrLabel.StylePriority.UseBorders = False
        Me.DocNoXrLabel.StylePriority.UseFont = False
        Me.DocNoXrLabel.StylePriority.UseTextAlignment = False
        Me.DocNoXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DocDtXrLabel
        '
        Me.DocDtXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.DocDtXrLabel.CanGrow = False
        Me.DocDtXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.DocDtXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 379.1668!)
        Me.DocDtXrLabel.Multiline = True
        Me.DocDtXrLabel.Name = "DocDtXrLabel"
        Me.DocDtXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DocDtXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.DocDtXrLabel.StylePriority.UseBorders = False
        Me.DocDtXrLabel.StylePriority.UseFont = False
        Me.DocDtXrLabel.StylePriority.UseTextAlignment = False
        Me.DocDtXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 379.1668!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Document Date:"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TransTypeXrLabel
        '
        Me.TransTypeXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TransTypeXrLabel.CanGrow = False
        Me.TransTypeXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.TransTypeXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 409.1668!)
        Me.TransTypeXrLabel.Multiline = True
        Me.TransTypeXrLabel.Name = "TransTypeXrLabel"
        Me.TransTypeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TransTypeXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.TransTypeXrLabel.StylePriority.UseBorders = False
        Me.TransTypeXrLabel.StylePriority.UseFont = False
        Me.TransTypeXrLabel.StylePriority.UseTextAlignment = False
        Me.TransTypeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel35
        '
        Me.XrLabel35.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel35.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 409.1668!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "Transaction Type:"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ValGoodsXrLabel
        '
        Me.ValGoodsXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ValGoodsXrLabel.CanGrow = False
        Me.ValGoodsXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.ValGoodsXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 439.1668!)
        Me.ValGoodsXrLabel.Multiline = True
        Me.ValGoodsXrLabel.Name = "ValGoodsXrLabel"
        Me.ValGoodsXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ValGoodsXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.ValGoodsXrLabel.StylePriority.UseBorders = False
        Me.ValGoodsXrLabel.StylePriority.UseFont = False
        Me.ValGoodsXrLabel.StylePriority.UseTextAlignment = False
        Me.ValGoodsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel38
        '
        Me.XrLabel38.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel38.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 439.1668!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel38.StylePriority.UseBorders = False
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "Value of Goods:"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'HSNXrLabel
        '
        Me.HSNXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.HSNXrLabel.CanGrow = False
        Me.HSNXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.HSNXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 469.1668!)
        Me.HSNXrLabel.Multiline = True
        Me.HSNXrLabel.Name = "HSNXrLabel"
        Me.HSNXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.HSNXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.HSNXrLabel.StylePriority.UseBorders = False
        Me.HSNXrLabel.StylePriority.UseFont = False
        Me.HSNXrLabel.StylePriority.UseTextAlignment = False
        Me.HSNXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel43.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 469.1668!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "HSN Code:"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TransporterXrLabel
        '
        Me.TransporterXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TransporterXrLabel.CanGrow = False
        Me.TransporterXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.TransporterXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 529.1668!)
        Me.TransporterXrLabel.Multiline = True
        Me.TransporterXrLabel.Name = "TransporterXrLabel"
        Me.TransporterXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TransporterXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.TransporterXrLabel.StylePriority.UseBorders = False
        Me.TransporterXrLabel.StylePriority.UseFont = False
        Me.TransporterXrLabel.StylePriority.UseTextAlignment = False
        Me.TransporterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReaTransportationXrLabel
        '
        Me.ReaTransportationXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ReaTransportationXrLabel.CanGrow = False
        Me.ReaTransportationXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.ReaTransportationXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 499.1668!)
        Me.ReaTransportationXrLabel.Multiline = True
        Me.ReaTransportationXrLabel.Name = "ReaTransportationXrLabel"
        Me.ReaTransportationXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ReaTransportationXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.ReaTransportationXrLabel.StylePriority.UseBorders = False
        Me.ReaTransportationXrLabel.StylePriority.UseFont = False
        Me.ReaTransportationXrLabel.StylePriority.UseTextAlignment = False
        Me.ReaTransportationXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel56
        '
        Me.XrLabel56.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel56.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 529.1668!)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "Transporter:"
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 499.1668!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Reason for Transportation:"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'EWNoXrLabel
        '
        Me.EWNoXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EWNoXrLabel.CanGrow = False
        Me.EWNoXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.EWNoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 665.9166!)
        Me.EWNoXrLabel.Multiline = True
        Me.EWNoXrLabel.Name = "EWNoXrLabel"
        Me.EWNoXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.EWNoXrLabel.SizeF = New System.Drawing.SizeF(778.0602!, 50.0!)
        Me.EWNoXrLabel.StylePriority.UseBorders = False
        Me.EWNoXrLabel.StylePriority.UseFont = False
        Me.EWNoXrLabel.StylePriority.UseTextAlignment = False
        Me.EWNoXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.EWNoXrLabel.Visible = False
        '
        'XR_EWayBillA
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.GroupFooter2, Me.GroupHeader1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine1})
        Me.DataAdapter = Me.DT_InvoiceTableAdapter1
        Me.DataMember = "DT_Invoice"
        Me.DataSource = Me.DS_Invoice2
        Me.FilterString = "[InvoiceID] = ?Invoice"
        Me.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.0!)
        Me.Margins = New DevExpress.Drawing.DXMargins(21.0!, 25.0!, 50.39743!, 1.0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Invoice})
        Me.Version = "23.2"
        XrWatermark1.Id = "Watermark1"
        Me.Watermarks.AddRange(New DevExpress.XtraPrinting.Drawing.Watermark() {XrWatermark1})
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents UniqXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents EntDtXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents EntByXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ValidXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SupGSTXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DispXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RecGSTXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DelXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DocNoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DocDtXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TransTypeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ValGoodsXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents HSNXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TransporterXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReaTransportationXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents EWNoXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
