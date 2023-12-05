Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Kategoriler
    Private Async Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim Name As String = kategoriName.Text
            Dim apiUrl = "https://localhost:44333/api/Kategori"

            ' Kategori nesnesi oluştur
            Dim kategori As New Kategori()
            kategori.Name = Name

            ' HttpClient oluştur
            Using client As New HttpClient()
                ' JSON formatına dönüştür
                Dim json = JsonConvert.SerializeObject(kategori)
                Dim content = New StringContent(json, Encoding.UTF8, "application/json")

                ' POST isteği oluştur ve API'ye gönder
                Dim response = Await client.PostAsync(apiUrl, content)

                ' Yanıtı işle
                If response.IsSuccessStatusCode Then
                    ' Yanıt 200 OK ise
                    Dim responseString = Await response.Content.ReadAsStringAsync()
                    ' Yanıtı işleme
                    MessageBox.Show("İstek başarılı! Yanıt: " & responseString)
                Else
                    ' Hata durumunda
                    MessageBox.Show("İstek başarısız! Durum kodu: " & response.StatusCode.ToString())
                End If
            End Using
        Catch ex As Exception
            ' Hata durumunda
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub

End Class
