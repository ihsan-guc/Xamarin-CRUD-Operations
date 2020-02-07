using System;
using System.Collections.Generic;
using System.Text;
using XamarinSqliteCRUD.Model;

namespace SqliteOrnek2.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public ILoginRepository LoginRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }
        public IPersonelRepository PersonelRepository { get; set; }

        public readonly DatabaseContext context;
        public UnitOfWork(ILoginRepository loginRepository, IDepartmentRepository departmentRepository,
            string dbPath,IPersonelRepository personelRepository)
        {
            LoginRepository = loginRepository;
            DepartmentRepository = departmentRepository;
            personelRepository = PersonelRepository;
            context = new DatabaseContext(dbPath);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
