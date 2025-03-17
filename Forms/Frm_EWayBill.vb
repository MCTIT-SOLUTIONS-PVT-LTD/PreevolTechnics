Imports DevExpress.XtraEditors
Imports Newtonsoft.Json
Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO
'Imports ELCF
Public Class Frm_EWayBill
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'CategoryNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        'themes(PanelCtrl)
    End Sub


    Private Sub updateJson1()
        Try
            Dim EWayBillJson As String
            EWayBillJson = ""

            Dim EWayBill As New EWayBillJsonModule.EWayBill
            EWayBill.Irn = "d384fd2defc91b391a959f54db9d0967e4593252301012da235a423053b20efe"
            EWayBill.Distance = 0
            EWayBill.TransMode = "1"
            EWayBill.TransId = "12AWGPV7107B1Z1"
            EWayBill.TransName = "Maruti transport"
            EWayBill.TransDocDt = "07/10/2022"
            EWayBill.TransDocNo = "Tra/Doc/01"
            EWayBill.VehNo = "KA12ER1234"
            EWayBill.VehType = "R"
            Dim ExpShipDtl As EWayBillJsonModule.Address = New EWayBillJsonModule.Address With {
                .Addr1 = "7th block, kuvempu layout",
                .Addr2 = "kuvempu layout",
                .Loc = "Banagalore",
                .Pin = 562160,
                .Stcd = "29"
            }
            EWayBill.ExpShipDtls = ExpShipDtl
            Dim DispDtl As EWayBillJsonModule.Address = New EWayBillJsonModule.Address With {
                .Nm = "TestABC company",
                .Addr1 = "7th block, kuvempu layout",
                .Addr2 = "kuvempu layout",
                .Loc = "Banagalore",
                .Pin = 562160,
                .Stcd = "29"
            }
            EWayBill.DispDtls = DispDtl

            EWayBillJson = JsonConvert.SerializeObject(EWayBill, Newtonsoft.Json.Formatting.Indented)
            TxtBoxResp.Text = EWayBillJson
            Dim FilePath = ConfigurationManager.AppSettings("AppPath") + "\GenEWay.txt"
            Dim InvPaylod = TxtBoxResp.Text
            File.WriteAllText(FilePath, InvPaylod)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub GenerateEWBSimpleButton_Click(sender As Object, e As EventArgs) Handles GenerateEWBSimpleButton.Click

        updateJson1()
    End Sub
End Class