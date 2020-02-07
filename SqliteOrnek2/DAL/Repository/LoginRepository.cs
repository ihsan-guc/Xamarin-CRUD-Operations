using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.Model.Entity;

namespace SqliteOrnek2.DAL.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DatabaseContext context;
        public async Task<bool> AddProductAsync(Users users)
        {
            try
            {
                var tracking = await context.Users.AddAsync(users);
                await context.SaveChangesAsync();
                var isAdded = tracking.State == EntityState.Added;
                return isAdded;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Users> GetLoginByAsync(int id)
        {
            try
            {
                var entity = await context.Users.FindAsync(id);
                return entity;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
