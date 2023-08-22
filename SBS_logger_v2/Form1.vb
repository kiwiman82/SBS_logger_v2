Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports EasyModbus


Public Class Form1

    Dim ModClient As New ModbusClient
    Dim Val1, Val2, Val3 As Integer

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click

        ModClient.IPAddress = TxtPLCIP.Text
        ModClient.Port = TxtPort.Text
        Try
            ModClient.Connect()
            Timer1.Interval = 500
            Timer1.Start()
            BtnStart.Visible = False
            BtnStop.Visible = True
            TxtPLCIP.Enabled = False
            TxtPort.Enabled = False
            TxtModbusID.Enabled = False
            TxtReg1.Enabled = False
            TxtReg2.Enabled = False
            TxtReg3.Enabled = False
            TxtTrigger.Enabled = False
            TxtSaveLoc.Enabled = False
            BtnBrowse.Enabled = False

        Catch ex As Exception
            BtnStop.Select()
        End Try

    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        ModClient.Disconnect()
        Timer1.Stop()
        BtnStart.Visible = True
        BtnStop.Visible = False
        If Not ModClient.Connected Then
            TxtCon.Visible = False
            TxtDisCon.Visible = True
            TxtPLCIP.Enabled = True
            TxtPort.Enabled = True
            TxtModbusID.Enabled = True
            TxtReg1.Enabled = True
            TxtReg2.Enabled = True
            TxtReg3.Enabled = True
            TxtTrigger.Enabled = True
            TxtSaveLoc.Enabled = True
            BtnBrowse.Enabled = True
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ModClient.Connected Then
            TxtCon.Visible = True
            TxtDisCon.Visible = False
            Dim Trigger As Integer()
            Dim Value As Integer()
            Dim ModBusConnected
            If BtnConfirm.Enabled = True Then
                Try
                    ModBusConnected = ModClient.Connected
                    If ModBusConnected Then
                        Trigger = ModClient.ReadHoldingRegisters(TxtTrigger.Text, 1)
                        If Trigger(0) = 1 Then
                            If Not TxtReg1.Text = 0 Then
                                Value = ModClient.ReadHoldingRegisters(TxtReg1.Text, 1)
                                TxtVal1.Text = Value(0)
                            ElseIf TxtReg1.Text = 0 Then
                                TxtVal1.Text = 0
                            End If
                            If TxtReg2.Text <> 0 Then
                                Value = ModClient.ReadHoldingRegisters(TxtReg2.Text, 1)
                                TxtVal2.Text = Value(0)
                            End If
                            If TxtReg3.Text <> 0 Then
                                Value = ModClient.ReadHoldingRegisters(TxtReg3.Text, 1)
                                TxtVal3.Text = Value(0)
                            End If
                            ModClient.WriteSingleRegister(TxtTrigger.Text, 0)

                            Dim sfile As String = TxtSaveLoc.Text
                            If Not sfile = "" Then
                                Dim sPrint As String = Now.ToString("dd-MM-yy HH:mm:ss")
                                If Not TxtVal1.Text = 0 Then
                                    sPrint = sPrint & "," & TxtVal1.Text.ToString
                                End If
                                If Not TxtVal2.Text = 0 Then
                                    sPrint = sPrint & "," & TxtVal2.Text.ToString
                                End If
                                If Not TxtVal2.Text = 0 Then
                                    sPrint = sPrint & "," & TxtVal3.Text.ToString
                                End If
                                Dim fWriter As New StreamWriter(sfile, append:=True)
                                fWriter.WriteLine(sPrint)
                                fWriter.Close()
                            End If

                        End If
                    End If
                Catch ex As Exception
                    Call BtnStop.PerformClick()
                End Try
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Line 1" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "1"
            CheckBox2.Text = "2"
            CheckBox3.Text = "3"

            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            CheckBox9.Visible = True
            CheckBox10.Visible = True
            CheckBox11.Visible = True
            CheckBox12.Visible = True
            CheckBox13.Visible = True
            CheckBox14.Visible = True
            CheckBox15.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox19.Visible = True
            CheckBox20.Visible = True
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox20.Checked = False
            CheckBox21.Checked = False
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False

            BtnConfirm.Enabled = True

        ElseIf ComboBox1.SelectedItem = "Line 2" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "1"
            CheckBox2.Text = "2"
            CheckBox3.Text = "3"

            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            CheckBox9.Visible = True
            CheckBox10.Visible = True
            CheckBox11.Visible = True
            CheckBox12.Visible = True
            CheckBox13.Visible = True
            CheckBox14.Visible = True
            CheckBox15.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox19.Visible = True
            CheckBox20.Visible = True
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
            CheckBox11.Checked = True
            CheckBox12.Checked = True
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox20.Checked = False
            CheckBox21.Checked = False
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False

            BtnConfirm.Enabled = True

        ElseIf ComboBox1.SelectedItem = "Line 3" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "1"
            CheckBox2.Text = "2"
            CheckBox3.Text = "3"

            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            CheckBox9.Visible = True
            CheckBox10.Visible = True
            CheckBox11.Visible = True
            CheckBox12.Visible = True
            CheckBox13.Visible = True
            CheckBox14.Visible = True
            CheckBox15.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox19.Visible = True
            CheckBox20.Visible = True
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
            CheckBox11.Checked = True
            CheckBox12.Checked = True
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox20.Checked = False
            CheckBox21.Checked = False
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False

            BtnConfirm.Enabled = True

        ElseIf ComboBox1.SelectedItem = "Line 4" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "1"
            CheckBox2.Text = "2"
            CheckBox3.Text = "3"

            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            CheckBox9.Visible = True
            CheckBox10.Visible = True
            CheckBox11.Visible = True
            CheckBox12.Visible = True
            CheckBox13.Visible = True
            CheckBox14.Visible = True
            CheckBox15.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox19.Visible = True
            CheckBox20.Visible = True
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
            CheckBox11.Checked = True
            CheckBox12.Checked = True
            CheckBox13.Checked = True
            CheckBox14.Checked = True
            CheckBox15.Checked = True
            CheckBox16.Checked = True
            CheckBox17.Checked = True
            CheckBox18.Checked = True
            CheckBox19.Checked = True
            CheckBox20.Checked = True
            CheckBox21.Checked = True
            CheckBox22.Checked = True
            CheckBox23.Checked = True
            CheckBox24.Checked = True

            BtnConfirm.Enabled = True

        ElseIf ComboBox1.SelectedItem = "Line 5" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "1"
            CheckBox2.Text = "2"
            CheckBox3.Text = "3"

            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            CheckBox9.Visible = True
            CheckBox10.Visible = True
            CheckBox11.Visible = True
            CheckBox12.Visible = True
            CheckBox13.Visible = True
            CheckBox14.Visible = True
            CheckBox15.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox19.Visible = True
            CheckBox20.Visible = True
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
            CheckBox11.Checked = True
            CheckBox12.Checked = True
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox20.Checked = False
            CheckBox21.Checked = False
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False

            BtnConfirm.Enabled = True

        ElseIf ComboBox1.SelectedItem = "Line 6" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "1"
            CheckBox2.Text = "2"
            CheckBox3.Text = "3"

            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            CheckBox9.Visible = True
            CheckBox10.Visible = True
            CheckBox11.Visible = True
            CheckBox12.Visible = True
            CheckBox13.Visible = True
            CheckBox14.Visible = True
            CheckBox15.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox19.Visible = True
            CheckBox20.Visible = True
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
            CheckBox11.Checked = True
            CheckBox12.Checked = True
            CheckBox13.Checked = True
            CheckBox14.Checked = True
            CheckBox15.Checked = True
            CheckBox16.Checked = True
            CheckBox17.Checked = True
            CheckBox18.Checked = True
            CheckBox19.Checked = True
            CheckBox20.Checked = True
            CheckBox21.Checked = True
            CheckBox22.Checked = True
            CheckBox23.Checked = True
            CheckBox24.Checked = True

            BtnConfirm.Enabled = True

        ElseIf ComboBox1.SelectedItem = "Line 7" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "1"
            CheckBox2.Text = "2"
            CheckBox3.Text = "3"

            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            CheckBox9.Visible = True
            CheckBox10.Visible = True
            CheckBox11.Visible = True
            CheckBox12.Visible = True
            CheckBox13.Visible = True
            CheckBox14.Visible = True
            CheckBox15.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox19.Visible = True
            CheckBox20.Visible = True
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox20.Checked = False
            CheckBox21.Checked = False
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False

            BtnConfirm.Enabled = True

        ElseIf ComboBox1.SelectedItem = "Line 8" Or ComboBox1.SelectedItem = "Line 9" Or ComboBox1.SelectedItem = "Line 10" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "A"
            CheckBox2.Text = "B"
            CheckBox3.Text = "C"

            CheckBox4.Visible = False
            CheckBox5.Visible = False
            CheckBox6.Visible = False
            CheckBox7.Visible = False
            CheckBox8.Visible = False
            CheckBox9.Visible = False
            CheckBox10.Visible = False
            CheckBox11.Visible = False
            CheckBox12.Visible = False
            CheckBox13.Visible = False
            CheckBox14.Visible = False
            CheckBox15.Visible = False
            CheckBox16.Visible = False
            CheckBox17.Visible = False
            CheckBox18.Visible = False
            CheckBox19.Visible = False
            CheckBox20.Visible = False
            CheckBox21.Visible = False
            CheckBox22.Visible = False
            CheckBox23.Visible = False
            CheckBox24.Visible = False

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox20.Checked = False
            CheckBox21.Checked = False
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False

            BtnConfirm.Enabled = True

        ElseIf ComboBox1.SelectedItem = "Line 11" Then
            BtnConfirm.Text = "Confirm"
            CheckBox1.Text = "1"
            CheckBox2.Text = "2"
            CheckBox3.Text = "3"

            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox6.Visible = True
            CheckBox7.Visible = True
            CheckBox8.Visible = True
            CheckBox9.Visible = True
            CheckBox10.Visible = True
            CheckBox11.Visible = True
            CheckBox12.Visible = True
            CheckBox13.Visible = True
            CheckBox14.Visible = True
            CheckBox15.Visible = True
            CheckBox16.Visible = True
            CheckBox17.Visible = True
            CheckBox18.Visible = True
            CheckBox19.Visible = True
            CheckBox20.Visible = True
            CheckBox21.Visible = True
            CheckBox22.Visible = True
            CheckBox23.Visible = True
            CheckBox24.Visible = True

            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
            CheckBox11.Checked = True
            CheckBox12.Checked = True
            CheckBox13.Checked = True
            CheckBox14.Checked = True
            CheckBox15.Checked = True
            CheckBox16.Checked = True
            CheckBox17.Checked = True
            CheckBox18.Checked = True
            CheckBox19.Checked = True
            CheckBox20.Checked = True
            CheckBox21.Checked = True
            CheckBox22.Checked = True
            CheckBox23.Checked = True
            CheckBox24.Checked = True

            BtnConfirm.Enabled = True

        End If

    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        BtnConfirm.Text = "Confirmed"
        If Not TxtSaveLoc.Text = "" Then
            BtnStart.Enabled = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub
    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        BtnConfirm.Text = "Confirm"
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        TxtSaveLoc.Text = SaveFileDialog1.FileName

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        SaveFileDialog1.ShowDialog()
    End Sub
End Class

