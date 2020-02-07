using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.Model.Entity;

namespace SqliteOrnek2.DAL.Repository
{
    public class PersonelRepository : IPersonelRepository
    {
        protected readonly DatabaseContext context;
        public PersonelRepository(string dbPath)
        {
            context = new DatabaseContext(dbPath);
        }
        public async Task<bool> AddPersonelAsync(Personel personel)
        {
            try
            {
                var tracking = await context.Personels.AddAsync(personel);
                await context.SaveChangesAsync();
                var isAdd = tracking.State == EntityState.Added;
                return isAdd;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletePersonelAsync(int id)
        {
            try
            {
                var tracking = await context.Personels.FindAsync(id);
                var entity = context.Remove(tracking);
                var isDelete = entity.State == EntityState.Deleted;
                return isDelete;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Department> GetDepartmentsListAsync()
        {
            try
            {
                var list = context.Departments.ToList();
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Personel>> GetPersonelAsyncList()
        {
            try
            {
                var personlist = await context.Personels.ToListAsync();
                return personlist;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<bool> UpdatePersonelAsync(Personel personel)
        {
            throw new NotImplementedException();
        }
    }

}
