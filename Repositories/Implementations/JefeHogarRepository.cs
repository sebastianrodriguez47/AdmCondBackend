using AdmCondominioBack.Data;
using AdmCondominioBack.Data.Models;
using AdmCondominioBack.Models;
using AdmCondominioBack.Repositories.Interfaces;

namespace AdmCondominioBack.Repositories.Implementations
{
    namespace AdmCondominioBack.Data.Models
    {
        public class JefeHogarRepository : IJefeHogarRepository
        {
            private readonly ApplicationDBContext _context;

            public JefeHogarRepository(ApplicationDBContext db)
            {
                _context = db;
            }

            public int CreateJefeHogar(JefeHogarDTO jefeHogar)
            {
                int result = -1;
                if (jefeHogar == null)
                {
                    result = 0;
                }
                else
                {
                    int idCasa = _context.Casas.Where(x => x.Number == jefeHogar.IdHouse).FirstOrDefault().Id;
                    if (idCasa > 0)
                    {
                        jefeHogar.IdHouse = idCasa;
                        _context.JefeHogars.Add(jefeHogar);
                        _context.SaveChanges();
                        result = jefeHogar.Id;
                    }
                    else
                    {
                        result = 0;
                    }
                    
                }
                return result;
            }

            public int DeleteJefeHogar(int id)
            {
                if (id == 0)
                {
                    return -1;
                }
                var x = _context.JefeHogars.Where(x => x.Id == id).FirstOrDefault();
                if (x != null)
                {
                    _context.JefeHogars.Remove(x);
                    _context.SaveChanges();
                    return x.Id;
                }
                return 0;
            }

            public IEnumerable<JefeHogarDTO> GetAllJefeHogar()
            {
                var y = _context.JefeHogars.ToList();
                return y;
            }

            public IList<JefeHogarDTO> GetJefeHogarByIdCasa(int number)
            {
                int? idCasa = _context.Casas.Where(x => x.Number == number).FirstOrDefault()?.Id;

                var y = _context.JefeHogars.Where(x => x.IdHouse == idCasa).ToList() ?? null;
                return y;
            }

            public int UpdateJefeHogar(JefeHogarDTO jefeHogar)
            {
                var y = _context.JefeHogars.Where(x => x.Id == jefeHogar.Id).FirstOrDefault() ?? null;
                int? idCasa = _context.Casas.Where(x => x.Number == jefeHogar.IdHouse).FirstOrDefault()?.Id;

                if(idCasa == 0)
                {
                    return -2;
                }

                if (y != null)
                {
                    y.Id = jefeHogar.Id;
                    y.Name = jefeHogar.Name;
                    y.BirthDate = jefeHogar.BirthDate;
                    y.Run = jefeHogar.Run;
                    y.Phone = jefeHogar.Phone;
                    y.Email = jefeHogar.Email;
                    y.IdHouse = jefeHogar.IdHouse;

                    _context.SaveChanges();
                    return y.Id;
                }
                return -1;
            }

            public void Dispose()
            {
                _context?.Dispose();
            }
        }
    }

}
