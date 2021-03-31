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
    Public Shared Function GetRecipe(ByVal URI As String) As String
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


    Public Shared Function PostRequestForModelToString(ByVal pUrl As String, ByVal pModel As Object) As String
        'because we don't have TLS 1.2 in .Net 4.0
        Const _Tls12 As SslProtocols = DirectCast(&HC00, SslProtocols)
        Const Tls12 As SecurityProtocolType = DirectCast(_Tls12, SecurityProtocolType)
        ServicePointManager.SecurityProtocol = Tls12
        'because we don't have TLS 1.2 in .Net 4.0

        'System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 'if we have .Net 4.5 and more

        Dim bmyrequest As Byte() = Nothing
        Dim rez_content As String = ""
        Dim req As HttpWebRequest = CType(HttpWebRequest.Create(pUrl), HttpWebRequest)
        Dim rpost As String = ""

        Try
            req.Timeout = 60000
            req.Method = "POST"
            req.ContentType = "application/json"
            rpost = JsonConvert.SerializeObject(pModel)
            bmyrequest = Encoding.UTF8.GetBytes(rpost)
            Dim str As Stream = req.GetRequestStream()
            str.Write(bmyrequest, 0, bmyrequest.Length)
            str.Close()
            Dim resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
            Dim StrRdr As StreamReader = New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
            rez_content = StrRdr.ReadToEnd()
        Catch e As Exception
            rez_content = "ERROR-ex" & e.Message
        End Try

        Return rez_content
    End Function

End Class
