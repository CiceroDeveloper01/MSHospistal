using Microsoft.EntityFrameworkCore;
using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteRepositorio;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<UsuarioDominio> Usuario { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UsuarioDominio>().ToTable("TB_Usuario");
            

        /*modelBuilder.Entity<PedidoProduto>()
            .HasKey(pp => new { pp.PedidoId, pp.ProdutoId });

        modelBuilder.Entity<PedidoProduto>()
            .HasOne(pp => pp.Pedido)
            .WithMany(p => p.PedidoProdutos)
            .HasForeignKey(pp => pp.PedidoId);

        modelBuilder.Entity<PedidoProduto>()
            .HasOne(pp => pp.Produto)
            .WithMany()
            .HasForeignKey(pp => pp.ProdutoId);*/
    }
}
