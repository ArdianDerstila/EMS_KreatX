using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public interface IProjecttRepository
    {
        Projectt GetProjectt(int id);
        IEnumerable<Projectt> GetAllProjectt();
        Projectt Add(Projectt Projectt);
        Projectt Update(Projectt ProjecttChange);
        Projectt Delete(int id);
    }
}
