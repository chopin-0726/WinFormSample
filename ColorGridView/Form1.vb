Public Class Form1
    Private ReadOnly _viewModel As ViewModel

    'Public Sub New()
    '    InitializeComponent()
    '    _viewModel = New ViewModel
    '    UserBindingSource.DataSource = _viewModel.Editing
    '    ViewModelBindingSource.DataSource = _viewModel

    '    AddHandler DataGridView1.CellFormatting, AddressOf ColorDataGridView.CellFormatting
    '    AddHandler DataGridView1.CellValueChanged, AddressOf ColorDataGridView.CellValueChanged
    'End Sub

    'Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
    '    _viewModel.Add()
    '    UserBindingSource.DataSource = _viewModel.Editing
    '    UserBindingSource.ResetBindings(False)
    'End Sub

    'Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
    '    _viewModel.Delete(UserBindingSource.Position)
    '    UserBindingSource.DataSource = _viewModel.Editing
    '    UserBindingSource.ResetBindings(False)
    'End Sub

    'Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
    '    _viewModel.Fix()
    'End Sub

    'Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
    '    _viewModel.Reset()
    '    UserBindingSource.DataSource = _viewModel.Editing

    'End Sub

    ' ''' <summary>
    ' ''' 値編集時処理
    ' ''' </summary>
    ' ''' <param name="sender"></param>
    ' ''' <param name="e"></param>
    ' ''' <remarks></remarks>
    'Private Sub dataGridView1_CellValueChanged(ByVal sender As Object, _
    '    ByVal e As DataGridViewCellEventArgs) _
    '    Handles DataGridView1.CellValueChanged
    '    If DataGridView1.CurrentCell Is Nothing Then
    '        Return
    '    End If
    '    'セル色、編集状態変更
    '    Dim status As EditType = TryCast(DataGridView1.Rows.Item(e.RowIndex).DataBoundItem, TenantGroup).EditStatus
    '    If status = EditType.None OrElse status = EditType.Updated Then
    '        status = EditType.Updated
    '        DataGridView1.CurrentCell.Style.BackColor = Color.Beige
    '    End If
    'End Sub

    ' ''' <summary>
    ' ''' セル表示時処理
    ' ''' </summary>
    ' ''' <param name="sender"></param>
    ' ''' <param name="e"></param>
    ' ''' <remarks></remarks>
    'Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
    '    Dim dgv As DataGridView = CType(sender, DataGridView)
    '    '列の編集状態により色変更
    '    Dim val As EditType = TryCast(dgv.Rows(e.RowIndex).DataBoundItem, TenantGroup).EditStatus
    '    If val = EditType.Created Then
    '        dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
    '    ElseIf val = EditType.Deleted Then
    '        dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
    '    ElseIf val = EditType.None Then
    '        dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
    '    End If
    'End Sub

End Class
