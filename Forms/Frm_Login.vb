Imports DevExpress.XtraEditors
Imports System.Data.OleDb
Imports System.ComponentModel

'Imports ELCF
Public Class Frm_Login

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            UserNameTextEdit.Focus()
            themesGroupCtrl(LoginGroupControl)
            InitLookup()
            CheckCompany()
        Catch ole As OleDbException
            Dim frmCon As New Frm_Connection
            frmCon.ShowDialog()
            frmCon.BringToFront()
            If frmCon.DialogResult = DialogResult.OK Or frmCon.DialogResult = DialogResult.Cancel Then
                Application.Exit()
            End If
            'Catch ex As Exception
            '    Dim d = XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    If d = 1 Then
            '        Application.Exit()
            '    End If
            'End Try
        Catch ex1 As TypeInitializationException
            MessageBox.Show(ex1.InnerException.Message)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub InitLookup()
        SetGridCommboBox("SELECT DISTINCT Name FROM Company", "Company", CompanyComboBoxEdit)
    End Sub

    Sub CheckCompany()
        Dim DACHK As New OleDbDataAdapter("Select CompanyID from Company", ConStr)
        Dim DTCHK As New DataTable
        DACHK.Fill(DTCHK)

        If DTCHK.Rows.Count > 0 Then
            CreateCompanySimpleButton.Visible = False
        Else
            CreateCompanySimpleButton.Visible = True
        End If
    End Sub
    Function Validation() As Boolean
        If UserNameTextEdit.EditValue Is DBNull.Value Then
            UserNameTextEdit.Focus()
            Return False
        ElseIf PasswordTextEdit.EditValue Is DBNull.Value Then
            PasswordTextEdit.Focus()
            Return False
        ElseIf CompanyComboBoxEdit.Text = "--Select Company--" Then
            CompanyComboBoxEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ExitSimpleButton_Click(sender As Object, e As EventArgs) Handles ExitSimpleButton.Click
        Application.Exit()
    End Sub

    Private Sub LoginSimpleButton_Click(sender As Object, e As EventArgs) Handles LoginSimpleButton.Click
        If Validation() Then
            Dim CMD As New OleDbCommand("SELECT UserID FROM LoginUser Where UserName='" + UserNameTextEdit.Text + "' AND Pwd='" + PasswordTextEdit.Text + "'", ConStr)
            CnnOpen() : Dim Varify As Integer = CMD.ExecuteScalar : CnnClose()
            If Varify <> 0 Then
                Dim NewCmd1 As New OleDbCommand("SELECT IsAdmin FROM LoginUser Where UserName='" + UserNameTextEdit.Text + "' AND Pwd='" + PasswordTextEdit.Text + "'", ConStr)
                CnnOpen() : Dim chk As Boolean = NewCmd1.ExecuteScalar : CnnClose()

                If chk = True Then
                    PubIsAdmin = True
                Else
                    PubIsAdmin = False
                End If
                PubUserID = Varify
                CurrentUserName = UserNameTextEdit.Text
                PubCompanyName = CompanyComboBoxEdit.Text
                Start_Waiting()

                Frm_Main.Text = PubCompanyName
                Frm_Main.WindowState = FormWindowState.Maximized
                Frm_Main.Show()
                Me.Close()

                End_Waiting()
            Else
                XtraMessageBox.Show("Username or Password Invalid.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserNameTextEdit.EditValue = DBNull.Value
                PasswordTextEdit.EditValue = DBNull.Value
                UserNameTextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub CreateCompanySimpleButton_Click(sender As Object, e As EventArgs) Handles CreateCompanySimpleButton.Click
        Dim CMP As New Frm_NewFirstCompany
        CMP.StartPosition = FormStartPosition.CenterScreen
        CMP.ShowDialog()
        If CMP.DialogResult = DialogResult.OK Then
            InitLookup()
            CheckCompany()
        End If
    End Sub

    Private Sub ConnectionSimpleButton_Click(sender As Object, e As EventArgs) Handles ConnectionSimpleButton.Click
        Dim frmCon As New Frm_Connection
        frmCon.ShowDialog()
    End Sub
End Class