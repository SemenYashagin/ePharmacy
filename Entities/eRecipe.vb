
Public Class eRecipe
    Public Property _id As String
    Public Property type As String
    Public Property externalId As String
    Public Property creationDate As Date
    Public Property status As Status
    Public Property code As String
    Public Property series As String
    Public Property number As Integer
    Public Property dueDate As Date
    Public Property clinic As Clinic
    Public Property patient As Patient
    Public Property doctor As Doctor
    Public Property diagnosis As Diagnosis
    Public Property medications As Medication()
    Public Property createdBy As String
    Public Property lastUpdateDate As Date
    Public Property name As String
    Public Property orders As Order()
End Class

Public Class Diagnosis
    Public Property code As String
    Public Property name As String
End Class

Public Class Status
    Public Property type As String
    Public Property name As String
End Class

Public Class Clinic
    Public Property name As String
    Public Property OGRN As String
    Public Property phone As String
    Public Property address As Address
End Class

Public Class Address
    Public Property region As String
    Public Property city As String
    Public Property street As String
    Public Property house As String
    Public Property housing As String
    Public Property OKATO As String
    Public Property full As String
    Public Property coordinates As Coordinates
End Class

Public Class Patient
    Public Property firstName As String
    Public Property lastName As String
    Public Property middleName As String
    Public Property SNILS As String
    Public Property phone As String
    Public Property sex As Integer
    Public Property OMS As OMS
    Public Property birthDate As String
End Class

Public Class OMS
    Public Property number As String
End Class

Public Class Doctor
    Public Property firstName As String
    Public Property lastName As String
    Public Property middleName As String
    Public Property SNILS As String
    Public Property specialization As Specialization
    Public Property code As String
End Class

Public Class Specialization
    Public Property name As String
End Class

Public Class Medication
    Public Property medicine As Medicine
    Public Property products As Product()
    Public Property medicationForm As Medicationform
    Public Property dosage As Dosage
    Public Property intakeSchedule As Intakeschedule
    Public Property totalAmount As Integer
End Class

Public Class Medicine
    Public Property name As String
    Public Property latinName As String
End Class

Public Class Medicationform
    Public Property code As String
    Public Property name As String
End Class

Public Class Dosage
    Public Property amount As Integer
    Public Property unit As String
    Public Property text As String
End Class

Public Class Intakeschedule
    Public Property amount As Integer
    Public Property unit As String
    Public Property frequency As Integer
    Public Property interval As Interval
    Public Property text As String
End Class

Public Class Interval
    Public Property type As String
    Public Property name As String
End Class

Public Class Product
    Public Property name As String
    Public Property SKU As String
    Public Property price As Price
    Public Property packageContent As Packagecontent
    Public Property amount As Integer
    Public Property medicine As String
    Public Property dosage As Dosage
    Public Property medicationForm As Medicationform
End Class

Public Class Order
    Public Property _id As String
    Public Property creationDate As Date
    Public Property userId As String
    Public Property lastUpdateDate As Date
    Public Property paid As Boolean
    Public Property status As Status
    Public Property reception As Reception
    Public Property products As Product()
    Public Property payment As Payment
    Public Property price As Price
    Public Property finalPrice As Finalprice
End Class

Public Class Reception
    Public Property type As String
    Public Property name As String
    Public Property address As Address
    Public Property store As Store
End Class

Public Class Coordinates
    Public Property latitude As Single
    Public Property longitude As Single
End Class

Public Class Store
    Public Property address As Address
    Public Property name As String
    Public Property code As String
End Class

Public Class Payment
    Public Property type As String
    Public Property name As String
End Class

Public Class Price
    Public Property amount As Integer
    Public Property name As String
    Public Property currency As String
End Class

Public Class Finalprice
    Public Property amount As Integer
    Public Property name As String
    Public Property currency As String
End Class