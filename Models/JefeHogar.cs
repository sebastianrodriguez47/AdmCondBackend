namespace AdmCondominioBack.Models
{
    public class JefeHogar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Run { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int HouseId { get; set; }
    }
}
