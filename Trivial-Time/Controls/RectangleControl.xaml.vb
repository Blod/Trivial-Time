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

    Private _category As category

    Public Property Category() As category
        Get
            Return _category
        End Get
        Set(ByVal value As category)
            _category = value
            Select Case _category
                Case Trivial_Time.category.Geography : Rectangle.Fill = Brushes.DodgerBlue
                    Rectangle.Stroke = Nothing
                Case Trivial_Time.category.Entertainment : Rectangle.Fill = Brushes.DarkViolet
                    Rectangle.Stroke = Nothing
                Case Trivial_Time.category.History : Rectangle.Fill = Brushes.Goldenrod
                    Rectangle.Stroke = Nothing
                Case Trivial_Time.category.Arts_and_Literature : Rectangle.Fill = Brushes.Firebrick
                    Rectangle.Stroke = Nothing
                Case Trivial_Time.category.Science : Rectangle.Fill = Brushes.ForestGreen
                    Rectangle.Stroke = Nothing
                Case Trivial_Time.category.Sports : Rectangle.Fill = Brushes.DarkOrange
                    Rectangle.Stroke = Nothing
                Case Trivial_Time.category.None : Rectangle.Fill = Brushes.Gray
                    Rectangle.Stroke = Nothing
                Case Else : Throw New Exception("Unspecified category")
            End Select
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub

End Class