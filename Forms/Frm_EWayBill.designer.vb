<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_EWayBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EWayBill))
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
        Me.AckNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AckDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.QRCodeMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtBoxResp = New DevExpress.XtraEditors.TextEdit()
        Me.MaskedTextBox1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIRN = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl()
        Me.GenerateEWBSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtBoxError = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        CType(Me.AckNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AckDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AckDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRCodeMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBoxResp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaskedTextBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIRN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBoxError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlTop.Size = New System.Drawing.Size(1946, 34)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 650)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1946, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 34)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 616)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1946, 34)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 616)
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
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.Controls.Add(Me.AckNoTextEdit)
        Me.PanelCtrlMain.Controls.Add(Me.AckDateDateEdit)
        Me.PanelCtrlMain.Controls.Add(Me.QRCodeMemoEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl59)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl58)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl60)
        Me.PanelCtrlMain.Controls.Add(Me.TxtBoxResp)
        Me.PanelCtrlMain.Controls.Add(Me.MaskedTextBox1)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl53)
        Me.PanelCtrlMain.Controls.Add(Me.txtIRN)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl52)
        Me.PanelCtrlMain.Controls.Add(Me.GenerateEWBSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl57)
        Me.PanelCtrlMain.Controls.Add(Me.Label1)
        Me.PanelCtrlMain.Controls.Add(Me.TxtBoxError)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl56)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(20, 63)
        Me.PanelCtrlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(1913, 572)
        Me.PanelCtrlMain.TabIndex = 0
        '
        'AckNoTextEdit
        '
        Me.AckNoTextEdit.Location = New System.Drawing.Point(91, 466)
        Me.AckNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AckNoTextEdit.Name = "AckNoTextEdit"
        Me.AckNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.AckNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.AckNoTextEdit.Size = New System.Drawing.Size(340, 28)
        Me.AckNoTextEdit.TabIndex = 230
        Me.AckNoTextEdit.TabStop = False
        '
        'AckDateDateEdit
        '
        Me.AckDateDateEdit.EditValue = Nothing
        Me.AckDateDateEdit.Location = New System.Drawing.Point(547, 466)
        Me.AckDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AckDateDateEdit.MenuManager = Me.BarManager1
        Me.AckDateDateEdit.Name = "AckDateDateEdit"
        Me.AckDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AckDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AckDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.AckDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AckDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.AckDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AckDateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.AckDateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.AckDateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.AckDateDateEdit.Size = New System.Drawing.Size(137, 28)
        Me.AckDateDateEdit.TabIndex = 231
        '
        'QRCodeMemoEdit
        '
        Me.QRCodeMemoEdit.Location = New System.Drawing.Point(83, 288)
        Me.QRCodeMemoEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.QRCodeMemoEdit.Name = "QRCodeMemoEdit"
        Me.QRCodeMemoEdit.Size = New System.Drawing.Size(1783, 162)
        Me.QRCodeMemoEdit.TabIndex = 243
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(454, 471)
        Me.LabelControl59.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(70, 22)
        Me.LabelControl59.TabIndex = 232
        Me.LabelControl59.Text = "Ack Date"
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(9, 290)
        Me.LabelControl58.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(76, 22)
        Me.LabelControl58.TabIndex = 241
        Me.LabelControl58.Text = "QR Code:"
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(20, 471)
        Me.LabelControl60.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(56, 22)
        Me.LabelControl60.TabIndex = 233
        Me.LabelControl60.Text = "Ack No"
        '
        'TxtBoxResp
        '
        Me.TxtBoxResp.Location = New System.Drawing.Point(83, 250)
        Me.TxtBoxResp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxResp.Name = "TxtBoxResp"
        Me.TxtBoxResp.Size = New System.Drawing.Size(1792, 28)
        Me.TxtBoxResp.TabIndex = 240
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(1083, 202)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MaskedTextBox1.Size = New System.Drawing.Size(793, 28)
        Me.MaskedTextBox1.TabIndex = 236
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(1051, 207)
        Me.LabelControl53.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(20, 22)
        Me.LabelControl53.TabIndex = 237
        Me.LabelControl53.Text = "url"
        '
        'txtIRN
        '
        Me.txtIRN.Location = New System.Drawing.Point(83, 202)
        Me.txtIRN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIRN.Name = "txtIRN"
        Me.txtIRN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRN.Size = New System.Drawing.Size(960, 28)
        Me.txtIRN.TabIndex = 234
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(9, 211)
        Me.LabelControl52.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(64, 22)
        Me.LabelControl52.TabIndex = 235
        Me.LabelControl52.Text = "IRN No:"
        '
        'GenerateEWBSimpleButton
        '
        Me.GenerateEWBSimpleButton.ImageOptions.Image = CType(resources.GetObject("GenerateEWBSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.GenerateEWBSimpleButton.Location = New System.Drawing.Point(346, 121)
        Me.GenerateEWBSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GenerateEWBSimpleButton.Name = "GenerateEWBSimpleButton"
        Me.GenerateEWBSimpleButton.Size = New System.Drawing.Size(243, 51)
        Me.GenerateEWBSimpleButton.TabIndex = 242
        Me.GenerateEWBSimpleButton.Text = "&Generate E-Way"
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(140, 128)
        Me.LabelControl57.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(92, 22)
        Me.LabelControl57.TabIndex = 229
        Me.LabelControl57.Text = "Auth Token"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(253, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 22)
        Me.Label1.TabIndex = 228
        Me.Label1.Text = "Label1"
        '
        'TxtBoxError
        '
        Me.TxtBoxError.Location = New System.Drawing.Point(1474, 79)
        Me.TxtBoxError.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxError.Name = "TxtBoxError"
        Me.TxtBoxError.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBoxError.Size = New System.Drawing.Size(382, 28)
        Me.TxtBoxError.TabIndex = 238
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(1337, 84)
        Me.LabelControl56.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(125, 22)
        Me.LabelControl56.TabIndex = 239
        Me.LabelControl56.Text = "E-Invoice Error/"
        '
        'Frm_EWayBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1946, 650)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_EWayBill"
        Me.Text = "Category"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlMain.ResumeLayout(False)
        Me.PanelCtrlMain.PerformLayout()
        CType(Me.AckNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AckDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AckDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRCodeMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBoxResp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaskedTextBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIRN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBoxError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
    Friend WithEvents AckNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AckDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents QRCodeMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtBoxResp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MaskedTextBox1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIRN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GenerateEWBSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtBoxError As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
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
