using CsGoPedia.DTO.Players;
using GamerPedia.DTO.Teams;
using GamerPedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GamerPedia.Controllers
{
    public class PlayersController : ApiController
    {
        public AppDB db = new AppDB();

        //get api/players/id with statistics and achivements
        [HttpGet, Route("api/players/{id}")]
        public IHttpActionResult GetPlayer(int? Id) {

            var player = db.Players
                .Where(p => p.Id == Id)
                .Select(p => new GetSinglePlayerOfTeam {
                    Id = p.Id,
                    Name = p.Name,
                    BirthDate = p.BirthDate,
                    Coutry = p.Coutry,
                    Hltv = p.Hltv,
                    ImgCountry = p.ImgCountry,
                    Instagram = p.Instagram,
                    Nickname = p.Nickname,
                    Photo = p.Photo,
                    Role = p.Role,
                    Team = p.Team,
                    TotalWinnings = p.TotalWinnings,
                    VideoHighlight = p.VideoHighlight,
                    ListAchievements = p.ListAchievements
                        .Select(a => new GetSinglePlayerOfTeam.GetAchievements {
                            Id = a.Id,
                            Name = a.Name,
                            Placement = a.Placement
                        }).ToList(),
                    ListStatistics = p.ListStatistics
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
        public IHttpActionResult GetPlayers() {

            var players = db.Players.Select(
                p => new GetAllPlayers {
                    Id = p.Id,
                    Name = p.Name,
                    BirthDate = p.BirthDate,
                    Coutry = p.Coutry,
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
                .OrderBy(p=>p.Name)
                .ToList();

            if(players.Count() == 0) {
                return NotFound();
            }

            return Ok(players);
        }
    }
}
