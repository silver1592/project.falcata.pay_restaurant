using Falcata.PayRestaurant.Application.Reflection;
using Falcata.PayRestaurant.Persistence.Reflection;
using Microsoft.AspNetCore.Hosting;

namespace Falcata.PayRestaurant.DI;

public static class ContainerModules
{
    [ExcludeFromCodeCoverage]
    public static IWebHostBuilder ConfigureDependencies(IWebHostBuilder webHost)
    {
        webHost.ConfigureServices(services =>
        {
            services.RegisterMediatR(ApplicationAssemblyFinder.GetAssembly());
            services.RegisterPersistenceContainers(PersistenceAssemblyFinder.GetAssembly());
        });

        return webHost;
    }
}