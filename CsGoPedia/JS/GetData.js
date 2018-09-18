//function getPlayers(Name) {
//    let url;
//    if (Name === null) {
//        url = "/api/players/";
//    }
//    else {
//        url = "/api/champions/?Name=" + Name;
//    }
//    return fetch(url, { headers: { Accept: "application/json" } })
//        .then(function(resposta) {
//            if (resposta.status === 200) {
//                return resposta.json();
//            } else {
//                return Promise.reject(new Error("Erro ao obter champs"));
//            }
//            });
    

//}


function GetTeams(){
    var Teams = "api/teams";

    return fetch(Teams, { headers: { Accept: 'application/json' } })
    .then(function (resposta) {
        //debugger;
        if (resposta.status === 200) {

            return resposta.json();

        } else {
            return Promise.reject(new Error("Error to get Teams"));
        }
    });
}

function GetTeam(TeamId){
    var Team= "api/teams/"+TeamId+"/players";

    return fetch(Team, { headers: { Accept: 'application/json' } })
    .then(function (resposta) {
        //debugger;
        if (resposta.status === 200) {

            return resposta.json();

        } else {
            return Promise.reject(new Error("Error to get Teams"));
        }
    });
}


function GetPlayers(){

    var Players = "api/players";
    return fetch(Players, { headers: { Accept: 'application/json' } })
    .then(function (resposta) {
        if (resposta.status === 200) {
            return resposta.json();
        } else {
            return Promise.reject(new Error("Error to get Players"));
        }
    });
}

function GetPlayer(PlayerId){

    var Player = "/api/players/"+PlayerId;
    return fetch(Player, { headers: { Accept: 'application/json' } })
    .then(function (resposta) {
        if (resposta.status === 200) {
            return resposta.json();
        } else {
            return Promise.reject(new Error("Error to get Player"));
        }
    });
}