Imports DevExpress.XtraEditors
Imports System.Data.OleDb
'Imports ELCF
Public Class Frm_AddParty
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()
        AddNew()
        PartyNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
        ' AddressTextEdit.EnterMoveNextControl = False
    End Sub

    Function SetDataTable()
        DS.Tables.Add("Party")
        With DS.Tables("Party").Columns
            .Add("PartyID", GetType(Integer))
            .Add("PartyName", GetType(String))
            .Add("ContactPerson", GetType(String))
            .Add("Contact1", GetType(String))
            .Add("Contact2", GetType(String))
            .Add("Address", GetType(String))
            .Add("City", GetType(String))
            .Add("State", GetType(String))
            .Add("StateCode", GetType(Integer))
            .Add("Email", GetType(String))
            .Add("Website", GetType(String))
            .Add("GSTStatus", GetType(String))
            .Add("GSTIN", GetType(String))
            .Add("PANNo", GetType(String))
            .Add("VATNo", GetType(Integer))
            .Add("CSTNO", GetType(Integer))
            .Add("ECCNo", GetType(String))
            .Add("IECCode", GetType(String))
            .Add("Company", GetType(String))
            .Add("Pin", GetType(Integer))
        End With

        With DS.Tables("Party").Columns("PartyID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
        Return True
    End Function

    Function SetQuery()
        DA.SelectCommand = New OleDbCommand("Select PartyID,PartyName,ContactPerson,Contact1,Contact2,Address,City,State,StateCode,Email,Website,GSTStatus,GSTIN,PANNo,VATNo,CSTNo,ECCNo,IECCode,Company,Pin From Party Where PartyID=@PartyID", ConStr)
        DA.SelectCommand.Parameters.Add("@PartyID", OleDbType.Integer, 4, "PartyID")

        DA.InsertCommand = New OleDbCommand("Insert Into Party (PartyName,ContactPerson,Contact1,Contact2,Address,City,State,StateCode,Email,Website,GSTStatus,GSTIN,PANNo,VATNo,CSTNo,ECCNo,IECCode,Company,Pin) Values (@PartyName,@ContactPerson,@Contact1,@Contact2,@Address,@City,@State,@StateCode,@Email,@Website,@GSTStatus,@GSTIN,@PANNo,@VATNo,@CSTNo,@ECCNo,@IECCode,@Company,@Pin)", ConStr)
        DA.InsertCommand.Parameters.Add("@PartyName", OleDbType.VarChar, 100, "PartyName")
        DA.InsertCommand.Parameters.Add("@ContactPerson", OleDbType.VarChar, 80, "ContactPerson")
        DA.InsertCommand.Parameters.Add("@Contact1", OleDbType.VarChar, 50, "Contact1")
        DA.InsertCommand.Parameters.Add("@Contact2", OleDbType.VarChar, 50, "Contact2")
        DA.InsertCommand.Parameters.Add("@Address", OleDbType.VarChar, 300, "Address")
        DA.InsertCommand.Parameters.Add("@City", OleDbType.VarChar, 150, "City")
        DA.InsertCommand.Parameters.Add("@State", OleDbType.VarChar, 150, "State")
        DA.InsertCommand.Parameters.Add("@StateCode", OleDbType.Integer, 4, "StateCode")
        DA.InsertCommand.Parameters.Add("@Email", OleDbType.VarChar, 100, "Email")
        DA.InsertCommand.Parameters.Add("@Website", OleDbType.VarChar, 100, "Website")
        DA.InsertCommand.Parameters.Add("@GSTStatus", OleDbType.VarChar, 50, "GSTStatus")
        DA.InsertCommand.Parameters.Add("@GSTIN", OleDbType.VarChar, 25, "GSTIN")
        DA.InsertCommand.Parameters.Add("@PANNo", OleDbType.VarChar, 25, "PANNo")
        DA.InsertCommand.Parameters.Add("@VATNo", OleDbType.Integer, 20, "VATNo")
        DA.InsertCommand.Parameters.Add("@CSTNO", OleDbType.Integer, 20, "CSTNO")
        DA.InsertCommand.Parameters.Add("@ECCNO", OleDbType.VarChar, 25, "ECCNO")
        DA.InsertCommand.Parameters.Add("@IECCode", OleDbType.VarChar, 25, "IECCode")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")
        DA.InsertCommand.Parameters.Add("@Pin", OleDbType.Integer, 8, "Pin")

        DA.UpdateCommand = New OleDbCommand("Update Party Set PartyName=@PartyName,ContactPerson=@ContactPerson,Contact1=@Contact1,Contact2=@Contact2,Address=@Address,City=@City,State=@State,StateCode=@StateCode,Email=@Email,Website=@Website,GSTStatus=@GSTStatus,GSTIN=@GSTIN,PANNo=@PANNo,VATNo=@VATNo,CSTNO=@CSTNO,ECCNo=@ECCNo,IECCode=@IECCode,Pin=@Pin Where PartyID=@PartyID", ConStr)
        DA.UpdateCommand.Parameters.Add("@PartyName", OleDbType.VarChar, 100, "PartyName")
        DA.UpdateCommand.Parameters.Add("@ContactPerson", OleDbType.VarChar, 80, "ContactPerson")
        DA.UpdateCommand.Parameters.Add("@Contact1", OleDbType.VarChar, 50, "Contact1")
        DA.UpdateCommand.Parameters.Add("@Contact2", OleDbType.VarChar, 50, "Contact2")
        DA.UpdateCommand.Parameters.Add("@Address", OleDbType.VarChar, 300, "Address")
        DA.UpdateCommand.Parameters.Add("@City", OleDbType.VarChar, 150, "City")
        DA.UpdateCommand.Parameters.Add("@State", OleDbType.VarChar, 150, "State")
        DA.UpdateCommand.Parameters.Add("@StateCode", OleDbType.Integer, 4, "StateCode")
        DA.UpdateCommand.Parameters.Add("@Email", OleDbType.VarChar, 100, "Email")
        DA.UpdateCommand.Parameters.Add("@Website", OleDbType.VarChar, 100, "Website")
        DA.UpdateCommand.Parameters.Add("@GSTStatus", OleDbType.VarChar, 50, "GSTStatus")
        DA.UpdateCommand.Parameters.Add("@GSTIN", OleDbType.VarChar, 25, "GSTIN")
        DA.UpdateCommand.Parameters.Add("@PANNo", OleDbType.VarChar, 25, "PANNo")
        DA.UpdateCommand.Parameters.Add("@VATNo", OleDbType.Integer, 20, "VATNo")
        DA.UpdateCommand.Parameters.Add("@CSTNO", OleDbType.Integer, 20, "CSTNO")
        DA.UpdateCommand.Parameters.Add("@ECCNO", OleDbType.VarChar, 25, "ECCNO")
        DA.UpdateCommand.Parameters.Add("@IECCode", OleDbType.VarChar, 25, "IECCode")
        DA.UpdateCommand.Parameters.Add("@Pin", OleDbType.Integer, 8, "Pin")
        DA.UpdateCommand.Parameters.Add("@PartyID", OleDbType.Integer, 4, "PartyID")

        DA.DeleteCommand = New OleDbCommand("Delete From Party Where PartyID=@PartyID", ConStr)
        DA.DeleteCommand.Parameters.Add("@PartyID", OleDbType.Integer, 4, "PartyID")
        Return True
    End Function

    Function SetBinding()
        BS.DataSource = DS.Tables("Party")
        PartyNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PartyName"))
        ContactPersonTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ContactPerson"))
        Contact1TextEdit.DataBindings.Add(New Binding("EditValue", BS, "Contact1"))
        Contact2TextEdit.DataBindings.Add(New Binding("EditValue", BS, "Contact2"))
        AddressMemoEdit.DataBindings.Add(New Binding("EditValue", BS, "Address"))
        CityTextEdit.DataBindings.Add(New Binding("EditValue", BS, "City"))
        StateTextEdit.DataBindings.Add(New Binding("EditValue", BS, "State"))
        StateCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "StateCode"))
        EmailTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Email"))
        WebsiteTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Website"))
        GSTStatusComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "GSTStatus"))
        GSTINTextEdit.DataBindings.Add(New Binding("EditValue", BS, "GSTIN"))
        PANNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "PANNo"))
        VATNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "VATNo"))
        CSTNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "CSTNo"))
        ECCNoText.DataBindings.Add(New Binding("EditValue", BS, "ECCNo"))
        IECCodeTextEdit.DataBindings.Add(New Binding("EditValue", BS, "IECCode"))
        PinTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Pin"))
        Return True
    End Function

    Sub AddNew()
        BS.AddNew()
        PartyNameTextEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        PartyNameTextEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From Party Where Company = '" + PubCompanyName + "'", "PartyID")
        If ID > 0 Then
            Try
                DS.Tables("Party").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@PartyID").Value = ID
            DA.Fill(DS, "Party")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("Party"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If PartyNameTextEdit.EditValue Is DBNull.Value Or PartyNameTextEdit.EditValue Is "" Then
            PartyNameTextEdit.Focus()
            Return False
        ElseIf AddressMemoEdit.EditValue Is DBNull.Value Then
            AddressMemoEdit.Focus()
            Return False
        ElseIf CityTextEdit.EditValue Is DBNull.Value Then
            CityTextEdit.Focus()
            Return False
        ElseIf StateTextEdit.EditValue Is DBNull.Value Then
            StateTextEdit.Focus()
            Return False
        ElseIf StateCodeTextEdit.EditValue Is DBNull.Value Or StateCodeTextEdit.EditValue Is "" Then
            StateCodeTextEdit.Focus()
            Return False
        ElseIf GSTStatusComboBoxEdit.EditValue Is DBNull.Value Then
            GSTStatusComboBoxEdit.Focus()
            Return False
        ElseIf GSTINTextEdit.EditValue Is DBNull.Value Then
            GSTINTextEdit.Focus()
            Return False
        ElseIf PANNoTextEdit.EditValue Is DBNull.Value Then
            PANNoTextEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.EndEdit()
            DA.Update(DS.Tables("Party"))

            Me.DialogResult = DialogResult.OK
            XtraMessageBox.Show("Party added successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddressMemoEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AddressMemoEdit.Validating
        If Not AddressMemoEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(PartyID) FROM Party WHERE PartyName=@PartyName AND Address=@Address AND PartyID<>@PartyID", ConStr)
                CMD.Parameters.AddWithValue("@PartyName", PartyNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@Address", AddressMemoEdit.EditValue)
                CMD.Parameters.AddWithValue("@PartyID", IIf(BS.Current!PartyID Is DBNull.Value, -1, BS.Current!PartyID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PartyNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
                'ErtOccur(ex)
            End Try
        End If
    End Sub
    Private Sub EmailTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmailTextEdit.Validating
        If EmailTextEdit IsNot DBNull.Value Then
            If Not IsValidEmail(EmailTextEdit.Text) Then
                XtraMessageBox.Show("Not an Email! Enter Valid Email Address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmailTextEdit.Focus()
            End If
        End If
    End Sub
    Private Function IsValidEmail(value As String) As Boolean
        Dim RE As Object
        RE = CreateObject("vbscript.RegExp")
        RE.Pattern = "^[a-zA-Z0-9\._-]+@([a-zA-Z0-9_-]+\.)+([a-zA-Z]{2,3})$"
        IsValidEmail = RE.Test(value)
        RE = Nothing
    End Function

    Private Sub GSTINTextEdit_Leave(sender As Object, e As EventArgs) Handles GSTINTextEdit.Leave
        If GSTINTextEdit.EditValue IsNot DBNull.Value And GSTINTextEdit.Text <> "UNREGISTERED" And GSTINTextEdit.Text <> "" Then
            If GSTINTextEdit.Text.Length <> 15 Then
                XtraMessageBox.Show("Please Enter Valid 15 Character GSTIN", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GSTINTextEdit.Focus()
            End If
        End If
        If GSTINTextEdit.Text = "" Then
            GSTINTextEdit.EditValue = DBNull.Value
        End If
    End Sub

    Private Sub PANNoTextEdit_Leave(sender As Object, e As EventArgs) Handles PANNoTextEdit.Leave
        If PANNoTextEdit.EditValue IsNot DBNull.Value Then
            If PANNoTextEdit.Text.Length <> 10 Then
                XtraMessageBox.Show("Please Enter Valid 10 Character PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PANNoTextEdit.Focus()
            End If
        End If
    End Sub

    Private Sub GSTStatusComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GSTStatusComboBoxEdit.SelectedIndexChanged
        If GSTStatusComboBoxEdit.Text = "Unregistered" Then
            GSTINTextEdit.TabStop = False
            GSTINTextEdit.Properties.ReadOnly = True
            GSTINTextEdit.EditValue = "Unregistered"
        Else
            GSTINTextEdit.TabStop = True
            GSTINTextEdit.Properties.ReadOnly = False
            GSTINTextEdit.EditValue = DBNull.Value
        End If
    End Sub

    Private Sub StateTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StateTextEdit.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    'Dim iNumber As Integer
    'Private Sub Contact1TextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Contact1TextEdit.Validating
    '    If Contact1TextEdit IsNot DBNull.Value Then
    '        If Contact1TextEdit.Text.Length > 12 Then
    '            If Not Integer.TryParse(Contact1TextEdit.Text, iNumber) Then
    '                XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub Contact2TextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Contact2TextEdit.Validating
    '    If Contact2TextEdit IsNot DBNull.Value Then
    '        If Contact2TextEdit.Text.Length > 12 Then
    '            If Not Integer.TryParse(Contact2TextEdit.Text, iNumber) Then
    '                XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End If
    '    End If
    'End Sub
    'Private Sub StateCodeTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles StateCodeTextEdit.Validating
    '    If StateCodeTextEdit IsNot DBNull.Value Then
    '        If Not Integer.TryParse(StateCodeTextEdit.Text, iNumber) Then
    '            XtraMessageBox.Show("Not a Number! Please enter Valid State Code.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            StateCodeTextEdit.Focus()
    '            'e.Cancel = True
    '        End If
    '    End If
    'End Sub
    'Private Sub VATNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VATNoTextEdit.Validating
    '    If VATNoTextEdit IsNot DBNull.Value Then
    '        If Not Integer.TryParse(VATNoTextEdit.Text, iNumber) Then
    '            XtraMessageBox.Show("Please enter Numeric VAT No.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End If
    'End Sub
    'Private Sub CSTNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CSTNoTextEdit.Validating
    '    If CSTNoTextEdit IsNot DBNull.Value Then
    '        If Not Integer.TryParse(CSTNoTextEdit.Text, iNumber) Then
    '            XtraMessageBox.Show("Please enter Numeric CST No.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End If
    'End Sub


    'Private Sub CityTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CityTextEdit.KeyPress
    '    If Not (Asc(e.KeyChar) = 8) Then
    '        If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
    '            e.KeyChar = ChrW(0)
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub StateTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StateTextEdit.KeyPress
    '    If Not (Asc(e.KeyChar) = 8) Then
    '        If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
    '            e.KeyChar = ChrW(0)
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub


    'Private Sub GSTINTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GSTINTextEdit.KeyPress
    '    If GSTINTextEdit.Text.Length > 11 Then
    '        XtraMessageBox.Show("Please Enter Valid GSTIN", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        GSTINTextEdit.Text = ""
    '        GSTINTextEdit.Focus()
    '    End If
    '    If GSTINTextEdit IsNot DBNull.Value Then
    '        Dim allowed As String = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
    '        For Each c As Char In GSTINTextEdit.Text
    '            If allowed.Contains(c) = False Then
    '                XtraMessageBox.Show("Please Enter Valid GSTIN", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                GSTINTextEdit.Text = ""
    '                GSTINTextEdit.Focus()
    '                'GSTINTextEdit.Text = GSTINTextEdit.Text.Remove(GSTINTextEdit.SelectionStart - 1, 1)
    '                'GSTINTextEdit.Select(GSTINTextEdit.Text.Count, 1)
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub PANNoTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PANNoTextEdit.KeyPress
    '    If PANNoTextEdit.Text.Length > 10 Then
    '        XtraMessageBox.Show("Please Enter Valid PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        PANNoTextEdit.Text = ""
    '        PANNoTextEdit.Focus()
    '    End If
    '    If PANNoTextEdit IsNot DBNull.Value Then
    '        Dim allowed As String = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
    '        For Each c As Char In PANNoTextEdit.Text
    '            If allowed.Contains(c) = False Then
    '                XtraMessageBox.Show("Please Enter Valid PAN No", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                PANNoTextEdit.Text = ""
    '                PANNoTextEdit.Focus()
    '                'PANNoTextEdit.Text = PANNoTextEdit.Text.Remove(PANNoTextEdit.SelectionStart - 1, 1)
    '                'PANNoTextEdit.Select(PANNoTextEdit.Text.Count, 0)
    '            End If
    '        Next
    '    End If
    'End Sub
End Class