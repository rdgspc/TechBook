using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBook.Models;

namespace TechBook.Data.Configuration
{
    public class EmprestimoConfiguration : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("Emprestimos");

            builder.HasKey(x  => x.Id);

            builder.Property(x => x.Observacao)
                .IsRequired(false)
                .HasColumnType("VARCHAR(250)");

            builder.Property(x => x.UsuarioId)
                .IsRequired();

            builder.Property( x => x.LivroId)
                .IsRequired();
        }
    }
}
