using System.Collections.Generic;
using AvalieMais.Models;
using Microsoft.EntityFrameworkCore;

namespace AvalieMais.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
