using FluentValidation;
using Movies.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Business.ValidationRules.FluentValidation
{
    public class GenreValidator:AbstractValidator<Genre>
    {
        public GenreValidator()
        {
            RuleFor(g => g.Name).MinimumLength(2);
        }
    }
}
