Public Class ViewModel

    Property SelectList As IList(Of User)
    Property SelectedList As IList(Of User)

    Public Sub New()
        SelectList = New List(Of User)({New User(1, "user1"), New User(2, "user2")})
        SelectedList = New List(Of User)
    End Sub

    Public Class User
        Property Name As String
        Property Id As Integer
        Public Sub New()

        End Sub
        Public Sub New(_id As Integer, _name As String)
            Id = _id
            Name = _name
        End Sub
    End Class
End Class
