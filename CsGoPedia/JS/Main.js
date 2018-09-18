document.addEventListener("DOMContentLoaded", function main(e) {

    inic();
});

function inic() {
    MainPage();
    
}
/*
para o filtro dos jogadores
function Procura() {
    var input = document.querySelector("#search-field");
    input.addEventListener("input", async function () {
        var filtro = input.value;
        divPrincipal.innerHTML = "";
        if (filtro.length === 0) {
            load();
        } else {
            const Player = await GetPlayers(filtro);
            ShowPlayers(Players);
        }
    });
} */

// Página inicial 
function MainPage() {

    // var AllPlayers = document.getElementById("AllPlayers").classList.add("hidden");

    var DivVideos = document.getElementById("DivVideos");
    var DivMedia = document.getElementById("Media");

    var DivVideo1 = document.createElement("div");
    DivVideo1.className = "col-md-4";
    var DivVideo2 = document.createElement("div");
    DivVideo2.className = "col-md-4";
    var DivVideo3 = document.createElement("div");
    DivVideo3.className = "col-md-4";
    var DivVideo4 = document.createElement("div");
    DivVideo4.className = "col-md-4";
    var DivVideo5 = document.createElement("div");
    DivVideo5.className = "col-md-4";
    var DivVideo6 = document.createElement("div");
    DivVideo6.className = "col-md-4";

    var Video1 = document.createElement("iframe");
    var Video2 = document.createElement("iframe");
    var Video3 = document.createElement("iframe");
    var Video4 = document.createElement("iframe");
    var Video5 = document.createElement("iframe");
    var Video6 = document.createElement("iframe");

    /*     var SteamImg = document.createElement("img");
        var Steam = document.createElement("a");
        var InstagramImg = document.createElement("img");
        var Instagram = document.createElement("a"); */
    var Me = document.createElement("img");

    Video1.src = "https://www.youtube.com/embed/gbqTR0aSh2M?rel=0";
    Video1.setAttribute("allowFullScreen", "");
    DivVideo1.appendChild(Video1);
    //Video1.className = "col-md-4";
    //Video1.setAttribute("width","250px");
    Video2.src = "https://www.youtube.com/embed/bXewHrp3BeQ?rel=0";
    Video2.setAttribute('allowFullScreen', '');
    DivVideo2.appendChild(Video2);
    //Video2.className = "col-md-4";
    //Video2.setAttribute("width","250px");
    Video3.src = "https://www.youtube.com/embed/swPCjsxpoXw?rel=0";
    Video3.setAttribute('allowFullScreen', '');
    DivVideo3.appendChild(Video3);
    //Video3.className = "col-md-4";
    //Video3.setAttribute("width","250px");
    Video4.src = "https://www.youtube.com/embed/iKmOXwRhTrI?rel=0";
    Video4.setAttribute('allowFullScreen', '');
    //Video4.setAttribute("style", "margin-top:5%");
    DivVideo4.appendChild(Video4);
    //Video4.className = "col-md-4";
    //Video4.setAttribute("width","250px");~

    Video5.src = "https://www.youtube.com/embed/0sMlZL6MVP4";
    Video5.setAttribute('allowFullScreen', '');
    //Video5.setAttribute("style", "margin-top:5%");
    DivVideo5.appendChild(Video5);
    //Video5.className = "col-md-4";

    Video6.src = "https://www.youtube.com/embed/vVIhQCN_Mm4";
    Video6.setAttribute('allowFullScreen', '');
    //Video6.setAttribute("style", "margin-top:5%");
    //Video6.className = "col-md-4";
    DivVideo6.appendChild(Video6);

    Me.src = "./Content/Images/Me.jpg";
    Me.className = "MePhoto";

    var ButtonTeams = document.createElement("button");
    ButtonTeams.className = "btn btn-primary";
    ButtonTeams.setAttribute("style","font-size:36px;background-color:#6351ce;")
    ButtonTeams.textContent= "Teams";

    var ButtonPlayers = document.createElement("button");
    ButtonPlayers.className = "btn btn-primary";
    ButtonPlayers.setAttribute("style","font-size:36px;float:right;background-color:#6351ce;")
    ButtonPlayers.textContent= "Players";

    DivVideos.appendChild(DivVideo1);
    DivVideos.appendChild(DivVideo2);
    DivVideos.appendChild(DivVideo3);
    DivVideos.appendChild(DivVideo4);
    DivVideos.appendChild(DivVideo5);
    DivVideos.appendChild(DivVideo6);
    DivMedia.appendChild(Me);
    DivMedia.appendChild(ButtonTeams);
    DivMedia.appendChild(ButtonPlayers);

    var RedirectPlayers = document.getElementById("RedirectPlayers");
    var RedirectTeams = document.getElementById("RedirectTeams");
    var TitleMiddlePage = document.getElementById("TitleMiddlePage");

    ButtonTeams.addEventListener("click",function(e){
        DivVideos.classList.add("hidden");
        TitleMiddlePage.classList.add("hidden");
        DivMedia.classList.add("hidden");
        
        EcranTeams();
    });

    RedirectTeams.addEventListener("click", function (e) {
        DivVideos.classList.add("hidden");
        TitleMiddlePage.classList.add("hidden");
        DivMedia.classList.add("hidden");
        SinglePlayer.classList.add("hidden");
        AllPlayers.classList.add("hidden");

        // RedirectTeams.classList.add("hidden");

        AllTeams.innerHTML = "";
        SinglePlayer.innerHTML = "";

        EcranTeams();
    });

    RedirectPlayers.addEventListener("click", function (e) {
        DivVideos.classList.add("hidden");
        TitleMiddlePage.classList.add("hidden");
        DivMedia.classList.add("hidden");
        AllPlayers.classList.add("hidden");
        AllTeams.classList.add("hidden");
        SinglePlayer.classList.add("hidden");

        // RedirectTeams.classList.add("hidden");
        AllPlayers.innerHTML = "";
        SinglePlayer.innerHTML = "";
        EcranPlayers();
    });
    
    // RedirectPlayers.addEventListener("click", function (e) {
    //     Video1.classList.add("hidden");
    //     Video2.classList.add("hidden");
    //     Video3.classList.add("hidden");
    //     Video4.classList.add("hidden");
    //     Video5.classList.add("hidden");
    //     Video6.classList.add("hidden");
    //     DivVideos.classList.add("hidden");
    //     DivMedia.classList.add("hidden");
    //     TitleMiddlePage.classList.add("hidden");
    //     Video1.innerHTML = "";
    //     Video2.innerHTML = "";
    //     Video3.innerHTML = "";
    //     Video4.innerHTML = "";
    //     Video5.innerHTML = "";
    //     Video6.innerHTML = "";
    //     DivVideos.innerHTML = "";
    //     DivMedia.innerHTML = "";
    //     TitleMiddlePage.innerHTML = "";
    //     /*      var AllPlayers = document.getElementById("AllPlayers");
    //             AllPlayers.classList.remove("hidden"); */
    //     EcranPlayers();
    //});

    var Clean = document.getElementById("Clean").addEventListener("click",function(e){
        
        /*esconde os divs*/
        DivVideos.classList.remove("hidden");
        DivMedia.classList.remove("hidden");
        TitleMiddlePage.classList.remove("hidden");
        

        AllTeams.classList.add("hidden");
        AllTeams.innerHTML = "";
        SinglePlayer.classList.add("hidden");
        SinglePlayer.innerHTML = ""
        AllPlayers.classList.add("hidden");
    });
}


