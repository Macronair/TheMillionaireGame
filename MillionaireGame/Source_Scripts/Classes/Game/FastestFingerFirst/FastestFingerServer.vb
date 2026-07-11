Imports System.ComponentModel
Imports System.Globalization
Imports System.Linq
Imports System.Security.Policy
Imports Microsoft.AspNetCore.SignalR.Client

Public Class FastestFingerServer

#Region "Fields & State"
    Private connection As HubConnection
    Private elapsedTime As Integer = 0

    Private WaitingQueue As New BindingList(Of WaitingCandidate)
    Private PlayerSlots As New List(Of FastestFingerContestant)

    Private SlotTextBoxes As Dictionary(Of Integer, TextBox)
    Private SlotTextBoxesAnswers As Dictionary(Of Integer, TextBox)
    Private SlotTextBoxesTimes As Dictionary(Of Integer, TextBox)
    Private SlotAssignButtons As Dictionary(Of Integer, Button)
    Private SlotClearButtons As Dictionary(Of Integer, Button)
    Private SlotForceButtons As Dictionary(Of Integer, Button)
    Private TVNameLabels As Dictionary(Of Integer, Label)
    Private TVPointLabels As Dictionary(Of Integer, Label)
    Private TVPanels As Dictionary(Of Integer, Panel)

    Public Shared correctOrder As String = ""
    Private winnerSlot As Integer

    Private interact_PlayQuestion As Integer = 0
    Private interact_ShowAnswers As Integer = 0
    Private interact_WhoWasCorrect As Integer = 0
    Private sequence_RevealCorrectPlayers As Integer = 0
#End Region

#Region "Initialization"
    Private Async Sub FastestFingerServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstWaiting.DataSource = WaitingQueue
        lstWaiting.DisplayMember = "CandidateName"
        lstWaiting.ValueMember = "CandidateId"

        Try
            BuildSignalRConnection()

            InitializeSlots()
            InitializeSlotControls()
            InitializeTVSlotControls()
            RegisterSignalREvents()

            Await connection.StartAsync()
            tlblStatus.Text = "Connected with core!"

            RefreshAllSlotUI()
            Await LoadExistingCandidates()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection error")
        End Try
    End Sub

    Private Sub BuildSignalRConnection()
        connection = New HubConnectionBuilder().
        WithUrl("http://localhost:5000/fastestfingerhub").
        WithAutomaticReconnect().
        Build()
    End Sub

    Private Sub RegisterSignalREvents()
        RegisterCandidateHandler()
        RegisterCandidateDisconnectingHandler()
        RegisterCandidateLeftHandler()
        RegisterAnswerHandler()
    End Sub

    Private Sub InitializeSlotControls()

        SlotTextBoxes = New Dictionary(Of Integer, TextBox)
        SlotTextBoxesAnswers = New Dictionary(Of Integer, TextBox)
        SlotTextBoxesTimes = New Dictionary(Of Integer, TextBox)
        SlotAssignButtons = New Dictionary(Of Integer, Button)
        SlotClearButtons = New Dictionary(Of Integer, Button)
        SlotForceButtons = New Dictionary(Of Integer, Button)

        For i = 1 To 8
            SlotTextBoxes(i) = CType(Controls("txtSlot" & i), TextBox)
            SlotTextBoxesAnswers(i) = CType(Controls("txtAnswer" & i), TextBox)
            SlotTextBoxesTimes(i) = CType(Controls("txtTime" & i), TextBox)
            SlotAssignButtons(i) = CType(Controls("btnAssign" & i), Button)
            SlotClearButtons(i) = CType(Controls("btnClear" & i), Button)
            SlotForceButtons(i) = CType(Controls("btnForce" & i), Button)

            AddHandler SlotAssignButtons(i).Click, Sub() AssignSelectedCandidateToSlot(i)
            AddHandler SlotClearButtons(i).Click, Sub() ClearSlot(i)
            AddHandler SlotForceButtons(i).Click, Sub() ForceRemoveSlot(i)
        Next

    End Sub

    Private Sub InitializeTVSlotControls()

        TVNameLabels = New Dictionary(Of Integer, Label) From {
        {1, TVControlPnl.txtPL1_Name},
        {2, TVControlPnl.txtPL2_Name},
        {3, TVControlPnl.txtPL3_Name},
        {4, TVControlPnl.txtPL4_Name},
        {5, TVControlPnl.txtPL5_Name},
        {6, TVControlPnl.txtPL6_Name},
        {7, TVControlPnl.txtPL7_Name},
        {8, TVControlPnl.txtPL8_Name}
    }

        TVPointLabels = New Dictionary(Of Integer, Label) From {
        {1, TVControlPnl.txtPL1_Points},
        {2, TVControlPnl.txtPL2_Points},
        {3, TVControlPnl.txtPL3_Points},
        {4, TVControlPnl.txtPL4_Points},
        {5, TVControlPnl.txtPL5_Points},
        {6, TVControlPnl.txtPL6_Points},
        {7, TVControlPnl.txtPL7_Points},
        {8, TVControlPnl.txtPL8_Points}
    }

        TVPanels = New Dictionary(Of Integer, Panel) From {
        {1, TVControlPnl.pnlPL1},
        {2, TVControlPnl.pnlPL2},
        {3, TVControlPnl.pnlPL3},
        {4, TVControlPnl.pnlPL4},
        {5, TVControlPnl.pnlPL5},
        {6, TVControlPnl.pnlPL6},
        {7, TVControlPnl.pnlPL7},
        {8, TVControlPnl.pnlPL8}
    }

    End Sub

    Private Async Function LoadExistingCandidates() As Task
        Dim candidates =
        Await connection.InvokeAsync(Of List(Of CandidateJoinInfo))(
            "GetConnectedCandidates"
        )

        WaitingQueue.Clear()

        For Each c In candidates

            ' Skip kandidaten die al in een slot zitten
            If PlayerSlots.Any(Function(s) s.CandidateId = c.CandidateId) Then
                Continue For
            End If

            Dim wc As New WaitingCandidate With {
                .CandidateId = c.CandidateId,
                .CandidateName = c.CandidateName,
                .ConnectionId = c.ConnectionId
            }

            AddToWaitingQueue(wc)
        Next
    End Function
