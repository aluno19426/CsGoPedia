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