//Mostra todos os jogadores 
function ShowPlayers(Players) {


/*     para o filtro do jogador
if (Players == null || Players.length === 0) {
        const h1 = document.createElement("h1");
        h1.textContent = "No champions were found.";

        mainDiv.appendChild(h1);
    } */

    var AllPlayers = document.getElementById("AllPlayers");
    AllPlayers.classList.remove("hidden");

    for (var i = 0; i < Players.length; i++) {

        var Player = Players[i];

        var MainCard = document.createElement("div");
        MainCard.className = "col-md-3 col-sm-4 filtr-item col-md-offset-1";
        //MainCard.className=" col-md-3 col-md-offset-1";
        //MainCard.style.marginBottom="1%";
        MainCard.setAttribute("style", "margin-bottom:3%;")

        var DivCard = document.createElement("div");
        DivCard.className = "card border-dark";

        var DivCardHeader = document.createElement("div");
        DivCardHeader.className = "card-header bg-dark text-light";

        var Name = document.createElement("h5");
        Name.textContent = Player.Name;
        Name.className = "row";
        DivCardHeader.appendChild(Name);
        //console.log(Title);

        var img = document.createElement("img");
        img.className = "card-img-top";
        img.src = Player.Photo;
        img.title ="TotalWinnings:"+ Player.TotalWinnings;
        //img.style.height = "100%";

        DivCardHeader.appendChild(img);

        var CardBody = document.createElement("div");
        CardBody.className = "card-body row";

        var Texto = document.createElement("p");
        Texto.className = "card-text";
        //Texto.textContent = "Country" + Player.Coutry;


        var CountryImg = document.createElement("img");
        CountryImg.src = Player.ImgCountry;
        CountryImg.setAttribute("style", "text-align:left");

        var DivFooter = document.createElement("div");
        DivFooter.className = "card-footer";

        DivFooter.appendChild(CountryImg);

        var Nickname = document.createElement("h6");
        Nickname.textContent = "Nickname:" + " " + Player.Nickname;

        var Team = document.createElement("h4");
        Team.textContent = "Team:" + " " + Player.Team;

        CardBody.appendChild(Nickname);
        CardBody.appendChild(Team);

        var Button = document.createElement("button");
        Button.className = "btn btn-dark btn-sm";
        Button.textContent = "click for more";
        Button.setAttribute("style", "margin-left: 2%;float:right")

        Button.setAttribute("id", Player.Id);
        //console.log(Player.Id);
        DivFooter.appendChild(Button);

        DivCard.appendChild(DivCardHeader);
        DivCard.appendChild(CardBody);
        DivCard.appendChild(DivFooter);

        var ButtonOrder = document.createElement("button");
        ButtonOrder.className = "btn btn-primary";

        Button.addEventListener("click", function (e) {
            var PlayerId = e.target.getAttribute("id", Players.Id);
            ContainerPlayers.classList.add("hidden");
            EcranPlayer(PlayerId);
        });
        MainCard.appendChild(DivCard);
        AllPlayers.appendChild(MainCard);

    }
}
//Mostra todos os jogadores de uma equipa
function ShowTeamPlayers(Players) {


    var AllPlayers= document.getElementById("AllPlayers");
    AllPlayers.classList.add("hidden");
   
    var SinglePlayer = document.getElementById("SinglePlayer");
    SinglePlayer.classList.remove("hidden");

    for (var i = 0; i < Players.length; i++) {

        var Player = Players[i];

        var MainCard = document.createElement("div");
        // MainCard.className = "col-md-3 col-sm-4 filtr-item col-md-offset-1";
        MainCard.className = "col 4 MainCardSinglePlayer";
        //MainCard.style.marginBottom="1%";
        MainCard.setAttribute("style", "margin-bottom:3%;")

        var DivCard = document.createElement("div");
        DivCard.className = "card border-dark";

        var DivCardHeader = document.createElement("div");
        DivCardHeader.className = "card-header bg-dark text-light";

        var Name = document.createElement("h5");
        Name.textContent = Player.Name;
        Name.className = "row";
        DivCardHeader.appendChild(Name);
        //console.log(Title);

        var img = document.createElement("img");
        img.className = "card-img-top";
        img.src = Player.Photo;
        //img.style.height = "100%";
        img.setAttribute("id",Players.Id);

        DivCardHeader.appendChild(img);

        var CardBody = document.createElement("div");
        CardBody.className = "card-body row";

        var Texto = document.createElement("p");
        Texto.className = "card-text";
        //Texto.textContent = "Country" + Player.Coutry;


        var CountryImg = document.createElement("img");
        CountryImg.src = Player.ImgCountry;
        CountryImg.setAttribute("style", "text-align:left");

        var DivFooter = document.createElement("div");
        DivFooter.className = "card-footer";

        DivFooter.appendChild(CountryImg);

        var Nickname = document.createElement("h6");
        Nickname.textContent = "Nickname:" + " " + Player.Nickname;

        var Team = document.createElement("h4");
        Team.textContent = "Team:" + " " + Player.Team;

        CardBody.appendChild(Nickname);
        CardBody.appendChild(Team);

        var Button = document.createElement("button");
        Button.className = "btn btn-dark btn-sm";
        Button.textContent = "click for more";
        Button.setAttribute("style", "margin-left: 2%;float:right")

        Button.setAttribute("id", Player.Id);
        //console.log(Player.Id);
        DivFooter.appendChild(Button);

        DivCard.appendChild(DivCardHeader);
        DivCard.appendChild(CardBody);
        DivCard.appendChild(DivFooter);

        var ButtonOrder = document.createElement("button");
        ButtonOrder.className = "btn btn-primary";


        /*         Button.addEventListener("click", function (e) {
                    GetPlayer(e.target.id).then
                    (function (res) {
                        ShowPlayer(res);
                    }).catch(function (erro) {
                        console.error(erro);
                        alert("Lamentamos, mas ocorreu um erro...");
                    });
                });

         */
        Button.addEventListener("click", function (e) {
            var PlayerId = e.target.getAttribute("id", Players.Id);
            ContainerPlayers.classList.add("hidden");
            SinglePlayer.classList.add("hidden");
            EcranPlayer(PlayerId);
        });


        MainCard.appendChild(DivCard);
        SinglePlayer.appendChild(MainCard);

    }
}


