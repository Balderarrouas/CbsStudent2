using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CbsStudent2.Models
{



public class Event
{

[Key]
public int EventID { get; set; }


[Required]
public string? EventName { get; set; }
[Required]
public string? About { get; set; }
[Required]
public string? Location { get; set; }

[Display(Name = "Mail Of Host")]
public int ProfileId { get; set; }

public Profile Profile{ get; set; }
}
}