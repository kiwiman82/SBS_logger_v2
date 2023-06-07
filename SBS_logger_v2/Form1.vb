Imports EasyModbus


Public Class Form1

    Dim ModClient As New ModbusClient
    Dim Val1, Val2, Val3 As Integer

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        ModClient.IPAddress = TxtPLCIP.Text
        ModClient.Port = TxtPort.Text
        ModClient.Connect()

        BtnStart.Visible = False
        BtnStop.Visible = True
        If ModClient.Connected Then
            TxtCon.Visible = True
            TxtDisCon.Visible = False
        End If
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
        If ModClient.Connected Then
            Dim Trigger
            Dim Value1, Value2, Value3
            Trigger = ModClient.ReadHoldingRegisters(TxtTrigger.Text, 1)
            If Trigger Is "1" Then
                Value1 = ModClient.ReadHoldingRegisters(TxtReg1.Text, 1)
                TxtVal1.Text = Value1

            End If
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        TxtSaveLoc.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        SaveFileDialog1.ShowDialog()
    End Sub
End Class
