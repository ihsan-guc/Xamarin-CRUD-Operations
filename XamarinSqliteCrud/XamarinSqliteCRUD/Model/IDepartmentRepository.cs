using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinSqliteCRUD.Model.Entity;

namespace XamarinSqliteCRUD.Model
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartmentsListAsync();
        Task<bool> AddDepartmentAsync(Department department);
        Task<bool> DeleteDepartmentAsync(int id);
        Task<bool> UpdateDepartment(Users users);
    }
}
