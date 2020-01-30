using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Troy.Default;


namespace R5T.Troy.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ITemporaryDirectoryNameConvention"/> service.
        /// </summary>
        public static IServiceCollection AddTemporaryDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddDefaultTemporaryDirectoryNameConvention();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ITemporaryDirectoryNameConvention"/> service.
        /// </summary>
        public static ServiceAction<ITemporaryDirectoryNameConvention> AddTemporaryDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITemporaryDirectoryNameConvention>(() => services.AddTemporaryDirectoryNameConvention());
            return serviceAction;
        }
    }
}
