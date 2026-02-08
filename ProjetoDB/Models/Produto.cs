using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDB.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }
        [StringLength(50)]
        public string? Cor { get; set; }
        [Required]
        [Column(TypeName = "decimal(13, 2)")]
        public decimal Preco { get; set; }
        [StringLength(5)]
        public string? Tamanho { get; set; }
        [Column(TypeName = "char(1)")]
        public string? Genero { get; set; }
    }
}