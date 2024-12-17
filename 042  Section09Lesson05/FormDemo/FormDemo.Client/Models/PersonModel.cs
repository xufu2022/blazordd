using System.ComponentModel.DataAnnotations;

namespace FormDemo.Client.Models;

public class PersonModel
{
    [Required]
    [MinLength(5, ErrorMessage = "The First Name is not long enough.")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "The Last Name is required.")]
    [MinLength(8, ErrorMessage = "The Last Name needs to be at least 8 characters.")]
    public string? LastName { get; set; }

    public string LifeStory { get; set; }
    public bool IsEnrolled { get; set; } = true;
}
