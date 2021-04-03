<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecipesForm))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.cbListofRecipes = New System.Windows.Forms.ComboBox()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnChoose)
        Me.GroupBox3.Controls.Add(Me.cbListofRecipes)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 93)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Выберите нужный рецепт"
        '
        'btnChoose
        '
        Me.btnChoose.Location = New System.Drawing.Point(95, 60)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(80, 23)
        Me.btnChoose.TabIndex = 1
        Me.btnChoose.Text = "Выбрать"
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'cbListofRecipes
        '
        Me.cbListofRecipes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbListofRecipes.FormattingEnabled = True
        Me.cbListofRecipes.Location = New System.Drawing.Point(6, 30)
        Me.cbListofRecipes.Name = "cbListofRecipes"
        Me.cbListofRecipes.Size = New System.Drawing.Size(256, 24)
        Me.cbListofRecipes.TabIndex = 0
        '
        'RecipesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 123)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RecipesForm"
        Me.Text = "Рецепты"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnChoose As Button
    Friend WithEvents cbListofRecipes As ComboBox
End Class
