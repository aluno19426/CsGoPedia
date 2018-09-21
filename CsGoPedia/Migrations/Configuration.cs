namespace CsGoPedia.Migrations
{
    using GamerPedia.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GamerPedia.Models.AppDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GamerPedia.Models.AppDB context)
        {

            //List of teams will be readed on API
            var ListTeam = new List<Teams> {

                //team MouseSports
                new Teams {Id = 1, Name = "Mousesports", WorldRanking="4º",Region="Europe", RegionPhoto="https://static.hltv.org/images/bigflags/30x20/EU.gif", CoachPhoto="https://static.hltv.org/images/playerprofile/thumb/300/400.jpeg?v=4", Coach="Sergey Bezhanov", TotalEarnings="1,829,391$", Logo="https://static.hltv.org/images/team/logo/4494"},

                //team Faze Clan
                new Teams {Id = 2, Name = "FaZe Clan",WorldRanking="5º",Region="Europe", RegionPhoto="https://static.hltv.org/images/bigflags/30x20/EU.gif", CoachPhoto="https://static.hltv.org/images/playerprofile/thumb/2/400.jpeg?v=1", Coach="Robert Dahlström", TotalEarnings="2,507,347$", Logo="https://static.hltv.org/images/team/logo/6667"},

                //team Renegades
                new Teams {Id = 3, Name = "Renegades", WorldRanking="19º", Region="North America", RegionPhoto="https://static.hltv.org/images/bigflags/30x20/US.gif", CoachPhoto="https://static.hltv.org/images/playerprofile/thumb/9052/400.jpeg?v=1", Coach="Steve Rattacasa", TotalEarnings="547,198$", Logo="https://static.hltv.org/images/team/logo/6211"},

                //team North
                new Teams {Id = 4, Name = "North", WorldRanking="6º",Region="Europe", RegionPhoto="https://static.hltv.org/images/bigflags/30x20/EU.gif", CoachPhoto="https://static.hltv.org/images/playerprofile/thumb/24/400.jpeg?v=1", Coach="Alexander Holdt", TotalEarnings="670,250$", Logo="https://static.hltv.org/images/team/logo/7533"},
            };

            ListTeam.ForEach(t => context.Teams.AddOrUpdate(tt => tt.Name, t));
            context.SaveChanges();

            var ListPlayers = new List<Players> {
                //List of players of team MouseSports

                new Players {Id=1, Name="Chris de Jong", Nickname="chrisJ", BirthDate="May 25, 1990 (age 28)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/NL.gif" ,Country="Netherlands", Hltv="https://www.hltv.org/player/2730/chrisJ", Instagram="https://www.instagram.com/chrisjcsgo_/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/2730.png",Role="In-game leader/Rifler", Team="mousesports", TotalWinnings="$288,428", VideoHighlight="https://www.youtube.com/embed/XqrCsQcSwsU?rel=0", TeamFK=1},

                new Players {Id=2,Name="Tomáš Šťastný", Nickname="oskar", BirthDate="June 27, 1991 (age 27)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/CZ.gif" ,Country="Czech Republic", Hltv="https://www.hltv.org/player/798/oskar", Instagram="https://www.instagram.com/oskartommy", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/798.png",Role="AWPer", Team="mousesports", TotalWinnings="$251,764", VideoHighlight="https://www.youtube.com/embed/0xXO26cGQl0?rel=0", TeamFK=1},

                new Players {Id=3,Name="Robin Kool",  Nickname="ropz",BirthDate="December 22, 1999 (age 18)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/EE.gif" ,Country="Estonia", Hltv="https://www.hltv.org/player/11816/ropz", Instagram="https://www.instagram.com/ropzicle/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/11816.png",Role="Rifler (lurker)", Team="mousesports", TotalWinnings="$198,773", VideoHighlight="https://www.youtube.com/embed/N4890ImohvA?rel=0", TeamFK=1},

                new Players {Id=4,Name="Miikka Kemppi",  Nickname="suNny",BirthDate="August 24, 1994 (age 23)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/FI.gif" ,Country="Finland", Hltv="https://www.hltv.org/player/5479/suNny", Instagram="https://www.instagram.com/sunnycsgo/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/5479.png",Role="Rifler (entry fragger)", Team="mousesports", TotalWinnings="$205,826", VideoHighlight="https://www.youtube.com/embed/fPVN3vteCkw?rel=0", TeamFK=1},


                new Players {Id=5,Name="Janusz Pogorzelski",  Nickname="Snax",BirthDate="July 5, 1993 (age 25)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/PL.gif" ,Country="Poland", Hltv="https://www.hltv.org/player/2553/Snax", Instagram="https://www.instagram.com/snax1337/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/2553.png",Role="Rifler/AWPer", Team="mousesports", TotalWinnings="$576,556", VideoHighlight="https://www.youtube.com/embed/1eADWcd2idM?rel=0", TeamFK=1},

                  //List of players of team FazeClan

                new Players {Id=6, Name="Håvard Nygaard", Nickname="rain", BirthDate="August 27, 1994 (age 23)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/NO.gif" ,Country="Norway", Hltv="https://www.hltv.org/player/8183/rain", Instagram="https://www.instagram.com/faze_raincs/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/8183.png",Role="Rifler (entry fragger)", Team="FaZe Clan", TotalWinnings="$532,296", VideoHighlight="https://www.youtube.com/embed/ifdtAujldbg?rel=0", TeamFK=2},

                new Players {Id=7,Name="Finn Andersen", Nickname="karrigan", BirthDate="April 14, 1990 (age 28)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/DK.gif" ,Country="Denmark", Hltv="https://www.hltv.org/player/429/karrigan", Instagram="https://www.instagram.com/karrigancsgo/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/429.png",Role="In-game leader/Rifler", Team="FaZe Clan", TotalWinnings="$695,992", VideoHighlight="https://www.youtube.com/embed/FgLGFNtFQFo?rel=0", TeamFK=2},

                new Players {Id=8,Name="Nikola Kovač",  Nickname="NiKo",BirthDate="February 16, 1997 (age 21)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/BA.gif" ,Country="Bosnia and Herzegovina", Hltv="https://www.hltv.org/player/3741/NiKo", Instagram="https://www.instagram.com/csgoniko/?hl=pt", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/3741.png",Role="Rifler (lurker)/AWPer", Team="FaZe Clan", TotalWinnings="$522,396", VideoHighlight="https://www.youtube.com/embed/C1Pbnw7DRLc?rel=0", TeamFK=2},

                new Players {Id=9,Name="Ladislav Kovács",  Nickname="GuardiaN ",BirthDate="July 9, 1991 (age 27)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/SK.gif" ,Country="Slovakia", Hltv="https://www.hltv.org/player/2757/GuardiaN", Instagram="https://www.instagram.com/ladislav.xkovacs/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/2757.png",Role="AWPer", Team="Faze Clan", TotalWinnings="$644,396", VideoHighlight="https://www.youtube.com/embed/rbINtd_NjyE?rel=0", TeamFK=2},

                new Players {Id=10,Name="Olof Kajbjer Gustafsson",  Nickname="olofmeister",BirthDate="January 31, 1992 (age 26)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/SE.gif" ,Country="Sweden", Hltv="https://www.hltv.org/player/2553/Snax", Instagram="https://www.instagram.com/olofkajbjer/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/885.png",Role="Rifler/AWPer", Team="Faze Clan", TotalWinnings="$675,598", VideoHighlight="https://www.youtube.com/embed/6_wLxs2wAZ8?rel=0", TeamFK=2},

                //List of players of team Renegades

               new Players {Id=11,Name="Aaron Ward",  Nickname="AZR",BirthDate="October 2, 1993 (age 25)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/AU.gif" ,Country="Australia", Hltv="https://www.hltv.org/player/8082/AZR", Instagram="https://www.instagram.com/azr/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/8082.png",Role="In-game leader/Rifler", Team="Renegades", TotalWinnings="$119,120", VideoHighlight="https://www.youtube.com/embed/Lzfr8lPNuw0?rel=0", TeamFK=3},

               new Players {Id=12,Name="Justin Savage",  Nickname="jks ",BirthDate="December 12, 1995 (age 22)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/AU.gif" ,Country="Australia", Hltv="https://www.hltv.org/player/4679/jks", Instagram="https://www.instagram.com/jks_cs/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/4679.png",Role="Rifler", Team="Renegades", TotalWinnings="$119,120", VideoHighlight="https://www.youtube.com/embed/ODjHNE-4A8g?rel=0", TeamFK=3},

               new Players {Id=13,Name="Karlo Pivac",  Nickname="USTILO",BirthDate="August 10, 1993 (age 24)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/AU.gif" ,Country="Australia", Hltv="https://www.hltv.org/player/8771/USTILO", Instagram="https://www.instagram.com/ustilocsgo/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/8771.png",Role="Rifler", Team="Renegades", TotalWinnings="$119,120", VideoHighlight="https://www.youtube.com/embed/WWo0oYleg1c?rel=0", TeamFK=3},

               new Players {Id=14,Name="Noah Francis",  Nickname="Nifty",BirthDate="November 23, 1997 (age 20)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/US.gif" ,Country="United States", Hltv="https://www.hltv.org/player/9069/Nifty", Instagram="https://www.instagram.com/buzzfeednifty/?hl=pt", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/9069.png",Role="AWPer/In-game leader", Team="Renegades", TotalWinnings="$88,817", VideoHighlight="https://www.youtube.com/embed/yLqrjB2jk74?rel=0", TeamFK=3},

               new Players {Id=15,Name="Joakim Myrbostad",  Nickname="jkaem",BirthDate="February 27, 1994 (age 24)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/NO.gif" ,Country="Norway", Hltv="https://www.hltv.org/player/8248/jkaem", Instagram="https://www.instagram.com/jkaem23/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/8248.png",Role="Rifler (lurker)", Team="Renegades", TotalWinnings="$79,110", VideoHighlight="https://www.youtube.com/embed/-KhBWM-0FZk?rel=0", TeamFK=3},

               // List of players of team North

               new Players {Id=16,Name="Mathias Sommer Lauridsen",  Nickname="MSL",BirthDate="December 6, 1994 (age 23)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/DK.gif" ,Country="Denmark", Hltv="https://www.hltv.org/player/7156/MSL", Instagram="https://www.instagram.com/mathiassommerlauridsen/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/7156.png",Role="In-game leader/Rifler (lurker)", Team="North", TotalWinnings="$296,096", VideoHighlight="https://www.youtube.com/embed/CbXBJ302N5Q?rel=0", TeamFK=4},

               new Players {Id=17,Name="Philip Aistrup Larsen",  Nickname="aizy ",BirthDate="June 4, 1996 (age 22)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/DK.gif" ,Country="Denmark", Hltv="https://www.hltv.org/player/8095/aizy", Instagram="https://www.instagram.com/aizydj/?hl=pt", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/8095.png",Role="Rifler", Team="North", TotalWinnings="$234,228", VideoHighlight="https://www.youtube.com/embed/qATvTfPTmLo?rel=0", TeamFK=4},

               new Players {Id=18,Name="Valdemar Bjørn Vangså",  Nickname="valde",BirthDate="June 12, 1995 (age 23)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/DK.gif" ,Country="Denmark", Hltv="https://www.hltv.org/player/9031/valde", Instagram="https://www.instagram.com/valdeCS/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/9031.png",Role="Rifler", Team="North", TotalWinnings="$146,387", VideoHighlight="https://www.youtube.com/embed/TUjXKVmhc_8?rel=0", TeamFK=4},

               new Players {Id=19,Name="Markus Kjærbye",  Nickname="Kjaerbye",BirthDate="April 27, 1998 (age 20)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/DK.gif" ,Country="Denmark", Hltv="https://www.hltv.org/player/8394/Kjaerbye", Instagram="https://www.instagram.com/markuskjaerbye/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/8394.png",Role="Rifler (entry fragger)", Team="North", TotalWinnings="$508,858", VideoHighlight="https://www.youtube.com/embed/u8FXWfyUGls?rel=0", TeamFK=4},

                new Players {Id=20,Name="Daniel Mertz",  Nickname="mertz",BirthDate="September 29, 1998 (age 19)", ImgCountry="https://static.hltv.org/images/bigflags/30x20/DK.gif" ,Country="Denmark", Hltv="https://www.hltv.org/player/9895/mertz", Instagram="https://www.instagram.com/mertz98/", Photo="https://static.hltv.org//images/playerprofile/bodyshot/compressed/9895.png",Role="AWPer", Team="North", TotalWinnings="$38,035", VideoHighlight="https://www.youtube.com/embed/7J-q58N6F48?rel=0", TeamFK=4},
            };

            ListPlayers.ForEach(t => context.Players.AddOrUpdate(tt => tt.Name, t));
            context.SaveChanges();

            var ListAchivements = new List<Achievements> {

                //List of Achivements of each player on team Mouse

                new Achievements {Id=1, Name="ELEAGUE Major 2018", Placement="1/4 Final", PlayerFK=1},
                new Achievements {Id=2, Name="ELEAGUE CS:GO Premier 2018", Placement="3rd ", PlayerFK=1},
                new Achievements {Id=3, Name="ESL One Belo Horizonte 2018", Placement="2nd", PlayerFK=1},
                new Achievements {Id=4, Name="StarSeries i-League Season 5", Placement="3rd", PlayerFK=1},
                new Achievements {Id=5, Name="PGL Major Krakow 2017", Placement="Group stage", PlayerFK=1},

                new Achievements {Id=6, Name="ELEAGUE Major 2018", Placement="1/4 Final", PlayerFK=2},
                new Achievements {Id=7, Name="ELEAGUE CS:GO Premier 2018", Placement="3rd ", PlayerFK=2},
                new Achievements {Id=8, Name="IEM Sydney 2018", Placement="3rd", PlayerFK=2},
                new Achievements {Id=9, Name="StarSeries i-League Season 5", Placement="3rd", PlayerFK=2},
                new Achievements {Id=10, Name="PGL Major Krakow 2017", Placement="Group stage", PlayerFK=2},

                new Achievements {Id=11, Name="ELEAGUE Major 2018", Placement="1/4 Final", PlayerFK=3},
                new Achievements {Id=12, Name="ELEAGUE CS:GO Premier 2018", Placement="3rd ", PlayerFK=3},
                new Achievements {Id=13, Name="ESL One Belo Horizonte 2018", Placement="2nd", PlayerFK=3},
                new Achievements {Id=14, Name="StarSeries i-League Season 5", Placement="3rd", PlayerFK=3},
                new Achievements {Id=15, Name="IEM Sydney 2018", Placement="3rd", PlayerFK=3},

                new Achievements {Id=16, Name="ELEAGUE Major 2018", Placement="1/4 Final", PlayerFK=4},
                new Achievements {Id=17, Name="ELEAGUE CS:GO Premier 2018", Placement="3rd ", PlayerFK=4},
                new Achievements {Id=18, Name="ESL One Belo Horizonte 2018", Placement="2nd", PlayerFK=4},
                new Achievements {Id=19, Name="ECS Season 4 Finals", Placement="2nd", PlayerFK=4},
                new Achievements {Id=20, Name="PGL Major Krakow 2017", Placement="Group stage", PlayerFK=4},

                new Achievements {Id=21, Name="EMS One Katowice 2014", Placement="1st", PlayerFK=5},
                new Achievements {Id=22, Name="DreamHack Winter 2014", Placement="3rd ", PlayerFK=5},
                new Achievements {Id=23, Name="ELEAGUE Major 2018", Placement="Group stage", PlayerFK=5},
                new Achievements {Id=24, Name="EPICENTER: Moscow", Placement="2nd", PlayerFK=5},
                new Achievements {Id=25, Name="ELEAGUE Major 2017", Placement="2nd", PlayerFK=5},

                //List of Achivements of each player on team Faze

                new Achievements {Id=26, Name="ESL One Cologne 2018", Placement="3rd", PlayerFK=6},
                new Achievements {Id=27, Name="ESL One Belo Horizonte 2018", Placement="1st ", PlayerFK=6},
                new Achievements {Id=28, Name="IEM Katowice 2018", Placement="2nd", PlayerFK=6},
                new Achievements {Id=29, Name="ECS Season 4 Finals", Placement="1st", PlayerFK=6},
                new Achievements {Id=30, Name="DreamHack Open Cluj-Napoca 2015", Placement="3rd", PlayerFK=6},

                new Achievements {Id=31, Name="ESL One Cologne 2018", Placement="3rd", PlayerFK=7},
                new Achievements {Id=32, Name="ESL One Belo Horizonte 2018", Placement="1st ", PlayerFK=7},
                new Achievements {Id=33, Name="IEM Katowice 2018", Placement="2nd", PlayerFK=7},
                new Achievements {Id=34, Name="ECS Season 4 Finals", Placement="1st", PlayerFK=7},
                new Achievements {Id=35, Name="DreamHack Open Cluj-Napoca 2015", Placement="1/4 final", PlayerFK=7},

                new Achievements {Id=36, Name="ESL One Cologne 2018", Placement="3rd", PlayerFK=8},
                new Achievements {Id=37, Name="ESL One Belo Horizonte 2018", Placement="1st ", PlayerFK=8},
                new Achievements {Id=38, Name="IEM Katowice 2018", Placement="2nd", PlayerFK=8},
                new Achievements {Id=39, Name="ECS Season 4 Finals", Placement="1st", PlayerFK=8},
                new Achievements {Id=40, Name="DreamHack Open Cluj-Napoca 2015", Placement="Group stage", PlayerFK=8},

                new Achievements {Id=41, Name="ESL One Cologne 2018", Placement="3rd", PlayerFK=9},
                new Achievements {Id=42, Name="ESL One Belo Horizonte 2018", Placement="1st ", PlayerFK=9},
                new Achievements {Id=43, Name="IEM Katowice 2018", Placement="2nd", PlayerFK=9},
                new Achievements {Id=44, Name="ECS Season 4 Finals", Placement="1st", PlayerFK=9},
                new Achievements {Id=45, Name="DreamHack Open Cluj-Napoca 2015", Placement="2nd", PlayerFK=9},

                new Achievements {Id=46, Name="ESL One Cologne 2018", Placement="3rd", PlayerFK=10},
                new Achievements {Id=47, Name="ESL One Belo Horizonte 2018", Placement="1st ", PlayerFK=10},
                new Achievements {Id=48, Name="IEM Katowice 2018", Placement="2nd", PlayerFK=10},
                new Achievements {Id=49, Name="ECS Season 1 Finals", Placement="3rd", PlayerFK=10},
                new Achievements {Id=50, Name="DreamHack Open Cluj-Napoca 2015", Placement="1/4 final", PlayerFK=10},

                //List of Achivements of each player on team Renegades

                new Achievements {Id=51, Name="ESL One Cologne 2015", Placement="Group stage", PlayerFK=11},
                new Achievements {Id=52, Name="ESL One Katowice 2015", Placement="Group stage", PlayerFK=11},
                new Achievements {Id=53, Name="IEM Gamescom 2015", Placement="3rd", PlayerFK=11},

                new Achievements {Id=54, Name="ESL One Cologne 2015", Placement="Group stage", PlayerFK=12},
                new Achievements {Id=55, Name="ESL One Katowice 2015", Placement="Group stage", PlayerFK=12},
                new Achievements {Id=56, Name="IEM Gamescom 2015", Placement="3rd", PlayerFK=12},

                new Achievements {Id=57, Name="ESL One Cologne 2015", Placement="Group stage", PlayerFK=13},

                new Achievements {Id=58, Name="Não apresenta resultados", Placement="ND", PlayerFK=14},

                new Achievements {Id=59, Name="ELEAGUE Season 2", Placement="3rd", PlayerFK=15},
                new Achievements {Id=60, Name="IEM San Jose 2015", Placement="3rd ", PlayerFK=15},
                new Achievements {Id=61, Name="DreamHack Open Cluj-Napoca 2015", Placement="3rd", PlayerFK=15},


                //List of Achivements of each player on team North

                new Achievements {Id=62, Name="DreamHack Open Valencia 2018", Placement="1st", PlayerFK=16},
                new Achievements {Id=63, Name="DreamHack Open Summer 2018", Placement="3rd ", PlayerFK=16},
                new Achievements {Id=64, Name="StarSeries i-League Season 5", Placement="3rd", PlayerFK=16},
                new Achievements {Id=65, Name="DreamHack Open Tours 2018", Placement="1st", PlayerFK=16},
                new Achievements {Id=66, Name="ELEAGUE CS:GO Premier 2017", Placement="3rd", PlayerFK=16},

                new Achievements {Id=67, Name="DreamHack Open Valencia 2018", Placement="3rd", PlayerFK=17},
                new Achievements {Id=68, Name="DreamHack Open Summer 2018", Placement="1st ", PlayerFK=17},
                new Achievements {Id=69, Name="StarSeries i-League Season 5", Placement="3rd", PlayerFK=17},
                new Achievements {Id=70, Name="DreamHack Open Tours 2018", Placement="1st", PlayerFK=17},
                new Achievements {Id=71, Name="ELEAGUE CS:GO Premier 2017", Placement="3rd", PlayerFK=17},

                new Achievements {Id=72, Name="DreamHack Open Valencia 2018", Placement="3rd", PlayerFK=18},
                new Achievements {Id=73, Name="DreamHack Open Summer 2018", Placement="1st ", PlayerFK=18},
                new Achievements {Id=74, Name="StarSeries i-League Season 5", Placement="3rd", PlayerFK=18},
                new Achievements {Id=75, Name="DreamHack Open Tours 2018", Placement="1st", PlayerFK=18},
                new Achievements {Id=76, Name="ELEAGUE CS:GO Premier 2017", Placement="3rd", PlayerFK=18},

                new Achievements {Id=77, Name="DreamHack Open Valencia 2018", Placement="3rd", PlayerFK=19},
                new Achievements {Id=78, Name="DreamHack Open Summer 2018", Placement="1st ", PlayerFK=19},
                new Achievements {Id=79, Name="StarSeries i-League Season 5", Placement="3rd", PlayerFK=19},
                new Achievements {Id=80, Name="DreamHack Open Tours 2018", Placement="1st", PlayerFK=19},
                new Achievements {Id=81, Name="ELEAGUE CS:GO Premier 2017", Placement="3rd", PlayerFK=19},

                new Achievements {Id=82, Name="DreamHack Open Valencia 2018", Placement="3rd", PlayerFK=20},
                new Achievements {Id=83, Name="StarSeries i-League Season 5", Placement="3rd", PlayerFK=20},
                new Achievements {Id=84, Name="DreamHack Open Tours 2018", Placement="1st", PlayerFK=20},
            };

            ListAchivements.ForEach(t => context.Achievements.AddOrUpdate(tt => tt.Id, t));
            context.SaveChanges();

            var ListStatistics = new List<Statistics> {
                //Statistics of players of mouseSports

                new Statistics {Id=1,HS="40.3%", Rating="1.02", MapsPlayed=71,TotalDeaths=20923, TotalKills=22572,DeadthsRound="0.69", KillsRound="0.65",  RoundsContributed="68.7%",  PlayerFK=1 },
                new Statistics {Id=2,HS="29.5%", Rating="1.11", MapsPlayed=60,TotalDeaths=13681, TotalKills=16407, DeadthsRound="0.64", KillsRound="0.73",  RoundsContributed="68.4%", PlayerFK=2 },
                new Statistics {Id=3,HS="52.7%", Rating="1.07", MapsPlayed=71,TotalDeaths=6679, TotalKills=7601, DeadthsRound="0.61", KillsRound="0.68",  RoundsContributed="71.3%", PlayerFK=3},
                new Statistics {Id=4,HS="47.6%", Rating="1.11", MapsPlayed=71,TotalDeaths=16422, TotalKills=18148,DeadthsRound="0.67", KillsRound="0.73",  RoundsContributed="69.4%", PlayerFK=4},
                new Statistics {Id=5,HS="44.2%", Rating="1.01", MapsPlayed=63,TotalDeaths=22612, TotalKills=24825, DeadthsRound="0.69", KillsRound="0.66",  RoundsContributed="66.3%", PlayerFK=5},

               //Statistics of players of FAZE

                new Statistics {Id=6,HS="52.0%", Rating="1.11", MapsPlayed=63,TotalDeaths=16607, TotalKills=17968,DeadthsRound="0.67", KillsRound="0.71",  RoundsContributed="72.0%", PlayerFK=6 },
                new Statistics {Id=7,HS="43.4%", Rating="0.96", MapsPlayed=64,TotalDeaths=22656, TotalKills=21514,DeadthsRound="0.67", KillsRound="0.61",  RoundsContributed="67.9%", PlayerFK=7 },
                new Statistics {Id=8,HS="44.3%", Rating="1.28", MapsPlayed=64,TotalDeaths=15872, TotalKills=19246, DeadthsRound="0.61", KillsRound="0.84",  RoundsContributed="75.0%", PlayerFK=8},
                new Statistics {Id=9,HS="28.8%", Rating="1.13", MapsPlayed=64,TotalDeaths=19807, TotalKills=24825, DeadthsRound="0.62", KillsRound="0.74",  RoundsContributed="71.2%", PlayerFK=9},
                new Statistics {Id=10,HS="60.9%", Rating="1.16", MapsPlayed=5,TotalDeaths=18183, TotalKills=21175, DeadthsRound="0.71", KillsRound="0.78",  RoundsContributed="75.0%", PlayerFK=10},

                
               //Statistics of players of Renegades

                new Statistics {Id=11,HS="52.6%", Rating="1.01", MapsPlayed=66,TotalDeaths=11365, TotalKills=11628, DeadthsRound="0.68", KillsRound="0.65",  RoundsContributed="69.6%",PlayerFK=11 },
                new Statistics {Id=12,HS="53.2%", Rating="1.13", MapsPlayed=66,TotalDeaths=10268, TotalKills=11661,DeadthsRound="0.63", KillsRound="0.71",  RoundsContributed="71.1%", PlayerFK=12 },
                new Statistics {Id=13,HS="43.8%", Rating="0.99", MapsPlayed=66,TotalDeaths=10962, TotalKills=10829, DeadthsRound="0.68", KillsRound="0.62",  RoundsContributed="70.1%", PlayerFK=13},
                new Statistics {Id=14,HS="30.5%", Rating="1.01", MapsPlayed=66,TotalDeaths=10578, TotalKills=10955, DeadthsRound="0.64", KillsRound="0.64",  RoundsContributed="68.6%", PlayerFK=14},
                new Statistics {Id=15,HS="55.0%", Rating="1.13", MapsPlayed=5,TotalDeaths=12140, TotalKills=12645, DeadthsRound="0.68", KillsRound="0.73",  RoundsContributed="71.9%", PlayerFK=15},

                //Statistics of players of North

                new Statistics {Id=16,HS="43.2%", Rating="0.96", MapsPlayed=72,TotalDeaths=24986, TotalKills=22121,  DeadthsRound="0.70", KillsRound="0.62",  RoundsContributed="68.2%", PlayerFK=16 },
                new Statistics {Id=17,HS="56.0%", Rating="1.08", MapsPlayed=72,TotalDeaths=18306, TotalKills=19214,DeadthsRound="0.63", KillsRound="0.68",  RoundsContributed="70.0%",  PlayerFK=17 },
                new Statistics {Id=18,HS="43.5%", Rating="1.17", MapsPlayed=72,TotalDeaths=10444, TotalKills=11911, DeadthsRound="0.63", KillsRound="0.76",  RoundsContributed="74.4%", PlayerFK=18},
                new Statistics {Id=19,HS="56.5%", Rating="1.13", MapsPlayed=72,TotalDeaths=18014, TotalKills=19925, DeadthsRound="0.66", KillsRound="0.73",  RoundsContributed="70.9%", PlayerFK=19},
                new Statistics {Id=20,HS="27.1%", Rating="1.07", MapsPlayed=63,TotalDeaths=7943, TotalKills=9230, DeadthsRound="0.64", KillsRound="0.68",  RoundsContributed="69.7%", PlayerFK=20},

            };

            ListStatistics.ForEach(t => context.Statistics.AddOrUpdate(tt => tt.Id, t));
            context.SaveChanges();
        }
    }
}
