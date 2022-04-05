using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Movies.Core.CrossCuttingConcerns.Caching;
using Movies.Core.CrossCuttingConcerns.Caching.Microsoft;
using Movies.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
