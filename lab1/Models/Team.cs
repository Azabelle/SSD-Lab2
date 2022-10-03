// I, Azabelle Tale, student number 000815166, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using System.ComponentModel.DataAnnotations;

namespace lab1.Models
{
    public class Team
    {
        [Required]
        public int Id { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required]
        public string Email { get; set; }
        public DateTime StablishedDate { get; set; }
    }
}
