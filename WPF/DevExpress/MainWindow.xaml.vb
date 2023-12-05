Imports System.Text
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.WindowsUI

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Partial Public Class MainWindow
    Inherits ThemedWindow
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Kategoriler_Click(sender As Object, e As RoutedEventArgs)
        Dim kategorilerPage As New Kategoriler()
        NavigationFrame.Navigate(kategorilerPage)
    End Sub

    Private Sub Urunler_Click(sender As Object, e As RoutedEventArgs)
        Dim urunlerPage As New Urunler()
        NavigationFrame.Navigate(urunlerPage)
    End Sub

End Class