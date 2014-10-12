Public Class Product

    Property Id As Integer
    Property Name As String
    Property Category1 As Category
    Property Category2 As Category

    Public Sub New()
        Category1 = GetCategory(9)
        Category2 = GetCategory(99)
    End Sub

    Public Sub New(_id As Integer, _name As String, _c1 As Category, _c2 As Category)
        Id = _id
        Name = _name
        Category1 = _c1
        Category2 = _c2
    End Sub

    Public Function Clone() As Product
        Return New Product(Me.Id, Me.Name, Me.Category1, Me.Category2)
    End Function

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        'objがNothingか、型が違うときは、等価でない
        If (obj Is Nothing) OrElse (Not Me.GetType() Is obj.GetType()) Then Return False

        'ひかく
        Dim target As Product = CType(obj, Product)
        Return Me.Category1.Equals(target.Category1) _
            And Me.Category2.Equals(target.Category2) _
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
            New Product(111, "comic 1", GetCategory(1), GetCategory(11)),
            New Product(112, "comic 2", GetCategory(1), GetCategory(11)),
            New Product(121, "novel 1", GetCategory(1), GetCategory(12)),
            New Product(122, "novel 2", GetCategory(1), GetCategory(12)),
            New Product(211, "note 1", GetCategory(2), GetCategory(21)),
            New Product(212, "note 2", GetCategory(2), GetCategory(21)),
            New Product(221, "pen 1", GetCategory(2), GetCategory(22)),
            New Product(222, "pen 2", GetCategory(2), GetCategory(22))
        })
    End Function

#Region "Category"
    ''' <summary>
    ''' カテゴリリスト（これも普通はDBとかから取ってくるやつ）
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Property CategoryList As IList(Of Category) =
        New List(Of Category)({ _
            New Category(1, "Book", 1, Nothing),
            New Category(2, "Stationary", 1, Nothing),
            New Category(11, "Comic", 2, 1),
            New Category(12, "Novel", 2, 1),
            New Category(21, "Note", 2, 2),
            New Category(22, "Pen", 2, 2),
            New Category(9, "Other", 1, Nothing),
            New Category(99, "Other", 2, 9) _
        })

    Shared Function GetCategory(ByVal id As Integer) As Category
        'TODO: Min...?
        Return CategoryList.Where(Function(t) t.Id = id).Min()
    End Function

    Public Class Category
        Property Id As Integer
        Property Name As String
        Property Level As Integer 'カテゴリ階層
        Property Parent As Nullable(Of Integer) '親カテゴリID

        Public Sub New(ByVal _id As Integer, ByVal _name As String, ByVal _level As Integer, ByVal _parent As Nullable(Of Integer))
            Id = _id
            Name = _name
            Level = _level
            Parent = _parent
        End Sub

        Public Function Clone() As Category
            Return New Category(Me.Id, Me.Name, Me.Level, Me.Parent)
        End Function

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            'objがNothingか、型が違うときは、等価でない
            If (obj Is Nothing) OrElse (Not Me.GetType() Is obj.GetType()) Then Return False

            'ひかく
            Dim target As Category = CType(obj, Category)
            Return Me.Id = target.Id _
                And Me.Level.Equals(target.Level) _
                And Me.Parent.Equals(target.Parent) _
                And Me.Name.Equals(target.Name)
        End Function

        'TODO : ToString()がDataGridViewのテキスト表示に使われている件
        Public Overrides Function ToString() As String
            Return Name
        End Function

    End Class

    ' TODO: ↓ごみ
    Public Enum Category1Enum
        Book
        Stationary
        Other
    End Enum
    Public Enum Category2Enum
        Comic
        Novel
        Note
        Pen
        Other
    End Enum

#End Region


End Class
