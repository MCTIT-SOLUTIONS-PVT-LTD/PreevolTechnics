Public Class FrmWaiting
    Sub New()
        InitializeComponent()
        Me.progressPanel1.AutoHeight = True
    End Sub

#Disable Warning BC30284 ' sub 'SetCaption' cannot be declared 'Overrides' because it does not override a sub in a base class.
    Public Overrides Sub SetCaption(ByVal caption As String)
#Enable Warning BC30284 ' sub 'SetCaption' cannot be declared 'Overrides' because it does not override a sub in a base class.
        MyBase.SetCaption(caption)
        Me.progressPanel1.Caption = caption
    End Sub

#Disable Warning BC30284 ' sub 'SetDescription' cannot be declared 'Overrides' because it does not override a sub in a base class.
    Public Overrides Sub SetDescription(ByVal description As String)
#Enable Warning BC30284 ' sub 'SetDescription' cannot be declared 'Overrides' because it does not override a sub in a base class.
        MyBase.SetDescription(description)
        Me.progressPanel1.Description = description
    End Sub

#Disable Warning BC30284 ' sub 'ProcessCommand' cannot be declared 'Overrides' because it does not override a sub in a base class.
    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
#Enable Warning BC30284 ' sub 'ProcessCommand' cannot be declared 'Overrides' because it does not override a sub in a base class.
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum WaitFormCommand
        SomeCommandId
    End Enum
End Class
