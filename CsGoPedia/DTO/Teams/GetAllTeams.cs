using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamerPedia.DTO.Teams {
    public class GetAllTeams {


        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string WorldRanking { get; set; }

        public string RegionPhoto { get; set; }

        public string History { get; set; }
    }
}