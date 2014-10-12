Imports System.Windows.Forms
Imports WinFormSample.Control.ColorStatus
Imports System.ComponentModel

Public Class VmColorGridView

    Private _editing As ProdctListForBind
    Public ReadOnly Property Editing As ProdctListForBind
        Get
            Return _editing
        End Get
    End Property


    Public Sub New()
        '_editing = ProductWithColor.CreateProductList
        _editing = New ProdctListForBind()
        _editing.LoadProductWithColors(ProductWithColor.CreateProductList())
    End Sub


    Public Sub Add()
        _editing.Add(New ProductWithColor())
    End Sub


    Public Sub Delete(index As Integer)
        Dim target As ProductWithColor = _editing.Item(index)
        If target.Status = EditStatus.Created Then
            _editing.RemoveAt(index)
        Else
            target.Status = EditStatus.Deleted
        End If
    End Sub


    Public Sub Reset()
        If MessageBox.Show("do you reset?", "", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            _editing.LoadProductWithColors(ProductWithColor.CreateProductList())
        End If
    End Sub

#Region "BindingList"
    Public Class ProdctListForBind
        Inherits BindingList(Of ProductWithColor)

        Public Sub LoadProductWithColors(ByVal list As IList(Of ProductWithColor))
            Dim l As IList = CType(Me, IList)
            l.Clear()
            For Each Item As ProductWithColor In list
                l.Add(Item)
            Next
        End Sub
    End Class
#End Region

End Class
