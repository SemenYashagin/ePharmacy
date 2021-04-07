Imports Newtonsoft.Json
Imports ePharmacy.Views

Public Class MainForm


    Private patients As List(Of Tuple(Of String, String, eRecipe)) = New List(Of Tuple(Of String, String, eRecipe))
    Private postOrder As PostOrder

    Public Sub New(postOrder As PostOrder)
        InitializeComponent()
        Me.postOrder = postOrder
    End Sub

    Public Sub NewClass(shortcode As String, qrcode As String)
        If (shortcode <> Nothing) Then
            PutDatafromCode(shortcode)
        Else
            PutDatafromID(qrcode)
        End If
    End Sub

    ''' <summary>
    ''' Entering data to MainForm
    ''' </summary>
    Private Sub PutDatafromID(qrcode As String)
        Try
            Dim str As String = Request.GetRecipebyId("https://pharmacy.test.1er.app/api/v1/prescriptions/" + qrcode)
            Dim recipe As eRecipe = JsonConvert.DeserializeObject(Of eRecipe)(str)
            Views.EnterPatient(recipe, Me)
            Dim data As DataTable = ToDataTable(recipe)
            GridControl1.DataSource = data
            GridView1.BestFitColumns(True) 'this shit for the best fitting of the widths of columns based on the context
        Catch err As Newtonsoft.Json.JsonSerializationException
            MessageBox.Show("QR код считался неккоректно")
            Views.ClearTextboxes(Me, Me) 'clear all textboxes and griddata
        Catch ex As SystemException
            MessageBox.Show("Рецепт не найден ")
            Views.ClearTextboxes(Me, Me) 'clear all textboxes and griddata
        Catch er As JsonReaderException
            MessageBox.Show("QR код считался неккоректно")
            Views.ClearTextboxes(Me, Me) 'clear all textboxes and griddata
        End Try
    End Sub

    Public Sub PutDatafromCode(shortcode As String)
        Try
            Dim code As String = shortcode
            Dim str As String = Request.GetRecipebyId("https://pharmacy.test.1er.app/api/v1/prescriptions?code=" + code)

            Dim recipe As eRecipe() = JsonConvert.DeserializeObject(Of eRecipe())(str)
            If (recipe.Length = 1) Then
                Views.EnterPatient(recipe(0), Me)
                Dim data As DataTable = ToDataTable(recipe(0))
                GridControl1.DataSource = data
                GridView1.BestFitColumns(True) 'this shit for the best fitting of the widths of columns based on the context
                postOrder.SelectedId = recipe(0)._id
            ElseIf (recipe.Length > 1) Then
                GetRecipeCode(recipe)
            End If
        Catch ex As SystemException
            MessageBox.Show("Рецепт не найден ")
            Views.ClearTextboxes(Me, Me) 'clear all textboxes and griddata
        Catch er As JsonReaderException
            MessageBox.Show("Вы ввели неверный код")
            Views.ClearTextboxes(Me, Me) 'clear all textboxes and griddata
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbRecipeStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSwitch_RecipeStatus_Click(sender As Object, e As EventArgs) Handles btnSwitch_RecipeStatus.Click
        Dim _id As String = tbRecipeID.Text
        Views.UpdateRecipestatus(Me, _id)
        PutDatafromID(_id)
    End Sub

    Private Sub GetRecipeCode(recipes As eRecipe())
        Try
            For Each oneRecipe As eRecipe In recipes
                Dim name As String = oneRecipe.patient.lastName + " " + oneRecipe.patient.firstName + " " + oneRecipe.patient.middleName + ", " + oneRecipe._id
                Dim id As String = oneRecipe._id
                cbchooseRecipe.Items.Add(name)
                Dim person As Tuple(Of String, String, eRecipe) = New Tuple(Of String, String, eRecipe)(name, id, oneRecipe)
                patients.Add(person)
            Next
        Catch ex As SystemException
            MessageBox.Show("Рецепт не найден ")
        Catch er As JsonReaderException
            MessageBox.Show("Вы ввели неверный код")
        End Try
    End Sub

    Private Function GetRecipebyQR() As eRecipe
        Dim QRcode As String = tbRecipeID.Text
        Dim recipe As eRecipe = Nothing
        Try
            'Dim prep As Prescription = JsonConvert.DeserializeObject(Of Prescription)(QRcode)
            Dim str As String = Request.GetRecipebyId("https://pharmacy.test.1er.app/api/v1/prescriptions/" + QRcode)
            recipe = JsonConvert.DeserializeObject(Of eRecipe)(str)
        Catch e As System.NullReferenceException
            MessageBox.Show("Некорректные данные")
        End Try
        Return recipe
    End Function

    Private Sub btnlastOrders_Click(sender As Object, e As EventArgs) Handles btnlastOrders.Click
        Dim recipe As eRecipe = GetRecipebyQR()
        Dim order As Orders = New Orders()
        order.Activate()
        order.Orders(recipe)
        order.ShowDialog()
    End Sub

    Private Sub cbchooseRecipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbchooseRecipe.SelectedIndexChanged
        For Each person As Tuple(Of String, String, eRecipe) In patients
            Dim indexComma As Integer = cbchooseRecipe.Text.IndexOf(",")
            Dim id As String = cbchooseRecipe.Text.Remove(0, indexComma + 2)
            If (person.Item2 = id) Then
                Views.EnterPatient(person.Item3, Me)
                postOrder.SelectedId = person.Item3._id
                Dim data As DataTable = Views.ToDataTable(person.Item3)
                GridControl1.DataSource = data
                GridView1.BestFitColumns(True)
                Exit For
            End If
        Next
    End Sub
End Class