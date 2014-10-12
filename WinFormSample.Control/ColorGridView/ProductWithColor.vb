Imports WinFormSample.Control.Product
Imports WinFormSample.Control.ColorStatus
Imports System.ComponentModel

''' <summary>
''' Product セル色変更対応版（ColorStatusの継承以外はProductと同じ）
''' </summary>
''' <remarks></remarks>
Public Class ProductWithColor
    Inherits ColorStatus

    Property Id As Integer
    Property Name As String
    Property Category1 As Category1Enum
    Property Category2 As Category2Enum

    Public Sub New()
        Category1 = Category1Enum.Other
        Category2 = Category2Enum.Other
        Status = EditStatus.Created
    End Sub

    Public Sub New(_id As Integer, _name As String, _c1 As Category1Enum, _c2 As Category2Enum)
        Id = _id
        Name = _name
        Category1 = _c1
        Category2 = _c2
        Status = EditStatus.None
    End Sub

    Public Sub New(ByVal source As ProductWithColor)
        MyBase.New(source)
        Id = source.Id
        Name = source.Name
        Category1 = source.Category1
        Category2 = source.Category2
    End Sub

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        'objがNothingか、型が違うときは、等価でない
        If (obj Is Nothing) OrElse (Not Me.GetType() Is obj.GetType()) Then
            Return False
        End If

        'ひかく
        Dim target As ProductWithColor = CType(obj, ProductWithColor)
        Return Me.Category1 = target.Category1 _
            And Me.Category2 = target.Category2 _
            And Me.Id = target.Id _
            And Me.Name.Equals(target.Name)

    End Function

    ''' <summary>
    ''' 商品リスト（普通はDBとかから取ってくるやつ）
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateProductList() As IList(Of ProductWithColor)
        Return New List(Of ProductWithColor)({ _
            New ProductWithColor(111, "comic 1", Category1Enum.Book, Category2Enum.Comic),
            New ProductWithColor(112, "comic 2", Category1Enum.Book, Category2Enum.Comic),
            New ProductWithColor(121, "novel 1", Category1Enum.Book, Category2Enum.Novel),
            New ProductWithColor(122, "novel 2", Category1Enum.Book, Category2Enum.Novel),
            New ProductWithColor(211, "note 1", Category1Enum.Stationary, Category2Enum.Note),
            New ProductWithColor(212, "note 2", Category1Enum.Stationary, Category2Enum.Note),
            New ProductWithColor(221, "pen 1", Category1Enum.Stationary, Category2Enum.Pen),
            New ProductWithColor(222, "pen 2", Category1Enum.Stationary, Category2Enum.Pen)
        })
    End Function
End Class


