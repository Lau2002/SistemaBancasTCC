using Microsoft.EntityFrameworkCore;
using sistemaBancas.Models;
public class Context : DbContext
{
    public DbSet<Professor> Professores {get; set;} = null!;
    public Context()
    {
    }
    public Context(DbContextOptions<Context> options)
        : base(options)
    { 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuração da entidade Professor
            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Professor_Id"); // Define a chave primária
                entity.Property(e => e.Email).IsRequired(); // Define que o email é obrigatório
                entity.Property(e => e.Senha).IsRequired(); // Define que a senha é obrigatória
            });
        }

}