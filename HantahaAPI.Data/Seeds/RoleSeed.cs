﻿using System;
using HantahaAPI.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data.Seeds
{
	public class RoleSeed:IEntityTypeConfiguration<Role>
	{

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                    new Role { Id=1, Name = "Admin", IsActive = true },
                    new Role { Id=2,Name = "User", IsActive = true }
                    );
        }
    }
}

