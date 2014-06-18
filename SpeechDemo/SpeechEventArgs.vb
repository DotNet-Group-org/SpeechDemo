Public Class SpeechEventArgs
    Inherits EventArgs

    Private _result As String
    Public Property Result() As String
        Get
            Return _result
        End Get
        Set(ByVal value As String)
            _result = value
        End Set
    End Property

    Public Sub New(ByVal result As String)
        Me.Result = result
    End Sub
End Class