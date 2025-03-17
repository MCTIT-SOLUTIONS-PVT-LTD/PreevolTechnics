Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI


'For Google API
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Services
Imports Google.Apis.Upload
Imports System.IO
Imports System.Threading
Imports System.Configuration

Public Class Frm_Main
    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Not PubIsAdmin Then
        '    ClientPaymentBarButtonItem.Enabled = False
        '    VendorPaymentBarButtonItem.Enabled = False
        'End If
        'OpenForm(Frm_Dashboard)
        End_Waiting()
    End Sub
    Public Sub OpenForm(Form As XtraForm, Optional Index As Boolean = False, Optional ByRef Index1 As Boolean = False)
        If Index1 = False Then Start_Waiting()
        Form.MdiParent = Me
        If Index = False Then Form.WindowState = FormWindowState.Maximized Else Form.WindowState = FormWindowState.Normal
        Form.Show()
        Form.BringToFront()
    End Sub
    Private Sub PartyBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PartyBarButtonItem.ItemClick
        OpenForm(Frm_Party)
        End_Waiting()
    End Sub
    Private Sub InvoiceBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InvoiceBarButtonItem.ItemClick

        If Frm_Invoice.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_Invoice.Close()
                Frm_SelectInvoiceType.StartPosition = FormStartPosition.CenterParent
                Frm_SelectInvoiceType.ControlBox = True
                Frm_SelectInvoiceType.ShowDialog()
            Else
                Frm_Invoice.Show()
                Frm_Invoice.BringToFront()
            End If
        ElseIf Frm_ServiceInvoice.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_ServiceInvoice.Close()
                Frm_SelectInvoiceType.StartPosition = FormStartPosition.CenterParent
                Frm_SelectInvoiceType.ControlBox = True
                Frm_SelectInvoiceType.ShowDialog()
            Else
                Frm_ServiceInvoice.Show()
                Frm_ServiceInvoice.BringToFront()
            End If
        Else
            Frm_SelectInvoiceType.StartPosition = FormStartPosition.CenterParent
            Frm_SelectInvoiceType.ControlBox = True
            Frm_SelectInvoiceType.ShowDialog()
        End If
        'Frm_SelectInvoiceType.StartPosition = FormStartPosition.CenterParent
        'Frm_SelectInvoiceType.ControlBox = True
        'Frm_SelectInvoiceType.ShowDialog()
    End Sub
    Private Sub Frm_Main_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub
    Private Sub ExitBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBarButtonItem.ItemClick
        'Application.Exit()
        Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the Program?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub
    Private Sub CompanyBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CompanyBarButtonItem.ItemClick
        If Me.MdiChildren.Length <= 0 Then
            Frm_SelectCompany.StartPosition = FormStartPosition.CenterParent
            Frm_SelectCompany.ControlBox = True
            Frm_SelectCompany.ShowDialog()
        Else
            XtraMessageBox.Show("Please Close All Opened Form(s)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub UserBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UserBarButtonItem.ItemClick
        OpenForm(Frm_User)
        With Frm_User
            ' .InitLookup()
        End With
        End_Waiting()
    End Sub
    Private Sub CategoryBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CategoryBarButtonItem.ItemClick
        OpenForm(Frm_Category)
        End_Waiting()
    End Sub
    Private Sub SubCategoryBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SubCategoryBarButtonItem.ItemClick
        OpenForm(Frm_SubCategory)
        With Frm_SubCategory
            .InitLookup()
        End With
        End_Waiting()
    End Sub
    Private Sub ProductBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProductBarButtonItem.ItemClick
        OpenForm(Frm_Product)
        With Frm_Product
            .InitLookup()
        End With
        End_Waiting()
    End Sub
    Private Sub CompanyProfileBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CompanyProfileBarButtonItem.ItemClick
        OpenForm(Frm_Company)
        End_Waiting()
    End Sub
    Private Sub BankDetailsBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BankDetailsBarButtonItem.ItemClick
        OpenForm(Frm_Bank)
        End_Waiting()
    End Sub
    Private Sub VendorBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles VendorBarButtonItem.ItemClick
        OpenForm(Frm_Vendor)
        End_Waiting()
    End Sub
    Private Sub PurchaseOrderBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PurchaseOrderBarButtonItem.ItemClick
        If Frm_PurchaseOrder.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_PurchaseOrder.Close()
                Frm_SelectPOType.StartPosition = FormStartPosition.CenterParent
                Frm_SelectPOType.ControlBox = True
                Frm_SelectPOType.ShowDialog()
            Else
                Frm_PurchaseOrder.Show()
                Frm_PurchaseOrder.BringToFront()
            End If
        Else
            Frm_SelectPOType.StartPosition = FormStartPosition.CenterParent
            Frm_SelectPOType.ControlBox = True
            Frm_SelectPOType.ShowDialog()
        End If
    End Sub
    Private Sub PurchaseProductBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PurchaseProductBarButtonItem.ItemClick
        OpenForm(Frm_POProduct)
        With Frm_POProduct
            .InitLookup()
        End With
        End_Waiting()
    End Sub
    Private Sub WorkOrderBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles WorkOrderBarButtonItem.ItemClick
        If Frm_WorkOrder.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_WorkOrder.Close()
                Frm_SelectWOType.StartPosition = FormStartPosition.CenterParent
                Frm_SelectWOType.ControlBox = True
                Frm_SelectWOType.ShowDialog()
            Else
                Frm_WorkOrder.Show()
                Frm_WorkOrder.BringToFront()
            End If
        Else
            Frm_SelectWOType.StartPosition = FormStartPosition.CenterParent
            Frm_SelectWOType.ControlBox = True
            Frm_SelectWOType.ShowDialog()
        End If
    End Sub
    Private Sub ProInvoiceBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProInvoiceBarButtonItem.ItemClick
        If Frm_ProformaInvoiceNew.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_ProformaInvoiceNew.Close()
                Frm_SelectProformaInvoiceType.StartPosition = FormStartPosition.CenterParent
                Frm_SelectProformaInvoiceType.ControlBox = True
                Frm_SelectProformaInvoiceType.ShowDialog()
            Else
                Frm_ProformaInvoiceNew.Show()
                Frm_ProformaInvoiceNew.BringToFront()
            End If
            'ElseIf Frm_ServiceInvoice.Visible Then
            '    Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            '    If result = DialogResult.Yes Then
            '        Frm_ServiceInvoice.Close()
            '        Frm_SelectProformaInvoiceType.StartPosition = FormStartPosition.CenterParent
            '        Frm_SelectProformaInvoiceType.ControlBox = True
            '        Frm_SelectProformaInvoiceType.ShowDialog()
            '    Else
            '        Frm_ServiceInvoice.Show()
            '    End If
        Else
            Frm_SelectProformaInvoiceType.StartPosition = FormStartPosition.CenterParent
            Frm_SelectProformaInvoiceType.ControlBox = True
            Frm_SelectProformaInvoiceType.ShowDialog()
        End If
    End Sub
    Private Sub SalesReportBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SalesReportBarButtonItem.ItemClick
        If Frm_SalesReport.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_SalesReport.Close()
                Frm_SelectInvoiceTypeForReport.StartPosition = FormStartPosition.CenterParent
                Frm_SelectInvoiceTypeForReport.ControlBox = True
                Frm_SelectInvoiceTypeForReport.ShowDialog()
            Else
                Frm_SalesReport.Show()
                Frm_SalesReport.BringToFront()
            End If
        ElseIf Frm_ServiceReportNew.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_ServiceReportNew.Close()
                Frm_SelectInvoiceTypeForReport.StartPosition = FormStartPosition.CenterParent
                Frm_SelectInvoiceTypeForReport.ControlBox = True
                Frm_SelectInvoiceTypeForReport.ShowDialog()
            Else
                Frm_ServiceReportNew.Show()
                Frm_ServiceReportNew.BringToFront()
            End If
        Else
            Frm_SelectInvoiceTypeForReport.StartPosition = FormStartPosition.CenterParent
            Frm_SelectInvoiceTypeForReport.ControlBox = True
            Frm_SelectInvoiceTypeForReport.ShowDialog()
        End If
        'OpenForm(Frm_SelectInvoiceTypeForReport)
        'End_Waiting()
    End Sub
    Private Sub BackupBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BackupBarButtonItem.ItemClick
        Dim portfolioPath As String = My.Settings.dbPreevolTechnicsConnectionString1
        Dim length As Integer = Len(portfolioPath)
        Dim subPath As String = portfolioPath.Substring(47, length - 48)
        UploadFolderToGoogleDrive(subPath)
        'Try
        '    FileCopy(subPath, "C:\Users\bhavsar\Google Drive\Back up of Preevol DB\dbPreevolTechnics.accdb")
        '    XtraMessageBox.Show("Database Backup Successfully Done...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    XtraMessageBox.Show("Please Take Backup From PC Where GOOGLE Drive is Configured.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    'FileCopy(subPath, "\\BHAVSAR-PC\Users\bhavsar\Google Drive\Back up of Preevol DB\dbPreevolTechnics.accdb")
        '    'XtraMessageBox.Show("Database Backup Successfully Done...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
        'Dim folderPath As String = "C:\Preevol\Preevol\Preevol\Preevol Technics" ' Replace with your folder path
    End Sub
    Private Sub UploadFolderToGoogleDrive(localFolderPath As String)
        Try
            ' Authenticate and initialize the Drive service
            Dim credential As UserCredential
            Dim AppPath As String = ConfigurationManager.AppSettings("AppPath")
            Dim credentialsFilePath As String = AppPath + "\credentials.json"
            Using stream = New FileStream(credentialsFilePath, FileMode.Open, FileAccess.Read)
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    New String() {DriveService.Scope.DriveFile},
                    "user",
                    CancellationToken.None).Result
            End Using

            Dim service = New DriveService(New BaseClientService.Initializer() With {
                .HttpClientInitializer = credential,
                .ApplicationName = "Google Drive Folder Upload"
            })

            ' Upload files recursively
            'UploadFilesInFolder(service, localFolderPath, Nothing)
            Dim folderName As String = "Preevol Database Backup File" ' Replace with the name of the folder
            Dim folderId As String = FindFolderIdByName(service, folderName)

            If folderId IsNot Nothing Then
                'MessageBox.Show($"Found folder ID: {folderId}")
            Else
                'MessageBox.Show("Folder not found so create a new folder.")
                folderId = CreateDriveFolder(service, folderName, Nothing)
            End If

            UploadFilesInFolder(service, localFolderPath, folderId)
            MessageBox.Show("Folder uploaded successfully!")

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub
    Private Function CreateDriveFolder(service As DriveService, folderName As String, parentFolderId As String) As String
        Dim fileMetadata = New Google.Apis.Drive.v3.Data.File() With {
            .Name = folderName,
            .MimeType = "application/vnd.google-apps.folder",
            .Parents = If(parentFolderId IsNot Nothing, New List(Of String)({parentFolderId}), Nothing)
        }

        Dim request = service.Files.Create(fileMetadata)
        request.Fields = "id"
        Dim folder = request.Execute()
        Return folder.Id
    End Function
    Private Function FindFolderIdByName(service As DriveService, folderName As String) As String
        ' Search for the folder by name
        Dim query As String = $"name = '{folderName}' and mimeType = 'application/vnd.google-apps.folder' and trashed = false"
        Dim request = service.Files.List()
        request.Q = query
        request.Fields = "files(id, name)"
        Dim result = request.Execute()

        If result.Files IsNot Nothing AndAlso result.Files.Count > 0 Then
            ' Return the first match
            Return result.Files(0).Id
        End If

        Return Nothing
    End Function

    'Private Sub UploadFilesInFolder(service As DriveService, localFolderPath As String, existingFolderId As String)
    '    ' Get all files in the local folder
    '    Dim files = Directory.GetFiles(Path.GetDirectoryName(localFolderPath))
    '    For Each filePath In files
    '        ' Check if the file exists in the target Google Drive folder
    '        Dim existingFileId = FindFileInFolder(service, Path.GetFileName(filePath), existingFolderId)

    '        If existingFileId IsNot Nothing Then
    '            ' If the file exists, delete it
    '            DeleteFileFromDrive(service, existingFileId)
    '        End If

    '        ' Upload the file to the existing folder
    '        UploadFileToDrive(service, filePath, existingFolderId)
    '    Next
    'End Sub
    Private Sub UploadFilesInFolder(service As DriveService, localFolderPath As String, existingFolderId As String)
        ' Create a folder in Google Drive
        Dim filename = Path.GetFileName(localFolderPath)
        Dim filePath As String = Path.GetDirectoryName(localFolderPath)
        'Dim currentDate As String = DateTime.Now.ToString("dd-MM-yyyy") ' Using hyphens for folder name safety
        'Dim newFolderName As String = $"{localFolderName}_{currentDate}"
        'Dim localFolderName = Path.GetFileName(filePath) + "_" + currentDate

        'Dim driveFolderId = CreateDriveFolder(service, localFolderName, parentFolderId)

        ' Upload files in the current folder
        'For Each file In Directory.GetFiles(filePath)
        Dim files = Directory.GetFiles(Path.GetDirectoryName(localFolderPath))
        Dim existingFileId = FindFileInFolder(service, filename, existingFolderId)

        If existingFileId IsNot Nothing Then
            ' If the file exists, delete it
            DeleteFileFromDrive(service, existingFileId)
        End If

        ' Upload the file to the existing folder
        'UploadFileToDrive(service, filePath, existingFolderId)
        UploadFileToDrive(service, localFolderPath, existingFolderId)
        'Next

        ' Recursively upload subfolders
        'For Each subfolder In Directory.GetDirectories(localFolderPath)
        ' UploadFilesInFolder(service, subfolder, driveFolderId)
        'Next
    End Sub

    Private Function FindFileInFolder(service As DriveService, fileName As String, folderId As String) As String
        Dim query = $"name = '{fileName}' and '{folderId}' in parents and trashed = false"
        Dim request = service.Files.List()
        request.Q = query
        request.Fields = "files(id, name)"
        Dim result = request.Execute()

        If result.Files IsNot Nothing AndAlso result.Files.Count > 0 Then
            Return result.Files(0).Id ' Return the file ID if it exists
        End If

        Return Nothing
    End Function

    Private Sub DeleteFileFromDrive(service As DriveService, fileId As String)
        Dim request = service.Files.Delete(fileId)
        request.Execute()
    End Sub

    Private Sub UploadFileToDrive(service As DriveService, filePath As String, folderId As String)
        Dim fileMetadata = New Google.Apis.Drive.v3.Data.File() With {
        .Name = Path.GetFileName(filePath),
        .Parents = New List(Of String)({folderId})
    }

        Using stream = New FileStream(filePath, FileMode.Open)
            Dim request = service.Files.Create(fileMetadata, stream, "application/octet-stream")
            request.Fields = "id"
            request.Upload()
        End Using
    End Sub

    'Private Sub UploadFolderToGoogleDrive(localFolderPath As String)
    '    Try
    '        ' Authenticate and initialize the Drive service
    '        Dim credential As UserCredential
    '        Dim AppPath As String = ConfigurationManager.AppSettings("AppPath")
    '        Dim credentialsFilePath As String = AppPath + "\credentials.json"
    '        Using stream = New FileStream(credentialsFilePath, FileMode.Open, FileAccess.Read)
    '            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
    '                GoogleClientSecrets.FromStream(stream).Secrets,
    '                New String() {DriveService.Scope.DriveFile},
    '                "user",
    '                CancellationToken.None).Result
    '        End Using

    '        Dim service = New DriveService(New BaseClientService.Initializer() With {
    '            .HttpClientInitializer = credential,
    '            .ApplicationName = "Google Drive Folder Upload"
    '        })

    '        ' Upload files recursively
    '        UploadFilesInFolder(service, localFolderPath, Nothing)
    '        MessageBox.Show("Folder uploaded successfully!")

    '    Catch ex As Exception
    '        MessageBox.Show($"Error: {ex.Message}")
    '    End Try
    'End Sub
    'Private Sub UploadFilesInFolder(service As DriveService, localFolderPath As String, parentFolderId As String)
    '    ' Create a folder in Google Drive
    '    Dim filename = Path.GetFileName(localFolderPath)
    '    Dim filePath As String = Path.GetDirectoryName(localFolderPath)
    '    Dim currentDate As String = DateTime.Now.ToString("dd-MM-yyyy") ' Using hyphens for folder name safety
    '    'Dim newFolderName As String = $"{localFolderName}_{currentDate}"
    '    Dim localFolderName = Path.GetFileName(filePath) + "_" + currentDate

    '    Dim driveFolderId = CreateDriveFolder(service, localFolderName, parentFolderId)

    '    ' Upload files in the current folder
    '    'For Each file In Directory.GetFiles(filePath)
    '    UploadFileToDrive(service, localFolderPath, driveFolderId)
    '    'Next

    '    ' Recursively upload subfolders
    '    'For Each subfolder In Directory.GetDirectories(localFolderPath)
    '    ' UploadFilesInFolder(service, subfolder, driveFolderId)
    '    'Next
    'End Sub
    'Private Function CreateDriveFolder(service As DriveService, folderName As String, parentFolderId As String) As String
    '    Dim fileMetadata = New Google.Apis.Drive.v3.Data.File() With {
    '        .Name = folderName,
    '        .MimeType = "application/vnd.google-apps.folder",
    '        .Parents = If(parentFolderId IsNot Nothing, New List(Of String)({parentFolderId}), Nothing)
    '    }

    '    Dim request = service.Files.Create(fileMetadata)
    '    request.Fields = "id"
    '    Dim folder = request.Execute()
    '    Return folder.Id
    'End Function
    'Private Sub UploadFileToDrive(service As DriveService, filePath As String, folderId As String)
    '    Dim fileMetadata = New Google.Apis.Drive.v3.Data.File() With {
    '        .Name = Path.GetFileName(filePath),
    '        .Parents = New List(Of String)({folderId})
    '    }

    '    Using stream = New FileStream(filePath, FileMode.Open)
    '        Dim request = service.Files.Create(fileMetadata, stream, "application/octet-stream")
    '        request.Fields = "id"
    '        request.Upload()
    '    End Using
    'End Sub
    Private Sub QuotationBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles QuotationBarButtonItem.ItemClick
        If Frm_Quotation.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_Quotation.Close()
                Frm_SelectQuotationType.StartPosition = FormStartPosition.CenterParent
                Frm_SelectQuotationType.ControlBox = True
                Frm_SelectQuotationType.ShowDialog()
            Else
                Frm_Quotation.Show()
                Frm_Quotation.BringToFront()
            End If
        Else
            Frm_SelectQuotationType.StartPosition = FormStartPosition.CenterParent
            Frm_SelectQuotationType.ControlBox = True
            Frm_SelectQuotationType.ShowDialog()
        End If
    End Sub
    Private Sub TypeBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles TypeBarButtonItem.ItemClick
        OpenForm(Frm_Type)
        End_Waiting()
    End Sub
    Private Sub PlungerDiaBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PlungerDiaBarButtonItem.ItemClick
        OpenForm(Frm_PlungerDia)
        End_Waiting()
    End Sub
    Private Sub ModelBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ModelBarButtonItem.ItemClick
        OpenForm(Frm_Model)
        End_Waiting()
    End Sub
    Private Sub GoodsBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles GoodsBarButtonItem.ItemClick
        OpenForm(Frm_Goods)
        End_Waiting()
    End Sub
    Private Sub InventoryBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InventoryBarButtonItem.ItemClick
        If Frm_InventoryManagement.Visible Then
            Dim result As DialogResult = XtraMessageBox.Show("Do you want to close the form?" & vbCrLf & vbCrLf & "Click Yes to close and No to go back." & vbCrLf & vbCrLf, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Frm_InventoryManagement.Close()
                Frm_SelectInventoryType.StartPosition = FormStartPosition.CenterParent
                Frm_SelectInventoryType.ControlBox = True
                Frm_SelectInventoryType.ShowDialog()
            Else
                Frm_InventoryManagement.Show()
                Frm_InventoryManagement.BringToFront()
            End If
        Else
            Frm_SelectInventoryType.StartPosition = FormStartPosition.CenterParent
            Frm_SelectInventoryType.ControlBox = True
            Frm_SelectInventoryType.ShowDialog()
        End If
    End Sub
    Private Sub DBBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DBBarButtonItem.ItemClick
        OpenForm(Frm_Dashboard)
        End_Waiting()
    End Sub
    Private Sub StockReportBarButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles StockReportBarButton.ItemClick
        OpenForm(Frm_StockReport)
        End_Waiting()
    End Sub
    'Private Sub ProformaInvoiceBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    OpenForm(Frm_ProformaInvoiceNew)
    '    With Frm_ProformaInvoiceNew
    '        .InitLookup()
    '    End With
    '    End_Waiting()
    'End Sub
    'Private Sub InvoiceReportBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    Dim Rpt As New XR_Invoice
    '    Rpt.FillDataSource()
    '    Dim ReportPrintTool = New ReportPrintTool(Rpt)
    '    End_Waiting()
    '    Rpt.ShowRibbonPreviewDialog()
    'End Sub
End Class