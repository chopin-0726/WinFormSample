Imports System.ComponentModel

Public Class VMMultiSelectList

#Region "property"

    Private _original As IList(Of Product)

    Public ReadOnly Property ProductList As IList(Of Product)
        Get
            Return _original
        End Get
    End Property



    Private _notSelected As BindingList(Of Product)
    Public ReadOnly Property NotSelected As BindingList(Of Product)
        Get
            Return _notSelected
        End Get
    End Property

    Private _selected As BindingList(Of Product)
    Public ReadOnly Property Selected As BindingList(Of Product)
        Get
            Return _selected
        End Get
    End Property

#End Region

    Public Sub New()
        _original = Product.CreateProductList()
        InitilalizeList()
    End Sub

    Private Sub InitilalizeList()
        _notSelected = New BindingList(Of Product)(_original.Select(Function(t) t.Clone()).ToList())
        _selected = New BindingList(Of Product)
    End Sub

    Public Sub MoveToSelected(ByVal target As Product)
        _selected.Add(target)
        _notSelected.Remove(target)
        'TODO: sort by id
    End Sub

    Public Sub MoveToNotSelected(ByVal target As Product)
        _notSelected.Add(target)
        _selected.Remove(target)
    End Sub
End Class
