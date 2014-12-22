Public Class Question

    Private _question As String
    Private _answers(3) As String
    Private _correctAnswer As String

    Public Property Question() As String
        Get
            Return _Question
        End Get
        Set(ByVal value As String)
            _Question = value
        End Set
    End Property

    Public Property Answer1() As String
        Get
            Return _answers(0)
        End Get
        Set(ByVal value As String)
            _answers(0) = value
        End Set
    End Property

    Public Property Answer2() As String
        Get
            Return _answers(1)
        End Get
        Set(ByVal value As String)
            _answers(1) = value
        End Set
    End Property

    Public Property Answer3() As String
        Get
            Return _answers(2)
        End Get
        Set(ByVal value As String)
            _answers(2) = value
        End Set
    End Property

    Public Property CorrectAnswer() As String
        Get
            Return _correctAnswer
        End Get
        Set(ByVal value As String)
            _correctAnswer = value
        End Set
    End Property

End Class