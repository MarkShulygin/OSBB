using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class OSBBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieSession> MovieSessions { get; set; }
        public OSBBContext(DbContextOptions options)
        : base(options)
        {
        }
    }
}
