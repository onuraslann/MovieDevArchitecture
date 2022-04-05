using Movies.Core.DataAccess;
using Movies.Core.Entities.Concrete;
using Movies.Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Business.Services.Abstract
{
    public interface IUserService:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
   
         User GetByMail(string email);
     
    }
}
