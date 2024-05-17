using Microsoft.Extensions.DependencyInjection;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos;
using MSCadastroMedicoPacienteServicos.Pacientes;
using MSCadastroMedicoPacienteServicos.Usuarios;

namespace MSCadastroMedicoPacienteServicos;

public static class DIServico
{
    public static IServiceCollection AddDIServico(this IServiceCollection services)
    {
        services.AddTransient<IServicoPaciente, PacienteServico>();
        services.AddTransient<IServicoMedico, MedicoServico>();
        services.AddTransient<IServicoUsuario, UsuarioServico>();
        return services;
    }
}