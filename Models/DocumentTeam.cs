namespace PremierAthletics.Models
{
  public class DocumentTeam
    {       
        public int DocumentTeamId { get; set; }
        public string DocumentId { get; set; }
        public string TeamId { get; set; }
        public virtual Document Document { get; set; }
        public virtual Team Team { get; set; }
    }
}