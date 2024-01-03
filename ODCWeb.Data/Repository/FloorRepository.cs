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
    public class FloorRepository : Repository<Floor>, IFloorRepository
    {
        private ApplicationDbContext _db;
        public FloorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Floor obj)
        {
            _db.Floors.Update(obj);
        }


    }
}
