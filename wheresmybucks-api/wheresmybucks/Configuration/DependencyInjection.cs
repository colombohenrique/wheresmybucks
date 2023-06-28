using Application.Services.Interfaces;
using Application.Services;

namespace wheresmybucks.Configuration
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpClient();

            services.AddScoped<IUserService, UserService>();

        }
    }
}
