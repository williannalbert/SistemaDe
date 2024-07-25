using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs.Utils;

public class CpfAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("O CPF é obrigatório.");
        }

        string cpf = value.ToString();

        if (string.IsNullOrEmpty(cpf))
        {
            return new ValidationResult("O CPF é obrigatório.");
        }

        if (!IsCpfValid(cpf))
        {
            return new ValidationResult("O CPF informado é inválido.");
        }

        return ValidationResult.Success;
    }

    private bool IsCpfValid(string cpf)
    {
        cpf = new string(cpf.Where(char.IsDigit).ToArray());

        if (cpf.Length != 11)
        {
            return false;
        }

        if (cpf.All(c => c == cpf[0]))
        {
            return false;
        }

        int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        string tempCpf = cpf.Substring(0, 9);
        int soma = 0;

        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
        }

        int resto = soma % 11;
        if (resto < 2)
        {
            resto = 0;
        }
        else
        {
            resto = 11 - resto;
        }

        string digito = resto.ToString();
        tempCpf += digito;

        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
        }

        resto = soma % 11;
        if (resto < 2)
        {
            resto = 0;
        }
        else
        {
            resto = 11 - resto;
        }

        digito += resto.ToString();

        return cpf.EndsWith(digito);
    }
}
