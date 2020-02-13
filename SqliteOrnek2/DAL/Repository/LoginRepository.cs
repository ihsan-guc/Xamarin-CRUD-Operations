using System;
using System.Linq;
using System.Threading.Tasks;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.Model.Entity;

namespace SqliteOrnek2.DAL.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DatabaseContext context;

        public LoginRepository(string dataPath)
        {
            context = new DatabaseContext(dataPath);
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

        public Users GetUserControl(string user, string password)
        {
            try
            {
                var entity = context.Users.Where(p => p.UserName == user && p.Password == password).FirstOrDefault();
                if (entity != null)
                    return entity;
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
