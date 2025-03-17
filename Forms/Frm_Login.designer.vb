<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.LoginGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.ConnectionSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CreateCompanySimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CompanyComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ExitSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LoginSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.lblHint = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UserNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.LoginGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginGroupControl.SuspendLayout()
        CType(Me.CompanyComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginGroupControl
        '
        Me.LoginGroupControl.Controls.Add(Me.ConnectionSimpleButton)
        Me.LoginGroupControl.Controls.Add(Me.CreateCompanySimpleButton)
        Me.LoginGroupControl.Controls.Add(Me.CompanyComboBoxEdit)
        Me.LoginGroupControl.Controls.Add(Me.LabelControl2)
        Me.LoginGroupControl.Controls.Add(Me.ExitSimpleButton)
        Me.LoginGroupControl.Controls.Add(Me.LoginSimpleButton)
        Me.LoginGroupControl.Controls.Add(Me.PictureEdit1)
        Me.LoginGroupControl.Controls.Add(Me.lblHint)
        Me.LoginGroupControl.Controls.Add(Me.LabelControl1)
        Me.LoginGroupControl.Controls.Add(Me.PasswordTextEdit)
        Me.LoginGroupControl.Controls.Add(Me.UserNameTextEdit)
        Me.LoginGroupControl.Controls.Add(Me.LabelControl3)
        Me.LoginGroupControl.Location = New System.Drawing.Point(12, 12)
        Me.LoginGroupControl.Name = "LoginGroupControl"
        Me.LoginGroupControl.Size = New System.Drawing.Size(411, 189)
        Me.LoginGroupControl.TabIndex = 6
        Me.LoginGroupControl.Text = "Login"
        '
        'ConnectionSimpleButton
        '
        Me.ConnectionSimpleButton.Image = CType(resources.GetObject("ConnectionSimpleButton.Image"), System.Drawing.Image)
        Me.ConnectionSimpleButton.Location = New System.Drawing.Point(376, 23)
        Me.ConnectionSimpleButton.Name = "ConnectionSimpleButton"
        Me.ConnectionSimpleButton.Size = New System.Drawing.Size(28, 14)
        Me.ConnectionSimpleButton.TabIndex = 7
        Me.ConnectionSimpleButton.TabStop = False
        '
        'CreateCompanySimpleButton
        '
        Me.CreateCompanySimpleButton.Location = New System.Drawing.Point(307, 159)
        Me.CreateCompanySimpleButton.Name = "CreateCompanySimpleButton"
        Me.CreateCompanySimpleButton.Size = New System.Drawing.Size(97, 23)
        Me.CreateCompanySimpleButton.TabIndex = 6
        Me.CreateCompanySimpleButton.Text = "&Create Company"
        '
        'CompanyComboBoxEdit
        '
        Me.CompanyComboBoxEdit.Location = New System.Drawing.Point(148, 133)
        Me.CompanyComboBoxEdit.Name = "CompanyComboBoxEdit"
        Me.CompanyComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyComboBoxEdit.Properties.DropDownRows = 3
        Me.CompanyComboBoxEdit.Properties.NullText = "--Select Company--"
        Me.CompanyComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CompanyComboBoxEdit.Size = New System.Drawing.Size(256, 20)
        Me.CompanyComboBoxEdit.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(149, 114)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Company"
        '
        'ExitSimpleButton
        '
        Me.ExitSimpleButton.Location = New System.Drawing.Point(228, 159)
        Me.ExitSimpleButton.Name = "ExitSimpleButton"
        Me.ExitSimpleButton.Size = New System.Drawing.Size(73, 23)
        Me.ExitSimpleButton.TabIndex = 5
        Me.ExitSimpleButton.Text = "&Exit"
        '
        'LoginSimpleButton
        '
        Me.LoginSimpleButton.Location = New System.Drawing.Point(149, 159)
        Me.LoginSimpleButton.Name = "LoginSimpleButton"
        Me.LoginSimpleButton.Size = New System.Drawing.Size(73, 23)
        Me.LoginSimpleButton.TabIndex = 4
        Me.LoginSimpleButton.Text = "&Login"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.PreevolTechnics.My.Resources.Resources.administrator_icon
        Me.PictureEdit1.Location = New System.Drawing.Point(5, 24)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopRight
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(137, 158)
        Me.PictureEdit1.TabIndex = 0
        '
        'lblHint
        '
        Me.lblHint.Location = New System.Drawing.Point(148, 132)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(0, 13)
        Me.lblHint.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(148, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "User Name"
        '
        'PasswordTextEdit
        '
        Me.PasswordTextEdit.Location = New System.Drawing.Point(148, 88)
        Me.PasswordTextEdit.Name = "PasswordTextEdit"
        Me.PasswordTextEdit.Properties.UseSystemPasswordChar = True
        Me.PasswordTextEdit.Size = New System.Drawing.Size(256, 20)
        Me.PasswordTextEdit.TabIndex = 2
        '
        'UserNameTextEdit
        '
        Me.UserNameTextEdit.Location = New System.Drawing.Point(148, 43)
        Me.UserNameTextEdit.Name = "UserNameTextEdit"
        Me.UserNameTextEdit.Size = New System.Drawing.Size(256, 20)
        Me.UserNameTextEdit.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(148, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Password"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 213)
        Me.ControlBox = False
        Me.Controls.Add(Me.LoginGroupControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LoginGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginGroupControl.ResumeLayout(False)
        Me.LoginGroupControl.PerformLayout()
        CType(Me.CompanyComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CompanyComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ExitSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LoginSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblHint As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CreateCompanySimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ConnectionSimpleButton As DevExpress.XtraEditors.SimpleButton
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
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
