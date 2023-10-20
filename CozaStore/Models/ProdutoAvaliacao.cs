using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("ProdutoAvaliacao")]
public class ProdutoAvaliacao
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required(ErrorMessage = "Informe o texto da sua avaliação")]
    [StringLength(300, ErrorMessage = "O texto deve possuir no minimo 300 caracteres")]

    public string AvaliacaoTexto { get; set; }

    [Display(Name = "Data da Avaliação")]
    public DateTime AvaliacaoData { get; set; } = DateTime.Now;

    [Display(Name = "Nome do Produto")]
    public byte? ProdutoNota { get; set; } 
}