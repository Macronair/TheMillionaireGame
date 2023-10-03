Public Class Game

    Public Shared CurrentProfile As New Profile

    ' Game info variables
    Public Shared gamemode As Integer = 0
    Public Shared level As Integer = 0
    Public Shared firstQuestion As Boolean = True
    Public Shared intoCommercials As Boolean = False
    Public Shared walkaway As Boolean = False
    Public Shared varCurrent As String = "0"
    Public Shared varCorrect As String = "0"
    Public Shared varWrong As String = "0"
    Public Shared varDrop As String = "0"
    Public Shared varQLeft As String = "0"

    Public Shared Sub ChangeLevel(ByVal newLvl As Integer)
        If newLvl = 0 Then
            Game.level = 0
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 0
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 1 Then
            Game.level = 1
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 1
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 2 Then
            Game.level = 2
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 2
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 3 Then
            Game.level = newLvl
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 3
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 4 Then
            Game.level = 4
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 4
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 5 Then
            Game.level = 5
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 5
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 6 Then
            Game.level = 6
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 6
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 7 Then
            Game.level = 7
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 7
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 8 Then
            Game.level = 8
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 8
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 9 Then
            Game.level = 9
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 9
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 10 Then
            Game.level = 10
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 10
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 11 Then
            Game.level = 11
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 11
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 12 Then
            Game.level = 12
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 12
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 13 Then
            Game.level = 13
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 13
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 14 Then
            Game.level = 14
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 14
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
        If newLvl = 15 Then
            Game.level = 15
            Game.SetValues()
            ControlPanel.nmrLevel.Value = 15
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
        End If
    End Sub

    Public Shared Sub ChangeMode(ByVal newmode As Integer)
        Select Case newmode
            Case 0      ' Change to normal mode
                gamemode = 0
                SetValues()
                ControlPanel.btnUnlockSwitch.Text = "RISK MODE OFF"
                ControlPanel.btnUnlockSwitch.BackColor = Color.Orange
                ControlPanel.btnSwitch.Enabled = False
                ControlPanel.chkSwitch.Enabled = False
                HostScreen.picSW.Visible = False
                GuestScreen.picSW.Visible = False
                TVControlPnl.picSW.Visible = False
            Case 1      ' Change to risk mode
                gamemode = 1
                SetValues()
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(9, False, 1000)
                End With
                ControlPanel.btnUnlockSwitch.Text = "RISK MODE ON"
                ControlPanel.btnUnlockSwitch.BackColor = Color.DarkGreen
                ControlPanel.btnSwitch.Enabled = True
                ControlPanel.chkSwitch.Enabled = True
                HostScreen.picSW.Visible = True
                GuestScreen.picSW.Visible = True
                TVControlPnl.picSW.Visible = True
        End Select
    End Sub

    Public Shared Sub SetValues()

        'Based on gamemode
        ' 0 = Normal Mode
        ' 1 = Risk Mode
        Select Case gamemode
            Case 0
                modeNormal.getInfo()
            Case 1
                modeRisk.getInfo()
        End Select

    End Sub

    Dim intSound As Integer = 0
    Dim snd As New SOUND

    Public Sub wrongAsnwer()
        If Game.level = 0 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(11, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 1 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(11, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 2 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(11, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 3 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(11, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 4 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(11, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 5 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(29, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 6 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(30, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 7 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(31, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 8 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(32, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 9 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(33, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 10 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(34, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 11 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(35, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 12 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(36, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 13 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(37, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
        If Game.level = 14 Then
            intSound += 1

            With snd
                .Name = "SOUND" & intSound
                .Play(38, False, 1000)
            End With
            ControlPanel.Timer1.Start()
        End If
    End Sub
End Class
