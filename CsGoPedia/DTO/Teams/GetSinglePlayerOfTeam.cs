using GamerPedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamerPedia.DTO.Teams {
    public class GetSinglePlayerOfTeam {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Nickname { get; set; }

        public string BirthDate { get; set; }

        public string ImgCountry { get; set; }
        public string Coutry { get; set; }

        public string Team { get; set; }

        public string Role { get; set; }

        public string Instagram { get; set; }

        public string Hltv { get; set; }

        public string Photo { get; set; }

        public string VideoHighlight { get; set; }

        public string TotalWinnings { get; set; }

        //Colletion of list of objets from construtor from class players
        public virtual ICollection<GetStatistics> Statistics { get; set; }
        public virtual ICollection<GetAchievements> Achievements { get; set; }

        public class GetStatistics {
            public int Id { get; set; }

            public string Rating { get; set; }

            public string HS { get; set; }

            public string KillsRound { get; set; }

            public string DeadthsRound { get; set; }

            public string RoundsContributed { get; set; }

            public int MapsPlayed { get; set; }

            public int TotalKills { get; set; }

            public int TotalDeaths { get; set; }
        }

        public class GetAchievements {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Placement { get; set; }

        }

    }
}