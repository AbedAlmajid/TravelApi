﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelerAPI.Models.SheredProp
{
    public class CommonProp
    {
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModifacationDate { get; set; }

    }
}
