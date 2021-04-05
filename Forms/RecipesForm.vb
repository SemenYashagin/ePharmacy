Imports Newtonsoft.Json
Imports ePharmacy.MainForm

Public Class RecipesForm
    Private patients As List(Of Tuple(Of String, String, eRecipe)) = New List(Of Tuple(Of String, String, eRecipe))
    Private mainForm As MainForm
    Public Sub RecipesForm(main As MainForm)
        Dim code As String = main.tbRecipeID.Text
        mainForm = main
        GetRecipeCode(code)
    End Sub

    Private Sub GetRecipeCode(code As String)
        Try
            Dim str As String = Request.GetRecipebyId("https://pharmacy.test.1er.app/api/v1/prescriptions?code=" + code)
            Dim recipe As eRecipe() = JsonConvert.DeserializeObject(Of eRecipe())(str)

            For Each oneRecipe As eRecipe In recipe
                Dim name As String = oneRecipe.patient.lastName + " " + oneRecipe.patient.firstName + " " + oneRecipe.patient.middleName + ", " + oneRecipe._id
                Dim id As String = oneRecipe._id
                cbListofRecipes.Items.Add(name)
                Dim person As Tuple(Of String, String, eRecipe) = New Tuple(Of String, String, eRecipe)(name, id, oneRecipe)
                patients.Add(person)
            Next
        Catch ex As SystemException
            MessageBox.Show("Рецепт не найден ")
        Catch er As JsonReaderException
            MessageBox.Show("Вы ввели неверный код")
        End Try
    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click

        For Each person As Tuple(Of String, String, eRecipe) In patients
            Dim indexComma As Integer = cbListofRecipes.Text.IndexOf(",")
            Dim id As String = cbListofRecipes.Text.Remove(0, indexComma + 2)
            If (person.Item2 = id) Then
                Views.EnterPatient(person.Item3, mainForm)
                Dim data As DataTable = Views.ToDataTable(person.Item3)
                mainForm.GridControl1.DataSource = data
                mainForm.UpdateStatusForm(person.Item3)
                Close()
                Exit For
            End If
        Next
    End Sub



End Class