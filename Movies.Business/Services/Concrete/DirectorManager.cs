using Movies.Business.BusinessAspects;
using Movies.Business.Services.Abstract;
using Movies.Core.DataAccess.EntityFramework;
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
    //[SecuredOperation("admin,atolla")]
    public class DirectorManager : EfRepositoryBase<Director, MovieContext>, IDirectorService 
    {
        public DirectorManager(MovieContext context) : base(context)
        {

        }
    }
}
