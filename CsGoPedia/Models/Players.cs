using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerPedia.Models {
    public class Players {

        public Players() {
            //Lista of Achievements and Statistics
            this.ListStatistics = new HashSet<Statistics>();
            this.ListAchievements = new HashSet<Achievements>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Nickname { get; set; }

        public string BirthDate { get; set; }

        public string ImgCountry { get; set; }

        public string Country { get; set; }

        public string Team { get; set; }

        public string Role { get; set; }

        public string Instagram { get; set; }

        public string Hltv { get; set; }

        public string Photo { get; set; }

        public string VideoHighlight { get; set; }

        public string TotalWinnings { get; set; }

        //Foreign Key of relationship teams/players(1/n)
        [ForeignKey("Teams")]
        public int TeamFK { get; set; }
        public virtual Teams Teams { get; set; }

        //Colletion of list of objets from construtor from class players
        public virtual ICollection<Statistics> ListStatistics { get; set; }
        public virtual ICollection<Achievements> ListAchievements { get; set; }
    }
}