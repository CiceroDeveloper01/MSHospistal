using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteDominio.Interfaces.Generica;

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