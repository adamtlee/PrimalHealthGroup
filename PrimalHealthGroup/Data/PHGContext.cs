using Microsoft.EntityFrameworkCore;
using PrimalHealthGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimalHealthGroup.Data
{
    public class PHGContext : DbContext
    {
        public PHGContext (DbContextOptions<PHGContext> options) : base (options)
        {

        }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
    }
}
