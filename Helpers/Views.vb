Imports Newtonsoft.Json

Public Class Views

    Public Shared Function UpdateRecipestatus() As String
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
            status.status.name = MainForm.cbRecipeStatus.Text
            status.status.type = recipeStatus.Item(MainForm.cbRecipeStatus.Text)

            Dim newStatus As String = JsonConvert.SerializeObject(status)

            Dim barcode As Prescription = JsonConvert.DeserializeObject(Of Prescription)(MainForm.tbRecipeID.Text)
            result = Request.UpdateRecipeByID("https://pharmacy.test.1er.app/api/v1/prescriptions", status, barcode.documentId)

        Catch ex As KeyNotFoundException
            MessageBox.Show("Для изменения статуса рецепта сначала получите его")
        End Try
        Return result
    End Function

    Public Shared Sub ClearTextboxes(ByVal control As Control)
        For Each c In control.Controls
            If TypeOf c Is TextBox Then CType(c, TextBox).Text = String.Empty
            ClearTextboxes(c)
        Next
        MainForm.GridControl1.DataSource = Nothing
        MainForm.cbRecipeStatus.Text = Nothing
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="recipe"></param>
    Public Shared Sub EnterPatient(recipe As eRecipe)
        If recipe.patient.firstName = Nothing Then MainForm.tbFirstname.Text = "" Else MainForm.tbFirstname.Text = recipe.patient.firstName
        If recipe.patient.lastName = Nothing Then MainForm.tbSurname.Text = "" Else MainForm.tbSurname.Text = recipe.patient.lastName
        If recipe.patient.middleName = Nothing Then MainForm.tbMiddlename.Text = "" Else MainForm.tbMiddlename.Text = recipe.patient.middleName
        If recipe.patient.birthDate = Nothing Then MainForm.tbBirthday.Text = "" Else MainForm.tbBirthday.Text = recipe.patient.birthDate
        If recipe.patient.SNILS = Nothing Then MainForm.tbSnils.Text = "" Else MainForm.tbSnils.Text = recipe.patient.SNILS

        If IsNothing(recipe.patient.OMS) Then
            MainForm.tbOMS.Text = ""
        Else
            If recipe.patient.OMS.number = Nothing Then MainForm.tbOMS.Text = "" Else MainForm.tbOMS.Text = recipe.patient.OMS.number
        End If

        If recipe.dueDate = Nothing Then MainForm.tbDueDate.Text = "" Else MainForm.tbDueDate.Text = recipe.dueDate
        If recipe.status.name = Nothing Then MainForm.cbRecipeStatus.Text = "" Else MainForm.cbRecipeStatus.Text = recipe.status.name
        If recipe.patient.sex = Nothing Then MainForm.tbSex.Text = "" Else If recipe.patient.sex = 1 Then MainForm.tbSex.Text = "муж" Else MainForm.tbSex.Text = "жен"
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
            'row(0) = unit.medicine.name

            If IsNothing(unit.products) Then
                row(1) = ""
            Else
                For Each product As Product In unit.products
                    If (product.name <> Nothing) Then row(1) = product.name Else row(1) = ""
                    'row(1) += product.name
                Next
            End If

            If (unit.medicationForm.name <> Nothing) Then row(2) = unit.medicationForm.name Else row(2) = ""
            'row(2) = unit.medicationForm.name

            If (unit.dosage.text <> Nothing) Then row(3) = unit.dosage.text Else row(3) = ""
            'row(3) = unit.dosage.text

            If (unit.intakeSchedule.text <> Nothing) Then row(4) = unit.intakeSchedule.text Else row(4) = ""
            'row(4) = unit.intakeSchedule.text

            If (unit.totalAmount <> Nothing) Then row(5) = unit.totalAmount Else row(5) = ""
            'row(5) = unit.totalAmount

            table.Rows.Add(row)
        Next

        Return table
    End Function


End Class