//Funcao que vai buscar todas as equipas e dá display
function ShowTeams(Teams) {

    /*  EcranPlayers(); */

    // var AllPlayers = document.getElementById("AllPlayers");
    // AllPlayers.classList.add("hidden");

    var AllTeams = document.getElementById("AllTeams");
    AllTeams.classList.remove("hidden");

    for (var i = 0; i < Teams.length; i++) {

        var Team = Teams[i];

        var MainCard = document.createElement("div");
        MainCard.className = "col-md-3 col-sm-6 filtr-item col-md-offset-1";
        //MainCard.className=" col-md-3 col-md-offset-1";
        //MainCard.style.marginBottom="1%";
        MainCard.setAttribute("style", "margin-bottom:3%;");

        var DivCard = document.createElement("div");
        DivCard.className = "card border-dark";

        var DivCardHeader = document.createElement("div");
        DivCardHeader.className = "card-header bg-dark text-light";


        var TeamName = document.createElement("h5");
        TeamName.textContent = Team.Name;
        TeamName.className = "row";
        DivCardHeader.appendChild(TeamName);

        var TeamImg = document.createElement("img");
        TeamImg.src = Team.Logo;
        TeamImg.className = "card-img-top zoom";
        TeamImg.setAttribute("style", "opacity:0.8");

        DivCardHeader.appendChild(TeamImg);

        var DivFooter = document.createElement("div");
        DivFooter.className = "card-footer";

        var WorldRanking = document.createElement("h6");
        WorldRanking.textContent = " WorldRanking:" + " " + Team.WorldRanking;

        var DivCardBody = document.createElement("div");
        DivCardBody.className = "card-body row";

        DivCardBody.appendChild(WorldRanking);

        var RegionPhoto = document.createElement("img");
        RegionPhoto.src = Team.RegionPhoto;

        //var DivFooter = document.createElement("div");
        //DivFooter.className = "card-footer";

        var Button = document.createElement("button");
        Button.className = "btn btn-dark btn-sm";
        Button.textContent = "click for more";
        Button.setAttribute("style", "margin-left: 2%;float:right");
        Button.setAttribute("id", Team.Id);
        DivFooter.appendChild(Button);


        Button.addEventListener("click", function (e) {
            var TeamId = e.target.getAttribute("id", Team.Id);
            AllTeams.classList.add("hidden");
            EcranTeamPlayers(TeamId);
        });

        DivFooter.appendChild(RegionPhoto);
        DivFooter.appendChild(Button);
        DivCard.appendChild(DivCardHeader);
        DivCard.appendChild(DivCardBody);
        DivCard.appendChild(DivFooter);
        MainCard.appendChild(DivCard);

        AllTeams.appendChild(MainCard);

    }
}

function ShowPlayer(PlayerId) {

    var SinglePlayer = document.getElementById("SinglePlayer");

    var teste = document.getElementById("teste");

    var photo = document.createElement("img");
    photo.src = PlayerId.Photo;
    var Name = document.createElement("p");
    Name.textContent = PlayerId.Name;
    Name.style.color = "white";
    var DivName = document.createElement("div");

    DivName.appendChild(Name);

    // SinglePlayer.appendChild(DivName);
    // // SinglePlayer.appendChild(p);

    teste.appendChild(photo);
}


// Ecran de todos os jogadores
function EcranPlayers() {

    return GetPlayers()

        .then(function (Players) {
            ShowPlayers(Players);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function EcranPlayer(PlayerId) {

    return GetPlayer(PlayerId)
        .then(function (PlayerId) {
            ShowPlayer(PlayerId);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
// Ecran de todas as equipas
function EcranTeams() {

    return GetTeams()

        .then(function (Teams) {
            ShowTeams(Teams);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

// Ecran de todos os jogadores que pertecem a uma equipa
function EcranTeamPlayers(TeamId) {

    return GetTeam(TeamId)
        .then(function (Players) {
            ShowTeamPlayers(Players);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
