<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_User))
        Me.PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.PasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsAdminCheckEdit = New DevExpress.XtraEditors.CheckEdit()
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.UserNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelCtrlMain = New DevExpress.XtraEditors.PanelControl()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrl.SuspendLayout()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAdminCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCtrl
        '
        Me.PanelCtrl.Controls.Add(Me.PasswordTextEdit)
        Me.PanelCtrl.Controls.Add(Me.IsAdminCheckEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl1)
        Me.PanelCtrl.Controls.Add(Me.UserNameTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl6)
        Me.PanelCtrl.Controls.Add(Me.LabelControl2)
        Me.PanelCtrl.Location = New System.Drawing.Point(5, 5)
        Me.PanelCtrl.Name = "PanelCtrl"
        Me.PanelCtrl.Size = New System.Drawing.Size(346, 84)
        Me.PanelCtrl.TabIndex = 0
        '
        'PasswordTextEdit
        '
        Me.PasswordTextEdit.Location = New System.Drawing.Point(67, 31)
        Me.PasswordTextEdit.Name = "PasswordTextEdit"
        Me.PasswordTextEdit.Properties.UseSystemPasswordChar = True
        Me.PasswordTextEdit.Size = New System.Drawing.Size(274, 20)
        Me.PasswordTextEdit.TabIndex = 1
        '
        'IsAdminCheckEdit
        '
        Me.IsAdminCheckEdit.Location = New System.Drawing.Point(67, 60)
        Me.IsAdminCheckEdit.MenuManager = Me.BarManager1
        Me.IsAdminCheckEdit.Name = "IsAdminCheckEdit"
        Me.IsAdminCheckEdit.Properties.Caption = ""
        Me.IsAdminCheckEdit.Size = New System.Drawing.Size(18, 19)
        Me.IsAdminCheckEdit.TabIndex = 2
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
        Me.barDockControlTop.Size = New System.Drawing.Size(398, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 206)
        Me.barDockControlBottom.Size = New System.Drawing.Size(398, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 175)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(398, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 175)
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
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Is Admin"
        '
        'UserNameTextEdit
        '
        Me.UserNameTextEdit.Location = New System.Drawing.Point(67, 5)
        Me.UserNameTextEdit.Name = "UserNameTextEdit"
        Me.UserNameTextEdit.Size = New System.Drawing.Size(274, 20)
        Me.UserNameTextEdit.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(5, 34)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "User Name"
        '
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.Controls.Add(Me.CancelSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.SaveSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.PanelCtrl)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(12, 37)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(357, 132)
        Me.PanelCtrlMain.TabIndex = 0
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.Image = CType(resources.GetObject("CancelSimpleButton.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(153, 95)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.CancelSimpleButton.TabIndex = 2
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.Image = CType(resources.GetObject("SaveSimpleButton.Image"), System.Drawing.Image)
        Me.SaveSimpleButton.Location = New System.Drawing.Point(72, 95)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.SaveSimpleButton.TabIndex = 1
        Me.SaveSimpleButton.Text = "Save"
        '
        'Frm_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 206)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_User"
        Me.Text = "User"
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrl.ResumeLayout(False)
        Me.PanelCtrl.PerformLayout()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAdminCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
    Friend WithEvents UserNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsAdminCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PasswordTextEdit As DevExpress.XtraEditors.TextEdit
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
End Class
