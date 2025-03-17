<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Bank

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Bank))
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
        Me.PanelCtrlMain = New DevExpress.XtraEditors.PanelControl()
        Me.PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.BankNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SwiftCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.SwiftCodeLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.IFSCCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MICRCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.BranchNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AccountNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrl.SuspendLayout()
        CType(Me.BankNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwiftCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IFSCCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MICRCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(365, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 277)
        Me.barDockControlBottom.Size = New System.Drawing.Size(365, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 246)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(365, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 246)
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
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.Controls.Add(Me.PanelCtrl)
        Me.PanelCtrlMain.Controls.Add(Me.CancelSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.SaveSimpleButton)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(12, 37)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(340, 209)
        Me.PanelCtrlMain.TabIndex = 0
        '
        'PanelCtrl
        '
        Me.PanelCtrl.Controls.Add(Me.LabelControl7)
        Me.PanelCtrl.Controls.Add(Me.LabelControl5)
        Me.PanelCtrl.Controls.Add(Me.LabelControl3)
        Me.PanelCtrl.Controls.Add(Me.LabelControl20)
        Me.PanelCtrl.Controls.Add(Me.BankNameTextEdit)
        Me.PanelCtrl.Controls.Add(Me.SwiftCodeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl15)
        Me.PanelCtrl.Controls.Add(Me.SwiftCodeLabelControl)
        Me.PanelCtrl.Controls.Add(Me.LabelControl1)
        Me.PanelCtrl.Controls.Add(Me.IFSCCodeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.MICRCodeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl21)
        Me.PanelCtrl.Controls.Add(Me.BranchNameTextEdit)
        Me.PanelCtrl.Controls.Add(Me.AccountNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl12)
        Me.PanelCtrl.Location = New System.Drawing.Point(9, 5)
        Me.PanelCtrl.Name = "PanelCtrl"
        Me.PanelCtrl.Size = New System.Drawing.Size(323, 160)
        Me.PanelCtrl.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(62, 88)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl7.TabIndex = 106
        Me.LabelControl7.Text = "*"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Location = New System.Drawing.Point(65, 63)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl5.TabIndex = 104
        Me.LabelControl5.Text = "*"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(64, 11)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl3.TabIndex = 102
        Me.LabelControl3.Text = "*"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(8, 8)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl20.TabIndex = 92
        Me.LabelControl20.Text = "Bank Name"
        '
        'BankNameTextEdit
        '
        Me.BankNameTextEdit.Location = New System.Drawing.Point(76, 5)
        Me.BankNameTextEdit.Name = "BankNameTextEdit"
        Me.BankNameTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BankNameTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.BankNameTextEdit.TabIndex = 0
        '
        'SwiftCodeTextEdit
        '
        Me.SwiftCodeTextEdit.Location = New System.Drawing.Point(76, 135)
        Me.SwiftCodeTextEdit.Name = "SwiftCodeTextEdit"
        Me.SwiftCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SwiftCodeTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.SwiftCodeTextEdit.TabIndex = 5
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(8, 34)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl15.TabIndex = 93
        Me.LabelControl15.Text = "Branch Name"
        '
        'SwiftCodeLabelControl
        '
        Me.SwiftCodeLabelControl.Location = New System.Drawing.Point(8, 138)
        Me.SwiftCodeLabelControl.Name = "SwiftCodeLabelControl"
        Me.SwiftCodeLabelControl.Size = New System.Drawing.Size(49, 13)
        Me.SwiftCodeLabelControl.TabIndex = 98
        Me.SwiftCodeLabelControl.Text = "SwiftCode"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 112)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 94
        Me.LabelControl1.Text = "MICR Code"
        '
        'IFSCCodeTextEdit
        '
        Me.IFSCCodeTextEdit.Location = New System.Drawing.Point(76, 83)
        Me.IFSCCodeTextEdit.Name = "IFSCCodeTextEdit"
        Me.IFSCCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IFSCCodeTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.IFSCCodeTextEdit.TabIndex = 3
        '
        'MICRCodeTextEdit
        '
        Me.MICRCodeTextEdit.Location = New System.Drawing.Point(76, 109)
        Me.MICRCodeTextEdit.Name = "MICRCodeTextEdit"
        Me.MICRCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MICRCodeTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.MICRCodeTextEdit.TabIndex = 4
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(8, 86)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl21.TabIndex = 96
        Me.LabelControl21.Text = "IFSC Code"
        '
        'BranchNameTextEdit
        '
        Me.BranchNameTextEdit.Location = New System.Drawing.Point(76, 31)
        Me.BranchNameTextEdit.Name = "BranchNameTextEdit"
        Me.BranchNameTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BranchNameTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.BranchNameTextEdit.TabIndex = 1
        '
        'AccountNoTextEdit
        '
        Me.AccountNoTextEdit.Location = New System.Drawing.Point(76, 57)
        Me.AccountNoTextEdit.Name = "AccountNoTextEdit"
        Me.AccountNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AccountNoTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.AccountNoTextEdit.TabIndex = 2
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(8, 60)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl12.TabIndex = 95
        Me.LabelControl12.Text = "Account No"
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.Image = CType(resources.GetObject("CancelSimpleButton.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(166, 171)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.CancelSimpleButton.TabIndex = 2
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.Image = CType(resources.GetObject("SaveSimpleButton.Image"), System.Drawing.Image)
        Me.SaveSimpleButton.Location = New System.Drawing.Point(85, 171)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.SaveSimpleButton.TabIndex = 1
        Me.SaveSimpleButton.Text = "Save"
        '
        'Frm_Bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 277)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Bank"
        Me.Text = "Bank Details"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlMain.ResumeLayout(False)
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrl.ResumeLayout(False)
        Me.PanelCtrl.PerformLayout()
        CType(Me.BankNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwiftCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IFSCCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MICRCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
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
    Friend WithEvents SwiftCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SwiftCodeLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IFSCCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AccountNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BranchNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MICRCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BankNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelCtrl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
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
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
End Class
