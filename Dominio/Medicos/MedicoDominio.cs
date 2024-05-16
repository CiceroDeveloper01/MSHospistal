using MSCadastroMedicoPacienteDominio.EspecialidadesMedicas;
using MSCadastroMedicoPacienteDominio.Interfaces.Generica;
using MSCadastroMedicoPacienteDominio.Usuarios;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSCadastroMedicoPacienteDominio.Medicos;

[Table("TB_Medicos")]
public class MedicoDominio : IBaseDominioCRUD
{
    public MedicoDominio(string nome, string rg, string cpf, UsuarioDominio usuarioCriacao, UsuarioDominio usuarioAlteracao)
    {
        Nome = nome;
        Cpf = cpf;
        UsuarioCriacao = usuarioCriacao;
        UsuarioAlteracao = usuarioAlteracao;
        DataAtualizacao = DateTime.Now;
        DataCriacao = DateTime.Now;
    }

    public MedicoDominio(int id, string nome, string rg, string cpf, UsuarioDominio usuarioAlteracao)
    {
        ID = id;
        Nome = nome;
        Cpf = cpf;
        UsuarioAlteracao = usuarioAlteracao;
        DataAtualizacao = DateTime.Now;
        DataCriacao = DateTime.Now;
    }

    [Key]
    public int ID { get; private set; }
    [Required]
    [MaxLength(200)]
    public string Nome { get; private set; }
    [Required]
    [MaxLength(50)]
    public string Rg { get; private set; }
    [Required]
    [MaxLength(14)]
    public string Cpf { get; private set; }
    [Required]
    [Column(TypeName = "datetime")]
    public DateTime DataAtualizacao { get; private set; }
    [Required]
    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; private set; }
    [Required]
    public UsuarioDominio UsuarioCriacao { get; private set; }
    [Required]
    public UsuarioDominio UsuarioAlteracao { get; private set; }
    [Required]
    public EspecialidadeMedicaDominio EspecialidadeMedica { get; private set; }
}