Public Class PharmacyOrder
    Public Property prescriptionId As String
    Public Property pharmacy As Pharmacy
    Public Property products() As Product
    Public Property externalId As String
    Public Property price As Price
    Public Property promocode As String
    Public Property finalPrice As Finalprice
End Class

Public Class Pharmacy
    Public Property code As String
    Public Property name As String
    Public Property address As Address
End Class

Public Class Packagecontent
    Public Property amount As Integer
    Public Property unit As String
End Class

