﻿using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    class TournamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> MyProperty { get; set; } = new List<List<MatchupModel>>();
    }
}
