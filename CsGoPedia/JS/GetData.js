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