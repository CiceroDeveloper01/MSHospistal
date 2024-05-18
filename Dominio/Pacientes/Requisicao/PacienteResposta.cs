using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteDominio.Pacientes.Requisicao;

public class PacienteResposta
{
    public int ID { get; private set; }
    public string Nome { get; private set; }
    public string Rg { get; private set; }
    public string Cpf { get; private set; }
    public DateTime DataAtualizacao { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public UsuarioDominio UsuarioCriacao { get; private set; }
    public UsuarioDominio UsuarioAlteracao { get; private set; }
}