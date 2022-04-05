using Movies.Business.Services.Abstract;
using Movies.Business.ValidationRules.FluentValidation;
using Movies.Core.Aspects.Validation;
using Movies.Core.DataAccess.EntityFramework;
using Movies.Core.Utilities.Business;
using Movies.Core.Utilities.Result;
using Movies.DataAccess.Concrete.EntityFramework;
using Movies.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Business.Services.Concrete
{
    public class MovieManager : EfRepositoryBase<Movie, MovieContext>,IMovieService
    {
        public MovieManager(MovieContext context) : base(context)
        {

        }
    }
}
