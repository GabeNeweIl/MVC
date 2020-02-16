using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHome.DAL.Data
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Artiсle> Articles { get; set; }
        public Tag()
        {
            Articles = new List<Artiсle>();
        }
    }
   
}
