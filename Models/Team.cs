using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace PremierAthletics.Models
{
    public class Team 
    {

      public Team() {
        this.Athletes = new HashSet<AthleteTeam>();
        this.Documents = new HashSet<DocumentTeam>();
      }
        public string TeamId {get; set;}
        public string TeamName { get; set; }
        public string Sport {get; set;} 
        public virtual ICollection<AthleteTeam> Athletes {get; set;}
        public virtual ICollection<DocumentTeam> Documents {get; set;}
    }
}
