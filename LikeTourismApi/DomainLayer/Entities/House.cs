﻿using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class House:BaseEntity
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }     
        public int Prise { get; set; }
        public float Rating { get; set; }
        public string RatingCommit { get; set; }
        public int FamousCityId { get; set; }
        public FamousCity FamousCity { get; set; }
    }
}