#End Region

#Region "Update"
    Private Sub UpdateSlotUI(slot As FastestFingerContestant)

        Dim txt = SlotTextBoxes(slot.SlotNumber)

        If Not slot.IsOccupied Then
            txt.Text = "<vrij>"
            txt.BackColor = Color.LightGray
            TVNameLabels(slot.SlotNumber).Text = ""
            TVPointLabels(slot.SlotNumber).Text = ""
            Return
        End If

        If slot.ReconnectSecondsLeft > 0 Then
            txt.Text = $"{slot.CandidateName} (reconnect {slot.ReconnectSecondsLeft}s)"
            txt.BackColor = Color.Orange
        Else
            txt.Text = slot.CandidateName
            txt.BackColor = Color.LightGreen
            TVNameLabels(slot.SlotNumber).Text = slot.CandidateName
            TVPointLabels(slot.SlotNumber).Text = ""
        End If

    End Sub

    Private Sub RefreshAllSlotUI()
        For Each slot In PlayerSlots
            UpdateSlotUI(slot)
        Next
    End Sub
#End Region

#Region "Handlers"
    Private Sub RegisterCandidateHandler()

        connection.On(Of CandidateJoinInfo)(
        "CandidateJoined",
        Sub(info)

            ' Reconnect?
            Dim slot = PlayerSlots.FirstOrDefault(Function(s) s.CandidateId = info.CandidateId)
            If slot IsNot Nothing Then
                RestoreSlotAfterReconnect(slot, info)
                Return
            End If

            ' Al in wachtrij?
            Dim existing = WaitingQueue.FirstOrDefault(Function(c) c.CandidateId = info.CandidateId)
            If existing IsNot Nothing Then
                existing.ConnectionId = info.ConnectionId
                existing.CandidateName = info.CandidateName
                Return
            End If

            ' Nieuw
            Dim wc As New WaitingCandidate With {
                .CandidateId = info.CandidateId,
                .CandidateName = info.CandidateName,
                .ConnectionId = info.ConnectionId
            }

            Invoke(Sub()
                       AddToWaitingQueue(wc)
                   End Sub)
        End Sub
    )
    End Sub

    Private Sub AddToWaitingQueue(candidate As WaitingCandidate)
        WaitingQueue.Add(candidate)
    End Sub

    Private Sub RegisterAnswerHandler()

        connection.On(Of FastestFingerAnswer)(
        "AnswerReceived",
        Sub(answer)

            Invoke(Sub()

                       ' Determine slot of candidate
                       Dim slot = PlayerSlots.
                    FirstOrDefault(Function(s) s.CandidateId = answer.CandidateId)

                       If slot Is Nothing Then Return

                       ' Convert answer order to letters
                       Dim givenOrder As String = OrderToLetters(answer.Order)

                       ' Show answer in UI
                       SlotTextBoxesAnswers(slot.SlotNumber).Text = givenOrder

                       ' Only correct answers get a time displayed
                       If givenOrder = correctOrder Then
                           Dim seconds As Double =
                               Math.Round(answer.ElapsedMilliseconds / 1000.0, 2)

                           slot.HasCorrectAnswer = True
                           slot.AnswerTimeSeconds = seconds
                           slot.AnswerTimeDisplay = seconds.ToString("0.00", CultureInfo.InvariantCulture) & " s"

                           SlotTextBoxesTimes(slot.SlotNumber).Text = slot.AnswerTimeDisplay
                       Else
                           slot.HasCorrectAnswer = False
                           slot.AnswerTimeSeconds = Nothing
                           slot.AnswerTimeDisplay = "—"

                           SlotTextBoxesTimes(slot.SlotNumber).Text = "—"
                       End If


                   End Sub)

        End Sub
    )

    End Sub

    Private Function OrderToLetters(order As List(Of Integer)) As String
        Return String.Concat(
        order.Select(Function(i) Chr(64 + i))
    )
    End Function

    Private Sub RegisterCandidateDisconnectingHandler()
        connection.On(Of CandidateDisconnectInfo)(
        "CandidateDisconnecting",
        Sub(info)
            Dim slot = PlayerSlots.FirstOrDefault(Function(s) s.CandidateId = info.CandidateId)
            If slot Is Nothing Then Return

            StartReconnectTimer(slot, info.GraceSeconds)
        End Sub
    )
    End Sub

    Private Sub RegisterCandidateLeftHandler()
        connection.On(Of String)(
        "CandidateLeft",
        Sub(candidateId)

            Invoke(Sub()
                       ' 1️⃣ Remove from waiting queue
                       Dim waiting = WaitingQueue.
                    FirstOrDefault(Function(c) c.CandidateId = candidateId)
                       If waiting IsNot Nothing Then
                           WaitingQueue.Remove(waiting)
                       End If

                       ' 2️⃣ Remove from slot
                       Dim slot = PlayerSlots.
                    FirstOrDefault(Function(s) s.CandidateId = candidateId)
                       If slot IsNot Nothing Then

                           If slot.ReconnectTimer IsNot Nothing Then
                               slot.ReconnectTimer.Stop()
                               slot.ReconnectTimer = Nothing
                           End If

                           slot.IsOccupied = False
                           slot.CandidateId = Nothing
                           slot.CandidateName = Nothing
                           slot.ConnectionId = Nothing
                           slot.ReconnectSecondsLeft = 0

                           UpdateSlotUI(slot)
                       End If
                   End Sub)
        End Sub
    )
    End Sub

    Private Sub DetermineWinner()
        Dim winner =
        PlayerSlots _
        .Where(Function(s) s.IsOccupied AndAlso s.HasCorrectAnswer) _
        .OrderBy(Function(s) s.AnswerTimeSeconds) _
        .FirstOrDefault()

        If winner Is Nothing Then
            lblWinner.Text = "Winner: None"
            Return
        End If

        lblWinner.Text =
        $"Winner: Slot {winner.SlotNumber}, " &
        $"{winner.CandidateName}"

        winnerSlot = winner.SlotNumber
    End Sub
