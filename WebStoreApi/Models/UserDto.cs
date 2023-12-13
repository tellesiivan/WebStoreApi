using System.ComponentModel.DataAnnotations;

namespace WebStoreApi.Models;

public class UserDto
{
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required(ErrorMessage = "LastName is needed")]
    public string LastName { get; set; } = string.Empty;
    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    [Required]
    [MinLength(5)]
    [MaxLength(200)]
    public string Address { get; set; } = string.Empty;
}