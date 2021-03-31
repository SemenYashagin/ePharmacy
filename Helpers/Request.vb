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
            Dim stream As System.IO.Stream = request.GetRequestStream()
            stream.Write(bodyBytes, 0, bodyBytes.Length)
            stream.Close()
            Dim response As System.Net.HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
            Dim reader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8)
            result = reader.ReadToEnd()
        Catch e As Exception
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
        Dim req As System.Net.HttpWebRequest = CType(System.Net.HttpWebRequest.Create(pUrl), System.Net.HttpWebRequest)
        Dim rpost As String = ""

        Try
            req.Timeout = 60000
            req.Method = "POST"
            req.ContentType = "application/json"
            rpost = Newtonsoft.Json.JsonConvert.SerializeObject(pModel)
            bmyrequest = Encoding.UTF8.GetBytes(rpost)
            Dim str As System.IO.Stream = req.GetRequestStream()
            str.Write(bmyrequest, 0, bmyrequest.Length)
            str.Close()
            Dim resp As System.Net.HttpWebResponse = CType(req.GetResponse(), System.Net.HttpWebResponse)
            Dim StrRdr As System.IO.StreamReader = New System.IO.StreamReader(resp.GetResponseStream(), Encoding.UTF8)
            rez_content = StrRdr.ReadToEnd()
        Catch e As Exception
            rez_content = "ERROR-ex" & e.Message
        End Try

        Return rez_content
    End Function

End Class
