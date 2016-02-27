﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Model;

namespace EF_Context.Repositories
{
    public interface IDatumRepository : IRepository<Datum>
    {
        IEnumerable<Datum> GetDatumsFromPrestatie(int id);
    }
}
