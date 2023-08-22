<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ConnectionSetup = New System.Windows.Forms.GroupBox()
        Me.TxtModbusID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPort = New System.Windows.Forms.TextBox()
        Me.TxtPLCIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Registers = New System.Windows.Forms.GroupBox()
        Me.TxtVal3 = New System.Windows.Forms.TextBox()
        Me.TxtVal2 = New System.Windows.Forms.TextBox()
        Me.TxtVal1 = New System.Windows.Forms.TextBox()
        Me.TxtReg3 = New System.Windows.Forms.TextBox()
        Me.TxtReg2 = New System.Windows.Forms.TextBox()
        Me.TxtReg1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoggingSetup = New System.Windows.Forms.GroupBox()
        Me.TxtTrigger = New System.Windows.Forms.TextBox()
        Me.TxtSaveLoc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCon = New System.Windows.Forms.TextBox()
        Me.TxtDisCon = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ConnectionSetup.SuspendLayout()
        Me.Registers.SuspendLayout()
        Me.LoggingSetup.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConnectionSetup
        '
        Me.ConnectionSetup.Controls.Add(Me.TxtModbusID)
        Me.ConnectionSetup.Controls.Add(Me.Label13)
        Me.ConnectionSetup.Controls.Add(Me.TxtPort)
        Me.ConnectionSetup.Controls.Add(Me.TxtPLCIP)
        Me.ConnectionSetup.Controls.Add(Me.Label2)
        Me.ConnectionSetup.Controls.Add(Me.Label1)
        Me.ConnectionSetup.Location = New System.Drawing.Point(14, 30)
        Me.ConnectionSetup.Name = "ConnectionSetup"
        Me.ConnectionSetup.Size = New System.Drawing.Size(270, 132)
        Me.ConnectionSetup.TabIndex = 0
        Me.ConnectionSetup.TabStop = False
        Me.ConnectionSetup.Text = "Connection Setup"
        '
        'TxtModbusID
        '
        Me.TxtModbusID.Location = New System.Drawing.Point(106, 81)
        Me.TxtModbusID.Name = "TxtModbusID"
        Me.TxtModbusID.Size = New System.Drawing.Size(143, 20)
        Me.TxtModbusID.TabIndex = 5
        Me.TxtModbusID.Text = "1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Modbus ID"
        '
        'TxtPort
        '
        Me.TxtPort.Location = New System.Drawing.Point(106, 53)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.Size = New System.Drawing.Size(143, 20)
        Me.TxtPort.TabIndex = 3
        Me.TxtPort.Text = "502"
        '
        'TxtPLCIP
        '
        Me.TxtPLCIP.Location = New System.Drawing.Point(106, 27)
        Me.TxtPLCIP.Name = "TxtPLCIP"
        Me.TxtPLCIP.Size = New System.Drawing.Size(143, 20)
        Me.TxtPLCIP.TabIndex = 2
        Me.TxtPLCIP.Text = "192.168.11.50"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modbus Port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLC IP Address"
        '
        'Registers
        '
        Me.Registers.Controls.Add(Me.TxtVal3)
        Me.Registers.Controls.Add(Me.TxtVal2)
        Me.Registers.Controls.Add(Me.TxtVal1)
        Me.Registers.Controls.Add(Me.TxtReg3)
        Me.Registers.Controls.Add(Me.TxtReg2)
        Me.Registers.Controls.Add(Me.TxtReg1)
        Me.Registers.Controls.Add(Me.Label10)
        Me.Registers.Controls.Add(Me.Label9)
        Me.Registers.Controls.Add(Me.Label8)
        Me.Registers.Controls.Add(Me.Label7)
        Me.Registers.Controls.Add(Me.Label6)
        Me.Registers.Controls.Add(Me.Label5)
        Me.Registers.Controls.Add(Me.Label4)
        Me.Registers.Controls.Add(Me.Label3)
        Me.Registers.Location = New System.Drawing.Point(14, 168)
        Me.Registers.Name = "Registers"
        Me.Registers.Size = New System.Drawing.Size(271, 257)
        Me.Registers.TabIndex = 0
        Me.Registers.TabStop = False
        Me.Registers.Text = "Registers"
        '
        'TxtVal3
        '
        Me.TxtVal3.Location = New System.Drawing.Point(73, 220)
        Me.TxtVal3.Name = "TxtVal3"
        Me.TxtVal3.ReadOnly = True
        Me.TxtVal3.Size = New System.Drawing.Size(171, 20)
        Me.TxtVal3.TabIndex = 14
        '
        'TxtVal2
        '
        Me.TxtVal2.Location = New System.Drawing.Point(73, 195)
        Me.TxtVal2.Name = "TxtVal2"
        Me.TxtVal2.ReadOnly = True
        Me.TxtVal2.Size = New System.Drawing.Size(171, 20)
        Me.TxtVal2.TabIndex = 13
        '
        'TxtVal1
        '
        Me.TxtVal1.Location = New System.Drawing.Point(73, 172)
        Me.TxtVal1.Name = "TxtVal1"
        Me.TxtVal1.ReadOnly = True
        Me.TxtVal1.Size = New System.Drawing.Size(171, 20)
        Me.TxtVal1.TabIndex = 12
        '
        'TxtReg3
        '
        Me.TxtReg3.Location = New System.Drawing.Point(89, 87)
        Me.TxtReg3.Name = "TxtReg3"
        Me.TxtReg3.Size = New System.Drawing.Size(160, 20)
        Me.TxtReg3.TabIndex = 11
        Me.TxtReg3.Text = "0"
        '
        'TxtReg2
        '
        Me.TxtReg2.Location = New System.Drawing.Point(89, 63)
        Me.TxtReg2.Name = "TxtReg2"
        Me.TxtReg2.Size = New System.Drawing.Size(160, 20)
        Me.TxtReg2.TabIndex = 10
        Me.TxtReg2.Text = "0"
        '
        'TxtReg1
        '
        Me.TxtReg1.Location = New System.Drawing.Point(89, 38)
        Me.TxtReg1.Name = "TxtReg1"
        Me.TxtReg1.Size = New System.Drawing.Size(160, 20)
        Me.TxtReg1.TabIndex = 9
        Me.TxtReg1.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Val 3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Weight"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Register Values"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Reg 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Weight (%MW)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Time (%MW)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Read Registers"
        '
        'LoggingSetup
        '
        Me.LoggingSetup.Controls.Add(Me.TxtTrigger)
        Me.LoggingSetup.Controls.Add(Me.TxtSaveLoc)
        Me.LoggingSetup.Controls.Add(Me.Label12)
        Me.LoggingSetup.Controls.Add(Me.Label11)
        Me.LoggingSetup.Controls.Add(Me.BtnBrowse)
        Me.LoggingSetup.Location = New System.Drawing.Point(290, 30)
        Me.LoggingSetup.Name = "LoggingSetup"
        Me.LoggingSetup.Size = New System.Drawing.Size(632, 85)
        Me.LoggingSetup.TabIndex = 1
        Me.LoggingSetup.TabStop = False
        Me.LoggingSetup.Text = "Logging Setup"
        '
        'TxtTrigger
        '
        Me.TxtTrigger.AcceptsReturn = True
        Me.TxtTrigger.AcceptsTab = True
        Me.TxtTrigger.AllowDrop = True
        Me.TxtTrigger.Location = New System.Drawing.Point(180, 58)
        Me.TxtTrigger.MaxLength = 9999
        Me.TxtTrigger.Name = "TxtTrigger"
        Me.TxtTrigger.Size = New System.Drawing.Size(45, 20)
        Me.TxtTrigger.TabIndex = 12
        '
        'TxtSaveLoc
        '
        Me.TxtSaveLoc.Location = New System.Drawing.Point(180, 22)
        Me.TxtSaveLoc.Name = "TxtSaveLoc"
        Me.TxtSaveLoc.Size = New System.Drawing.Size(313, 20)
        Me.TxtSaveLoc.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Trigger Register Value"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Save File Name and Location"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(499, 19)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(127, 25)
        Me.BtnBrowse.TabIndex = 3
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Enabled = False
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnStart.Location = New System.Drawing.Point(339, 134)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(254, 59)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnStop.Location = New System.Drawing.Point(599, 134)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(254, 59)
        Me.BtnStop.TabIndex = 3
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        Me.BtnStop.Visible = False
        '
        'Logo
        '
        Me.Logo.BackgroundImage = CType(resources.GetObject("Logo.BackgroundImage"), System.Drawing.Image)
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.ErrorImage = Nothing
        Me.Logo.InitialImage = Nothing
        Me.Logo.Location = New System.Drawing.Point(290, 235)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(613, 200)
        Me.Logo.TabIndex = 4
        Me.Logo.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "CSV File | *.csv"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(527, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 24)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Status"
        '
        'TxtCon
        '
        Me.TxtCon.BackColor = System.Drawing.Color.Green
        Me.TxtCon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCon.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCon.Location = New System.Drawing.Point(599, 201)
        Me.TxtCon.Multiline = True
        Me.TxtCon.Name = "TxtCon"
        Me.TxtCon.Size = New System.Drawing.Size(113, 24)
        Me.TxtCon.TabIndex = 6
        Me.TxtCon.Text = "   Connected"
        Me.TxtCon.Visible = False
        '
        'TxtDisCon
        '
        Me.TxtDisCon.BackColor = System.Drawing.Color.Red
        Me.TxtDisCon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDisCon.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtDisCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisCon.Location = New System.Drawing.Point(599, 201)
        Me.TxtDisCon.Multiline = True
        Me.TxtDisCon.Name = "TxtDisCon"
        Me.TxtDisCon.Size = New System.Drawing.Size(113, 24)
        Me.TxtDisCon.TabIndex = 7
        Me.TxtDisCon.Text = "Disconnected"
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 441)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 108)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setup"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnConfirm)
        Me.GroupBox2.Controls.Add(Me.CheckBox23)
        Me.GroupBox2.Controls.Add(Me.CheckBox24)
        Me.GroupBox2.Controls.Add(Me.CheckBox18)
        Me.GroupBox2.Controls.Add(Me.CheckBox19)
        Me.GroupBox2.Controls.Add(Me.CheckBox20)
        Me.GroupBox2.Controls.Add(Me.CheckBox21)
        Me.GroupBox2.Controls.Add(Me.CheckBox22)
        Me.GroupBox2.Controls.Add(Me.CheckBox13)
        Me.GroupBox2.Controls.Add(Me.CheckBox14)
        Me.GroupBox2.Controls.Add(Me.CheckBox15)
        Me.GroupBox2.Controls.Add(Me.CheckBox16)
        Me.GroupBox2.Controls.Add(Me.CheckBox17)
        Me.GroupBox2.Controls.Add(Me.CheckBox12)
        Me.GroupBox2.Controls.Add(Me.CheckBox11)
        Me.GroupBox2.Controls.Add(Me.CheckBox10)
        Me.GroupBox2.Controls.Add(Me.CheckBox9)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.Controls.Add(Me.CheckBox7)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(902, 62)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tracks"
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Enabled = False
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnConfirm.Location = New System.Drawing.Point(769, 21)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(133, 23)
        Me.BtnConfirm.TabIndex = 25
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Location = New System.Drawing.Point(494, 39)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox23.TabIndex = 24
        Me.CheckBox23.Text = "24"
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Location = New System.Drawing.Point(445, 39)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox24.TabIndex = 23
        Me.CheckBox24.Text = "23"
        Me.CheckBox24.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(396, 39)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox18.TabIndex = 22
        Me.CheckBox18.Text = "22"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Location = New System.Drawing.Point(353, 39)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox19.TabIndex = 21
        Me.CheckBox19.Text = "21"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Location = New System.Drawing.Point(310, 39)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox20.TabIndex = 20
        Me.CheckBox20.Text = "20"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Location = New System.Drawing.Point(266, 39)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox21.TabIndex = 19
        Me.CheckBox21.Text = "19"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Location = New System.Drawing.Point(224, 39)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox22.TabIndex = 18
        Me.CheckBox22.Text = "18"
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(181, 39)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox13.TabIndex = 17
        Me.CheckBox13.Text = "17"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(138, 39)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox14.TabIndex = 16
        Me.CheckBox14.Text = "16"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(96, 39)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox15.TabIndex = 15
        Me.CheckBox15.Text = "15"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(54, 39)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox16.TabIndex = 14
        Me.CheckBox16.Text = "14"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(12, 39)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox17.TabIndex = 13
        Me.CheckBox17.Text = "13"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(494, 17)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox12.TabIndex = 12
        Me.CheckBox12.Text = "12"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(445, 17)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox11.TabIndex = 11
        Me.CheckBox11.Text = "11"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(396, 17)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox10.TabIndex = 10
        Me.CheckBox10.Text = "10"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(353, 17)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox9.TabIndex = 9
        Me.CheckBox9.Text = "9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(310, 17)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox8.TabIndex = 8
        Me.CheckBox8.Text = "8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(267, 17)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox7.TabIndex = 7
        Me.CheckBox7.Text = "7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(224, 17)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox6.TabIndex = 6
        Me.CheckBox6.Text = "6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(181, 17)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox5.TabIndex = 5
        Me.CheckBox5.Text = "5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(138, 17)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox4.TabIndex = 4
        Me.CheckBox4.Text = "4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(96, 17)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(54, 17)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 17)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Line"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Line 1", "Line 2", "Line 3", "Line 4", "Line 5", "Line 6", "Line 7", "Line 8", "Line 9", "Line 10", "Line 11"})
        Me.ComboBox1.Location = New System.Drawing.Point(73, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(171, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 578)
        Me.Controls.Add(Me.TxtDisCon)
        Me.Controls.Add(Me.TxtCon)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LoggingSetup)
        Me.Controls.Add(Me.Registers)
        Me.Controls.Add(Me.ConnectionSetup)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SBS Tester"
        Me.ConnectionSetup.ResumeLayout(False)
        Me.ConnectionSetup.PerformLayout()
        Me.Registers.ResumeLayout(False)
        Me.Registers.PerformLayout()
        Me.LoggingSetup.ResumeLayout(False)
        Me.LoggingSetup.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectionSetup As GroupBox
    Friend WithEvents TxtPLCIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Registers As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LoggingSetup As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents TxtPort As TextBox
    Friend WithEvents TxtVal3 As TextBox
    Friend WithEvents TxtVal2 As TextBox
    Friend WithEvents TxtVal1 As TextBox
    Friend WithEvents TxtReg3 As TextBox
    Friend WithEvents TxtReg2 As TextBox
    Friend WithEvents TxtReg1 As TextBox
    Friend WithEvents TxtTrigger As TextBox
    Friend WithEvents TxtSaveLoc As TextBox
    Friend WithEvents TxtModbusID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCon As TextBox
    Friend WithEvents TxtDisCon As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox23 As CheckBox
    Friend WithEvents CheckBox24 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox22 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents BtnConfirm As Button
End Class
