Imports System.IO
Imports System.Net
Imports System.Security.Authentication
Imports System.Text
Imports Newtonsoft.Json

Public Class PostOrder

    Private Shared Function GetId() As String
        Dim QRcode As String = MainForm.tbRecipeID.Text
        Dim prep As Prescription = JsonConvert.DeserializeObject(Of Prescription)(QRcode)
        Return prep.documentId
    End Function

    Public Shared Function PostRequest(ByVal Order As PharmacyOrder) As String
        Const _Tls12 As SslProtocols = DirectCast(&HC00, SslProtocols)
        Const Tls12 As SecurityProtocolType = DirectCast(_Tls12, SecurityProtocolType)
        ServicePointManager.SecurityProtocol = Tls12

        Order.prescriptionId = GetId()

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
            rez_content = StrRdr.ReadToEnd()
        Catch e As Exception
            rez_content = "ERROR-ex" & e.Message
        End Try

        Return rez_content
    End Function
End Class
