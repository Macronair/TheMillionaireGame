Public Class FastestFingerContestant
    Public ReadOnly Property SlotNumber As Integer   ' max. 8

    Public Sub New(slotNumber As Integer)
        Me.SlotNumber = slotNumber
    End Sub

    Public Property CandidateId As String
    Public Property CandidateName As String
    Public Property ConnectionId As String
    Public Property IsOccupied As Boolean

    Public Property AnswerTimeSeconds As Double?
    Public Property AnswerTimeDisplay As String
    Public Property HasCorrectAnswer As Boolean

    ' 🔄 reconnect
    Public Property ReconnectSecondsLeft As Integer
    Public Property ReconnectTimer As Timer
End Class

Public Class WaitingCandidate
    Public Property CandidateId As String
    Public Property CandidateName As String
    Public Property ConnectionId As String
End Class

Public Class CandidateJoinInfo
    Public Property CandidateId As String
    Public Property CandidateName As String
    Public Property ConnectionId As String
End Class

Public Class CandidateDisconnectInfo
    Public Property CandidateId As String
    Public Property GraceSeconds As Integer
End Class