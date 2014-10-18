Imports WinFormSample.Control

Public Class VMFrmBase

    Property CtlNameList As IList(Of String) = New List(Of String)({"ColorGridView", "ChainedComboBox", "MultiSelectList"})
    Property SelectedCtl As String
    Private _currentCtl As Windows.Forms.Control
    Private _mainPanel As Panel

    Public Sub New(mainPanel As Panel)
        _mainPanel = mainPanel
    End Sub

    Public Sub SelectedIndexChanged()
        '良いやり方ないのかな
        Select Case SelectedCtl
            Case "ColorGridView" : ChangeControl(Of CtlColorGridView)()
            Case "ChainedComboBox" : ChangeControl(Of CtlChainedComboBox)()
            Case "MultiSelectList" : ChangeControl(Of CtlMultiSelectList)()
        End Select
    End Sub

    ''' <summary>
    ''' メイン部分を入れ替え
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <remarks></remarks>
    Private Sub ChangeControl(Of T As {UserControl, New})()
        Dim nextCtl As Windows.Forms.Control
        nextCtl = New T()
        _mainPanel.Controls.Add(nextCtl)
        _mainPanel.Controls.Remove(_currentCtl)
        _mainPanel.Show()
        If Not _currentCtl Is Nothing Then
            _currentCtl.Dispose()
        End If
        _currentCtl = nextCtl
    End Sub
End Class
