using System;
using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public enum Country
    {
        USA,
        Canada,
        Germany,
        England,
        UK,
        Spain,
        korea,
        Vietnam
    }
    public class Members
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "League Name")]
        [StringLength(30, ErrorMessage = "Please enter your full League name using 30 characters or less.")]
        public string? LeagueName { get; set; }

        [Required]
        [Display(Name = "Sport")]
        [StringLength(30, ErrorMessage = "Please enter your Sport name using 30 characters or less.")]
        public string? Sport { get; set; }

        [Display(Name = "Country")]
        public Country? CountryOrgin { get; set; }

        [StringLength(50, ErrorMessage = "Please enter your address using 50 characters or less.")]
        public string? HeadQuarters { get; set; }

        [StringLength(2, ErrorMessage = "Please enter the state using 2 characters.")]
        public string? Division { get; set; }

        public string? Email { get; set; }

        [Display(Name = "Cell Phone")]
        public string? Cell { get; set; }
    }
}