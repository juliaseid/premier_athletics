namespace PremierAthletics.Models
{
  public class AthleteTeam
    {       
        public int AthleteTeamId { get; set; }
        public int AthleteId { get; set; }
        public int TeamId { get; set; }
        public virtual Athlete Athlete { get; set; }
        public virtual Team Team { get; set; }
    }
}