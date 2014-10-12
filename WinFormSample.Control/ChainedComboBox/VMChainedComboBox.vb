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

    Private _productList As BindingList(Of Product)
    Public ReadOnly Property ProductList As BindingList(Of Product)
        Get
            Return New BindingList(Of Product)(_productList.Where(Function(t) t.Category2.Id = Category2Selected).ToList())
        End Get
    End Property


    'TODO: WriteOnly
    Property Category1Selected As Integer
    Property Category2Selected As Integer

    Private _categoryList As IList(Of Category)


    Public Sub New()
        _categoryList = CategoryList()
        Category1 = New BindingList(Of Category)(_categoryList.Where(Function(t) t.Level = 1).ToList())
        _category2 = New BindingList(Of Category)(_categoryList.Where(Function(t) t.Level = 2).ToList())
        _productList = New BindingList(Of Product)(Product.CreateProductList())
        Category1Selected = 0
        Category2Selected = 0
    End Sub


End Class
