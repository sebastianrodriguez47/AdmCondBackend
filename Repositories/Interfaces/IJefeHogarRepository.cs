using AdmCondominioBack.Data.Models;

namespace AdmCondominioBack.Repositories.Interfaces
{
    public interface IJefeHogarRepository: IDisposable
    {
        IEnumerable<JefeHogarDTO> GetAllJefeHogar();
        IList<JefeHogarDTO> GetJefeHogarByIdCasa(int id);
        int CreateJefeHogar(JefeHogarDTO casa);
        int UpdateJefeHogar(JefeHogarDTO casa);
        int DeleteJefeHogar(int id);

    }
}
