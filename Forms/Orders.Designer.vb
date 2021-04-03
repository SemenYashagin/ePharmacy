<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMNN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.clmForma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDosage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmPackageContent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTotalamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridControl2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Заказы пациента"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(6, 21)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRichTextEdit1, Me.RepositoryItemMemoEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(512, 168)
        Me.GridControl2.TabIndex = 34
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMNN, Me.clmName, Me.clmForma, Me.clmDosage, Me.clmPackageContent, Me.clmTotalamount})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        'clmPackageContent
        '
        Me.clmPackageContent.Caption = "В одной упаковке"
        Me.clmPackageContent.FieldName = "clmPackageContent"
        Me.clmPackageContent.Name = "clmPackageContent"
        Me.clmPackageContent.Visible = True
        Me.clmPackageContent.VisibleIndex = 5
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
        Me.clmTotalamount.VisibleIndex = 4
        Me.clmTotalamount.Width = 291
        '
        'RepositoryItemRichTextEdit1
        '
        Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
        Me.RepositoryItemRichTextEdit1.ShowCaretInReadOnly = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 227)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Orders"
        Me.Text = "Заказы"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmMNN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents clmForma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDosage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTotalamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents clmPackageContent As DevExpress.XtraGrid.Columns.GridColumn
End Class
