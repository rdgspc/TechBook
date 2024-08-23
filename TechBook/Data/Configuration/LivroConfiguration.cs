using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBook.Models;

namespace TechBook.Data.Configuration
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livros");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo)
                .IsRequired(true)
                .HasColumnType("VARCHAR(60)");


            builder.Property(x => x.Autor)
                .IsRequired(true)
                .HasColumnType("VARCHAR(60)");

            builder.Property(x => x.ISBN)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(13)");


            builder.Property(x => x.AnoPublicacao)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(4)");


            builder.Property(x => x.CategoriaId)
                .IsRequired(true)
                .HasColumnType("VARCHAR(60)");

            builder.HasIndex(x => x.ISBN)
                .IsUnique();

            builder.HasMany(e => e.Emprestimos)
                .WithOne(l => l.Livro)
                .HasForeignKey(l => l.Livro.Id)
                .OnDelete(DeleteBehavior.Restrict);





        }
    }
}
