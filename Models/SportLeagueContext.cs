using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class SportLeagueContext : DbContext
    {
        public SportLeagueContext(DbContextOptions<SportLeagueContext> options) : base(options)
        { }
        public DbSet<Members> Membership { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Members>().HasData(
                new Members
                {
                    ID = 1,
                    LeagueName = "English premire league",
                    Sport = "Soccer",
                    HeadQuarters = "1099 way",
                    Division = "1",
                    Email = "EPL@eng.com"
                },
                new Members
                {
                    ID = 2,
                    LeagueName = "NFL",
                    Sport = "FootBall",
                    HeadQuarters = "1023 my drive",
                    Division = "1",
                    Email = "NFL@yahoo.com"
                },
                new Members
                {
                    ID = 3,
                    LeagueName = "MLB",
                    Sport = "Baseball",
                    HeadQuarters = "328 west hollywood",
                    Division = "1",
                    Email = "MLB@gmail.com"
                }
            );

        }
    }
}