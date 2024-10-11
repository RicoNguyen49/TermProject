using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class Leagues
    {
        [Key]
        [Display(Name = "League ID")]
        public int LeagueId { get; set; }
        public string? Name { get; set; }

    }
}

