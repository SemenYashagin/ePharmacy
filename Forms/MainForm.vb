Imports Newtonsoft.Json
Imports ePharmacy.Views
Imports ePharmacy.eRecipe

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetRecipe.Click
        PutData()
    End Sub

    ''' <summary>
    ''' Entering data to MainForm
    ''' </summary>
    Private Sub PutData()
        Dim barcode As String = tbRecipeID.Text
        Dim str As String = Request.GetRecipe("https://pharmacy.test.1er.app/api/v1/prescriptions/" + barcode)

        Try
            Dim recipe As eRecipe = JsonConvert.DeserializeObject(Of eRecipe)(str)
            EnterPatient(recipe)
            Dim data As DataTable = ToDataTable(recipe)
            GridControl1.DataSource = data
            GridView1.BestFitColumns(True) 'this shit for the best fitting of the widths of columns based on the context

        Catch ex As SystemException
            MessageBox.Show("Рецепт не найден ")
            ClearTextboxes(Me) 'clear all textboxes and griddata
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbRecipeStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSwitch_RecipeStatus_Click(sender As Object, e As EventArgs) Handles btnSwitch_RecipeStatus.Click
        Try
            Dim recipeStatus As Dictionary(Of String, String) = New Dictionary(Of String, String)

            recipeStatus.Add("Выписан", "ISSUED")
            recipeStatus.Add("Испорчен", "SPOILED")
            recipeStatus.Add("Не обработан", "NOT_PROCESSED")
            recipeStatus.Add("Отпущен", "RELEASED")
            recipeStatus.Add("Отпущен частично", "RELEASED_PARTIALLY")
            recipeStatus.Add("Отсрочен", "DELAYED")
            recipeStatus.Add("Отложен", "RESERVED")
            recipeStatus.Add("Получен фармуправлением", "RECEIVED_BY_PHARMACY")
            recipeStatus.Add("Передан в РМИС", "SENT_TO_RMIS")

            Dim stat = New Status
            Dim status = New NewStatus
            status.status = stat
            status.status.name = cbRecipeStatus.Text
            status.status.type = recipeStatus.Item(cbRecipeStatus.Text)

            Dim newStatus As String = JsonConvert.SerializeObject(status)

            Dim barcode As String = tbRecipeID.Text
            Request.UpdateRecipeByID("https://pharmacy.test.1er.app/api/v1/prescriptions", status, barcode)

        Catch ex As KeyNotFoundException
            MessageBox.Show("Для изменения статуса сначала получите рецепт")
        End Try

    End Sub

End Class