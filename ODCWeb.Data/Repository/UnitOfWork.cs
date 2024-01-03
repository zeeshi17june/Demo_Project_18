using ODCWeb.DataAccess.Data;
using ODCWeb.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCWeb.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public IProjectRepository ODCProject { get; private set; }
        public IFloorRepository Floor { get; private set; }


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ODCProject = new ProjectRepository(_db);
            Floor = new FloorRepository(_db);
        }
        public void save()
        {
            _db.SaveChanges();
        }
    }
}
