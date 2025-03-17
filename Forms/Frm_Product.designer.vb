<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Product))
        Me.PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.IsServComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
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
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.AddNewSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.PriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SubCategoryIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.MachineNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.UOMComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.HSNNoOrSACNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CategoryIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelCtrlMain = New DevExpress.XtraEditors.PanelControl()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrl.SuspendLayout()
        CType(Me.IsServComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOMComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HSNNoOrSACNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCtrl
        '
        Me.PanelCtrl.Controls.Add(Me.IsServComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl13)
        Me.PanelCtrl.Controls.Add(Me.LabelControl10)
        Me.PanelCtrl.Controls.Add(Me.AddNewSimpleButton)
        Me.PanelCtrl.Controls.Add(Me.LabelControl12)
        Me.PanelCtrl.Controls.Add(Me.LabelControl11)
        Me.PanelCtrl.Controls.Add(Me.LabelControl9)
        Me.PanelCtrl.Controls.Add(Me.LabelControl8)
        Me.PanelCtrl.Controls.Add(Me.LabelControl7)
        Me.PanelCtrl.Controls.Add(Me.PriceTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl6)
        Me.PanelCtrl.Controls.Add(Me.SubCategoryIDLookUpEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl5)
        Me.PanelCtrl.Controls.Add(Me.LabelControl2)
        Me.PanelCtrl.Controls.Add(Me.MachineNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl4)
        Me.PanelCtrl.Controls.Add(Me.UOMComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl3)
        Me.PanelCtrl.Controls.Add(Me.HSNNoOrSACNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.ProductNameTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl1)
        Me.PanelCtrl.Controls.Add(Me.CategoryIDLookUpEdit)
        Me.PanelCtrl.Location = New System.Drawing.Point(8, 7)
        Me.PanelCtrl.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCtrl.Name = "PanelCtrl"
        Me.PanelCtrl.Size = New System.Drawing.Size(585, 235)
        Me.PanelCtrl.TabIndex = 0
        '
        'IsServComboBoxEdit
        '
        Me.IsServComboBoxEdit.Location = New System.Drawing.Point(429, 121)
        Me.IsServComboBoxEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.IsServComboBoxEdit.MenuManager = Me.BarManager1
        Me.IsServComboBoxEdit.Name = "IsServComboBoxEdit"
        Me.IsServComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IsServComboBoxEdit.Properties.DropDownRows = 2
        Me.IsServComboBoxEdit.Properties.Items.AddRange(New Object() {"N", "Y"})
        Me.IsServComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.IsServComboBoxEdit.Size = New System.Drawing.Size(48, 26)
        Me.IsServComboBoxEdit.TabIndex = 52
        Me.IsServComboBoxEdit.Visible = False
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
        Me.NewBarButtonItem.Caption = "New"
        Me.NewBarButtonItem.Id = 0
        Me.NewBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.NewBarButtonItem.ImageOptions.Image = CType(resources.GetObject("NewBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.NewBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("NewBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NewBarButtonItem.Name = "NewBarButtonItem"
        '
        'OpenBarButtonItem
        '
        Me.OpenBarButtonItem.Caption = "Open"
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(633, 46)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 365)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(633, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 46)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 319)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(633, 46)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 319)
        '
        'PrintBarButtonItem
        '
        Me.PrintBarButtonItem.Caption = "Print"
        Me.PrintBarButtonItem.Id = 2
        Me.PrintBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrintBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintBarButtonItem.Name = "PrintBarButtonItem"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(415, 126)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(9, 19)
        Me.LabelControl13.TabIndex = 51
        Me.LabelControl13.Text = "*"
        Me.LabelControl13.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(342, 124)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl10.TabIndex = 50
        Me.LabelControl10.Text = "Is Service"
        Me.LabelControl10.Visible = False
        '
        'AddNewSimpleButton
        '
        Me.AddNewSimpleButton.Location = New System.Drawing.Point(496, 12)
        Me.AddNewSimpleButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddNewSimpleButton.Name = "AddNewSimpleButton"
        Me.AddNewSimpleButton.Size = New System.Drawing.Size(81, 57)
        Me.AddNewSimpleButton.TabIndex = 3
        Me.AddNewSimpleButton.TabStop = False
        Me.AddNewSimpleButton.Text = "Add New"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(138, 164)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(9, 19)
        Me.LabelControl12.TabIndex = 49
        Me.LabelControl12.Text = "*"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(120, 50)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(9, 19)
        Me.LabelControl11.TabIndex = 48
        Me.LabelControl11.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(126, 88)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(9, 19)
        Me.LabelControl9.TabIndex = 46
        Me.LabelControl9.Text = "*"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(88, 12)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(9, 19)
        Me.LabelControl8.TabIndex = 45
        Me.LabelControl8.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(414, 202)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl7.TabIndex = 44
        Me.LabelControl7.Text = "Price"
        '
        'PriceTextEdit
        '
        Me.PriceTextEdit.Location = New System.Drawing.Point(458, 197)
        Me.PriceTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTextEdit.MenuManager = Me.BarManager1
        Me.PriceTextEdit.Name = "PriceTextEdit"
        Me.PriceTextEdit.Size = New System.Drawing.Size(120, 26)
        Me.PriceTextEdit.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl6.TabIndex = 41
        Me.LabelControl6.Text = "Category"
        '
        'SubCategoryIDLookUpEdit
        '
        Me.SubCategoryIDLookUpEdit.EnterMoveNextControl = True
        Me.SubCategoryIDLookUpEdit.Location = New System.Drawing.Point(156, 45)
        Me.SubCategoryIDLookUpEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.SubCategoryIDLookUpEdit.Name = "SubCategoryIDLookUpEdit"
        Me.SubCategoryIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubCategoryIDLookUpEdit.Properties.NullText = ""
        Me.SubCategoryIDLookUpEdit.Size = New System.Drawing.Size(332, 26)
        Me.SubCategoryIDLookUpEdit.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 50)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl5.TabIndex = 39
        Me.LabelControl5.Text = "Sub Category"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 202)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "Machine No."
        '
        'MachineNoTextEdit
        '
        Me.MachineNoTextEdit.Location = New System.Drawing.Point(156, 197)
        Me.MachineNoTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.MachineNoTextEdit.MenuManager = Me.BarManager1
        Me.MachineNoTextEdit.Name = "MachineNoTextEdit"
        Me.MachineNoTextEdit.Size = New System.Drawing.Size(249, 26)
        Me.MachineNoTextEdit.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 126)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(114, 19)
        Me.LabelControl4.TabIndex = 36
        Me.LabelControl4.Text = "Unit Of Measure"
        '
        'UOMComboBoxEdit
        '
        Me.UOMComboBoxEdit.Location = New System.Drawing.Point(156, 121)
        Me.UOMComboBoxEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.UOMComboBoxEdit.MenuManager = Me.BarManager1
        Me.UOMComboBoxEdit.Name = "UOMComboBoxEdit"
        Me.UOMComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UOMComboBoxEdit.Properties.Items.AddRange(New Object() {"Nos", "Set", "Ltrs", "Mtrs", "KGs"})
        Me.UOMComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.UOMComboBoxEdit.Size = New System.Drawing.Size(178, 26)
        Me.UOMComboBoxEdit.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 164)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(117, 19)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "HSN No/SAC No"
        '
        'HSNNoOrSACNoTextEdit
        '
        Me.HSNNoOrSACNoTextEdit.Location = New System.Drawing.Point(156, 159)
        Me.HSNNoOrSACNoTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.HSNNoOrSACNoTextEdit.MenuManager = Me.BarManager1
        Me.HSNNoOrSACNoTextEdit.Name = "HSNNoOrSACNoTextEdit"
        Me.HSNNoOrSACNoTextEdit.Size = New System.Drawing.Size(422, 26)
        Me.HSNNoOrSACNoTextEdit.TabIndex = 4
        '
        'ProductNameTextEdit
        '
        Me.ProductNameTextEdit.Location = New System.Drawing.Point(156, 83)
        Me.ProductNameTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductNameTextEdit.MenuManager = Me.BarManager1
        Me.ProductNameTextEdit.Name = "ProductNameTextEdit"
        Me.ProductNameTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProductNameTextEdit.Size = New System.Drawing.Size(422, 26)
        Me.ProductNameTextEdit.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 88)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 19)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product Name"
        '
        'CategoryIDLookUpEdit
        '
        Me.CategoryIDLookUpEdit.Location = New System.Drawing.Point(156, 7)
        Me.CategoryIDLookUpEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.CategoryIDLookUpEdit.MenuManager = Me.BarManager1
        Me.CategoryIDLookUpEdit.Name = "CategoryIDLookUpEdit"
        Me.CategoryIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CategoryIDLookUpEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CategoryIDLookUpEdit.Properties.NullText = ""
        Me.CategoryIDLookUpEdit.Properties.PopupSizeable = False
        Me.CategoryIDLookUpEdit.Size = New System.Drawing.Size(332, 26)
        Me.CategoryIDLookUpEdit.TabIndex = 0
        '
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.Controls.Add(Me.CancelSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.SaveSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.PanelCtrl)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(18, 54)
        Me.PanelCtrlMain.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(602, 304)
        Me.PanelCtrlMain.TabIndex = 0
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.ImageOptions.Image = CType(resources.GetObject("CancelSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(285, 251)
        Me.CancelSimpleButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(112, 44)
        Me.CancelSimpleButton.TabIndex = 2
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.ImageOptions.Image = CType(resources.GetObject("SaveSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.SaveSimpleButton.Location = New System.Drawing.Point(164, 251)
        Me.SaveSimpleButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(112, 44)
        Me.SaveSimpleButton.TabIndex = 1
        Me.SaveSimpleButton.Text = "Save"
        '
        'Frm_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 365)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Product"
        Me.Text = "Product"
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrl.ResumeLayout(False)
        Me.PanelCtrl.PerformLayout()
        CType(Me.IsServComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOMComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HSNNoOrSACNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrl As DevExpress.XtraEditors.PanelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrlMain As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProductNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HSNNoOrSACNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UOMComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MachineNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SubCategoryIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CategoryIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents AddNewSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IsServComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
End Class
