<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlChainedComboBox
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SearchResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Category2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Categroy1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Category2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categroy1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Search Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Category2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Category1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.Category1DataGridViewTextBoxColumn, Me.Category2DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SearchResultBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(466, 211)
        Me.DataGridView1.TabIndex = 8
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
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
        '
        'Category2DataGridViewTextBoxColumn
        '
        Me.Category2DataGridViewTextBoxColumn.DataPropertyName = "Category2"
        Me.Category2DataGridViewTextBoxColumn.HeaderText = "Category2"
        Me.Category2DataGridViewTextBoxColumn.Name = "Category2DataGridViewTextBoxColumn"
        Me.Category2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SearchResultBindingSource
        '
        Me.SearchResultBindingSource.DataSource = GetType(WinFormSample.Control.Product)
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ViewModelBindingSource, "Category2Selected", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox2.DataSource = Me.Category2BindingSource
        Me.ComboBox2.DisplayMember = "Name"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 64)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(192, 20)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.ValueMember = "Id"
        '
        'ViewModelBindingSource
        '
        Me.ViewModelBindingSource.DataSource = GetType(WinFormSample.Control.VMChainedComboBox)
        '
        'Category2BindingSource
        '
        Me.Category2BindingSource.DataSource = GetType(WinFormSample.Control.Product.Category)
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ViewModelBindingSource, "Category1Selected", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.DataSource = Me.Categroy1BindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 20)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "Id"
        '
        'Categroy1BindingSource
        '
        Me.Categroy1BindingSource.DataSource = GetType(WinFormSample.Control.Product.Category)
        '
        'CtlChainedComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "CtlChainedComboBox"
        Me.Size = New System.Drawing.Size(626, 415)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Category2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categroy1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Categroy1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Category2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SearchResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewModelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
