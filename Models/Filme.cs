using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
   
    [Required(ErrorMessage = "O gênero é obrigatório")]
    public string Titulo { get; set; }
    
    [Required]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    
    [Required]
    [Range(30,600, ErrorMessage = "A duração deve ser entre 30 e 600 minutos")]
    public int Duracao { get; set; }
    public virtual ICollection<Sessao> Sessoes { get; set; }
}
