Imports System.Data.OleDb
Imports DevExpress.XtraEditors
'Imports ELCF
Public Class Frm_AddGoods
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
        TypeComboBoxEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Function SetDataTable()
        DS.Tables.Add("Goods")
        With DS.Tables("Goods").Columns
            .Add("GoodsID", GetType(Integer))
            .Add("TypeName", GetType(String))
            .Add("ModelName", GetType(String))
            .Add("PlungerDiaName", GetType(String))
            .Add("GoodsName", GetType(String))
            .Add("Description", GetType(String))
            .Add("UOM", GetType(String))
            .Add("OpeningQty", GetType(Double))
            .Add("ClosingQty", GetType(Double))
            .Add("ReOrderLevel", GetType(Double))
            .Add("FullGoodsName", GetType(String))
            .Add("LastUpdated", GetType(String))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("Goods").Columns("GoodsID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
        Return True
    End Function

    Function SetQuery()
        DA.SelectCommand = New OleDbCommand("Select GoodsID,TypeName,ModelName,PlungerDiaName,GoodsName,Description,UOM,OpeningQty,ClosingQty,ReOrderLevel,LastUpdated,Company From Goods Where GoodsID=@GoodsID", ConStr)
        DA.SelectCommand.Parameters.Add("@GoodsID", OleDbType.Integer, 4, "GoodsID")

        'DA.InsertCommand = New OleDbCommand("Insert Into Category (CategoryName,Company) Values (@CategoryName,@Company)", ConStr)
        DA.InsertCommand = New OleDbCommand("Insert Into Goods (TypeName,ModelName,PlungerDiaName,GoodsName,Description,UOM,OpeningQty,ClosingQty,ReOrderLevel,FullGoodsName,LastUpdated,Company) Values (@TypeName,@ModelName,@PlungerDiaName,@GoodsName,@Description,@UOM,@OpeningQty,@ClosingQty,@ReOrderLevel,@FullGoodsName,@LastUpdated,@Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@TypeName", OleDbType.VarChar, 50, "TypeName")
        DA.InsertCommand.Parameters.Add("@ModelName", OleDbType.VarChar, 50, "ModelName")
        DA.InsertCommand.Parameters.Add("@PlungerDiaName", OleDbType.VarChar, 50, "PlungerDiaName")
        DA.InsertCommand.Parameters.Add("@GoodsName", OleDbType.VarChar, 50, "GoodsName")
        DA.InsertCommand.Parameters.Add("@Description", OleDbType.VarChar, 50, "Description")
        DA.InsertCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DA.InsertCommand.Parameters.Add("@OpeningQty", OleDbType.Double, 8, "OpeningQty")
        DA.InsertCommand.Parameters.Add("@ClosingQty", OleDbType.Double, 8, "ClosingQty")
        DA.InsertCommand.Parameters.Add("@ReOrderLevel", OleDbType.Double, 8, "ReOrderLevel")
        DA.InsertCommand.Parameters.Add("@FullGoodsName", OleDbType.VarChar, 200, "FullGoodsName")
        DA.InsertCommand.Parameters.Add("@LastUpdated", OleDbType.VarChar, 200, "LastUpdated")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update Goods Set TypeName=@TypeName,ModelName=@ModelName,PlungerDiaName=@PlungerDiaName,GoodsName=@GoodsName,Description=@Description,UOM=@UMO,OpeningQty=@OpeningQty,ClosingQty=@ClosingQty,ReOrderLevel=@ReOrderLevel,FullGoodsName=@FullGoodsName,LastUpdated=@LastUpdated Where GoodsID=@GoodsID", ConStr)
        DA.UpdateCommand.Parameters.Add("@TypeName", OleDbType.VarChar, 50, "TypeName")
        DA.UpdateCommand.Parameters.Add("@ModelName", OleDbType.VarChar, 50, "ModelName")
        DA.UpdateCommand.Parameters.Add("@PlungerDiaName", OleDbType.VarChar, 50, "PlungerDiaName")
        DA.UpdateCommand.Parameters.Add("@GoodsName", OleDbType.VarChar, 50, "GoodsName")
        DA.UpdateCommand.Parameters.Add("@Description", OleDbType.VarChar, 50, "Description")
        DA.UpdateCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DA.UpdateCommand.Parameters.Add("@OpeningQty", OleDbType.Double, 8, "OpeningQty")
        DA.UpdateCommand.Parameters.Add("@ClosingQty", OleDbType.Double, 8, "ClosingQty")
        DA.UpdateCommand.Parameters.Add("@ReOrderLevel", OleDbType.Double, 8, "ReOrderLevel")
        DA.UpdateCommand.Parameters.Add("@FullGoodsName", OleDbType.VarChar, 200, "FullGoodsName")
        DA.UpdateCommand.Parameters.Add("@LastUpdated", OleDbType.VarChar, 200, "LastUpdated")
        DA.UpdateCommand.Parameters.Add("@GoodsID", OleDbType.Integer, 4, "GoodsID")

        DA.DeleteCommand = New OleDbCommand("Delete From Goods Where GoodsID=@GoodsID", ConStr)
        DA.DeleteCommand.Parameters.Add("@GoodsID", OleDbType.Integer, 4, "GoodsID")
        Return True
    End Function

    Function SetBinding()
        BS.DataSource = DS.Tables("Goods")
        TypeComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "TypeName"))
        ModelComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "ModelName"))
        PlungerDiaComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "PlungerDiaName"))
        GoodsNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "GoodsName"))
        DescriptionTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Description"))
        UOMComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "UOM"))
        OpeningQtyTextEdit.DataBindings.Add(New Binding("EditValue", BS, "OpeningQty"))
        ClosingQtyTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ClosingQty"))
        ReorderTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ReOrderLevel"))
        LastUpdateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "LastUpdated"))
        Return True
    End Function
    Sub InitLookup()
        SetGridCommboBox("SELECT DISTINCT TypeName FROM Type", "Type", TypeComboBoxEdit)
        SetGridCommboBox("SELECT DISTINCT ModelName FROM Model", "Model", ModelComboBoxEdit)
        SetGridCommboBox("SELECT DISTINCT PlungerDiaName FROM PlungerDia", "PlungerDia", PlungerDiaComboBoxEdit)
    End Sub

    Sub AddNew()
        BS.AddNew()
        TypeComboBoxEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        TypeComboBoxEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From Goods Where Company ='" + PubCompanyName + "'", "GoodsID")
        If ID > 0 Then
            Try
                DS.Tables("Goods").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@GoodsID").Value = ID
            DA.Fill(DS, "Goods")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("Goods"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If TypeComboBoxEdit.EditValue Is DBNull.Value Or GoodsNameTextEdit.EditValue Is "" Then
            TypeComboBoxEdit.Focus()
            Return False
        ElseIf ModelComboBoxEdit.EditValue Is DBNull.Value Then
            ModelComboBoxEdit.Focus()
            Return False
        ElseIf PlungerDiaComboBoxEdit.EditValue Is DBNull.Value Then
            PlungerDiaComboBoxEdit.Focus()
            Return False
        ElseIf GoodsNameTextEdit.EditValue Is DBNull.Value Then
            GoodsNameTextEdit.Focus()
            Return False
        ElseIf DescriptionTextEdit.EditValue Is DBNull.Value Or DescriptionTextEdit.EditValue Is "" Then
            DescriptionTextEdit.Focus()
            Return False
        ElseIf OpeningQtyTextEdit.EditValue Is DBNull.Value Or OpeningQtyTextEdit.EditValue Is "" Then
            OpeningQtyTextEdit.Focus()
            Return False
        ElseIf UOMComboBoxEdit.EditValue Is DBNull.Value Then
            UOMComboBoxEdit.Focus()
            Return False
        ElseIf ReorderTextEdit.EditValue Is DBNull.Value Or ReorderTextEdit.EditValue Is "" Then
            ReorderTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.Current!UOM = UOMComboBoxEdit.Text
            BS.Current!LastUpdated = DateTime.Now.ToString()
            BS.Current!ClosingQTY = BS.Current!OpeningQTY
            BS.Current!FullGoodsName = TypeComboBoxEdit.Text + " " + ModelComboBoxEdit.Text + "/" + PlungerDiaComboBoxEdit.Text + " " + GoodsNameTextEdit.Text
            BS.EndEdit()
            DA.Update(DS.Tables("Goods"))
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub
    'Private Sub GoodsIDLookUpEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GoodsNameComboBoxEdit.Validating

    '    If Not GoodsNameComboBoxEdit.EditValue Is DBNull.Value Then
    '        Try
    '            Dim CMD As New OleDbCommand("SELECT Count(InventoryID) FROM GoodsInventory WHERE GoodsName=@GoodsName AND TypeID=@TypeID AND ModelID=@ModelID AND PlungerDiaID=@PlungerDiaID AND InventoryID<>@InventoryID", ConStr)
    '            CMD.Parameters.AddWithValue("@GoodsName", GoodsNameComboBoxEdit.EditValue)
    '            CMD.Parameters.AddWithValue("@TypeID", TypeComboBoxEdit.EditValue)
    '            CMD.Parameters.AddWithValue("@ModelID", ModelIDLookUpEdit.EditValue)
    '            CMD.Parameters.AddWithValue("@PlungerDiaID", PlungerDiaIDLookUpEdit.EditValue)
    '            CMD.Parameters.AddWithValue("@InventoryID", IIf(BS.Current!InventoryID Is DBNull.Value, -1, BS.Current!InventoryID))
    '            CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
    '            If Verify <> 0 Then
    '                XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                GoodsNameComboBoxEdit.Focus()
    '                e.Cancel = True
    '            End If
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub

    Private Sub GoodsNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GoodsNameTextEdit.Validating
        If Not GoodsNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(GoodsID) FROM Goods WHERE GoodsName=@GoodsName AND TypeName=@TypeName AND ModelName=@ModelName AND PlungerDiaName=@PlungerDiaName AND GoodsID<>@GoodsID", ConStr)
                CMD.Parameters.AddWithValue("@GoodsName", GoodsNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@TypeID", TypeComboBoxEdit.EditValue)
                CMD.Parameters.AddWithValue("@ModelID", ModelComboBoxEdit.EditValue)
                CMD.Parameters.AddWithValue("@PlungerDiaID", PlungerDiaComboBoxEdit.EditValue)
                CMD.Parameters.AddWithValue("@GoodsID", IIf(BS.Current!GoodsID Is DBNull.Value, -1, BS.Current!GoodsID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GoodsNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Dim iNumber As Integer
    Private Sub ReorderTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReorderTextEdit.Validating
        If ReorderTextEdit.EditValue IsNot DBNull.Value Then
            If Not Integer.TryParse(ReorderTextEdit.Text, iNumber) Then
                XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ReorderTextEdit.Focus()
            End If
        End If
    End Sub
    'Private Sub HSNNoOrSACNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DescriptionTextEdit.Validating
    '    Dim iNumber As Integer
    '    If Not Integer.TryParse(DescriptionTextEdit.Text, iNumber) Then
    '        XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        DescriptionTextEdit.Focus()
    '        e.Cancel = True
    '    End If
    'End Sub

    'Private Sub AddNewSimpleButton_Click(sender As Object, e As EventArgs)
    '    Frm_AddSubCategory.StartPosition = FormStartPosition.CenterParent
    '    Frm_AddSubCategory.ShowDialog()
    '    If Frm_AddSubCategory.DialogResult = DialogResult.OK Then
    '        InitLookup()
    '        Frm_AddSubCategory.Close()
    '    Else
    '        Frm_AddSubCategory.Close()
    '    End If
    'End Sub


End Class