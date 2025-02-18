using System.ComponentModel.DataAnnotations;
using BookAPI.API.Models.User;

namespace BookStoreApp.API.Models.User
{
    public class UserDto : LoginUserDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Role { get; set; }
    }




}