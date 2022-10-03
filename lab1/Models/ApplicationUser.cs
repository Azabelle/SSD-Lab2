using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace lab1.Models
{
    public class ApplicationUser :  IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required, Display(Name = "Last Name")]
        public string  LastName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; } = DateTime.Now;
    }
}
