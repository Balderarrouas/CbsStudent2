using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CbsStudent2.Models
{



public class Event
{

[Key]
public int EventID { get; set; }

public string? EventName { get; set; }

public string? About { get; set; }
public string? Location { get; set; }


public int ProfileId { get; set; }

public Profile Profile{ get; set; }
}
}