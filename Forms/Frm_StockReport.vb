Imports System.Data.OleDb
Public Class Frm_StockReport
    Dim sqlCgst As String
    Dim sqlLineItems As String
    Dim sqlPacking As String
    Private Sub FrmMasterConceptFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitLookup()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
        'FromDateDateEdit.Text = Date.Today()
        'ToDateDateEdit.Text = Date.Today()
    End Sub
    Sub InitLookup()
        SetGridCommboBox("SELECT DISTINCT GoodsName FROM Goods", "Goods", ItemNameComboBoxEdit)
        SetGridCommboBox("SELECT DISTINCT ModelName FROM Goods", "Goods", PumpModelComboBoxEdit)
        SetGridCommboBox("SELECT DISTINCT PartyName FROM GoodsInventory", "GoodsInventory", PartyComboBoxEdit)
    End Sub
    Private Sub GetDataSimpleButton_Click(sender As Object, e As EventArgs) Handles GetDataSimpleButton.Click
        Dim condition As String = " AND"
        If ItemNameComboBoxEdit.EditValue IsNot Nothing Then
            condition += " Goods.GoodsName = '" + ItemNameComboBoxEdit.Text + "' AND"
        End If
        If PartyComboBoxEdit.EditValue IsNot Nothing Then
            condition += " GoodsInventory.PartyName = '" + PartyComboBoxEdit.Text + "' AND"
        End If
        If PumpModelComboBoxEdit.EditValue IsNot Nothing Then
            condition += " Goods.ModelName = '" + PumpModelComboBoxEdit.Text + "' AND"
        End If
        If InventoryTypeComboBoxEdit.EditValue IsNot Nothing Then
            condition += " GoodsInventory.InventoryType = '" + InventoryTypeComboBoxEdit.Text + "' AND"
        End If
        If FromDateDateEdit.EditValue IsNot Nothing Then
            If ToDateDateEdit.EditValue IsNot Nothing Then
                'condition += " (OrderDate BETWEEN #" & FromDateEdit.Text & "# AND #" & ToDateEdit.Text & "#) AND"
                condition += " (GoodsInventory.InvDate BETWEEN #" & FromDateDateEdit.Text & "# AND #" & ToDateDateEdit.Text & "#) AND"
            End If
        End If

        condition = condition.Remove(condition.Length - 4)

        SetData(condition)
        SetGrid()
    End Sub
    Public Sub SetData(condition As String)
        Try
            Dim DT As New DataTable
            Dim DA As New OleDbDataAdapter("SELECT Goods.TypeName, Goods.ModelName, Goods.PlungerDiaName, Goods.GoodsName, GoodsInventory.UOM, GoodsInventory.Qty, GoodsInventory.InvDate, GoodsInventory.PartyName, GoodsInventory.PartyOtherDetail, GoodsInventory.Remarks, GoodsInventory.InventoryType
                FROM Goods INNER JOIN GoodsInventory ON Goods.GoodsID = GoodsInventory.GoodsID Where GoodsInventory.Company = '" + PubCompanyName + "'" + condition, ConStr)

            DA.Fill(DT)
            InvoiceDetailGridControl.DataSource = DT
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SetGrid()
        With InvoiceDetailGridView
            .Columns("TypeName").OptionsColumn.AllowFocus = False
            .Columns("TypeName").OptionsColumn.ReadOnly = True
            .Columns("ModelName").OptionsColumn.AllowFocus = False
            .Columns("ModelName").OptionsColumn.ReadOnly = True
            .Columns("PlungerDiaName").OptionsColumn.AllowFocus = False
            .Columns("PlungerDiaName").OptionsColumn.ReadOnly = True
            .Columns("GoodsName").OptionsColumn.AllowFocus = False
            .Columns("GoodsName").OptionsColumn.ReadOnly = True
            .Columns("UOM").OptionsColumn.AllowFocus = False
            .Columns("UOM").OptionsColumn.ReadOnly = True
            .Columns("Qty").OptionsColumn.AllowFocus = False
            .Columns("Qty").OptionsColumn.ReadOnly = True
            .Columns("InvDate").OptionsColumn.AllowFocus = False
            .Columns("InvDate").OptionsColumn.ReadOnly = True
            .Columns("PartyName").OptionsColumn.AllowFocus = False
            .Columns("PartyName").OptionsColumn.ReadOnly = True
            .Columns("PartyOtherDetail").OptionsColumn.AllowFocus = False
            .Columns("PartyOtherDetail").OptionsColumn.ReadOnly = True
            .Columns("Remarks").OptionsColumn.AllowFocus = False
            .Columns("Remarks").OptionsColumn.ReadOnly = True
            .Columns("InventoryType").OptionsColumn.AllowFocus = False
            .Columns("InventoryType").OptionsColumn.ReadOnly = True
        End With

        InvoiceDetailGridView.BestFitColumns()
    End Sub

    Private Sub ResetSimpleButton_Click(sender As Object, e As EventArgs) Handles ResetSimpleButton.Click
        InvoiceDetailGridControl.DataSource = Nothing
        InvoiceDetailGridView.Columns.Clear()
        InvoiceDetailGridControl.Refresh()
        FromDateDateEdit.EditValue = Nothing
        ToDateDateEdit.EditValue = Nothing
        ItemNameComboBoxEdit.EditValue = Nothing
        PumpModelComboBoxEdit.EditValue = Nothing
        InventoryTypeComboBoxEdit.EditValue = Nothing
        PartyComboBoxEdit.EditValue = Nothing
    End Sub

    Private Sub ExportExcelSimpleButton_Click(sender As Object, e As EventArgs) Handles ExportExcelSimpleButton.Click
        InvoiceDetailGridControl.ExportToXlsx("StockReport.xlsx")
        Process.Start("StockReport.xlsx")
    End Sub
End Class

