Imports System.Data.OleDb
Imports DevExpress.XtraEditors
'Imports ELCF
Public Class Frm_InventoryManagement
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim DADetails As New OleDbDataAdapter
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()
        InitLookup()
        AddNew()
        GoodsIDLookUpEdit.Focus()
        'TypeComboBoxEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
        'If PubInventoryType = "RETURN" Then
        '    LabelControl3.Visible = True
        '    LabelControl12.Visible = True
        '    RemarksMemoEdit.Visible = True
        'End If
    End Sub

    Function SetDataTable()
        DS.Tables.Add("GoodsInventory")
        With DS.Tables("GoodsInventory").Columns
            .Add("InventoryID", GetType(Integer))
            .Add("GoodsID", GetType(Integer))
            .Add("PartyName", GetType(String))
            .Add("PartyOtherDetail", GetType(String))
            .Add("InvDate", GetType(Date))
            .Add("UOM", GetType(String))
            .Add("Qty", GetType(Double))
            .Add("Remarks", GetType(String))
            .Add("Company", GetType(String))
            .Add("InventoryType", GetType(String))
        End With

        With DS.Tables("GoodsInventory").Columns("InventoryID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
        Return True
    End Function

    Function SetQuery()
        DA.SelectCommand = New OleDbCommand("Select InventoryID,GoodsID,PartyName,PartyOtherDetail,InvDate,UOM,Qty,Remarks,Company,InventoryType From GoodsInventory Where InventoryID=@InventoryID", ConStr)
        DA.SelectCommand.Parameters.Add("@InventoryID", OleDbType.Integer, 4, "InventoryID")

        DA.InsertCommand = New OleDbCommand("Insert Into GoodsInventory (GoodsID,PartyName,PartyOtherDetail,InvDate,UOM,Qty,Remarks,Company,InventoryType) Values (@GoodsID,@PartyName,@PartyOtherDetail,@InvDate,@UOM,@Qty,@Remarks,@Company,@InventoryType)", ConStr)
        DA.InsertCommand.Parameters.Add("@GoodsID", OleDbType.Integer, 4, "GoodsID")
        DA.InsertCommand.Parameters.Add("@PartyName", OleDbType.VarChar, 50, "PartyName")
        DA.InsertCommand.Parameters.Add("@PartyOtherDetail", OleDbType.VarChar, 50, "PartyOtherDetail")
        DA.InsertCommand.Parameters.Add("@InvDate", OleDbType.Date, 3, "InvDate")
        DA.InsertCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DA.InsertCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DA.InsertCommand.Parameters.Add("@Remarks", OleDbType.VarChar, 50, "Remarks")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")
        DA.InsertCommand.Parameters.Add("@InventoryType", OleDbType.VarChar, 50, "InventoryType")

        DA.UpdateCommand = New OleDbCommand("Update GoodsInventory Set GoodsID=@GoodsID,PartyName=@PartyName,PartyOtherDetail=@PartyOtherDetail,UOM=@UOM,Qty=@Qty,Remarks=@Remarks Where InventoryID=@InventoryID", ConStr)
        DA.UpdateCommand.Parameters.Add("@GoodsID", OleDbType.Integer, 4, "GoodsID")
        DA.UpdateCommand.Parameters.Add("@PartyName", OleDbType.VarChar, 50, "PartyName")
        DA.UpdateCommand.Parameters.Add("@PartyOtherDetail", OleDbType.VarChar, 50, "PartyOtherDetail")
        DA.UpdateCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DA.UpdateCommand.Parameters.Add("@Qty", OleDbType.Double, 8, "Qty")
        DA.UpdateCommand.Parameters.Add("@Remarks", OleDbType.VarChar, 50, "Remarks")
        DA.UpdateCommand.Parameters.Add("@InventoryID", OleDbType.Integer, 4, "InventoryID")

        DA.DeleteCommand = New OleDbCommand("Delete From GoodsInventory Where InventoryID=@InventoryID", ConStr)
        DA.DeleteCommand.Parameters.Add("@InventoryID", OleDbType.Integer, 4, "InventoryID")
        Return True
    End Function

    Function SetBinding()
        BS.DataSource = DS.Tables("GoodsInventory")
        GoodsIDLookUpEdit.DataBindings.Add(New Binding("EditValue", BS, "GoodsID"))
        PartyNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyName"))
        PartyOtherDetailMemoEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyOtherDetail"))
        UOMTextEdit.DataBindings.Add(New Binding("EditValue", BS, "UOM"))
        QtyMaskedTextBox.DataBindings.Add(New Binding("Text", BS, "Qty"))
        RemarksMemoEdit.DataBindings.Add(New Binding("EditValue", BS, "Remarks"))
        Return True
    End Function
    Sub InitLookup()
        SetLookUp("SELECT GoodsID,FullGoodsName FROM Goods", "Goods", "GoodsID", "FullGoodsName", GoodsIDLookUpEdit, "Goods")
        ''SetGridCommboBox("SELECT DISTINCT FullGoodsName FROM Goods", "Goods", GoodsNameComboBoxEdit)
        'SetLookUp("SELECT GoodsID, GoodsName FROM Goods", "Goods", "GoodsID", "GoodsName", GoodsNameComboBoxEdit, "Goods")
    End Sub

    Sub AddNew()
        BS.AddNew()
        BS.Current!Company = PubCompanyName
        BS.Current!InventoryType = PubInventoryType
        BS.Current!InvDate = Date.Today
        BS.EndEdit()
        GoodsIDLookUpEdit.Focus()
        InitLookup()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        GoodsIDLookUpEdit.Focus()
        SaveSimpleButton.Enabled = True
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From GoodsInventory Where InventoryType='" + PubInventoryType + "' AND Company ='" + PubCompanyName + "'", "InventoryID")
        If ID > 0 Then
            Try
                DS.Tables("GoodsInventory").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@InventoryID").Value = ID
            DA.Fill(DS, "GoodsInventory")

            SaveSimpleButton.Enabled = False
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("GoodsInventory"))
                AddNew()
                SaveSimpleButton.Enabled = True
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If PubInventoryType = "RETURN" Then
            If RemarksMemoEdit.EditValue Is DBNull.Value Then
                RemarksMemoEdit.Focus()
                Return False
            Else
                Return True
            End If
        End If
        If GoodsIDLookUpEdit.EditValue Is DBNull.Value Then
            GoodsIDLookUpEdit.Focus()
            Return False
        ElseIf PartyNameTextEdit.EditValue Is DBNull.Value Then
            PartyNameTextEdit.Focus()
            Return False
            Else
                Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            CnnOpen()
            Dim checkCMD As New OleDbCommand("Select ClosingQty,PricePerUnit From Goods Where GoodsId=@GoodsID", ConStr)
            checkCMD.Parameters.AddWithValue("@GoodsId", BS.Current!GoodsId)
            'CnnOpen() : Dim reader = checkCMD.ExecuteScalar() : CnnClose()
            Dim reader As OleDbDataReader = checkCMD.ExecuteReader()
            If PubInventoryType = "RETURN" Or
                PubInventoryType = "IN" Then
                BS.Current!Company = PubCompanyName
                'BS.Current!UOM = UOMComboBoxEdit.Text
                BS.EndEdit()
                DA.Update(DS.Tables("GoodsInventory"))
                While reader.Read()
                    Dim newQty = (reader("ClosingQty").ToString()) + BS.Current!Qty
                    Dim newCloseVal = (reader("PricePerUnit").ToString()) * newQty
                    Dim newCMD As New OleDbCommand("Update Goods set ClosingQty=@ClosingQty,ClosingStockVal=@ClosingStockVal,LastUpdated=@LastUpdated where GoodsId=@GoodsID", ConStr)
                    newCMD.Parameters.AddWithValue("@ClosingQty", newQty)
                    newCMD.Parameters.AddWithValue("@ClosingStockVal", newCloseVal)
                    newCMD.Parameters.AddWithValue("@LastUpdated", DateTime.Now.ToString())
                    newCMD.Parameters.AddWithValue("@GoodsId", BS.Current!GoodsId)
                    newCMD.ExecuteNonQuery()
                End While
                AddNew()
            Else
                While reader.Read()
                    If (reader("ClosingQty").ToString()) >= BS.Current!Qty Then
                        BS.Current!Company = PubCompanyName
                        'BS.Current!UOM = UOMComboBoxEdit.Text
                        BS.EndEdit()
                        DA.Update(DS.Tables("GoodsInventory"))
                        Dim newQty = (reader("ClosingQty").ToString()) - BS.Current!Qty
                        Dim newCloseVal = (reader("PricePerUnit").ToString()) * newQty
                        Dim newCMD As New OleDbCommand("Update Goods set ClosingQty=@ClosingQty,ClosingStockVal=@ClosingStockVal,LastUpdated=@LastUpdated where GoodsId=@GoodsID", ConStr)
                        newCMD.Parameters.AddWithValue("@ClosingQty", newQty)
                        newCMD.Parameters.AddWithValue("@ClosingStockVal", newCloseVal)
                        newCMD.Parameters.AddWithValue("@LastUpdated", DateTime.Now.ToString())
                        newCMD.Parameters.AddWithValue("@GoodsId", BS.Current!GoodsId)
                        newCMD.ExecuteNonQuery()
                        AddNew()
                    Else
                        XtraMessageBox.Show("Operation Failed : Only " + reader(0).ToString() + " Qty Availabe in stock.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End While
            End If
            CnnClose()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    'Private Sub AddNewSimpleButton_Click(sender As Object, e As EventArgs) Handles AddNewSimpleButton.Click
    '    Frm_AddSubCategory.StartPosition = FormStartPosition.CenterParent
    '    Frm_AddSubCategory.ShowDialog()
    '    If Frm_AddSubCategory.DialogResult = DialogResult.OK Then
    '        InitLookup()
    '        Frm_AddSubCategory.Close()
    '    Else
    '        Frm_AddSubCategory.Close()
    '    End If
    'End Sub



    'Private Sub GoodsNameComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Dim sda As New OleDbDataAdapter("Select UOM From Goods Where FullGoodsName='" + GoodsIDLookUpEdit.EditValue + "'", ConStr)
    '    Dim dt As New DataTable()
    '    sda.Fill(dt)
    '    If (dt.Rows.Count > 0) Then
    '        UOMTextEdit.Text = dt.Rows(0).Item("UOM").ToString
    '    End If
    '    If UOMTextEdit.Text = "Nos." Or UOMTextEdit.Text = "Set" Then
    '        QtyMaskedTextBox.Mask = "00"
    '        '    LabelControl14.Visible = True
    '        '    QtyTextEdit.Visible = True
    '    Else
    '        QtyMaskedTextBox.Mask = "00.00"
    '        '    LabelControl15.Visible = True
    '        '    KgsTextEdit.Visible = True
    '        '    KgsTextEdit.Visible = True
    '    End If

    'End Sub

    Private Sub AddNewSimpleButton_Click(sender As Object, e As EventArgs) Handles AddNewGoodsSimpleButton.Click
        Frm_AddGoods.StartPosition = FormStartPosition.CenterParent
        Frm_AddGoods.ShowDialog()
        If Frm_AddGoods.DialogResult = DialogResult.OK Then
            InitLookup()
            Frm_AddGoods.Close()
        Else
            Frm_AddGoods.Close()
        End If
    End Sub

    Private Sub GoodsIDLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles GoodsIDLookUpEdit.EditValueChanged
        Dim sda As New OleDbDataAdapter("Select UOM From Goods Where FullGoodsName='" + GoodsIDLookUpEdit.Text + "'", ConStr)
        Dim dt As New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            UOMTextEdit.Text = dt.Rows(0).Item("UOM").ToString
        End If
        If UOMTextEdit.Text = "Nos." Or UOMTextEdit.Text = "Set" Then
            QtyMaskedTextBox.Mask = "00"
            '    LabelControl14.Visible = True
            '    QtyTextEdit.Visible = True
        Else
            QtyMaskedTextBox.Mask = "00.00"
            '    LabelControl15.Visible = True
            '    KgsTextEdit.Visible = True
            '    KgsTextEdit.Visible = True
        End If
    End Sub
End Class