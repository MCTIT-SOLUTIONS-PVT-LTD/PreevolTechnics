Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Configuration
Imports EASendMail
Imports System.Net
'Imports ELCF
Public Class Frm_Message
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()

        AddNew()

        txtTo.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Sub SetDataTable()
        DS.Tables.Add("Category")
        With DS.Tables("Category").Columns
            .Add("CategoryID", GetType(Integer))
            .Add("CategoryName", GetType(String))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("Category").Columns("CategoryID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
    End Sub

    Sub SetQuery()
        DA.SelectCommand = New OleDbCommand("Select CategoryID,CategoryName,Company From Category Where CategoryID=@CategoryID", ConStr)
        DA.SelectCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")

        DA.InsertCommand = New OleDbCommand("Insert Into Category (CategoryName,Company) Values (@CategoryName,@Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@CategoryName", OleDbType.VarChar, 50, "CategoryName")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update Category Set CategoryName=@CategoryName Where CategoryID=@CategoryID", ConStr)
        DA.UpdateCommand.Parameters.Add("@CategoryName", OleDbType.VarChar, 50, "CategoryName")
        DA.UpdateCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")

        DA.DeleteCommand = New OleDbCommand("Delete From Category Where CategoryID=@CategoryID", ConStr)
        DA.DeleteCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")
    End Sub

    Sub SetBinding()
        BS.DataSource = DS
        BS.DataMember = "Category"
        txtTo.DataBindings.Add(New Binding("EditValue", BS, "CategoryName"))
    End Sub

    Sub AddNew()
        BS.AddNew()
        txtTo.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        txtTo.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From Category Where Company ='" + PubCompanyName + "'", "CategoryID")
        If ID > 0 Then
            Try
                DS.Tables("Category").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@CategoryID").Value = ID
            DA.Fill(DS, "Category")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("Category"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If txtTo.EditValue Is DBNull.Value Then
            txtTo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        'Using mm As New MailMessage(ConfigurationManager.AppSettings("FromEmail"), txtTo.Text)
        '    mm.Subject = txtSubject.Text
        '    mm.Body = BodyMemoEdit.Text
        '    For Each filePath As String In OpenFileDialog1.FileNames
        '        If File.Exists(filePath) Then
        '            Dim fileName As String = Path.GetFileName(filePath)
        '            mm.Attachments.Add(New Net.Mail.Attachment(filePath))
        '        End If
        '    Next
        '    mm.IsBodyHtml = False
        '    Dim smtp As New Net.Mail.SmtpClient()
        '    smtp.Host = ConfigurationManager.AppSettings("Host")
        '    smtp.EnableSsl = True
        '    Dim NetworkCred As New NetworkCredential(ConfigurationManager.AppSettings("Username"), ConfigurationManager.AppSettings("Password"))
        '    smtp.UseDefaultCredentials = True
        '    smtp.Credentials = NetworkCred
        '    smtp.Port = Integer.Parse(ConfigurationManager.AppSettings("Port"))
        '    Try
        '        MsgBox("Sending Email......")
        '        smtp.Send(mm)
        '        MessageBox.Show("Email sent.", "Message")
        '        System.Threading.Thread.Sleep(3000)
        '    Catch error_t As Exception
        '        MsgBox(error_t.ToString)
        '    End Try
        'End Using
        'Try
        '    Dim From As Mail.MailAddress = New Mail.MailAddress("preevoltechnics35@yahoo.in")
        '    Dim Totxt As Mail.MailAddress = New Mail.MailAddress("mpanchal@miraclecloud-technology.com")
        '    Dim Message As Mail.MailMessage = New Mail.MailMessage(From, Totxt)

        '    Message.Subject = "test"
        '    Message.Body = "Test Email"
        '    'Message.Attachments.Add(New Mail.Attachment(OpenFileDialog1.FileName.ToString))
        '    Dim Str As String = "smtp.mail.yahoo.com"
        '    Dim client = New Mail.SmtpClient(Str)
        '    'client.Port = 465
        '    client.EnableSsl = False
        '    client.Credentials = New System.Net.NetworkCredential("preevoltechnics35@yahoo.In", "pt$35pt$35")
        '    client.Send(Message)
        '    MsgBox("Send Email Successfully")
        '    Threading.Thread.Sleep(3000)
        'Catch ep As Exception
        '    'MsgBox("failed to send email with the following error:")
        '    MsgBox(ep.ToString)
        'End Try
        Try
            Dim oMail As New SmtpMail("TryIt")
            oMail.From = "preevoltechnics35@yahoo.in"
            oMail.To = "mpanchal@miraclecloud-technology.com"
            oMail.Subject = "Test"
            oMail.TextBody = "Test Email"
            Dim oServer As New SmtpServer("smtp.mail.yahoo.com")
            oServer.User = "preevoltechnics35@yahoo.in"
            oServer.Password = "vzbofznyxzlvltxt"
            oServer.Port = 465
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto
            'Console.WriteLine("start to send email over SSL ...")
            Dim oSmtp As New SmtpClient()
            oSmtp.SendMail(oServer, oMail)
            MsgBox("email was sent successfully!")
            Threading.Thread.Sleep(3000)
        Catch ep As Exception
            'MsgBox("failed to send email with the following error:")
            MsgBox(ep.Message)
        End Try
    End Sub
    'Using mm As New Net.Mail.MailMessage(emailTextEdit.Text.Trim(), txtTo.Text.Trim())
    '    mm.Subject = txtSubject.Text
    '    mm.Body = BodyMemoEdit.Text
    '    For Each filePath As String In OpenFileDialog1.FileNames
    '        If File.Exists(filePath) Then
    '            Dim fileName As String = Path.GetFileName(filePath)
    '            mm.Attachments.Add(New Net.Mail.Attachment(filePath))
    '        End If
    '    Next
    '    mm.IsBodyHtml = False
    '    Dim smtp As New Net.Mail.SmtpClient()
    '    smtp.Host = "smtp.gmail.com"
    '    smtp.EnableSsl = True
    '    Dim NetworkCred As New NetworkCredential(emailTextEdit.Text.Trim(), passwordTextEdit.Text.Trim())
    '    smtp.UseDefaultCredentials = True
    '    smtp.Credentials = NetworkCred
    '    smtp.Port = 587
    '    Try
    '        smtp.Send(mm)
    '        MessageBox.Show("Email sent.", "Message")
    '    Catch error_t As Exception
    '        MsgBox(error_t.ToString)
    '    End Try
    'End Using
    'Try
    '    Dim Smtp_Server As New SmtpClient
    '    Dim e_mail As New MailMessage()
    '    Smtp_Server.UseDefaultCredentials = False
    '    Smtp_Server.Credentials = New NetworkCredential("xxx", "xxx")
    '    Smtp_Server.Port = "587"
    '    Smtp_Server.EnableSsl = False
    '    Smtp_Server.Host = "smtp.gmail.com"
    '    Smtp_Server.DeliveryMethod = SmtpDeliveryMethod.Network

    '    e_mail = New MailMessage()
    '    e_mail.From = New MailAddress("mittal.mistry89@gmail.com")
    '    e_mail.To.Add(txtTo.Text)
    '    e_mail.Subject = txtSubject.Text
    '    e_mail.IsBodyHtml = True
    '    e_mail.Body = BodyMemoEdit.Text

    '    Smtp_Server.Send(e_mail)
    '    Smtp_Server.Dispose()

    '    MsgBox("Mail Sent")

    'Catch error_t As Exception
    '    MsgBox(error_t.ToString)
    'End Try
    'Try
    '    Dim oMail As New EASendMail.SmtpMail("localhost 587")

    '    ' Set sender email address, please change it to yours
    '    oMail.From = "mittal.mistry89@gmail.com"
    '    ' Set recipient email address, please change it to yours
    '    oMail.To = "mittal.mistry89@gmail.com"

    '    ' Set email subject
    '    oMail.Subject = "test email from VB.NET project"
    '    ' Set email body
    '    oMail.TextBody = "this is a test email sent from VB.NET project, do not reply"

    '    ' Your SMTP server address
    '    Dim oServer As New SmtpServer("smtp.gmail.com")

    '    ' User and password for ESMTP authentication
    '    oServer.User = "mittal.mistry89@gmail.com"
    '    oServer.Password = "Private@1989"

    '    ' Most mordern SMTP servers require SSL/TLS connection now.
    '    ' ConnectTryTLS means if server supports SSL/TLS, SSL/TLS will be used automatically.
    '    oServer.ConnectType = SmtpConnectType.ConnectTryTLS

    '    ' If your SMTP server uses 587 port
    '    oServer.Port = 587


    '    ' If your SMTP server requires SSL/TLS connection on 25/587/465 port
    '    ' oServer.Port = 25 ' 25 or 587 or 465
    '    ' oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

    '    Console.WriteLine("start to send email ...")

    '    Dim oSmtp As New EASendMail.SmtpClient()
    '    oSmtp.SendMail(oServer, oMail)

    '    MsgBox("email was sent successfully!")
    'Catch ep As Exception
    '    'MsgBox("failed to send email with the following error:")
    '    MsgBox(ep.Message)
    'End Try
    ''''''''''''''''''''''''
    'Dim oMail As New EASendMail.SmtpMail("TryIt")
    'Dim oSmtp As New EASendMail.SmtpClient()
    'oMail.From = "mittal.mistry89@gmail.com"
    'oMail.To = New AddressCollection(txtTo.Text)
    'oMail.Subject = txtSubject.Text
    ''If html.CheckAlign = True Then
    ''    oMail.HtmlBody = bodytxt.Text
    ''Else
    ''    oMail.TextBody = bodytxt.Text
    ''End If
    'oMail.TextBody = BodyMemoEdit.Text
    'Dim oServer As New SmtpServer("smtp.gmail.com")
    'oServer.Port = 587
    'oServer.ConnectType = SmtpConnectType.ConnectSSLAuto
    'oServer.User = "mittal.mistry89@gmail.com"
    'oServer.Password = "Private@1989"
    ''Dim r As Integer
    ''If ListBox1.Items.Count <= 0 Then
    ''Else
    ''    oMail.AddAttachment(ListBox1.Items(r))
    ''End If
    ''oSmtp.LogFileName = Application.StartupPath & "\maillog.log"
    'Try
    '    oSmtp.SendMail(oServer, oMail)
    '    MsgBox("Mail sent !")
    'Catch ex As Exception
    '    MsgBox(ex.Message)
    ''End Try
    'Using smtp As New EASendMail.SmtpClient("smtp.gmail.com")

    '    ' Connect and sign to the SMTP server.
    '    smtp.Connect()
    '    smtp.Authenticate("<USERNAME>", "<PASSWORD>")

    '    ' Create and send a new email.
    '    Dim message As New MailMessage()
    '    ' ...
    '    smtp.SendMessage(message)
    'End Using


    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CategoryNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTo.Validating
        If Not txtTo.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(CategoryID) FROM Category WHERE CategoryName=@CategoryName AND CategoryID<>@CategoryID", ConStr)
                CMD.Parameters.AddWithValue("@CategoryName", txtTo.EditValue)
                CMD.Parameters.AddWithValue("@CategoryID", IIf(BS.Current!CategoryID Is DBNull.Value, -1, BS.Current!CategoryID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTo.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each filePath As String In OpenFileDialog1.FileNames
            If File.Exists(filePath) Then
                Dim fileName As String = Path.GetFileName(filePath)
                lblAttachment.Text += fileName + Environment.NewLine
            End If
        Next
    End Sub

    Private Sub lblAttachment_Click(sender As Object, e As EventArgs) Handles lblAttachment.Click

    End Sub
End Class