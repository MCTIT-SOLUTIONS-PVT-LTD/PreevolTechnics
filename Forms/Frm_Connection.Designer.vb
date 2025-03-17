<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Connection
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Connection))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ConnectionStringTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OKSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CurrentPathTextEdit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.ConnectionStringTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentPathTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "New Path"
        '
        'ConnectionStringTextEdit
        '
        Me.ConnectionStringTextEdit.Location = New System.Drawing.Point(78, 57)
        Me.ConnectionStringTextEdit.Name = "ConnectionStringTextEdit"
        Me.ConnectionStringTextEdit.Size = New System.Drawing.Size(441, 20)
        Me.ConnectionStringTextEdit.TabIndex = 0
        '
        'OKSimpleButton
        '
        Me.OKSimpleButton.Image = CType(resources.GetObject("OKSimpleButton.Image"), System.Drawing.Image)
        Me.OKSimpleButton.Location = New System.Drawing.Point(78, 83)
        Me.OKSimpleButton.Name = "OKSimpleButton"
        Me.OKSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.OKSimpleButton.TabIndex = 1
        Me.OKSimpleButton.Text = "OK"
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.Image = CType(resources.GetObject("CancelSimpleButton.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(159, 83)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.CancelSimpleButton.TabIndex = 2
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(78, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(373, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "e.g. E:\Preevol Technics Software\Preevol Technics\dbPreevolTechnics.accdb"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Current Path"
        '
        'CurrentPathTextEdit
        '
        Me.CurrentPathTextEdit.Location = New System.Drawing.Point(78, 12)
        Me.CurrentPathTextEdit.Name = "CurrentPathTextEdit"
        Me.CurrentPathTextEdit.Properties.ReadOnly = True
        Me.CurrentPathTextEdit.Size = New System.Drawing.Size(441, 20)
        Me.CurrentPathTextEdit.TabIndex = 5
        Me.CurrentPathTextEdit.TabStop = False
        '
        'Frm_Connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 120)
        Me.Controls.Add(Me.CurrentPathTextEdit)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CancelSimpleButton)
        Me.Controls.Add(Me.OKSimpleButton)
        Me.Controls.Add(Me.ConnectionStringTextEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Connection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        CType(Me.ConnectionStringTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentPathTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConnectionStringTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OKSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CurrentPathTextEdit As DevExpress.XtraEditors.TextEdit
End Class
