using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public DbSet<Command> Commands { get; set; }
        public WebAppContext(DbContextOptions<WebAppContext> opt) :base(opt)
        {

        }
    }
}
