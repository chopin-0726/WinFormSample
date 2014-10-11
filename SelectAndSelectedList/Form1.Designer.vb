<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.SelectDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectedDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeftToRight = New System.Windows.Forms.Button()
        Me.RightToLeft = New System.Windows.Forms.Button()
        CType(Me.SelectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectDataGridView
        '
        Me.SelectDataGridView.AllowUserToAddRows = False
        Me.SelectDataGridView.AllowUserToDeleteRows = False
        Me.SelectDataGridView.AutoGenerateColumns = False
        Me.SelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SelectDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.SelectDataGridView.DataSource = Me.SelectBindingSource
        Me.SelectDataGridView.Location = New System.Drawing.Point(57, 39)
        Me.SelectDataGridView.Name = "SelectDataGridView"
        Me.SelectDataGridView.ReadOnly = True
        Me.SelectDataGridView.RowTemplate.Height = 21
        Me.SelectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SelectDataGridView.Size = New System.Drawing.Size(167, 210)
        Me.SelectDataGridView.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'SelectBindingSource
        '
        Me.SelectBindingSource.DataSource = GetType(SelectAndSelectedList.ViewModel.User)
        '
        'SelectedDataGridView
        '
        Me.SelectedDataGridView.AllowUserToAddRows = False
        Me.SelectedDataGridView.AllowUserToDeleteRows = False
        Me.SelectedDataGridView.AutoGenerateColumns = False
        Me.SelectedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SelectedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn1, Me.IdDataGridViewTextBoxColumn1})
        Me.SelectedDataGridView.DataSource = Me.SelectedBindingSource
        Me.SelectedDataGridView.Location = New System.Drawing.Point(351, 39)
        Me.SelectedDataGridView.Name = "SelectedDataGridView"
        Me.SelectedDataGridView.ReadOnly = True
        Me.SelectedDataGridView.RowTemplate.Height = 21
        Me.SelectedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SelectedDataGridView.Size = New System.Drawing.Size(176, 210)
        Me.SelectedDataGridView.TabIndex = 1
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'SelectedBindingSource
        '
        Me.SelectedBindingSource.DataSource = GetType(SelectAndSelectedList.ViewModel.User)
        '
        'LeftToRight
        '
        Me.LeftToRight.Location = New System.Drawing.Point(245, 69)
        Me.LeftToRight.Name = "LeftToRight"
        Me.LeftToRight.Size = New System.Drawing.Size(75, 23)
        Me.LeftToRight.TabIndex = 2
        Me.LeftToRight.Text = "→"
        Me.LeftToRight.UseVisualStyleBackColor = True
        '
        'RightToLeft
        '
        Me.RightToLeft.Location = New System.Drawing.Point(245, 164)
        Me.RightToLeft.Name = "RightToLeft"
        Me.RightToLeft.Size = New System.Drawing.Size(75, 23)
        Me.RightToLeft.TabIndex = 3
        Me.RightToLeft.Text = "←"
        Me.RightToLeft.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 310)
        Me.Controls.Add(Me.RightToLeft)
        Me.Controls.Add(Me.LeftToRight)
        Me.Controls.Add(Me.SelectedDataGridView)
        Me.Controls.Add(Me.SelectDataGridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SelectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SelectDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SelectedDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LeftToRight As System.Windows.Forms.Button
    Friend WithEvents RightToLeft As System.Windows.Forms.Button
    Friend WithEvents SelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
