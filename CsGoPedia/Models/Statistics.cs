using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerPedia.Models {
    public class Statistics {


        [Key]
        public int Id { get; set; }

        public string Rating { get; set; }

        public string HS { get; set; }

        public string KillsRound { get; set; }

        public string DeadthsRound { get; set; }

        public string RoundsContributed { get; set; }

        public int MapsPlayed { get; set; }

        public int TotalKills { get; set; }

        public int TotalDeaths { get; set; }

        //Foreign Key of relationship players/Statistics(1/n)
        [ForeignKey("Player")]
        public int PlayerFK { get; set; }
        public virtual Players Player { get; set; }
    }
}