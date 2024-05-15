using MSCadastroMedicoPacienteDominio.InterfacesGenericas;
using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteDominio.Pacientes;

public class PacienteDominio : IBaseDominioCRUD
{
    public PacienteDominio(int id, string nome, string rg, string cpf, UsuarioDominio usuarioCriacao, UsuarioDominio usuarioAlteracao)
    {
        ID = id;
        Nome = nome;
        Cpf = cpf;
        UsuarioCriacao = usuarioCriacao;
        UsuarioAlteracao = usuarioAlteracao;
        DataAtualizacao = DateTime.Now;
        DataCriacao = DateTime.Now; 
    }

    public int ID { get ; private  set; }
    public string Nome { get ; private  set; }
    public string Rg { get ; private  set; }
    public string Cpf { get ; private  set; }
    public DateTime DataAtualizacao { get ; private  set; }
    public DateTime DataCriacao { get ; private  set; }
    public UsuarioDominio UsuarioCriacao { get ; private  set; }
    public UsuarioDominio UsuarioAlteracao { get ; private set ; }
}
