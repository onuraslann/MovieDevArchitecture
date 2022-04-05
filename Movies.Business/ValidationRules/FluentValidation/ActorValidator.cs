using FluentValidation;
using Movies.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Business.ValidationRules.FluentValidation
{
    public class ActorValidator:AbstractValidator<Actor>
    {
        public ActorValidator()
        {
            RuleFor(a => a.Name).NotEmpty();
            RuleFor(a => a.Surname).MaximumLength(2);
        }
    }
}
