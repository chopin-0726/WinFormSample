Imports System.Windows.Forms
Imports WinFormSample.Control.ColorStatus
Imports System.ComponentModel

Public Class VmColorGridView

    Private _original As IList(Of ProductWithColor)
    Private _editing As BindingList(Of ProductWithColor)
    Public ReadOnly Property Editing As BindingList(Of ProductWithColor)
        Get
            Return _editing
        End Get
    End Property


    Public Sub New()
        _original = ProductWithColor.CreateProductList()
        InitilalizeEditingList()
    End Sub

    Private Sub InitilalizeEditingList()
        'TODO: リストのディープコピーってこれでいいの？
        _editing = New BindingList(Of ProductWithColor)(_original.Select(Function(t) New ProductWithColor(t)).ToList())

    End Sub


    Public Sub Add()
        _editing.Add(New ProductWithColor())
    End Sub


    Public Sub Delete(index As Integer)
        Dim target As ProductWithColor = _editing.Item(index)
        If target.Status = EditStatus.Created Then
            _editing.RemoveAt(index)
        Else
            target.Status = EditStatus.Deleted
        End If
    End Sub


    Public Sub Reset()
        If MessageBox.Show("do you reset?", "", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            InitilalizeEditingList()
        End If
    End Sub

End Class
