﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IRolRepositories
    {
        DataTable GetRol();
        DataTable GetAllRol();
    }
}