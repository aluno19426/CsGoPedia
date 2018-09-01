using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamerPedia.Models {
    public class Achievements {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Placement { get; set; }

        //Foreign Key of relationship players/Achivements(1/n)
        [ForeignKey("Player")]
        public int PlayerFK { get; set; }
        public virtual Players Player { get; set; }

    }
}