using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace PremierAthletics.Models
{
    public class Document 
    {

      public Document() {
        this.Teams = new HashSet<DocumentTeam>();
      }
        public string Title {get; set;}
        public string Subject {get; set;}
        public string Message {get; set;}
        public string Filepath {get; set;}
        public virtual ICollection<DocumentTeam> Teams {get; set;}
    }
}
