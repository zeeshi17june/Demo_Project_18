using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCWeb.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProjectRepository ODCProject { get; }
        void save();
    }
}
