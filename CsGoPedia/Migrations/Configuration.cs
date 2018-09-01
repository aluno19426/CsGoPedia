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
                new Teams {Id = 1, Name = "Mousesports", Localization="Germany",  LocalizationPhoto="https://liquipedia.net/commons/images/8/8f/De.png", Region="Europe", RegionPhoto="https://liquipedia.net/commons/images/c/cc/Eu.png", CoachPhoto="https://liquipedia.net/commons/images/thumb/7/7a/Lmbt_at_StarLadder_i-League_StarSeries_S4.jpg/600px-Lmbt_at_StarLadder_i-League_StarSeries_S4.jpg", Coach="Sergey Bezhanov", TotalEarnings="1,829,391$", Logo="https://liquipedia.net/commons/images/thumb/7/7a/Mouz_logo.png/800px-Mouz_logo.png"},

                //team Faze Clan
                new Teams {Id = 2, Name = "FaZe Clan", Localization="United States",  LocalizationPhoto="https://liquipedia.net/commons/images/2/2f/Us.png", Region="Europe", RegionPhoto="https://liquipedia.net/commons/images/c/cc/Eu.png", CoachPhoto="https://liquipedia.net/commons/images/thumb/0/04/RobbaN_at_StarLadder_i-League_StarSeries_S4.jpg/600px-RobbaN_at_StarLadder_i-League_StarSeries_S4.jpg", Coach="Robert Dahlström", TotalEarnings="2,507,347$", Logo="https://liquipedia.net/commons/images/thumb/a/a4/FaZe_Clan.png/600px-FaZe_Clan.png"},

                //team Renegades
                new Teams {Id = 3, Name = "Renegades", Localization="Australia",  LocalizationPhoto="https://liquipedia.net/commons/images/e/e6/Au.png", Region="North America", RegionPhoto="https://liquipedia.net/commons/images/5/57/North_America.png", CoachPhoto="https://liquipedia.net/commons/images/thumb/0/07/Ryu_at_DH_Montreal_2017.jpg/600px-Ryu_at_DH_Montreal_2017.jpg", Coach="Steve Rattacasa", TotalEarnings="547,198$", Logo="https://liquipedia.net/commons/images/thumb/8/8e/Renegades.svg/600px-Renegades.svg.png"},

                //team North
                new Teams {Id = 4, Name = "North", Localization="Denmark",  LocalizationPhoto="https://liquipedia.net/commons/images/0/06/Dk.png", Region="Europe", RegionPhoto="https://liquipedia.net/commons/images/c/cc/Eu.png", CoachPhoto="https://liquipedia.net/commons/images/thumb/7/78/Ave_at_StarLadder_i-League_StarSeries_S5.jpg/600px-Ave_at_StarLadder_i-League_StarSeries_S5.jpg", Coach="Alexander Holdt", TotalEarnings="670,250$", Logo="https://liquipedia.net/commons/images/e/eb/North.png"},
            };

            ListTeam.ForEach(t => context.Teams.AddOrUpdate(tt => tt.Name, t));
            context.SaveChanges();

            var ListPlayers = new List<Players> {
                //List of players of team MouseSports

                new Players {Id=1, Name="Chris de Jong", Nickname="chrisJ", BirthDate="May 25, 1990 (age 28)", ImgCountry="https://liquipedia.net/commons/images/9/98/Nl.png" ,Coutry="Netherlands", Hltv="https://www.hltv.org/player/2730/chrisJ", Instagram="https://www.instagram.com/chrisjcsgo_/", Photo="https://liquipedia.net/commons/images/thumb/0/0b/ChrisJ_at_DH_Masters_Marseille_18.jpg/600px-ChrisJ_at_DH_Masters_Marseille_18.jpg",Role="In-game leader/Rifler", Team="mousesports", TotalWinnings="$288,428", VideoHighlight="https://www.youtube.com/watch?v=XqrCsQcSwsU", TeamFK=1},

                new Players {Id=2,Name="Tomáš Šťastný", Nickname="oskar", BirthDate="June 27, 1991 (age 27)", ImgCountry="https://liquipedia.net/counterstrike/Category:Czech_Republic" ,Coutry="Czech Republic", Hltv="https://www.hltv.org/player/798/oskar", Instagram="https://www.instagram.com/oskartommy", Photo="https://liquipedia.net/commons/images/thumb/2/24/Oskar_DHW17.jpg/600px-Oskar_DHW17.jpg",Role="AWPer", Team="mousesports", TotalWinnings="$251,764", VideoHighlight="https://www.youtube.com/watch?v=0xXO26cGQl0", TeamFK=1},

                new Players {Id=3,Name="Robin Kool",  Nickname="ropz",BirthDate="December 22, 1999 (age 18)", ImgCountry="https://liquipedia.net/commons/images/5/5e/Ee.png" ,Coutry="Estonia", Hltv="https://www.hltv.org/player/11816/ropz", Instagram="https://www.instagram.com/ropzicle/", Photo="https://liquipedia.net/commons/images/thumb/a/a6/Ropz_at_DreamHack_Winter_Open_2017.jpg/600px-Ropz_at_DreamHack_Winter_Open_2017.jpg",Role="Rifler (lurker)", Team="mousesports", TotalWinnings="$198,773", VideoHighlight="https://www.youtube.com/watch?v=N4890ImohvA", TeamFK=1},

                new Players {Id=4,Name="Miikka Kemppi",  Nickname="suNny",BirthDate="August 24, 1994 (age 23)", ImgCountry="https://liquipedia.net/commons/images/7/70/Fi.png" ,Coutry="Finland", Hltv="https://www.hltv.org/player/5479/suNny", Instagram="https://www.instagram.com/sunnycsgo/", Photo="https://liquipedia.net/commons/images/thumb/a/a4/SuNny_at_StarSeries_%26_i-League_S5.jpg/600px-SuNny_at_StarSeries_%26_i-League_S5.jpgg",Role="Rifler (entry fragger)", Team="mousesports", TotalWinnings="$205,826", VideoHighlight="https://www.youtube.com/watch?v=fPVN3vteCkw", TeamFK=1},


                new Players {Id=5,Name="Janusz Pogorzelski",  Nickname="Snax",BirthDate="July 5, 1993 (age 25)", ImgCountry="https://liquipedia.net/counterstrike/Category:Poland" ,Coutry="Poland", Hltv="https://www.hltv.org/player/2553/Snax", Instagram="https://www.instagram.com/snax1337/", Photo="https://liquipedia.net/commons/images/thumb/3/33/Snax_at_StarLadder_i-League_StarSeries_S4.jpg/600px-Snax_at_StarLadder_i-League_StarSeries_S4.jpg",Role="Rifler/AWPer", Team="mousesports", TotalWinnings="$576,556", VideoHighlight="https://www.youtube.com/watch?v=1eADWcd2idM", TeamFK=1},

                  //List of players of team FazeClan

                new Players {Id=6, Name="Håvard Nygaard", Nickname="rain", BirthDate="August 27, 1994 (age 23)", ImgCountry="https://liquipedia.net/counterstrike/Category:Norway" ,Coutry="Norway", Hltv="https://www.hltv.org/player/8183/rain", Instagram="https://www.instagram.com/faze_raincs/", Photo="https://liquipedia.net/commons/images/thumb/0/01/Rain_at_DH_Master_Marseille_2018.jpg/600px-Rain_at_DH_Master_Marseille_2018.jpg",Role="Rifler (entry fragger)", Team="FaZe Clan", TotalWinnings="$532,296", VideoHighlight="https://www.youtube.com/watch?v=ifdtAujldbg", TeamFK=2},

                new Players {Id=7,Name="Finn Andersen", Nickname="karrigan", BirthDate="April 14, 1990 (age 28)", ImgCountry="https://liquipedia.net/counterstrike/Category:Denmark" ,Coutry="Denmark", Hltv="https://www.hltv.org/player/429/karrigan", Instagram="https://www.instagram.com/karrigancsgo/", Photo="https://liquipedia.net/commons/images/thumb/1/18/Karrigan_at_Starladder_iLeague_Starseries_Season_4.jpg/600px-Karrigan_at_Starladder_iLeague_Starseries_Season_4.jpg",Role="In-game leader/Rifler", Team="FaZe Clan", TotalWinnings="$695,992", VideoHighlight="https://www.youtube.com/watch?v=FgLGFNtFQFo", TeamFK=2},

                new Players {Id=8,Name="Nikola Kovač",  Nickname="NiKo",BirthDate="February 16, 1997 (age 21)", ImgCountry="https://liquipedia.net/counterstrike/Category:Bosnia_and_Herzegovina" ,Coutry="Bosnia and Herzegovina", Hltv="https://www.hltv.org/player/3741/NiKo", Instagram="https://liquipedia.net/commons/images/thumb/a/a4/NiKo_at_ELEAGUE_Major_Boston_2018.jpg/600px-NiKo_at_ELEAGUE_Major_Boston_2018.jpg",Role="Rifler (lurker)/AWPer", Team="FaZe Clan", TotalWinnings="$522,396", VideoHighlight="hhttps://www.youtube.com/watch?v=QOuCleKrzEw", TeamFK=2},

                new Players {Id=9,Name="Ladislav Kovács",  Nickname="GuardiaN ",BirthDate="July 9, 1991 (age 27)", ImgCountry="https://liquipedia.net/commons/images/1/11/Sk.png" ,Coutry="Slovakia", Hltv="https://www.hltv.org/player/2757/GuardiaN", Instagram="https://www.instagram.com/ladislav.xkovacs/", Photo="https://liquipedia.net/commons/images/thumb/5/50/GuardiaN_at_ELEAGUE_Major_Boston_2018.jpg/600px-GuardiaN_at_ELEAGUE_Major_Boston_2018.jpg",Role="AWPer", Team="Faze Clan", TotalWinnings="$644,396", VideoHighlight="https://www.youtube.com/watch?v=rbINtd_NjyE", TeamFK=2},

                new Players {Id=10,Name="Olof Kajbjer Gustafsson",  Nickname="olofmeister",BirthDate="January 31, 1992 (age 26)", ImgCountry="https://liquipedia.net/counterstrike/Category:Sweden" ,Coutry="Sweden", Hltv="https://www.hltv.org/player/2553/Snax", Instagram="https://www.instagram.com/olofkajbjer/", Photo="https://liquipedia.net/commons/images/thumb/e/e2/Olofmeister_at_ELEAGUE_Major_Boston_2018.jpg/600px-Olofmeister_at_ELEAGUE_Major_Boston_2018.jpg",Role="Rifler/AWPer", Team="Faze Clan", TotalWinnings="$675,598", VideoHighlight="https://www.youtube.com/watch?v=6_wLxs2wAZ8", TeamFK=2},

                //List of players of team Renegades

               new Players {Id=11,Name="Aaron Ward",  Nickname="AZR",BirthDate="October 2, 1993 (age 25)", ImgCountry="https://liquipedia.net/commons/images/e/e6/Au.png" ,Coutry="Australia", Hltv="https://www.hltv.org/player/8082/AZR", Instagram="https://www.instagram.com/azr/", Photo="https://liquipedia.net/counterstrike/File:AZR_at_IEM_Season_XIII_Sydney.jpg",Role="In-game leader/Rifler", Team="Renegades", TotalWinnings="$119,120", VideoHighlight="https://www.youtube.com/watch?v=Lzfr8lPNuw0", TeamFK=3},

               new Players {Id=12,Name="Justin Savage",  Nickname="jks ",BirthDate="December 12, 1995 (age 22)", ImgCountry="https://liquipedia.net/commons/images/e/e6/Au.png" ,Coutry="Australia", Hltv="https://www.hltv.org/player/4679/jks", Instagram="https://www.instagram.com/jks_cs/", Photo="https://liquipedia.net/commons/images/thumb/2/26/Jks_at_StarLadder_i-League_StarLadder_S4.jpg/600px-Jks_at_StarLadder_i-League_StarLadder_S4.jpg",Role="Rifler", Team="Renegades", TotalWinnings="$119,120", VideoHighlight="https://www.youtube.com/watch?v=ODjHNE-4A8g", TeamFK=3},

               new Players {Id=13,Name="Karlo Pivac",  Nickname="USTILO",BirthDate="August 10, 1993 (age 24)", ImgCountry="https://liquipedia.net/commons/images/e/e6/Au.png" ,Coutry="Australia", Hltv="https://www.hltv.org/player/8771/USTILO", Instagram="https://www.instagram.com/ustilocsgo/", Photo="https://liquipedia.net/commons/images/thumb/b/b7/USTILO_DreamHack_Master_Malo_2017.jpg/600px-USTILO_DreamHack_Master_Malo_2017.jpg",Role="Rifler", Team="Renegades", TotalWinnings="$119,120", VideoHighlight="https://www.youtube.com/watch?v=WWo0oYleg1c", TeamFK=3},

               new Players {Id=14,Name="Noah Francis",  Nickname="Nifty",BirthDate="November 23, 1997 (age 20)", ImgCountry="https://liquipedia.net/commons/images/2/2f/Us.png" ,Coutry="United States", Hltv="https://www.hltv.org/player/9069/Nifty", Instagram="https://www.instagram.com/buzzfeednifty/?hl=pt", Photo="https://liquipedia.net/commons/images/thumb/b/b9/Nifty_at_StarLadder_i-League_StarSeries_S4.jpg/600px-Nifty_at_StarLadder_i-League_StarSeries_S4.jpg",Role="AWPer/In-game leader", Team="Renegades", TotalWinnings="$88,817", VideoHighlight="https://www.youtube.com/watch?v=yLqrjB2jk74", TeamFK=3},

               new Players {Id=15,Name="Joakim Myrbostad",  Nickname="jkaem",BirthDate="February 27, 1994 (age 24)", ImgCountry="https://liquipedia.net/commons/images/0/04/No.png" ,Coutry="Norway", Hltv="https://www.hltv.org/player/8248/jkaem", Instagram="https://www.instagram.com/jkaem23/", Photo="https://liquipedia.net/commons/images/thumb/8/85/Jkaem_at_StarLadder_i-League_StarSeries_S4.jpg/600px-Jkaem_at_StarLadder_i-League_StarSeries_S4.jpg",Role="Rifler (lurker)", Team="Renegades", TotalWinnings="$79,110", VideoHighlight="https://www.youtube.com/watch?v=-KhBWM-0FZk", TeamFK=3},

               // List of players of team North

               new Players {Id=16,Name="Mathias Sommer Lauridsen",  Nickname="MSL",BirthDate="December 6, 1994 (age 23)", ImgCountry="https://liquipedia.net/commons/images/0/06/Dk.png" ,Coutry="Denmark", Hltv="https://www.hltv.org/player/7156/MSL", Instagram="https://www.instagram.com/mathiassommerlauridsen/", Photo="https://liquipedia.net/commons/images/thumb/7/70/MSL_at_StarLadder_i-League_StarSeries_Season_3.jpg/600px-MSL_at_StarLadder_i-League_StarSeries_Season_3.jpg",Role="In-game leader/Rifler (lurker)", Team="North", TotalWinnings="$296,096", VideoHighlight="https://www.youtube.com/watch?v=CbXBJ302N5Q", TeamFK=4},

               new Players {Id=17,Name="Philip Aistrup Larsen",  Nickname="aizy ",BirthDate="June 4, 1996 (age 22)", ImgCountry="https://liquipedia.net/commons/images/0/06/Dk.png" ,Coutry="Denmark", Hltv="https://www.hltv.org/player/8095/aizy", Instagram="https://www.instagram.com/aizydj/?hl=pt", Photo="https://liquipedia.net/commons/images/thumb/6/62/Aizy_at_EPICENTER_2017.jpg/600px-Aizy_at_EPICENTER_2017.jpg",Role="Rifler", Team="North", TotalWinnings="$234,228", VideoHighlight="https://www.youtube.com/watch?v=qATvTfPTmLo", TeamFK=4},

               new Players {Id=18,Name="Valdemar Bjørn Vangså",  Nickname="valde",BirthDate="June 12, 1995 (age 23)", ImgCountry="https://liquipedia.net/commons/images/0/06/Dk.png" ,Coutry="Denmark", Hltv="https://www.hltv.org/player/9031/valde", Instagram="https://www.instagram.com/valdeCS/", Photo="https://liquipedia.net/commons/images/thumb/e/e3/Valde_at_ESL_Pro_League_Season_6_Finals.jpg/600px-Valde_at_ESL_Pro_League_Season_6_Finals.jpg",Role="Rifler", Team="North", TotalWinnings="$146,387", VideoHighlight="https://www.youtube.com/watch?v=TUjXKVmhc_8", TeamFK=4},

               new Players {Id=19,Name="Markus Kjærbye",  Nickname="Kjaerbye",BirthDate="April 27, 1998 (age 20)", ImgCountry="https://liquipedia.net/commons/images/0/06/Dk.png" ,Coutry="Denmark", Hltv="https://www.hltv.org/player/8394/Kjaerbye", Instagram="https://www.instagram.com/markuskjaerbye/", Photo="https://liquipedia.net/commons/images/thumb/a/a5/Kjaerbye_StarSeries_Season_5_2018.jpg/600px-Kjaerbye_StarSeries_Season_5_2018.jpg",Role="Rifler (entry fragger)", Team="North", TotalWinnings="$508,858", VideoHighlight="https://www.youtube.com/watch?v=u8FXWfyUGls", TeamFK=4},

                new Players {Id=20,Name="Daniel Mertz",  Nickname="mertz",BirthDate="September 29, 1998 (age 19)", ImgCountry="https://liquipedia.net/commons/images/0/06/Dk.png" ,Coutry="Denmark", Hltv="https://www.hltv.org/player/9895/mertz", Instagram="https://www.instagram.com/mertz98/", Photo="https://liquipedia.net/commons/images/thumb/a/a1/Mertz_at_DH_Tours_2018.jpg/600px-Mertz_at_DH_Tours_2018.jpg",Role="AWPer", Team="North", TotalWinnings="$38,035", VideoHighlight="https://www.youtube.com/watch?v=7J-q58N6F48", TeamFK=4},
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
