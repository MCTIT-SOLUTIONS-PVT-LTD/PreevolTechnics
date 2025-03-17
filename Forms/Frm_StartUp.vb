Public Class Frm_StartUp
    Dim dbl As New Double
    Sub New()
        InitializeComponent()

    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''TODO: This line of code loads data into the 'DS_Invoice2.DT_Invoice' table. You can move, or remove it, as needed.
        'Me.DT_InvoiceTableAdapter.Fill(Me.DS_Invoice2.DT_Invoice)
        ''TODO: This line of code loads data into the 'DS_ServiceInvoice1.ServiceInvoice' table. You can move, or remove it, as needed.
        'Me.ServiceInvoiceTableAdapter.Fill(Me.DS_ServiceInvoice1.ServiceInvoice)
        Timer1.Interval = 175
        Timer1.Start()
        Frm_Login.WindowState = FormWindowState.Minimized
        Frm_Login.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dbl = dbl + 0.01
        If dbl = 0.16 Then
            Timer1.Stop()
            Frm_Login.WindowState = FormWindowState.Normal
            Frm_Login.StartPosition = FormStartPosition.CenterScreen
            'Me.Close()
            Me.Visible = False

        End If
    End Sub
End Class
