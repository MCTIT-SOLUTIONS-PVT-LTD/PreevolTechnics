Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Module EstablishConnection

    Public PubCompanyName As String = ""
    Public PubInvoiceType As String = ""
    Public PubInventoryType As String = ""
    Public PubProformaInvoiceType As String = ""
    Public PubQuotationType As String = ""
    Public PubFormType As String = ""


    Public PubPOType As String = ""
    Public PubWOType As String = ""


    Public PubUserID As Integer = 0
    Public CurrentUserName As String

    Public PubGST As Boolean
    Public PubIGST As Boolean
    Public PubWithLUT As Boolean
    Public PubWithoutLUT As Boolean

    'added for EInvoice TranDtls -> SupTyp
    Public PubSupTyp As String
    'end
    Public PubPrice As Boolean
    Public PubDis As Boolean
    Public PubIsAdmin As Boolean
    Public PubTransportName As String = ""
    Public PubTransportID As Integer = 0
    'Public PubBillNo As Integer = 0
    ' Public UserType As Boolean = True
    Public UserID As Integer = 1

    Public PubPrintAction As String = ""

    Public ConStr As New OleDbConnection(My.Settings.dbPreevolTechnicsConnectionString1 ) 
    'For Database Backup/Restore

    Sub CnnOpen()
        If ConStr.State = ConnectionState.Closed Then ConStr.Open()
    End Sub

    Sub CnnClose()
        ConStr.Close()
    End Sub

    Function SetLookUp(SelectString As String, TableName As String, VM As String, DM As String, ByVal LookupEdit As DevExpress.XtraEditors.LookUpEdit, Caption As String, Optional ByVal IsDirectAcces As Boolean = False)
        Dim DS As New DataSet
        Try
            DS.Tables(TableName).Clear()
        Catch
        End Try
        Dim DA As New OleDbDataAdapter(SelectString, ConStr)
        DA.Fill(DS, TableName)
        With LookupEdit.Properties
            .DataSource = DS.Tables(TableName)
            .ValueMember = VM
            .DisplayMember = DM
            If .Columns.Count = 0 Then .Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(DM, Caption))
            .SearchMode = Controls.SearchMode.AutoFilter
            .ImmediatePopup = True
            .AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        End With

        Return True
    End Function

    Function ShowRecordStock(ByVal SelectString As String, ByVal PKColumnName As String) As Integer
        ShowRecordStock = 0
        Dim Frm As New FrmOpenStock(SelectString)

        Frm.GridView1.Columns(PKColumnName).Visible = False

        For Each col In Frm.GridView1.Columns
            col.OptionsColumn.AllowFocus = False
            'col.optionscolumn.bestfit()
        Next
        Frm.GridView1.BestFitColumns()

        Frm.ShowDialog()
        If Frm.DialogResult = DialogResult.OK Then
            If Frm.BS.Count > 0 Then
                ShowRecordStock = Frm.BS.Current(0)
            End If
        End If

        Frm = Nothing
        Return ShowRecordStock
    End Function
    Function ShowRecord(ByVal SelectString As String, ByVal PKColumnName As String) As Integer
        ShowRecord = 0
        Dim Frm As New FrmOpen(SelectString)

        Frm.GridView1.Columns(PKColumnName).Visible = False
        ' MsgBox("in")

        If SelectString = "Select * From SubCategory Where Company = '" + PubCompanyName + "'" Then
            GridLookUpFunc("SELECT CategoryID,CategoryName FROM Category", "Category", "CategoryID", "CategoryName", Frm.GridControl1, Frm.GridView1, "CategoryID", "Category Name")
            Frm.GridView1.Columns("Company").Visible = False
        ElseIf SelectString = "Select * From Category Where Company ='" + PubCompanyName + "'" Then
            Frm.GridView1.Columns("Company").Visible = False
        ElseIf SelectString = "Select * From Product Where Company ='" + PubCompanyName + "'" Then
            GridLookUpFunc("SELECT CategoryID,CategoryName FROM Category", "Category", "CategoryID", "CategoryName", Frm.GridControl1, Frm.GridView1, "CategoryID", "Category Name")
            GridLookUpFunc("SELECT SubCategoryID, SubCategoryName FROM SubCategory", "SubCategory", "SubCategoryID", "SubCategoryName", Frm.GridControl1, Frm.GridView1, "SubCategoryID", "Sub Category Name")
            Frm.GridView1.Columns("Company").Visible = False
        ElseIf SelectString = "Select * From Bank Where Company ='" + PubCompanyName + "'" Then
            GridLookUpFunc("SELECT CompanyID,Name FROM Company", "Company", "CompanyID", "Name", Frm.GridControl1, Frm.GridView1, "CompanyID", "Company Name")
            Frm.GridView1.Columns("Company").Visible = False
        ElseIf SelectString = "Select * From Party Where Company = '" + PubCompanyName + "'" Then
            Frm.GridView1.Columns("Company").Visible = False
        ElseIf SelectString = "Select * From User" Then
            Frm.GridView1.Columns("Pwd").Visible = False
        ElseIf SelectString = "SELECT * FROM Invoice Where InvoiceType='" + PubInvoiceType + "' AND Company ='" + PubCompanyName + "' ORDER BY InvoiceDate DESC" Then
            Frm.GridView1.Columns("ReceiverAddress").Visible = False
            Frm.GridView1.Columns("ReceiverGSTIN").Visible = False
            Frm.GridView1.Columns("ReceiverState").Visible = False
            Frm.GridView1.Columns("ReceiverStateCode").Visible = False
            Frm.GridView1.Columns("ConsigneeAddress").Visible = False
            Frm.GridView1.Columns("ConsigneeGSTIN").Visible = False
            Frm.GridView1.Columns("ConsigneeState").Visible = False
            Frm.GridView1.Columns("ConsigneeStateCode").Visible = False
            Frm.GridView1.Columns("Remarks").Visible = False
            Frm.GridView1.Columns("TotalInWords").Visible = False
            Frm.GridView1.Columns("Company").Visible = False
            Frm.GridView1.Columns("TaxInWords").Visible = False
        ElseIf SelectString = "SELECT * FROM ServiceInvoice Where InvoiceType='" + PubInvoiceType + "' AND Company = '" + PubCompanyName + "' ORDER BY InvoiceDate DESC" Then
            Frm.GridView1.Columns("ReceiverAddress").Visible = False
            Frm.GridView1.Columns("ReceiverGSTIN").Visible = False
            Frm.GridView1.Columns("ReceiverState").Visible = False
            Frm.GridView1.Columns("ReceiverStateCode").Visible = False
            Frm.GridView1.Columns("ConsigneeAddress").Visible = False
            Frm.GridView1.Columns("ConsigneeGSTIN").Visible = False
            Frm.GridView1.Columns("ConsigneeState").Visible = False
            Frm.GridView1.Columns("ConsigneeStateCode").Visible = False
            Frm.GridView1.Columns("Remarks").Visible = False
            Frm.GridView1.Columns("TotalInWords").Visible = False
            Frm.GridView1.Columns("Company").Visible = False
            Frm.GridView1.Columns("TaxInWords").Visible = False
        End If
        
        For Each col In Frm.GridView1.Columns
            col.OptionsColumn.AllowFocus = False
            'col.optionscolumn.bestfit()
        Next
        Frm.GridView1.BestFitColumns()

        Frm.ShowDialog()
        If Frm.DialogResult = DialogResult.OK Then
            If Frm.BS.Count > 0 Then
                ShowRecord = Frm.BS.Current(0)
            End If
        End If

        Frm = Nothing
        Return ShowRecord
    End Function

    Function themes(ByVal PanelCtrl As PanelControl)
        For Each Ctrl In PanelCtrl.Controls
            If Ctrl.GetType.Name <> "LabelControl" And Ctrl.GetType.Name <> "Label" And Ctrl.GetType.Name <> "GridControl" And Ctrl.GetType.Name <> "SimpleButton" And Ctrl.GetType.Name <> "PanelControl" Then
                Try
                    Ctrl.Properties.AppearanceFocused.BackColor = Color.Aqua
                    Ctrl.EnterMoveNextControl = True
                Catch
                End Try
            End If
        Next
        Return True
    End Function

    Function themesGroupCtrl(ByVal GroupCtrl As GroupControl)
        For Each Ctrl In GroupCtrl.Controls
            If Ctrl.GetType.Name <> "LabelControl" And Ctrl.GetType.Name <> "Label" And Ctrl.GetType.Name <> "GridControl" And Ctrl.GetType.Name <> "SimpleButton" Then
                Ctrl.Properties.AppearanceFocused.BackColor = Color.Aqua
                Ctrl.EnterMoveNextControl = True
            End If
        Next
        Return True
    End Function

    Function themesTabCtrl(ByVal TabCtrl As DevExpress.XtraTab.XtraTabPage)
        For Each Ctrl In TabCtrl.Controls
            If Ctrl.GetType.Name <> "LabelControl" And Ctrl.GetType.Name <> "Label" And Ctrl.GetType.Name <> "GridControl" And Ctrl.GetType.Name <> "SimpleButton" Then
                Ctrl.Properties.AppearanceFocused.BackColor = Color.Aqua
                Ctrl.EnterMoveNextControl = True
            End If
        Next
        Return True
    End Function

    Function SetGridLookUp(SelectString As String, TableName As String, DM As String, VM As String, ByVal GridLookupEdit As DevExpress.XtraEditors.GridLookUpEdit, Caption As String, Optional ByVal IsDirectAcces As Boolean = False)
        Dim DS As New DataSet
        Try
            DS.Tables(TableName).Clear()
        Catch
        End Try
        Dim DA As New OleDbDataAdapter(SelectString, ConStr)
        DA.Fill(DS, TableName)
        GridLookupEdit.Properties.DisplayMember = DM
        GridLookupEdit.Properties.ValueMember = VM
        GridLookupEdit.Properties.DataSource = DS.Tables(TableName)

        If IsDirectAcces = True Then
            GridLookupEdit.Properties.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(ButtonPredefines.Redo))
        End If

        GridLookupEdit.Properties.ImmediatePopup = True
        'GridLookupEdit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(DM, Caption))
        GridLookupEdit.Properties.View.Columns.AddField(DM)
        Return True
    End Function
End Module
