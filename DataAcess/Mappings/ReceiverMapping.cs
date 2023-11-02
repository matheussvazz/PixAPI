﻿using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAcess.Mappings
{
    public class ReceiverMapping : IEntityTypeConfiguration<Receiver>
    {
        public void Configure(EntityTypeBuilder<Receiver> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Name)
                 .IsRequired()
                 .HasColumnType("varchar(1000)");

            builder.ToTable("Receiver");
        }
    }
}
