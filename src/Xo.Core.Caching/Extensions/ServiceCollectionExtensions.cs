namespace Xo.Core.Cachine.Extensions;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddCachingServices(this IServiceCollection @this,
        IConfiguration configuration
    )
    {
        @this.TryAddSingleton<ICache, Cache>();
        return @this;
    }
}
