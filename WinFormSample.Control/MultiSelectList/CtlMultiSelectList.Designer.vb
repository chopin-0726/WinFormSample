<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlMultiSelectList
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
        Me.RightToLeft = New System.Windows.Forms.Button()
        Me.LeftToRight = New System.Windows.Forms.Button()
        Me.SelectedDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceSelected = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotSelectedDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceNotSelected = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        CType(Me.SelectedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotSelectedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceNotSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RightToLeft
        '
        Me.RightToLeft.Location = New System.Drawing.Point(229, 147)
        Me.RightToLeft.Name = "RightToLeft"
        Me.RightToLeft.Size = New System.Drawing.Size(75, 23)
        Me.RightToLeft.TabIndex = 7
        Me.RightToLeft.Text = "←"
        Me.RightToLeft.UseVisualStyleBackColor = True
        '
        'LeftToRight
        '
        Me.LeftToRight.Location = New System.Drawing.Point(229, 52)
        Me.LeftToRight.Name = "LeftToRight"
        Me.LeftToRight.Size = New System.Drawing.Size(75, 23)
        Me.LeftToRight.TabIndex = 6
        Me.LeftToRight.Text = "→"
        Me.LeftToRight.UseVisualStyleBackColor = True
        '
        'SelectedDataGridView
        '
        Me.SelectedDataGridView.AllowUserToAddRows = False
        Me.SelectedDataGridView.AllowUserToDeleteRows = False
        Me.SelectedDataGridView.AutoGenerateColumns = False
        Me.SelectedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SelectedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.NameDataGridViewTextBoxColumn1, Me.Category1DataGridViewTextBoxColumn1, Me.Category2DataGridViewTextBoxColumn1})
        Me.SelectedDataGridView.DataSource = Me.BindingSourceSelected
        Me.SelectedDataGridView.Location = New System.Drawing.Point(335, 22)
        Me.SelectedDataGridView.Name = "SelectedDataGridView"
        Me.SelectedDataGridView.ReadOnly = True
        Me.SelectedDataGridView.RowTemplate.Height = 21
        Me.SelectedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SelectedDataGridView.Size = New System.Drawing.Size(176, 210)
        Me.SelectedDataGridView.TabIndex = 5
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Category1DataGridViewTextBoxColumn1
        '
        Me.Category1DataGridViewTextBoxColumn1.DataPropertyName = "Category1"
        Me.Category1DataGridViewTextBoxColumn1.HeaderText = "Category1"
        Me.Category1DataGridViewTextBoxColumn1.Name = "Category1DataGridViewTextBoxColumn1"
        Me.Category1DataGridViewTextBoxColumn1.ReadOnly = True
        Me.Category1DataGridViewTextBoxColumn1.Visible = False
        '
        'Category2DataGridViewTextBoxColumn1
        '
        Me.Category2DataGridViewTextBoxColumn1.DataPropertyName = "Category2"
        Me.Category2DataGridViewTextBoxColumn1.HeaderText = "Category2"
        Me.Category2DataGridViewTextBoxColumn1.Name = "Category2DataGridViewTextBoxColumn1"
        Me.Category2DataGridViewTextBoxColumn1.ReadOnly = True
        Me.Category2DataGridViewTextBoxColumn1.Visible = False
        '
        'BindingSourceSelected
        '
        Me.BindingSourceSelected.DataSource = GetType(WinFormSample.Control.Product)
        '
        'NotSelectedDataGridView
        '
        Me.NotSelectedDataGridView.AllowUserToAddRows = False
        Me.NotSelectedDataGridView.AllowUserToDeleteRows = False
        Me.NotSelectedDataGridView.AutoGenerateColumns = False
        Me.NotSelectedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotSelectedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.Category1DataGridViewTextBoxColumn, Me.Category2DataGridViewTextBoxColumn})
        Me.NotSelectedDataGridView.DataSource = Me.BindingSourceNotSelected
        Me.NotSelectedDataGridView.Location = New System.Drawing.Point(41, 22)
        Me.NotSelectedDataGridView.Name = "NotSelectedDataGridView"
        Me.NotSelectedDataGridView.ReadOnly = True
        Me.NotSelectedDataGridView.RowTemplate.Height = 21
        Me.NotSelectedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NotSelectedDataGridView.Size = New System.Drawing.Size(167, 210)
        Me.NotSelectedDataGridView.TabIndex = 4
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MaxInputLength = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Category1DataGridViewTextBoxColumn
        '
        Me.Category1DataGridViewTextBoxColumn.DataPropertyName = "Category1"
        Me.Category1DataGridViewTextBoxColumn.HeaderText = "Category1"
        Me.Category1DataGridViewTextBoxColumn.Name = "Category1DataGridViewTextBoxColumn"
        Me.Category1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Category1DataGridViewTextBoxColumn.Visible = False
        '
        'Category2DataGridViewTextBoxColumn
        '
        Me.Category2DataGridViewTextBoxColumn.DataPropertyName = "Category2"
        Me.Category2DataGridViewTextBoxColumn.HeaderText = "Category2"
        Me.Category2DataGridViewTextBoxColumn.Name = "Category2DataGridViewTextBoxColumn"
        Me.Category2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Category2DataGridViewTextBoxColumn.Visible = False
        '
        'BindingSourceNotSelected
        '
        Me.BindingSourceNotSelected.DataSource = GetType(WinFormSample.Control.Product)
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Location = New System.Drawing.Point(422, 260)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(89, 23)
        Me.ButtonSubmit.TabIndex = 8
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'CtlMultiSelectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.RightToLeft)
        Me.Controls.Add(Me.LeftToRight)
        Me.Controls.Add(Me.SelectedDataGridView)
        Me.Controls.Add(Me.NotSelectedDataGridView)
        Me.Name = "CtlMultiSelectList"
        Me.Size = New System.Drawing.Size(598, 349)
        CType(Me.SelectedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotSelectedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceNotSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RightToLeft As System.Windows.Forms.Button
    Friend WithEvents LeftToRight As System.Windows.Forms.Button
    Friend WithEvents SelectedDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NotSelectedDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceNotSelected As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceSelected As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button

End Class
