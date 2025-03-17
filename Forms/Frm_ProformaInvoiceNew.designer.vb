<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ProformaInvoiceNew

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.XtraForm' is not defined.
    Inherits DevExpress.XtraEditors.XtraForm
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.XtraForm' is not defined.

    'Form overrides dispose to clean up the component list.
#Disable Warning BC30284 ' sub 'Dispose' cannot be declared 'Overrides' because it does not override a sub in a base class.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
#Enable Warning BC30284 ' sub 'Dispose' cannot be declared 'Overrides' because it does not override a sub in a base class.
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ProformaInvoiceNew))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.NewBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.OpenBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.DeleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintOriginalPrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintOriginalSignBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintDuplicateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintTriplicateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.lblAttachment = New DevExpress.XtraEditors.LabelControl()
        Me.SendEmailSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.TaxInWordsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.ModifiedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CreatedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CreatedByLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.ModifiedByLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.PIGSTAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.PSGSTAmt = New DevExpress.XtraEditors.TextEdit()
        Me.PCGSTAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PIGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.PSGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PCGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.PackingChargeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.TotalAmtAfterTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.GSTReverseChargeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TotalGSTTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.IGSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SGSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CGSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.TotalInWordsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.NetAmtLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.TotalAmtBeforeTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.PackingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.PartyDCDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.PartyDCNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.AddNewPartySimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.InvoiceNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ConsigneePANNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverPANNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.AddNewProductSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ConsigneeAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AgainstFormTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.PODateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.POTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ConsigneeStateCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverStateCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.ConsigneeNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ReceiverNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.AddressCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ConsigneeStateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.ConsigneeGSTINTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverStateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverGSTINTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.SupplyToTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TransportationModeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.InvoiceDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.InvoiceDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.InvoiceDetailGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PanelCtrlMain = New DevExpress.XtraEditors.PanelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrl.SuspendLayout()
        CType(Me.TaxInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIGSTAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSGSTAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCGSTAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackingChargeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmtAfterTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSTReverseChargeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalGSTTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmtBeforeTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneePANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverPANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgainstFormTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyToTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportationModeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.InvoiceDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDetailGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.NewBarButtonItem, Me.OpenBarButtonItem, Me.PrintBarButtonItem, Me.DeleteBarButtonItem, Me.PrintOriginalPrintBarButtonItem, Me.PrintDuplicateBarButtonItem, Me.PrintTriplicateBarButtonItem, Me.PrintOriginalSignBarButtonItem, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.NewBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.OpenBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.DeleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintOriginalPrintBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintOriginalSignBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'NewBarButtonItem
        '
        Me.NewBarButtonItem.Caption = "&New"
        Me.NewBarButtonItem.Id = 0
        Me.NewBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.NewBarButtonItem.ImageOptions.Image = CType(resources.GetObject("NewBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.NewBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("NewBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NewBarButtonItem.Name = "NewBarButtonItem"
        '
        'OpenBarButtonItem
        '
        Me.OpenBarButtonItem.Caption = "&Open"
        Me.OpenBarButtonItem.Id = 1
        Me.OpenBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.OpenBarButtonItem.ImageOptions.Image = CType(resources.GetObject("OpenBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.OpenBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("OpenBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.OpenBarButtonItem.Name = "OpenBarButtonItem"
        '
        'DeleteBarButtonItem
        '
        Me.DeleteBarButtonItem.Caption = "Delete"
        Me.DeleteBarButtonItem.Id = 3
        Me.DeleteBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.DeleteBarButtonItem.ImageOptions.Image = CType(resources.GetObject("DeleteBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.DeleteBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("DeleteBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.DeleteBarButtonItem.Name = "DeleteBarButtonItem"
        '
        'PrintOriginalPrintBarButtonItem
        '
        Me.PrintOriginalPrintBarButtonItem.Caption = "Print Original"
        Me.PrintOriginalPrintBarButtonItem.Id = 4
        Me.PrintOriginalPrintBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrintOriginalPrintBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintOriginalPrintBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintOriginalPrintBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintOriginalPrintBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintOriginalPrintBarButtonItem.Name = "PrintOriginalPrintBarButtonItem"
        '
        'PrintOriginalSignBarButtonItem
        '
        Me.PrintOriginalSignBarButtonItem.Caption = "Print Original Sign"
        Me.PrintOriginalSignBarButtonItem.Id = 7
        Me.PrintOriginalSignBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintOriginalSignBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintOriginalSignBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintOriginalSignBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintOriginalSignBarButtonItem.Name = "PrintOriginalSignBarButtonItem"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close"
        Me.BarButtonItem1.Id = 8
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(5)
        Me.barDockControlTop.Size = New System.Drawing.Size(2277, 34)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1020)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(5)
        Me.barDockControlBottom.Size = New System.Drawing.Size(2277, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 34)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(5)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 986)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(2277, 34)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(5)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 986)
        '
        'PrintBarButtonItem
        '
        Me.PrintBarButtonItem.Caption = "Print Bill"
        Me.PrintBarButtonItem.Id = 2
        Me.PrintBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrintBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintBarButtonItem.Name = "PrintBarButtonItem"
        '
        'PrintDuplicateBarButtonItem
        '
        Me.PrintDuplicateBarButtonItem.Caption = "Print Duplicate"
        Me.PrintDuplicateBarButtonItem.Id = 5
        Me.PrintDuplicateBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintDuplicateBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintDuplicateBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintDuplicateBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintDuplicateBarButtonItem.Name = "PrintDuplicateBarButtonItem"
        '
        'PrintTriplicateBarButtonItem
        '
        Me.PrintTriplicateBarButtonItem.Caption = "Print Triplicate"
        Me.PrintTriplicateBarButtonItem.Id = 6
        Me.PrintTriplicateBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintTriplicateBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintTriplicateBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintTriplicateBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintTriplicateBarButtonItem.Name = "PrintTriplicateBarButtonItem"
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.ImageOptions.Image = CType(resources.GetObject("SaveSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.SaveSimpleButton.Location = New System.Drawing.Point(371, 835)
        Me.SaveSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(156, 51)
        Me.SaveSimpleButton.TabIndex = 2
        Me.SaveSimpleButton.Text = "&Save 'n' New"
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.ImageOptions.Image = CType(resources.GetObject("CancelSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(537, 835)
        Me.CancelSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(124, 51)
        Me.CancelSimpleButton.TabIndex = 3
        Me.CancelSimpleButton.Text = "&Cancel"
        '
        'lblAttachment
        '
        Me.lblAttachment.Location = New System.Drawing.Point(711, 849)
        Me.lblAttachment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(90, 22)
        Me.lblAttachment.TabIndex = 195
        Me.lblAttachment.Text = "Attachment"
        '
        'SendEmailSimpleButton
        '
        Me.SendEmailSimpleButton.ImageOptions.Image = CType(resources.GetObject("SendEmailSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.SendEmailSimpleButton.Location = New System.Drawing.Point(891, 835)
        Me.SendEmailSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendEmailSimpleButton.Name = "SendEmailSimpleButton"
        Me.SendEmailSimpleButton.Size = New System.Drawing.Size(158, 51)
        Me.SendEmailSimpleButton.TabIndex = 194
        Me.SendEmailSimpleButton.Text = "&Send Email"
        '
        'PanelCtrl
        '
        Me.PanelCtrl.Controls.Add(Me.LabelControl46)
        Me.PanelCtrl.Controls.Add(Me.LabelControl43)
        Me.PanelCtrl.Controls.Add(Me.TaxInWordsTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl8)
        Me.PanelCtrl.Controls.Add(Me.ModifiedByTextEdit)
        Me.PanelCtrl.Controls.Add(Me.CreatedByTextEdit)
        Me.PanelCtrl.Controls.Add(Me.CreatedByLabelControl)
        Me.PanelCtrl.Controls.Add(Me.ModifiedByLabelControl)
        Me.PanelCtrl.Controls.Add(Me.PIGSTAmt)
        Me.PanelCtrl.Controls.Add(Me.LabelControl4)
        Me.PanelCtrl.Controls.Add(Me.PSGSTAmt)
        Me.PanelCtrl.Controls.Add(Me.PCGSTAmt)
        Me.PanelCtrl.Controls.Add(Me.LabelControl6)
        Me.PanelCtrl.Controls.Add(Me.PIGSTRateTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl7)
        Me.PanelCtrl.Controls.Add(Me.PSGSTRateTextEdit)
        Me.PanelCtrl.Controls.Add(Me.PCGSTRateTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl10)
        Me.PanelCtrl.Controls.Add(Me.PackingChargeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl11)
        Me.PanelCtrl.Controls.Add(Me.TotalAmtAfterTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl18)
        Me.PanelCtrl.Controls.Add(Me.GSTReverseChargeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl14)
        Me.PanelCtrl.Controls.Add(Me.TotalGSTTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl13)
        Me.PanelCtrl.Controls.Add(Me.IGSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.SGSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.CGSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl12)
        Me.PanelCtrl.Controls.Add(Me.LabelControl31)
        Me.PanelCtrl.Controls.Add(Me.LabelControl32)
        Me.PanelCtrl.Controls.Add(Me.TotalInWordsTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl54)
        Me.PanelCtrl.Controls.Add(Me.RemarksTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl55)
        Me.PanelCtrl.Controls.Add(Me.NetAmtLabelControl)
        Me.PanelCtrl.Controls.Add(Me.TotalAmtBeforeTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl61)
        Me.PanelCtrl.Controls.Add(Me.PackingTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl16)
        Me.PanelCtrl.Controls.Add(Me.PartyDCDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl50)
        Me.PanelCtrl.Controls.Add(Me.PartyDCNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl51)
        Me.PanelCtrl.Controls.Add(Me.AddNewPartySimpleButton)
        Me.PanelCtrl.Controls.Add(Me.InvoiceNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.ConsigneePANNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl49)
        Me.PanelCtrl.Controls.Add(Me.ReceiverPANNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl48)
        Me.PanelCtrl.Controls.Add(Me.LabelControl40)
        Me.PanelCtrl.Controls.Add(Me.LabelControl39)
        Me.PanelCtrl.Controls.Add(Me.LabelControl38)
        Me.PanelCtrl.Controls.Add(Me.LabelControl37)
        Me.PanelCtrl.Controls.Add(Me.LabelControl36)
        Me.PanelCtrl.Controls.Add(Me.LabelControl20)
        Me.PanelCtrl.Controls.Add(Me.LabelControl9)
        Me.PanelCtrl.Controls.Add(Me.AddNewProductSimpleButton)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeAddressTextEdit)
        Me.PanelCtrl.Controls.Add(Me.AgainstFormTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl35)
        Me.PanelCtrl.Controls.Add(Me.PODateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl33)
        Me.PanelCtrl.Controls.Add(Me.POTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl1)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeStateCodeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl30)
        Me.PanelCtrl.Controls.Add(Me.ReceiverStateCodeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl19)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeNameComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.ReceiverNameComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.AddressCheckEdit)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeStateTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl26)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeGSTINTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl27)
        Me.PanelCtrl.Controls.Add(Me.LabelControl28)
        Me.PanelCtrl.Controls.Add(Me.LabelControl29)
        Me.PanelCtrl.Controls.Add(Me.LabelControl25)
        Me.PanelCtrl.Controls.Add(Me.ReceiverStateTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl24)
        Me.PanelCtrl.Controls.Add(Me.ReceiverGSTINTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl23)
        Me.PanelCtrl.Controls.Add(Me.LabelControl22)
        Me.PanelCtrl.Controls.Add(Me.LabelControl21)
        Me.PanelCtrl.Controls.Add(Me.LabelControl15)
        Me.PanelCtrl.Controls.Add(Me.SupplyToTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl2)
        Me.PanelCtrl.Controls.Add(Me.TransportationModeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl5)
        Me.PanelCtrl.Controls.Add(Me.InvoiceDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl3)
        Me.PanelCtrl.Controls.Add(Me.InvoiceDetailGridControl)
        Me.PanelCtrl.Controls.Add(Me.LabelControl17)
        Me.PanelCtrl.Controls.Add(Me.ReceiverAddressTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl34)
        Me.PanelCtrl.Location = New System.Drawing.Point(9, 8)
        Me.PanelCtrl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCtrl.Name = "PanelCtrl"
        Me.PanelCtrl.Size = New System.Drawing.Size(2247, 817)
        Me.PanelCtrl.TabIndex = 0
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(205, 649)
        Me.LabelControl46.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(81, 22)
        Me.LabelControl46.TabIndex = 286
        Me.LabelControl46.Text = "SGST Amt"
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(205, 606)
        Me.LabelControl43.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(67, 22)
        Me.LabelControl43.TabIndex = 285
        Me.LabelControl43.Text = "SGST %"
        '
        'TaxInWordsTextEdit
        '
        Me.TaxInWordsTextEdit.Location = New System.Drawing.Point(1344, 776)
        Me.TaxInWordsTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.TaxInWordsTextEdit.Name = "TaxInWordsTextEdit"
        Me.TaxInWordsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TaxInWordsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TaxInWordsTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TaxInWordsTextEdit.Properties.ReadOnly = True
        Me.TaxInWordsTextEdit.Size = New System.Drawing.Size(893, 28)
        Me.TaxInWordsTextEdit.TabIndex = 272
        Me.TaxInWordsTextEdit.TabStop = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(1226, 781)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(108, 22)
        Me.LabelControl8.TabIndex = 273
        Me.LabelControl8.Text = "Tax In Words"
        '
        'ModifiedByTextEdit
        '
        Me.ModifiedByTextEdit.Location = New System.Drawing.Point(2061, 603)
        Me.ModifiedByTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ModifiedByTextEdit.Name = "ModifiedByTextEdit"
        Me.ModifiedByTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ModifiedByTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ModifiedByTextEdit.Properties.ReadOnly = True
        Me.ModifiedByTextEdit.Size = New System.Drawing.Size(177, 28)
        Me.ModifiedByTextEdit.TabIndex = 284
        Me.ModifiedByTextEdit.TabStop = False
        '
        'CreatedByTextEdit
        '
        Me.CreatedByTextEdit.Location = New System.Drawing.Point(2061, 559)
        Me.CreatedByTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.CreatedByTextEdit.Name = "CreatedByTextEdit"
        Me.CreatedByTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreatedByTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CreatedByTextEdit.Properties.ReadOnly = True
        Me.CreatedByTextEdit.Size = New System.Drawing.Size(177, 28)
        Me.CreatedByTextEdit.TabIndex = 283
        Me.CreatedByTextEdit.TabStop = False
        '
        'CreatedByLabelControl
        '
        Me.CreatedByLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CreatedByLabelControl.Appearance.Options.UseFont = True
        Me.CreatedByLabelControl.Location = New System.Drawing.Point(1928, 564)
        Me.CreatedByLabelControl.Margin = New System.Windows.Forms.Padding(5)
        Me.CreatedByLabelControl.Name = "CreatedByLabelControl"
        Me.CreatedByLabelControl.Size = New System.Drawing.Size(109, 21)
        Me.CreatedByLabelControl.TabIndex = 282
        Me.CreatedByLabelControl.Text = "Created By : "
        '
        'ModifiedByLabelControl
        '
        Me.ModifiedByLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ModifiedByLabelControl.Appearance.Options.UseFont = True
        Me.ModifiedByLabelControl.Location = New System.Drawing.Point(1928, 608)
        Me.ModifiedByLabelControl.Margin = New System.Windows.Forms.Padding(5)
        Me.ModifiedByLabelControl.Name = "ModifiedByLabelControl"
        Me.ModifiedByLabelControl.Size = New System.Drawing.Size(118, 21)
        Me.ModifiedByLabelControl.TabIndex = 281
        Me.ModifiedByLabelControl.Text = "Modified By : "
        '
        'PIGSTAmt
        '
        Me.PIGSTAmt.Location = New System.Drawing.Point(469, 644)
        Me.PIGSTAmt.Margin = New System.Windows.Forms.Padding(5)
        Me.PIGSTAmt.Name = "PIGSTAmt"
        Me.PIGSTAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PIGSTAmt.Properties.Appearance.Options.UseBackColor = True
        Me.PIGSTAmt.Properties.ReadOnly = True
        Me.PIGSTAmt.Size = New System.Drawing.Size(68, 28)
        Me.PIGSTAmt.TabIndex = 252
        Me.PIGSTAmt.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(381, 649)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(78, 22)
        Me.LabelControl4.TabIndex = 280
        Me.LabelControl4.Text = "IGST Amt"
        '
        'PSGSTAmt
        '
        Me.PSGSTAmt.Location = New System.Drawing.Point(293, 644)
        Me.PSGSTAmt.Margin = New System.Windows.Forms.Padding(5)
        Me.PSGSTAmt.Name = "PSGSTAmt"
        Me.PSGSTAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PSGSTAmt.Properties.Appearance.Options.UseBackColor = True
        Me.PSGSTAmt.Properties.ReadOnly = True
        Me.PSGSTAmt.Size = New System.Drawing.Size(68, 28)
        Me.PSGSTAmt.TabIndex = 279
        Me.PSGSTAmt.TabStop = False
        '
        'PCGSTAmt
        '
        Me.PCGSTAmt.Location = New System.Drawing.Point(116, 644)
        Me.PCGSTAmt.Margin = New System.Windows.Forms.Padding(5)
        Me.PCGSTAmt.Name = "PCGSTAmt"
        Me.PCGSTAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PCGSTAmt.Properties.Appearance.Options.UseBackColor = True
        Me.PCGSTAmt.Properties.ReadOnly = True
        Me.PCGSTAmt.Size = New System.Drawing.Size(68, 28)
        Me.PCGSTAmt.TabIndex = 277
        Me.PCGSTAmt.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 649)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(82, 22)
        Me.LabelControl6.TabIndex = 278
        Me.LabelControl6.Text = "CGST Amt"
        '
        'PIGSTRateTextEdit
        '
        Me.PIGSTRateTextEdit.Location = New System.Drawing.Point(469, 601)
        Me.PIGSTRateTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.PIGSTRateTextEdit.Name = "PIGSTRateTextEdit"
        Me.PIGSTRateTextEdit.Size = New System.Drawing.Size(68, 28)
        Me.PIGSTRateTextEdit.TabIndex = 257
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(381, 606)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 22)
        Me.LabelControl7.TabIndex = 276
        Me.LabelControl7.Text = "IGST %"
        '
        'PSGSTRateTextEdit
        '
        Me.PSGSTRateTextEdit.Location = New System.Drawing.Point(293, 601)
        Me.PSGSTRateTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.PSGSTRateTextEdit.Name = "PSGSTRateTextEdit"
        Me.PSGSTRateTextEdit.Size = New System.Drawing.Size(68, 28)
        Me.PSGSTRateTextEdit.TabIndex = 258
        '
        'PCGSTRateTextEdit
        '
        Me.PCGSTRateTextEdit.Location = New System.Drawing.Point(116, 600)
        Me.PCGSTRateTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.PCGSTRateTextEdit.Name = "PCGSTRateTextEdit"
        Me.PCGSTRateTextEdit.Size = New System.Drawing.Size(68, 28)
        Me.PCGSTRateTextEdit.TabIndex = 255
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 606)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(68, 22)
        Me.LabelControl10.TabIndex = 275
        Me.LabelControl10.Text = "CGST %"
        '
        'PackingChargeTextEdit
        '
        Me.PackingChargeTextEdit.Location = New System.Drawing.Point(214, 559)
        Me.PackingChargeTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.PackingChargeTextEdit.Name = "PackingChargeTextEdit"
        Me.PackingChargeTextEdit.Size = New System.Drawing.Size(323, 28)
        Me.PackingChargeTextEdit.TabIndex = 253
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 564)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(129, 22)
        Me.LabelControl11.TabIndex = 274
        Me.LabelControl11.Text = "Packing Charges"
        '
        'TotalAmtAfterTaxTextEdit
        '
        Me.TotalAmtAfterTaxTextEdit.Location = New System.Drawing.Point(1253, 623)
        Me.TotalAmtAfterTaxTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.TotalAmtAfterTaxTextEdit.Name = "TotalAmtAfterTaxTextEdit"
        Me.TotalAmtAfterTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalAmtAfterTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalAmtAfterTaxTextEdit.Properties.ReadOnly = True
        Me.TotalAmtAfterTaxTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.TotalAmtAfterTaxTextEdit.TabIndex = 263
        Me.TotalAmtAfterTaxTextEdit.TabStop = False
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(983, 628)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(187, 22)
        Me.LabelControl18.TabIndex = 271
        Me.LabelControl18.Text = "Total Amount After Tax"
        '
        'GSTReverseChargeTextEdit
        '
        Me.GSTReverseChargeTextEdit.Location = New System.Drawing.Point(1253, 666)
        Me.GSTReverseChargeTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.GSTReverseChargeTextEdit.Name = "GSTReverseChargeTextEdit"
        Me.GSTReverseChargeTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.GSTReverseChargeTextEdit.TabIndex = 260
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(983, 671)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(253, 22)
        Me.LabelControl14.TabIndex = 270
        Me.LabelControl14.Text = "GST Payable on Reverse Charge"
        '
        'TotalGSTTaxTextEdit
        '
        Me.TotalGSTTaxTextEdit.Location = New System.Drawing.Point(1253, 579)
        Me.TotalGSTTaxTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.TotalGSTTaxTextEdit.Name = "TotalGSTTaxTextEdit"
        Me.TotalGSTTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalGSTTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalGSTTaxTextEdit.Properties.ReadOnly = True
        Me.TotalGSTTaxTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.TotalGSTTaxTextEdit.TabIndex = 262
        Me.TotalGSTTaxTextEdit.TabStop = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(983, 584)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(147, 22)
        Me.LabelControl13.TabIndex = 269
        Me.LabelControl13.Text = "Total Amount:GST"
        '
        'IGSTTextEdit
        '
        Me.IGSTTextEdit.Location = New System.Drawing.Point(746, 667)
        Me.IGSTTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.IGSTTextEdit.Name = "IGSTTextEdit"
        Me.IGSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IGSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IGSTTextEdit.Properties.ReadOnly = True
        Me.IGSTTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.IGSTTextEdit.TabIndex = 259
        Me.IGSTTextEdit.TabStop = False
        '
        'SGSTTextEdit
        '
        Me.SGSTTextEdit.Location = New System.Drawing.Point(746, 623)
        Me.SGSTTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.SGSTTextEdit.Name = "SGSTTextEdit"
        Me.SGSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SGSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.SGSTTextEdit.Properties.ReadOnly = True
        Me.SGSTTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.SGSTTextEdit.TabIndex = 256
        Me.SGSTTextEdit.TabStop = False
        '
        'CGSTTextEdit
        '
        Me.CGSTTextEdit.Location = New System.Drawing.Point(746, 579)
        Me.CGSTTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.CGSTTextEdit.Name = "CGSTTextEdit"
        Me.CGSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CGSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CGSTTextEdit.Properties.ReadOnly = True
        Me.CGSTTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.CGSTTextEdit.TabIndex = 254
        Me.CGSTTextEdit.TabStop = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(594, 672)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 22)
        Me.LabelControl12.TabIndex = 268
        Me.LabelControl12.Text = "Total IGST"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(594, 628)
        Me.LabelControl31.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(89, 22)
        Me.LabelControl31.TabIndex = 267
        Me.LabelControl31.Text = "Total SGST"
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(594, 584)
        Me.LabelControl32.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(90, 22)
        Me.LabelControl32.TabIndex = 266
        Me.LabelControl32.Text = "Total CGST"
        '
        'TotalInWordsTextEdit
        '
        Me.TotalInWordsTextEdit.Location = New System.Drawing.Point(228, 776)
        Me.TotalInWordsTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.TotalInWordsTextEdit.Name = "TotalInWordsTextEdit"
        Me.TotalInWordsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalInWordsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalInWordsTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalInWordsTextEdit.Properties.ReadOnly = True
        Me.TotalInWordsTextEdit.Size = New System.Drawing.Size(988, 28)
        Me.TotalInWordsTextEdit.TabIndex = 264
        Me.TotalInWordsTextEdit.TabStop = False
        '
        'LabelControl54
        '
        Me.LabelControl54.Location = New System.Drawing.Point(16, 781)
        Me.LabelControl54.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(136, 22)
        Me.LabelControl54.TabIndex = 265
        Me.LabelControl54.Text = "Rupees In Words"
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.Location = New System.Drawing.Point(228, 732)
        Me.RemarksTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RemarksTextEdit.Size = New System.Drawing.Size(2010, 28)
        Me.RemarksTextEdit.TabIndex = 261
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(16, 737)
        Me.LabelControl55.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(67, 22)
        Me.LabelControl55.TabIndex = 249
        Me.LabelControl55.Text = "Remarks"
        '
        'NetAmtLabelControl
        '
        Me.NetAmtLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NetAmtLabelControl.Appearance.Options.UseFont = True
        Me.NetAmtLabelControl.Location = New System.Drawing.Point(1499, 618)
        Me.NetAmtLabelControl.Margin = New System.Windows.Forms.Padding(5)
        Me.NetAmtLabelControl.Name = "NetAmtLabelControl"
        Me.NetAmtLabelControl.Size = New System.Drawing.Size(96, 22)
        Me.NetAmtLabelControl.TabIndex = 250
        Me.NetAmtLabelControl.Text = "Grand Amt"
        '
        'TotalAmtBeforeTaxTextEdit
        '
        Me.TotalAmtBeforeTaxTextEdit.Location = New System.Drawing.Point(228, 688)
        Me.TotalAmtBeforeTaxTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.TotalAmtBeforeTaxTextEdit.Name = "TotalAmtBeforeTaxTextEdit"
        Me.TotalAmtBeforeTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalAmtBeforeTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalAmtBeforeTaxTextEdit.Properties.ReadOnly = True
        Me.TotalAmtBeforeTaxTextEdit.Size = New System.Drawing.Size(310, 28)
        Me.TotalAmtBeforeTaxTextEdit.TabIndex = 251
        Me.TotalAmtBeforeTaxTextEdit.TabStop = False
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(16, 689)
        Me.LabelControl61.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(200, 22)
        Me.LabelControl61.TabIndex = 248
        Me.LabelControl61.Text = "Total Amount Before Tax"
        '
        'PackingTextEdit
        '
        Me.PackingTextEdit.Location = New System.Drawing.Point(134, 174)
        Me.PackingTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.PackingTextEdit.Name = "PackingTextEdit"
        Me.PackingTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PackingTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.PackingTextEdit.TabIndex = 201
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(12, 179)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(60, 22)
        Me.LabelControl16.TabIndex = 247
        Me.LabelControl16.Text = "Packing"
        '
        'PartyDCDateDateEdit
        '
        Me.PartyDCDateDateEdit.EditValue = Nothing
        Me.PartyDCDateDateEdit.Location = New System.Drawing.Point(579, 49)
        Me.PartyDCDateDateEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.PartyDCDateDateEdit.MenuManager = Me.BarManager1
        Me.PartyDCDateDateEdit.Name = "PartyDCDateDateEdit"
        Me.PartyDCDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartyDCDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.PartyDCDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PartyDCDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.PartyDCDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PartyDCDateDateEdit.Properties.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.PartyDCDateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.PartyDCDateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.PartyDCDateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.PartyDCDateDateEdit.Size = New System.Drawing.Size(140, 28)
        Me.PartyDCDateDateEdit.TabIndex = 194
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(456, 52)
        Me.LabelControl50.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(111, 22)
        Me.LabelControl50.TabIndex = 246
        Me.LabelControl50.Text = "Party DC Date"
        '
        'PartyDCNoTextEdit
        '
        Me.PartyDCNoTextEdit.Location = New System.Drawing.Point(134, 49)
        Me.PartyDCNoTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.PartyDCNoTextEdit.Name = "PartyDCNoTextEdit"
        Me.PartyDCNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PartyDCNoTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.PartyDCNoTextEdit.TabIndex = 193
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(12, 51)
        Me.LabelControl51.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(97, 22)
        Me.LabelControl51.TabIndex = 245
        Me.LabelControl51.Text = "Party DC No"
        '
        'AddNewPartySimpleButton
        '
        Me.AddNewPartySimpleButton.Appearance.Options.UseTextOptions = True
        Me.AddNewPartySimpleButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AddNewPartySimpleButton.Location = New System.Drawing.Point(1381, 7)
        Me.AddNewPartySimpleButton.Margin = New System.Windows.Forms.Padding(5)
        Me.AddNewPartySimpleButton.Name = "AddNewPartySimpleButton"
        Me.AddNewPartySimpleButton.Size = New System.Drawing.Size(75, 39)
        Me.AddNewPartySimpleButton.TabIndex = 203
        Me.AddNewPartySimpleButton.TabStop = False
        Me.AddNewPartySimpleButton.Text = "Add"
        '
        'InvoiceNoTextEdit
        '
        Me.InvoiceNoTextEdit.Location = New System.Drawing.Point(134, 8)
        Me.InvoiceNoTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.InvoiceNoTextEdit.Name = "InvoiceNoTextEdit"
        Me.InvoiceNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.InvoiceNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.InvoiceNoTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.InvoiceNoTextEdit.TabIndex = 191
        Me.InvoiceNoTextEdit.TabStop = False
        '
        'ConsigneePANNoTextEdit
        '
        Me.ConsigneePANNoTextEdit.Location = New System.Drawing.Point(1574, 189)
        Me.ConsigneePANNoTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ConsigneePANNoTextEdit.Name = "ConsigneePANNoTextEdit"
        Me.ConsigneePANNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneePANNoTextEdit.Size = New System.Drawing.Size(197, 28)
        Me.ConsigneePANNoTextEdit.TabIndex = 217
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(1497, 193)
        Me.LabelControl49.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(61, 22)
        Me.LabelControl49.TabIndex = 244
        Me.LabelControl49.Text = "PAN No"
        '
        'ReceiverPANNoTextEdit
        '
        Me.ReceiverPANNoTextEdit.Location = New System.Drawing.Point(886, 188)
        Me.ReceiverPANNoTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ReceiverPANNoTextEdit.Name = "ReceiverPANNoTextEdit"
        Me.ReceiverPANNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverPANNoTextEdit.Size = New System.Drawing.Size(197, 28)
        Me.ReceiverPANNoTextEdit.TabIndex = 209
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(811, 193)
        Me.LabelControl48.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(61, 22)
        Me.LabelControl48.TabIndex = 243
        Me.LabelControl48.Text = "PAN No"
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl40.Appearance.Options.UseForeColor = True
        Me.LabelControl40.Location = New System.Drawing.Point(61, 100)
        Me.LabelControl40.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl40.TabIndex = 242
        Me.LabelControl40.Text = "*"
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl39.Appearance.Options.UseForeColor = True
        Me.LabelControl39.Location = New System.Drawing.Point(1554, 64)
        Me.LabelControl39.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl39.TabIndex = 241
        Me.LabelControl39.Text = "*"
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl38.Appearance.Options.UseForeColor = True
        Me.LabelControl38.Location = New System.Drawing.Point(866, 64)
        Me.LabelControl38.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl38.TabIndex = 240
        Me.LabelControl38.Text = "*"
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl37.Appearance.Options.UseForeColor = True
        Me.LabelControl37.Location = New System.Drawing.Point(502, 19)
        Me.LabelControl37.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl37.TabIndex = 239
        Me.LabelControl37.Text = "*"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl36.Appearance.Options.UseForeColor = True
        Me.LabelControl36.Location = New System.Drawing.Point(96, 142)
        Me.LabelControl36.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl36.TabIndex = 238
        Me.LabelControl36.Text = "*"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(529, 103)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl20.TabIndex = 237
        Me.LabelControl20.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(116, 19)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl9.TabIndex = 236
        Me.LabelControl9.Text = "*"
        '
        'AddNewProductSimpleButton
        '
        Me.AddNewProductSimpleButton.Location = New System.Drawing.Point(14, 213)
        Me.AddNewProductSimpleButton.Margin = New System.Windows.Forms.Padding(5)
        Me.AddNewProductSimpleButton.Name = "AddNewProductSimpleButton"
        Me.AddNewProductSimpleButton.Size = New System.Drawing.Size(280, 39)
        Me.AddNewProductSimpleButton.TabIndex = 218
        Me.AddNewProductSimpleButton.TabStop = False
        Me.AddNewProductSimpleButton.Text = "Add New Product"
        '
        'ConsigneeAddressTextEdit
        '
        Me.ConsigneeAddressTextEdit.Location = New System.Drawing.Point(1574, 101)
        Me.ConsigneeAddressTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ConsigneeAddressTextEdit.Name = "ConsigneeAddressTextEdit"
        Me.ConsigneeAddressTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeAddressTextEdit.Size = New System.Drawing.Size(570, 28)
        Me.ConsigneeAddressTextEdit.TabIndex = 212
        '
        'AgainstFormTextEdit
        '
        Me.AgainstFormTextEdit.Location = New System.Drawing.Point(579, 132)
        Me.AgainstFormTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.AgainstFormTextEdit.Name = "AgainstFormTextEdit"
        Me.AgainstFormTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AgainstFormTextEdit.Size = New System.Drawing.Size(210, 28)
        Me.AgainstFormTextEdit.TabIndex = 200
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(456, 137)
        Me.LabelControl35.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(96, 22)
        Me.LabelControl35.TabIndex = 235
        Me.LabelControl35.Text = "Way Bill No."
        '
        'PODateDateEdit
        '
        Me.PODateDateEdit.EditValue = Nothing
        Me.PODateDateEdit.Location = New System.Drawing.Point(579, 90)
        Me.PODateDateEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.PODateDateEdit.MenuManager = Me.BarManager1
        Me.PODateDateEdit.Name = "PODateDateEdit"
        Me.PODateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PODateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PODateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.PODateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PODateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.PODateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PODateDateEdit.Properties.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.PODateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.PODateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.PODateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.PODateDateEdit.Size = New System.Drawing.Size(138, 28)
        Me.PODateDateEdit.TabIndex = 198
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(456, 98)
        Me.LabelControl33.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(65, 22)
        Me.LabelControl33.TabIndex = 234
        Me.LabelControl33.Text = "PO Date"
        '
        'POTextEdit
        '
        Me.POTextEdit.Location = New System.Drawing.Point(134, 90)
        Me.POTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.POTextEdit.Name = "POTextEdit"
        Me.POTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.POTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.POTextEdit.TabIndex = 195
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 95)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 22)
        Me.LabelControl1.TabIndex = 233
        Me.LabelControl1.Text = "P. O."
        '
        'ConsigneeStateCodeTextEdit
        '
        Me.ConsigneeStateCodeTextEdit.Location = New System.Drawing.Point(1881, 184)
        Me.ConsigneeStateCodeTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ConsigneeStateCodeTextEdit.Name = "ConsigneeStateCodeTextEdit"
        Me.ConsigneeStateCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeStateCodeTextEdit.Size = New System.Drawing.Size(55, 28)
        Me.ConsigneeStateCodeTextEdit.TabIndex = 216
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(1781, 189)
        Me.LabelControl30.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(86, 22)
        Me.LabelControl30.TabIndex = 232
        Me.LabelControl30.Text = "State Code"
        '
        'ReceiverStateCodeTextEdit
        '
        Me.ReceiverStateCodeTextEdit.Location = New System.Drawing.Point(1401, 146)
        Me.ReceiverStateCodeTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ReceiverStateCodeTextEdit.Name = "ReceiverStateCodeTextEdit"
        Me.ReceiverStateCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverStateCodeTextEdit.Size = New System.Drawing.Size(55, 28)
        Me.ReceiverStateCodeTextEdit.TabIndex = 208
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(1301, 149)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(86, 22)
        Me.LabelControl19.TabIndex = 231
        Me.LabelControl19.Text = "State Code"
        '
        'ConsigneeNameComboBoxEdit
        '
        Me.ConsigneeNameComboBoxEdit.Location = New System.Drawing.Point(1574, 57)
        Me.ConsigneeNameComboBoxEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ConsigneeNameComboBoxEdit.MenuManager = Me.BarManager1
        Me.ConsigneeNameComboBoxEdit.Name = "ConsigneeNameComboBoxEdit"
        Me.ConsigneeNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConsigneeNameComboBoxEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeNameComboBoxEdit.Size = New System.Drawing.Size(570, 28)
        Me.ConsigneeNameComboBoxEdit.TabIndex = 211
        '
        'ReceiverNameComboBoxEdit
        '
        Me.ReceiverNameComboBoxEdit.Location = New System.Drawing.Point(886, 58)
        Me.ReceiverNameComboBoxEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ReceiverNameComboBoxEdit.MenuManager = Me.BarManager1
        Me.ReceiverNameComboBoxEdit.Name = "ReceiverNameComboBoxEdit"
        Me.ReceiverNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReceiverNameComboBoxEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverNameComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ReceiverNameComboBoxEdit.Size = New System.Drawing.Size(570, 28)
        Me.ReceiverNameComboBoxEdit.TabIndex = 204
        '
        'AddressCheckEdit
        '
        Me.AddressCheckEdit.Location = New System.Drawing.Point(1093, 184)
        Me.AddressCheckEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.AddressCheckEdit.MenuManager = Me.BarManager1
        Me.AddressCheckEdit.Name = "AddressCheckEdit"
        Me.AddressCheckEdit.Properties.Caption = "If Billing Address is same as Shipping Address"
        Me.AddressCheckEdit.Size = New System.Drawing.Size(392, 27)
        Me.AddressCheckEdit.TabIndex = 210
        '
        'ConsigneeStateTextEdit
        '
        Me.ConsigneeStateTextEdit.Location = New System.Drawing.Point(1834, 145)
        Me.ConsigneeStateTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ConsigneeStateTextEdit.Name = "ConsigneeStateTextEdit"
        Me.ConsigneeStateTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeStateTextEdit.Size = New System.Drawing.Size(145, 28)
        Me.ConsigneeStateTextEdit.TabIndex = 214
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(1781, 150)
        Me.LabelControl26.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(40, 22)
        Me.LabelControl26.TabIndex = 230
        Me.LabelControl26.Text = "State"
        '
        'ConsigneeGSTINTextEdit
        '
        Me.ConsigneeGSTINTextEdit.Location = New System.Drawing.Point(1574, 145)
        Me.ConsigneeGSTINTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ConsigneeGSTINTextEdit.Name = "ConsigneeGSTINTextEdit"
        Me.ConsigneeGSTINTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeGSTINTextEdit.Size = New System.Drawing.Size(197, 28)
        Me.ConsigneeGSTINTextEdit.TabIndex = 213
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(1497, 150)
        Me.LabelControl27.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(52, 22)
        Me.LabelControl27.TabIndex = 229
        Me.LabelControl27.Text = "GSTIN"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(1497, 106)
        Me.LabelControl28.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(62, 22)
        Me.LabelControl28.TabIndex = 228
        Me.LabelControl28.Text = "Address"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(1497, 64)
        Me.LabelControl29.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(45, 22)
        Me.LabelControl29.TabIndex = 227
        Me.LabelControl29.Text = "Name"
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Location = New System.Drawing.Point(1499, 5)
        Me.LabelControl25.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(144, 29)
        Me.LabelControl25.TabIndex = 226
        Me.LabelControl25.Text = "Shipped to :"
        '
        'ReceiverStateTextEdit
        '
        Me.ReceiverStateTextEdit.Location = New System.Drawing.Point(1146, 146)
        Me.ReceiverStateTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ReceiverStateTextEdit.Name = "ReceiverStateTextEdit"
        Me.ReceiverStateTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverStateTextEdit.Size = New System.Drawing.Size(145, 28)
        Me.ReceiverStateTextEdit.TabIndex = 207
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(1092, 151)
        Me.LabelControl24.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(40, 22)
        Me.LabelControl24.TabIndex = 225
        Me.LabelControl24.Text = "State"
        '
        'ReceiverGSTINTextEdit
        '
        Me.ReceiverGSTINTextEdit.Location = New System.Drawing.Point(886, 146)
        Me.ReceiverGSTINTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ReceiverGSTINTextEdit.Name = "ReceiverGSTINTextEdit"
        Me.ReceiverGSTINTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverGSTINTextEdit.Size = New System.Drawing.Size(197, 28)
        Me.ReceiverGSTINTextEdit.TabIndex = 206
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(811, 151)
        Me.LabelControl23.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(52, 22)
        Me.LabelControl23.TabIndex = 224
        Me.LabelControl23.Text = "GSTIN"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(809, 105)
        Me.LabelControl22.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(62, 22)
        Me.LabelControl22.TabIndex = 223
        Me.LabelControl22.Text = "Address"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(811, 5)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(114, 29)
        Me.LabelControl21.TabIndex = 222
        Me.LabelControl21.Text = "Billed to :"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(811, 64)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(45, 22)
        Me.LabelControl15.TabIndex = 221
        Me.LabelControl15.Text = "Name"
        '
        'SupplyToTextEdit
        '
        Me.SupplyToTextEdit.Location = New System.Drawing.Point(134, 132)
        Me.SupplyToTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.SupplyToTextEdit.Name = "SupplyToTextEdit"
        Me.SupplyToTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SupplyToTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.SupplyToTextEdit.TabIndex = 199
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 137)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 22)
        Me.LabelControl2.TabIndex = 220
        Me.LabelControl2.Text = "Supply To"
        '
        'TransportationModeTextEdit
        '
        Me.TransportationModeTextEdit.Location = New System.Drawing.Point(579, 174)
        Me.TransportationModeTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.TransportationModeTextEdit.Name = "TransportationModeTextEdit"
        Me.TransportationModeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TransportationModeTextEdit.Size = New System.Drawing.Size(138, 28)
        Me.TransportationModeTextEdit.TabIndex = 202
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(456, 179)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl5.TabIndex = 215
        Me.LabelControl5.Text = "Trans. Mode"
        '
        'InvoiceDateDateEdit
        '
        Me.InvoiceDateDateEdit.EditValue = Nothing
        Me.InvoiceDateDateEdit.Location = New System.Drawing.Point(579, 8)
        Me.InvoiceDateDateEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.InvoiceDateDateEdit.MenuManager = Me.BarManager1
        Me.InvoiceDateDateEdit.Name = "InvoiceDateDateEdit"
        Me.InvoiceDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.InvoiceDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InvoiceDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.InvoiceDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InvoiceDateDateEdit.Properties.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.InvoiceDateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.InvoiceDateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.InvoiceDateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.InvoiceDateDateEdit.Size = New System.Drawing.Size(137, 28)
        Me.InvoiceDateDateEdit.TabIndex = 192
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(456, 15)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 22)
        Me.LabelControl3.TabIndex = 196
        Me.LabelControl3.Text = "Date"
        '
        'InvoiceDetailGridControl
        '
        Me.InvoiceDetailGridControl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InvoiceDetailGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5)
        Me.InvoiceDetailGridControl.Location = New System.Drawing.Point(12, 262)
        Me.InvoiceDetailGridControl.MainView = Me.InvoiceDetailGridView
        Me.InvoiceDetailGridControl.Margin = New System.Windows.Forms.Padding(5)
        Me.InvoiceDetailGridControl.MenuManager = Me.BarManager1
        Me.InvoiceDetailGridControl.Name = "InvoiceDetailGridControl"
        Me.InvoiceDetailGridControl.Size = New System.Drawing.Size(2223, 283)
        Me.InvoiceDetailGridControl.TabIndex = 219
        Me.InvoiceDetailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.InvoiceDetailGridView, Me.GridView1})
        '
        'InvoiceDetailGridView
        '
        Me.InvoiceDetailGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.InvoiceDetailGridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.InvoiceDetailGridView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.InvoiceDetailGridView.Appearance.OddRow.Options.UseBackColor = True
        Me.InvoiceDetailGridView.DetailHeight = 592
        Me.InvoiceDetailGridView.GridControl = Me.InvoiceDetailGridControl
        Me.InvoiceDetailGridView.Name = "InvoiceDetailGridView"
        Me.InvoiceDetailGridView.OptionsCustomization.AllowColumnMoving = False
        Me.InvoiceDetailGridView.OptionsCustomization.AllowFilter = False
        Me.InvoiceDetailGridView.OptionsCustomization.AllowSort = False
        Me.InvoiceDetailGridView.OptionsEditForm.PopupEditFormWidth = 1333
        Me.InvoiceDetailGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.InvoiceDetailGridView.OptionsView.ColumnAutoWidth = False
        Me.InvoiceDetailGridView.OptionsView.EnableAppearanceEvenRow = True
        Me.InvoiceDetailGridView.OptionsView.EnableAppearanceOddRow = True
        Me.InvoiceDetailGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.InvoiceDetailGridView.OptionsView.RowAutoHeight = True
        Me.InvoiceDetailGridView.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.InvoiceDetailGridView.OptionsView.ShowGroupPanel = False
        Me.InvoiceDetailGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.InvoiceDetailGridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.InvoiceDetailGridControl
        Me.GridView1.Name = "GridView1"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(12, 14)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(5)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(100, 22)
        Me.LabelControl17.TabIndex = 197
        Me.LabelControl17.Text = "Proforma No"
        '
        'ReceiverAddressTextEdit
        '
        Me.ReceiverAddressTextEdit.Location = New System.Drawing.Point(886, 102)
        Me.ReceiverAddressTextEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.ReceiverAddressTextEdit.Name = "ReceiverAddressTextEdit"
        Me.ReceiverAddressTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverAddressTextEdit.Size = New System.Drawing.Size(570, 28)
        Me.ReceiverAddressTextEdit.TabIndex = 205
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(9, 140)
        Me.LabelControl34.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(45, 22)
        Me.LabelControl34.TabIndex = 128
        Me.LabelControl34.Text = "W. O."
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(237, 835)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(124, 51)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Save"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(817, 849)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 22)
        Me.LinkLabel1.TabIndex = 196
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Attach"
        '
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.AllowTouchScroll = True
        Me.PanelCtrlMain.AlwaysScrollActiveControlIntoView = False
        Me.PanelCtrlMain.Controls.Add(Me.LinkLabel1)
        Me.PanelCtrlMain.Controls.Add(Me.SimpleButton1)
        Me.PanelCtrlMain.Controls.Add(Me.PanelCtrl)
        Me.PanelCtrlMain.Controls.Add(Me.SendEmailSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.lblAttachment)
        Me.PanelCtrlMain.Controls.Add(Me.CancelSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.SaveSimpleButton)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(19, 63)
        Me.PanelCtrlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(2258, 900)
        Me.PanelCtrlMain.TabIndex = 0
        '
        'Frm_ProformaInvoiceNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1946, 1046)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_ProformaInvoiceNew"
        Me.Text = "Proforma Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrl.ResumeLayout(False)
        Me.PanelCtrl.PerformLayout()
        CType(Me.TaxInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIGSTAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSGSTAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCGSTAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackingChargeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmtAfterTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSTReverseChargeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalGSTTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmtBeforeTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneePANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverPANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgainstFormTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyToTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportationModeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.InvoiceDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDetailGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlMain.ResumeLayout(False)
        Me.PanelCtrlMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.DateEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.DateEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LookUpEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LookUpEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LookUpEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LookUpEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents NewBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpenBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DeleteBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintOriginalPrintBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintOriginalSignBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PrintBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintDuplicateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintTriplicateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelCtrlMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelCtrl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TaxInWordsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModifiedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreatedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreatedByLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModifiedByLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PIGSTAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PSGSTAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PCGSTAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PIGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PSGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PCGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PackingChargeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalAmtAfterTaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GSTReverseChargeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalGSTTaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IGSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SGSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CGSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalInWordsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NetAmtLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalAmtBeforeTaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PackingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PartyDCDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PartyDCNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AddNewPartySimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents InvoiceNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConsigneePANNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiverPANNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AddNewProductSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ConsigneeAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AgainstFormTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PODateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents POTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConsigneeStateCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiverStateCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConsigneeNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ReceiverNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents AddressCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ConsigneeStateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConsigneeGSTINTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiverStateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiverGSTINTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SupplyToTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransportationModeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InvoiceDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InvoiceDetailGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents InvoiceDetailGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiverAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SendEmailSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblAttachment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
End Class
