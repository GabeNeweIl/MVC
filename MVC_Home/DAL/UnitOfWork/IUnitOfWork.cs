using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCHome.DAL.Repository;
using MVCHome.DAL.Data;

namespace MVCHome.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Artiсle> Articles { get;}
        IRepository<Review> Reviews { get;}
        //IRepository<Vote> Votes { get; }
        IRepository<Tag> Tags { get; }
        void Save();
    }
}
