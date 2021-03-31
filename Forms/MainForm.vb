Imports Newtonsoft.Json
Imports ePharmacy.Views

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetRecipe.Click
        PutData()
    End Sub

    ''' <summary>
    ''' Entering data to MainForm
    ''' </summary>
    Private Sub PutData()
        Try
            Dim QRcode As String = tbRecipeID.Text
            Dim prep As Prescription = JsonConvert.DeserializeObject(Of Prescription)(QRcode)
            Dim str As String = Request.GetRecipe("https://pharmacy.test.1er.app/api/v1/prescriptions/" + prep.documentId)

            Dim recipe As eRecipe = JsonConvert.DeserializeObject(Of eRecipe)(str)
            EnterPatient(recipe)
            Dim data As DataTable = ToDataTable(recipe)
            GridControl1.DataSource = data
            GridView1.BestFitColumns(True) 'this shit for the best fitting of the widths of columns based on the context
        Catch ex As SystemException
            MessageBox.Show("Рецепт не найден ")
            ClearTextboxes(Me) 'clear all textboxes and griddata
        Catch er As JsonReaderException
            MessageBox.Show("QR код считался неккоректно")
            ClearTextboxes(Me) 'clear all textboxes and griddata
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbRecipeStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSwitch_RecipeStatus_Click(sender As Object, e As EventArgs) Handles btnSwitch_RecipeStatus.Click
        UpdateRecipestatus()
    End Sub

End Class