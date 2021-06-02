namespace PremierAthletics.Models
{
  public class SignatureRequestTeam
    {       
        public int SignatureRequestTeamId { get; set; }
        public int SignatureRequestId { get; set; }
        public int TeamId { get; set; }
        public virtual SignatureRequest SignatureRequest { get; set; }
        public virtual Team Team { get; set; }
    }
}