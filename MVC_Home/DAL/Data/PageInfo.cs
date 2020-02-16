using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHome.DAL.Data
{
    public class PageInfo
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotlaPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / PageSize);
            }
        }

    }
    public class IndexViewModel
    {
        public PageInfo PageInfo { get; set; }
        public IEnumerable<Artiсle> Articles { get; set; }
    }
}
