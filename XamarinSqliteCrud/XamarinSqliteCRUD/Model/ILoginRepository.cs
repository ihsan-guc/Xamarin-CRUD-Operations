﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinSqliteCRUD.Model.Entity;

namespace XamarinSqliteCRUD.Model
{
    public interface ILoginRepository
    {
        Task<Users> GetLoginByAsync(int id);
        Users GetUserControl(string user, string password);
    }
}
