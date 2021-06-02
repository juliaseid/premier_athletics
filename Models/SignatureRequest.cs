using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace PremierAthletics.Models
{
    public class SignatureRequest 
    {

      public SignatureRequest() {
        this.Teams = new HashSet<SignatureRequestTeam>();
      }
        public string SignatureRequestId {get; set;}
        public virtual ICollection<SignatureRequestTeam> Teams {get; set;}
    }
}
