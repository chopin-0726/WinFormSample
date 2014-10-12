Public Class Product

    Property Id As Integer
    Property Name As String
    Property Category1 As Category1Enum
    Property Category2 As Category2Enum

    Public Sub New()
        Category1 = Category1Enum.Other
        Category2 = Category2Enum.Other
    End Sub

    Public Sub New(_id As Integer, _name As String, _c1 As Category1Enum, _c2 As Category2Enum)
        Id = _id
        Name = _name
        Category1 = _c1
        Category2 = _c2
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
    Public Shared Function CreateProductList() As IList(Of Product)
        Return New List(Of Product)({ _
            New Product(111, "comic 1", Category1Enum.Book, Category2Enum.Comic),
            New Product(112, "comic 2", Category1Enum.Book, Category2Enum.Comic),
            New Product(121, "novel 1", Category1Enum.Book, Category2Enum.Novel),
            New Product(122, "novel 2", Category1Enum.Book, Category2Enum.Novel),
            New Product(211, "note 1", Category1Enum.Stationary, Category2Enum.Note),
            New Product(212, "note 2", Category1Enum.Stationary, Category2Enum.Note),
            New Product(221, "pen 1", Category1Enum.Stationary, Category2Enum.Pen),
            New Product(222, "pen 2", Category1Enum.Stationary, Category2Enum.Pen)
        })
    End Function

#Region "Category"
    Public Enum Category1Enum
        Book
        Stationary
        Other
    End Enum
    Public Enum Category2Enum ' TODO: ほんとはカテゴリ１毎に分かれてるとよいのだけど
        Comic
        Novel
        Note
        Pen
        Other
    End Enum

#End Region


End Class
