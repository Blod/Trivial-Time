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

    Public Property Category() As category
        Get
            Return _category
        End Get
        Set(ByVal value As category)
            _category = value
            Select Case _category
                Case Trivial_Time.category.Geography : Wedge.Fill = Brushes.DodgerBlue
                    Wedge.Stroke = Nothing
                Case Trivial_Time.category.Entertainment : Wedge.Fill = Brushes.DarkViolet
                    Wedge.Stroke = Nothing
                Case Trivial_Time.category.History : Wedge.Fill = Brushes.Goldenrod
                    Wedge.Stroke = Nothing
                Case Trivial_Time.category.Arts_and_Literature : Wedge.Fill = Brushes.Firebrick
                    Wedge.Stroke = Nothing
                Case Trivial_Time.category.Science : Wedge.Fill = Brushes.ForestGreen
                    Wedge.Stroke = Nothing
                Case Trivial_Time.category.Sports : Wedge.Fill = Brushes.DarkOrange
                    Wedge.Stroke = Nothing
                Case Trivial_Time.category.None : Wedge.Fill = Brushes.Gray
                    Wedge.Stroke = Nothing
                Case Else : Throw New Exception("Unspecified category")
            End Select
        End Set
    End Property


    Public Sub New()
        MyBase.New()

        Me.InitializeComponent()
        ' Insert code required on object creation below this point.
    End Sub
End Class
