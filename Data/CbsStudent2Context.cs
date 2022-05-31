using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CbsStudent2.Models;

    public class CbsStudent2Context : DbContext
    {
        public CbsStudent2Context (DbContextOptions<CbsStudent2Context> options)
            : base(options)
        {
        }

        public DbSet<CbsStudent2.Models.Profile>? Profile { get; set; }
    }
