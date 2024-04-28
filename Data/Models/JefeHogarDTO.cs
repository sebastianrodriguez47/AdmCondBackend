using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdmCondominioBack.Data.Models
{
    [Table("JefeHogar")]
    public class JefeHogarDTO
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nombre")]
        public string Name { get; set; }
        [Column("FechaNacimiento")]
        public DateTimeOffset BirthDate { get; set; }
        [Column("Run")]
        public string Run { get; set; }
        [Column("Telefono")]
        public int Phone { get; set; }
        [Column("Correo")]
        public string? Email { get; set; } = string.Empty;
        [Column("IdCasa")]
        public int IdHouse { get; set; }



    }
}
