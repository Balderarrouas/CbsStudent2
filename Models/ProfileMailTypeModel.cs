using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace CbsStudent2.Models
{

    public class ProfileMailTypeModel
    {

    public List<Profile>? Profiles{get; set;}
    public SelectList? Mails { get; set; }
    public string? MailType { get; set; }
    public string? SearchString { get; set; }


    }
}