﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogReyting
    {
        public int BlogReytingID { get; set; }
        public int BlogID { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogReytingCount { get; set; }
    }
}
