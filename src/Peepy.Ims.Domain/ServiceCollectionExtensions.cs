using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peepy.Ims.Domain
{
    public class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceRegistry(this IServiceCollection services)
        => services.AddSingleton<IUserService>(provider => new UserService());
    }
}
