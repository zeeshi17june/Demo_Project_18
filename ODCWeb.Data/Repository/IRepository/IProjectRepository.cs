using Microsoft.Build.Evaluation;
using ODCWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCWeb.DataAccess.Repository.IRepository
{
    public interface IProjectRepository:IRepository<ODCProject>
    {
        void Update(ODCProject obj);
    }
}
