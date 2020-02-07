using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.Model.Entity;

namespace SqliteOrnek2.DAL.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DatabaseContext Context;
        public DepartmentRepository(string dataPath)
        {
            Context = new DatabaseContext(dataPath);
        }
        public async Task<IEnumerable<Department>> GetDepartmentsListAsync()
        {
            try
            {
                var list = await Context.Departments.ToListAsync();
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> AddDepartmentAsync(Department product)
        {
            try
            {
                var tracking = await Context.Departments.AddAsync(product);
                await Context.SaveChangesAsync();
                var isAdded = tracking.State == EntityState.Added;
                return isAdded;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteDepartmentAsync(int id)
        {
            try
            {
                var entity = await Context.Departments.FindAsync(id);
                var tracking = Context.Remove(entity);
                var isDelete = tracking.State == EntityState.Deleted; 
                await Context.SaveChangesAsync();
                return isDelete;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Task<bool> UpdateDepartment(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