#End Region

#Region "Reconnect"
    Private Sub RestoreSlotAfterReconnect(slot As FastestFingerContestant, info As CandidateJoinInfo)

        slot.ConnectionId = info.ConnectionId
        slot.CandidateName = info.CandidateName
        slot.ReconnectSecondsLeft = 0

        If slot.ReconnectTimer IsNot Nothing Then
            slot.ReconnectTimer.Stop()
            slot.ReconnectTimer = Nothing
        End If

        UpdateSlotUI(slot)

        connection.InvokeAsync("AssignSlot", info.ConnectionId, slot.SlotNumber)

    End Sub

    Private Sub StartReconnectTimer(slot As FastestFingerContestant, seconds As Integer)

        slot.ReconnectSecondsLeft = seconds
        slot.ReconnectTimer = New Timer With {.Interval = 1000}

        AddHandler slot.ReconnectTimer.Tick,
        Sub()
            slot.ReconnectSecondsLeft -= 1
            UpdateSlotUI(slot)

            If slot.ReconnectSecondsLeft <= 0 Then
                slot.ReconnectTimer.Stop()
            End If
        End Sub

        slot.ReconnectTimer.Start()
    End Sub
#End Region

#Region "Slots"
    Private Sub InitializeSlots()
        PlayerSlots.Clear()
        For i = 1 To 8
            PlayerSlots.Add(New FastestFingerContestant(i))
        Next
    End Sub

    Private Async Sub AssignSelectedCandidateToSlot(slotNumber As Integer)

        If lstWaiting.SelectedItem Is Nothing Then Return

        Dim selected = TryCast(lstWaiting.SelectedItem, WaitingCandidate)
        If selected Is Nothing Then Return

        Dim candidate = WaitingQueue.FirstOrDefault(Function(c) c.CandidateId = selected.CandidateId)
        If candidate Is Nothing Then
            MessageBox.Show("Kandidaat niet gevonden in wachtrij.")
            Return
        End If

        Dim slot = PlayerSlots.FirstOrDefault(Function(s) s.SlotNumber = slotNumber)
        If slot Is Nothing Then
            MessageBox.Show("Ongeldig slotnummer.")
            Return
        End If

        slot.CandidateId = candidate.CandidateId
        slot.CandidateName = candidate.CandidateName
        slot.ConnectionId = candidate.ConnectionId
        slot.IsOccupied = True

        UpdateSlotUI(slot)

        WaitingQueue.Remove(candidate)

        Await connection.InvokeAsync(
            "AssignSlot",
            slot.ConnectionId,
            slot.SlotNumber
        )
    End Sub

    Private Sub ClearSlot(slotNumber As Integer)

        Dim slot = PlayerSlots.FirstOrDefault(Function(s) s.SlotNumber = slotNumber)
        If slot Is Nothing OrElse Not slot.IsOccupied Then Return

        ' Kandidaat-data tijdelijk bewaren
        Dim candidateId = slot.CandidateId
        Dim candidateName = slot.CandidateName
        Dim connectionId = slot.ConnectionId

        ' Slot leegmaken
        slot.IsOccupied = False
        slot.CandidateId = Nothing
        slot.CandidateName = Nothing
        slot.ConnectionId = Nothing
        slot.ReconnectSecondsLeft = 0

        If slot.ReconnectTimer IsNot Nothing Then
            slot.ReconnectTimer.Stop()
            slot.ReconnectTimer = Nothing
        End If

        UpdateSlotUI(slot)

        ' Kandidaat terug naar wachtrij (alleen als hij nog verbonden is)
        If Not String.IsNullOrEmpty(candidateId) Then
            If Not WaitingQueue.Any(Function(c) c.CandidateId = candidateId) Then
                WaitingQueue.Add(New WaitingCandidate With {
                    .CandidateId = candidateId,
                    .CandidateName = candidateName,
                    .ConnectionId = connectionId
                })
            End If
        End If

    End Sub


    Private Async Sub ForceRemoveSlot(slotNumber As Integer)

        Dim slot = PlayerSlots.FirstOrDefault(Function(s) s.SlotNumber = slotNumber)
        If slot Is Nothing OrElse Not slot.IsOccupied Then Return

        ' 1️⃣ Reconnect-timer stoppen
        If slot.ReconnectTimer IsNot Nothing Then
            slot.ReconnectTimer.Stop()
            slot.ReconnectTimer = Nothing
        End If

        Dim candidateId = slot.CandidateId

        ' 2️⃣ Slot lokaal leegmaken
        slot.IsOccupied = False
        slot.CandidateId = Nothing
        slot.CandidateName = Nothing
        slot.ConnectionId = Nothing
        slot.ReconnectSecondsLeft = 0

        UpdateSlotUI(slot)

        ' 3️⃣ Server expliciet informeren
        Await connection.InvokeAsync("ForceRemoveCandidate", candidateId)
    End Sub
