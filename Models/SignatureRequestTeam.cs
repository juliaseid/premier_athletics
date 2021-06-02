namespace PremierAthletics.Models
{
  public class SignatureRequestTeam
    {       
        public int SignatureRequestTeamId { get; set; }
        public string SignatureRequestId { get; set; }
        public string TeamId { get; set; }
        public virtual SignatureRequest SignatureRequest { get; set; }
        public virtual Team Team { get; set; }
    }
}