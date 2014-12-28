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

Partial Public Class WedgeControl

    Private _category As category
    Private _categoryBrush As Brush

    Public Property Category() As category
        Get
            Return _category
        End Get
        Set(ByVal value As category)
            _category = value
            Select Case _category
                Case Trivial_Time.category.Geography : MainWedge.Fill = Brushes.DodgerBlue
                Case Trivial_Time.category.Entertainment : MainWedge.Fill = Brushes.DarkViolet
                Case Trivial_Time.category.History : MainWedge.Fill = Brushes.Gold
                Case Trivial_Time.category.Arts_and_Literature : MainWedge.Fill = Brushes.Firebrick
                Case Trivial_Time.category.Science : MainWedge.Fill = Brushes.ForestGreen
                Case Trivial_Time.category.Sports : MainWedge.Fill = Brushes.DarkOrange
                Case Trivial_Time.category.None : MainWedge.Fill = Brushes.Gray
                Case Else : Throw New Exception("Unspecified category")
            End Select
            _categoryBrush = MainWedge.Fill
        End Set
    End Property

    Private Sub button_MouseEnter() Handles UserControl.MouseEnter
        MainWedge.StrokeThickness = 2
        MainWedge.Stroke = Brushes.Black
    End Sub

    Private Sub button_MouseLeave() Handles UserControl.MouseLeave
        MainWedge.StrokeThickness = 0
        MainWedge.Fill = _categoryBrush
    End Sub

    Private Sub button_MouseDown() Handles UserControl.MouseDown
        MainWedge.Fill = Brushes.White
    End Sub

    Private Sub button_MouseUp() Handles UserControl.MouseUp
        MainWedge.Fill = _categoryBrush
    End Sub

    Public Sub New()
        MyBase.New()

        Me.InitializeComponent()
        ' Insert code required on object creation below this point.
    End Sub
End Class
