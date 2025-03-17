Imports DevExpress.XtraEditors
Imports System.Data.OleDb
Imports System.ComponentModel
'Imports ELCF
Public Class Frm_SelectCompany
    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CompanyComboBoxEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
        InitLookup()
    End Sub

    Sub InitLookup()
        SetGridCommboBox("SELECT DISTINCT Name FROM Company", "Company", CompanyComboBoxEdit)
    End Sub

    Function Validation()
        If CompanyComboBoxEdit.Text = "--Select Company--" Then
            CompanyComboBoxEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub OKSimpleButton_Click(sender As Object, e As EventArgs) Handles OKSimpleButton.Click
        If Validation() Then
            PubCompanyName = CompanyComboBoxEdit.Text
            Frm_Main.Text = PubCompanyName
            Frm_Main.WindowState = FormWindowState.Maximized
            Frm_Main.Show()
            Me.Close()
        End If
    End Sub
End Class