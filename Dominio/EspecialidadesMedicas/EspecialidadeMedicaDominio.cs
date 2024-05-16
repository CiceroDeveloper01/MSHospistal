using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSCadastroMedicoPacienteDominio.EspecialidadesMedicas;

[Table("TB_EspecialidadeMedica")]
public class EspecialidadeMedicaDominio
{
    public EspecialidadeMedicaDominio(int iD, string descricaoEspecialidade)
    {
        ID = iD;
        DescricaoEspecialidade = descricaoEspecialidade;
    }

    public EspecialidadeMedicaDominio(string descricaoEspecialidade)
    {
        DescricaoEspecialidade = descricaoEspecialidade;
    }

    [Key]
    public int ID { get; private set; }
    [Required]
    [MaxLength(200)]
    public string DescricaoEspecialidade { get; private set; }
}