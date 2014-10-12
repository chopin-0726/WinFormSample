Imports WinFormSample.Control.Product
Imports System.ComponentModel

Public Class VMChainedComboBox
    'TODO: ReadOnly
    Property Category1 As BindingList(Of Category)

    Private _category2 As BindingList(Of Category)
    Public ReadOnly Property Category2 As BindingList(Of Category)
        Get
            _category2.Clear()
            For Each c As Category In _categoryList.Where(Function(t) t.Parent.Equals(Category1Selected)).ToList()
                _category2.Add(c)
            Next
            Return _category2
        End Get
    End Property

    Private _rawProductList As IList(Of Product)
    Private _productList As BindingList(Of Product)
    Public ReadOnly Property ProductList As BindingList(Of Product)
        Get
            If IsCategory2Changed() Then
                _productList = New BindingList(Of Product)(_rawProductList.Where(Function(t) t.Category2.Id = Category2Selected).ToList())
                Category2PrevValue = Category2Selected
            End If
            Return _productList
        End Get
    End Property


    'TODO: WriteOnly
    Property Category1Selected As Integer
    Property Category2Selected As Integer
    Property Category2PrevValue As Integer

    Private _categoryList As IList(Of Category)


    Public Sub New()
        _categoryList = CategoryList()
        Category1 = New BindingList(Of Category)(_categoryList.Where(Function(t) t.Level = 1).ToList())
        _category2 = New BindingList(Of Category)(_categoryList.Where(Function(t) t.Level = 2).ToList())
        _rawProductList = Product.CreateProductList()
        _productList = New BindingList(Of Product)

        If 0 < Category1.Count Then Category1Selected = Category1.Item(0).Id
        If 0 < Category2.Count Then
            Category2Selected = Category2.Item(0).Id
            Category2PrevValue = -1 '初期表示時にSearchResultを表示するため
        End If
    End Sub

    Public Function IsCategory2Changed() As Boolean
        Return Category2PrevValue <> Category2Selected
    End Function

End Class
