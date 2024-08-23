using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBook.Models;

namespace TechBook.Data.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(60)");


            builder.Property(x => x.Descricao)
                .IsRequired(false)
                .HasColumnType("VARCHAR(150)");

            builder.HasMany(l => l.Livros)
                .WithOne(c => c.Categoria)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
