using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
    public interface IApplicatoinDbContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
