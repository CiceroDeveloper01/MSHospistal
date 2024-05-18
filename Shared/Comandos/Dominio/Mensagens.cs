namespace MSCadastroMedicoPacienteShared.Comandos.Dominio;

public class Mensagens
{
    private Mensagens(string value) { Value = value; }
    public static string NomeCampo { get => "{NomeCampo}"; }
    public static string QuantidadeCampo { get => "{QuantidadeCampo}"; }
    public string Value { get; set; }
    public static Mensagens Autenticacao { get { return new Mensagens($"A {NomeCampo} autenticação foi efetuada com sucesso"); } }
    public static Mensagens AutenticacaoInvalida { get { return new Mensagens($"A {NomeCampo} não foi possível efetuar a autenticação, por favor, verificar"); } }
    public static Mensagens EmailInvalido {  get {  return new Mensagens($"O {NomeCampo} é inválido, por favor, informar um válido"); } }
    public static Mensagens InformacacoesJaCadastradas { get { return new Mensagens($"O {NomeCampo} já foi cadastrado, por favor, informar um outro valor"); } }
    public static Mensagens InformacacoesNaoCadastradas { get { return new Mensagens($"O {NomeCampo} não foi localizado, por favor, informar um outro valor"); } }
    public static Mensagens CNPJCPJFInvalidos { get { return new Mensagens($"O campo {NomeCampo} está inválido, por favor, corrigir"); } }
    public static Mensagens CampoObrigatorioNaoPreenchido { get { return new Mensagens($"O campo {NomeCampo} é obrigatório, por favor, preencher"); } }
    public static Mensagens CadastroEfetuadoComSucesso { get { return new Mensagens($"O {NomeCampo} foi cadastrado com sucesso."); } }
    public static Mensagens CadastroNaoEfetuadoComSucesso { get { return new Mensagens($"O {NomeCampo} não foi cadastrado com sucesso, por favor, verificar as mensagens de erro"); } }
    public static Mensagens BuscaEmServicosExternosSemSucesso { get { return new Mensagens($"O {NomeCampo} não foi localizado com sucesso, por favor, verificar as mensagens de erro"); } }
    public static Mensagens BuscaEmServicosExternosComSucesso { get { return new Mensagens($"O {NomeCampo} foi localizado com sucesso"); } }
    public static Mensagens AtualizacaoEfetuadoComSucesso { get { return new Mensagens($"O {NomeCampo} foi atualizada com sucesso."); } }
    public static Mensagens AtualizacaoNaoEfetuadoComSucesso { get { return new Mensagens($"O {NomeCampo} não foi atualizada com sucesso, por favor, verificar as mensagens de erro"); } }
    public static Mensagens ExclusaoEfetuadoComSucesso { get { return new Mensagens($"O {NomeCampo} foi atualizada com sucesso."); } }
    public static Mensagens ExclusaoNaoEfetuadoComSucesso { get { return new Mensagens($"O {NomeCampo} não foi atualizada com sucesso, por favor, verificar as mensagens de erro"); } }
    public static Mensagens RegistroNaoEncontrado { get { return new Mensagens($"O registro com o código {NomeCampo} não foi localizado"); } }
    public static Mensagens StatusBuscaInSucesso { get { return new Mensagens($"Busca Não Efetuada Com Sucesso"); } }
    public static Mensagens StatusBuscaSucesso { get { return new Mensagens($"Busca Efetuada Com Sucesso"); } }
    public static Mensagens MensagemLogInicioMetodo { get { return new Mensagens($"Iniciando o Método:"); } }
    public static Mensagens MensagemLogFinalizandoMetodo { get { return new Mensagens($"Iniciando o Método:"); } }
    public static Mensagens MensagemErroInesperado { get { return new Mensagens($"Houve um erro interno que é impossível seguir o processo:"); } }
}
