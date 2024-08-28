using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs.Utils;

public class ExtensaoImagemValidaAttribute : ValidationAttribute
{
    private readonly string[] _formatosPermitidos = { ".png", ".jpg", ".jpeg" };

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return ValidationResult.Success;
        }

        var imagemString = value as string;

        if (!string.IsNullOrEmpty(imagemString))
        {
            if (_formatosPermitidos.Any(formato => imagemString.EndsWith(formato, StringComparison.OrdinalIgnoreCase)))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"Formatos permitidos: {string.Join(", ", _formatosPermitidos)}.");
            }
        }

        return ValidationResult.Success;
    }
}
