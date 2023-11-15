using Microsoft.Build.Evaluation;
using ODCWeb.DataAccess.Data;
using ODCWeb.DataAccess.Repository.IRepository;
using ODCWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ODCWeb.DataAccess.Repository
{
    public class ProjectRepository : Repository<ODCProject>, IProjectRepository
    {
        private ApplicationDbContext _db;
        public ProjectRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ODCProject obj)
        {
            _db.Projects.Update(obj);


        }
    }
}
