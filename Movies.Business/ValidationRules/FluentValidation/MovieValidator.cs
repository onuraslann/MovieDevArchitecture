using FluentValidation;
using Movies.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Business.ValidationRules.FluentValidation
{
    public  class MovieValidator:AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(m => m.Name).MaximumLength(30);
            RuleFor(m => m.Year).GreaterThanOrEqualTo(1990);
        }
    }
}
