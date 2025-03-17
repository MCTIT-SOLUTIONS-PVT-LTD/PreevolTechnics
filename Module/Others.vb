#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraEditors
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraEditors' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports System.Data.OleDb
#Disable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraBars' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.
Imports DevExpress.XtraBars
#Enable Warning BC40056 ' Namespace or type specified in the Imports 'DevExpress.XtraBars' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.

Module Others

    Public access As String = "access"
    Function TruckStrCut(Str As String) As String
        Try
            Dim TempDigit As String = Right(Str, 4)

            Dim TempSeries As String = Left(Str, Str.Length - 4)

            Return TempDigit + ":" + TempSeries
        Catch ex As Exception
            ' ErtOccur(ex)
        End Try
        Return True
    End Function

    Sub NextInvoiceNo()
        Try
            Dim CMDGet As New OleDbCommand("SELECT InvoiceNo FROM S_InvoiceNo WHERE ID=1", ConStr)
            CnnOpen() : Dim Str As String = CStr(CMDGet.ExecuteScalar()) : CnnClose()
            Dim RStr As String = StrReverse(Str)
            Dim IntID As Integer = InStr(RStr, "/", CompareMethod.Text)
            Dim Temp As String = Left(RStr, IntID - 1)
            Dim Temp2 As String = Right(RStr, RStr.Length - IntID + 1)
            Temp = StrReverse(Temp) + 1
            If Temp.Length = 1 Then
                Temp = "000" + Temp
            ElseIf Temp.Length = 2 Then
                Temp = "00" + Temp
            ElseIf Temp.Length = 3 Then
                Temp = "0" + Temp
            End If
            Dim CMDSet As New OleDbCommand("UPDATE S_InvoiceNo SET InvoiceNo='" & (StrReverse(Temp2) + Temp) & "' WHERE ID=1", ConStr)
            CnnOpen() : CMDSet.ExecuteNonQuery() : CnnClose()
        Catch ex As Exception
            ' ErtOccur(ex)
        End Try
    End Sub

    Public Function User_Validation(User As Integer) As Boolean
        'If UserType = True Then
        '    Return True
        'Else
        '    If UserID = User Then
        '        Return True
        '    Else
        '        XtraMessageBox.Show("You don't have permission.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Return False
        '    End If
        'End If
    End Function

#Disable Warning BC30002 ' Type 'BarManager' is not defined.
    Sub AutoChangeIconColor(Frm As XtraForm, Bar As BarManager)
#Disable Warning BC30002 ' Type 'XtraForm' is not defined.
#Enable Warning BC30002 ' Type 'BarManager' is not defined.
        Try
#Enable Warning BC30002 ' Type 'XtraForm' is not defined.
            For Each Control As BarButtonItem In Bar.Items
                Control.AllowGlyphSkinning = True
            Next
        Catch ex As Exception
            ' ErtOccur(ex)
        End Try
    End Sub


    Public Function CutString(ByVal Str As String) As String
        Try
            Dim RStr As String = StrReverse(Str)
            Dim IntID As Integer = InStr(RStr, "\", CompareMethod.Text)
            Dim Temp As String = Right(RStr, RStr.Length - IntID)
            Dim Temp2 As String = Right(RStr, RStr.Length - IntID + 1)
            Temp = StrReverse(Temp)
            Return Temp
        Catch ex As Exception
            'ErtOccur(ex)
        End Try
    End Function

#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
    Public Function GetLastDayOfMonth(Month, Year) As Date
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        GetLastDayOfMonth = DateSerial(Year, Month + 1, 0)
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
    End Function

#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
    Public Function GetFirstDayOfMonth(Month, Year) As Date
#Disable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
        GetFirstDayOfMonth = DateSerial(Year, Month, 1)
#Enable Warning BC42020 ' Variable declaration without an 'As' clause; type of Object assumed.
    End Function

End Module
