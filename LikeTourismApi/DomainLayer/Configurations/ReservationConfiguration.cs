﻿using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {

            builder.Property(m => m.RoomType).IsRequired();
            builder.Property(m => m.RoomPrise).IsRequired();
            builder.Property(m => m.Breakfast).IsRequired();
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}