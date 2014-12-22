Imports MySql.Data.MySqlClient
Public Class QuestionReceiver

    Private Const _connecttionString As String = "placeholder"
    Private _questionBuffer As New List(Of Question)
    Private _connection As New MySqlConnection(_connecttionString)
    Public Event QuestionsReceived()

    Public Sub LoadQuestions()
        _connection.Open()
        Dim Command As New MySqlCommand("SELECT * FROM question;", _connection)
        Dim dr As MySqlDataReader = Command.ExecuteReader()
        Do While (dr.Read)
            Dim q As Question = New Question()
            q.Question = dr.Item("TheQuestion")
            q.Answer1 = dr.Item("AnswerA")
            q.Answer2 = dr.Item("AnswerB")
            q.Answer3 = dr.Item("AnswerC")
            q.CorrectAnswer = dr.Item("QuestionSort")
            _questionBuffer.Add(q)
        Loop
        _connection.Close()
        RaiseEvent QuestionsReceived()
    End Sub

End Class
