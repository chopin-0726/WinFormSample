Public Class ColorStatus

    ''' <summary>
    ''' 色変更を行うエンティティの基底クラス
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ColorStatus
        Public Property ColorStatus As EditStatus = EditStatus.None
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
End Class
