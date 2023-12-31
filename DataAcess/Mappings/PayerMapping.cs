﻿using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Mappings
{
    public class PayerMapping : IEntityTypeConfiguration<Payer>
    {
        public void Configure(EntityTypeBuilder<Payer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Name)
                 .IsRequired()
                 .HasColumnType("varchar(1000)");

            builder.ToTable("Payer");
        }
    }
}
