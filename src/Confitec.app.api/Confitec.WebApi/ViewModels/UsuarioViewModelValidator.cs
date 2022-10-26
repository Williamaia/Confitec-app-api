//using FluentValidation;
//using System;

//namespace Confitec.WebApi.ViewModels
//{
//    public class UsuarioViewModelValidator : AbstractValidator<UsuarioViewModel>
//    {
//        public UsuarioViewModelValidator()
//        {
//            RuleFor(x => x.Nome)
//                .NotEmpty().WithMessage("Informe o nome do usuário")
//                .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 caracteres e no máximo 100");

//            RuleFor(x => x.Email)
//                .NotEmpty().WithMessage("Informe o email do usuário")
//                .EmailAddress().WithMessage("Informe um email válido");

//            RuleFor(x => x.DataNascimento)
//                .NotEmpty().WithMessage("Informe a data de nascimento do usuário")
//                .Must(ValidaDataNascimento).WithMessage("A data de nascimento não pode ser igual a data atual");
//        }

//        private static bool ValidaDataNascimento(DateTime dataNascimento)
//        {
//            return dataNascimento < DateTime.Now;
//        }
//    }
//}
