using Movies.Business.Constants;
using Movies.Business.Services.Abstract;
using Movies.Business.ValidationRules.FluentValidation;
using Movies.Core.Aspects.Caching;
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
    public class GenreManager : EfRepositoryBase<Genre, MovieContext>, IGenreService
    {

        public GenreManager(MovieContext context) : base(context)
        {

        }
        public IDataResult<Genre> TransactionalTest(Genre genre)
        {
            base.Update(genre);
            base.Add(genre);
            
            base.saveChanges();
            return new SuccessDataResult<Genre>(genre);
        }

       
    }
}
