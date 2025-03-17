<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_EWayBillB
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
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.ModeXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.VehicleDetailsXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FromXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.EnteredDateXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.EnteredByXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CEWBXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.MultiVehXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.ModeValueXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.VehicleDetailsValueXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FromValueXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.EnteredDateValurXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.EnteredByValueXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CEWBvalueXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.MultiVehValueXrTableCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ValidTilXrLabel = New DevExpress.XtraReports.UI.XRLabel()
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
        CType(Me.DS_Invoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.ValidTilXrLabel, Me.XrLabel17, Me.UniqXrLabel, Me.XrLabel4, Me.EntDtXrLabel, Me.XrLabel7, Me.EntByXrLabel, Me.XrLabel12, Me.XrLabel15, Me.ValidXrLabel, Me.XrLabel16, Me.SupGSTXrLabel, Me.XrLabel18, Me.XrLabel22, Me.DispXrLabel, Me.XrLabel24, Me.RecGSTXrLabel, Me.XrLabel30, Me.DelXrLabel, Me.XrLabel32, Me.DocNoXrLabel, Me.DocDtXrLabel, Me.XrLabel33, Me.TransTypeXrLabel, Me.XrLabel35, Me.ValGoodsXrLabel, Me.XrLabel38, Me.HSNXrLabel, Me.XrLabel43, Me.TransporterXrLabel, Me.ReaTransportationXrLabel, Me.XrLabel56, Me.XrLabel55})
        Me.GroupHeader1.HeightF = 1025.395!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(10.00002!, 722.723!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2, Me.XrTableRow1})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(757.0002!, 123.3273!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ModeXrTableCell, Me.VehicleDetailsXrTableCell, Me.FromXrTableCell, Me.EnteredDateXrTableCell, Me.EnteredByXrTableCell, Me.CEWBXrTableCell, Me.MultiVehXrTableCell})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.23688934326172R
        '
        'ModeXrTableCell
        '
        Me.ModeXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ModeXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.ModeXrTableCell.Name = "ModeXrTableCell"
        Me.ModeXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.ModeXrTableCell.StylePriority.UseBorders = False
        Me.ModeXrTableCell.StylePriority.UseFont = False
        Me.ModeXrTableCell.StylePriority.UsePadding = False
        Me.ModeXrTableCell.StylePriority.UseTextAlignment = False
        Me.ModeXrTableCell.Text = "Mode"
        Me.ModeXrTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.ModeXrTableCell.Weight = 1.6326650454218741R
        '
        'VehicleDetailsXrTableCell
        '
        Me.VehicleDetailsXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.VehicleDetailsXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.VehicleDetailsXrTableCell.Name = "VehicleDetailsXrTableCell"
        Me.VehicleDetailsXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.VehicleDetailsXrTableCell.StylePriority.UseBorders = False
        Me.VehicleDetailsXrTableCell.StylePriority.UseFont = False
        Me.VehicleDetailsXrTableCell.StylePriority.UsePadding = False
        Me.VehicleDetailsXrTableCell.StylePriority.UseTextAlignment = False
        Me.VehicleDetailsXrTableCell.Text = "Vehicle / Trans Doc No & DL"
        Me.VehicleDetailsXrTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.VehicleDetailsXrTableCell.Weight = 2.3765018738554473R
        '
        'FromXrTableCell
        '
        Me.FromXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.FromXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.FromXrTableCell.Name = "FromXrTableCell"
        Me.FromXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.FromXrTableCell.StylePriority.UseBorders = False
        Me.FromXrTableCell.StylePriority.UseFont = False
        Me.FromXrTableCell.StylePriority.UsePadding = False
        Me.FromXrTableCell.StylePriority.UseTextAlignment = False
        Me.FromXrTableCell.Text = "From"
        Me.FromXrTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.FromXrTableCell.Weight = 3.209027372207033R
        '
        'EnteredDateXrTableCell
        '
        Me.EnteredDateXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EnteredDateXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.EnteredDateXrTableCell.Name = "EnteredDateXrTableCell"
        Me.EnteredDateXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.EnteredDateXrTableCell.StylePriority.UseBorders = False
        Me.EnteredDateXrTableCell.StylePriority.UseFont = False
        Me.EnteredDateXrTableCell.StylePriority.UsePadding = False
        Me.EnteredDateXrTableCell.StylePriority.UseTextAlignment = False
        Me.EnteredDateXrTableCell.Text = "Entered Date"
        Me.EnteredDateXrTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.EnteredDateXrTableCell.Weight = 3.0811994020388216R
        '
        'EnteredByXrTableCell
        '
        Me.EnteredByXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EnteredByXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.EnteredByXrTableCell.Multiline = True
        Me.EnteredByXrTableCell.Name = "EnteredByXrTableCell"
        Me.EnteredByXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.EnteredByXrTableCell.StylePriority.UseBorders = False
        Me.EnteredByXrTableCell.StylePriority.UseFont = False
        Me.EnteredByXrTableCell.StylePriority.UsePadding = False
        Me.EnteredByXrTableCell.StylePriority.UseTextAlignment = False
        Me.EnteredByXrTableCell.Text = "Entered By"
        Me.EnteredByXrTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.EnteredByXrTableCell.Weight = 3.1423377704819511R
        '
        'CEWBXrTableCell
        '
        Me.CEWBXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.CEWBXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.CEWBXrTableCell.Multiline = True
        Me.CEWBXrTableCell.Name = "CEWBXrTableCell"
        Me.CEWBXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.CEWBXrTableCell.StylePriority.UseBorders = False
        Me.CEWBXrTableCell.StylePriority.UseFont = False
        Me.CEWBXrTableCell.StylePriority.UsePadding = False
        Me.CEWBXrTableCell.StylePriority.UseTextAlignment = False
        Me.CEWBXrTableCell.Text = "CEWB No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(if any)"
        Me.CEWBXrTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.CEWBXrTableCell.Weight = 2.5489834559936626R
        '
        'MultiVehXrTableCell
        '
        Me.MultiVehXrTableCell.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.MultiVehXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.MultiVehXrTableCell.Multiline = True
        Me.MultiVehXrTableCell.Name = "MultiVehXrTableCell"
        Me.MultiVehXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.MultiVehXrTableCell.StylePriority.UseBorders = False
        Me.MultiVehXrTableCell.StylePriority.UseFont = False
        Me.MultiVehXrTableCell.StylePriority.UsePadding = False
        Me.MultiVehXrTableCell.StylePriority.UseTextAlignment = False
        Me.MultiVehXrTableCell.Text = "Multi Veh. Info" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(if any)"
        Me.MultiVehXrTableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.MultiVehXrTableCell.Weight = 2.8497323327369388R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ModeValueXrTableCell, Me.VehicleDetailsValueXrTableCell, Me.FromValueXrTableCell, Me.EnteredDateValurXrTableCell, Me.EnteredByValueXrTableCell, Me.CEWBvalueXrTableCell, Me.MultiVehValueXrTableCell})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.23688934326172R
        '
        'ModeValueXrTableCell
        '
        Me.ModeValueXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ModeValueXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ModeValueXrTableCell.Multiline = True
        Me.ModeValueXrTableCell.Name = "ModeValueXrTableCell"
        Me.ModeValueXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.ModeValueXrTableCell.StylePriority.UseBorders = False
        Me.ModeValueXrTableCell.StylePriority.UseFont = False
        Me.ModeValueXrTableCell.StylePriority.UsePadding = False
        Me.ModeValueXrTableCell.Weight = 1.6326644757738147R
        '
        'VehicleDetailsValueXrTableCell
        '
        Me.VehicleDetailsValueXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.VehicleDetailsValueXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.VehicleDetailsValueXrTableCell.Multiline = True
        Me.VehicleDetailsValueXrTableCell.Name = "VehicleDetailsValueXrTableCell"
        Me.VehicleDetailsValueXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.VehicleDetailsValueXrTableCell.StylePriority.UseBorders = False
        Me.VehicleDetailsValueXrTableCell.StylePriority.UseFont = False
        Me.VehicleDetailsValueXrTableCell.StylePriority.UsePadding = False
        Me.VehicleDetailsValueXrTableCell.Weight = 2.3765014940900744R
        '
        'FromValueXrTableCell
        '
        Me.FromValueXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.FromValueXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.FromValueXrTableCell.Multiline = True
        Me.FromValueXrTableCell.Name = "FromValueXrTableCell"
        Me.FromValueXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.FromValueXrTableCell.StylePriority.UseBorders = False
        Me.FromValueXrTableCell.StylePriority.UseFont = False
        Me.FromValueXrTableCell.StylePriority.UsePadding = False
        Me.FromValueXrTableCell.Weight = 3.2090273722070326R
        '
        'EnteredDateValurXrTableCell
        '
        Me.EnteredDateValurXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EnteredDateValurXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.EnteredDateValurXrTableCell.Multiline = True
        Me.EnteredDateValurXrTableCell.Name = "EnteredDateValurXrTableCell"
        Me.EnteredDateValurXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.EnteredDateValurXrTableCell.StylePriority.UseBorders = False
        Me.EnteredDateValurXrTableCell.StylePriority.UseFont = False
        Me.EnteredDateValurXrTableCell.StylePriority.UsePadding = False
        Me.EnteredDateValurXrTableCell.Weight = 3.081200161569507R
        '
        'EnteredByValueXrTableCell
        '
        Me.EnteredByValueXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EnteredByValueXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.EnteredByValueXrTableCell.Multiline = True
        Me.EnteredByValueXrTableCell.Name = "EnteredByValueXrTableCell"
        Me.EnteredByValueXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.EnteredByValueXrTableCell.StylePriority.UseBorders = False
        Me.EnteredByValueXrTableCell.StylePriority.UseFont = False
        Me.EnteredByValueXrTableCell.StylePriority.UsePadding = False
        Me.EnteredByValueXrTableCell.Weight = 3.1423379603646979R
        '
        'CEWBvalueXrTableCell
        '
        Me.CEWBvalueXrTableCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.CEWBvalueXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.CEWBvalueXrTableCell.Multiline = True
        Me.CEWBvalueXrTableCell.Name = "CEWBvalueXrTableCell"
        Me.CEWBvalueXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.CEWBvalueXrTableCell.StylePriority.UseBorders = False
        Me.CEWBvalueXrTableCell.StylePriority.UseFont = False
        Me.CEWBvalueXrTableCell.StylePriority.UsePadding = False
        Me.CEWBvalueXrTableCell.Weight = 2.5489849750551539R
        '
        'MultiVehValueXrTableCell
        '
        Me.MultiVehValueXrTableCell.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.MultiVehValueXrTableCell.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.MultiVehValueXrTableCell.Multiline = True
        Me.MultiVehValueXrTableCell.Name = "MultiVehValueXrTableCell"
        Me.MultiVehValueXrTableCell.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.MultiVehValueXrTableCell.StylePriority.UseBorders = False
        Me.MultiVehValueXrTableCell.StylePriority.UseFont = False
        Me.MultiVehValueXrTableCell.StylePriority.UsePadding = False
        Me.MultiVehValueXrTableCell.Weight = 2.8497308136754471R
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.3533893!, 712.4289!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(777.688!, 147.7535!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.3533831!, 682.4292!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(777.7069!, 30.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Part - B"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.353363!, 292.4289!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Valid Until:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ValidTilXrLabel
        '
        Me.ValidTilXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ValidTilXrLabel.CanGrow = False
        Me.ValidTilXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.ValidTilXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 292.429!)
        Me.ValidTilXrLabel.Multiline = True
        Me.ValidTilXrLabel.Name = "ValidTilXrLabel"
        Me.ValidTilXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ValidTilXrLabel.SizeF = New System.Drawing.SizeF(560.4909!, 30.00002!)
        Me.ValidTilXrLabel.StylePriority.UseBorders = False
        Me.ValidTilXrLabel.StylePriority.UseFont = False
        Me.ValidTilXrLabel.StylePriority.UseTextAlignment = False
        Me.ValidTilXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Calibri", 15.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0.01678013!, 26.0!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(778.0245!, 146.4288!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "E-Way Bill" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'UniqXrLabel
        '
        Me.UniqXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.UniqXrLabel.CanGrow = False
        Me.UniqXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.UniqXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5396!, 172.4288!)
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
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.2939588!, 172.4288!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "E-Way Bill No:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'EntDtXrLabel
        '
        Me.EntDtXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EntDtXrLabel.CanGrow = False
        Me.EntDtXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.EntDtXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 202.4287!)
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
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.3236589!, 202.4287!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "E-Way Bill Date:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'EntByXrLabel
        '
        Me.EntByXrLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.EntByXrLabel.CanGrow = False
        Me.EntByXrLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.EntByXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 232.4287!)
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
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 232.4287!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Generated By:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 262.4287!)
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
        Me.ValidXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 262.4288!)
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
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 322.429!)
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
        Me.SupGSTXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 352.429!)
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
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 352.429!)
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
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 382.4292!)
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
        Me.DispXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 382.4292!)
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
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 412.429!)
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
        Me.RecGSTXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 412.429!)
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
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 442.4292!)
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
        Me.DelXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 442.4292!)
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
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 472.4292!)
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
        Me.DocNoXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 472.4292!)
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
        Me.DocDtXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 502.4292!)
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
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 502.4292!)
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
        Me.TransTypeXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 532.4292!)
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
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 532.4292!)
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
        Me.ValGoodsXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 562.4292!)
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
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 562.4292!)
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
        Me.HSNXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 592.4292!)
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
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 592.4292!)
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
        Me.TransporterXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 652.4292!)
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
        Me.ReaTransportationXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217.5693!, 622.4293!)
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
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 652.4292!)
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
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(0.353359!, 622.4293!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(217.216!, 30.0!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Reason for Transportation:"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XR_EWayBillB
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
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ValidTilXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ModeXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents VehicleDetailsXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents FromXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents EnteredDateXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents EnteredByXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CEWBXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents MultiVehXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ModeValueXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents VehicleDetailsValueXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents FromValueXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents EnteredDateValurXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents EnteredByValueXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CEWBvalueXrTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents MultiVehValueXrTableCell As DevExpress.XtraReports.UI.XRTableCell
End Class
