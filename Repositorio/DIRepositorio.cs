using Microsoft.Extensions.DependencyInjection;
using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;

namespace MSCadastroMedicoPacienteRepositorio;

public static class DIRepositorio
{
    public static IServiceCollection AddDIRepositorio(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));
        services.AddScoped<IRepositorioUsuario, UsuarioRepositorio>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}