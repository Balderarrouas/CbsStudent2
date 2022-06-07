using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CbsStudent2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace CbsStudent2.Data
{

    public class CbsStudent2Context : IdentityDbContext
    {
        public CbsStudent2Context (DbContextOptions<CbsStudent2Context> options)
            : base(options)
        {
        }

        public DbSet<CbsStudent2.Models.Profile>? Profile { get; set; }

        public DbSet<CbsStudent2.Models.Event> Event { get; set; }
    }
}