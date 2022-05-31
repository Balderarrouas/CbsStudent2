using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CbsStudent2.Models
{

public class Profile{

[Key]
public int ProfileId { get; set; }

[Display(Name = "Name Of Student")]
public string? Name { get; set; }
public string? About { get; set; }
public string? Email { get; set; }



}





}