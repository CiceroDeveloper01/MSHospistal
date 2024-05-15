using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteDominio.InterfacesGenericas;

public interface IBaseDominioCRUD
{
    int ID { get; } 
    string Nome { get; }
    string Rg { get; }
    string Cpf { get; }
    DateTime DataAtualizacao { get; }
    DateTime DataCriacao { get; }
    UsuarioDominio UsuarioCriacao { get; }
    UsuarioDominio UsuarioAlteracao { get; }
}