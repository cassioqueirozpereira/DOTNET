using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDB.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string? Nome { get; set; }

        [StringLength(255)]
        public string? Sobrenome { get; set; }

        [StringLength(255)]
        public string? Email { get; set; }

        public bool? AceitaComunicados { get; set; }

        public DateTime? DataCadastro { get; set; }
    }
}