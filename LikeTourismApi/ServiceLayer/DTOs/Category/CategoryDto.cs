﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
    }
}