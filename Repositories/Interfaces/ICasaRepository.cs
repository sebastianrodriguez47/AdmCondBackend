using AdmCondominioBack.Data.Models;

namespace AdmCondominioBack.Repositories.Interfaces
{
    public interface ICasaRepository: IDisposable
    {
        IEnumerable<CasaDTO> GetAllCasas();
        CasaDTO GetCasaById(int id);
        int CreateCasa(CasaDTO casa);
        int UpdateCasa(CasaDTO casa);
        int DeleteCasa(int id);

    }
}
