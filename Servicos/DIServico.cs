using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos.Medicos;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos.Pacientes;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos.Usuarios;
using MSCadastroMedicoPacienteDominio.Usuarios;
using MSCadastroMedicoPacienteServicos.Pacientes;
using MSCadastroMedicoPacienteServicos.Usuarios;
using MSCadastroMedicoPacienteServicos.Usuarios.Validadores;

namespace MSCadastroMedicoPacienteServicos;

public static class DIServico
{
    public static IServiceCollection AddDIServico(this IServiceCollection services)
    {
        services.AddTransient<IServicoPaciente, PacienteServico>();
        services.AddTransient<IServicoMedico, MedicoServico>();
        services.AddTransient<IServicoUsuarioAutenticacao, UsuarioAutenticacaoServico>();
        return services;
    }

    public static IServiceCollection AddDIValidacao(this IServiceCollection services)
    {
        services.AddTransient<IValidator<UsuarioRequisicaoAutenticacao>, UsuarioValidarAutenticacao>();
        return services;
    }
}