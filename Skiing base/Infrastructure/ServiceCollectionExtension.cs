using Application.Entities.Visitor;


namespace Domain.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddSkiingBaseCollection(this IServiceCollection services)
        {
            services.AddTransient<IVisitorsService, VisitorsService>();
            
            return services;
        }
    }
}
