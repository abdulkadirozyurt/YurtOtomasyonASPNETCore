﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Income
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string DateOfIncome { get; set; }
        public decimal AmountOfIncome { get; set; }

    }
}
