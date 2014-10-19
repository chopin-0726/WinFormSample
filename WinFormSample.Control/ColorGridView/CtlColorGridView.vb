Imports System.Windows.Forms
Imports System.Drawing
Imports WinFormSample.Control.ColorStatus
Imports System.ComponentModel
Imports FluentValidation.Results

Public Class CtlColorGridView

    Private ReadOnly _viewModel As VmColorGridView
    Private ReadOnly _colorGridView As CellColorFormatter(Of ProductWithColor)
    Private ReadOnly _validator As ProductWithColorValidator

    Public Sub New()
        InitializeComponent()
        _viewModel = New VmColorGridView()
        _validator = New ProductWithColorValidator()
        BindingSourceProduct.DataSource = _viewModel.Editing
        _colorGridView = New CellColorFormatter(Of ProductWithColor)( _
            DataGridView1, _viewModel.Original, _viewModel.Editing.ToList())
        BindingSourceCategory.DataSource = _viewModel.Category1
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        _viewModel.Add()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'フォーカスをはずさないと列をVisible=Falseにできない
        'フォーカスを外した時点でCellFormattingが発生する　→フォーカスを外すのが先
        DataGridView1.CurrentCell = Nothing
        _viewModel.Delete(BindingSourceProduct.Position)
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        _viewModel.Reset()
        BindingSourceProduct.DataSource = _viewModel.Editing
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click

    End Sub

    Private Sub SortButton_Click(sender As Object, e As EventArgs) Handles SortButton.Click
        _viewModel.Reverse()
    End Sub

    ''' <summary>
    ''' 行描画時、行単位エラーメッセージ要求イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataGridView1_RowErrorTextNeeded(sender As Object, e As DataGridViewRowErrorTextNeededEventArgs) Handles DataGridView1.RowErrorTextNeeded
        'CellErrorTextNeededでセル単位でも処理できるが、
        '行のオブジェクト単位でバリデーションしたかったのでこっちのイベント
        'Rowとついているが、セル１つ編集しただけで発生する

        'CellValidating だとそのセルだけeventArgs.CellFormattedValueから取れる(DataBoundItemは未変更状態で、変更後の行情報はとれない)
        'RowValidating だと行移動（orグリッドからフォーカスが外れる）で発生、DataBoundItemから行取得可
        'ただし↑２つはソート等でキャンセルされてしまう（グリッド側にセットする情報　セル色変更と同じ理屈）

        Try
            Dim dgv As DataGridView = CType(sender, DataGridView)
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
            Dim item As ProductWithColor = TryCast(row.DataBoundItem, ProductWithColor)
            Dim result As ValidationResult = _validator.Validate(item)

            For currentCellIndex As Integer = 0 To row.Cells.Count - 1 Step 1
                Dim column As DataGridViewColumn = row.Cells(currentCellIndex).OwningColumn
                If column.Visible = False Then Continue For
                Dim editedValue As Object = item.GetType.GetProperty(column.DataPropertyName).GetValue(item)
                '自カラム（プロパティ）のエラー文言を取得
                'エラーがある場合、メッセージをON（OFF操作は値編集後のCellValueChanged）
                Dim targetErrors As IList(Of ValidationFailure) = result.Errors.Where(Function(t) t.PropertyName = column.DataPropertyName).ToList()
                If dgv(column.Index, e.RowIndex).ErrorText <> "" Or targetErrors.Count = 0 Then
                    Continue For
                End If
                For Each faillure As ValidationFailure In targetErrors
                    If dgv(column.Index, e.RowIndex).ErrorText <> "" Then dgv(column.Index, e.RowIndex).ErrorText += vbCrLf
                    dgv(column.Index, e.RowIndex).ErrorText += faillure.ErrorMessage
                Next
            Next
        Catch ex As Exception
            Debug.Print(ex.ToString)
            Return
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim dgv As DataGridView = CType(sender, DataGridView)
        If dgv.CurrentCell Is Nothing Then Return

        '値の再評価のため、メッセージを一旦OFF（エラーがあった場合、RowErrorTextNeededで処理される）
        '値変更契機でのみOFFをする　RowErrorTextNeededだとアイコンが点滅状態になるのでNG
        dgv(e.ColumnIndex, e.RowIndex).ErrorText = ""
    End Sub
End Class
