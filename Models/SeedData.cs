

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CbsStudent2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CbsStudent2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CbsStudent2Context>>()))
            {
                // Look for any movies.
                if (context.Profile.Any())
                {
                    return;   // DB has been seeded
                }

                context.Profile.AddRange(
                    new Profile
                    {
                        Name = "Johnny",
                        About =  "I am a student at cbs",
                        Email = "Johnny@cbs.dk"
                    },

                    new Profile
                    {
                        Name = "Benny",
                        About = "I am also a student at cbs",
                        Email = "Benny@cbs.dk"
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}