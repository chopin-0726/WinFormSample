Public Class Form1
    Private _viewModel As ViewModel
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        _viewModel = New ViewModel
        SelectBindingSource.DataSource = _viewModel.SelectList
        SelectedBindingSource.DataSource = _viewModel.SelectedList

    End Sub

    Private Sub LeftToRight_Click(sender As Object, e As EventArgs) Handles LeftToRight.Click
        If SelectDataGridView.Rows.Count = 0 Then
            MessageBox.Show("no item.")
            Return
        ElseIf SelectDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("not selected.")
            Return
        End If

        Dim index = SelectDataGridView.Rows.Count - 1
        Dim insertPosition = SelectedDataGridView.RowCount
        Do
            If SelectDataGridView.Rows.Item(index).Selected Then
                SelectedDataGridView.DataSource.Insert(insertPosition, SelectDataGridView.Rows.Item(index).DataBoundItem)
                SelectDataGridView.Rows.RemoveAt(index)
            End If
            index = index - 1
        Loop While index >= 0

        SelectedBindingSource.ResetBindings(False)
    End Sub

    Private Sub RightToLeft_Click(sender As Object, e As EventArgs) Handles RightToLeft.Click
        If SelectedDataGridView.Rows.Count = 0 Then
            MessageBox.Show("no item.")
            Return
        ElseIf SelectedDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("not selected.")
            Return
        End If
        Dim index = SelectedDataGridView.Rows.Count - 1
        Dim insertPosition = SelectDataGridView.RowCount
        Do
            If SelectedDataGridView.Rows.Item(index).Selected Then
                SelectDataGridView.DataSource.Insert(insertPosition, SelectedDataGridView.Rows.Item(index).DataBoundItem)
                SelectedDataGridView.Rows.RemoveAt(index)
            End If
            index = index - 1
        Loop While index >= 0

        SelectBindingSource.ResetBindings(False)
    End Sub
End Class
