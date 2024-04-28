using AdmCondominioBack.Data;
using AdmCondominioBack.Data.Models;
using AdmCondominioBack.Repositories.Interfaces;

namespace AdmCondominioBack.Repositories.Implementations
{
    namespace AdmCondominioBack.Data.Models
    {
        public class CasaRepository : ICasaRepository
        {
            private readonly ApplicationDBContext _context;

            public CasaRepository(ApplicationDBContext db)
            {
                _context = db;
            }

            public int CreateCasa(CasaDTO casa)
            {
                int result = -1;
                if (casa == null)
                {
                    result = 0;
                }
                else
                {
                    _context.Casas.Add(casa);
                    _context.SaveChanges();
                    result = casa.Id;
                }
                return result;
            }

            public int DeleteCasa(int id)
            {
                if (id == 0)
                {
                    return -1;
                }
                var x = _context.Casas.Where(x => x.Id == id).FirstOrDefault();
                if (x != null)
                {
                    _context.Casas.Remove(x);
                    _context.SaveChanges();
                    return x.Id;
                }
                return 0;
            }

            public IEnumerable<CasaDTO> GetAllCasas()
            {
                var y = _context.Casas.ToList();
                return y;
            }

            public CasaDTO GetCasaById(int id)
            {
                var y = _context.Casas.Where(x => x.Id == id).FirstOrDefault() ?? null;
                return y;
            }

            public int UpdateCasa(CasaDTO casa)
            {
                var y = _context.Casas.Where(x => x.Id == casa.Id).FirstOrDefault() ?? null;
                if (y != null)
                {
                    y.Id = casa.Id;
                    y.Number = casa.Number;
                    y.Word = casa.Word;
                    y.Debt = casa.Debt;

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
