using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSqliteCRUD.Model
{
    public interface IUnitOfWork : IDisposable
    {
        ILoginRepository LoginRepository { get; set; }
        IDepartmentRepository DepartmentRepository { get; set; }
        IPersonelRepository PersonelRepository{ get; set; }
    }
}
