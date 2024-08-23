namespace TechBook.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = null!;

        public string Autor { get; set; } = null!;

        public string ISBN { get; set; } = null!;

        public string AnoPublicacao { get; set; } = null!;

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; } = null!;

        public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();



    }
}
