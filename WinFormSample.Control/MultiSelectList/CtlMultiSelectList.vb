Imports System.Windows.Forms

Public Class CtlMultiSelectList
    Private ReadOnly _viewModel As VMMultiSelectList

    Public Sub New()
        InitializeComponent()
        _viewModel = New VMMultiSelectList()
        BindingSourceNotSelected.DataSource = _viewModel.NotSelected
        BindingSourceSelected.DataSource = _viewModel.Selected

    End Sub

    ''' <summary>
    ''' →ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LeftToRight_Click(sender As Object, e As EventArgs) Handles LeftToRight.Click
        If NotSelectedDataGridView.Rows.Count = 0 Then
            MessageBox.Show("no item.")
            Return
        ElseIf NotSelectedDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("not selected.")
            Return
        End If

        Dim index As Integer = NotSelectedDataGridView.Rows.Count - 1
        Dim insertPosition As Integer = SelectedDataGridView.RowCount
        Do
            If NotSelectedDataGridView.Rows.Item(index).Selected Then
                _viewModel.MoveToSelected(CType(NotSelectedDataGridView.CurrentRow.DataBoundItem, Product))
            End If
            index = index - 1
        Loop While index >= 0
    End Sub

    ''' <summary>
    ''' ←ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RightToLeft_Click(sender As Object, e As EventArgs) Handles RightToLeft.Click
        If SelectedDataGridView.Rows.Count = 0 Then
            MessageBox.Show("no item.")
            Return
        ElseIf SelectedDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("not selected.")
            Return
        End If

        Dim index As Integer = SelectedDataGridView.Rows.Count - 1
        Do
            If SelectedDataGridView.Rows.Item(index).Selected Then
                _viewModel.MoveToNotSelected(CType(SelectedDataGridView.CurrentRow.DataBoundItem, Product))
            End If
            index = index - 1
        Loop While index >= 0
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        'save to Database.
    End Sub
End Class
