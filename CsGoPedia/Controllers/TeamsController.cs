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
    public class TeamsController : ApiController {
        public AppDB db = new AppDB();

        //get api/teams
        [HttpGet, Route("api/Teams")]
        public IHttpActionResult GetTeams() {

            var teams = db.Teams.Select(
                t => new GetAllTeams {
                    Id = t.Id,
                    Name = t.Name,
                    Logo = t.Logo,
                    WorldRanking = t.WorldRanking,
                    RegionPhoto = t.RegionPhoto
                })
                .OrderBy(t => t.Id)
                .ToList();

            if(teams.Count() == 0) {
                return NotFound();
            }
            return Ok(teams);
        }

        //get api/teams/1
        [HttpGet, Route("api/teams/{id}")]
        public IHttpActionResult GetTeam(int? Id) {

            if(Id == null) {
                return BadRequest();
            }

            var team = db.Teams
                .Where(t => t.Id == Id)
                .Select(
                    t => new GetSingleTeam {
                        Id = t.Id,
                        Name = t.Name,
                        RegionPhoto = t.RegionPhoto,
                        Coach = t.Coach,
                        CoachPhoto = t.CoachPhoto,
                    })
                .ToList();

            if(team == null) {
                return NotFound();

            }

            return Ok(team);
        }

        //get api/team/listplayers

        [HttpGet, Route("api/teams/{id}/players")]
        public IHttpActionResult GetPlayers(int? Id) {

            if(Id == null) {
                return BadRequest();
            }

            var players = db.Players
                .Where(p => p.TeamFK == Id)
                .Select(
                    p => new GetAllPlayersOfTeam {
                        Id = p.Id,
                        Name = p.Name,
                        Nickname = p.Nickname,
                        BirthDate = p.BirthDate,
                        Coutry = p.Coutry,
                        ImgCountry = p.ImgCountry,
                        Team = p.Team,
                        Role = p.Role,
                        Instagram = p.Instagram,
                        Hltv = p.Hltv,
                        Photo = p.Photo,
                        VideoHighlight = p.VideoHighlight,
                        TotalWinnings = p.TotalWinnings
                    })
                    .OrderBy(p => p.Name)
                    .ToList();


            if(players == null) {
                return NotFound();
            }

            return Ok(players);
        }
    }
}
