Public Class LifelineManager

    Public Shared Sub Use(ByVal LifelineNumber As Integer)
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
        End Select
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
