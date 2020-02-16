using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHome.DAL.Data
{
    public class Artiсle
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Text { get; set; }
        public DateTime Publish { get; set; }
        //public int? TagId { get; set; }
        //public Tag tag { get; set; }
    }
}