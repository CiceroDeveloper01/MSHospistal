using MSCadastroMedicoPacienteShared.Comandos.Interfaces;

namespace MSCadastroMedicoPacienteShared.Comandos.Dominio;

public class CriandoObjetoResultado : IComandoResultado
{
    public CriandoObjetoResultado(int codigoRetorno, bool successo, string menssagem, object resultado)
    {
        Successo = successo;
        Menssagem = menssagem;
        Resultado = resultado;
        CodigoRetorno = codigoRetorno;
    }
    public int CodigoRetorno  { get; private set; }
    public bool Successo { get; private set; }
    public string Menssagem { get; private set; }
    public object Resultado { get; private set; }
}