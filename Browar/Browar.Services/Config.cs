using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Browar.Repositories;
using Browar.Repositories.Interfaces;
using Browar.Repositories.Repositories;

namespace Browar.Services
{
    public static class Config
    {
        public static void Configure(IConfiguration configuration, IServiceCollection services)
        {
            var config = new Browar.Repositories.Config(configuration);
            config.PartOfConfigureServices(services);

            services.AddTransient<IBeerRepository, BeerRepository>(); //każde repo tak trzeba
        }
    }
}
