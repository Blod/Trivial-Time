Public Class Player

    Private _name As String
    Private _position As Control
    Private _color As Color

    Private _geography As Boolean
    Private _entertainment As Boolean
    Private _history As Boolean
    Private _artsAndLiterature As Boolean
    Private _science As Boolean
    Private _sports As Boolean

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property HasGeography() As Boolean
        Get
            Return _geography
        End Get
        Set(ByVal value As Boolean)
            _geography = value
        End Set
    End Property

    Public Property HasEntertainment() As Boolean
        Get
            Return _entertainment
        End Get
        Set(ByVal value As Boolean)
            _entertainment = value
        End Set
    End Property

    Public Property HasHistory() As Boolean
        Get
            Return _History
        End Get
        Set(ByVal value As Boolean)
            _History = value
        End Set
    End Property

    Public Property HasArtsAndLiterature() As Boolean
        Get
            Return _artsAndLiterature
        End Get
        Set(ByVal value As Boolean)
            _artsAndLiterature = value
        End Set
    End Property

    Public Property HasScience() As Boolean
        Get
            Return _Science
        End Get
        Set(ByVal value As Boolean)
            _Science = value
        End Set
    End Property

    Public Property HasSports() As Boolean
        Get
            Return _sports
        End Get
        Set(ByVal value As Boolean)
            _sports = value
        End Set
    End Property

End Class
