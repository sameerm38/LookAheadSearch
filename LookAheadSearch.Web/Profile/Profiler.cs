using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAheadSearch.Web.Profile
{
    public class Profiler:AutoMapper.Profile
    {
        public Profiler()
        {
            CreateMap<Db.Product, Models.Product>();
        }
    }
}
