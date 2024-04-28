using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCondominioBack.Data.Models
{
    [Table("Casa")]
    public class CasaDTO
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Numero")]
        public int Number { get; set; }
        [Column("Letra")]
        public string? Word { get; set; } = string.Empty;
        [Column("Deuda")]
        public int? Debt { get; set; } = 0;

    }
}
