using Movies.Core.DataAccess;
using Movies.Core.Utilities.Result;
using Movies.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Business.Services.Abstract
{
    public interface IGenreService: IEntityRepository<Genre>
    {
    
       

        IDataResult<Genre> TransactionalTest(Genre genre);


    }
}
