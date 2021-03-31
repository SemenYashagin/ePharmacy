Public Class Views

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
        MainForm.tbFirstname.Text = recipe.patient.firstName
        MainForm.tbSurname.Text = recipe.patient.lastName
        MainForm.tbMiddlename.Text = recipe.patient.middleName
        MainForm.tbBirthday.Text = recipe.patient.birthDate
        MainForm.tbSnils.Text = recipe.patient.SNILS
        MainForm.tbOMS.Text = recipe.patient.OMS.number
        MainForm.tbDueDate.Text = recipe.dueDate
        MainForm.cbRecipeStatus.Text = recipe.status.name
        If recipe.patient.sex = 1 Then MainForm.tbSex.Text = "муж" Else MainForm.tbSex.Text = "жен"
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
            row(0) = unit.medicine.name

            For Each product As Product In unit.products
                row(1) += product.name
            Next

            row(2) = unit.medicationForm.name
            row(3) = unit.dosage.text
            row(4) = unit.intakeSchedule.text
            row(5) = unit.totalAmount
            table.Rows.Add(row)
        Next

        Return table
    End Function


End Class
