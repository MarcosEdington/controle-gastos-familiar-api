using System.ComponentModel.DataAnnotations;

namespace ControleGastosFamiliaApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty; // Novo campo

        [Required]
        public string CPF { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        [Required]
        public string Senha { get; set; } = string.Empty;

        public bool Ativo { get; set; } = true;
    }
}