#End Region

    Private Async Sub btnPlayQuestion_Click(sender As Object, e As EventArgs) Handles btnPlayQuestion.Click
        Select Case interact_PlayQuestion
            Case 0
                interact_WhoWasCorrect = 0
                interact_ShowAnswers = 0

                Game.level = -1
                HostScreen.pnlAnswer.BackColor = Color.Black
                ControlPanel.txtA.BackColor = SystemColors.Control
                ControlPanel.txtB.BackColor = SystemColors.Control
                ControlPanel.txtC.BackColor = SystemColors.Control
                ControlPanel.txtD.BackColor = SystemColors.Control

                HostScreen.txtA.ForeColor = Color.White
                HostScreen.txtB.ForeColor = Color.White
                HostScreen.txtC.ForeColor = Color.White
                HostScreen.txtD.ForeColor = Color.White
                HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
                HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
                HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
                HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
                GuestScreen.txtA.ForeColor = Color.White
                GuestScreen.txtB.ForeColor = Color.White
                GuestScreen.txtC.ForeColor = Color.White
                GuestScreen.txtD.ForeColor = Color.White
                GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
                GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
                GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
                GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
                TVControlPnl.txtA.ForeColor = Color.White
                TVControlPnl.txtB.ForeColor = Color.White
                TVControlPnl.txtC.ForeColor = Color.White
                TVControlPnl.txtD.ForeColor = Color.White
                HostScreen.txtATAa.ForeColor = Color.White
                HostScreen.txtATAb.ForeColor = Color.White
                HostScreen.txtATAc.ForeColor = Color.White
                HostScreen.txtATAd.ForeColor = Color.White
                GuestScreen.txtATAa.ForeColor = Color.White
                GuestScreen.txtATAb.ForeColor = Color.White
                GuestScreen.txtATAc.ForeColor = Color.White
                GuestScreen.txtATAd.ForeColor = Color.White

                HostScreen.txtATAa.Text = ""
                HostScreen.txtATAb.Text = ""
                HostScreen.txtATAc.Text = ""
                HostScreen.txtATAd.Text = ""
                GuestScreen.txtATAa.Text = ""
                GuestScreen.txtATAb.Text = ""
                GuestScreen.txtATAc.Text = ""
                GuestScreen.txtATAd.Text = ""
                TVControlPnl.txtA.Text = ""
                TVControlPnl.txtB.Text = ""
                TVControlPnl.txtC.Text = ""
                TVControlPnl.txtD.Text = ""
                HostScreen.txtA.Text = ""
                HostScreen.txtB.Text = ""
                HostScreen.txtC.Text = ""
                HostScreen.txtD.Text = ""
                GuestScreen.txtA.Text = ""
                GuestScreen.txtB.Text = ""
                GuestScreen.txtC.Text = ""
                GuestScreen.txtD.Text = ""

                TVControlPnl.picTree.BackgroundImage = MoneyTreeCore.GetTreeImage()
                TVControlPnl.picLifeline1.Visible = False
                TVControlPnl.picLifeline2.Visible = False
                TVControlPnl.picLifeline3.Visible = False
                TVControlPnl.picLifeline4.Visible = False

                Dim q As New QDatabase
                q.getQuestion()

                With Sounds.fff_question
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_ReadQuestion
                    .controls.play()
                End With

                TVControlPnl.picA.BackgroundImage = QuestionStrap.GetTexture(2)
                TVControlPnl.picB.BackgroundImage = QuestionStrap.GetTexture(3)
                TVControlPnl.picC.BackgroundImage = QuestionStrap.GetTexture(2)
                TVControlPnl.picD.BackgroundImage = QuestionStrap.GetTexture(3)

                HostScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
                TVControlPnl.txtQuestion.Text = ControlPanel.txtQuestion.Text
                GuestScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
                HostScreen.lblAnswer.Text = ControlPanel.lblAnswer.Text
                HostScreen.txtExplain.Text = ControlPanel.txtExplain.Text

                correctOrder = ControlPanel.lblAnswer.Text.ToUpper()

                FastestFingerQuestion.FillAnswers()

                Dim question = New With {
                    .QuestionId = 1,
                    .Question = ControlPanel.txtQuestion.Text,
                    .Answers = New List(Of String) From {
                        ControlPanel.txtA.Text,
                        ControlPanel.txtB.Text,
                        ControlPanel.txtC.Text,
                        ControlPanel.txtD.Text
                    }
                }

                Await connection.InvokeAsync("SendQuestion", question)
                interact_PlayQuestion = 1
            Case 1
                ControlPanel.chkShowQuestion.Checked = True
        End Select
    End Sub

    Private Sub btnStartTImerShowAnswers_Click(sender As Object, e As EventArgs) Handles btnStartTImerShowAnswers.Click
        With Sounds.fff_st1
            .URL = Sounds.SoundsPath + Profile.Options.snd_F_ThreeNotes
            .controls.play()
        End With

        Sounds.fff_question.controls.stop()

        HostScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
        GuestScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
        TVControlPnl.txtA.Text = "A: " & ControlPanel.txtA.Text
        TVControlPnl.txtA.Visible = True
        HostScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
        GuestScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
        TVControlPnl.txtB.Text = "B: " & ControlPanel.txtB.Text
        TVControlPnl.txtB.Visible = True
        HostScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
        GuestScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
        TVControlPnl.txtC.Text = "C: " & ControlPanel.txtC.Text
        TVControlPnl.txtC.Visible = True
        HostScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
        GuestScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
        TVControlPnl.txtD.Text = "D: " & ControlPanel.txtD.Text
        TVControlPnl.txtD.Visible = True

        ' After the three notes, show the answers and start the timer
        tmrPlayAfterThreeNotes.Start()
    End Sub

    Private Async Sub tmrPlayAfterThreeNotes_Tick(sender As Object, e As EventArgs) Handles tmrPlayAfterThreeNotes.Tick
        With Sounds.fff_st2
            .URL = Sounds.SoundsPath + Profile.Options.snd_F_Thinking
            .controls.play()
        End With

        Await connection.InvokeAsync("StartTimer", 20)

        tmrThinking.Start()
        tmrPlayAfterThreeNotes.Stop()
    End Sub

    Private Async Sub tmrThinking_Tick(sender As Object, e As EventArgs) Handles tmrThinking.Tick
        elapsedTime += 1
        If elapsedTime >= 20 Then
            tmrThinking.Stop()
            elapsedTime = 0
            Await connection.InvokeAsync("StopAnswers")
            DetermineWinner()
        End If
    End Sub

    Private Async Sub btnStopTimerLockAnswers_Click(sender As Object, e As EventArgs) Handles btnStopTimerLockAnswers.Click
        Await connection.InvokeAsync("StopAnswers")
        DetermineWinner()
    End Sub

    Private Async Sub btnClearReset_Click(sender As Object, e As EventArgs) Handles btnClearReset.Click
        ' Only reset game state, not the slots
        elapsedTime = 0
        WaitingQueue.Clear()

        winnerSlot = Nothing
        lblWinner.Text = "Winner: "

        For Each slot In PlayerSlots
            slot.HasCorrectAnswer = False
            slot.AnswerTimeDisplay = ""
            slot.AnswerTimeSeconds = Nothing
            SlotTextBoxesTimes(slot.SlotNumber).Clear()
            SlotTextBoxesAnswers(slot.SlotNumber).Clear()
        Next

        Await connection.InvokeAsync("ClearRound")
    End Sub

    Private Async Sub FastestFingerServer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If connection IsNot Nothing Then
            Await connection.DisposeAsync()
        End If
    End Sub

    Private Sub btnAssign1_Click(sender As Object, e As EventArgs) Handles btnAssign1.Click
        AssignSelectedCandidateToSlot(1)
    End Sub

    Private Sub btnAssign2_Click(sender As Object, e As EventArgs) Handles btnAssign2.Click
        AssignSelectedCandidateToSlot(2)
    End Sub

    Private Sub btnAssign3_Click(sender As Object, e As EventArgs) Handles btnAssign3.Click
        AssignSelectedCandidateToSlot(3)
    End Sub

    Private Sub btnAssign4_Click(sender As Object, e As EventArgs) Handles btnAssign4.Click
        AssignSelectedCandidateToSlot(4)
    End Sub

    Private Sub btnAssign5_Click(sender As Object, e As EventArgs) Handles btnAssign5.Click
        AssignSelectedCandidateToSlot(5)
    End Sub

    Private Sub btnAssign6_Click(sender As Object, e As EventArgs) Handles btnAssign6.Click
        AssignSelectedCandidateToSlot(6)
    End Sub

    Private Sub btnAssign7_Click(sender As Object, e As EventArgs) Handles btnAssign7.Click
        AssignSelectedCandidateToSlot(7)
    End Sub

    Private Sub btnAssign8_Click(sender As Object, e As EventArgs) Handles btnAssign8.Click
        AssignSelectedCandidateToSlot(8)
    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        ClearSlot(1)
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        ClearSlot(2)
    End Sub

    Private Sub btnClear3_Click(sender As Object, e As EventArgs) Handles btnClear3.Click
        ClearSlot(3)
    End Sub

    Private Sub btnClear4_Click(sender As Object, e As EventArgs) Handles btnClear4.Click
        ClearSlot(4)
    End Sub

    Private Sub btnClear5_Click(sender As Object, e As EventArgs) Handles btnClear5.Click
        ClearSlot(5)
    End Sub

    Private Sub btnClear6_Click(sender As Object, e As EventArgs) Handles btnClear6.Click
        ClearSlot(6)
    End Sub

    Private Sub btnClear7_Click(sender As Object, e As EventArgs) Handles btnClear7.Click
        ClearSlot(7)
    End Sub

    Private Sub btnClear8_Click(sender As Object, e As EventArgs) Handles btnClear8.Click
        ClearSlot(8)
    End Sub

    Private Sub btnForce1_Click(sender As Object, e As EventArgs) Handles btnForce1.Click
        ForceRemoveSlot(1)
    End Sub

    Private Sub btnForce2_Click(sender As Object, e As EventArgs) Handles btnForce2.Click
        ForceRemoveSlot(2)
    End Sub

    Private Sub btnForce3_Click(sender As Object, e As EventArgs) Handles btnForce3.Click
        ForceRemoveSlot(3)
    End Sub

    Private Sub btnForce4_Click(sender As Object, e As EventArgs) Handles btnForce4.Click
        ForceRemoveSlot(4)
    End Sub

    Private Sub btnForce5_Click(sender As Object, e As EventArgs) Handles btnForce5.Click
        ForceRemoveSlot(5)
    End Sub

    Private Sub btnForce6_Click(sender As Object, e As EventArgs) Handles btnForce6.Click
        ForceRemoveSlot(6)
    End Sub

    Private Sub btnForce7_Click(sender As Object, e As EventArgs) Handles btnForce7.Click
        ForceRemoveSlot(7)
    End Sub

    Private Sub btnForce8_Click(sender As Object, e As EventArgs) Handles btnForce8.Click
        ForceRemoveSlot(8)
    End Sub

    Private Sub btnCorrectOrderSequence_Click(sender As Object, e As EventArgs) Handles btnCorrectOrderSequence.Click
        Select Case interact_ShowAnswers
            Case 0
                ControlPanel.chkShowQuestion.Checked = False
                interact_ShowAnswers = 1
                Return
            Case 1
                With Sounds.fff_st1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_ReadCorrectOrder
                    .settings.setMode("Loop", True)
                    .controls.play()
                End With
                interact_ShowAnswers = 2
                Return
            Case 2
                TVControlPnl.lblFFFQuestion.Visible = True
                TVControlPnl.picTree.Visible = True
                interact_ShowAnswers = 3
                Return
            Case 3
                TVControlPnl.pnlFFFOrder1.Visible = True
                Dim order As New WMPLib.WindowsMediaPlayer
                With order
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Order1
                    .controls.play()
                End With
                interact_ShowAnswers = 4
                Return
            Case 4
                TVControlPnl.pnlFFFOrder2.Visible = True
                Dim order As New WMPLib.WindowsMediaPlayer
                With order
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Order2
                    .controls.play()
                End With
                interact_ShowAnswers = 5
                Return
            Case 5
                TVControlPnl.pnlFFFOrder3.Visible = True
                Dim order As New WMPLib.WindowsMediaPlayer
                With order
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Order3
                    .controls.play()
                End With
                interact_ShowAnswers = 6
                Return
            Case 6
                TVControlPnl.pnlFFFOrder4.Visible = True
                Dim order As New WMPLib.WindowsMediaPlayer
                With order
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Order4
                    .controls.play()
                End With
                interact_ShowAnswers = 7
                Return
        End Select
    End Sub

    Private Sub btnWhoWasCorrect_Click(sender As Object, e As EventArgs) Handles btnWhoWasCorrect.Click
        Select Case interact_WhoWasCorrect
            Case 0
                ControlPanel.chkShowPlayerList.Checked = True
                TVControlPnl.picTree.Visible = False
                interact_WhoWasCorrect = 1
            Case 1
                TVControlPnl.lblFFFQuestion.Visible = False
                TVControlPnl.pnlFFFOrder1.Visible = False
                TVControlPnl.pnlFFFOrder2.Visible = False
                TVControlPnl.pnlFFFOrder3.Visible = False
                TVControlPnl.pnlFFFOrder4.Visible = False
                If Game.level = -1 Then
                    tmrShowCorrectPlayersOnList.Start()
                    With Sounds.fff_st1
                        .URL = Sounds.SoundsPath + Profile.Options.snd_F_WhoWasCorrect
                        .settings.setMode("Loop", False)
                        .controls.play()
                    End With
                    Sounds.fff_st2.controls.stop()
                End If
                interact_WhoWasCorrect = 2
            Case 2
                Dim winner = PlayerSlots.FirstOrDefault(Function(s) s.SlotNumber = winnerSlot)

                With Sounds.fff_st2
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Winner
                    .controls.play()
                End With
                TVControlPnl.lblFFFWinnerName.Text = winner.CandidateName
                TVControlPnl.lblFFFWinnerPoints.Text = SlotTextBoxesTimes(winner.SlotNumber).Text
                TVControlPnl.pnlFFFWinner.Visible = True
                interact_WhoWasCorrect = 3
            Case 3
                ControlPanel.chkShowPlayerList.Checked = False
                tmrShowFastestPlayerOnList.Stop()
                interact_WhoWasCorrect = 4
            Case 4
                Game.ChangeLevel(0)
                TVControlPnl.pnlFFFWinner.Visible = False
                interact_WhoWasCorrect = 5
                interact_ShowAnswers = 0
                interact_PlayQuestion = 0
        End Select
    End Sub

    Private Sub ShowCorrectPlayer(slot As FastestFingerContestant)
        If slot Is Nothing OrElse Not slot.HasCorrectAnswer Then Return

        Dim i = slot.SlotNumber

        TVNameLabels(i).ForeColor = Color.Black
        TVPointLabels(i).ForeColor = Color.Black
        TVPointLabels(i).Text = SlotTextBoxesTimes(i).Text
        TVPanels(i).BackgroundImage = My.Resources.fff_correct_new
    End Sub

    Private Sub tmrShowCorrectPlayersOnList_Tick(sender As Object, e As EventArgs) Handles tmrShowCorrectPlayersOnList.Tick
        Dim slotIndex = sequence_RevealCorrectPlayers + 1

        If slotIndex > PlayerSlots.Count Then
            tmrShowCorrectPlayersOnList.Stop()
            tmrShowFastestPlayerOnList.Start()
            Return
        End If

        Dim slot = PlayerSlots.
            FirstOrDefault(Function(s) s.SlotNumber = slotIndex)

        ShowCorrectPlayer(slot)
        sequence_RevealCorrectPlayers += 1
    End Sub

    Dim flash As Boolean = False
    Private Sub tmrShowFastestPlayerOnList_Tick(sender As Object, e As EventArgs) Handles tmrShowFastestPlayerOnList.Tick
        Select Case flash
            Case False
                TVPanels(winnerSlot).BackgroundImage = My.Resources.fff_correct_new
                flash = True
                Return
            Case True
                TVPanels(winnerSlot).BackgroundImage = My.Resources.fff_fastest_new
                flash = False
                Return
        End Select
    End Sub
End Class