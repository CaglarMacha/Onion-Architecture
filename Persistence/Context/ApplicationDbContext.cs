﻿using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicatoinDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Product> Products { get; set ; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync(); 
        }

        Task<int> IApplicatoinDbContext.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
