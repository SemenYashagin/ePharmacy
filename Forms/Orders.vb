Public Class Orders
    Public Sub Orders(recipe As eRecipe)
        Dim data As DataTable = ToDataTable(recipe)
        GridControl2.DataSource = data
        GridView2.BestFitColumns(True)
    End Sub

    Private Function ToDataTable(recipes As eRecipe) As DataTable
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
            .ColumnName = "clmPackageContent",
            .Caption = "В одной упаковке",
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

        For Each order As Order In recipes.orders
            For Each product As Product In order.products
                row = table.NewRow()
                If (product.medicine <> Nothing) Then row(0) = product.medicine Else row(0) = ""
                If (product.name <> Nothing) Then row(1) = product.name Else row(1) = ""
                If (IsNothing(product.medicationForm)) Then row(2) = "" Else row(2) = product.medicationForm.name
                If (IsNothing(product.dosage)) Then row(3) = "" Else row(3) = product.dosage.text
                If (IsNothing(product.packageContent)) Then row(4) = "" Else row(4) = product.packageContent.amount + " " + product.packageContent.unit
                If (product.amount <> Nothing) Then row(5) = product.amount Else row(5) = ""
                table.Rows.Add(row)
            Next
        Next
        Return table
    End Function
End Class