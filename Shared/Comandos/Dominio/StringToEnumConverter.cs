using AutoMapper;

namespace MSCadastroMedicoPacienteShared.Comandos.Dominio;

public class StringToEnumConverter<TEnum> : ITypeConverter<string, TEnum> where TEnum : struct
{
    public TEnum Convert(string source, TEnum destination, ResolutionContext context)
    {
        if (Enum.TryParse<TEnum>(source, true, out var result))
        {
            return result;
        }
        throw new ArgumentException($"Unable to convert '{source}' to enum {typeof(TEnum).Name}");
    }
}