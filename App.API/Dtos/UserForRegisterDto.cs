using System.ComponentModel.DataAnnotations;

namespace App.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Password must be between 4 and 8 character length")]
        public string Password { get; set; }


    }
}