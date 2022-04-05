using Microsoft.EntityFrameworkCore;
using Movies.Business.BusinessAspects;
using Movies.Business.Constants;
using Movies.Business.Services.Abstract;
using Movies.Business.ValidationRules.FluentValidation;
using Movies.Core.Aspects.Validation;
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
    [ValidationAspect(typeof(ActorValidator))]

    public class ActorManager : EfRepositoryBase<Actor,MovieContext>,IActorService
    {
   

    

        public ActorManager(MovieContext context) : base(context)
        {

        }

     

        public async Task<IDataResult<List<Actor>>> GetActors()
        {
           await base.GetList();
            await base.SaveChanges();
            return new SuccessDataResult<List<Actor>>();

        }

        public IEnumerable<Actor> GetAllActorsMovies()
        {
            var actorMovies = Context.Actors.Include(m => m.Movies).ToList();
            return actorMovies;
        }


    }
}
