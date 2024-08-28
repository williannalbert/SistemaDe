using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs.Utils;

public class MaioridadeAttribute : ValidationAttribute
{
    private readonly int _idadeMinima;
    private readonly int _idadeMaxima;

    public MaioridadeAttribute(int idadeMinima = 18, int idadeMaxima = 100)
    {
        _idadeMinima = idadeMinima;
        _idadeMaxima = idadeMaxima;
    }
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return ValidationResult.Success; 
        }

        if (value is DateTime dataNascimento)
        {
            var idade = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento > DateTime.Today.AddYears(-idade))
            {
                idade--;
            }

            if (idade < _idadeMinima)
            {
                return new ValidationResult($"A idade mínima é {_idadeMinima} anos.");
            }

            if (idade > _idadeMaxima)
            {
                return new ValidationResult($"Data de nascimento inválida.");
            }

        }
        else
        {
            return new ValidationResult("Data de nascimento inválida.");
        }

        return ValidationResult.Success;
    }
}
