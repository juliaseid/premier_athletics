namespace PremierAthletics.Models
{
  public class AthleteTeam
    {       
        public int AthleteTeamId { get; set; }
        public string AthleteId { get; set; }
        public string TeamId { get; set; }
        public virtual Athlete Athlete { get; set; }
        public virtual Team Team { get; set; }
    }
}