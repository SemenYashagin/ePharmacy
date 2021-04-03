Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Security.Authentication
Imports Newtonsoft.Json

Public Class Request
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="URI"></param>
    ''' <returns></returns>
    Public Shared Function GetRecipebyId(ByVal URI As String) As String
        Dim rez_content As String = ""
        Dim request As HttpWebRequest = CType(WebRequest.Create(URI), HttpWebRequest)
        request.Method = "GET"
        request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
        request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhdXRoLnRlc3QuMWVyLmFwcCIsInN1YiI6IjYwNGI0ODMxMDQ5MWJhNmJ" & "lNjBlZmNmMyIsImlhdCI6MTYxNTU0NzAyNywidXNlcklkIjoiNjA0YjQ4MzEwNDkxYmE2YmU2MGVmY2YzIiwidXNlciI6eyJfaWQiOiI2MDRiNDgzMTA0OTFiYTZiZTYw" & "ZWZjZjMiLCJyb2xlcyI6WyJJTlRFR1JBVElPTiJdLCJyb2xlIjoiSU5URUdSQVRJT04iLCJjaGlsZHJlbiI6W119LCJleHAiOjE2NDcwODMwMjd9.O9cdUL9IRHdMBXptUjt" & "3yKb6pWuUWqjzFzLcfBRf60k")

        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

                Using stream As Stream = response.GetResponseStream()

                    Using reader As StreamReader = New StreamReader(stream)
                        rez_content = reader.ReadToEnd()
                        If (rez_content = "[]") Then
                            MessageBox.Show("Вы ввели неверный код")
                        End If
                    End Using
                End Using
            End Using
        Catch e As Exception
            'MessageBox.Show("ERROR-ex" & vbCrLf & e.Message)
        End Try

        Return rez_content
    End Function

    Public Shared Function UpdateRecipeByID(ByVal url As String, ByVal body As Object, ByVal prescription_id As String) As String
        Dim bodyBytes As Byte() = Nothing
        Dim result As String = ""
        Dim jsonBody As String = ""
        url += $"?documentId={prescription_id}"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhdXRoLnRlc3QuMWVyLmFwcCIsInN1YiI6IjYwNGI0ODMxMDQ5MWJhNmJ" & "lNjBlZmNmMyIsImlhdCI6MTYxNTU0NzAyNywidXNlcklkIjoiNjA0YjQ4MzEwNDkxYmE2YmU2MGVmY2YzIiwidXNlciI6eyJfaWQiOiI2MDRiNDgzMTA0OTFiYTZiZTYw" & "ZWZjZjMiLCJyb2xlcyI6WyJJTlRFR1JBVElPTiJdLCJyb2xlIjoiSU5URUdSQVRJT04iLCJjaGlsZHJlbiI6W119LCJleHAiOjE2NDcwODMwMjd9.O9cdUL9IRHdMBXptUjt" & "3yKb6pWuUWqjzFzLcfBRf60k")

        Try
            request.Timeout = 10000
            request.Method = "PUT"
            request.ContentType = "application/json"
            jsonBody = JsonConvert.SerializeObject(body)
            bodyBytes = Encoding.UTF8.GetBytes(jsonBody)
            Dim stream As Stream = request.GetRequestStream()
            stream.Write(bodyBytes, 0, bodyBytes.Length)
            stream.Close()
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream(), Encoding.UTF8)
            result = reader.ReadToEnd()
            MessageBox.Show("Статус изменён успешно")
        Catch e As Exception
            MessageBox.Show("Вначале получите данные рецепта")
            result = "ERROR-ex" & e.Message
        End Try
        Return result
    End Function
End Class
