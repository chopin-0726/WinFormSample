Public Class CtlChainedComboBox
    Private _viewModel As VMChainedComboBox

    Public Sub New()
        InitializeComponent()
        _viewModel = New VMChainedComboBox()
        Categroy1BindingSource.DataSource = _viewModel.Category1
        Category2BindingSource.DataSource = _viewModel.Category2
        SearchResultBindingSource.DataSource = _viewModel.ProductList
        ViewModelBindingSource.DataSource = _viewModel
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Category2BindingSource.DataSource = _viewModel.Category2
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        SearchResultBindingSource.DataSource = _viewModel.ProductList
    End Sub
End Class
