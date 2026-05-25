using System.ComponentModel.DataAnnotations;

namespace CadastroDeLivros.Models;

public class Livro
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O título é obrigatório")]
    [Display(Name = "Título")]
    public string Titulo { get; set; } = string.Empty;

    [Required(ErrorMessage = "O autor é obrigatório")]
    public string Autor { get; set; } = string.Empty;

    [Required(ErrorMessage = "O ano é obrigatório")]
    [Display(Name = "Ano de Publicação")]
    public int AnoPublicacao { get; set; }

    [Display(Name = "Gênero")]
    public string? Genero { get; set; }

    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public decimal Preco { get; set; }
}