using Final.Feature.Components.Controllers;
using Final.Feature.Components.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Final.Feature.Components.DI
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(ISearchResultRepository), typeof(SearchResultRepository));
            serviceCollection.AddTransient(typeof(SearchResultController), typeof(SearchResultController));
        }
    }
}