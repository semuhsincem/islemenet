using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ViewModels.Login;

namespace MvcWebUI.Validators
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(x => x.CompanyName)
                .NotEmpty();

            RuleFor(x => x.State)
                .NotEmpty();
            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .MinimumLength(11)
                .MaximumLength(11);

            RuleFor(x => x.City)
               .NotEmpty();

            RuleFor(x => x.Region)
               .NotEmpty();
            RuleFor(x => x.Street)
                .NotEmpty();

            RuleFor(x => x.FirstName)
              .NotEmpty();

            RuleFor(x => x.LastName)
              .NotEmpty();

            RuleFor(x => x.Email)
                .EmailAddress()
              .NotEmpty();

            RuleFor(x => x.Password)
              .EmailAddress()
            .NotEmpty();

            RuleFor(x => x.RePassword)
              .Equal(x => x.Password)
            .NotEmpty();

            RuleFor(x => x.IsCheckTheContract)
             .Must(x => true);

            RuleFor(x => x.TIN)
            .GreaterThan(0);

            RuleFor(x => x.YearOfEstablishment)
             .GreaterThan(0);

            RuleFor(x => x.CompanySize)
              .GreaterThan(0);
    
            RuleFor(x => x.WebSiteUrl)
              .NotEmpty();

            RuleFor(x => x.MaterialsYourCompanyProcesses)
             .NotEmpty();

            RuleFor(x => x.TechnologiesYourCompanyUses)
            .NotEmpty();

            RuleFor(x => x.IndustriesYourCompanySuppliesTo)
            .NotEmpty();

            RuleFor(x => x.MyCertifications)
            .NotEmpty();

        }

    }
}
