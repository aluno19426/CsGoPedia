using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamerPedia.DTO.Teams {
    public class GetSingleTeam {

        public int Id { get; set; }

        public string Name { get; set; }

        public string RegionPhoto { get; set; }

        public string CoachPhoto { get; set; }
        public string Coach { get; set; }

    }
}