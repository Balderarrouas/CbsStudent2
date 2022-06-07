

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using CbsStudent2.Data;




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
                // Look for any Profiles.
                if (context.Profile.Any())
                {
                    return;   // DB has been seeded
                }

                context.Profile.AddRange(
                    new Profile
                    {
                        Name = "Johnny",
                        About =  "I am a student at cbs",
                        Email = "Johnny@cbs.dk",
                        Year = "1"
                    },

                    new Profile
                    {
                        Name = "Benny",
                        About = "I am also a student at cbs",
                        Email = "Benny@cbs.dk",
                        Year = "2"
                        
                    }
                );
                context.SaveChanges();

                if (context.Event.Any())
                {
                    return; //Db has been seedelideeded
                }

                context.Event.AddRange(
                    new Event
                    {

                        EventName = "Juleaften",
                        About = "Julehygge på kontoret",
                        Location = "Kontor 2"
                    },

                    new Event
                    {

                        EventName = "Påskefrokost",
                        About = "Haps Haps nu ska vi ha snaps",
                        Location = "Kantinen"
                    }



                );
                context.SaveChanges();


            }


            


        }
    }
}