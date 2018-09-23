using CsGoPedia.DTO.Players;
using GamerPedia.DTO.Teams;
using GamerPedia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GamerPedia.Controllers {
    public class PlayersController : ApiController {
        public AppDB db = new AppDB();

        //get api/players/id with statistics and achivements
        [HttpGet, Route("api/players/{id}")]
        public IHttpActionResult GetPlayer(int? id) {

            if(id == null) {
                return BadRequest();
            }

            var player = db.Players
                .Where(p => p.Id == id)
                .Select(p => new GetSinglePlayerOfTeam {
                    Id = p.Id,
                    Name = p.Name,
                    BirthDate = p.BirthDate,
                    Country = p.Country,
                    Hltv = p.Hltv,
                    ImgCountry = p.ImgCountry,
                    Instagram = p.Instagram,
                    Nickname = p.Nickname,
                    Photo = p.Photo,
                    Role = p.Role,
                    Team = p.Team,
                    TotalWinnings = p.TotalWinnings,
                    VideoHighlight = p.VideoHighlight,
                    Achievements = p.ListAchievements
                        //.Where(a => a.PlayerFK == p.Id)
                        .Select(a => new GetSinglePlayerOfTeam.GetAchievements {

                            Id = a.Id,
                            Name = a.Name,
                            Placement = a.Placement

                        }).ToList(),

                    Statistics = p.ListStatistics
                                 .Select(s => new GetSinglePlayerOfTeam.GetStatistics {
                                     Id = s.Id,
                                     DeadthsRound = s.DeadthsRound,
                                     HS = s.HS,
                                     KillsRound = s.KillsRound,
                                     MapsPlayed = s.MapsPlayed,
                                     Rating = s.Rating,
                                     RoundsContributed = s.RoundsContributed,
                                     TotalDeaths = s.TotalDeaths,
                                     TotalKills = s.TotalKills
                                 }).ToList(),

                }).FirstOrDefault();

            if(player == null) {
                return NotFound();
            }

            return Ok(player);
        }
        
        //get api/players/id with statistics and achivements
        [HttpGet, Route("api/players")]
        public IHttpActionResult GetPlayers(string type = "", string str = "") {
            
            var q = db.Players;

            var players = q.Select(
                p => new GetAllPlayers {
                    Id = p.Id,
                    Name = p.Name,
                    BirthDate = p.BirthDate,
                    Country = p.Country,
                    Hltv = p.Hltv,
                    ImgCountry = p.ImgCountry,
                    Instagram = p.Instagram,
                    Nickname = p.Nickname,
                    Photo = p.Photo,
                    Role = p.Role,
                    Team = p.Team,
                    TotalWinnings = p.TotalWinnings,
                    VideoHighlight = p.VideoHighlight
                })
            .OrderBy(p => p.Id)
            .ToList();


            if(type == "country" && str!=null) {
               players = players.Where(p => p.Country.ToLower().Contains(str.ToLower())).ToList();
            }

            if(type == "team" && str!=null) {
                players = players.Where(p => p.Team.ToLower().Contains(str.ToLower())).ToList();
            }

            if(type == "name" && str != null) {
                players = players.Where(p => p.Name.ToLower().Contains(str.ToLower())).ToList();
            }

            if(type == "role" && str != null) {
                players = players.Where(p => p.Role.ToLower().Contains(str.ToLower())).ToList();
            }



            if(players.Count() == 0) {
                return NotFound();
            }
            return Ok(players);
        }
    }
}