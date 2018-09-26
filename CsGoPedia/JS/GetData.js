// fetch para buscar todas as equipas
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

// fetch para buscar uma única equipa
function GetSingleTeam(TeamSingleId){
    var T = "api/teams/"+TeamSingleId;

    return fetch(T, { headers: { Accept: 'application/json' } })
    .then(function (resposta) {
        //debugger;
        if (resposta.status === 200) {

            return resposta.json();

        } else {
            return Promise.reject(new Error("Error to get Teams"));
        }
    });
}

//fetch para buscar os jogadores de uma determinada equipa

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


//Fetch para buscar todos os jogadores e também irá servir para filtro 
function GetPlayers(type, str){
    var Players;

    debugger;
    if (type == null && str == null) {
        Players = "api/players";
    }

    else {
        Players = "api/players/?type=" + type + "&str=" + str;
    }

    var ps =fetch(Players, { headers: { Accept: 'application/json' } })

    .then(function (resposta) {
        if (resposta.status === 200) {
            return resposta.json();
        } else {
            return Promise.reject(new Error("Error to get Players"));
        }
    });
    return ps;
}

// fetch para ir buscar um único jogador
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