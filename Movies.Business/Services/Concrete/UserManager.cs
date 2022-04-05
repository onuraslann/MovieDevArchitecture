using Movies.Business.Services.Abstract;
using Movies.Core.DataAccess.EntityFramework;
using Movies.Core.Entities.Concrete;
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
    public class UserManager : EfRepositoryBase<User, MovieContext>, IUserService
    {
        public UserManager(MovieContext context) : base(context)
        {

        }



        public User GetByMail(string email)
        {
            return base.Get(x => x.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            var result = from operationClaim in Context.OperationClaims
                         join userOperationClaim in Context.UserOperationClaims
                   on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();
        }
    
    }
}
