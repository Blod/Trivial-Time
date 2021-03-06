﻿#Region "Imports"
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

Partial Public Class HexagonControl

    Private _originalBrush = Brushes.Gray

    Private Sub button_MouseEnter() Handles UserControl.MouseEnter
        MainHexagon.StrokeThickness = 2
        MainHexagon.Stroke = Brushes.Black
    End Sub

    Private Sub button_MouseLeave() Handles UserControl.MouseLeave
        MainHexagon.StrokeThickness = 0
        MainHexagon.Fill = _originalBrush
    End Sub

    Private Sub button_MouseDown() Handles UserControl.MouseDown
        MainHexagon.Fill = Brushes.White
    End Sub

    Private Sub button_MouseUp() Handles UserControl.MouseUp
        MainHexagon.Fill = _originalBrush
    End Sub

    Public Sub New()
        MyBase.New()

        Me.InitializeComponent()

        ' Insert code required on object creation below this point.
    End Sub
End Class
