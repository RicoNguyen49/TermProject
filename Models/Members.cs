using System;
using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class Members
    {
        public int ID { get; set; }

        [Display(Name = "League ID")]
        public int LeagueId { get; set; }
        public Leagues? Leagues { get; set; }

        [Required]
        [Display(Name = "League Name")]
        [StringLength(30, ErrorMessage = "Please enter your full League name using 30 characters or less.")]
        public string? LeagueName { get; set; }

        [Required]
        [Display(Name = "Sport")]
        [StringLength(30, ErrorMessage = "Please enter your Sport name using 30 characters or less.")]
        public string? Sport { get; set; }


        [StringLength(50, ErrorMessage = "Please enter your Country using 50 characters or less.")]
        public string? Country { get; set; }

        [StringLength(2, ErrorMessage = "Please enter the Division.")]
        public int? Division { get; set; }

        public string? Email { get; set; }

        [Display(Name = "Cell Phone")]
        public string? Cell { get; set; }
    }
}