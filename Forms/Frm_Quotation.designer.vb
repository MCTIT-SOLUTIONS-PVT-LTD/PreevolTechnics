<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Quotation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Quotation))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.NewBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.OpenBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.DeleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintOriginalPrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintSignOriginalBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintDuplicateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintTriplicateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelCtrlMain = New DevExpress.XtraEditors.PanelControl()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SendEmailSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.ModelNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.PreparedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.MobileTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.ValidityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.WarrantyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.PaymentTermTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.FORTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.DeliveryTimeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.WithGSTCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.PackingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.AddNewPartySimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.KindlyAttentionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PartyDCDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.PartyDCNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.InquiryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.InvoiceNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BuyerPANNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.TaxInWordsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.ModifiedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CreatedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CreatedByLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.ModifiedByLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.AddNewProductSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.InquiryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.BuyerStateCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.BuyerNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TotalAmtAfterTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.TotalGSTTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.IGSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SGSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.BuyerStateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.BuyerGSTINTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.TotalInWordsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.InvoiceDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.NetAmtLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.InvoiceDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.InvoiceDetailGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TotalAmtBeforeTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.BuyerAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.lblAttachment = New DevExpress.XtraEditors.LabelControl()
        Me.SaveNewSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CloseBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrl.SuspendLayout()
        CType(Me.ModelNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreparedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarrantyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentTermTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryTimeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WithGSTCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KindlyAttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InquiryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerPANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InquiryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InquiryDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmtAfterTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalGSTTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.InvoiceDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDetailGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmtBeforeTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.NewBarButtonItem, Me.OpenBarButtonItem, Me.PrintBarButtonItem, Me.DeleteBarButtonItem, Me.PrintOriginalPrintBarButtonItem, Me.PrintDuplicateBarButtonItem, Me.PrintTriplicateBarButtonItem, Me.PrintSignOriginalBarButtonItem, Me.CloseBarButtonItem})
        Me.BarManager1.MaxItemId = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.NewBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.OpenBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.DeleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintOriginalPrintBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintSignOriginalBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseBarButtonItem)})
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
        'PrintSignOriginalBarButtonItem
        '
        Me.PrintSignOriginalBarButtonItem.Caption = "Print Sign Original"
        Me.PrintSignOriginalBarButtonItem.Id = 7
        Me.PrintSignOriginalBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintSignOriginalBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintSignOriginalBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintSignOriginalBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintSignOriginalBarButtonItem.Name = "PrintSignOriginalBarButtonItem"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1365, 34)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 638)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1365, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 34)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 604)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1365, 34)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 604)
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 37)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(1360, 601)
        Me.SplitContainer1.SplitterDistance = 453
        Me.SplitContainer1.TabIndex = 5
        '
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.Controls.Add(Me.LinkLabel1)
        Me.PanelCtrlMain.Controls.Add(Me.SimpleButton1)
        Me.PanelCtrlMain.Controls.Add(Me.SendEmailSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.PanelCtrl)
        Me.PanelCtrlMain.Controls.Add(Me.CancelSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.lblAttachment)
        Me.PanelCtrlMain.Controls.Add(Me.SaveNewSimpleButton)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(5, 33)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(1358, 604)
        Me.PanelCtrlMain.TabIndex = 11
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(507, 571)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 22)
        Me.LinkLabel1.TabIndex = 196
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Attach"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(153, 563)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 30)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Save"
        '
        'SendEmailSimpleButton
        '
        Me.SendEmailSimpleButton.ImageOptions.Image = CType(resources.GetObject("SendEmailSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.SendEmailSimpleButton.Location = New System.Drawing.Point(552, 563)
        Me.SendEmailSimpleButton.Name = "SendEmailSimpleButton"
        Me.SendEmailSimpleButton.Size = New System.Drawing.Size(95, 30)
        Me.SendEmailSimpleButton.TabIndex = 194
        Me.SendEmailSimpleButton.Text = "&Send Email"
        '
        'PanelCtrl
        '
        Me.PanelCtrl.Controls.Add(Me.ModelNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl30)
        Me.PanelCtrl.Controls.Add(Me.PreparedByTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl29)
        Me.PanelCtrl.Controls.Add(Me.MobileTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl28)
        Me.PanelCtrl.Controls.Add(Me.ValidityTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl26)
        Me.PanelCtrl.Controls.Add(Me.WarrantyTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl27)
        Me.PanelCtrl.Controls.Add(Me.PaymentTermTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl25)
        Me.PanelCtrl.Controls.Add(Me.FORTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl20)
        Me.PanelCtrl.Controls.Add(Me.DeliveryTimeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl16)
        Me.PanelCtrl.Controls.Add(Me.WithGSTCheckEdit)
        Me.PanelCtrl.Controls.Add(Me.PackingTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl5)
        Me.PanelCtrl.Controls.Add(Me.LabelControl14)
        Me.PanelCtrl.Controls.Add(Me.LabelControl9)
        Me.PanelCtrl.Controls.Add(Me.AddNewPartySimpleButton)
        Me.PanelCtrl.Controls.Add(Me.KindlyAttentionTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl2)
        Me.PanelCtrl.Controls.Add(Me.PartyDCDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl50)
        Me.PanelCtrl.Controls.Add(Me.PartyDCNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl51)
        Me.PanelCtrl.Controls.Add(Me.InquiryTextEdit)
        Me.PanelCtrl.Controls.Add(Me.InvoiceNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.BuyerPANNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl48)
        Me.PanelCtrl.Controls.Add(Me.TaxInWordsTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl8)
        Me.PanelCtrl.Controls.Add(Me.ModifiedByTextEdit)
        Me.PanelCtrl.Controls.Add(Me.CreatedByTextEdit)
        Me.PanelCtrl.Controls.Add(Me.CreatedByLabelControl)
        Me.PanelCtrl.Controls.Add(Me.ModifiedByLabelControl)
        Me.PanelCtrl.Controls.Add(Me.LabelControl37)
        Me.PanelCtrl.Controls.Add(Me.LabelControl17)
        Me.PanelCtrl.Controls.Add(Me.AddNewProductSimpleButton)
        Me.PanelCtrl.Controls.Add(Me.InquiryDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl32)
        Me.PanelCtrl.Controls.Add(Me.LabelControl31)
        Me.PanelCtrl.Controls.Add(Me.BuyerStateCodeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl19)
        Me.PanelCtrl.Controls.Add(Me.BuyerNameComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.TotalAmtAfterTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl18)
        Me.PanelCtrl.Controls.Add(Me.TotalGSTTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl13)
        Me.PanelCtrl.Controls.Add(Me.IGSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.SGSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.GSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl12)
        Me.PanelCtrl.Controls.Add(Me.LabelControl11)
        Me.PanelCtrl.Controls.Add(Me.LabelControl10)
        Me.PanelCtrl.Controls.Add(Me.BuyerStateTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl24)
        Me.PanelCtrl.Controls.Add(Me.BuyerGSTINTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl23)
        Me.PanelCtrl.Controls.Add(Me.LabelControl22)
        Me.PanelCtrl.Controls.Add(Me.LabelControl21)
        Me.PanelCtrl.Controls.Add(Me.LabelControl15)
        Me.PanelCtrl.Controls.Add(Me.TotalInWordsTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl4)
        Me.PanelCtrl.Controls.Add(Me.RemarksTextEdit)
        Me.PanelCtrl.Controls.Add(Me.InvoiceDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl3)
        Me.PanelCtrl.Controls.Add(Me.LabelControl6)
        Me.PanelCtrl.Controls.Add(Me.NetAmtLabelControl)
        Me.PanelCtrl.Controls.Add(Me.InvoiceDetailGridControl)
        Me.PanelCtrl.Controls.Add(Me.TotalAmtBeforeTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl1)
        Me.PanelCtrl.Controls.Add(Me.LabelControl7)
        Me.PanelCtrl.Controls.Add(Me.BuyerAddressTextEdit)
        Me.PanelCtrl.Location = New System.Drawing.Point(5, 5)
        Me.PanelCtrl.Name = "PanelCtrl"
        Me.PanelCtrl.Size = New System.Drawing.Size(1348, 552)
        Me.PanelCtrl.TabIndex = 0
        '
        'ModelNoTextEdit
        '
        Me.ModelNoTextEdit.Location = New System.Drawing.Point(363, 85)
        Me.ModelNoTextEdit.Name = "ModelNoTextEdit"
        Me.ModelNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModelNoTextEdit.Size = New System.Drawing.Size(82, 28)
        Me.ModelNoTextEdit.TabIndex = 222
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(286, 88)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(75, 22)
        Me.LabelControl30.TabIndex = 223
        Me.LabelControl30.Text = "Model No"
        '
        'PreparedByTextEdit
        '
        Me.PreparedByTextEdit.Location = New System.Drawing.Point(774, 328)
        Me.PreparedByTextEdit.Name = "PreparedByTextEdit"
        Me.PreparedByTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PreparedByTextEdit.Size = New System.Drawing.Size(155, 28)
        Me.PreparedByTextEdit.TabIndex = 15
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Location = New System.Drawing.Point(694, 331)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(120, 21)
        Me.LabelControl29.TabIndex = 221
        Me.LabelControl29.Text = "Prepared By : "
        '
        'MobileTextEdit
        '
        Me.MobileTextEdit.Location = New System.Drawing.Point(983, 328)
        Me.MobileTextEdit.Name = "MobileTextEdit"
        Me.MobileTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MobileTextEdit.Size = New System.Drawing.Size(155, 28)
        Me.MobileTextEdit.TabIndex = 16
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.Location = New System.Drawing.Point(932, 331)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(73, 21)
        Me.LabelControl28.TabIndex = 219
        Me.LabelControl28.Text = "Mobile : "
        '
        'ValidityTextEdit
        '
        Me.ValidityTextEdit.Location = New System.Drawing.Point(1030, 525)
        Me.ValidityTextEdit.Name = "ValidityTextEdit"
        Me.ValidityTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ValidityTextEdit.Size = New System.Drawing.Size(284, 28)
        Me.ValidityTextEdit.TabIndex = 23
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(925, 528)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(69, 22)
        Me.LabelControl26.TabIndex = 218
        Me.LabelControl26.Text = "Validity :"
        '
        'WarrantyTextEdit
        '
        Me.WarrantyTextEdit.Location = New System.Drawing.Point(1030, 497)
        Me.WarrantyTextEdit.Name = "WarrantyTextEdit"
        Me.WarrantyTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.WarrantyTextEdit.Size = New System.Drawing.Size(284, 28)
        Me.WarrantyTextEdit.TabIndex = 22
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(925, 500)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(83, 22)
        Me.LabelControl27.TabIndex = 216
        Me.LabelControl27.Text = "Warranty :"
        '
        'PaymentTermTextEdit
        '
        Me.PaymentTermTextEdit.Location = New System.Drawing.Point(567, 526)
        Me.PaymentTermTextEdit.Name = "PaymentTermTextEdit"
        Me.PaymentTermTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PaymentTermTextEdit.Size = New System.Drawing.Size(284, 28)
        Me.PaymentTermTextEdit.TabIndex = 21
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(462, 529)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(127, 22)
        Me.LabelControl25.TabIndex = 214
        Me.LabelControl25.Text = "Payment Term :"
        '
        'FORTextEdit
        '
        Me.FORTextEdit.Location = New System.Drawing.Point(567, 498)
        Me.FORTextEdit.Name = "FORTextEdit"
        Me.FORTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FORTextEdit.Size = New System.Drawing.Size(284, 28)
        Me.FORTextEdit.TabIndex = 20
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(462, 501)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(55, 22)
        Me.LabelControl20.TabIndex = 212
        Me.LabelControl20.Text = "F.O.R :"
        '
        'DeliveryTimeTextEdit
        '
        Me.DeliveryTimeTextEdit.Location = New System.Drawing.Point(114, 526)
        Me.DeliveryTimeTextEdit.Name = "DeliveryTimeTextEdit"
        Me.DeliveryTimeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DeliveryTimeTextEdit.Size = New System.Drawing.Size(284, 28)
        Me.DeliveryTimeTextEdit.TabIndex = 19
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(9, 529)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(119, 22)
        Me.LabelControl16.TabIndex = 210
        Me.LabelControl16.Text = "Delivery Time :"
        '
        'WithGSTCheckEdit
        '
        Me.WithGSTCheckEdit.Location = New System.Drawing.Point(323, 495)
        Me.WithGSTCheckEdit.MenuManager = Me.BarManager1
        Me.WithGSTCheckEdit.Name = "WithGSTCheckEdit"
        Me.WithGSTCheckEdit.Properties.Caption = "Add GST"
        Me.WithGSTCheckEdit.Size = New System.Drawing.Size(75, 27)
        Me.WithGSTCheckEdit.TabIndex = 18
        '
        'PackingTextEdit
        '
        Me.PackingTextEdit.Location = New System.Drawing.Point(217, 494)
        Me.PackingTextEdit.Name = "PackingTextEdit"
        Me.PackingTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PackingTextEdit.Size = New System.Drawing.Size(92, 28)
        Me.PackingTextEdit.TabIndex = 17
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(8, 498)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(332, 22)
        Me.LabelControl5.TabIndex = 207
        Me.LabelControl5.Text = "Packing/ Courier/Transportation Charges :"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(6, 469)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(235, 25)
        Me.LabelControl14.TabIndex = 206
        Me.LabelControl14.Text = "Terms and Conditions:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(75, 11)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl9.TabIndex = 193
        Me.LabelControl9.Text = "*"
        '
        'AddNewPartySimpleButton
        '
        Me.AddNewPartySimpleButton.Appearance.Options.UseTextOptions = True
        Me.AddNewPartySimpleButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AddNewPartySimpleButton.Location = New System.Drawing.Point(901, 34)
        Me.AddNewPartySimpleButton.Name = "AddNewPartySimpleButton"
        Me.AddNewPartySimpleButton.Size = New System.Drawing.Size(45, 23)
        Me.AddNewPartySimpleButton.TabIndex = 185
        Me.AddNewPartySimpleButton.TabStop = False
        Me.AddNewPartySimpleButton.Text = "Add"
        '
        'KindlyAttentionTextEdit
        '
        Me.KindlyAttentionTextEdit.Location = New System.Drawing.Point(580, 95)
        Me.KindlyAttentionTextEdit.Name = "KindlyAttentionTextEdit"
        Me.KindlyAttentionTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.KindlyAttentionTextEdit.Size = New System.Drawing.Size(759, 28)
        Me.KindlyAttentionTextEdit.TabIndex = 12
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(483, 98)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(153, 22)
        Me.LabelControl2.TabIndex = 183
        Me.LabelControl2.Text = "Kindly Attention To"
        '
        'PartyDCDateDateEdit
        '
        Me.PartyDCDateDateEdit.EditValue = Nothing
        Me.PartyDCDateDateEdit.Location = New System.Drawing.Point(363, 56)
        Me.PartyDCDateDateEdit.MenuManager = Me.BarManager1
        Me.PartyDCDateDateEdit.Name = "PartyDCDateDateEdit"
        Me.PartyDCDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartyDCDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.PartyDCDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PartyDCDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.PartyDCDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PartyDCDateDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.PartyDCDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.PartyDCDateDateEdit.Size = New System.Drawing.Size(83, 28)
        Me.PartyDCDateDateEdit.TabIndex = 5
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(286, 57)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(111, 22)
        Me.LabelControl50.TabIndex = 182
        Me.LabelControl50.Text = "Party DC Date"
        '
        'PartyDCNoTextEdit
        '
        Me.PartyDCNoTextEdit.Location = New System.Drawing.Point(113, 56)
        Me.PartyDCNoTextEdit.Name = "PartyDCNoTextEdit"
        Me.PartyDCNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PartyDCNoTextEdit.Size = New System.Drawing.Size(139, 28)
        Me.PartyDCNoTextEdit.TabIndex = 4
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(5, 57)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(137, 22)
        Me.LabelControl51.TabIndex = 181
        Me.LabelControl51.Text = "Party DC No/ Ref"
        '
        'InquiryTextEdit
        '
        Me.InquiryTextEdit.Location = New System.Drawing.Point(113, 31)
        Me.InquiryTextEdit.Name = "InquiryTextEdit"
        Me.InquiryTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.InquiryTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.InquiryTextEdit.Size = New System.Drawing.Size(139, 28)
        Me.InquiryTextEdit.TabIndex = 2
        '
        'InvoiceNoTextEdit
        '
        Me.InvoiceNoTextEdit.Location = New System.Drawing.Point(113, 5)
        Me.InvoiceNoTextEdit.Name = "InvoiceNoTextEdit"
        Me.InvoiceNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.InvoiceNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.InvoiceNoTextEdit.Size = New System.Drawing.Size(139, 28)
        Me.InvoiceNoTextEdit.TabIndex = 0
        '
        'BuyerPANNoTextEdit
        '
        Me.BuyerPANNoTextEdit.Location = New System.Drawing.Point(1225, 34)
        Me.BuyerPANNoTextEdit.Name = "BuyerPANNoTextEdit"
        Me.BuyerPANNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BuyerPANNoTextEdit.Size = New System.Drawing.Size(114, 28)
        Me.BuyerPANNoTextEdit.TabIndex = 10
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(1154, 36)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(61, 22)
        Me.LabelControl48.TabIndex = 167
        Me.LabelControl48.Text = "PAN No"
        '
        'TaxInWordsTextEdit
        '
        Me.TaxInWordsTextEdit.Location = New System.Drawing.Point(803, 443)
        Me.TaxInWordsTextEdit.Name = "TaxInWordsTextEdit"
        Me.TaxInWordsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TaxInWordsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TaxInWordsTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TaxInWordsTextEdit.Properties.ReadOnly = True
        Me.TaxInWordsTextEdit.Size = New System.Drawing.Size(536, 28)
        Me.TaxInWordsTextEdit.TabIndex = 135
        Me.TaxInWordsTextEdit.TabStop = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(732, 446)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(108, 22)
        Me.LabelControl8.TabIndex = 136
        Me.LabelControl8.Text = "Tax In Words"
        '
        'ModifiedByTextEdit
        '
        Me.ModifiedByTextEdit.Location = New System.Drawing.Point(1231, 355)
        Me.ModifiedByTextEdit.Name = "ModifiedByTextEdit"
        Me.ModifiedByTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ModifiedByTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ModifiedByTextEdit.Properties.ReadOnly = True
        Me.ModifiedByTextEdit.Size = New System.Drawing.Size(106, 28)
        Me.ModifiedByTextEdit.TabIndex = 165
        Me.ModifiedByTextEdit.TabStop = False
        '
        'CreatedByTextEdit
        '
        Me.CreatedByTextEdit.Location = New System.Drawing.Point(1231, 328)
        Me.CreatedByTextEdit.Name = "CreatedByTextEdit"
        Me.CreatedByTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreatedByTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CreatedByTextEdit.Properties.ReadOnly = True
        Me.CreatedByTextEdit.Size = New System.Drawing.Size(106, 28)
        Me.CreatedByTextEdit.TabIndex = 24
        Me.CreatedByTextEdit.TabStop = False
        '
        'CreatedByLabelControl
        '
        Me.CreatedByLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CreatedByLabelControl.Appearance.Options.UseFont = True
        Me.CreatedByLabelControl.Location = New System.Drawing.Point(1144, 331)
        Me.CreatedByLabelControl.Name = "CreatedByLabelControl"
        Me.CreatedByLabelControl.Size = New System.Drawing.Size(109, 21)
        Me.CreatedByLabelControl.TabIndex = 163
        Me.CreatedByLabelControl.Text = "Created By : "
        '
        'ModifiedByLabelControl
        '
        Me.ModifiedByLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ModifiedByLabelControl.Appearance.Options.UseFont = True
        Me.ModifiedByLabelControl.Location = New System.Drawing.Point(1144, 358)
        Me.ModifiedByLabelControl.Name = "ModifiedByLabelControl"
        Me.ModifiedByLabelControl.Size = New System.Drawing.Size(118, 21)
        Me.ModifiedByLabelControl.TabIndex = 162
        Me.ModifiedByLabelControl.Text = "Modified By : "
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl37.Appearance.Options.UseForeColor = True
        Me.LabelControl37.Location = New System.Drawing.Point(315, 11)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl37.TabIndex = 140
        Me.LabelControl37.Text = "*"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(516, 40)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl17.TabIndex = 137
        Me.LabelControl17.Text = "*"
        '
        'AddNewProductSimpleButton
        '
        Me.AddNewProductSimpleButton.Location = New System.Drawing.Point(6, 88)
        Me.AddNewProductSimpleButton.Name = "AddNewProductSimpleButton"
        Me.AddNewProductSimpleButton.Size = New System.Drawing.Size(168, 23)
        Me.AddNewProductSimpleButton.TabIndex = 24
        Me.AddNewProductSimpleButton.TabStop = False
        Me.AddNewProductSimpleButton.Text = "Add New Product"
        '
        'InquiryDateDateEdit
        '
        Me.InquiryDateDateEdit.EditValue = Nothing
        Me.InquiryDateDateEdit.Location = New System.Drawing.Point(363, 31)
        Me.InquiryDateDateEdit.MenuManager = Me.BarManager1
        Me.InquiryDateDateEdit.Name = "InquiryDateDateEdit"
        Me.InquiryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InquiryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InquiryDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.InquiryDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InquiryDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.InquiryDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InquiryDateDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.InquiryDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.InquiryDateDateEdit.Size = New System.Drawing.Size(83, 28)
        Me.InquiryDateDateEdit.TabIndex = 3
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(286, 34)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(36, 22)
        Me.LabelControl32.TabIndex = 126
        Me.LabelControl32.Text = "Date"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(3, 34)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(111, 22)
        Me.LabelControl31.TabIndex = 124
        Me.LabelControl31.Text = "Inquiry By/No"
        '
        'BuyerStateCodeTextEdit
        '
        Me.BuyerStateCodeTextEdit.Location = New System.Drawing.Point(1225, 66)
        Me.BuyerStateCodeTextEdit.Name = "BuyerStateCodeTextEdit"
        Me.BuyerStateCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BuyerStateCodeTextEdit.Size = New System.Drawing.Size(33, 28)
        Me.BuyerStateCodeTextEdit.TabIndex = 11
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(1154, 68)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(86, 22)
        Me.LabelControl19.TabIndex = 120
        Me.LabelControl19.Text = "State Code"
        '
        'BuyerNameComboBoxEdit
        '
        Me.BuyerNameComboBoxEdit.Location = New System.Drawing.Point(580, 34)
        Me.BuyerNameComboBoxEdit.MenuManager = Me.BarManager1
        Me.BuyerNameComboBoxEdit.Name = "BuyerNameComboBoxEdit"
        Me.BuyerNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerNameComboBoxEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BuyerNameComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.BuyerNameComboBoxEdit.Size = New System.Drawing.Size(315, 28)
        Me.BuyerNameComboBoxEdit.TabIndex = 6
        '
        'TotalAmtAfterTaxTextEdit
        '
        Me.TotalAmtAfterTaxTextEdit.Location = New System.Drawing.Point(136, 387)
        Me.TotalAmtAfterTaxTextEdit.Name = "TotalAmtAfterTaxTextEdit"
        Me.TotalAmtAfterTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalAmtAfterTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalAmtAfterTaxTextEdit.Properties.ReadOnly = True
        Me.TotalAmtAfterTaxTextEdit.Size = New System.Drawing.Size(173, 28)
        Me.TotalAmtAfterTaxTextEdit.TabIndex = 29
        Me.TotalAmtAfterTaxTextEdit.TabStop = False
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(10, 390)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(187, 22)
        Me.LabelControl18.TabIndex = 115
        Me.LabelControl18.Text = "Total Amount After Tax"
        '
        'TotalGSTTaxTextEdit
        '
        Me.TotalGSTTaxTextEdit.Location = New System.Drawing.Point(136, 363)
        Me.TotalGSTTaxTextEdit.Name = "TotalGSTTaxTextEdit"
        Me.TotalGSTTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalGSTTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalGSTTaxTextEdit.Properties.ReadOnly = True
        Me.TotalGSTTaxTextEdit.Size = New System.Drawing.Size(173, 28)
        Me.TotalGSTTaxTextEdit.TabIndex = 28
        Me.TotalGSTTaxTextEdit.TabStop = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(9, 366)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(147, 22)
        Me.LabelControl13.TabIndex = 111
        Me.LabelControl13.Text = "Total Amount:GST"
        '
        'IGSTTextEdit
        '
        Me.IGSTTextEdit.Location = New System.Drawing.Point(373, 391)
        Me.IGSTTextEdit.Name = "IGSTTextEdit"
        Me.IGSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IGSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IGSTTextEdit.Properties.ReadOnly = True
        Me.IGSTTextEdit.Size = New System.Drawing.Size(23, 28)
        Me.IGSTTextEdit.TabIndex = 27
        Me.IGSTTextEdit.TabStop = False
        Me.IGSTTextEdit.Visible = False
        '
        'SGSTTextEdit
        '
        Me.SGSTTextEdit.Location = New System.Drawing.Point(373, 365)
        Me.SGSTTextEdit.Name = "SGSTTextEdit"
        Me.SGSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SGSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.SGSTTextEdit.Properties.ReadOnly = True
        Me.SGSTTextEdit.Size = New System.Drawing.Size(23, 28)
        Me.SGSTTextEdit.TabIndex = 26
        Me.SGSTTextEdit.TabStop = False
        Me.SGSTTextEdit.Visible = False
        '
        'GSTTextEdit
        '
        Me.GSTTextEdit.Location = New System.Drawing.Point(373, 339)
        Me.GSTTextEdit.Name = "GSTTextEdit"
        Me.GSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.GSTTextEdit.Properties.ReadOnly = True
        Me.GSTTextEdit.Size = New System.Drawing.Size(23, 28)
        Me.GSTTextEdit.TabIndex = 25
        Me.GSTTextEdit.TabStop = False
        Me.GSTTextEdit.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(315, 394)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 22)
        Me.LabelControl12.TabIndex = 107
        Me.LabelControl12.Text = "Total IGST"
        Me.LabelControl12.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(315, 368)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(89, 22)
        Me.LabelControl11.TabIndex = 105
        Me.LabelControl11.Text = "Total SGST"
        Me.LabelControl11.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(315, 342)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(79, 22)
        Me.LabelControl10.TabIndex = 103
        Me.LabelControl10.Text = "Total GST"
        Me.LabelControl10.Visible = False
        '
        'BuyerStateTextEdit
        '
        Me.BuyerStateTextEdit.Location = New System.Drawing.Point(1000, 67)
        Me.BuyerStateTextEdit.Name = "BuyerStateTextEdit"
        Me.BuyerStateTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BuyerStateTextEdit.Size = New System.Drawing.Size(118, 28)
        Me.BuyerStateTextEdit.TabIndex = 9
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(955, 69)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(40, 22)
        Me.LabelControl24.TabIndex = 91
        Me.LabelControl24.Text = "State"
        '
        'BuyerGSTINTextEdit
        '
        Me.BuyerGSTINTextEdit.Location = New System.Drawing.Point(1000, 34)
        Me.BuyerGSTINTextEdit.Name = "BuyerGSTINTextEdit"
        Me.BuyerGSTINTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BuyerGSTINTextEdit.Size = New System.Drawing.Size(118, 28)
        Me.BuyerGSTINTextEdit.TabIndex = 8
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(955, 38)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(52, 22)
        Me.LabelControl23.TabIndex = 89
        Me.LabelControl23.Text = "GSTIN"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(483, 68)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(62, 22)
        Me.LabelControl22.TabIndex = 86
        Me.LabelControl22.Text = "Address"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(483, 3)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(85, 29)
        Me.LabelControl21.TabIndex = 84
        Me.LabelControl21.Text = "Buyer :"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(483, 37)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(45, 22)
        Me.LabelControl15.TabIndex = 83
        Me.LabelControl15.Text = "Name"
        '
        'TotalInWordsTextEdit
        '
        Me.TotalInWordsTextEdit.Location = New System.Drawing.Point(133, 443)
        Me.TotalInWordsTextEdit.Name = "TotalInWordsTextEdit"
        Me.TotalInWordsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalInWordsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalInWordsTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalInWordsTextEdit.Properties.ReadOnly = True
        Me.TotalInWordsTextEdit.Size = New System.Drawing.Size(593, 28)
        Me.TotalInWordsTextEdit.TabIndex = 32
        Me.TotalInWordsTextEdit.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(6, 446)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(136, 22)
        Me.LabelControl4.TabIndex = 51
        Me.LabelControl4.Text = "Rupees In Words"
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.Location = New System.Drawing.Point(133, 417)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RemarksTextEdit.Size = New System.Drawing.Size(1206, 28)
        Me.RemarksTextEdit.TabIndex = 14
        '
        'InvoiceDateDateEdit
        '
        Me.InvoiceDateDateEdit.EditValue = Nothing
        Me.InvoiceDateDateEdit.Location = New System.Drawing.Point(363, 5)
        Me.InvoiceDateDateEdit.MenuManager = Me.BarManager1
        Me.InvoiceDateDateEdit.Name = "InvoiceDateDateEdit"
        Me.InvoiceDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.InvoiceDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InvoiceDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.InvoiceDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InvoiceDateDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.InvoiceDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.InvoiceDateDateEdit.Size = New System.Drawing.Size(82, 28)
        Me.InvoiceDateDateEdit.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(286, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 22)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Date"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(6, 420)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(67, 22)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Remarks"
        '
        'NetAmtLabelControl
        '
        Me.NetAmtLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NetAmtLabelControl.Appearance.Options.UseFont = True
        Me.NetAmtLabelControl.Location = New System.Drawing.Point(444, 361)
        Me.NetAmtLabelControl.Name = "NetAmtLabelControl"
        Me.NetAmtLabelControl.Size = New System.Drawing.Size(96, 22)
        Me.NetAmtLabelControl.TabIndex = 11
        Me.NetAmtLabelControl.Text = "Grand Amt"
        '
        'InvoiceDetailGridControl
        '
        Me.InvoiceDetailGridControl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InvoiceDetailGridControl.Location = New System.Drawing.Point(5, 122)
        Me.InvoiceDetailGridControl.MainView = Me.InvoiceDetailGridView
        Me.InvoiceDetailGridControl.MenuManager = Me.BarManager1
        Me.InvoiceDetailGridControl.Name = "InvoiceDetailGridControl"
        Me.InvoiceDetailGridControl.Size = New System.Drawing.Size(1334, 200)
        Me.InvoiceDetailGridControl.TabIndex = 13
        Me.InvoiceDetailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.InvoiceDetailGridView})
        '
        'InvoiceDetailGridView
        '
        Me.InvoiceDetailGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.InvoiceDetailGridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.InvoiceDetailGridView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.InvoiceDetailGridView.Appearance.OddRow.Options.UseBackColor = True
        Me.InvoiceDetailGridView.GridControl = Me.InvoiceDetailGridControl
        Me.InvoiceDetailGridView.Name = "InvoiceDetailGridView"
        Me.InvoiceDetailGridView.OptionsCustomization.AllowColumnMoving = False
        Me.InvoiceDetailGridView.OptionsCustomization.AllowFilter = False
        Me.InvoiceDetailGridView.OptionsCustomization.AllowSort = False
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
        'TotalAmtBeforeTaxTextEdit
        '
        Me.TotalAmtBeforeTaxTextEdit.Location = New System.Drawing.Point(136, 339)
        Me.TotalAmtBeforeTaxTextEdit.Name = "TotalAmtBeforeTaxTextEdit"
        Me.TotalAmtBeforeTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalAmtBeforeTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalAmtBeforeTaxTextEdit.Properties.ReadOnly = True
        Me.TotalAmtBeforeTaxTextEdit.Size = New System.Drawing.Size(173, 28)
        Me.TotalAmtBeforeTaxTextEdit.TabIndex = 19
        Me.TotalAmtBeforeTaxTextEdit.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(106, 22)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Quotation No"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(8, 342)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(200, 22)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Total Amount Before Tax"
        '
        'BuyerAddressTextEdit
        '
        Me.BuyerAddressTextEdit.Location = New System.Drawing.Point(580, 65)
        Me.BuyerAddressTextEdit.Name = "BuyerAddressTextEdit"
        Me.BuyerAddressTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BuyerAddressTextEdit.Size = New System.Drawing.Size(315, 28)
        Me.BuyerAddressTextEdit.TabIndex = 7
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.ImageOptions.Image = CType(resources.GetObject("CancelSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(333, 563)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.CancelSimpleButton.TabIndex = 3
        Me.CancelSimpleButton.Text = "&Cancel"
        '
        'lblAttachment
        '
        Me.lblAttachment.Location = New System.Drawing.Point(444, 571)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(90, 22)
        Me.lblAttachment.TabIndex = 195
        Me.lblAttachment.Text = "Attachment"
        '
        'SaveNewSimpleButton
        '
        Me.SaveNewSimpleButton.ImageOptions.Image = CType(resources.GetObject("SaveNewSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.SaveNewSimpleButton.Location = New System.Drawing.Point(234, 563)
        Me.SaveNewSimpleButton.Name = "SaveNewSimpleButton"
        Me.SaveNewSimpleButton.Size = New System.Drawing.Size(93, 30)
        Me.SaveNewSimpleButton.TabIndex = 2
        Me.SaveNewSimpleButton.Text = "&Save 'n' New"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CloseBarButtonItem
        '
        Me.CloseBarButtonItem.Caption = "Close"
        Me.CloseBarButtonItem.Id = 8
        Me.CloseBarButtonItem.ImageOptions.Image = CType(resources.GetObject("CloseBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.CloseBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("CloseBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.CloseBarButtonItem.Name = "CloseBarButtonItem"
        Me.CloseBarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Frm_Quotation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1300, 643)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Quotation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Quotation"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlMain.ResumeLayout(False)
        Me.PanelCtrlMain.PerformLayout()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrl.ResumeLayout(False)
        Me.PanelCtrl.PerformLayout()
        CType(Me.ModelNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreparedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarrantyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentTermTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryTimeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WithGSTCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KindlyAttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InquiryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerPANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InquiryDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InquiryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmtAfterTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalGSTTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.InvoiceDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDetailGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmtBeforeTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents NewBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents OpenBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents PrintBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents DeleteBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
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
    Friend WithEvents PrintOriginalPrintBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PrintDuplicateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintTriplicateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PanelCtrlMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelCtrl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PreparedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MobileTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ValidityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WarrantyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PaymentTermTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DeliveryTimeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WithGSTCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PackingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AddNewPartySimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KindlyAttentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PartyDCDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PartyDCNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InquiryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvoiceNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BuyerPANNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TaxInWordsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModifiedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreatedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreatedByLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModifiedByLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AddNewProductSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents InquiryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BuyerStateCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BuyerNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TotalAmtAfterTaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalGSTTaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IGSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SGSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BuyerStateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BuyerGSTINTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalInWordsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvoiceDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NetAmtLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InvoiceDetailGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents InvoiceDetailGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TotalAmtBeforeTaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BuyerAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveNewSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintSignOriginalBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents SendEmailSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblAttachment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ModelNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CloseBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
End Class
