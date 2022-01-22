﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAheadSearch.Web.Db
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Molecule { get; set; }
        public string HyperLink { get; set; }
    }
}
