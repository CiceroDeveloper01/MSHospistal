using AutoMapper;
using MSCadastroMedicoPacienteDominio.Usuarios.Resposta;

namespace MSCadastroMedicoPacienteDominio.Usuarios.Mapeador;

public static class UsuarioMapeadorResposta
{
    private static MapperConfiguration MCTRespostaAutenticacao;
    private static IMapper MPTRespostaAutenticacao;

    private static void ConfigurarMapeadorParaUsuarioAutorizacaoResposta()
    {
        MCTRespostaAutenticacao = new MapperConfiguration(cfg => cfg.CreateMap<UsuarioDominio, UsuarioRespostaAutenticacao>());

        MPTRespostaAutenticacao = MCTRespostaAutenticacao.CreateMapper();
    }

    public static UsuarioRespostaAutenticacao UsuarioDominioParaUsuarioAutenticacao(this UsuarioDominio usuarioDominio)
    {
        if (MCTRespostaAutenticacao == null)
            ConfigurarMapeadorParaUsuarioAutorizacaoResposta();
        
        return MPTRespostaAutenticacao.Map<UsuarioDominio, UsuarioRespostaAutenticacao>(usuarioDominio);
    }
}