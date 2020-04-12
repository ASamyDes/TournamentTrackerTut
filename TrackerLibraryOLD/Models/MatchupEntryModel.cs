namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the Score for this team
        /// </summary>
        public double score { get; set; }
        /// <summary>
        /// represents the matchup that this team came from
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        
        public MatchupEntryModel(double initialScore)
        {
            
        }
    }
}