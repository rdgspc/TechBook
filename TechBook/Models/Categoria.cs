namespace TechBook.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public string? Descricao { get; set; }

        public ICollection<Livro> Livros { get; set; } = new List<Livro>();

    }
}
