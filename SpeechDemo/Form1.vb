Public Class Form1

    Dim grammarChanged As Boolean = False
    Dim speechEnabled As Boolean = False
    Dim WithEvents recognizer As Recognizer

    Private Sub textGrammar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textGrammar.TextChanged
        grammarChanged = True
        buttonSetGrammar.Enabled = (grammarChanged And (Not String.IsNullOrEmpty(textGrammar.Text)))
    End Sub

    Private Sub buttonSpeech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSpeech.Click
        If speechEnabled Then
            buttonSpeech.Text = "Enable Speech"
            speechEnabled = False
            recognizer.StopListening()
        Else
            buttonSpeech.Text = "Disable Speech"
            speechEnabled = True
            recognizer.StartListening()
        End If
    End Sub

    Private Sub buttonSetGrammar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSetGrammar.Click
        Dim phrases As New List(Of String)

        phrases.AddRange(textGrammar.Text.Split(vbCrLf))
        If recognizer Is Nothing Then
            recognizer = New Recognizer(phrases)
        Else
            recognizer.LoadGrammar(phrases)
        End If

        If Not buttonSpeech.Enabled Then
            speechEnabled = True
            buttonSpeech.Enabled = True
            buttonSpeech.Text = "Disabled Speech"
            recognizer.StartListening()
        End If
    End Sub

    Private Sub VoiceRecognized(ByVal sender As Object, ByVal e As SpeechEventArgs) Handles recognizer.SpeechRecognized
        textrecognized.Text = textrecognized.Text & e.Result & vbcrlf
    End Sub
End Class
