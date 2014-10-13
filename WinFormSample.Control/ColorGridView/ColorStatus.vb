Imports System.Windows.Forms
Imports System.Drawing

''' <summary>
''' 色変更を行うエンティティの基底クラス
''' </summary>
''' <remarks></remarks>
Public Class ColorStatus
    Property Status As EditStatus
    Property RowId As Integer

    Public Sub New()
        Status = EditStatus.None
    End Sub

    Public Sub New(ByVal source As ColorStatus)
        Status = source.Status
    End Sub

End Class

''' <summary>
''' 更新状態
''' </summary>
''' <remarks></remarks>
Public Enum EditStatus
    None
    Created
    Updated
    Deleted
End Enum

''' <summary>
''' DataGridViewの色変更処理セット
''' </summary>
''' <remarks></remarks>
Public Class CellColorFormatter(Of T As ColorStatus)

    Private ReadOnly _dataGridView As DataGridView
    Public ReadOnly Property DataGridView As DataGridView
        Get
            Return _dataGridView
        End Get
    End Property

    Private ReadOnly _original As IList(Of T)
    Private ReadOnly _editing As IList(Of T)
    Private index As Integer


    Public Sub New(ByVal target As DataGridView, ByVal original As IList(Of T), ByVal editing As IList(Of T))
        _dataGridView = target
        AddHandler _dataGridView.CellValueChanged, AddressOf CellValueChanged
        AddHandler _dataGridView.CellFormatting, AddressOf CellFormatting

        _original = original
        _editing = editing

        'TODO: っていうかここで一緒のデータじゃないと無理ゲー（実装方法直したい）
        If (_original.Count <> _editing.Count) Then Return

        'rowidを振る（Update検出用ユニークキーとして、同じ値を持たせる）
        Do While index <= _original.Count - 1
            _original.Item(index).RowId = index
            _editing.Item(index).RowId = index
            index += 1
        Loop

    End Sub

    ''' <summary>
    ''' セル編集時、行ステータスを変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="rowevent"></param>
    ''' <remarks></remarks>
    Private Sub CellValueChanged(sender As Object, rowevent As EventArgs)
        If _dataGridView.CurrentCell Is Nothing Then
            Return
        End If
        '編集状態変更
        Dim e As DataGridViewCellEventArgs = CType(rowevent, DataGridViewCellEventArgs)
        Dim status As EditStatus = TryCast(_dataGridView.Rows.Item(e.RowIndex).DataBoundItem, ColorStatus).Status
        If status = EditStatus.None OrElse status = EditStatus.Updated Then
            status = EditStatus.Updated
            TryCast(_dataGridView.Rows.Item(e.RowIndex).DataBoundItem, ColorStatus).Status = EditStatus.Updated
        End If
    End Sub

    ''' <summary>
    ''' 行表示時、行のステータスで行の色を変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="rowevent"></param>
    ''' <remarks></remarks>
    Private Sub CellFormatting(sender As Object, rowevent As EventArgs)
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim e As DataGridViewCellFormattingEventArgs = CType(rowevent, DataGridViewCellFormattingEventArgs)

        '列の編集状態により色変更
        Dim item As ColorStatus = TryCast(dgv.Rows(e.RowIndex).DataBoundItem, ColorStatus)
        Dim row As DataGridViewRow = _dataGridView.Rows(e.RowIndex)

        If item.Status = EditStatus.Created Then
            row.DefaultCellStyle.BackColor = Color.Aqua
        ElseIf item.Status = EditStatus.Deleted Then
            row.Visible = False
        ElseIf item.Status = EditStatus.None Then
            row.DefaultCellStyle.BackColor = Nothing
        ElseIf item.Status = EditStatus.Updated Then
            ApplyUpdateColor(dgv, e.RowIndex)
        End If
    End Sub

    ''' <summary>
    ''' オリジナルと比較し、値が更新されたセルの色を変更
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ApplyUpdateColor(ByVal dgv As DataGridView, RowIndex As Integer) As Boolean
        Dim item As T = TryCast(dgv.Rows(RowIndex).DataBoundItem, T)
        Dim row As DataGridViewRow = _dataGridView.Rows(RowIndex)

        Dim originalRow As T = _original.Where(Function(t) t.RowId = item.RowId).ToList().Item(0)

        Dim currentCellIndex As Integer = row.Cells.Count - 1
        Do While currentCellIndex >= 0

            Try
                Dim column As DataGridViewColumn = row.Cells(currentCellIndex).OwningColumn
                currentCellIndex -= 1
                If column.Visible = False Then Continue Do

                Dim originalValue As Object = originalRow.GetType.GetProperty(column.DataPropertyName).GetValue(originalRow)
                Dim editedValue As Object = item.GetType.GetProperty(column.DataPropertyName).GetValue(item)
                Dim changed As Boolean = originalValue.Equals(editedValue) = False
                If changed And row.Cells(column.Index).Style.BackColor = Nothing Then
                    row.Cells(column.Index).Style.BackColor = Color.PaleGreen
                End If
            Catch e As Exception
                Debug.Print(e.ToString)
                Return False
            End Try
        Loop
        Return False
    End Function

End Class