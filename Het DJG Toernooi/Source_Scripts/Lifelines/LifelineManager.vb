Public Class LifelineManager

    Public Shared CurrentActive As Integer = 0
    Public Shared Lifeline1_Used As Boolean = False
    Public Shared Lifeline2_Used As Boolean = False
    Public Shared Lifeline3_Used As Boolean = False
    Public Shared Lifeline4_Used As Boolean = False

    Public Shared Sub Use(ByVal LifelineNumber As Integer)
        CurrentActive = 0
        CurrentActive = LifelineNumber

        Select Case LifelineNumber
            Case 1
                Select Case Profile.Options.Lifeline1
                    Case "ask_audience"
                        LifelineATA.LifelineUse1()
                    Case "50_50"
                        Lifeline5050.LifelineUse1()
                    Case "plus_one"
                        LifelinePO.LifelineUse1()
                    Case "switch"
                        LifelineSwitch.LifelineUse1()
                    Case "double_dip"
                        LifeLineDouble.LifelineUse1()
                    Case "ask_host"
                        ' Ask the Host class here
                End Select
            Case 2
                Select Case Profile.Options.Lifeline2
                    Case "ask_audience"
                        LifelineATA.LifelineUse1()
                    Case "50_50"
                        Lifeline5050.LifelineUse1()
                    Case "plus_one"
                        LifelinePO.LifelineUse1()
                    Case "switch"
                        LifelineSwitch.LifelineUse1()
                    Case "double_dip"
                        LifeLineDouble.LifelineUse1()
                    Case "ask_host"
                        ' Ask the Host class here
                End Select
            Case 3
                Select Case Profile.Options.Lifeline3
                    Case "ask_audience"
                        LifelineATA.LifelineUse1()
                    Case "50_50"
                        Lifeline5050.LifelineUse1()
                    Case "plus_one"
                        LifelinePO.LifelineUse1()
                    Case "switch"
                        LifelineSwitch.LifelineUse1()
                    Case "double_dip"
                        LifeLineDouble.LifelineUse1()
                    Case "ask_host"
                        ' Ask the Host class here
                End Select
            Case 4
                Select Case Profile.Options.Lifeline4
                    Case "ask_audience"
                        LifelineATA.LifelineUse1()
                    Case "50_50"
                        Lifeline5050.LifelineUse1()
                    Case "plus_one"
                        LifelinePO.LifelineUse1()
                    Case "switch"
                        LifelineSwitch.LifelineUse1()
                    Case "double_dip"
                        LifeLineDouble.LifelineUse1()
                    Case "ask_host"
                        ' Ask the Host class here
                End Select
        End Select
    End Sub

    Public Shared Sub UnlockLifeline(ByVal LifelineNumber As Integer)
        Select Case LifelineNumber
            Case 1
                ControlPanel.btnLifeline1.Enabled = False
                ControlPanel.chkLifeline1Unused.Enabled = False
                HostScreen.picLifeline1.Visible = False
                GuestScreen.picLifeline1.Visible = False
                TVControlPnl.picLifeline1.Visible = False

                If Profile.Options.TotalLifelines >= 1 Then
                    Select Case Profile.Options.Lifeline1_available
                        Case 0
                            ControlPanel.btnLifeline1.Enabled = True
                            ControlPanel.chkLifeline1Unused.Enabled = True
                            HostScreen.picLifeline1.Visible = True
                            GuestScreen.picLifeline1.Visible = True
                            TVControlPnl.picLifeline1.Visible = True
                        Case 1
                            If Game.level >= 5 Then
                                ControlPanel.btnLifeline1.Enabled = True
                                ControlPanel.chkLifeline1Unused.Enabled = True
                                HostScreen.picLifeline1.Visible = True
                                GuestScreen.picLifeline1.Visible = True
                                TVControlPnl.picLifeline1.Visible = True
                            End If
                        Case 2
                            If Game.level >= 10 Then
                                ControlPanel.btnLifeline1.Enabled = True
                                ControlPanel.chkLifeline1Unused.Enabled = True
                                HostScreen.picLifeline1.Visible = True
                                GuestScreen.picLifeline1.Visible = True
                                TVControlPnl.picLifeline1.Visible = True
                            End If
                        Case 3
                            If Game.gamemode = 1 Then
                                ControlPanel.btnLifeline1.Enabled = True
                                ControlPanel.chkLifeline1Unused.Enabled = True
                                HostScreen.picLifeline1.Visible = True
                                GuestScreen.picLifeline1.Visible = True
                                TVControlPnl.picLifeline1.Visible = True
                            End If
                    End Select
                End If
                If Lifeline1_Used Then
                    ControlPanel.btnLifeline1.Enabled = False
                    ControlPanel.chkLifeline1Unused.Enabled = False
                End If
            Case 2
                ControlPanel.btnLifeline2.Enabled = False
                ControlPanel.chkLifeline2Unused.Enabled = False
                HostScreen.picLifeline2.Visible = False
                GuestScreen.picLifeline2.Visible = False
                TVControlPnl.picLifeline2.Visible = False

                If Profile.Options.TotalLifelines >= 2 Then
                    Select Case Profile.Options.Lifeline2_available
                        Case 0
                            ControlPanel.btnLifeline2.Enabled = True
                            ControlPanel.chkLifeline2Unused.Enabled = True
                            HostScreen.picLifeline2.Visible = True
                            GuestScreen.picLifeline2.Visible = True
                            TVControlPnl.picLifeline2.Visible = True
                        Case 1
                            If Game.level >= 5 Then
                                ControlPanel.btnLifeline2.Enabled = True
                                ControlPanel.chkLifeline2Unused.Enabled = True
                                HostScreen.picLifeline2.Visible = True
                                GuestScreen.picLifeline2.Visible = True
                                TVControlPnl.picLifeline2.Visible = True
                            End If
                        Case 2
                            If Game.level >= 10 Then
                                ControlPanel.btnLifeline2.Enabled = True
                                ControlPanel.chkLifeline2Unused.Enabled = True
                                HostScreen.picLifeline2.Visible = True
                                GuestScreen.picLifeline2.Visible = True
                                TVControlPnl.picLifeline2.Visible = True
                            End If
                        Case 3
                            If Game.gamemode = 1 Then
                                ControlPanel.btnLifeline2.Enabled = True
                                ControlPanel.chkLifeline2Unused.Enabled = True
                                HostScreen.picLifeline2.Visible = True
                                GuestScreen.picLifeline2.Visible = True
                                TVControlPnl.picLifeline2.Visible = True
                            End If
                    End Select
                End If
                If Lifeline2_Used Then
                    ControlPanel.btnLifeline2.Enabled = False
                    ControlPanel.chkLifeline2Unused.Enabled = False
                End If
            Case 3
                ControlPanel.btnLifeline3.Enabled = False
                ControlPanel.chkLifeline3Unused.Enabled = False
                HostScreen.picLifeline3.Visible = False
                GuestScreen.picLifeline3.Visible = False
                TVControlPnl.picLifeline3.Visible = False

                If Profile.Options.TotalLifelines >= 3 Then
                    Select Case Profile.Options.Lifeline3_available
                        Case 0
                            ControlPanel.btnLifeline3.Enabled = True
                            ControlPanel.chkLifeline3Unused.Enabled = True
                            HostScreen.picLifeline3.Visible = True
                            GuestScreen.picLifeline3.Visible = True
                            TVControlPnl.picLifeline3.Visible = True
                        Case 1
                            If Game.level >= 5 Then
                                ControlPanel.btnLifeline3.Enabled = True
                                ControlPanel.chkLifeline3Unused.Enabled = True
                                HostScreen.picLifeline3.Visible = True
                                GuestScreen.picLifeline3.Visible = True
                                TVControlPnl.picLifeline3.Visible = True
                            End If
                        Case 2
                            If Game.level >= 10 Then
                                ControlPanel.btnLifeline3.Enabled = True
                                ControlPanel.chkLifeline3Unused.Enabled = True
                                HostScreen.picLifeline3.Visible = True
                                GuestScreen.picLifeline3.Visible = True
                                TVControlPnl.picLifeline3.Visible = True
                            End If
                        Case 3
                            If Game.gamemode = 1 Then
                                ControlPanel.btnLifeline3.Enabled = True
                                ControlPanel.chkLifeline3Unused.Enabled = True
                                HostScreen.picLifeline3.Visible = True
                                GuestScreen.picLifeline3.Visible = True
                                TVControlPnl.picLifeline3.Visible = True
                            End If
                    End Select
                End If
                If Lifeline3_Used Then
                    ControlPanel.btnLifeline3.Enabled = False
                    ControlPanel.chkLifeline3Unused.Enabled = False
                End If
            Case 4
                ControlPanel.btnLifeline4.Enabled = False
                ControlPanel.chkLifeline4Unused.Enabled = False
                HostScreen.picLifeline4.Visible = False
                GuestScreen.picLifeline4.Visible = False
                TVControlPnl.picLifeline4.Visible = False

                If Profile.Options.TotalLifelines = 4 Then
                    Select Case Profile.Options.Lifeline4_available
                        Case 0
                            ControlPanel.btnLifeline4.Enabled = True
                            ControlPanel.chkLifeline4Unused.Enabled = True
                            HostScreen.picLifeline4.Visible = True
                            GuestScreen.picLifeline4.Visible = True
                            TVControlPnl.picLifeline4.Visible = True
                        Case 1
                            If Game.level >= 5 Then
                                ControlPanel.btnLifeline4.Enabled = True
                                ControlPanel.chkLifeline4Unused.Enabled = True
                                HostScreen.picLifeline4.Visible = True
                                GuestScreen.picLifeline4.Visible = True
                                TVControlPnl.picLifeline4.Visible = True
                            End If
                        Case 2
                            If Game.level >= 10 Then
                                ControlPanel.btnLifeline4.Enabled = True
                                ControlPanel.chkLifeline4Unused.Enabled = True
                                HostScreen.picLifeline4.Visible = True
                                GuestScreen.picLifeline4.Visible = True
                                TVControlPnl.picLifeline4.Visible = True
                            End If
                        Case 3
                            If Game.gamemode = 1 Then
                                ControlPanel.btnLifeline4.Enabled = True
                                ControlPanel.chkLifeline4Unused.Enabled = True
                                HostScreen.picLifeline4.Visible = True
                                GuestScreen.picLifeline4.Visible = True
                                TVControlPnl.picLifeline4.Visible = True
                            End If
                    End Select
                End If
                If Lifeline4_Used Then
                    ControlPanel.btnLifeline4.Enabled = False
                    ControlPanel.chkLifeline4Unused.Enabled = False
                End If
        End Select
    End Sub

    Public Shared Sub EnableLifeline(ByVal LifelineNumber As Integer, ByVal enable As Boolean)
        If enable = True Then
            Select Case LifelineNumber
                Case 1
                    ControlPanel.btnLifeline1.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline1)
                    HostScreen.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
                    GuestScreen.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
                    TVControlPnl.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
                Case 2
                    ControlPanel.btnLifeline2.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline2)
                    HostScreen.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
                    GuestScreen.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
                    TVControlPnl.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
                Case 3
                    ControlPanel.btnLifeline3.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline3)
                    HostScreen.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
                    GuestScreen.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
                    TVControlPnl.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
                Case 4
                    ControlPanel.btnLifeline4.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline4)
                    HostScreen.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
                    GuestScreen.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
                    TVControlPnl.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
            End Select
        Else
            Select Case LifelineNumber
                Case 1
                    ControlPanel.btnLifeline1.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline1)
                    HostScreen.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
                    GuestScreen.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
                    TVControlPnl.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
                Case 2
                    ControlPanel.btnLifeline2.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline2)
                    HostScreen.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
                    GuestScreen.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
                    TVControlPnl.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
                Case 3
                    ControlPanel.btnLifeline3.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline3)
                    HostScreen.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
                    GuestScreen.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
                    TVControlPnl.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
                Case 4
                    ControlPanel.btnLifeline4.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline4)
                    HostScreen.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
                    GuestScreen.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
                    TVControlPnl.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
            End Select
        End If
    End Sub

    Public Shared Function GetLifelineImage(Lifeline As String)
        Select Case Lifeline
            Case "ask_audience"
                Return My.Resources.ll_audience
            Case "50_50"
                Return My.Resources.ll_5050
            Case "plus_one"
                Return My.Resources.ll_plusone
            Case "switch"
                Return My.Resources.ll_switch
            Case "double_dip"
                Return My.Resources.ll_double
            Case "ask_host"
                Return My.Resources.ll_host
        End Select
        Return vbNull
    End Function

    Public Shared Function GetLifelineBlingImage(Lifeline As String)
        Select Case Lifeline
            Case "ask_audience"
                Return My.Resources.ll_audience_bling
            Case "50_50"
                Return My.Resources.ll_5050_bling
            Case "plus_one"
                Return My.Resources.ll_plusone_bling
            Case "switch"
                Return My.Resources.ll_switch_bling
            Case "double_dip"
                Return My.Resources.ll_double_bling
            Case "ask_host"
                Return My.Resources.ll_host_bling
        End Select

        Return vbNull
    End Function

    Public Shared Function GetLifelineUsedImage(Lifeline As String)
        Select Case Lifeline
            Case "ask_audience"
                Return My.Resources.ll_audience_used
            Case "50_50"
                Return My.Resources.ll_5050_used
            Case "plus_one"
                Return My.Resources.ll_plusone_used
            Case "switch"
                Return My.Resources.ll_switch_used
            Case "double_dip"
                Return My.Resources.ll_double_used
            Case "ask_host"
                Return My.Resources.ll_host_used
        End Select

        Return vbNull
    End Function
End Class
