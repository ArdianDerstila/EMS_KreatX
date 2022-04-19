using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class ProjecttRepository : IProjecttRepository
    {
        private readonly AppDbContext context;

        public ProjecttRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Projectt Add(Projectt Projectt)
        {
            context.Projectts.Add(Projectt);
            context.SaveChanges();
            return Projectt;
        }

        public Projectt Delete(int id)
        {
            Projectt Projectt = context.Projectts.Find(id);
            if (Projectt != null)
            {
                context.Projectts.Remove(Projectt);
                context.SaveChanges();
            }
            return Projectt;
        }

        public IEnumerable<Projectt> GetAllProjectt()
        {
            return context.Projectts;
        }

        public Projectt GetProjectt(int id)
        {
            return context.Projectts.Find(id);
        }

        public Projectt Update(Projectt ProjecttChange)
        {
            var Projectt = context.Projectts.Attach(ProjecttChange);
            Projectt.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return ProjecttChange;
        }
    }
}
