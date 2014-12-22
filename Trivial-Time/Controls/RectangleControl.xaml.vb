#Region "Imports"
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
#End Region

Partial Public Class RectangleControl

    Private _category As String

    Public Property Category() As String
        Get
            Return _category
        End Get
        Set(ByVal value As String)
            _category = value
        End Set
    End Property

    Public Property isAvailable() As Boolean
        Get
            Return _available
        End Get
        Set(ByVal value As Boolean)
            _available = value
        End Set
    End Property


    Public Sub New()
        MyBase.New()

        Me.InitializeComponent()
    End Sub

End Class