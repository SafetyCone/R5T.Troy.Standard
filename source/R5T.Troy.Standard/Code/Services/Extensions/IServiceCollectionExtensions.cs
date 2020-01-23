using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Troy.Default;


namespace R5T.Troy.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddTemporaryDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<ITemporaryDirectoryNameConvention, TemporaryDirectoryNameConvention>();

            return services;
        }
    }
}
