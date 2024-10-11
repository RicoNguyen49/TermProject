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

        public DbSet<Leagues> Leagues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Members>().HasData(
                new Members
                {
                    ID = 1,
                    LeagueId = 1,
                    LeagueName = "English premire league",
                    Sport = "Soccer",
                    Country = "England",
                    Division = 1,
                    Email = "EPL@eng.com",
                    Cell = "981-123-4912"
                },
                new Members
                {
                    ID = 2,
                    LeagueId = 2,
                    LeagueName = "NFL",
                    Sport = "FootBall",
                    Country = "USA",
                    Division = 1,
                    Email = "NFL@yahoo.com",
                    Cell = "192-371-4781"

                },
                new Members
                {
                    ID = 3,
                    LeagueId = 3,
                    LeagueName = "MLB",
                    Sport = "Baseball",
                    Country = " USA",
                    Division = 1,
                    Email = "MLB@gmail.com",
                    Cell = "491-728-1374"
                }
            );
            modelBuilder.Entity<Leagues>().HasData(
            new Leagues { LeagueId = 1, Name = "English Premire League" },
            new Leagues { LeagueId = 2, Name = "NFL" },
            new Leagues { LeagueId = 3, Name = "MLB" }
            );

        }
    }
}