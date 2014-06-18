Imports System.Speech
Imports System.Speech.Recognition

Public Class Recognizer
    Protected WithEvents reco As SpeechRecognizer

    Public Event SpeechRecognized(ByVal sender As Object, ByVal e As SpeechEventArgs)

    Public Sub New(ByVal options As List(Of String))
        reco = New SpeechRecognizer
        LoadGrammar(options)
        reco.Enabled = False
    End Sub

    Public Sub LoadGrammar(ByVal options As List(Of String))
        Dim choices As New Choices(options.ToArray)
        Dim gb As New GrammarBuilder(choices)
        Dim g As New Grammar(gb)
        reco.LoadGrammar(g)
    End Sub

    Public Sub StartListening()
        If Not reco Is Nothing Then reco.Enabled = True
    End Sub

    Public Sub StopListening()
        If Not reco Is Nothing Then reco.Enabled = False
    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs) _
    Handles reco.SpeechRecognized
        RaiseEvent SpeechRecognized(Me, New SpeechEventArgs(e.Result.Text))
    End Sub
End Class
