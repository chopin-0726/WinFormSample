<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBase
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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.ComboBoxControlName = New System.Windows.Forms.ComboBox()
        Me.BindingSourceControlName = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSourceControlName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Location = New System.Drawing.Point(12, 60)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(652, 472)
        Me.MainPanel.TabIndex = 0
        '
        'ComboBoxControlName
        '
        Me.ComboBoxControlName.FormattingEnabled = True
        Me.ComboBoxControlName.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxControlName.Name = "ComboBoxControlName"
        Me.ComboBoxControlName.Size = New System.Drawing.Size(237, 20)
        Me.ComboBoxControlName.TabIndex = 1
        '
        'FrmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 544)
        Me.Controls.Add(Me.ComboBoxControlName)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "FrmBase"
        Me.Text = "Form1"
        CType(Me.BindingSourceControlName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents ComboBoxControlName As System.Windows.Forms.ComboBox
    Friend WithEvents BindingSourceControlName As System.Windows.Forms.BindingSource

End Class
