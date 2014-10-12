Imports System.Windows.Forms
Imports WinFormSample.Control.ColorStatus

Public Class VmColorGridView


    Private _editing As IList(Of ProductWithColor)
    Public ReadOnly Property Editing As IList(Of ProductWithColor)
        Get
            Return _editing
        End Get
    End Property


    Public Sub New()
        _editing = ProductWithColor.CreateProductList
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
            _editing = ProductWithColor.CreateProductList()
        End If
    End Sub

End Class
