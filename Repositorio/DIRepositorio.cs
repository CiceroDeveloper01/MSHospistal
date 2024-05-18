using Microsoft.Extensions.DependencyInjection;
using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;
using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteRepositorio;

public static class DIRepositorio
{
    public static IServiceCollection AddDIRepositorio(this IServiceCollection services)
    {
        services.AddScoped<IRepositorio<UsuarioDominio>, Repositorio<UsuarioDominio>>();
        services.AddScoped<IRepositorioUsuario, UsuarioRepositorio>();
        return services;
    }
}