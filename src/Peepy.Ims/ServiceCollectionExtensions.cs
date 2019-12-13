using Microsoft.Extensions.DependencyInjection;
using Peepy.Ims.Application;
using Peepy.Ims.Domain;

namespace Peepy.Ims
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceRegistry(this IServiceCollection services)
        => services.AddSingleton<IUserService>(provider => new UserService());
    }
}
