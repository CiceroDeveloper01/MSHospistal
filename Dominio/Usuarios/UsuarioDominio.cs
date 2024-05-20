using MSCadastroMedicoPacienteDominio.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSCadastroMedicoPacienteDominio.Usuarios;

[Table("TB_Usuario")]
public class UsuarioDominio
{
    public int ID { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
    public string PerfilAcesso { get; private set; }
}