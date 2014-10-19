Imports FluentValidation

Public Class ProductWithColorValidator
    Inherits AbstractValidator(Of ProductWithColor)

    Public Sub New()
        RuleFor(Function(dto) dto.Name).NotEmpty().Length(1, 10)
        RuleFor(Function(dto) dto.Category1).NotEmpty()
        RuleFor(Function(dto) dto.Id).GreaterThan(100)
    End Sub

End Class
