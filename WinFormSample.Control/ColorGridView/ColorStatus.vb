Imports System.Windows.Forms
Imports System.Drawing

''' <summary>
''' 色変更を行うエンティティの基底クラス
''' </summary>
''' <remarks></remarks>
Public Class ColorStatus
    Property Status As EditStatus

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

    Public Sub New(ByVal target As DataGridView)
        _dataGridView = target
        AddHandler _dataGridView.CellValueChanged, AddressOf CellValueChanged
        AddHandler _dataGridView.CellFormatting, AddressOf CellFormatting
    End Sub

    ''' <summary>
    ''' 行表示時、行のステータスで行の色を変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="rowevent"></param>
    ''' <remarks></remarks>
    Private Sub CellValueChanged(sender As Object, rowevent As EventArgs)
        If _dataGridView.CurrentCell Is Nothing Then
            Return
        End If
        'セル色、編集状態変更
        Dim e As DataGridViewCellEventArgs = CType(rowevent, DataGridViewCellEventArgs)
        Dim status As EditStatus = TryCast(_dataGridView.Rows.Item(e.RowIndex).DataBoundItem, ColorStatus).Status
        If status = EditStatus.None OrElse status = EditStatus.Updated Then
            status = EditStatus.Updated
            _dataGridView.CurrentCell.Style.BackColor = Color.Beige
            TryCast(_dataGridView.Rows.Item(e.RowIndex).DataBoundItem, ColorStatus).Status = EditStatus.Updated
        End If
    End Sub

    ''' <summary>
    ''' セル編集時、セルの色を変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="rowevent"></param>
    ''' <remarks></remarks>
    Private Sub CellFormatting(sender As Object, rowevent As EventArgs)
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim e As DataGridViewCellFormattingEventArgs = CType(rowevent, DataGridViewCellFormattingEventArgs)

        '列の編集状態により色変更
        Dim val As EditStatus = TryCast(dgv.Rows(e.RowIndex).DataBoundItem, ColorStatus).Status
        If val = EditStatus.Created Then
            _dataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        ElseIf val = EditStatus.Deleted Then
            _dataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        ElseIf val = EditStatus.None Then
            _dataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Nothing
        End If
    End Sub
End Class