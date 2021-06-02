using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace PremierAthletics.Models
{
    public class Athlete 
    {

      public Athlete() {
        this.Teams = new HashSet<AthleteTeam>();
      }
        public string AthleteId {get; set;}
        public string FirstName { get; set; }
        public string LastName {get; set;}
        public DateTime Birthday {get; set;}
        [Required]
        [EmailAddress]
        public string email {get; set;}
        public ICollection<AthleteTeam> Teams {get; set;}
    }
}
