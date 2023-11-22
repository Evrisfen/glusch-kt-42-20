using gluschKt_42_20.Interfaces.StudentsInterface;
using System.Runtime.CompilerServices;

namespace gluschKt_42_20.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}
