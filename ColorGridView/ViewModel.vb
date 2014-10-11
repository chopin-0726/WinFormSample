Public Class ViewModel


    Private _editing As IList(Of User)
    Public ReadOnly Property Editing As IList(Of User)
        Get
            Return New List(Of User)(_editing)
        End Get
    End Property


    Public Sub New()
        _editing = New List(Of User)({New User(1, "user1"), New User(2, "user2")})
    End Sub


    Public Sub Add()
        _editing.Add(New User())
    End Sub


    Public Sub Delete(index As Integer)
        Dim target As User = _editing.Item(index)
        'If target.EditStatus = EditType.Created Then
        '    _editing.RemoveAt(index)
        'Else
        '    target.EditStatus = EditType.Deleted
        'End If
    End Sub


    Public Sub Reset()
        'TODO: get message
        If MessageBox.Show("tmp: reset?", "", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            'reset editing
        End If
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
