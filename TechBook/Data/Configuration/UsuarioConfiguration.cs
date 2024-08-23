using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBook.Models;

namespace TechBook.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(60)");

            builder.Property(x => x.Documento)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(11)");

            builder.Property(x => x.Email)
                .IsRequired(true)
                .HasColumnType("VARCHAR(60)");

            builder.Property(x => x.Celular)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(11)");

            builder.HasIndex(x => x.Documento)
                .IsUnique();

            builder.HasMany(e => e.Emprestimos)
                .WithOne(u => u.Usuario)
                .HasForeignKey(u => u.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
