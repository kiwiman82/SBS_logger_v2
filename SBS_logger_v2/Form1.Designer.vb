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
        Me.ConnectionSetup.SuspendLayout()
        Me.Registers.SuspendLayout()
        Me.LoggingSetup.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TxtPLCIP.Text = "192.168.11.59"
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
        Me.Registers.Location = New System.Drawing.Point(14, 192)
        Me.Registers.Name = "Registers"
        Me.Registers.Size = New System.Drawing.Size(271, 375)
        Me.Registers.TabIndex = 0
        Me.Registers.TabStop = False
        Me.Registers.Text = "Registers"
        '
        'TxtVal3
        '
        Me.TxtVal3.Location = New System.Drawing.Point(73, 266)
        Me.TxtVal3.Name = "TxtVal3"
        Me.TxtVal3.Size = New System.Drawing.Size(171, 20)
        Me.TxtVal3.TabIndex = 14
        '
        'TxtVal2
        '
        Me.TxtVal2.Location = New System.Drawing.Point(73, 241)
        Me.TxtVal2.Name = "TxtVal2"
        Me.TxtVal2.Size = New System.Drawing.Size(171, 20)
        Me.TxtVal2.TabIndex = 13
        '
        'TxtVal1
        '
        Me.TxtVal1.Location = New System.Drawing.Point(73, 218)
        Me.TxtVal1.Name = "TxtVal1"
        Me.TxtVal1.Size = New System.Drawing.Size(171, 20)
        Me.TxtVal1.TabIndex = 12
        '
        'TxtReg3
        '
        Me.TxtReg3.Location = New System.Drawing.Point(73, 133)
        Me.TxtReg3.Name = "TxtReg3"
        Me.TxtReg3.Size = New System.Drawing.Size(171, 20)
        Me.TxtReg3.TabIndex = 11
        Me.TxtReg3.Text = "3"
        '
        'TxtReg2
        '
        Me.TxtReg2.Location = New System.Drawing.Point(73, 109)
        Me.TxtReg2.Name = "TxtReg2"
        Me.TxtReg2.Size = New System.Drawing.Size(171, 20)
        Me.TxtReg2.TabIndex = 10
        Me.TxtReg2.Text = "2"
        '
        'TxtReg1
        '
        Me.TxtReg1.Location = New System.Drawing.Point(73, 86)
        Me.TxtReg1.Name = "TxtReg1"
        Me.TxtReg1.Size = New System.Drawing.Size(171, 20)
        Me.TxtReg1.TabIndex = 9
        Me.TxtReg1.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Val 3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Val 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Val 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Register Values"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Reg 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Reg 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Reg 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 67)
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
        Me.LoggingSetup.Size = New System.Drawing.Size(632, 132)
        Me.LoggingSetup.TabIndex = 1
        Me.LoggingSetup.TabStop = False
        Me.LoggingSetup.Text = "Logging Setup"
        '
        'TxtTrigger
        '
        Me.TxtTrigger.Location = New System.Drawing.Point(180, 84)
        Me.TxtTrigger.Name = "TxtTrigger"
        Me.TxtTrigger.Size = New System.Drawing.Size(372, 20)
        Me.TxtTrigger.TabIndex = 12
        Me.TxtTrigger.Text = "100"
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
        Me.Label12.Location = New System.Drawing.Point(134, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Trigger"
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
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnStart.Location = New System.Drawing.Point(340, 204)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(254, 90)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnStop.Location = New System.Drawing.Point(600, 204)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(254, 90)
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
        Me.Logo.Location = New System.Drawing.Point(291, 350)
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
        Me.Label14.Location = New System.Drawing.Point(528, 304)
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
        Me.TxtCon.Location = New System.Drawing.Point(600, 304)
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
        Me.TxtDisCon.Location = New System.Drawing.Point(600, 304)
        Me.TxtDisCon.Multiline = True
        Me.TxtDisCon.Name = "TxtDisCon"
        Me.TxtDisCon.Size = New System.Drawing.Size(113, 24)
        Me.TxtDisCon.TabIndex = 7
        Me.TxtDisCon.Text = "Disconnected"
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
End Class
