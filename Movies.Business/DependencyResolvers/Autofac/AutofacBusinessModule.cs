using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Movies.Business.Services.Abstract;
using Movies.Business.Services.Concrete;
using Movies.Core.Utilities.Interceptors;
using Movies.Core.Utilities.Security.JWT;
using Movies.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Business.DependencyResolvers.Autofac
{
    public  class AutofacBusinessModule:Module
    {
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ActorManager>().As<IActorService>().SingleInstance();
           
            builder.RegisterType<DirectorManager>().As<IDirectorService>().SingleInstance();
           
            builder.RegisterType<GenreManager>().As<IGenreService>().SingleInstance();
         
            builder.RegisterType<MovieManager>().As<IMovieService>().SingleInstance();
           
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
           
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
