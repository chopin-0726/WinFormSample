Imports System.Windows.Forms
Imports System.Drawing
Imports WinFormSample.Control.ColorStatus

Public Class CtlColorGridView

    Private ReadOnly _viewModel As VmColorGridView
    Private ReadOnly _colorGridView As CellColorFormatter(Of ProductWithColor)

    Public Sub New()
        InitializeComponent()
        _viewModel = New VmColorGridView()
        BindingSourceProduct.DataSource = _viewModel.Editing
        _colorGridView = New CellColorFormatter(Of ProductWithColor)(DataGridView1)
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        _viewModel.Add()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        _viewModel.Delete(BindingSourceProduct.Position)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        _viewModel.Reset()
        BindingSourceProduct.DataSource = _viewModel.Editing
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click

    End Sub

    'Private Sub DataGridView1_CellValueChanged(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
    '    If DataGridView1.CurrentCell Is Nothing Then
    '        Return
    '    End If
    '    'セル色、編集状態変更
    '    Dim status As EditStatus = TryCast(DataGridView1.Rows.Item(e.RowIndex).DataBoundItem, ProductWithColor).Status
    '    If status = EditStatus.None OrElse status = EditStatus.Updated Then
    '        status = EditStatus.Updated
    '        DataGridView1.CurrentCell.Style.BackColor = Color.Beige
    '        TryCast(DataGridView1.Rows.Item(e.RowIndex).DataBoundItem, ProductWithColor).Status = EditStatus.Updated
    '    End If
    'End Sub

    'Private Sub DataGridView1_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
    '    Dim dgv As DataGridView = CType(sender, DataGridView)
    '    '列の編集状態により色変更
    '    Dim val As EditStatus = TryCast(dgv.Rows(e.RowIndex).DataBoundItem, ProductWithColor).Status
    '    If val = EditStatus.Created Then
    '        DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
    '    ElseIf val = EditStatus.Deleted Then
    '        DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
    '    ElseIf val = EditStatus.None Then
    '        DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
    '    End If
    'End Sub
End Class
