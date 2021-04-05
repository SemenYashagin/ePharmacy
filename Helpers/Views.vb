Imports Newtonsoft.Json

Public Class Views
    'Dim main As MainForm
    Public Shared Function UpdateRecipestatus(main As MainForm) As String
        Dim result As String = ""
        Try
            Dim recipeStatus As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
                {"Выписан", "ISSUED"},
                {"Испорчен", "SPOILED"},
                {"Не обработан", "NOT_PROCESSED"},
                {"Отпущен", "RELEASED"},
                {"Отпущен частично", "RELEASED_PARTIALLY"},
                {"Отсрочен", "DELAYED"},
                {"Отложен", "RESERVED"},
                {"Получен фармуправлением", "RECEIVED_BY_PHARMACY"},
                {"Передан в РМИС", "SENT_TO_RMIS"}
            }

            Dim stat = New Status
            Dim status = New NewStatus
            status.status = stat
            status.status.name = main.cbRecipeStatus.Text
            status.status.type = recipeStatus.Item(main.cbRecipeStatus.Text)

            Dim newStatus As String = JsonConvert.SerializeObject(status)

            Dim barcode As Prescription = JsonConvert.DeserializeObject(Of Prescription)(main.tbRecipeID.Text)
            result = Request.UpdateRecipeByID("https://pharmacy.test.1er.app/api/v1/prescriptions", status, barcode.documentId)

        Catch ex As KeyNotFoundException
            MessageBox.Show("Для изменения статуса рецепта сначала получите его")

        Catch err As System.NullReferenceException
            MessageBox.Show("Неверно указан номер рецепта")
        Catch e As Newtonsoft.Json.JsonReaderException
            MessageBox.Show("Неверно указан ID рецепта")
        End Try
        Return result
    End Function

    Public Shared Sub ClearTextboxes(ByVal control As Control, main As MainForm)
        For Each c In control.Controls
            If TypeOf c Is TextBox Then CType(c, TextBox).Text = String.Empty
            ClearTextboxes(c, main)
        Next
        main.GridControl1.DataSource = Nothing
        main.cbRecipeStatus.Text = Nothing
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="recipe"></param>
    Public Shared Sub EnterPatient(recipe As eRecipe, main As MainForm)
        Dim currentdata As DateTime = DateTime.Now

        If recipe.patient.firstName = Nothing Then main.tbFirstname.Text = "" Else main.tbFirstname.Text = recipe.patient.firstName
        If recipe.patient.lastName = Nothing Then main.tbSurname.Text = "" Else main.tbSurname.Text = recipe.patient.lastName
        If recipe.patient.middleName = Nothing Then main.tbMiddlename.Text = "" Else main.tbMiddlename.Text = recipe.patient.middleName
        If recipe.patient.birthDate = Nothing Then main.tbBirthday.Text = "" Else main.tbBirthday.Text = recipe.patient.birthDate
        If recipe.patient.SNILS = Nothing Then main.tbSnils.Text = "" Else main.tbSnils.Text = recipe.patient.SNILS

        If IsNothing(recipe.patient.OMS) Then
            main.tbOMS.Text = ""
        Else
            If recipe.patient.OMS.number = Nothing Then main.tbOMS.Text = "" Else main.tbOMS.Text = recipe.patient.OMS.number
        End If

        If (recipe.orders.Length = 0) Then main.tbQuantityOrders.Text = "0" Else main.tbQuantityOrders.Text = recipe.orders.Length
        If (recipe.dueDate > currentdata) Then main.tbDueDate.BackColor = Color.FromArgb(192, 255, 192) Else main.tbDueDate.BackColor = Color.FromArgb(255, 192, 192)
        If recipe.dueDate = Nothing Then main.tbDueDate.Text = "" Else main.tbDueDate.Text = recipe.dueDate
        If recipe.status.name = Nothing Then main.cbRecipeStatus.Text = "" Else main.cbRecipeStatus.Text = recipe.status.name
        If recipe.patient.sex = Nothing Then main.tbSex.Text = "" Else If recipe.patient.sex = 1 Then main.tbSex.Text = "муж" Else main.tbSex.Text = "жен"
        If recipe.status.name = Nothing Then main.tbCurrentStatus.Text = "" Else main.tbCurrentStatus.Text = recipe.status.name
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="recipes"></param>
    ''' <returns></returns>
    Public Shared Function ToDataTable(recipes As eRecipe) As DataTable
        Dim table As DataTable = New DataTable()
        Dim column As DataColumn
        Dim row As DataRow
        column = New DataColumn With {
            .DataType = System.Type.[GetType]("System.String"),
            .ColumnName = "clmMNN",
            .Caption = "МНН",
            .[ReadOnly] = True
        }
        table.Columns.Add(column)
        column = New DataColumn With {
            .DataType = System.Type.[GetType]("System.String"),
            .ColumnName = "clmName",
            .Caption = "Торговое наименование",
            .[ReadOnly] = True
        }
        table.Columns.Add(column)
        column = New DataColumn With {
            .DataType = System.Type.[GetType]("System.String"),
            .ColumnName = "clmForma",
            .Caption = "Форма выпуска",
            .[ReadOnly] = True
        }
        table.Columns.Add(column)
        column = New DataColumn With {
            .DataType = System.Type.[GetType]("System.String"),
            .ColumnName = "clmDosage",
            .Caption = "Дозировка",
            .[ReadOnly] = True
        }
        table.Columns.Add(column)
        column = New DataColumn With {
            .DataType = System.Type.[GetType]("System.String"),
            .ColumnName = "clmSigna",
            .Caption = "Сигнатура",
            .[ReadOnly] = True
        }
        table.Columns.Add(column)
        column = New DataColumn With {
            .DataType = System.Type.[GetType]("System.String"),
            .ColumnName = "clmTotalamount",
            .Caption = "Кол-во единиц",
            .[ReadOnly] = True
        }
        table.Columns.Add(column)

        For Each unit As Medication In recipes.medications
            row = table.NewRow()

            If (unit.medicine.name <> Nothing) Then row(0) = unit.medicine.name Else row(0) = ""
            If IsNothing(unit.products) Then
                row(1) = ""
            Else
                For Each product As Product In unit.products
                    If (product.name <> Nothing) Then row(1) = product.name Else row(1) = ""
                    'row(1) += product.name
                Next
            End If

            If (unit.medicationForm.name <> Nothing) Then row(2) = unit.medicationForm.name Else row(2) = ""
            If (unit.dosage.text <> Nothing) Then row(3) = unit.dosage.text Else row(3) = ""
            If (unit.intakeSchedule.text <> Nothing) Then row(4) = unit.intakeSchedule.text Else row(4) = ""
            If (unit.totalAmount <> Nothing) Then row(5) = unit.totalAmount Else row(5) = ""
            table.Rows.Add(row)
        Next

        Return table
    End Function
End Class
