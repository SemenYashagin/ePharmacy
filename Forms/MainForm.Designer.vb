<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tbRecipeID = New System.Windows.Forms.TextBox()
        Me.tbMedcardNumber = New System.Windows.Forms.TextBox()
        Me.lbMedcardNumber = New System.Windows.Forms.Label()
        Me.tbSex = New System.Windows.Forms.TextBox()
        Me.lbSex = New System.Windows.Forms.Label()
        Me.tbOMS = New System.Windows.Forms.TextBox()
        Me.lbOMS = New System.Windows.Forms.Label()
        Me.lbSnils = New System.Windows.Forms.Label()
        Me.tbBirthday = New System.Windows.Forms.TextBox()
        Me.lbBirthday = New System.Windows.Forms.Label()
        Me.tbMiddlename = New System.Windows.Forms.TextBox()
        Me.lbMiddlename = New System.Windows.Forms.Label()
        Me.tbFirstname = New System.Windows.Forms.TextBox()
        Me.lbFirstname = New System.Windows.Forms.Label()
        Me.tbSurname = New System.Windows.Forms.TextBox()
        Me.lbSurname = New System.Windows.Forms.Label()
        Me.tbSnils = New System.Windows.Forms.TextBox()
        Me.gbPatientInfo = New System.Windows.Forms.GroupBox()
        Me.lbRecipeID = New System.Windows.Forms.Label()
        Me.tbCurrentStatus = New System.Windows.Forms.TextBox()
        Me.lbCurrentStatus = New System.Windows.Forms.Label()
        Me.tbDueDate = New System.Windows.Forms.TextBox()
        Me.lbDueDate = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMNN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.clmForma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDosage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSigna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTotalamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbQuantityOrders = New System.Windows.Forms.TextBox()
        Me.btnlastOrders = New System.Windows.Forms.Button()
        Me.lbOrders = New System.Windows.Forms.Label()
        Me.cbRecipeStatus = New System.Windows.Forms.ComboBox()
        Me.btnSwitch_RecipeStatus = New System.Windows.Forms.Button()
        Me.lbRecipeStatus = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbchooseRecipe = New System.Windows.Forms.ComboBox()
        Me.gbPatientInfo.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRecipeID
        '
        Me.tbRecipeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbRecipeID.Location = New System.Drawing.Point(257, 379)
        Me.tbRecipeID.Name = "tbRecipeID"
        Me.tbRecipeID.ReadOnly = True
        Me.tbRecipeID.Size = New System.Drawing.Size(210, 22)
        Me.tbRecipeID.TabIndex = 1
        '
        'tbMedcardNumber
        '
        Me.tbMedcardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbMedcardNumber.Location = New System.Drawing.Point(249, 218)
        Me.tbMedcardNumber.Name = "tbMedcardNumber"
        Me.tbMedcardNumber.ReadOnly = True
        Me.tbMedcardNumber.Size = New System.Drawing.Size(210, 22)
        Me.tbMedcardNumber.TabIndex = 16
        '
        'lbMedcardNumber
        '
        Me.lbMedcardNumber.AutoSize = True
        Me.lbMedcardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbMedcardNumber.ForeColor = System.Drawing.Color.Maroon
        Me.lbMedcardNumber.Location = New System.Drawing.Point(21, 221)
        Me.lbMedcardNumber.Name = "lbMedcardNumber"
        Me.lbMedcardNumber.Size = New System.Drawing.Size(140, 16)
        Me.lbMedcardNumber.TabIndex = 15
        Me.lbMedcardNumber.Text = "Номер мед. карты"
        '
        'tbSex
        '
        Me.tbSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbSex.Location = New System.Drawing.Point(249, 190)
        Me.tbSex.Name = "tbSex"
        Me.tbSex.ReadOnly = True
        Me.tbSex.Size = New System.Drawing.Size(210, 22)
        Me.tbSex.TabIndex = 13
        '
        'lbSex
        '
        Me.lbSex.AutoSize = True
        Me.lbSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbSex.ForeColor = System.Drawing.Color.Maroon
        Me.lbSex.Location = New System.Drawing.Point(21, 192)
        Me.lbSex.Name = "lbSex"
        Me.lbSex.Size = New System.Drawing.Size(37, 16)
        Me.lbSex.TabIndex = 12
        Me.lbSex.Text = "Пол"
        '
        'tbOMS
        '
        Me.tbOMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbOMS.Location = New System.Drawing.Point(249, 162)
        Me.tbOMS.Name = "tbOMS"
        Me.tbOMS.ReadOnly = True
        Me.tbOMS.Size = New System.Drawing.Size(210, 22)
        Me.tbOMS.TabIndex = 11
        '
        'lbOMS
        '
        Me.lbOMS.AutoSize = True
        Me.lbOMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbOMS.ForeColor = System.Drawing.Color.Maroon
        Me.lbOMS.Location = New System.Drawing.Point(21, 164)
        Me.lbOMS.Name = "lbOMS"
        Me.lbOMS.Size = New System.Drawing.Size(150, 16)
        Me.lbOMS.TabIndex = 10
        Me.lbOMS.Text = "Номер полиса ОМС"
        '
        'lbSnils
        '
        Me.lbSnils.AutoSize = True
        Me.lbSnils.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbSnils.ForeColor = System.Drawing.Color.Maroon
        Me.lbSnils.Location = New System.Drawing.Point(21, 136)
        Me.lbSnils.Name = "lbSnils"
        Me.lbSnils.Size = New System.Drawing.Size(60, 16)
        Me.lbSnils.TabIndex = 8
        Me.lbSnils.Text = "СНИЛС"
        '
        'tbBirthday
        '
        Me.tbBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbBirthday.Location = New System.Drawing.Point(249, 105)
        Me.tbBirthday.Name = "tbBirthday"
        Me.tbBirthday.ReadOnly = True
        Me.tbBirthday.Size = New System.Drawing.Size(210, 22)
        Me.tbBirthday.TabIndex = 7
        '
        'lbBirthday
        '
        Me.lbBirthday.AutoSize = True
        Me.lbBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbBirthday.ForeColor = System.Drawing.Color.Maroon
        Me.lbBirthday.Location = New System.Drawing.Point(21, 107)
        Me.lbBirthday.Name = "lbBirthday"
        Me.lbBirthday.Size = New System.Drawing.Size(120, 16)
        Me.lbBirthday.TabIndex = 6
        Me.lbBirthday.Text = "Дата рождения"
        '
        'tbMiddlename
        '
        Me.tbMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbMiddlename.Location = New System.Drawing.Point(249, 77)
        Me.tbMiddlename.Name = "tbMiddlename"
        Me.tbMiddlename.ReadOnly = True
        Me.tbMiddlename.Size = New System.Drawing.Size(210, 22)
        Me.tbMiddlename.TabIndex = 5
        '
        'lbMiddlename
        '
        Me.lbMiddlename.AutoSize = True
        Me.lbMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbMiddlename.ForeColor = System.Drawing.Color.Maroon
        Me.lbMiddlename.Location = New System.Drawing.Point(21, 79)
        Me.lbMiddlename.Name = "lbMiddlename"
        Me.lbMiddlename.Size = New System.Drawing.Size(79, 16)
        Me.lbMiddlename.TabIndex = 4
        Me.lbMiddlename.Text = "Отчество"
        '
        'tbFirstname
        '
        Me.tbFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbFirstname.Location = New System.Drawing.Point(249, 49)
        Me.tbFirstname.Name = "tbFirstname"
        Me.tbFirstname.ReadOnly = True
        Me.tbFirstname.Size = New System.Drawing.Size(210, 22)
        Me.tbFirstname.TabIndex = 3
        '
        'lbFirstname
        '
        Me.lbFirstname.AutoSize = True
        Me.lbFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbFirstname.ForeColor = System.Drawing.Color.Maroon
        Me.lbFirstname.Location = New System.Drawing.Point(21, 51)
        Me.lbFirstname.Name = "lbFirstname"
        Me.lbFirstname.Size = New System.Drawing.Size(37, 16)
        Me.lbFirstname.TabIndex = 2
        Me.lbFirstname.Text = "Имя"
        '
        'tbSurname
        '
        Me.tbSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbSurname.Location = New System.Drawing.Point(249, 22)
        Me.tbSurname.Name = "tbSurname"
        Me.tbSurname.ReadOnly = True
        Me.tbSurname.Size = New System.Drawing.Size(210, 22)
        Me.tbSurname.TabIndex = 1
        '
        'lbSurname
        '
        Me.lbSurname.AutoSize = True
        Me.lbSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbSurname.ForeColor = System.Drawing.Color.Maroon
        Me.lbSurname.Location = New System.Drawing.Point(21, 24)
        Me.lbSurname.Name = "lbSurname"
        Me.lbSurname.Size = New System.Drawing.Size(74, 16)
        Me.lbSurname.TabIndex = 0
        Me.lbSurname.Text = "Фамилия"
        '
        'tbSnils
        '
        Me.tbSnils.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbSnils.Location = New System.Drawing.Point(249, 134)
        Me.tbSnils.Name = "tbSnils"
        Me.tbSnils.ReadOnly = True
        Me.tbSnils.Size = New System.Drawing.Size(210, 22)
        Me.tbSnils.TabIndex = 31
        '
        'gbPatientInfo
        '
        Me.gbPatientInfo.Controls.Add(Me.lbRecipeID)
        Me.gbPatientInfo.Controls.Add(Me.tbCurrentStatus)
        Me.gbPatientInfo.Controls.Add(Me.lbCurrentStatus)
        Me.gbPatientInfo.Controls.Add(Me.tbDueDate)
        Me.gbPatientInfo.Controls.Add(Me.lbDueDate)
        Me.gbPatientInfo.Controls.Add(Me.tbSnils)
        Me.gbPatientInfo.Controls.Add(Me.tbMedcardNumber)
        Me.gbPatientInfo.Controls.Add(Me.lbMedcardNumber)
        Me.gbPatientInfo.Controls.Add(Me.tbSex)
        Me.gbPatientInfo.Controls.Add(Me.lbSex)
        Me.gbPatientInfo.Controls.Add(Me.tbOMS)
        Me.gbPatientInfo.Controls.Add(Me.lbOMS)
        Me.gbPatientInfo.Controls.Add(Me.lbSnils)
        Me.gbPatientInfo.Controls.Add(Me.tbBirthday)
        Me.gbPatientInfo.Controls.Add(Me.lbBirthday)
        Me.gbPatientInfo.Controls.Add(Me.tbMiddlename)
        Me.gbPatientInfo.Controls.Add(Me.lbMiddlename)
        Me.gbPatientInfo.Controls.Add(Me.tbFirstname)
        Me.gbPatientInfo.Controls.Add(Me.lbFirstname)
        Me.gbPatientInfo.Controls.Add(Me.tbSurname)
        Me.gbPatientInfo.Controls.Add(Me.lbSurname)
        Me.gbPatientInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gbPatientInfo.Location = New System.Drawing.Point(8, 73)
        Me.gbPatientInfo.Name = "gbPatientInfo"
        Me.gbPatientInfo.Size = New System.Drawing.Size(498, 335)
        Me.gbPatientInfo.TabIndex = 32
        Me.gbPatientInfo.TabStop = False
        Me.gbPatientInfo.Text = "Данные пациента"
        '
        'lbRecipeID
        '
        Me.lbRecipeID.AutoSize = True
        Me.lbRecipeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbRecipeID.ForeColor = System.Drawing.Color.Maroon
        Me.lbRecipeID.Location = New System.Drawing.Point(22, 307)
        Me.lbRecipeID.Name = "lbRecipeID"
        Me.lbRecipeID.Size = New System.Drawing.Size(89, 16)
        Me.lbRecipeID.TabIndex = 36
        Me.lbRecipeID.Text = "ID рецепта"
        '
        'tbCurrentStatus
        '
        Me.tbCurrentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbCurrentStatus.Location = New System.Drawing.Point(249, 278)
        Me.tbCurrentStatus.Name = "tbCurrentStatus"
        Me.tbCurrentStatus.ReadOnly = True
        Me.tbCurrentStatus.Size = New System.Drawing.Size(210, 22)
        Me.tbCurrentStatus.TabIndex = 35
        '
        'lbCurrentStatus
        '
        Me.lbCurrentStatus.AutoSize = True
        Me.lbCurrentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbCurrentStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lbCurrentStatus.Location = New System.Drawing.Point(21, 278)
        Me.lbCurrentStatus.Name = "lbCurrentStatus"
        Me.lbCurrentStatus.Size = New System.Drawing.Size(192, 16)
        Me.lbCurrentStatus.TabIndex = 34
        Me.lbCurrentStatus.Text = "Текущий статус рецепта"
        '
        'tbDueDate
        '
        Me.tbDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbDueDate.Location = New System.Drawing.Point(249, 248)
        Me.tbDueDate.Name = "tbDueDate"
        Me.tbDueDate.ReadOnly = True
        Me.tbDueDate.Size = New System.Drawing.Size(210, 22)
        Me.tbDueDate.TabIndex = 33
        '
        'lbDueDate
        '
        Me.lbDueDate.AutoSize = True
        Me.lbDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbDueDate.ForeColor = System.Drawing.Color.Maroon
        Me.lbDueDate.Location = New System.Drawing.Point(21, 251)
        Me.lbDueDate.Name = "lbDueDate"
        Me.lbDueDate.Size = New System.Drawing.Size(193, 16)
        Me.lbDueDate.TabIndex = 32
        Me.lbDueDate.Text = "Дата окончания рецепта"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(6, 90)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRichTextEdit1, Me.RepositoryItemMemoEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(486, 130)
        Me.GridControl1.TabIndex = 33
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMNN, Me.clmName, Me.clmForma, Me.clmDosage, Me.clmSigna, Me.clmTotalamount})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'clmMNN
        '
        Me.clmMNN.Caption = "МНН"
        Me.clmMNN.FieldName = "clmMNN"
        Me.clmMNN.Name = "clmMNN"
        Me.clmMNN.OptionsColumn.AllowMove = False
        Me.clmMNN.OptionsColumn.AllowSize = False
        Me.clmMNN.OptionsFilter.AllowFilter = False
        Me.clmMNN.Visible = True
        Me.clmMNN.VisibleIndex = 0
        Me.clmMNN.Width = 56
        '
        'clmName
        '
        Me.clmName.Caption = "Торговое наименование"
        Me.clmName.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.clmName.FieldName = "clmName"
        Me.clmName.Name = "clmName"
        Me.clmName.OptionsColumn.AllowMove = False
        Me.clmName.OptionsColumn.AllowSize = False
        Me.clmName.OptionsFilter.AllowFilter = False
        Me.clmName.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmName.Visible = True
        Me.clmName.VisibleIndex = 1
        Me.clmName.Width = 132
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'clmForma
        '
        Me.clmForma.Caption = "Форма выпуска"
        Me.clmForma.FieldName = "clmForma"
        Me.clmForma.Name = "clmForma"
        Me.clmForma.OptionsColumn.AllowMove = False
        Me.clmForma.OptionsColumn.AllowSize = False
        Me.clmForma.OptionsFilter.AllowFilter = False
        Me.clmForma.Visible = True
        Me.clmForma.VisibleIndex = 2
        Me.clmForma.Width = 88
        '
        'clmDosage
        '
        Me.clmDosage.Caption = "Дозировка"
        Me.clmDosage.FieldName = "clmDosage"
        Me.clmDosage.Name = "clmDosage"
        Me.clmDosage.OptionsColumn.AllowMove = False
        Me.clmDosage.OptionsColumn.AllowSize = False
        Me.clmDosage.OptionsFilter.AllowFilter = False
        Me.clmDosage.Visible = True
        Me.clmDosage.VisibleIndex = 3
        Me.clmDosage.Width = 65
        '
        'clmSigna
        '
        Me.clmSigna.Caption = "Сигнатура"
        Me.clmSigna.FieldName = "clmSigna"
        Me.clmSigna.Name = "clmSigna"
        Me.clmSigna.OptionsColumn.AllowMove = False
        Me.clmSigna.OptionsColumn.AllowSize = False
        Me.clmSigna.OptionsFilter.AllowFilter = False
        Me.clmSigna.Visible = True
        Me.clmSigna.VisibleIndex = 4
        Me.clmSigna.Width = 64
        '
        'clmTotalamount
        '
        Me.clmTotalamount.Caption = "Кол-во единиц"
        Me.clmTotalamount.FieldName = "clmTotalamount"
        Me.clmTotalamount.Name = "clmTotalamount"
        Me.clmTotalamount.OptionsColumn.AllowMove = False
        Me.clmTotalamount.OptionsColumn.AllowSize = False
        Me.clmTotalamount.OptionsFilter.AllowFilter = False
        Me.clmTotalamount.Visible = True
        Me.clmTotalamount.VisibleIndex = 5
        Me.clmTotalamount.Width = 291
        '
        'RepositoryItemRichTextEdit1
        '
        Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
        Me.RepositoryItemRichTextEdit1.ShowCaretInReadOnly = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbQuantityOrders)
        Me.GroupBox1.Controls.Add(Me.btnlastOrders)
        Me.GroupBox1.Controls.Add(Me.lbOrders)
        Me.GroupBox1.Controls.Add(Me.cbRecipeStatus)
        Me.GroupBox1.Controls.Add(Me.btnSwitch_RecipeStatus)
        Me.GroupBox1.Controls.Add(Me.GridControl1)
        Me.GroupBox1.Controls.Add(Me.lbRecipeStatus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 414)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 229)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Рецепт"
        '
        'tbQuantityOrders
        '
        Me.tbQuantityOrders.Location = New System.Drawing.Point(138, 60)
        Me.tbQuantityOrders.Name = "tbQuantityOrders"
        Me.tbQuantityOrders.ReadOnly = True
        Me.tbQuantityOrders.Size = New System.Drawing.Size(210, 22)
        Me.tbQuantityOrders.TabIndex = 41
        '
        'btnlastOrders
        '
        Me.btnlastOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnlastOrders.Location = New System.Drawing.Point(357, 59)
        Me.btnlastOrders.Name = "btnlastOrders"
        Me.btnlastOrders.Size = New System.Drawing.Size(122, 25)
        Me.btnlastOrders.TabIndex = 40
        Me.btnlastOrders.Text = "Просмотреть"
        Me.btnlastOrders.UseVisualStyleBackColor = True
        '
        'lbOrders
        '
        Me.lbOrders.AutoSize = True
        Me.lbOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbOrders.ForeColor = System.Drawing.Color.Maroon
        Me.lbOrders.Location = New System.Drawing.Point(11, 63)
        Me.lbOrders.Name = "lbOrders"
        Me.lbOrders.Size = New System.Drawing.Size(115, 16)
        Me.lbOrders.TabIndex = 39
        Me.lbOrders.Text = "Купленные ЛП"
        '
        'cbRecipeStatus
        '
        Me.cbRecipeStatus.FormattingEnabled = True
        Me.cbRecipeStatus.Items.AddRange(New Object() {"Выписан", "Испорчен", "Отпущен", "Отпущен частично"})
        Me.cbRecipeStatus.Location = New System.Drawing.Point(138, 20)
        Me.cbRecipeStatus.Name = "cbRecipeStatus"
        Me.cbRecipeStatus.Size = New System.Drawing.Size(210, 24)
        Me.cbRecipeStatus.TabIndex = 38
        '
        'btnSwitch_RecipeStatus
        '
        Me.btnSwitch_RecipeStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSwitch_RecipeStatus.Location = New System.Drawing.Point(357, 19)
        Me.btnSwitch_RecipeStatus.Name = "btnSwitch_RecipeStatus"
        Me.btnSwitch_RecipeStatus.Size = New System.Drawing.Size(122, 25)
        Me.btnSwitch_RecipeStatus.TabIndex = 37
        Me.btnSwitch_RecipeStatus.Text = "Изменить статус"
        Me.btnSwitch_RecipeStatus.UseVisualStyleBackColor = True
        '
        'lbRecipeStatus
        '
        Me.lbRecipeStatus.AutoSize = True
        Me.lbRecipeStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbRecipeStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lbRecipeStatus.Location = New System.Drawing.Point(6, 23)
        Me.lbRecipeStatus.Name = "lbRecipeStatus"
        Me.lbRecipeStatus.Size = New System.Drawing.Size(126, 16)
        Me.lbRecipeStatus.TabIndex = 34
        Me.lbRecipeStatus.Text = "Статус рецепта"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbchooseRecipe)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(498, 63)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Номер рецепта"
        '
        'cbchooseRecipe
        '
        Me.cbchooseRecipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbchooseRecipe.FormattingEnabled = True
        Me.cbchooseRecipe.Location = New System.Drawing.Point(14, 21)
        Me.cbchooseRecipe.Name = "cbchooseRecipe"
        Me.cbchooseRecipe.Size = New System.Drawing.Size(465, 24)
        Me.cbchooseRecipe.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 646)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tbRecipeID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPatientInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Электронные рецепты"
        Me.gbPatientInfo.ResumeLayout(False)
        Me.gbPatientInfo.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbRecipeID As TextBox
    Friend WithEvents tbMedcardNumber As TextBox
    Friend WithEvents lbMedcardNumber As Label
    Friend WithEvents tbSex As TextBox
    Friend WithEvents lbSex As Label
    Friend WithEvents tbOMS As TextBox
    Friend WithEvents lbOMS As Label
    Friend WithEvents lbSnils As Label
    Friend WithEvents tbBirthday As TextBox
    Friend WithEvents lbBirthday As Label
    Friend WithEvents tbMiddlename As TextBox
    Friend WithEvents lbMiddlename As Label
    Friend WithEvents tbFirstname As TextBox
    Friend WithEvents lbFirstname As Label
    Friend WithEvents tbSurname As TextBox
    Friend WithEvents lbSurname As Label
    Friend WithEvents tbSnils As TextBox
    Friend WithEvents gbPatientInfo As GroupBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents clmMNN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmForma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDosage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSigna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTotalamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents tbDueDate As TextBox
    Friend WithEvents lbDueDate As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbRecipeStatus As Label
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSwitch_RecipeStatus As Button
    Friend WithEvents cbRecipeStatus As ComboBox
    Friend WithEvents tbCurrentStatus As TextBox
    Friend WithEvents lbCurrentStatus As Label
    Friend WithEvents tbQuantityOrders As TextBox
    Friend WithEvents btnlastOrders As Button
    Friend WithEvents lbOrders As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbchooseRecipe As ComboBox
    Friend WithEvents lbRecipeID As Label
End Class
