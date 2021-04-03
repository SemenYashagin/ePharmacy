Imports Newtonsoft.Json
Imports ePharmacy.Views

Public Class MainForm

    Public Sub MainForm()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetRecipe.Click
        If cbMethod.Text = "" Then
            MessageBox.Show("Выберите метод получения рецепта")
        ElseIf cbMethod.Text = "QR-код" Then
            PutDatafromID()
        ElseIf cbMethod.Text = "Код рецепта" Then
            PutDatafromCode()
        End If

    End Sub

    ''' <summary>
    ''' Entering data to MainForm
    ''' </summary>
    Private Sub PutDatafromID()
        Try
            Dim QRcode As String = tbRecipeID.Text
            Dim prep As Prescription = JsonConvert.DeserializeObject(Of Prescription)(QRcode)
            Dim str As String = Request.GetRecipebyId("https://pharmacy.test.1er.app/api/v1/prescriptions/" + prep.documentId)
            Dim recipe As eRecipe = JsonConvert.DeserializeObject(Of eRecipe)(str)
            EnterPatient(recipe)
            Dim data As DataTable = ToDataTable(recipe)
            GridControl1.DataSource = data
            GridView1.BestFitColumns(True) 'this shit for the best fitting of the widths of columns based on the context
        Catch err As Newtonsoft.Json.JsonSerializationException
            MessageBox.Show("QR код считался неккоректно")
            ClearTextboxes(Me) 'clear all textboxes and griddata
        Catch ex As SystemException
            MessageBox.Show("Рецепт не найден ")
            ClearTextboxes(Me) 'clear all textboxes and griddata
        Catch er As JsonReaderException
            MessageBox.Show("QR код считался неккоректно")
            ClearTextboxes(Me) 'clear all textboxes and griddata
        End Try
    End Sub

    Private Sub PutDatafromCode()
        Try
            Dim code As String = tbRecipeID.Text
            Dim str As String = Request.GetRecipebyId("https://pharmacy.test.1er.app/api/v1/prescriptions?code=" + code)

            Dim recipe As eRecipe() = JsonConvert.DeserializeObject(Of eRecipe())(str)
            If (recipe.Length = 1) Then
                EnterPatient(recipe(0))
                Dim data As DataTable = ToDataTable(recipe(0))
                GridControl1.DataSource = data
                GridView1.BestFitColumns(True) 'this shit for the best fitting of the widths of columns based on the context
                UpdateStatusForm(recipe(0))

            ElseIf (recipe.Length > 1) Then
                Dim eRecipes As RecipesForm = New RecipesForm()
                eRecipes.Activate()
                eRecipes.RecipesForm()
                eRecipes.ShowDialog()
                GridView1.BestFitColumns(True)
            End If
        Catch ex As SystemException
            MessageBox.Show("Рецепт не найден ")
            ClearTextboxes(Me) 'clear all textboxes and griddata
        Catch er As JsonReaderException
            MessageBox.Show("Вы ввели неверный код")
            ClearTextboxes(Me) 'clear all textboxes and griddata
        End Try
    End Sub

    Public Sub UpdateStatusForm(recipe As eRecipe)
        tbRecipeID.Text = Nothing
        Dim status As String = recipe._id
        Dim id As ID = New ID()
        id.documentId = status
        Dim newID As String = JsonConvert.SerializeObject(id)
        tbRecipeID.Text = newID
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbRecipeStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSwitch_RecipeStatus_Click(sender As Object, e As EventArgs) Handles btnSwitch_RecipeStatus.Click
        UpdateRecipestatus()
        PutDatafromID()
    End Sub

    Private Function GetRecipebyQR() As eRecipe
        Dim QRcode As String = tbRecipeID.Text
        Dim prep As Prescription = JsonConvert.DeserializeObject(Of Prescription)(QRcode)
        Dim str As String = Request.GetRecipebyId("https://pharmacy.test.1er.app/api/v1/prescriptions/" + prep.documentId)
        Dim recipe As eRecipe = JsonConvert.DeserializeObject(Of eRecipe)(str)
        Return recipe
    End Function

    Private Sub btnlastOrders_Click(sender As Object, e As EventArgs) Handles btnlastOrders.Click
        Dim recipe As eRecipe = GetRecipebyQR()
        Orders.Activate()
        Orders.Orders(recipe)
        Orders.ShowDialog()
    End Sub
End Class