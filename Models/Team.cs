using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace PremierAthletics.Models
{
    public class Team 
    {

      public Team() {
        this.Signatures = new HashSet<SignatureRequest>();
      }
        public string TeamId {get; set;}
        public string TeamName { get; set; }
        public string Sport {get; set;}
        public 
        public ICollection<SignatureRequest> Signatures {get; set;}
    }
}
//TODO: properly configure relationships between Team-Athlete (many-to-many, need join table) and Team-SignatureRequest(also many-to-many, need join table)