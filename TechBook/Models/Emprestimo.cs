namespace TechBook.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        public string? Observacao { get; set; }

        public int LivroId { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public Livro Livro { get; set; } = null!;

        public Usuario Usuario { get; set; } = null!;



    }
}
