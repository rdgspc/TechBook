using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TechBook.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public string Documento { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Celular { get; set; } = null!;

        public DateTime DataNascimento { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

    }
}
