using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProject.Models
{
    public class Members
    {
        public int ID { get; set; }

        [Display(Name = "League ID")]
        public int LeagueId { get; set; }
        public Leagues? Leagues { get; set; }

        [Required(ErrorMessage = "League Name is required.")]
        [Display(Name = "League Name")]
        [StringLength(30, ErrorMessage = "Please enter your full League name using 30 characters or less.")]
        [Column("LeagueName")]
        public string? LeagueName { get; set; }


        [Required(ErrorMessage = "Sport is required.")]
        [Display(Name = "Sport")]
        [StringLength(30, ErrorMessage = "Please enter your Sport name using 30 characters or less.")]
        public string? Sport { get; set; }


        [StringLength(50, ErrorMessage = "Please enter your Country using 50 characters or less.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Country name can only contain letters and spaces.")]
        public string? Country { get; set; }



        [Range(1, 10, ErrorMessage = "Division must be between 1 and 10.")]
        public int? Division { get; set; }


        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Display(Name = "Cell Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\)\s?|\d{3}[-.])?\d{3}[-.]\d{4}$", ErrorMessage = "Please enter a valid cell phone number (e.g., (123) 456-7890 or 123-456-7890).")]
        [Required(ErrorMessage = "Cell phone number is required.")]
        public string? Cell { get; set; }
    }
}