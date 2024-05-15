using MSCadastroMedicoPacienteDominio.Enum;

namespace MSCadastroMedicoPacienteDominio.Usuarios;

public class UsuarioDominio
{
    public int ID { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
    public EPerfilAcesso PerfilAcesso { get; private set; }
}