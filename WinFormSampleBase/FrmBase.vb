Imports WinFormSample.Control

Public Class FrmBase


    'Property CtlNameList As IList(Of String) = New List(Of String)({"ChainedComboBox", "ColorGridView", "MultiSelectList"})

    'Private SelectedCtl As String
    'Private _currentCtl As Windows.Forms.Control

    Private _viewModel As VMFrmBase

    Private Sub BaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _viewModel = New VMFrmBase(Me.MainPanel)

        ' コンボボックスにバインドしてない（けど普段Stringとバインドとかしないし）
        ComboBoxControlName.Items.AddRange(_viewModel.CtlNameList.ToArray())
        ComboBoxControlName.SelectedItem = _viewModel.CtlNameList.Item(0)
    End Sub

    Private Sub ComboBoxControlName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxControlName.SelectedIndexChanged
        _viewModel.SelectedCtl = CType(sender, ComboBox).SelectedItem.ToString()
        _viewModel.SelectedIndexChanged()
    End Sub
End Class
