using MSCadastroMedicoPacienteShared.Comandos.Interfaces;

namespace MSCadastroMedicoPacienteShared.Comandos.Dominio;

public class CriandoObjetoResultado : IComandoResultado
{
    public CriandoObjetoResultado(bool successo, string menssagem, object resultado)
    {
        Successo = successo;
        Menssagem = menssagem;
        Resultado = resultado;
    }
    public bool Successo { get; private set; }
    public string Menssagem { get; private set; }
    public object Resultado { get; private set; }
}