using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinSqliteCRUD.Model.Entity;

namespace XamarinSqliteCRUD.Model
{
    public interface IPersonelRepository
    {
        Task<IEnumerable<Personel>> GetPersonelAsyncList();
        Task<bool> AddPersonelAsync(Personel personel);
        Task<bool> DeletePersonelAsync(int id);
        Task<bool> UpdatePersonelAsync(Personel personel);
        List<Department> GetDepartmentsListAsync();
    }
}
