using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Confitec.WebApi.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Escolaridade { get; set; }
    }

    public class UsuarioViewModelValidator : AbstractValidator<UsuarioViewModel>
    {
        public UsuarioViewModelValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe o nome do usuário")
                .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 caracteres e no máximo 100");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Informe o email do usuário")
                .EmailAddress().WithMessage("Informe um email válido");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().WithMessage("Informe a data de nascimento do usuário")
                .Must(ValidaDataNascimento).WithMessage("A data de nascimento não pode ser igual a data atual");
        }

        private static bool ValidaDataNascimento(DateTime dataNascimento)
        {
            return dataNascimento < DateTime.Now;
        }
    }
}
