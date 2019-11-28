using Microsoft.EntityFrameworkCore;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infra.Data
{
    public class StoreDbContext:DbContext
    {
        public StoreDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
