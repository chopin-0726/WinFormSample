<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlColorGridView
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BindingSourceCategory = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.IsSubmitTargetDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category1IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckButton
        '
        Me.CheckButton.Location = New System.Drawing.Point(20, 260)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(75, 23)
        Me.CheckButton.TabIndex = 14
        Me.CheckButton.Text = "check"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(213, 230)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 13
        Me.ResetButton.Text = "reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(122, 230)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 12
        Me.DeleteButton.Text = "delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(20, 230)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 11
        Me.AddButton.Text = "add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsSubmitTargetDataGridViewCheckBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.Category1DataGridViewTextBoxColumn, Me.Category1IdDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSourceProduct
        Me.DataGridView1.Location = New System.Drawing.Point(3, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(505, 224)
        Me.DataGridView1.TabIndex = 10
        '
        'BindingSourceCategory
        '
        Me.BindingSourceCategory.DataSource = GetType(WinFormSample.Control.Product.Category)
        '
        'BindingSourceProduct
        '
        Me.BindingSourceProduct.DataSource = GetType(WinFormSample.Control.ProductWithColor)
        '
        'IsSubmitTargetDataGridViewCheckBoxColumn
        '
        Me.IsSubmitTargetDataGridViewCheckBoxColumn.DataPropertyName = "IsSubmitTarget"
        Me.IsSubmitTargetDataGridViewCheckBoxColumn.HeaderText = "IsSubmitTarget"
        Me.IsSubmitTargetDataGridViewCheckBoxColumn.Name = "IsSubmitTargetDataGridViewCheckBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'Category1DataGridViewTextBoxColumn
        '
        Me.Category1DataGridViewTextBoxColumn.DataPropertyName = "Category1"
        Me.Category1DataGridViewTextBoxColumn.HeaderText = "Category1"
        Me.Category1DataGridViewTextBoxColumn.Name = "Category1DataGridViewTextBoxColumn"
        Me.Category1DataGridViewTextBoxColumn.Visible = False
        '
        'Category1IdDataGridViewTextBoxColumn
        '
        Me.Category1IdDataGridViewTextBoxColumn.DataPropertyName = "Category1Id"
        Me.Category1IdDataGridViewTextBoxColumn.DataSource = Me.BindingSourceCategory
        Me.Category1IdDataGridViewTextBoxColumn.DisplayMember = "Name"
        Me.Category1IdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = True
        Me.Category1IdDataGridViewTextBoxColumn.HeaderText = "Category1Id"
        Me.Category1IdDataGridViewTextBoxColumn.Name = "Category1IdDataGridViewTextBoxColumn"
        Me.Category1IdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Category1IdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Category1IdDataGridViewTextBoxColumn.ValueMember = "Id"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'CtlColorGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CtlColorGridView"
        Me.Size = New System.Drawing.Size(607, 380)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents BindingSourceProduct As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceCategory As System.Windows.Forms.BindingSource
    Friend WithEvents IsSubmitTargetDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category1IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
