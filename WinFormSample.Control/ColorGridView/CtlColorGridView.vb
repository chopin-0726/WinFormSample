Imports System.Windows.Forms
Imports System.Drawing
Imports WinFormSample.Control.ColorStatus

Public Class CtlColorGridView

    Private ReadOnly _viewModel As VmColorGridView
    Private ReadOnly _colorGridView As CellColorFormatter(Of ProductWithColor)

    Public Sub New()
        InitializeComponent()
        _viewModel = New VmColorGridView()
        'TODO: BindingSourceがなくてもいけるのでは？
        BindingSourceProduct.DataSource = _viewModel.Editing
        _colorGridView = New CellColorFormatter(Of ProductWithColor)(DataGridView1)
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        _viewModel.Add()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        _viewModel.Delete(BindingSourceProduct.Position)
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        _viewModel.Reset()
        BindingSourceProduct.DataSource = _viewModel.Editing
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click

    End Sub

End Class
