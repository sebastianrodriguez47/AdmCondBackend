using AdmCondominioBack.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmCondominioBack.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) 
        {     
        }   
        public virtual DbSet<CasaDTO> Casas {  get; set; }
        public virtual DbSet<JefeHogarDTO> JefeHogars { get; set; }
    }
}
