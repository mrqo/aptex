﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aptex.Contracts.ViewModels
{
    public class CategorySelectViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public bool Selected { get; set; }
    }
}
