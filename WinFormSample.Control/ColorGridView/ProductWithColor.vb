Imports WinFormSample.Control.Product

''' <summary>
''' Product拡張 Product＋ColorStatus＋Checked
''' （本当はProductがColorStatusを継承 ＋ 
'''   画面用のエンティティはそれを継承 or 別のエンティティとして定義する　等にするべき）
''' </summary>
''' <remarks></remarks>
Public Class ProductWithColor
    Inherits ColorStatus

    Property Id As Integer
    Property Name As String
    Property Category1 As Category
    Property Category2 As Category
    Property Category1Id As Integer
    Property Category2Id As Integer

    Property IsSubmitTarget As Boolean

    Public Sub New()
        Category1 = GetCategory(9)
        Category2 = GetCategory(99)
        Status = EditStatus.Created
        IsSubmitTarget = False
        Category1Id = Category1.Id
        Category2Id = Category2.Id
    End Sub

    Public Sub New(_id As Integer, _name As String, _c1 As Category, _c2 As Category)
        Id = _id
        Name = _name
        Category1 = _c1
        Category2 = _c2
        Status = EditStatus.None
        IsSubmitTarget = False
        Category1Id = Category1.Id
        Category2Id = Category2.Id
    End Sub

    Public Function Clone() As ProductWithColor
        Return New ProductWithColor(Me.Id, Me.Name, Me.Category1, Me.Category2)
    End Function

    Public Sub Copy(ByRef dest As ProductWithColor)
        dest.Id = Me.Id
        dest.Name = Me.Name
        dest.Category1 = Me.Category1.Clone()
        dest.Category2 = Me.Category2.Clone()
        dest.Status = EditStatus.None
        dest.IsSubmitTarget = False
        Category1Id = Category1.Id
        Category2Id = Category2.Id
    End Sub

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        'objがNothingか、型が違うときは、等価でない
        If (obj Is Nothing) OrElse (Not Me.GetType() Is obj.GetType()) Then Return False

        'ひかく
        Dim target As ProductWithColor = CType(obj, ProductWithColor)
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
    Public Shared Function CreateProductList() As IList(Of ProductWithColor)
        Return New List(Of ProductWithColor)({ _
            New ProductWithColor(111, "comic 1", GetCategory(1), GetCategory(11)),
            New ProductWithColor(112, "comic 2", GetCategory(1), GetCategory(11)),
            New ProductWithColor(121, "novel 1", GetCategory(1), GetCategory(12)),
            New ProductWithColor(122, "novel 2", GetCategory(1), GetCategory(12)),
            New ProductWithColor(211, "note 1", GetCategory(2), GetCategory(21)),
            New ProductWithColor(212, "note 2", GetCategory(2), GetCategory(21)),
            New ProductWithColor(221, "pen 1", GetCategory(2), GetCategory(22)),
            New ProductWithColor(222, "pen 2", GetCategory(2), GetCategory(22))
        })
    End Function

End Class
