<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_SalesReport

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SalesReport))
        Me.PanelCtrlMain = New DevExpress.XtraEditors.PanelControl()
        Me.PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.InvoiceTypeLabel = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ExportExcelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ToDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.NewBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.OpenBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.DeleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintOriginalPrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintDuplicateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintTriplicateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.FromDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ResetSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.GetDataSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.PartyNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.InvoiceDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.InvoiceDetailGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrl.SuspendLayout()
        CType(Me.ToDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.InvoiceDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDetailGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.Controls.Add(Me.PanelCtrl)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(18, 18)
        Me.PanelCtrlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(2037, 798)
        Me.PanelCtrlMain.TabIndex = 0
        '
        'PanelCtrl
        '
        Me.PanelCtrl.Controls.Add(Me.InvoiceTypeLabel)
        Me.PanelCtrl.Controls.Add(Me.LabelControl1)
        Me.PanelCtrl.Controls.Add(Me.ExportExcelSimpleButton)
        Me.PanelCtrl.Controls.Add(Me.ToDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.FromDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.ResetSimpleButton)
        Me.PanelCtrl.Controls.Add(Me.GetDataSimpleButton)
        Me.PanelCtrl.Controls.Add(Me.LabelControl32)
        Me.PanelCtrl.Controls.Add(Me.PartyNameComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl15)
        Me.PanelCtrl.Controls.Add(Me.LabelControl3)
        Me.PanelCtrl.Controls.Add(Me.InvoiceDetailGridControl)
        Me.PanelCtrl.Location = New System.Drawing.Point(8, 7)
        Me.PanelCtrl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCtrl.Name = "PanelCtrl"
        Me.PanelCtrl.Size = New System.Drawing.Size(2022, 783)
        Me.PanelCtrl.TabIndex = 0
        '
        'InvoiceTypeLabel
        '
        Me.InvoiceTypeLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceTypeLabel.Appearance.Options.UseFont = True
        Me.InvoiceTypeLabel.Location = New System.Drawing.Point(141, 96)
        Me.InvoiceTypeLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.InvoiceTypeLabel.Name = "InvoiceTypeLabel"
        Me.InvoiceTypeLabel.Size = New System.Drawing.Size(44, 24)
        Me.InvoiceTypeLabel.TabIndex = 171
        Me.InvoiceTypeLabel.Text = "Type"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 96)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(127, 24)
        Me.LabelControl1.TabIndex = 170
        Me.LabelControl1.Text = "Invoice Type :"
        '
        'ExportExcelSimpleButton
        '
        Me.ExportExcelSimpleButton.Location = New System.Drawing.Point(1348, 39)
        Me.ExportExcelSimpleButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExportExcelSimpleButton.Name = "ExportExcelSimpleButton"
        Me.ExportExcelSimpleButton.Size = New System.Drawing.Size(112, 34)
        Me.ExportExcelSimpleButton.TabIndex = 169
        Me.ExportExcelSimpleButton.Text = "&Export Excel"
        '
        'ToDateDateEdit
        '
        Me.ToDateDateEdit.EditValue = Nothing
        Me.ToDateDateEdit.Location = New System.Drawing.Point(310, 39)
        Me.ToDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ToDateDateEdit.MenuManager = Me.BarManager1
        Me.ToDateDateEdit.Name = "ToDateDateEdit"
        Me.ToDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToDateDateEdit.Size = New System.Drawing.Size(140, 26)
        Me.ToDateDateEdit.TabIndex = 168
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.NewBarButtonItem, Me.OpenBarButtonItem, Me.PrintBarButtonItem, Me.DeleteBarButtonItem, Me.PrintOriginalPrintBarButtonItem, Me.PrintDuplicateBarButtonItem, Me.PrintTriplicateBarButtonItem})
        Me.BarManager1.MaxItemId = 7
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1946, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 818)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1946, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 818)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1946, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 818)
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
        'PrintBarButtonItem
        '
        Me.PrintBarButtonItem.Caption = "Print Bill"
        Me.PrintBarButtonItem.Id = 2
        Me.PrintBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrintBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintBarButtonItem.Name = "PrintBarButtonItem"
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
        'FromDateDateEdit
        '
        Me.FromDateDateEdit.EditValue = Nothing
        Me.FromDateDateEdit.Location = New System.Drawing.Point(96, 39)
        Me.FromDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FromDateDateEdit.MenuManager = Me.BarManager1
        Me.FromDateDateEdit.Name = "FromDateDateEdit"
        Me.FromDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromDateDateEdit.Size = New System.Drawing.Size(140, 26)
        Me.FromDateDateEdit.TabIndex = 167
        '
        'ResetSimpleButton
        '
        Me.ResetSimpleButton.Appearance.Options.UseTextOptions = True
        Me.ResetSimpleButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ResetSimpleButton.Location = New System.Drawing.Point(1224, 39)
        Me.ResetSimpleButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ResetSimpleButton.Name = "ResetSimpleButton"
        Me.ResetSimpleButton.Size = New System.Drawing.Size(98, 34)
        Me.ResetSimpleButton.TabIndex = 166
        Me.ResetSimpleButton.TabStop = False
        Me.ResetSimpleButton.Text = "&Reset"
        '
        'GetDataSimpleButton
        '
        Me.GetDataSimpleButton.Appearance.Options.UseTextOptions = True
        Me.GetDataSimpleButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GetDataSimpleButton.Location = New System.Drawing.Point(1098, 39)
        Me.GetDataSimpleButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GetDataSimpleButton.Name = "GetDataSimpleButton"
        Me.GetDataSimpleButton.Size = New System.Drawing.Size(98, 34)
        Me.GetDataSimpleButton.TabIndex = 11
        Me.GetDataSimpleButton.TabStop = False
        Me.GetDataSimpleButton.Text = "&Get Data"
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(244, 47)
        Me.LabelControl32.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl32.TabIndex = 126
        Me.LabelControl32.Text = "To Date"
        '
        'PartyNameComboBoxEdit
        '
        Me.PartyNameComboBoxEdit.Location = New System.Drawing.Point(561, 39)
        Me.PartyNameComboBoxEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PartyNameComboBoxEdit.MenuManager = Me.BarManager1
        Me.PartyNameComboBoxEdit.Name = "PartyNameComboBoxEdit"
        Me.PartyNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartyNameComboBoxEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PartyNameComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PartyNameComboBoxEdit.Size = New System.Drawing.Size(488, 26)
        Me.PartyNameComboBoxEdit.TabIndex = 11
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(468, 44)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl15.TabIndex = 83
        Me.LabelControl15.Text = "Party Name"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 44)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "From Date"
        '
        'InvoiceDetailGridControl
        '
        Me.InvoiceDetailGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.InvoiceDetailGridControl.Location = New System.Drawing.Point(8, 158)
        Me.InvoiceDetailGridControl.MainView = Me.InvoiceDetailGridView
        Me.InvoiceDetailGridControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.InvoiceDetailGridControl.MenuManager = Me.BarManager1
        Me.InvoiceDetailGridControl.Name = "InvoiceDetailGridControl"
        Me.InvoiceDetailGridControl.Size = New System.Drawing.Size(2001, 618)
        Me.InvoiceDetailGridControl.TabIndex = 24
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Frm_SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1946, 818)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frm_SalesReport"
        Me.Text = "Sales Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlMain.ResumeLayout(False)
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrl.ResumeLayout(False)
        Me.PanelCtrl.PerformLayout()
        CType(Me.ToDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.InvoiceDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDetailGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrlMain As DevExpress.XtraEditors.PanelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.
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
    Friend WithEvents PanelCtrl As DevExpress.XtraEditors.PanelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.DateEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.DateEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.
    Friend WithEvents InvoiceDetailGridControl As DevExpress.XtraGrid.GridControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
    Friend WithEvents InvoiceDetailGridView As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PartyNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PrintDuplicateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintTriplicateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GetDataSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ResetSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FromDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ExportExcelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InvoiceTypeLabel As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
End Class
