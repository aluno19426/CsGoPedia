using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamerPedia.Models {
    public class Teams {

        public Teams() {
            //List of players
            this.ListPlayers = new HashSet<Players>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string LocalizationPhoto { get; set; }
        public string Localization { get; set; }

        public string Region { get; set; }
        public string RegionPhoto { get; set; }

        public string CoachPhoto { get; set; }
        public string Coach { get; set; }

        public string CeoPhoto { get; set; }
        public string Ceo { get; set; }

        public string TotalEarnings { get; set; }

        public string Logo { get; set; }

        //Colletion of list of objets from construtor from class teams
        public virtual ICollection<Players> ListPlayers { get; set; }


    }
}