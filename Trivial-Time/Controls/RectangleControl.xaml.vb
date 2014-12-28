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
    Private _categoryBrush As Brush

    Public Property Category() As category
        Get
            Return _category
        End Get
        Set(ByVal value As category)
            _category = value
            Select Case _category
                Case Trivial_Time.category.Geography : MainRectangle.Fill = Brushes.DodgerBlue
                Case Trivial_Time.category.Entertainment : MainRectangle.Fill = Brushes.DarkViolet
                Case Trivial_Time.category.History : MainRectangle.Fill = Brushes.Gold
                Case Trivial_Time.category.Arts_and_Literature : MainRectangle.Fill = Brushes.Firebrick
                Case Trivial_Time.category.Science : MainRectangle.Fill = Brushes.ForestGreen
                Case Trivial_Time.category.Sports : MainRectangle.Fill = Brushes.DarkOrange
                Case Trivial_Time.category.None : MainRectangle.Fill = Brushes.Gray
                Case Else : Throw New Exception("Unspecified category")
            End Select
            _categoryBrush = MainRectangle.Fill
        End Set
    End Property

#Region "Visual Handlers"
    Private Sub button_MouseEnter() Handles UserControl.MouseEnter
        MainRectangle.StrokeThickness = 2
        MainRectangle.Stroke = Brushes.Black
    End Sub

    Private Sub button_MouseLeave() Handles UserControl.MouseLeave
        MainRectangle.StrokeThickness = 0
        MainRectangle.Fill = _categoryBrush
    End Sub

    Private Sub button_MouseDown() Handles UserControl.MouseDown
        MainRectangle.Fill = Brushes.White
    End Sub

    Private Sub button_MouseUp() Handles UserControl.MouseUp
        MainRectangle.Fill = _categoryBrush
    End Sub

#End Region

   

    Public Sub New()
        MyBase.New()
        Me.InitializeComponent()
    End Sub

End Class