Imports DevExpress.XtraSplashScreen

Module Waiting_Module
    Sub Start_Waiting()
        Try
            End_Waiting()
            Dim f As New FrmWaiting
            SplashScreenManager.ShowForm(f, GetType(PreevolTechnics.FrmWaiting), True, True)
        Catch ex As Exception

        End Try
      
    End Sub
    Sub End_Waiting()
        Try
            SplashScreenManager.CloseForm()
        Catch ex As Exception

        End Try


    End Sub
End Module
