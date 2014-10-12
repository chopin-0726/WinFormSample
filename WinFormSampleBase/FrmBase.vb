Imports WinFormSample.Control

Public Class FrmBase

    Property CtlNameDic As IList(Of String) =
        New List(Of String)({"CtlDefault", "CtlDefault2"})
    Private SelectedCtl As String
    Private _currentCtl As Windows.Forms.Control

    Private Sub BaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:コントロールの切り替え

        '_currentCtl = New CtlDefault
        _currentCtl = New CtlColorGridView
        MainPanel.Controls.Add(_currentCtl)
        MainPanel.Show()
    End Sub

    Private Sub ComboBoxControlName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxControlName.SelectedIndexChanged
        Dim prevCtl As Windows.Forms.Control
        If SelectedCtl.Equals("CtlDefault") Then
            prevCtl = _currentCtl
            _currentCtl = New CtlDefault
            MainPanel.Controls.Add(_currentCtl)
            MainPanel.Controls.Remove(prevCtl)
            MainPanel.Show()
            prevCtl.Dispose()
        ElseIf SelectedCtl.Equals("CtlDefault2") Then
            prevCtl = _currentCtl
            _currentCtl = New CtlDefault2
            MainPanel.Controls.Add(_currentCtl)
            MainPanel.Controls.Remove(prevCtl)
            MainPanel.Show()
            prevCtl.Dispose()
        End If
    End Sub
End Class
