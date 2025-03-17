<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Invoice

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.XtraForm' is not defined.
    Inherits DevExpress.XtraEditors.XtraForm
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.XtraForm' is not defined.

    'Form overrides dispose to clean up the component list.
#Disable Warning BC30284 ' sub 'Dispose' cannot be declared 'Overrides' because it does not override a sub in a base class.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
#Enable Warning BC30284 ' sub 'Dispose' cannot be declared 'Overrides' because it does not override a sub in a base class.
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Invoice))
        Me.PanelCtrlMain = New DevExpress.XtraEditors.PanelControl()
        Me.EwbValidTillDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.NewBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.OpenBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.DeleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintOriginalPrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintDuplicateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintTriplicateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintOriginalSignBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintTriplicateSignBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.EWayBillPrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintEWBillBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.EWayBillABBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PrintDetailedBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.CloseBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl()
        Me.AckDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl()
        Me.AckNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl()
        Me.GenerateEWBSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl()
        Me.QRCodeMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.EwbNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ModelNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EwbDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.ModelNo = New DevExpress.XtraEditors.LabelControl()
        Me.GenerateEInvoiceSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.MultiVehInfoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MultiVehInfo = New DevExpress.XtraEditors.LabelControl()
        Me.CEWBNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl()
        Me.VehTypeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
        Me.TransportModeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl()
        Me.VehNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl()
        Me.DistanceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl()
        Me.TransNMTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl()
        Me.TransIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.SSCTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl()
        Me.ARNDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.ARNNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.PartyDCDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.PartyDCNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.ChallanNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.InvoiceNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AddNewPartySimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ConsigneePANNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverPANNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.AddressCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TaxInWordsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ModifiedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CreatedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CreatedByLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.ModifiedByLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.AddNewProductSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ConsigneeAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AgainstFormTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.PODateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.POTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.ChallanDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.ConsigneeStateCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverStateCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.ConsigneeNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ReceiverNameComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TotalAmtAfterTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.GSTReverseChargeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TotalGSTTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.IGSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SGSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CGSTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.ConsigneeStateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.ConsigneeGSTINTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverStateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverGSTINTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.SupplyToTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TotalInWordsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TransportationModeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.InvoiceDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.NetAmtLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.InvoiceDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.InvoiceDetailGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TotalAmtBeforeTaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiverAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SendEmailSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.lblAttachment = New DevExpress.XtraEditors.LabelControl()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBoxError = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PackingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.PCGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.PSGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.PIGSTRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.PCGSTAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.PSGSTAmt = New DevExpress.XtraEditors.TextEdit()
        Me.PIGSTAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox2 = New DevExpress.XtraEditors.PictureEdit()
        Me.TxtBoxResp = New DevExpress.XtraEditors.TextEdit()
        Me.MaskedTextBox1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIRN = New DevExpress.XtraEditors.TextEdit()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        CType(Me.EwbValidTillDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EwbValidTillDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AckDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AckDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AckNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRCodeMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EwbNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EwbDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EwbDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrl.SuspendLayout()
        CType(Me.MultiVehInfoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEWBNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehTypeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportModeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistanceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransNMTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSCTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARNDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARNDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARNNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneePANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverPANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgainstFormTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmtAfterTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSTReverseChargeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalGSTTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyToTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportationModeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDetailGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmtBeforeTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBoxError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCGSTAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSGSTAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIGSTAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBoxResp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaskedTextBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIRN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.AllowTouchScroll = True
        Me.PanelCtrlMain.AlwaysScrollActiveControlIntoView = False
        Me.PanelCtrlMain.Controls.Add(Me.EwbValidTillDateEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl58)
        Me.PanelCtrlMain.Controls.Add(Me.AckDateDateEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl59)
        Me.PanelCtrlMain.Controls.Add(Me.AckNoTextEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl65)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl52)
        Me.PanelCtrlMain.Controls.Add(Me.GenerateEWBSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl60)
        Me.PanelCtrlMain.Controls.Add(Me.QRCodeMemoEdit)
        Me.PanelCtrlMain.Controls.Add(Me.EwbNoTextEdit)
        Me.PanelCtrlMain.Controls.Add(Me.ModelNoTextEdit)
        Me.PanelCtrlMain.Controls.Add(Me.EwbDateDateEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl63)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl57)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl64)
        Me.PanelCtrlMain.Controls.Add(Me.Label1)
        Me.PanelCtrlMain.Controls.Add(Me.ModelNo)
        Me.PanelCtrlMain.Controls.Add(Me.GenerateEInvoiceSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.LinkLabel1)
        Me.PanelCtrlMain.Controls.Add(Me.SimpleButton1)
        Me.PanelCtrlMain.Controls.Add(Me.PanelCtrl)
        Me.PanelCtrlMain.Controls.Add(Me.SendEmailSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.lblAttachment)
        Me.PanelCtrlMain.Controls.Add(Me.CancelSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.TxtBoxError)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl56)
        Me.PanelCtrlMain.Controls.Add(Me.SaveSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.PackingTextEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl41)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl42)
        Me.PanelCtrlMain.Controls.Add(Me.PCGSTRateTextEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl43)
        Me.PanelCtrlMain.Controls.Add(Me.PSGSTRateTextEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl44)
        Me.PanelCtrlMain.Controls.Add(Me.PIGSTRateTextEdit)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl45)
        Me.PanelCtrlMain.Controls.Add(Me.PCGSTAmt)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl46)
        Me.PanelCtrlMain.Controls.Add(Me.PSGSTAmt)
        Me.PanelCtrlMain.Controls.Add(Me.PIGSTAmt)
        Me.PanelCtrlMain.Controls.Add(Me.LabelControl47)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(20, 63)
        Me.PanelCtrlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(2259, 1223)
        Me.PanelCtrlMain.TabIndex = 0
        '
        'EwbValidTillDateEdit
        '
        Me.EwbValidTillDateEdit.EditValue = Nothing
        Me.EwbValidTillDateEdit.Location = New System.Drawing.Point(1334, 1147)
        Me.EwbValidTillDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EwbValidTillDateEdit.MenuManager = Me.BarManager1
        Me.EwbValidTillDateEdit.Name = "EwbValidTillDateEdit"
        Me.EwbValidTillDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EwbValidTillDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EwbValidTillDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.EwbValidTillDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EwbValidTillDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.EwbValidTillDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EwbValidTillDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.EwbValidTillDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.EwbValidTillDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.EwbValidTillDateEdit.Size = New System.Drawing.Size(137, 28)
        Me.EwbValidTillDateEdit.TabIndex = 236
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.NewBarButtonItem, Me.OpenBarButtonItem, Me.PrintBarButtonItem, Me.DeleteBarButtonItem, Me.PrintOriginalPrintBarButtonItem, Me.PrintDuplicateBarButtonItem, Me.PrintTriplicateBarButtonItem, Me.PrintOriginalSignBarButtonItem, Me.PrintTriplicateSignBarButtonItem, Me.CloseBarButtonItem, Me.PrintEWBillBarButtonItem, Me.EWayBillABBarButtonItem, Me.PrintDetailedBarButtonItem, Me.EWayBillPrintBarButtonItem})
        Me.BarManager1.MaxItemId = 14
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.NewBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.OpenBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.DeleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintOriginalPrintBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintDuplicateBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintTriplicateBarButtonItem, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintOriginalSignBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PrintTriplicateSignBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.EWayBillPrintBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.PrintEWBillBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.EWayBillABBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.PrintDetailedBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.CloseBarButtonItem)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'NewBarButtonItem
        '
        Me.NewBarButtonItem.Caption = "&New"
        Me.NewBarButtonItem.Id = 0
        Me.NewBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.NewBarButtonItem.ImageOptions.Image = CType(resources.GetObject("NewBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.NewBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("NewBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.NewBarButtonItem.Name = "NewBarButtonItem"
        '
        'OpenBarButtonItem
        '
        Me.OpenBarButtonItem.Caption = "&Open"
        Me.OpenBarButtonItem.Id = 1
        Me.OpenBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.OpenBarButtonItem.ImageOptions.Image = CType(resources.GetObject("OpenBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.OpenBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("OpenBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.OpenBarButtonItem.Name = "OpenBarButtonItem"
        '
        'DeleteBarButtonItem
        '
        Me.DeleteBarButtonItem.Caption = "Delete"
        Me.DeleteBarButtonItem.Id = 3
        Me.DeleteBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.DeleteBarButtonItem.ImageOptions.Image = CType(resources.GetObject("DeleteBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.DeleteBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("DeleteBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.DeleteBarButtonItem.Name = "DeleteBarButtonItem"
        '
        'PrintOriginalPrintBarButtonItem
        '
        Me.PrintOriginalPrintBarButtonItem.Caption = "Print Original"
        Me.PrintOriginalPrintBarButtonItem.Id = 4
        Me.PrintOriginalPrintBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrintOriginalPrintBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintOriginalPrintBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintOriginalPrintBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintOriginalPrintBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintOriginalPrintBarButtonItem.Name = "PrintOriginalPrintBarButtonItem"
        '
        'PrintDuplicateBarButtonItem
        '
        Me.PrintDuplicateBarButtonItem.Caption = "Print Duplicate"
        Me.PrintDuplicateBarButtonItem.Id = 5
        Me.PrintDuplicateBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintDuplicateBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintDuplicateBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintDuplicateBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintDuplicateBarButtonItem.Name = "PrintDuplicateBarButtonItem"
        '
        'PrintTriplicateBarButtonItem
        '
        Me.PrintTriplicateBarButtonItem.Caption = "Print Triplicate"
        Me.PrintTriplicateBarButtonItem.Id = 6
        Me.PrintTriplicateBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintTriplicateBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintTriplicateBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintTriplicateBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintTriplicateBarButtonItem.Name = "PrintTriplicateBarButtonItem"
        '
        'PrintOriginalSignBarButtonItem
        '
        Me.PrintOriginalSignBarButtonItem.Caption = "Print Original Sign"
        Me.PrintOriginalSignBarButtonItem.Id = 7
        Me.PrintOriginalSignBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintOriginalSignBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintOriginalSignBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintOriginalSignBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintOriginalSignBarButtonItem.Name = "PrintOriginalSignBarButtonItem"
        '
        'PrintTriplicateSignBarButtonItem
        '
        Me.PrintTriplicateSignBarButtonItem.Caption = "Print Triplicate Sign"
        Me.PrintTriplicateSignBarButtonItem.Id = 8
        Me.PrintTriplicateSignBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintTriplicateSignBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintTriplicateSignBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintTriplicateSignBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintTriplicateSignBarButtonItem.Name = "PrintTriplicateSignBarButtonItem"
        '
        'EWayBillPrintBarButtonItem
        '
        Me.EWayBillPrintBarButtonItem.Caption = "E-WayBill Print"
        Me.EWayBillPrintBarButtonItem.Id = 13
        Me.EWayBillPrintBarButtonItem.ImageOptions.Image = CType(resources.GetObject("EWayBillPrintBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.EWayBillPrintBarButtonItem.Name = "EWayBillPrintBarButtonItem"
        Me.EWayBillPrintBarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'PrintEWBillBarButtonItem
        '
        Me.PrintEWBillBarButtonItem.Caption = "E-WayBill Part A"
        Me.PrintEWBillBarButtonItem.Id = 10
        Me.PrintEWBillBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintEWBillBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintEWBillBarButtonItem.Name = "PrintEWBillBarButtonItem"
        Me.PrintEWBillBarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.PrintEWBillBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'EWayBillABBarButtonItem
        '
        Me.EWayBillABBarButtonItem.Caption = "E-WayBill Part A B"
        Me.EWayBillABBarButtonItem.Id = 11
        Me.EWayBillABBarButtonItem.ImageOptions.Image = CType(resources.GetObject("EWayBillABBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.EWayBillABBarButtonItem.Name = "EWayBillABBarButtonItem"
        Me.EWayBillABBarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.EWayBillABBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'PrintDetailedBarButtonItem
        '
        Me.PrintDetailedBarButtonItem.Caption = "Detailed E-Way Bill"
        Me.PrintDetailedBarButtonItem.Id = 12
        Me.PrintDetailedBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintDetailedBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintDetailedBarButtonItem.Name = "PrintDetailedBarButtonItem"
        Me.PrintDetailedBarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.PrintDetailedBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'CloseBarButtonItem
        '
        Me.CloseBarButtonItem.Caption = "Close"
        Me.CloseBarButtonItem.Id = 9
        Me.CloseBarButtonItem.ImageOptions.Image = CType(resources.GetObject("CloseBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.CloseBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("CloseBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.CloseBarButtonItem.Name = "CloseBarButtonItem"
        Me.CloseBarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlTop.Size = New System.Drawing.Size(2279, 34)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1286)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlBottom.Size = New System.Drawing.Size(2279, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 34)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 1252)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(2279, 34)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 1252)
        '
        'PrintBarButtonItem
        '
        Me.PrintBarButtonItem.Caption = "Print Bill"
        Me.PrintBarButtonItem.Id = 2
        Me.PrintBarButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrintBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PrintBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PrintBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PrintBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PrintBarButtonItem.Name = "PrintBarButtonItem"
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(13, 988)
        Me.LabelControl58.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(76, 22)
        Me.LabelControl58.TabIndex = 226
        Me.LabelControl58.Text = "QR Code:"
        '
        'AckDateDateEdit
        '
        Me.AckDateDateEdit.EditValue = Nothing
        Me.AckDateDateEdit.Location = New System.Drawing.Point(549, 1147)
        Me.AckDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AckDateDateEdit.MenuManager = Me.BarManager1
        Me.AckDateDateEdit.Name = "AckDateDateEdit"
        Me.AckDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AckDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AckDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.AckDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AckDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.AckDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AckDateDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.AckDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.AckDateDateEdit.Size = New System.Drawing.Size(137, 28)
        Me.AckDateDateEdit.TabIndex = 215
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(454, 1152)
        Me.LabelControl59.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(70, 22)
        Me.LabelControl59.TabIndex = 216
        Me.LabelControl59.Text = "Ack Date"
        '
        'AckNoTextEdit
        '
        Me.AckNoTextEdit.Location = New System.Drawing.Point(96, 1147)
        Me.AckNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AckNoTextEdit.Name = "AckNoTextEdit"
        Me.AckNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.AckNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.AckNoTextEdit.Size = New System.Drawing.Size(340, 28)
        Me.AckNoTextEdit.TabIndex = 214
        Me.AckNoTextEdit.TabStop = False
        '
        'LabelControl65
        '
        Me.LabelControl65.Location = New System.Drawing.Point(1229, 1150)
        Me.LabelControl65.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(94, 22)
        Me.LabelControl65.TabIndex = 233
        Me.LabelControl65.Text = "EwbValidTill"
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(13, 915)
        Me.LabelControl52.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(64, 22)
        Me.LabelControl52.TabIndex = 219
        Me.LabelControl52.Text = "IRN No:"
        '
        'GenerateEWBSimpleButton
        '
        Me.GenerateEWBSimpleButton.ImageOptions.Image = CType(resources.GetObject("GenerateEWBSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.GenerateEWBSimpleButton.Location = New System.Drawing.Point(2183, 1166)
        Me.GenerateEWBSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GenerateEWBSimpleButton.Name = "GenerateEWBSimpleButton"
        Me.GenerateEWBSimpleButton.Size = New System.Drawing.Size(63, 50)
        Me.GenerateEWBSimpleButton.TabIndex = 226
        Me.GenerateEWBSimpleButton.Text = "&Generate E-Way"
        Me.GenerateEWBSimpleButton.Visible = False
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(21, 1150)
        Me.LabelControl60.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(56, 22)
        Me.LabelControl60.TabIndex = 217
        Me.LabelControl60.Text = "Ack No"
        '
        'QRCodeMemoEdit
        '
        Me.QRCodeMemoEdit.Location = New System.Drawing.Point(96, 988)
        Me.QRCodeMemoEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.QRCodeMemoEdit.Name = "QRCodeMemoEdit"
        Me.QRCodeMemoEdit.Size = New System.Drawing.Size(1791, 148)
        Me.QRCodeMemoEdit.TabIndex = 227
        '
        'EwbNoTextEdit
        '
        Me.EwbNoTextEdit.Location = New System.Drawing.Point(769, 1147)
        Me.EwbNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EwbNoTextEdit.Name = "EwbNoTextEdit"
        Me.EwbNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.EwbNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.EwbNoTextEdit.Size = New System.Drawing.Size(211, 28)
        Me.EwbNoTextEdit.TabIndex = 232
        Me.EwbNoTextEdit.TabStop = False
        '
        'ModelNoTextEdit
        '
        Me.ModelNoTextEdit.Location = New System.Drawing.Point(96, 852)
        Me.ModelNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ModelNoTextEdit.Name = "ModelNoTextEdit"
        Me.ModelNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModelNoTextEdit.Size = New System.Drawing.Size(114, 28)
        Me.ModelNoTextEdit.TabIndex = 0
        '
        'EwbDateDateEdit
        '
        Me.EwbDateDateEdit.EditValue = Nothing
        Me.EwbDateDateEdit.Location = New System.Drawing.Point(1080, 1147)
        Me.EwbDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EwbDateDateEdit.MenuManager = Me.BarManager1
        Me.EwbDateDateEdit.Name = "EwbDateDateEdit"
        Me.EwbDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EwbDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EwbDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.EwbDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EwbDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.EwbDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EwbDateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.EwbDateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.EwbDateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.EwbDateDateEdit.Size = New System.Drawing.Size(137, 28)
        Me.EwbDateDateEdit.TabIndex = 233
        '
        'LabelControl63
        '
        Me.LabelControl63.Location = New System.Drawing.Point(987, 1150)
        Me.LabelControl63.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(75, 22)
        Me.LabelControl63.TabIndex = 234
        Me.LabelControl63.Text = "Ewb Date"
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(1306, 836)
        Me.LabelControl57.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(104, 22)
        Me.LabelControl57.TabIndex = 213
        Me.LabelControl57.Text = "Auth Token :"
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(693, 1150)
        Me.LabelControl64.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(65, 22)
        Me.LabelControl64.TabIndex = 235
        Me.LabelControl64.Text = "EWB No"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(1426, 834)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 22)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "Label1"
        '
        'ModelNo
        '
        Me.ModelNo.Location = New System.Drawing.Point(13, 852)
        Me.ModelNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ModelNo.Name = "ModelNo"
        Me.ModelNo.Size = New System.Drawing.Size(75, 22)
        Me.ModelNo.TabIndex = 225
        Me.ModelNo.Text = "Model No"
        '
        'GenerateEInvoiceSimpleButton
        '
        Me.GenerateEInvoiceSimpleButton.ImageOptions.Image = CType(resources.GetObject("GenerateEInvoiceSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.GenerateEInvoiceSimpleButton.Location = New System.Drawing.Point(1039, 836)
        Me.GenerateEInvoiceSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GenerateEInvoiceSimpleButton.Name = "GenerateEInvoiceSimpleButton"
        Me.GenerateEInvoiceSimpleButton.Size = New System.Drawing.Size(220, 50)
        Me.GenerateEInvoiceSimpleButton.TabIndex = 212
        Me.GenerateEInvoiceSimpleButton.Text = "&Generate E-Invoice"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(784, 850)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 22)
        Me.LinkLabel1.TabIndex = 196
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Attach"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(230, 836)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(124, 50)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Save"
        '
        'PanelCtrl
        '
        Me.PanelCtrl.Controls.Add(Me.MultiVehInfoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.MultiVehInfo)
        Me.PanelCtrl.Controls.Add(Me.CEWBNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl74)
        Me.PanelCtrl.Controls.Add(Me.VehTypeRadioGroup)
        Me.PanelCtrl.Controls.Add(Me.TransportModeComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl71)
        Me.PanelCtrl.Controls.Add(Me.VehNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl72)
        Me.PanelCtrl.Controls.Add(Me.LabelControl69)
        Me.PanelCtrl.Controls.Add(Me.DistanceTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl70)
        Me.PanelCtrl.Controls.Add(Me.TransNMTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl68)
        Me.PanelCtrl.Controls.Add(Me.LabelControl67)
        Me.PanelCtrl.Controls.Add(Me.TransIDTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl66)
        Me.PanelCtrl.Controls.Add(Me.LabelControl61)
        Me.PanelCtrl.Controls.Add(Me.SSCTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl62)
        Me.PanelCtrl.Controls.Add(Me.ARNDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl54)
        Me.PanelCtrl.Controls.Add(Me.ARNNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl55)
        Me.PanelCtrl.Controls.Add(Me.PartyDCDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl50)
        Me.PanelCtrl.Controls.Add(Me.PartyDCNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl51)
        Me.PanelCtrl.Controls.Add(Me.ChallanNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.InvoiceNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.AddNewPartySimpleButton)
        Me.PanelCtrl.Controls.Add(Me.ConsigneePANNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl49)
        Me.PanelCtrl.Controls.Add(Me.ReceiverPANNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl48)
        Me.PanelCtrl.Controls.Add(Me.AddressCheckEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl8)
        Me.PanelCtrl.Controls.Add(Me.TaxInWordsTextEdit)
        Me.PanelCtrl.Controls.Add(Me.ModifiedByTextEdit)
        Me.PanelCtrl.Controls.Add(Me.CreatedByTextEdit)
        Me.PanelCtrl.Controls.Add(Me.CreatedByLabelControl)
        Me.PanelCtrl.Controls.Add(Me.ModifiedByLabelControl)
        Me.PanelCtrl.Controls.Add(Me.LabelControl40)
        Me.PanelCtrl.Controls.Add(Me.LabelControl39)
        Me.PanelCtrl.Controls.Add(Me.LabelControl38)
        Me.PanelCtrl.Controls.Add(Me.LabelControl37)
        Me.PanelCtrl.Controls.Add(Me.LabelControl36)
        Me.PanelCtrl.Controls.Add(Me.LabelControl20)
        Me.PanelCtrl.Controls.Add(Me.LabelControl17)
        Me.PanelCtrl.Controls.Add(Me.LabelControl16)
        Me.PanelCtrl.Controls.Add(Me.LabelControl9)
        Me.PanelCtrl.Controls.Add(Me.AddNewProductSimpleButton)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeAddressTextEdit)
        Me.PanelCtrl.Controls.Add(Me.AgainstFormTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl35)
        Me.PanelCtrl.Controls.Add(Me.PODateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl33)
        Me.PanelCtrl.Controls.Add(Me.POTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl34)
        Me.PanelCtrl.Controls.Add(Me.ChallanDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl32)
        Me.PanelCtrl.Controls.Add(Me.LabelControl31)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeStateCodeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl30)
        Me.PanelCtrl.Controls.Add(Me.ReceiverStateCodeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl19)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeNameComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.ReceiverNameComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.TotalAmtAfterTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl18)
        Me.PanelCtrl.Controls.Add(Me.GSTReverseChargeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl14)
        Me.PanelCtrl.Controls.Add(Me.TotalGSTTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl13)
        Me.PanelCtrl.Controls.Add(Me.IGSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.SGSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.CGSTTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl12)
        Me.PanelCtrl.Controls.Add(Me.LabelControl11)
        Me.PanelCtrl.Controls.Add(Me.LabelControl10)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeStateTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl26)
        Me.PanelCtrl.Controls.Add(Me.ConsigneeGSTINTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl27)
        Me.PanelCtrl.Controls.Add(Me.LabelControl28)
        Me.PanelCtrl.Controls.Add(Me.LabelControl29)
        Me.PanelCtrl.Controls.Add(Me.LabelControl25)
        Me.PanelCtrl.Controls.Add(Me.ReceiverStateTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl24)
        Me.PanelCtrl.Controls.Add(Me.ReceiverGSTINTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl23)
        Me.PanelCtrl.Controls.Add(Me.LabelControl22)
        Me.PanelCtrl.Controls.Add(Me.LabelControl21)
        Me.PanelCtrl.Controls.Add(Me.LabelControl15)
        Me.PanelCtrl.Controls.Add(Me.SupplyToTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl2)
        Me.PanelCtrl.Controls.Add(Me.TotalInWordsTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl4)
        Me.PanelCtrl.Controls.Add(Me.RemarksTextEdit)
        Me.PanelCtrl.Controls.Add(Me.TransportationModeTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl5)
        Me.PanelCtrl.Controls.Add(Me.InvoiceDateDateEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl3)
        Me.PanelCtrl.Controls.Add(Me.LabelControl6)
        Me.PanelCtrl.Controls.Add(Me.NetAmtLabelControl)
        Me.PanelCtrl.Controls.Add(Me.InvoiceDetailGridControl)
        Me.PanelCtrl.Controls.Add(Me.TotalAmtBeforeTaxTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl1)
        Me.PanelCtrl.Controls.Add(Me.LabelControl7)
        Me.PanelCtrl.Controls.Add(Me.ReceiverAddressTextEdit)
        Me.PanelCtrl.Location = New System.Drawing.Point(9, 8)
        Me.PanelCtrl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCtrl.Name = "PanelCtrl"
        Me.PanelCtrl.Size = New System.Drawing.Size(2247, 817)
        Me.PanelCtrl.TabIndex = 0
        '
        'MultiVehInfoTextEdit
        '
        Me.MultiVehInfoTextEdit.Location = New System.Drawing.Point(1731, 693)
        Me.MultiVehInfoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MultiVehInfoTextEdit.Name = "MultiVehInfoTextEdit"
        Me.MultiVehInfoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MultiVehInfoTextEdit.Size = New System.Drawing.Size(237, 28)
        Me.MultiVehInfoTextEdit.TabIndex = 35
        Me.MultiVehInfoTextEdit.Visible = False
        '
        'MultiVehInfo
        '
        Me.MultiVehInfo.Location = New System.Drawing.Point(1591, 698)
        Me.MultiVehInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MultiVehInfo.Name = "MultiVehInfo"
        Me.MultiVehInfo.Size = New System.Drawing.Size(118, 22)
        Me.MultiVehInfo.TabIndex = 230
        Me.MultiVehInfo.Text = "Multi Veh. Info"
        Me.MultiVehInfo.Visible = False
        '
        'CEWBNoTextEdit
        '
        Me.CEWBNoTextEdit.Location = New System.Drawing.Point(1400, 693)
        Me.CEWBNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CEWBNoTextEdit.Name = "CEWBNoTextEdit"
        Me.CEWBNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CEWBNoTextEdit.Size = New System.Drawing.Size(177, 28)
        Me.CEWBNoTextEdit.TabIndex = 34
        Me.CEWBNoTextEdit.Visible = False
        '
        'LabelControl74
        '
        Me.LabelControl74.Location = New System.Drawing.Point(1267, 698)
        Me.LabelControl74.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl74.Name = "LabelControl74"
        Me.LabelControl74.Size = New System.Drawing.Size(81, 22)
        Me.LabelControl74.TabIndex = 228
        Me.LabelControl74.Text = "CEWB No."
        Me.LabelControl74.Visible = False
        '
        'VehTypeRadioGroup
        '
        Me.VehTypeRadioGroup.EditValue = "R"
        Me.VehTypeRadioGroup.Location = New System.Drawing.Point(1731, 651)
        Me.VehTypeRadioGroup.MenuManager = Me.BarManager1
        Me.VehTypeRadioGroup.Name = "VehTypeRadioGroup"
        Me.VehTypeRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("O", "ODC"), New DevExpress.XtraEditors.Controls.RadioGroupItem("R", "Regular")})
        Me.VehTypeRadioGroup.Size = New System.Drawing.Size(237, 35)
        Me.VehTypeRadioGroup.TabIndex = 33
        '
        'TransportModeComboBoxEdit
        '
        Me.TransportModeComboBoxEdit.EditValue = "Road"
        Me.TransportModeComboBoxEdit.Location = New System.Drawing.Point(1731, 613)
        Me.TransportModeComboBoxEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TransportModeComboBoxEdit.MenuManager = Me.BarManager1
        Me.TransportModeComboBoxEdit.Name = "TransportModeComboBoxEdit"
        Me.TransportModeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransportModeComboBoxEdit.Properties.DropDownRows = 3
        Me.TransportModeComboBoxEdit.Properties.Items.AddRange(New Object() {"Road", "Rail", "Air", "Ship"})
        Me.TransportModeComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TransportModeComboBoxEdit.Size = New System.Drawing.Size(237, 28)
        Me.TransportModeComboBoxEdit.TabIndex = 31
        '
        'LabelControl71
        '
        Me.LabelControl71.Location = New System.Drawing.Point(1590, 657)
        Me.LabelControl71.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl71.Name = "LabelControl71"
        Me.LabelControl71.Size = New System.Drawing.Size(100, 22)
        Me.LabelControl71.TabIndex = 206
        Me.LabelControl71.Text = "Vehical Type"
        '
        'VehNoTextEdit
        '
        Me.VehNoTextEdit.Location = New System.Drawing.Point(1399, 652)
        Me.VehNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VehNoTextEdit.Name = "VehNoTextEdit"
        Me.VehNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VehNoTextEdit.Size = New System.Drawing.Size(177, 28)
        Me.VehNoTextEdit.TabIndex = 32
        '
        'LabelControl72
        '
        Me.LabelControl72.Location = New System.Drawing.Point(1266, 657)
        Me.LabelControl72.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl72.Name = "LabelControl72"
        Me.LabelControl72.Size = New System.Drawing.Size(83, 22)
        Me.LabelControl72.TabIndex = 204
        Me.LabelControl72.Text = "Vehical No"
        '
        'LabelControl69
        '
        Me.LabelControl69.Location = New System.Drawing.Point(1590, 618)
        Me.LabelControl69.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(117, 22)
        Me.LabelControl69.TabIndex = 202
        Me.LabelControl69.Text = "Tranport Mode"
        '
        'DistanceTextEdit
        '
        Me.DistanceTextEdit.Enabled = False
        Me.DistanceTextEdit.Location = New System.Drawing.Point(1399, 613)
        Me.DistanceTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DistanceTextEdit.Name = "DistanceTextEdit"
        Me.DistanceTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DistanceTextEdit.Size = New System.Drawing.Size(177, 28)
        Me.DistanceTextEdit.TabIndex = 30
        '
        'LabelControl70
        '
        Me.LabelControl70.Location = New System.Drawing.Point(1266, 618)
        Me.LabelControl70.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl70.Name = "LabelControl70"
        Me.LabelControl70.Size = New System.Drawing.Size(66, 22)
        Me.LabelControl70.TabIndex = 200
        Me.LabelControl70.Text = "Distance"
        '
        'TransNMTextEdit
        '
        Me.TransNMTextEdit.Location = New System.Drawing.Point(1731, 575)
        Me.TransNMTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TransNMTextEdit.Name = "TransNMTextEdit"
        Me.TransNMTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TransNMTextEdit.Size = New System.Drawing.Size(237, 28)
        Me.TransNMTextEdit.TabIndex = 29
        '
        'LabelControl68
        '
        Me.LabelControl68.Location = New System.Drawing.Point(1590, 580)
        Me.LabelControl68.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(134, 22)
        Me.LabelControl68.TabIndex = 198
        Me.LabelControl68.Text = "Tranporter Name"
        '
        'LabelControl67
        '
        Me.LabelControl67.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl67.Appearance.Options.UseFont = True
        Me.LabelControl67.Location = New System.Drawing.Point(1263, 547)
        Me.LabelControl67.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(174, 22)
        Me.LabelControl67.TabIndex = 196
        Me.LabelControl67.Text = "Transporter Details"
        '
        'TransIDTextEdit
        '
        Me.TransIDTextEdit.Location = New System.Drawing.Point(1399, 575)
        Me.TransIDTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TransIDTextEdit.Name = "TransIDTextEdit"
        Me.TransIDTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TransIDTextEdit.Size = New System.Drawing.Size(177, 28)
        Me.TransIDTextEdit.TabIndex = 28
        '
        'LabelControl66
        '
        Me.LabelControl66.Location = New System.Drawing.Point(1266, 580)
        Me.LabelControl66.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(108, 22)
        Me.LabelControl66.TabIndex = 195
        Me.LabelControl66.Text = "Tranporter ID"
        '
        'LabelControl61
        '
        Me.LabelControl61.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl61.Appearance.Options.UseForeColor = True
        Me.LabelControl61.Location = New System.Drawing.Point(159, 226)
        Me.LabelControl61.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl61.TabIndex = 193
        Me.LabelControl61.Text = "*"
        '
        'SSCTextEdit
        '
        Me.SSCTextEdit.Location = New System.Drawing.Point(179, 222)
        Me.SSCTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SSCTextEdit.Name = "SSCTextEdit"
        Me.SSCTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SSCTextEdit.Size = New System.Drawing.Size(70, 28)
        Me.SSCTextEdit.TabIndex = 191
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(9, 226)
        Me.LabelControl62.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(145, 22)
        Me.LabelControl62.TabIndex = 192
        Me.LabelControl62.Text = "Supply State Code"
        '
        'ARNDateDateEdit
        '
        Me.ARNDateDateEdit.EditValue = Nothing
        Me.ARNDateDateEdit.Location = New System.Drawing.Point(2056, 339)
        Me.ARNDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ARNDateDateEdit.MenuManager = Me.BarManager1
        Me.ARNDateDateEdit.Name = "ARNDateDateEdit"
        Me.ARNDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ARNDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ARNDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.ARNDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ARNDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.ARNDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ARNDateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.ARNDateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.ARNDateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.ARNDateDateEdit.Size = New System.Drawing.Size(131, 28)
        Me.ARNDateDateEdit.TabIndex = 27
        '
        'LabelControl54
        '
        Me.LabelControl54.Location = New System.Drawing.Point(1921, 346)
        Me.LabelControl54.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(76, 22)
        Me.LabelControl54.TabIndex = 190
        Me.LabelControl54.Text = "ARN Date"
        '
        'ARNNoTextEdit
        '
        Me.ARNNoTextEdit.Location = New System.Drawing.Point(2056, 299)
        Me.ARNNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ARNNoTextEdit.Name = "ARNNoTextEdit"
        Me.ARNNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ARNNoTextEdit.Size = New System.Drawing.Size(131, 28)
        Me.ARNNoTextEdit.TabIndex = 26
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(1921, 303)
        Me.LabelControl55.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(62, 22)
        Me.LabelControl55.TabIndex = 189
        Me.LabelControl55.Text = "ARN No"
        '
        'PartyDCDateDateEdit
        '
        Me.PartyDCDateDateEdit.EditValue = Nothing
        Me.PartyDCDateDateEdit.Location = New System.Drawing.Point(570, 94)
        Me.PartyDCDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PartyDCDateDateEdit.MenuManager = Me.BarManager1
        Me.PartyDCDateDateEdit.Name = "PartyDCDateDateEdit"
        Me.PartyDCDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartyDCDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.PartyDCDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PartyDCDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.PartyDCDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PartyDCDateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.PartyDCDateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.PartyDCDateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.PartyDCDateDateEdit.Size = New System.Drawing.Size(210, 28)
        Me.PartyDCDateDateEdit.TabIndex = 5
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(441, 96)
        Me.LabelControl50.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(111, 22)
        Me.LabelControl50.TabIndex = 178
        Me.LabelControl50.Text = "Party DC Date"
        '
        'PartyDCNoTextEdit
        '
        Me.PartyDCNoTextEdit.Location = New System.Drawing.Point(130, 94)
        Me.PartyDCNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PartyDCNoTextEdit.Name = "PartyDCNoTextEdit"
        Me.PartyDCNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PartyDCNoTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.PartyDCNoTextEdit.TabIndex = 4
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(9, 96)
        Me.LabelControl51.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(97, 22)
        Me.LabelControl51.TabIndex = 177
        Me.LabelControl51.Text = "Party DC No"
        '
        'ChallanNoTextEdit
        '
        Me.ChallanNoTextEdit.Location = New System.Drawing.Point(130, 52)
        Me.ChallanNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChallanNoTextEdit.Name = "ChallanNoTextEdit"
        Me.ChallanNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ChallanNoTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.ChallanNoTextEdit.TabIndex = 2
        '
        'InvoiceNoTextEdit
        '
        Me.InvoiceNoTextEdit.Location = New System.Drawing.Point(130, 8)
        Me.InvoiceNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InvoiceNoTextEdit.Name = "InvoiceNoTextEdit"
        Me.InvoiceNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.InvoiceNoTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.InvoiceNoTextEdit.TabIndex = 0
        '
        'AddNewPartySimpleButton
        '
        Me.AddNewPartySimpleButton.Appearance.Options.UseTextOptions = True
        Me.AddNewPartySimpleButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AddNewPartySimpleButton.Location = New System.Drawing.Point(1377, 2)
        Me.AddNewPartySimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddNewPartySimpleButton.Name = "AddNewPartySimpleButton"
        Me.AddNewPartySimpleButton.Size = New System.Drawing.Size(76, 39)
        Me.AddNewPartySimpleButton.TabIndex = 21
        Me.AddNewPartySimpleButton.TabStop = False
        Me.AddNewPartySimpleButton.Text = "Add"
        '
        'ConsigneePANNoTextEdit
        '
        Me.ConsigneePANNoTextEdit.Location = New System.Drawing.Point(1566, 206)
        Me.ConsigneePANNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConsigneePANNoTextEdit.Name = "ConsigneePANNoTextEdit"
        Me.ConsigneePANNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneePANNoTextEdit.Size = New System.Drawing.Size(197, 28)
        Me.ConsigneePANNoTextEdit.TabIndex = 22
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(1486, 211)
        Me.LabelControl49.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(61, 22)
        Me.LabelControl49.TabIndex = 174
        Me.LabelControl49.Text = "PAN No"
        '
        'ReceiverPANNoTextEdit
        '
        Me.ReceiverPANNoTextEdit.Location = New System.Drawing.Point(880, 207)
        Me.ReceiverPANNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReceiverPANNoTextEdit.Name = "ReceiverPANNoTextEdit"
        Me.ReceiverPANNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverPANNoTextEdit.Size = New System.Drawing.Size(197, 28)
        Me.ReceiverPANNoTextEdit.TabIndex = 16
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(804, 212)
        Me.LabelControl48.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(61, 22)
        Me.LabelControl48.TabIndex = 172
        Me.LabelControl48.Text = "PAN No"
        '
        'AddressCheckEdit
        '
        Me.AddressCheckEdit.Location = New System.Drawing.Point(1084, 211)
        Me.AddressCheckEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddressCheckEdit.MenuManager = Me.BarManager1
        Me.AddressCheckEdit.Name = "AddressCheckEdit"
        Me.AddressCheckEdit.Properties.Caption = "If Billing Address is same as Shipping Address"
        Me.AddressCheckEdit.Size = New System.Drawing.Size(401, 27)
        Me.AddressCheckEdit.TabIndex = 17
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(1273, 778)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(108, 22)
        Me.LabelControl8.TabIndex = 136
        Me.LabelControl8.Text = "Tax In Words"
        '
        'TaxInWordsTextEdit
        '
        Me.TaxInWordsTextEdit.Location = New System.Drawing.Point(1391, 773)
        Me.TaxInWordsTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TaxInWordsTextEdit.Name = "TaxInWordsTextEdit"
        Me.TaxInWordsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TaxInWordsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TaxInWordsTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TaxInWordsTextEdit.Properties.ReadOnly = True
        Me.TaxInWordsTextEdit.Size = New System.Drawing.Size(840, 28)
        Me.TaxInWordsTextEdit.TabIndex = 135
        Me.TaxInWordsTextEdit.TabStop = False
        '
        'ModifiedByTextEdit
        '
        Me.ModifiedByTextEdit.Location = New System.Drawing.Point(2056, 427)
        Me.ModifiedByTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifiedByTextEdit.Name = "ModifiedByTextEdit"
        Me.ModifiedByTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ModifiedByTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ModifiedByTextEdit.Properties.ReadOnly = True
        Me.ModifiedByTextEdit.Size = New System.Drawing.Size(131, 28)
        Me.ModifiedByTextEdit.TabIndex = 165
        Me.ModifiedByTextEdit.TabStop = False
        '
        'CreatedByTextEdit
        '
        Me.CreatedByTextEdit.Location = New System.Drawing.Point(2056, 383)
        Me.CreatedByTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CreatedByTextEdit.Name = "CreatedByTextEdit"
        Me.CreatedByTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreatedByTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CreatedByTextEdit.Properties.ReadOnly = True
        Me.CreatedByTextEdit.Size = New System.Drawing.Size(131, 28)
        Me.CreatedByTextEdit.TabIndex = 164
        Me.CreatedByTextEdit.TabStop = False
        '
        'CreatedByLabelControl
        '
        Me.CreatedByLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CreatedByLabelControl.Appearance.Options.UseFont = True
        Me.CreatedByLabelControl.Location = New System.Drawing.Point(1921, 390)
        Me.CreatedByLabelControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CreatedByLabelControl.Name = "CreatedByLabelControl"
        Me.CreatedByLabelControl.Size = New System.Drawing.Size(109, 21)
        Me.CreatedByLabelControl.TabIndex = 163
        Me.CreatedByLabelControl.Text = "Created By : "
        '
        'ModifiedByLabelControl
        '
        Me.ModifiedByLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ModifiedByLabelControl.Appearance.Options.UseFont = True
        Me.ModifiedByLabelControl.Location = New System.Drawing.Point(1921, 434)
        Me.ModifiedByLabelControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifiedByLabelControl.Name = "ModifiedByLabelControl"
        Me.ModifiedByLabelControl.Size = New System.Drawing.Size(118, 21)
        Me.ModifiedByLabelControl.TabIndex = 162
        Me.ModifiedByLabelControl.Text = "Modified By : "
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl40.Appearance.Options.UseForeColor = True
        Me.LabelControl40.Location = New System.Drawing.Point(63, 146)
        Me.LabelControl40.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl40.TabIndex = 143
        Me.LabelControl40.Text = "*"
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl39.Appearance.Options.UseForeColor = True
        Me.LabelControl39.Location = New System.Drawing.Point(1541, 64)
        Me.LabelControl39.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl39.TabIndex = 142
        Me.LabelControl39.Text = "*"
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl38.Appearance.Options.UseForeColor = True
        Me.LabelControl38.Location = New System.Drawing.Point(860, 66)
        Me.LabelControl38.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl38.TabIndex = 141
        Me.LabelControl38.Text = "*"
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl37.Appearance.Options.UseForeColor = True
        Me.LabelControl37.Location = New System.Drawing.Point(490, 19)
        Me.LabelControl37.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl37.TabIndex = 140
        Me.LabelControl37.Text = "*"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl36.Appearance.Options.UseForeColor = True
        Me.LabelControl36.Location = New System.Drawing.Point(97, 193)
        Me.LabelControl36.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl36.TabIndex = 139
        Me.LabelControl36.Text = "*"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(524, 145)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl20.TabIndex = 138
        Me.LabelControl20.Text = "*"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(549, 63)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl17.TabIndex = 137
        Me.LabelControl17.Text = "*"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(100, 63)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl16.TabIndex = 136
        Me.LabelControl16.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(103, 17)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl9.TabIndex = 135
        Me.LabelControl9.Text = "*"
        '
        'AddNewProductSimpleButton
        '
        Me.AddNewProductSimpleButton.Location = New System.Drawing.Point(9, 258)
        Me.AddNewProductSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddNewProductSimpleButton.Name = "AddNewProductSimpleButton"
        Me.AddNewProductSimpleButton.Size = New System.Drawing.Size(411, 39)
        Me.AddNewProductSimpleButton.TabIndex = 24
        Me.AddNewProductSimpleButton.TabStop = False
        Me.AddNewProductSimpleButton.Text = "Add New Product"
        '
        'ConsigneeAddressTextEdit
        '
        Me.ConsigneeAddressTextEdit.Location = New System.Drawing.Point(1566, 107)
        Me.ConsigneeAddressTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConsigneeAddressTextEdit.Name = "ConsigneeAddressTextEdit"
        Me.ConsigneeAddressTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeAddressTextEdit.Size = New System.Drawing.Size(626, 28)
        Me.ConsigneeAddressTextEdit.TabIndex = 19
        '
        'AgainstFormTextEdit
        '
        Me.AgainstFormTextEdit.Enabled = False
        Me.AgainstFormTextEdit.Location = New System.Drawing.Point(570, 182)
        Me.AgainstFormTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AgainstFormTextEdit.Name = "AgainstFormTextEdit"
        Me.AgainstFormTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AgainstFormTextEdit.Size = New System.Drawing.Size(210, 28)
        Me.AgainstFormTextEdit.TabIndex = 9
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(441, 189)
        Me.LabelControl35.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(96, 22)
        Me.LabelControl35.TabIndex = 132
        Me.LabelControl35.Text = "Way Bill No."
        '
        'PODateDateEdit
        '
        Me.PODateDateEdit.EditValue = Nothing
        Me.PODateDateEdit.Location = New System.Drawing.Point(570, 140)
        Me.PODateDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PODateDateEdit.MenuManager = Me.BarManager1
        Me.PODateDateEdit.Name = "PODateDateEdit"
        Me.PODateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PODateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PODateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.PODateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PODateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.PODateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PODateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.PODateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.PODateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.PODateDateEdit.Size = New System.Drawing.Size(210, 28)
        Me.PODateDateEdit.TabIndex = 7
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(441, 140)
        Me.LabelControl33.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(65, 22)
        Me.LabelControl33.TabIndex = 130
        Me.LabelControl33.Text = "PO Date"
        '
        'POTextEdit
        '
        Me.POTextEdit.Location = New System.Drawing.Point(130, 140)
        Me.POTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.POTextEdit.Name = "POTextEdit"
        Me.POTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.POTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.POTextEdit.TabIndex = 6
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(9, 140)
        Me.LabelControl34.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(39, 22)
        Me.LabelControl34.TabIndex = 128
        Me.LabelControl34.Text = "P. O."
        '
        'ChallanDateDateEdit
        '
        Me.ChallanDateDateEdit.EditValue = Nothing
        Me.ChallanDateDateEdit.Location = New System.Drawing.Point(570, 52)
        Me.ChallanDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChallanDateDateEdit.MenuManager = Me.BarManager1
        Me.ChallanDateDateEdit.Name = "ChallanDateDateEdit"
        Me.ChallanDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.ChallanDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChallanDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.ChallanDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ChallanDateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.ChallanDateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.ChallanDateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.ChallanDateDateEdit.Size = New System.Drawing.Size(210, 28)
        Me.ChallanDateDateEdit.TabIndex = 3
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(441, 58)
        Me.LabelControl32.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(99, 22)
        Me.LabelControl32.TabIndex = 126
        Me.LabelControl32.Text = "Challan Date"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(4, 58)
        Me.LabelControl31.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(85, 22)
        Me.LabelControl31.TabIndex = 124
        Me.LabelControl31.Text = "Challan No"
        '
        'ConsigneeStateCodeTextEdit
        '
        Me.ConsigneeStateCodeTextEdit.Location = New System.Drawing.Point(1873, 204)
        Me.ConsigneeStateCodeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConsigneeStateCodeTextEdit.Name = "ConsigneeStateCodeTextEdit"
        Me.ConsigneeStateCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeStateCodeTextEdit.Size = New System.Drawing.Size(97, 28)
        Me.ConsigneeStateCodeTextEdit.TabIndex = 23
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(1773, 211)
        Me.LabelControl30.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(86, 22)
        Me.LabelControl30.TabIndex = 122
        Me.LabelControl30.Text = "State Code"
        '
        'ReceiverStateCodeTextEdit
        '
        Me.ReceiverStateCodeTextEdit.Location = New System.Drawing.Point(1397, 159)
        Me.ReceiverStateCodeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReceiverStateCodeTextEdit.Name = "ReceiverStateCodeTextEdit"
        Me.ReceiverStateCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverStateCodeTextEdit.Size = New System.Drawing.Size(56, 28)
        Me.ReceiverStateCodeTextEdit.TabIndex = 15
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(1297, 167)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(86, 22)
        Me.LabelControl19.TabIndex = 120
        Me.LabelControl19.Text = "State Code"
        '
        'ConsigneeNameComboBoxEdit
        '
        Me.ConsigneeNameComboBoxEdit.Location = New System.Drawing.Point(1566, 57)
        Me.ConsigneeNameComboBoxEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConsigneeNameComboBoxEdit.MenuManager = Me.BarManager1
        Me.ConsigneeNameComboBoxEdit.Name = "ConsigneeNameComboBoxEdit"
        Me.ConsigneeNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConsigneeNameComboBoxEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeNameComboBoxEdit.Size = New System.Drawing.Size(626, 28)
        Me.ConsigneeNameComboBoxEdit.TabIndex = 18
        '
        'ReceiverNameComboBoxEdit
        '
        Me.ReceiverNameComboBoxEdit.Location = New System.Drawing.Point(881, 58)
        Me.ReceiverNameComboBoxEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReceiverNameComboBoxEdit.MenuManager = Me.BarManager1
        Me.ReceiverNameComboBoxEdit.Name = "ReceiverNameComboBoxEdit"
        Me.ReceiverNameComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReceiverNameComboBoxEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverNameComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ReceiverNameComboBoxEdit.Size = New System.Drawing.Size(570, 28)
        Me.ReceiverNameComboBoxEdit.TabIndex = 11
        '
        'TotalAmtAfterTaxTextEdit
        '
        Me.TotalAmtAfterTaxTextEdit.Location = New System.Drawing.Point(711, 607)
        Me.TotalAmtAfterTaxTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalAmtAfterTaxTextEdit.Name = "TotalAmtAfterTaxTextEdit"
        Me.TotalAmtAfterTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalAmtAfterTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalAmtAfterTaxTextEdit.Properties.ReadOnly = True
        Me.TotalAmtAfterTaxTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.TotalAmtAfterTaxTextEdit.TabIndex = 29
        Me.TotalAmtAfterTaxTextEdit.TabStop = False
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(441, 611)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(187, 22)
        Me.LabelControl18.TabIndex = 115
        Me.LabelControl18.Text = "Total Amount After Tax"
        '
        'GSTReverseChargeTextEdit
        '
        Me.GSTReverseChargeTextEdit.Location = New System.Drawing.Point(711, 647)
        Me.GSTReverseChargeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GSTReverseChargeTextEdit.Name = "GSTReverseChargeTextEdit"
        Me.GSTReverseChargeTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.GSTReverseChargeTextEdit.TabIndex = 25
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(441, 654)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(253, 22)
        Me.LabelControl14.TabIndex = 114
        Me.LabelControl14.Text = "GST Payable on Reverse Charge"
        '
        'TotalGSTTaxTextEdit
        '
        Me.TotalGSTTaxTextEdit.Location = New System.Drawing.Point(711, 563)
        Me.TotalGSTTaxTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalGSTTaxTextEdit.Name = "TotalGSTTaxTextEdit"
        Me.TotalGSTTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalGSTTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalGSTTaxTextEdit.Properties.ReadOnly = True
        Me.TotalGSTTaxTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.TotalGSTTaxTextEdit.TabIndex = 28
        Me.TotalGSTTaxTextEdit.TabStop = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(441, 567)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(147, 22)
        Me.LabelControl13.TabIndex = 111
        Me.LabelControl13.Text = "Total Amount:GST"
        '
        'IGSTTextEdit
        '
        Me.IGSTTextEdit.Location = New System.Drawing.Point(221, 684)
        Me.IGSTTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IGSTTextEdit.Name = "IGSTTextEdit"
        Me.IGSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IGSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IGSTTextEdit.Properties.ReadOnly = True
        Me.IGSTTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.IGSTTextEdit.TabIndex = 27
        Me.IGSTTextEdit.TabStop = False
        '
        'SGSTTextEdit
        '
        Me.SGSTTextEdit.Location = New System.Drawing.Point(221, 640)
        Me.SGSTTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SGSTTextEdit.Name = "SGSTTextEdit"
        Me.SGSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SGSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.SGSTTextEdit.Properties.ReadOnly = True
        Me.SGSTTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.SGSTTextEdit.TabIndex = 26
        Me.SGSTTextEdit.TabStop = False
        '
        'CGSTTextEdit
        '
        Me.CGSTTextEdit.Location = New System.Drawing.Point(221, 596)
        Me.CGSTTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CGSTTextEdit.Name = "CGSTTextEdit"
        Me.CGSTTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CGSTTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CGSTTextEdit.Properties.ReadOnly = True
        Me.CGSTTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.CGSTTextEdit.TabIndex = 25
        Me.CGSTTextEdit.TabStop = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(10, 688)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 22)
        Me.LabelControl12.TabIndex = 107
        Me.LabelControl12.Text = "Total IGST"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(10, 644)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(89, 22)
        Me.LabelControl11.TabIndex = 105
        Me.LabelControl11.Text = "Total SGST"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(10, 600)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(90, 22)
        Me.LabelControl10.TabIndex = 103
        Me.LabelControl10.Text = "Total CGST"
        '
        'ConsigneeStateTextEdit
        '
        Me.ConsigneeStateTextEdit.Location = New System.Drawing.Point(1826, 157)
        Me.ConsigneeStateTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConsigneeStateTextEdit.Name = "ConsigneeStateTextEdit"
        Me.ConsigneeStateTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeStateTextEdit.Size = New System.Drawing.Size(144, 28)
        Me.ConsigneeStateTextEdit.TabIndex = 21
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(1773, 163)
        Me.LabelControl26.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(40, 22)
        Me.LabelControl26.TabIndex = 100
        Me.LabelControl26.Text = "State"
        '
        'ConsigneeGSTINTextEdit
        '
        Me.ConsigneeGSTINTextEdit.Location = New System.Drawing.Point(1566, 157)
        Me.ConsigneeGSTINTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConsigneeGSTINTextEdit.Name = "ConsigneeGSTINTextEdit"
        Me.ConsigneeGSTINTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConsigneeGSTINTextEdit.Size = New System.Drawing.Size(197, 28)
        Me.ConsigneeGSTINTextEdit.TabIndex = 20
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(1486, 163)
        Me.LabelControl27.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(52, 22)
        Me.LabelControl27.TabIndex = 98
        Me.LabelControl27.Text = "GSTIN"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(1486, 108)
        Me.LabelControl28.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(62, 22)
        Me.LabelControl28.TabIndex = 95
        Me.LabelControl28.Text = "Address"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(1486, 61)
        Me.LabelControl29.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(45, 22)
        Me.LabelControl29.TabIndex = 94
        Me.LabelControl29.Text = "Name"
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Location = New System.Drawing.Point(1487, 5)
        Me.LabelControl25.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(144, 29)
        Me.LabelControl25.TabIndex = 92
        Me.LabelControl25.Text = "Shipped to :"
        '
        'ReceiverStateTextEdit
        '
        Me.ReceiverStateTextEdit.Location = New System.Drawing.Point(1141, 159)
        Me.ReceiverStateTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReceiverStateTextEdit.Name = "ReceiverStateTextEdit"
        Me.ReceiverStateTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverStateTextEdit.Size = New System.Drawing.Size(144, 28)
        Me.ReceiverStateTextEdit.TabIndex = 14
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(1089, 167)
        Me.LabelControl24.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(40, 22)
        Me.LabelControl24.TabIndex = 91
        Me.LabelControl24.Text = "State"
        '
        'ReceiverGSTINTextEdit
        '
        Me.ReceiverGSTINTextEdit.Location = New System.Drawing.Point(881, 159)
        Me.ReceiverGSTINTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReceiverGSTINTextEdit.Name = "ReceiverGSTINTextEdit"
        Me.ReceiverGSTINTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverGSTINTextEdit.Size = New System.Drawing.Size(197, 28)
        Me.ReceiverGSTINTextEdit.TabIndex = 13
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(807, 167)
        Me.LabelControl23.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(52, 22)
        Me.LabelControl23.TabIndex = 89
        Me.LabelControl23.Text = "GSTIN"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(807, 112)
        Me.LabelControl22.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(62, 22)
        Me.LabelControl22.TabIndex = 86
        Me.LabelControl22.Text = "Address"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(807, 5)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(114, 29)
        Me.LabelControl21.TabIndex = 84
        Me.LabelControl21.Text = "Billed to :"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(807, 63)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(45, 22)
        Me.LabelControl15.TabIndex = 83
        Me.LabelControl15.Text = "Name"
        '
        'SupplyToTextEdit
        '
        Me.SupplyToTextEdit.Location = New System.Drawing.Point(130, 182)
        Me.SupplyToTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SupplyToTextEdit.Name = "SupplyToTextEdit"
        Me.SupplyToTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SupplyToTextEdit.Size = New System.Drawing.Size(290, 28)
        Me.SupplyToTextEdit.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 189)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 22)
        Me.LabelControl2.TabIndex = 81
        Me.LabelControl2.Text = "Supply To"
        '
        'TotalInWordsTextEdit
        '
        Me.TotalInWordsTextEdit.Location = New System.Drawing.Point(221, 773)
        Me.TotalInWordsTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalInWordsTextEdit.Name = "TotalInWordsTextEdit"
        Me.TotalInWordsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalInWordsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalInWordsTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalInWordsTextEdit.Properties.ReadOnly = True
        Me.TotalInWordsTextEdit.Size = New System.Drawing.Size(1041, 28)
        Me.TotalInWordsTextEdit.TabIndex = 32
        Me.TotalInWordsTextEdit.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 778)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(136, 22)
        Me.LabelControl4.TabIndex = 51
        Me.LabelControl4.Text = "Rupees In Words"
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.Location = New System.Drawing.Point(221, 729)
        Me.RemarksTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RemarksTextEdit.Size = New System.Drawing.Size(2010, 28)
        Me.RemarksTextEdit.TabIndex = 36
        '
        'TransportationModeTextEdit
        '
        Me.TransportationModeTextEdit.Location = New System.Drawing.Point(570, 228)
        Me.TransportationModeTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TransportationModeTextEdit.Name = "TransportationModeTextEdit"
        Me.TransportationModeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TransportationModeTextEdit.Size = New System.Drawing.Size(210, 28)
        Me.TransportationModeTextEdit.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(441, 234)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "Trans. Mode"
        '
        'InvoiceDateDateEdit
        '
        Me.InvoiceDateDateEdit.EditValue = Nothing
        Me.InvoiceDateDateEdit.Location = New System.Drawing.Point(570, 8)
        Me.InvoiceDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InvoiceDateDateEdit.MenuManager = Me.BarManager1
        Me.InvoiceDateDateEdit.Name = "InvoiceDateDateEdit"
        Me.InvoiceDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.InvoiceDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InvoiceDateDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.InvoiceDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.InvoiceDateDateEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.InvoiceDateDateEdit.Properties.MaskSettings.Set("useAdvancingCaret", True)
        Me.InvoiceDateDateEdit.Properties.MaskSettings.Set("mask", "dd-MM-yyyy")
        Me.InvoiceDateDateEdit.Size = New System.Drawing.Size(209, 28)
        Me.InvoiceDateDateEdit.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(441, 14)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 22)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Date"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 734)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(67, 22)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Remarks"
        '
        'NetAmtLabelControl
        '
        Me.NetAmtLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NetAmtLabelControl.Appearance.Options.UseFont = True
        Me.NetAmtLabelControl.Location = New System.Drawing.Point(951, 610)
        Me.NetAmtLabelControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NetAmtLabelControl.Name = "NetAmtLabelControl"
        Me.NetAmtLabelControl.Size = New System.Drawing.Size(96, 22)
        Me.NetAmtLabelControl.TabIndex = 11
        Me.NetAmtLabelControl.Text = "Grand Amt"
        '
        'InvoiceDetailGridControl
        '
        Me.InvoiceDetailGridControl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InvoiceDetailGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InvoiceDetailGridControl.Location = New System.Drawing.Point(9, 303)
        Me.InvoiceDetailGridControl.MainView = Me.InvoiceDetailGridView
        Me.InvoiceDetailGridControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InvoiceDetailGridControl.MenuManager = Me.BarManager1
        Me.InvoiceDetailGridControl.Name = "InvoiceDetailGridControl"
        Me.InvoiceDetailGridControl.Size = New System.Drawing.Size(1900, 242)
        Me.InvoiceDetailGridControl.TabIndex = 24
        Me.InvoiceDetailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.InvoiceDetailGridView})
        '
        'InvoiceDetailGridView
        '
        Me.InvoiceDetailGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.InvoiceDetailGridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.InvoiceDetailGridView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.InvoiceDetailGridView.Appearance.OddRow.Options.UseBackColor = True
        Me.InvoiceDetailGridView.DetailHeight = 405
        Me.InvoiceDetailGridView.GridControl = Me.InvoiceDetailGridControl
        Me.InvoiceDetailGridView.Name = "InvoiceDetailGridView"
        Me.InvoiceDetailGridView.OptionsCustomization.AllowColumnMoving = False
        Me.InvoiceDetailGridView.OptionsCustomization.AllowFilter = False
        Me.InvoiceDetailGridView.OptionsCustomization.AllowSort = False
        Me.InvoiceDetailGridView.OptionsEditForm.PopupEditFormWidth = 889
        Me.InvoiceDetailGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.InvoiceDetailGridView.OptionsView.ColumnAutoWidth = False
        Me.InvoiceDetailGridView.OptionsView.EnableAppearanceEvenRow = True
        Me.InvoiceDetailGridView.OptionsView.EnableAppearanceOddRow = True
        Me.InvoiceDetailGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.InvoiceDetailGridView.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.InvoiceDetailGridView.OptionsView.ShowGroupPanel = False
        Me.InvoiceDetailGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.InvoiceDetailGridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'TotalAmtBeforeTaxTextEdit
        '
        Me.TotalAmtBeforeTaxTextEdit.Location = New System.Drawing.Point(221, 555)
        Me.TotalAmtBeforeTaxTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalAmtBeforeTaxTextEdit.Name = "TotalAmtBeforeTaxTextEdit"
        Me.TotalAmtBeforeTaxTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalAmtBeforeTaxTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TotalAmtBeforeTaxTextEdit.Properties.ReadOnly = True
        Me.TotalAmtBeforeTaxTextEdit.Size = New System.Drawing.Size(193, 28)
        Me.TotalAmtBeforeTaxTextEdit.TabIndex = 19
        Me.TotalAmtBeforeTaxTextEdit.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 14)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 22)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Invoice No"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(10, 559)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(200, 22)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Total Amount Before Tax"
        '
        'ReceiverAddressTextEdit
        '
        Me.ReceiverAddressTextEdit.Location = New System.Drawing.Point(881, 108)
        Me.ReceiverAddressTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReceiverAddressTextEdit.Name = "ReceiverAddressTextEdit"
        Me.ReceiverAddressTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReceiverAddressTextEdit.Size = New System.Drawing.Size(570, 28)
        Me.ReceiverAddressTextEdit.TabIndex = 12
        '
        'SendEmailSimpleButton
        '
        Me.SendEmailSimpleButton.ImageOptions.Image = CType(resources.GetObject("SendEmailSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.SendEmailSimpleButton.Location = New System.Drawing.Point(861, 836)
        Me.SendEmailSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendEmailSimpleButton.Name = "SendEmailSimpleButton"
        Me.SendEmailSimpleButton.Size = New System.Drawing.Size(159, 50)
        Me.SendEmailSimpleButton.TabIndex = 194
        Me.SendEmailSimpleButton.Text = "&Send Email"
        '
        'lblAttachment
        '
        Me.lblAttachment.Location = New System.Drawing.Point(679, 850)
        Me.lblAttachment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(90, 22)
        Me.lblAttachment.TabIndex = 195
        Me.lblAttachment.Text = "Attachment"
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.ImageOptions.Image = CType(resources.GetObject("CancelSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(530, 836)
        Me.CancelSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(124, 50)
        Me.CancelSimpleButton.TabIndex = 3
        Me.CancelSimpleButton.Text = "&Cancel"
        '
        'TxtBoxError
        '
        Me.TxtBoxError.Location = New System.Drawing.Point(1359, 869)
        Me.TxtBoxError.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxError.Name = "TxtBoxError"
        Me.TxtBoxError.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBoxError.Size = New System.Drawing.Size(801, 28)
        Me.TxtBoxError.TabIndex = 222
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(1306, 872)
        Me.LabelControl56.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(38, 22)
        Me.LabelControl56.TabIndex = 223
        Me.LabelControl56.Text = "Error"
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.ImageOptions.Image = CType(resources.GetObject("SaveSimpleButton.ImageOptions.Image"), System.Drawing.Image)
        Me.SaveSimpleButton.Location = New System.Drawing.Point(364, 836)
        Me.SaveSimpleButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(156, 50)
        Me.SaveSimpleButton.TabIndex = 2
        Me.SaveSimpleButton.Text = "&Save 'n' New"
        '
        'PackingTextEdit
        '
        Me.PackingTextEdit.Location = New System.Drawing.Point(337, 1080)
        Me.PackingTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PackingTextEdit.Name = "PackingTextEdit"
        Me.PackingTextEdit.Size = New System.Drawing.Size(323, 28)
        Me.PackingTextEdit.TabIndex = 25
        Me.PackingTextEdit.Visible = False
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(139, 1086)
        Me.LabelControl41.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(129, 22)
        Me.LabelControl41.TabIndex = 145
        Me.LabelControl41.Text = "Packing Charges"
        Me.LabelControl41.Visible = False
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(139, 1004)
        Me.LabelControl42.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(68, 22)
        Me.LabelControl42.TabIndex = 147
        Me.LabelControl42.Text = "CGST %"
        Me.LabelControl42.Visible = False
        '
        'PCGSTRateTextEdit
        '
        Me.PCGSTRateTextEdit.Location = New System.Drawing.Point(239, 998)
        Me.PCGSTRateTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PCGSTRateTextEdit.Name = "PCGSTRateTextEdit"
        Me.PCGSTRateTextEdit.Size = New System.Drawing.Size(69, 28)
        Me.PCGSTRateTextEdit.TabIndex = 26
        Me.PCGSTRateTextEdit.Visible = False
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(317, 1004)
        Me.LabelControl43.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(67, 22)
        Me.LabelControl43.TabIndex = 149
        Me.LabelControl43.Text = "SGST %"
        Me.LabelControl43.Visible = False
        '
        'PSGSTRateTextEdit
        '
        Me.PSGSTRateTextEdit.Location = New System.Drawing.Point(416, 999)
        Me.PSGSTRateTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PSGSTRateTextEdit.Name = "PSGSTRateTextEdit"
        Me.PSGSTRateTextEdit.Size = New System.Drawing.Size(69, 28)
        Me.PSGSTRateTextEdit.TabIndex = 27
        Me.PSGSTRateTextEdit.Visible = False
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(503, 1004)
        Me.LabelControl44.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(64, 22)
        Me.LabelControl44.TabIndex = 151
        Me.LabelControl44.Text = "IGST %"
        Me.LabelControl44.Visible = False
        '
        'PIGSTRateTextEdit
        '
        Me.PIGSTRateTextEdit.Location = New System.Drawing.Point(591, 999)
        Me.PIGSTRateTextEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PIGSTRateTextEdit.Name = "PIGSTRateTextEdit"
        Me.PIGSTRateTextEdit.Size = New System.Drawing.Size(69, 28)
        Me.PIGSTRateTextEdit.TabIndex = 27
        Me.PIGSTRateTextEdit.Visible = False
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(139, 1047)
        Me.LabelControl45.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(82, 22)
        Me.LabelControl45.TabIndex = 154
        Me.LabelControl45.Text = "CGST Amt"
        Me.LabelControl45.Visible = False
        '
        'PCGSTAmt
        '
        Me.PCGSTAmt.Location = New System.Drawing.Point(239, 1042)
        Me.PCGSTAmt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PCGSTAmt.Name = "PCGSTAmt"
        Me.PCGSTAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PCGSTAmt.Properties.Appearance.Options.UseBackColor = True
        Me.PCGSTAmt.Properties.ReadOnly = True
        Me.PCGSTAmt.Size = New System.Drawing.Size(69, 28)
        Me.PCGSTAmt.TabIndex = 153
        Me.PCGSTAmt.TabStop = False
        Me.PCGSTAmt.Visible = False
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(317, 1047)
        Me.LabelControl46.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(81, 22)
        Me.LabelControl46.TabIndex = 156
        Me.LabelControl46.Text = "SGST Amt"
        Me.LabelControl46.Visible = False
        '
        'PSGSTAmt
        '
        Me.PSGSTAmt.Location = New System.Drawing.Point(416, 1042)
        Me.PSGSTAmt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PSGSTAmt.Name = "PSGSTAmt"
        Me.PSGSTAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PSGSTAmt.Properties.Appearance.Options.UseBackColor = True
        Me.PSGSTAmt.Properties.ReadOnly = True
        Me.PSGSTAmt.Size = New System.Drawing.Size(69, 28)
        Me.PSGSTAmt.TabIndex = 155
        Me.PSGSTAmt.TabStop = False
        Me.PSGSTAmt.Visible = False
        '
        'PIGSTAmt
        '
        Me.PIGSTAmt.Location = New System.Drawing.Point(591, 1042)
        Me.PIGSTAmt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PIGSTAmt.Name = "PIGSTAmt"
        Me.PIGSTAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PIGSTAmt.Properties.Appearance.Options.UseBackColor = True
        Me.PIGSTAmt.Properties.ReadOnly = True
        Me.PIGSTAmt.Size = New System.Drawing.Size(69, 28)
        Me.PIGSTAmt.TabIndex = 157
        Me.PIGSTAmt.TabStop = False
        Me.PIGSTAmt.Visible = False
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(503, 1047)
        Me.LabelControl47.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(78, 22)
        Me.LabelControl47.TabIndex = 158
        Me.LabelControl47.Text = "IGST Amt"
        Me.LabelControl47.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Location = New System.Drawing.Point(1929, 968)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.MenuManager = Me.BarManager1
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureBox2.Size = New System.Drawing.Size(251, 258)
        Me.PictureBox2.TabIndex = 225
        '
        'TxtBoxResp
        '
        Me.TxtBoxResp.Location = New System.Drawing.Point(116, 1007)
        Me.TxtBoxResp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxResp.Name = "TxtBoxResp"
        Me.TxtBoxResp.Size = New System.Drawing.Size(1791, 28)
        Me.TxtBoxResp.TabIndex = 224
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(1116, 971)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MaskedTextBox1.Size = New System.Drawing.Size(793, 28)
        Me.MaskedTextBox1.TabIndex = 220
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(1084, 976)
        Me.LabelControl53.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(20, 22)
        Me.LabelControl53.TabIndex = 221
        Me.LabelControl53.Text = "url"
        '
        'txtIRN
        '
        Me.txtIRN.Location = New System.Drawing.Point(116, 971)
        Me.txtIRN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIRN.Name = "txtIRN"
        Me.txtIRN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIRN.Size = New System.Drawing.Size(960, 28)
        Me.txtIRN.TabIndex = 218
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Print Triplicate Sign"
        Me.BarButtonItem1.Id = 8
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Triplicate Sign"
        Me.BarButtonItem2.Id = 8
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print E-Way Bill"
        Me.BarButtonItem3.Id = 10
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Frm_Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1386, 787)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TxtBoxResp)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.LabelControl53)
        Me.Controls.Add(Me.txtIRN)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Invoice"
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlMain.ResumeLayout(False)
        Me.PanelCtrlMain.PerformLayout()
        CType(Me.EwbValidTillDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EwbValidTillDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AckDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AckDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AckNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRCodeMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EwbNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EwbDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EwbDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrl.ResumeLayout(False)
        Me.PanelCtrl.PerformLayout()
        CType(Me.MultiVehInfoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEWBNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehTypeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportModeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistanceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransNMTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSCTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARNDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARNDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARNNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneePANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverPANNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgainstFormTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverStateCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverNameComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmtAfterTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSTReverseChargeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalGSTTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CGSTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverGSTINTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyToTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalInWordsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportationModeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDetailGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmtBeforeTaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBoxError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIGSTRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCGSTAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSGSTAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIGSTAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBoxResp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaskedTextBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIRN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrlMain As DevExpress.XtraEditors.PanelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents NewBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents OpenBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents PrintBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents DeleteBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
    Friend WithEvents SaveSimpleButton As DevExpress.XtraEditors.SimpleButton
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrl As DevExpress.XtraEditors.PanelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
    Friend WithEvents NetAmtLabelControl As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.DateEdit' is not defined.
    Friend WithEvents InvoiceDateDateEdit As DevExpress.XtraEditors.DateEdit
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.DateEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.
    Friend WithEvents InvoiceDetailGridControl As DevExpress.XtraGrid.GridControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.GridControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
    Friend WithEvents InvoiceDetailGridView As DevExpress.XtraGrid.Views.Grid.GridView
#Enable Warning BC30002 ' Type 'DevExpress.XtraGrid.Views.Grid.GridView' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
    Friend WithEvents TotalAmtBeforeTaxTextEdit As DevExpress.XtraEditors.TextEdit
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LookUpEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LookUpEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LookUpEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LookUpEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
    Friend WithEvents TransportationModeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PrintOriginalPrintBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalInWordsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SupplyToTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ReceiverStateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiverGSTINTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConsigneeStateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConsigneeGSTINTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IGSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SGSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CGSTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalGSTTaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GSTReverseChargeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalAmtAfterTaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiverNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ConsigneeNameComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ReceiverStateCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConsigneeStateCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PODateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents POTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChallanDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AgainstFormTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConsigneeAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ReceiverAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrintDuplicateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintTriplicateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AddNewProductSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TaxInWordsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PackingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PCGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PIGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PSGSTRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PCGSTAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PIGSTAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PSGSTAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModifiedByLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CreatedByLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ModifiedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreatedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ConsigneePANNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiverPANNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AddressCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AddNewPartySimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChallanNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvoiceNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PartyDCDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PartyDCNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ARNDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ARNNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PrintOriginalSignBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintTriplicateSignBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents SendEmailSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblAttachment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GenerateEInvoiceSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AckNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AckDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents QRCodeMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents TxtBoxResp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtBoxError As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MaskedTextBox1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIRN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SSCTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CloseBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ModelNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ModelNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GenerateEWBSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EwbNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EwbDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EwbValidTillDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransNMTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents VehNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DistanceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents VehTypeRadioGroup As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents TransportModeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PrintEWBillBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MultiVehInfoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MultiVehInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CEWBNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EWayBillABBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintDetailedBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EWayBillPrintBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
End Class
