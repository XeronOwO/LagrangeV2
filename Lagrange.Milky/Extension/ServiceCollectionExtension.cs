using Microsoft.Extensions.DependencyInjection;

namespace Lagrange.Milky.Extension;

public static partial class ServiceCollectionExtension
{
    public static partial TServiceCollection AddApiHandlers<TServiceCollection>(this TServiceCollection services) where TServiceCollection : IServiceCollection;
}