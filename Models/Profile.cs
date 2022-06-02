using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CbsStudent2.Models
{

public class Profile
{

[Key]
public int ProfileId { get; set; }

[Display(Name = "Name Of Student")]
[Required]
[StringLength(50, MinimumLength = 2)]
public string? Name { get; set; }
public string? About { get; set; }
[Required]
public string? Email { get; set; }
[Required]
[Range(1, 8)]
public string Year { get; set; }



}





}