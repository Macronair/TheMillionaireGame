Public Class LifelineManager

    Public Shared CurrentActive As Integer = 0
    Public Shared Lifeline1_Used As Boolean = False
    Public Shared Lifeline2_Used As Boolean = False
    Public Shared Lifeline3_Used As Boolean = False
    Public Shared Lifeline4_Used As Boolean = False

    Public Shared Lifeline1_Active As Boolean = True
    Public Shared Lifeline2_Active As Boolean = True
    Public Shared Lifeline3_Active As Boolean = True
    Public Shared Lifeline4_Active As Boolean = True

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
                    Case "phone_a_friend"
                        LifelinePhone.LifelineUse1()
                    Case "switch"
                        LifelineSwitch.LifelineUse1()
                    Case "double_dip"
                        LifeLineDouble.LifelineUse1()
                    Case "ask_host"
                        LifelineHost.LifelineUse1()
                End Select
            Case 2
                Select Case Profile.Options.Lifeline2
                    Case "ask_audience"
                        LifelineATA.LifelineUse1()
                    Case "50_50"
                        Lifeline5050.LifelineUse1()
                    Case "plus_one"
                        LifelinePO.LifelineUse1()
                    Case "phone_a_friend"
                        LifelinePhone.LifelineUse1()
                    Case "switch"
                        LifelineSwitch.LifelineUse1()
                    Case "double_dip"
                        LifeLineDouble.LifelineUse1()
                    Case "ask_host"
                        LifelineHost.LifelineUse1()
                End Select
            Case 3
                Select Case Profile.Options.Lifeline3
                    Case "ask_audience"
                        LifelineATA.LifelineUse1()
                    Case "50_50"
                        Lifeline5050.LifelineUse1()
                    Case "plus_one"
                        LifelinePO.LifelineUse1()
                    Case "phone_a_friend"
                        LifelinePhone.LifelineUse1()
                    Case "switch"
                        LifelineSwitch.LifelineUse1()
                    Case "double_dip"
                        LifeLineDouble.LifelineUse1()
                    Case "ask_host"
                        LifelineHost.LifelineUse1()
                End Select
            Case 4
                Select Case Profile.Options.Lifeline4
                    Case "ask_audience"
                        LifelineATA.LifelineUse1()
                    Case "50_50"
                        Lifeline5050.LifelineUse1()
                    Case "plus_one"
                        LifelinePO.LifelineUse1()
                    Case "phone_a_friend"
                        LifelinePhone.LifelineUse1()
                    Case "switch"
                        LifelineSwitch.LifelineUse1()
                    Case "double_dip"
                        LifeLineDouble.LifelineUse1()
                    Case "ask_host"
                        LifelineHost.LifelineUse1()
                End Select
        End Select
    End Sub

    Public Shared Sub UnlockLifeline(ByVal LifelineNumber As Integer)
        Select Case LifelineNumber
            Case 1
                ControlPanel.btnLifeline1.Enabled = False
                ControlPanel.chkLifeline1Unused.Enabled = False
                ControlPanel.btnLL1.Enabled = False
                TVControlPnl.picLifeline1.Visible = False
                HostScreen.picLifeline1.Visible = False
                GuestScreen.picLifeline1.Visible = False

                Lifeline1_Active = False

                If Profile.Options.TotalLifelines >= 1 Then
                    Select Case Profile.Options.Lifeline1_available
                        Case 0
                            ControlPanel.btnLifeline1.Enabled = True
                            ControlPanel.chkLifeline1Unused.Enabled = True
                            ControlPanel.btnLL1.Enabled = True
                            TVControlPnl.picLifeline1.Visible = True
                            HostScreen.picLifeline1.Visible = True
                            GuestScreen.picLifeline1.Visible = True

                            Lifeline1_Active = True
                        Case 1
                            If Game.level >= 5 Then
                                ControlPanel.btnLifeline1.Enabled = True
                                ControlPanel.chkLifeline1Unused.Enabled = True
                                ControlPanel.btnLL1.Enabled = True
                                TVControlPnl.picLifeline1.Visible = True
                                HostScreen.picLifeline1.Visible = True
                                GuestScreen.picLifeline1.Visible = True

                                Lifeline1_Active = True
                            End If
                        Case 2
                            If Game.level >= 10 Then
                                ControlPanel.btnLifeline1.Enabled = True
                                ControlPanel.chkLifeline1Unused.Enabled = True
                                ControlPanel.btnLL1.Enabled = True
                                TVControlPnl.picLifeline1.Visible = True
                                HostScreen.picLifeline1.Visible = True
                                GuestScreen.picLifeline1.Visible = True

                                Lifeline1_Active = True
                            End If
                        Case 3
                            If Game.gamemode = 1 Then
                                ControlPanel.btnLifeline1.Enabled = True
                                ControlPanel.chkLifeline1Unused.Enabled = True
                                ControlPanel.btnLL1.Enabled = True
                                TVControlPnl.picLifeline1.Visible = True
                                HostScreen.picLifeline1.Visible = True
                                GuestScreen.picLifeline1.Visible = True

                                Lifeline1_Active = True
                            End If
                    End Select

                    If Lifeline1_Used = True Then
                        EnableLifeline(1, False)
                    End If
                End If
            Case 2
                ControlPanel.btnLifeline2.Enabled = False
                ControlPanel.chkLifeline2Unused.Enabled = False
                ControlPanel.btnLL2.Enabled = False
                TVControlPnl.picLifeline2.Visible = False
                HostScreen.picLifeline2.Visible = False
                GuestScreen.picLifeline2.Visible = False

                Lifeline2_Active = False
                If Profile.Options.TotalLifelines >= 2 Then
                    Select Case Profile.Options.Lifeline2_available
                        Case 0
                            ControlPanel.btnLifeline2.Enabled = True
                            ControlPanel.chkLifeline2Unused.Enabled = True
                            ControlPanel.btnLL2.Enabled = True
                            TVControlPnl.picLifeline2.Visible = True
                            HostScreen.picLifeline2.Visible = True
                            GuestScreen.picLifeline2.Visible = True

                            Lifeline2_Active = True
                        Case 1
                            If Game.level >= 5 Then
                                ControlPanel.btnLifeline2.Enabled = True
                                ControlPanel.chkLifeline2Unused.Enabled = True
                                ControlPanel.btnLL2.Enabled = True
                                TVControlPnl.picLifeline2.Visible = True
                                HostScreen.picLifeline2.Visible = True
                                GuestScreen.picLifeline2.Visible = True

                                Lifeline2_Active = True
                            End If
                        Case 2
                            If Game.level >= 10 Then
                                ControlPanel.btnLifeline2.Enabled = True
                                ControlPanel.chkLifeline2Unused.Enabled = True
                                ControlPanel.btnLL2.Enabled = True
                                TVControlPnl.picLifeline2.Visible = True
                                HostScreen.picLifeline2.Visible = True
                                GuestScreen.picLifeline2.Visible = True

                                Lifeline2_Active = True
                            End If
                        Case 3
                            If Game.gamemode = 1 Then
                                ControlPanel.btnLifeline2.Enabled = True
                                ControlPanel.chkLifeline2Unused.Enabled = True
                                ControlPanel.btnLL2.Enabled = True
                                TVControlPnl.picLifeline2.Visible = True
                                HostScreen.picLifeline2.Visible = True
                                GuestScreen.picLifeline2.Visible = True

                                Lifeline2_Active = True
                            End If
                    End Select

                    If Lifeline2_Used = True Then
                        EnableLifeline(2, False)
                    End If
                End If
            Case 3
                ControlPanel.btnLifeline3.Enabled = False
                ControlPanel.chkLifeline3Unused.Enabled = False
                ControlPanel.btnLL3.Enabled = False
                TVControlPnl.picLifeline3.Visible = False
                HostScreen.picLifeline3.Visible = False
                GuestScreen.picLifeline3.Visible = False

                Lifeline3_Active = False
                If Profile.Options.TotalLifelines >= 3 Then
                    Select Case Profile.Options.Lifeline3_available
                        Case 0
                            ControlPanel.btnLifeline3.Enabled = True
                            ControlPanel.chkLifeline3Unused.Enabled = True
                            ControlPanel.btnLL3.Enabled = True
                            TVControlPnl.picLifeline3.Visible = True
                            HostScreen.picLifeline3.Visible = True
                            GuestScreen.picLifeline3.Visible = True

                            Lifeline3_Active = True
                        Case 1
                            If Game.level >= 5 Then
                                ControlPanel.btnLifeline3.Enabled = True
                                ControlPanel.chkLifeline3Unused.Enabled = True
                                ControlPanel.btnLL3.Enabled = True
                                TVControlPnl.picLifeline3.Visible = True
                                HostScreen.picLifeline3.Visible = True
                                GuestScreen.picLifeline3.Visible = True

                                Lifeline3_Active = True
                            End If
                        Case 2
                            If Game.level >= 10 Then
                                ControlPanel.btnLifeline3.Enabled = True
                                ControlPanel.chkLifeline3Unused.Enabled = True
                                ControlPanel.btnLL3.Enabled = True
                                TVControlPnl.picLifeline3.Visible = True
                                HostScreen.picLifeline3.Visible = True
                                GuestScreen.picLifeline3.Visible = True

                                Lifeline3_Active = True
                            End If
                        Case 3
                            If Game.gamemode = 1 Then
                                ControlPanel.btnLifeline3.Enabled = True
                                ControlPanel.chkLifeline3Unused.Enabled = True
                                ControlPanel.btnLL3.Enabled = True
                                TVControlPnl.picLifeline3.Visible = True
                                HostScreen.picLifeline3.Visible = True
                                GuestScreen.picLifeline3.Visible = True

                                Lifeline3_Active = True
                            End If
                    End Select

                    If Lifeline3_Used = True Then
                        EnableLifeline(3, False)
                    End If
                End If
            Case 4
                ControlPanel.btnLifeline4.Enabled = False
                ControlPanel.chkLifeline4Unused.Enabled = False
                ControlPanel.btnLL4.Enabled = False
                TVControlPnl.picLifeline4.Visible = False
                HostScreen.picLifeline4.Visible = False
                GuestScreen.picLifeline4.Visible = False

                Lifeline4_Active = False

                If Lifeline4_Used = True Then
                    EnableLifeline(4, False)
                End If

                If Profile.Options.TotalLifelines = 4 Then
                    Select Case Profile.Options.Lifeline4_available
                        Case 0
                            ControlPanel.btnLifeline4.Enabled = True
                            ControlPanel.chkLifeline4Unused.Enabled = True
                            ControlPanel.btnLL4.Enabled = True
                            TVControlPnl.picLifeline4.Visible = True
                            HostScreen.picLifeline4.Visible = True
                            GuestScreen.picLifeline4.Visible = True

                            Lifeline4_Active = True
                        Case 1
                            If Game.level >= 5 Then
                                ControlPanel.btnLifeline4.Enabled = True
                                ControlPanel.chkLifeline4Unused.Enabled = True
                                ControlPanel.btnLL4.Enabled = True
                                TVControlPnl.picLifeline4.Visible = True
                                HostScreen.picLifeline4.Visible = True
                                GuestScreen.picLifeline4.Visible = True

                                Lifeline4_Active = True
                            End If
                        Case 2
                            If Game.level >= 10 Then
                                ControlPanel.btnLifeline4.Enabled = True
                                ControlPanel.chkLifeline4Unused.Enabled = True
                                ControlPanel.btnLL4.Enabled = True
                                TVControlPnl.picLifeline4.Visible = True
                                HostScreen.picLifeline4.Visible = True
                                GuestScreen.picLifeline4.Visible = True

                                Lifeline4_Active = True
                            End If
                        Case 3
                            If Game.gamemode = 1 Then
                                ControlPanel.btnLifeline4.Enabled = True
                                ControlPanel.chkLifeline4Unused.Enabled = True
                                ControlPanel.btnLL4.Enabled = True
                                TVControlPnl.picLifeline4.Visible = True
                                HostScreen.picLifeline4.Visible = True
                                GuestScreen.picLifeline4.Visible = True

                                Lifeline4_Active = True
                            End If
                    End Select

                End If
        End Select
    End Sub

    Public Shared Sub EnableLifeline(ByVal LifelineNumber As Integer, ByVal enable As Boolean)
        If enable = True Then
            Select Case LifelineNumber
                Case 1
                    ControlPanel.btnLifeline1.Enabled = True
                    ControlPanel.btnLifeline1.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline1)
                    TVControlPnl.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
                    HostScreen.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
                    GuestScreen.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
                    Lifeline1_Used = False
                    ControlPanel.chkLifeline1Unused.Checked = True
                    ControlPanel.btnLL1.Enabled = True
                Case 2
                    ControlPanel.btnLifeline2.Enabled = True
                    ControlPanel.btnLifeline2.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline2)
                    TVControlPnl.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
                    HostScreen.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
                    GuestScreen.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
                    Lifeline2_Used = False
                    ControlPanel.chkLifeline2Unused.Checked = True
                    ControlPanel.btnLL2.Enabled = True
                Case 3
                    ControlPanel.btnLifeline3.Enabled = True
                    ControlPanel.btnLifeline3.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline3)
                    TVControlPnl.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
                    HostScreen.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
                    GuestScreen.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
                    Lifeline3_Used = False
                    ControlPanel.chkLifeline3Unused.Checked = True
                    ControlPanel.btnLL3.Enabled = True
                Case 4
                    ControlPanel.btnLifeline4.Enabled = True
                    ControlPanel.btnLifeline4.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline4)
                    TVControlPnl.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
                    HostScreen.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
                    GuestScreen.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
                    Lifeline4_Used = False
                    ControlPanel.chkLifeline4Unused.Checked = True
                    ControlPanel.btnLL4.Enabled = True
            End Select
        Else
            Select Case LifelineNumber
                Case 1
                    ControlPanel.btnLifeline1.Enabled = False
                    ControlPanel.btnLifeline1.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline1)
                    TVControlPnl.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
                    HostScreen.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
                    GuestScreen.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
                    Lifeline1_Used = True
                    ControlPanel.chkLifeline1Unused.Checked = False
                    ControlPanel.btnLL1.Enabled = False
                Case 2
                    ControlPanel.btnLifeline2.Enabled = False
                    ControlPanel.btnLifeline2.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline2)
                    TVControlPnl.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
                    HostScreen.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
                    GuestScreen.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
                    Lifeline2_Used = True
                    ControlPanel.chkLifeline2Unused.Checked = False
                    ControlPanel.btnLL2.Enabled = False
                Case 3
                    ControlPanel.btnLifeline3.Enabled = False
                    ControlPanel.btnLifeline3.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline3)
                    TVControlPnl.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
                    HostScreen.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
                    GuestScreen.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
                    Lifeline3_Used = True
                    ControlPanel.chkLifeline3Unused.Checked = False
                    ControlPanel.btnLL3.Enabled = False
                Case 4
                    ControlPanel.btnLifeline4.Enabled = False
                    ControlPanel.btnLifeline4.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline4)
                    TVControlPnl.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
                    HostScreen.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
                    GuestScreen.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
                    Lifeline4_Used = True
                    ControlPanel.chkLifeline4Unused.Checked = False
                    ControlPanel.btnLL4.Enabled = False
            End Select
        End If

    End Sub

    Public Shared Sub RefreshLifelineImages()
        Select Case Lifeline1_Used
            Case True
                TVControlPnl.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
                ControlPanel.btnLifeline1.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline1)
                HostScreen.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
                GuestScreen.picLifeline1.Image = GetLifelineUsedImage(Profile.Options.Lifeline1)
            Case False
                TVControlPnl.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
                ControlPanel.btnLifeline1.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline1)
                HostScreen.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
                GuestScreen.picLifeline1.Image = GetLifelineImage(Profile.Options.Lifeline1)
        End Select

        Select Case Lifeline2_Used
            Case True
                TVControlPnl.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
                ControlPanel.btnLifeline2.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline2)
                HostScreen.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
                GuestScreen.picLifeline2.Image = GetLifelineUsedImage(Profile.Options.Lifeline2)
            Case False
                TVControlPnl.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
                ControlPanel.btnLifeline2.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline2)
                HostScreen.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
                GuestScreen.picLifeline2.Image = GetLifelineImage(Profile.Options.Lifeline2)
        End Select

        Select Case Lifeline3_Used
            Case True
                TVControlPnl.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
                ControlPanel.btnLifeline3.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline3)
                HostScreen.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
                GuestScreen.picLifeline3.Image = GetLifelineUsedImage(Profile.Options.Lifeline3)
            Case False
                TVControlPnl.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
                ControlPanel.btnLifeline3.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline3)
                HostScreen.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
                GuestScreen.picLifeline3.Image = GetLifelineImage(Profile.Options.Lifeline3)
        End Select

        Select Case Lifeline4_Used
            Case True
                TVControlPnl.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
                ControlPanel.btnLifeline4.BackgroundImage = GetLifelineUsedImage(Profile.Options.Lifeline4)
                HostScreen.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
                GuestScreen.picLifeline4.Image = GetLifelineUsedImage(Profile.Options.Lifeline4)
            Case False
                TVControlPnl.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
                ControlPanel.btnLifeline4.BackgroundImage = GetLifelineImage(Profile.Options.Lifeline4)
                HostScreen.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
                GuestScreen.picLifeline4.Image = GetLifelineImage(Profile.Options.Lifeline4)
        End Select
    End Sub

    Public Shared Function GetLifelineImage(Lifeline As String)
        Select Case Lifeline
            Case "ask_audience"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Audience
                    Case 1
                        Return My.Resources._02_LL_Audience
                    Case 2
                        Return My.Resources._03_LL_Audience
                    Case 3
                        Return My.Resources._04_LL_Audience
                    Case 4
                        Return My.Resources._05_LL_Audience
                End Select
            Case "50_50"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_5050
                    Case 1
                        Return My.Resources._02_LL_5050
                    Case 2
                        Return My.Resources._03_LL_5050
                    Case 3
                        Return My.Resources._04_LL_5050
                    Case 4
                        Return My.Resources._05_LL_5050
                End Select
            Case "plus_one"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Plus
                    Case 1
                        Return My.Resources._02_LL_Plus
                    Case 2
                        Return My.Resources._03_LL_Plus
                    Case 3
                        Return My.Resources._04_LL_Plus
                    Case 4
                        Return My.Resources._05_LL_Plus
                End Select
            Case "phone_a_friend"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Phone
                    Case 1
                        Return My.Resources._02_LL_Phone
                    Case 2
                        Return My.Resources._03_LL_Phone
                    Case 3
                        Return My.Resources._04_LL_Phone
                    Case 4
                        Return My.Resources._05_LL_Phone
                End Select
            Case "switch"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Switch
                    Case 1
                        Return My.Resources._02_LL_Switch
                    Case 2
                        Return My.Resources._03_LL_Switch
                    Case 3
                        Return My.Resources._04_LL_Switch
                    Case 4
                        Return My.Resources._05_LL_Switch
                End Select
            Case "double_dip"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Double
                    Case 1
                        Return My.Resources._02_LL_Double
                    Case 2
                        Return My.Resources._03_LL_Double
                    Case 3
                        Return My.Resources._04_LL_Double
                    Case 4
                        Return My.Resources._05_LL_Double
                End Select
            Case "ask_host"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Host
                    Case 1
                        Return My.Resources._02_LL_Host
                    Case 2
                        Return My.Resources._03_LL_Host
                    Case 3
                        Return My.Resources._04_LL_Host
                    Case 4
                        Return My.Resources._05_LL_Host
                End Select
        End Select

        Return vbNull
    End Function

    Public Shared Function GetLifelineBlingImage(Lifeline As String)
        Select Case Lifeline
            Case "ask_audience"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Audience_select
                    Case 1
                        Return My.Resources._02_LL_Audience_select
                    Case 2
                        Return My.Resources._03_LL_Audience_select
                    Case 3
                        Return My.Resources._04_LL_Audience_select
                    Case 4
                        Return My.Resources._05_LL_Audience_select
                End Select
            Case "50_50"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_5050_select
                    Case 1
                        Return My.Resources._02_LL_5050_select
                    Case 2
                        Return My.Resources._03_LL_5050_select
                    Case 3
                        Return My.Resources._04_LL_5050_select
                    Case 4
                        Return My.Resources._05_LL_5050_select
                End Select
            Case "plus_one"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Plus_select
                    Case 1
                        Return My.Resources._02_LL_Plus_select
                    Case 2
                        Return My.Resources._03_LL_Plus_select
                    Case 3
                        Return My.Resources._04_LL_Plus_select
                    Case 4
                        Return My.Resources._05_LL_Plus_select
                End Select
            Case "phone_a_friend"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Phone_select
                    Case 1
                        Return My.Resources._02_LL_Phone_select
                    Case 2
                        Return My.Resources._03_LL_Phone_select
                    Case 3
                        Return My.Resources._04_LL_Phone_select
                    Case 4
                        Return My.Resources._05_LL_Phone_select
                End Select
            Case "switch"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Switch_select
                    Case 1
                        Return My.Resources._02_LL_Switch_select
                    Case 2
                        Return My.Resources._03_LL_Switch_select
                    Case 3
                        Return My.Resources._04_LL_Switch_select
                    Case 4
                        Return My.Resources._05_LL_Switch_select
                End Select
            Case "double_dip"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Double_select
                    Case 1
                        Return My.Resources._02_LL_Double_select
                    Case 2
                        Return My.Resources._03_LL_Double_select
                    Case 3
                        Return My.Resources._04_LL_Double_select
                    Case 4
                        Return My.Resources._05_LL_Double_select
                End Select
            Case "ask_host"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Host_select
                    Case 1
                        Return My.Resources._02_LL_Host_select
                    Case 2
                        Return My.Resources._03_LL_Host_select
                    Case 3
                        Return My.Resources._04_LL_Host_select
                    Case 4
                        Return My.Resources._05_LL_Host_select
                End Select
        End Select

        Return vbNull
    End Function

    Public Shared Function GetLifelineUsedImage(Lifeline As String)
        Select Case Lifeline
            Case "ask_audience"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Audience_used
                    Case 1
                        Return My.Resources._02_LL_Audience_used
                    Case 2
                        Return My.Resources._03_LL_Audience_used
                    Case 3
                        Return My.Resources._04_LL_Audience_used
                    Case 4
                        Return My.Resources._05_LL_Audience_used
                End Select
            Case "50_50"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_5050_used
                    Case 1
                        Return My.Resources._02_LL_5050_used
                    Case 2
                        Return My.Resources._03_LL_5050_used
                    Case 3
                        Return My.Resources._04_LL_5050_used
                    Case 4
                        Return My.Resources._05_LL_5050_used
                End Select
            Case "plus_one"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Plus_used
                    Case 1
                        Return My.Resources._02_LL_Plus_used
                    Case 2
                        Return My.Resources._03_LL_Plus_used
                    Case 3
                        Return My.Resources._04_LL_Plus_used
                    Case 4
                        Return My.Resources._05_LL_Plus_used
                End Select
            Case "phone_a_friend"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Phone_used
                    Case 1
                        Return My.Resources._02_LL_Phone_used
                    Case 2
                        Return My.Resources._03_LL_Phone_used
                    Case 3
                        Return My.Resources._04_LL_Phone_used
                    Case 4
                        Return My.Resources._05_LL_Phone_used
                End Select
            Case "switch"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Switch_used
                    Case 1
                        Return My.Resources._02_LL_Switch_used
                    Case 2
                        Return My.Resources._03_LL_Switch_used
                    Case 3
                        Return My.Resources._04_LL_Switch_used
                    Case 4
                        Return My.Resources._05_LL_Switch_used
                End Select
            Case "double_dip"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Double_used
                    Case 1
                        Return My.Resources._02_LL_Double_used
                    Case 2
                        Return My.Resources._03_LL_Double_used
                    Case 3
                        Return My.Resources._04_LL_Double_used
                    Case 4
                        Return My.Resources._05_LL_Double_used
                End Select
            Case "ask_host"
                Select Case Profile.Options.QuestionsTexture
                    Case 0
                        Return My.Resources._01_LL_Host_used
                    Case 1
                        Return My.Resources._02_LL_Host_used
                    Case 2
                        Return My.Resources._03_LL_Host_used
                    Case 3
                        Return My.Resources._04_LL_Host_used
                    Case 4
                        Return My.Resources._05_LL_Host_used
                End Select
        End Select

        Return vbNull
    End Function
End Class
