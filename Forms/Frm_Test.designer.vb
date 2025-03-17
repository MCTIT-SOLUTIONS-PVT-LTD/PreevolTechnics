<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Test))
        Me.PanelCtrlDetail = New DevExpress.XtraEditors.PanelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.NewBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.OpenBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.DeleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PanelCtrlDetailMain = New DevExpress.XtraEditors.PanelControl()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.ProductNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.HSNACSTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.UOMTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.QtyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.RateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.AmountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.DiscountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.DiscountAmountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TaxableValueTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.CGSTAmtTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SGSTAmtTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.IGSTAmtTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.IGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.TotalAmountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.PanelCtrlDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlDetail.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrlDetailMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlDetailMain.SuspendLayout()
        CType(Me.ProductNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HSNACSTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOMTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountAmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxableValueTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CGSTAmtTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGSTAmtTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGSTAmtTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCtrlDetail
        '
        Me.PanelCtrlDetail.Controls.Add(Me.DescriptionMemoEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl17)
        Me.PanelCtrlDetail.Controls.Add(Me.TotalAmountTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl15)
        Me.PanelCtrlDetail.Controls.Add(Me.IGSTAmtTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl16)
        Me.PanelCtrlDetail.Controls.Add(Me.IGSTRateTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl6)
        Me.PanelCtrlDetail.Controls.Add(Me.SGSTAmtTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl3)
        Me.PanelCtrlDetail.Controls.Add(Me.SGSTRateTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl2)
        Me.PanelCtrlDetail.Controls.Add(Me.CGSTAmtTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl1)
        Me.PanelCtrlDetail.Controls.Add(Me.CGSTRateTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl14)
        Me.PanelCtrlDetail.Controls.Add(Me.TaxableValueTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl13)
        Me.PanelCtrlDetail.Controls.Add(Me.DiscountAmountTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl12)
        Me.PanelCtrlDetail.Controls.Add(Me.DiscountTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl11)
        Me.PanelCtrlDetail.Controls.Add(Me.AmountTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl10)
        Me.PanelCtrlDetail.Controls.Add(Me.RateTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl9)
        Me.PanelCtrlDetail.Controls.Add(Me.QtyTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl8)
        Me.PanelCtrlDetail.Controls.Add(Me.UOMTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl7)
        Me.PanelCtrlDetail.Controls.Add(Me.HSNACSTextEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl4)
        Me.PanelCtrlDetail.Controls.Add(Me.ProductNameComboBoxEdit)
        Me.PanelCtrlDetail.Controls.Add(Me.LabelControl5)
        Me.PanelCtrlDetail.Location = New System.Drawing.Point(5, 5)
        Me.PanelCtrlDetail.Name = "PanelCtrlDetail"
        Me.PanelCtrlDetail.Size = New System.Drawing.Size(352, 340)
        Me.PanelCtrlDetail.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.NewBarButtonItem, Me.OpenBarButtonItem, Me.PrintBarButtonItem, Me.DeleteBarButtonItem})
        Me.BarManager1.MaxItemId = 4
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.NewBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.OpenBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.DeleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'NewBarButtonItem
        '
        Me.NewBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.NewBarButtonItem.Caption = "New"
        Me.NewBarButtonItem.Glyph = CType(resources.GetObject("NewBarButtonItem.Glyph"), System.Drawing.Image)
        Me.NewBarButtonItem.Id = 0
        Me.NewBarButtonItem.LargeGlyph = CType(resources.GetObject("NewBarButtonItem.LargeGlyph"), System.Drawing.Image)
        Me.NewBarButtonItem.Name = "NewBarButtonItem"
        '
        'OpenBarButtonItem
        '
        Me.OpenBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.OpenBarButtonItem.Caption = "Open"
        Me.OpenBarButtonItem.Glyph = CType(resources.GetObject("OpenBarButtonItem.Glyph"), System.Drawing.Image)
        Me.OpenBarButtonItem.Id = 1
        Me.OpenBarButtonItem.LargeGlyph = CType(resources.GetObject("OpenBarButtonItem.LargeGlyph"), System.Drawing.Image)
        Me.OpenBarButtonItem.Name = "OpenBarButtonItem"
        '
        'DeleteBarButtonItem
        '
        Me.DeleteBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.DeleteBarButtonItem.Caption = "Delete"
        Me.DeleteBarButtonItem.Glyph = CType(resources.GetObject("DeleteBarButtonItem.Glyph"), System.Drawing.Image)
        Me.DeleteBarButtonItem.Id = 3
        Me.DeleteBarButtonItem.LargeGlyph = CType(resources.GetObject("DeleteBarButtonItem.LargeGlyph"), System.Drawing.Image)
        Me.DeleteBarButtonItem.Name = "DeleteBarButtonItem"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(393, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 446)
        Me.barDockControlBottom.Size = New System.Drawing.Size(393, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 415)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(393, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 415)
        '
        'PrintBarButtonItem
        '
        Me.PrintBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrintBarButtonItem.Caption = "Print"
        Me.PrintBarButtonItem.Glyph = CType(resources.GetObject("PrintBarButtonItem.Glyph"), System.Drawing.Image)
        Me.PrintBarButtonItem.Id = 2
        Me.PrintBarButtonItem.LargeGlyph = CType(resources.GetObject("PrintBarButtonItem.LargeGlyph"), System.Drawing.Image)
        Me.PrintBarButtonItem.Name = "PrintBarButtonItem"
        '
        'PanelCtrlDetailMain
        '
        Me.PanelCtrlDetailMain.Controls.Add(Me.CancelSimpleButton)
        Me.PanelCtrlDetailMain.Controls.Add(Me.SaveSimpleButton)
        Me.PanelCtrlDetailMain.Controls.Add(Me.PanelCtrlDetail)
        Me.PanelCtrlDetailMain.Location = New System.Drawing.Point(12, 37)
        Me.PanelCtrlDetailMain.Name = "PanelCtrlDetailMain"
        Me.PanelCtrlDetailMain.Size = New System.Drawing.Size(363, 386)
        Me.PanelCtrlDetailMain.TabIndex = 0
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.Image = CType(resources.GetObject("CancelSimpleButton.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(164, 351)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.CancelSimpleButton.TabIndex = 1
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.Image = CType(resources.GetObject("SaveSimpleButton.Image"), System.Drawing.Image)
        Me.SaveSimpleButton.Location = New System.Drawing.Point(83, 351)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.SaveSimpleButton.TabIndex = 0
        Me.SaveSimpleButton.Text = "Save"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl5.TabIndex = 46
        Me.LabelControl5.Text = "Product Name"
        '
        'ProductNameComboBoxEdit
        '
        Me.ProductNameComboBoxEdit.Location = New System.Drawing.Point(78, 5)
        Me.ProductNameComboBoxEdit.MenuManager = Me.BarManager1
        Me.ProductNameComboBoxEdit.Name = "ProductNameComboBoxEdit"
        Me.ProductNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductNameComboBoxEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProductNameComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ProductNameComboBoxEdit.Size = New System.Drawing.Size(268, 20)
        Me.ProductNameComboBoxEdit.TabIndex = 47
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 33)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Description"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(5, 135)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl7.TabIndex = 50
        Me.LabelControl7.Text = "HSN/ACS"
        '
        'HSNACSTextEdit
        '
        Me.HSNACSTextEdit.EditValue = ""
        Me.HSNACSTextEdit.Location = New System.Drawing.Point(78, 133)
        Me.HSNACSTextEdit.Name = "HSNACSTextEdit"
        Me.HSNACSTextEdit.Size = New System.Drawing.Size(140, 20)
        Me.HSNACSTextEdit.TabIndex = 49
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(224, 136)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl8.TabIndex = 52
        Me.LabelControl8.Text = "UOM"
        '
        'UOMTextEdit
        '
        Me.UOMTextEdit.EditValue = ""
        Me.UOMTextEdit.Location = New System.Drawing.Point(253, 133)
        Me.UOMTextEdit.Name = "UOMTextEdit"
        Me.UOMTextEdit.Size = New System.Drawing.Size(93, 20)
        Me.UOMTextEdit.TabIndex = 51
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(5, 161)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl9.TabIndex = 54
        Me.LabelControl9.Text = "Qty"
        '
        'QtyTextEdit
        '
        Me.QtyTextEdit.EditValue = ""
        Me.QtyTextEdit.Location = New System.Drawing.Point(78, 159)
        Me.QtyTextEdit.Name = "QtyTextEdit"
        Me.QtyTextEdit.Size = New System.Drawing.Size(35, 20)
        Me.QtyTextEdit.TabIndex = 53
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(119, 162)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl10.TabIndex = 56
        Me.LabelControl10.Text = "Rate"
        '
        'RateTextEdit
        '
        Me.RateTextEdit.EditValue = ""
        Me.RateTextEdit.Location = New System.Drawing.Point(148, 159)
        Me.RateTextEdit.Name = "RateTextEdit"
        Me.RateTextEdit.Size = New System.Drawing.Size(70, 20)
        Me.RateTextEdit.TabIndex = 55
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(224, 162)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl11.TabIndex = 58
        Me.LabelControl11.Text = "Amount"
        '
        'AmountTextEdit
        '
        Me.AmountTextEdit.EditValue = ""
        Me.AmountTextEdit.Location = New System.Drawing.Point(267, 159)
        Me.AmountTextEdit.Name = "AmountTextEdit"
        Me.AmountTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AmountTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.AmountTextEdit.Properties.ReadOnly = True
        Me.AmountTextEdit.Size = New System.Drawing.Size(79, 20)
        Me.AmountTextEdit.TabIndex = 57
        Me.AmountTextEdit.TabStop = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(5, 187)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl12.TabIndex = 60
        Me.LabelControl12.Text = "Discount"
        '
        'DiscountTextEdit
        '
        Me.DiscountTextEdit.EditValue = ""
        Me.DiscountTextEdit.Location = New System.Drawing.Point(78, 185)
        Me.DiscountTextEdit.Name = "DiscountTextEdit"
        Me.DiscountTextEdit.Size = New System.Drawing.Size(35, 20)
        Me.DiscountTextEdit.TabIndex = 59
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(180, 188)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl13.TabIndex = 62
        Me.LabelControl13.Text = "Discount Amount"
        '
        'DiscountAmountTextEdit
        '
        Me.DiscountAmountTextEdit.EditValue = ""
        Me.DiscountAmountTextEdit.Location = New System.Drawing.Point(267, 185)
        Me.DiscountAmountTextEdit.Name = "DiscountAmountTextEdit"
        Me.DiscountAmountTextEdit.Size = New System.Drawing.Size(79, 20)
        Me.DiscountAmountTextEdit.TabIndex = 61
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(5, 213)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl14.TabIndex = 64
        Me.LabelControl14.Text = "Taxable Value"
        '
        'TaxableValueTextEdit
        '
        Me.TaxableValueTextEdit.EditValue = ""
        Me.TaxableValueTextEdit.Location = New System.Drawing.Point(78, 211)
        Me.TaxableValueTextEdit.Name = "TaxableValueTextEdit"
        Me.TaxableValueTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TaxableValueTextEdit.Size = New System.Drawing.Size(268, 20)
        Me.TaxableValueTextEdit.TabIndex = 63
        '
        'CGSTRateTextEdit
        '
        Me.CGSTRateTextEdit.EditValue = ""
        Me.CGSTRateTextEdit.Location = New System.Drawing.Point(78, 237)
        Me.CGSTRateTextEdit.Name = "CGSTRateTextEdit"
        Me.CGSTRateTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CGSTRateTextEdit.Size = New System.Drawing.Size(35, 20)
        Me.CGSTRateTextEdit.TabIndex = 65
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 239)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 66
        Me.LabelControl1.Text = "CGST Rate"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(195, 240)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl2.TabIndex = 68
        Me.LabelControl2.Text = "CGST Amount"
        '
        'CGSTAmtTextEdit
        '
        Me.CGSTAmtTextEdit.EditValue = ""
        Me.CGSTAmtTextEdit.Location = New System.Drawing.Point(267, 237)
        Me.CGSTAmtTextEdit.Name = "CGSTAmtTextEdit"
        Me.CGSTAmtTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CGSTAmtTextEdit.Size = New System.Drawing.Size(79, 20)
        Me.CGSTAmtTextEdit.TabIndex = 67
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 265)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 70
        Me.LabelControl3.Text = "SGST Rate"
        '
        'SGSTRateTextEdit
        '
        Me.SGSTRateTextEdit.EditValue = ""
        Me.SGSTRateTextEdit.Location = New System.Drawing.Point(78, 263)
        Me.SGSTRateTextEdit.Name = "SGSTRateTextEdit"
        Me.SGSTRateTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SGSTRateTextEdit.Size = New System.Drawing.Size(35, 20)
        Me.SGSTRateTextEdit.TabIndex = 69
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(195, 266)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl6.TabIndex = 72
        Me.LabelControl6.Text = "SGST Amount"
        '
        'SGSTAmtTextEdit
        '
        Me.SGSTAmtTextEdit.EditValue = ""
        Me.SGSTAmtTextEdit.Location = New System.Drawing.Point(267, 263)
        Me.SGSTAmtTextEdit.Name = "SGSTAmtTextEdit"
        Me.SGSTAmtTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SGSTAmtTextEdit.Size = New System.Drawing.Size(79, 20)
        Me.SGSTAmtTextEdit.TabIndex = 71
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(195, 292)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl15.TabIndex = 76
        Me.LabelControl15.Text = "IGST Amount"
        '
        'IGSTAmtTextEdit
        '
        Me.IGSTAmtTextEdit.EditValue = ""
        Me.IGSTAmtTextEdit.Location = New System.Drawing.Point(267, 289)
        Me.IGSTAmtTextEdit.Name = "IGSTAmtTextEdit"
        Me.IGSTAmtTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IGSTAmtTextEdit.Size = New System.Drawing.Size(79, 20)
        Me.IGSTAmtTextEdit.TabIndex = 75
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(5, 291)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl16.TabIndex = 74
        Me.LabelControl16.Text = "IGST Rate"
        '
        'IGSTRateTextEdit
        '
        Me.IGSTRateTextEdit.EditValue = ""
        Me.IGSTRateTextEdit.Location = New System.Drawing.Point(78, 289)
        Me.IGSTRateTextEdit.Name = "IGSTRateTextEdit"
        Me.IGSTRateTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IGSTRateTextEdit.Size = New System.Drawing.Size(35, 20)
        Me.IGSTRateTextEdit.TabIndex = 73
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(5, 317)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl17.TabIndex = 78
        Me.LabelControl17.Text = "Total Amount"
        '
        'TotalAmountTextEdit
        '
        Me.TotalAmountTextEdit.EditValue = ""
        Me.TotalAmountTextEdit.Location = New System.Drawing.Point(78, 315)
        Me.TotalAmountTextEdit.Name = "TotalAmountTextEdit"
        Me.TotalAmountTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalAmountTextEdit.Size = New System.Drawing.Size(268, 20)
        Me.TotalAmountTextEdit.TabIndex = 77
        '
        'DescriptionMemoEdit
        '
        Me.DescriptionMemoEdit.Location = New System.Drawing.Point(78, 31)
        Me.DescriptionMemoEdit.MenuManager = Me.BarManager1
        Me.DescriptionMemoEdit.Name = "DescriptionMemoEdit"
        Me.DescriptionMemoEdit.Size = New System.Drawing.Size(268, 96)
        Me.DescriptionMemoEdit.TabIndex = 79
        '
        'Frm_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 446)
        Me.Controls.Add(Me.PanelCtrlDetailMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Test"
        Me.Text = "Sub Category"
        CType(Me.PanelCtrlDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlDetail.ResumeLayout(False)
        Me.PanelCtrlDetail.PerformLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCtrlDetailMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlDetailMain.ResumeLayout(False)
        CType(Me.ProductNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HSNACSTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOMTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountAmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxableValueTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CGSTAmtTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGSTAmtTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGSTAmtTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrlDetail As DevExpress.XtraEditors.PanelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrlDetailMain As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
    Friend WithEvents SaveSimpleButton As DevExpress.XtraEditors.SimpleButton
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalAmountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IGSTAmtTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SGSTAmtTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CGSTAmtTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TaxableValueTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DiscountAmountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DiscountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AmountTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents QtyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UOMTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HSNACSTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProductNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DescriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
End Class
