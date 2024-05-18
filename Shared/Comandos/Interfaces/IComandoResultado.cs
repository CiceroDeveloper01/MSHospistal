namespace MSCadastroMedicoPacienteShared.Comandos.Interfaces;

public interface IComandoResultado
{
    int CodigoRetorno { get; }
    bool Successo { get; }
    string Menssagem { get; }
    object Resultado { get;  }
}