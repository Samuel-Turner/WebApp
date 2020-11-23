using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public class DinoDbContext : DbContext
    {
        public DbSet<Dino> Dino { get; set; }
        public DinoDbContext(DbContextOptions<DinoDbContext> opt) : base(opt)
        {

        }
    }
}
