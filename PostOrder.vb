Imports System.IO
Imports System.Net
Imports System.Security.Authentication
Imports System.Text
Imports Newtonsoft.Json

Public Class PostOrder
    Property SelectedId As String = Nothing
    Public Sub GetRecipe(shortcode As String, qrcode As String)
        Dim main As New MainForm(Me)
        main.Activate()
        main.NewClass(shortcode, qrcode)
        If (Not main.IsDisposed) Then
            main.Show()
        Else
            main.Dispose()
        End If
    End Sub

    Public Function PostRequest(ByVal Order As PharmacyOrder) As ResponseData
        Const _Tls12 As SslProtocols = DirectCast(&HC00, SslProtocols)
        Const Tls12 As SecurityProtocolType = DirectCast(_Tls12, SecurityProtocolType)
        ServicePointManager.SecurityProtocol = Tls12

        Dim response As New ResponseData

        Dim bmyrequest As Byte() = Nothing
        Dim rez_content As String = ""
        Dim Url As String = "https://pharmacy.test.1er.app/api/v1/orders"
        Dim request As HttpWebRequest = CType(HttpWebRequest.Create(Url), HttpWebRequest)
        request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJhdXRoLnRlc3QuMWVyLmFwcCIsInN1YiI6IjYwNGI0ODMxMDQ5MWJhNmJ" & "lNjBlZmNmMyIsImlhdCI6MTYxNTU0NzAyNywidXNlcklkIjoiNjA0YjQ4MzEwNDkxYmE2YmU2MGVmY2YzIiwidXNlciI6eyJfaWQiOiI2MDRiNDgzMTA0OTFiYTZiZTYw" & "ZWZjZjMiLCJyb2xlcyI6WyJJTlRFR1JBVElPTiJdLCJyb2xlIjoiSU5URUdSQVRJT04iLCJjaGlsZHJlbiI6W119LCJleHAiOjE2NDcwODMwMjd9.O9cdUL9IRHdMBXptUjt" & "3yKb6pWuUWqjzFzLcfBRf60k")
        Dim rpost As String = ""

        Try
            request.Timeout = 60000
            request.Method = "POST"
            request.ContentType = "application/json"
            rpost = JsonConvert.SerializeObject(Order)
            bmyrequest = Encoding.UTF8.GetBytes(rpost)
            Dim str As Stream = request.GetRequestStream()
            str.Write(bmyrequest, 0, bmyrequest.Length)
            str.Close()
            Dim resp As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim StrRdr As StreamReader = New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
            response.Data = StrRdr.ReadToEnd()
            response.IsSuccess = True
        Catch e As Exception
            response.IsSuccess = False
            response.ErrorMessage = e.Message
        End Try
        Return response
    End Function
End Class
