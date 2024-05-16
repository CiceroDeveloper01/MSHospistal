namespace MSCadastroMedicoPacienteShared.Comandos.Interfaces;

public interface IComandoResultado
{
    bool Successo { get; }
    string Menssagem { get; }
    object Resultado { get;  }
}