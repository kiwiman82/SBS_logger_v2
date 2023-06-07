Imports EasyModbus


Public Class Form1

    Dim ModClient As New ModbusClient
    Dim Val1, Val2, Val3 As Integer

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        ModClient.IPAddress = TxtPLCIP.Text
        ModClient.Port = TxtPort.Text
        ModClient.Connect()
        Timer1.Interval = 500
        Timer1.Start()

        BtnStart.Visible = False
        BtnStop.Visible = True



    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        ModClient.Disconnect()
        BtnStart.Visible = True
        BtnStop.Visible = False
        If Not ModClient.Connected Then
            TxtCon.Visible = False
            TxtDisCon.Visible = True
        End If
    End Sub

    Private Sub TxtTrigger_TextChanged(sender As Object, e As EventArgs) Handles TxtTrigger.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ModClient.Connected Then
            TxtCon.Visible = True
            TxtDisCon.Visible = False
            Dim Trigger As Integer()
            Dim Value As Integer()

            Trigger = ModClient.ReadHoldingRegisters(TxtTrigger.Text, 1)
            If Trigger(0) = 1 Then
                txtTrigVal.Text = Trigger(0)
            Else
                txtTrigVal.Text = 0
            End If
            Value = ModClient.ReadHoldingRegisters(TxtReg1.Text, 1)
            TxtVal1.Text = Value(0)
            Value = ModClient.ReadHoldingRegisters(TxtReg2.Text, 1)
            TxtVal2.Text = Value(0)
            Value = ModClient.ReadHoldingRegisters(TxtReg3.Text, 1)
            TxtVal3.Text = Value(0)
        Else
            BtnStop.Select()

        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        TxtSaveLoc.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        SaveFileDialog1.ShowDialog()
    End Sub
End Class
