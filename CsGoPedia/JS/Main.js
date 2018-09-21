document.addEventListener("DOMContentLoaded", function main(e) {
    inic();
});

function inic() {
    MainPage();
}

// Página inicial
function MainPage() {
    // var AllPlayers = document.getElementById("AllPlayers").classList.add("hidden");

    var DivVideos = document.getElementById("DivVideos");
    DivVideos.setAttribute("style","margin-top:15%");
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

    // var Me = document.createElement("img");

    Video1.src = "https://www.youtube.com/embed/gbqTR0aSh2M?rel=0";
    Video1.setAttribute("allowFullScreen", "");
    DivVideo1.appendChild(Video1);
    Video2.src = "https://www.youtube.com/embed/bXewHrp3BeQ?rel=0";
    Video2.setAttribute('allowFullScreen', '');
    DivVideo2.appendChild(Video2);
    Video3.src = "https://www.youtube.com/embed/swPCjsxpoXw?rel=0";
    Video3.setAttribute('allowFullScreen', '');
    DivVideo3.appendChild(Video3);
    Video4.src = "https://www.youtube.com/embed/iKmOXwRhTrI?rel=0";
    Video4.setAttribute('allowFullScreen', '');
    DivVideo4.appendChild(Video4);

    Video5.src = "https://www.youtube.com/embed/0sMlZL6MVP4";
    Video5.setAttribute('allowFullScreen', '');
    DivVideo5.appendChild(Video5);

    Video6.src = "https://www.youtube.com/embed/vVIhQCN_Mm4";
    Video6.setAttribute('allowFullScreen', '');
    DivVideo6.appendChild(Video6);

    // Me.src = "./Content/Images/Me.jpg";
    // Me.className = "MePhoto";


    DivVideos.appendChild(DivVideo1);
    DivVideos.appendChild(DivVideo2);
    DivVideos.appendChild(DivVideo3);
    DivVideos.appendChild(DivVideo4);
    DivVideos.appendChild(DivVideo5);
    DivVideos.appendChild(DivVideo6);

    var RedirectPlayers = document.getElementById("RedirectPlayers");
    var RedirectTeams = document.getElementById("RedirectTeams");
    var TitleMiddlePage = document.getElementById("TitleMiddlePage");
    var SubmitSearch = document.getElementById("SubmitSearch");

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

    SubmitSearch.addEventListener("click", function(e){
        e.preventDefault();
        //Ecran dependendo do input da procura
        var type = document.getElementById("searchFilter").value;
        var str = document.getElementById("searchInput").value;
        DivVideos.classList.add("hidden");
        TitleMiddlePage.classList.add("hidden");
        DivMedia.classList.add("hidden");
        AllPlayers.classList.add("hidden");
        AllTeams.classList.add("hidden");
        SinglePlayer.classList.add("hidden");

        // RedirectTeams.classList.add("hidden");
        AllPlayers.innerHTML = "";
        SinglePlayer.innerHTML = "";
        // debugger;
        EcranPlayers(type, str);
    });

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
        //Texto.textContent = "Country" + Player.Country;


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

            AllPlayers.innerHTML = "";
            SinglePlayer.innerHTML = "";
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

    var PlayersDetails = document.getElementById("PlayersDetails");
    PlayersDetails.style.marginTop = "1%";

    var DivCol1 = document.createElement("div");
    DivCol1.className = "col-md-6";

    var DivCol2 = document.createElement("div");
    DivCol2.className = "col-md-6";
    DivCol2.setAttribute("style","background-color:#32383e");

    var DivCol3 = document.createElement("div");
    DivCol3.className = "col-md-4";

    var DivPhoto = document.createElement("div");

    var PlayerPhoto = document.createElement("img");
    PlayerPhoto.src = PlayerId.Photo;
    PlayerPhoto.setAttribute("style","height:100%; width:100%");
    DivPhoto.appendChild(PlayerPhoto);

    var DivTotalWinnings = document.createElement("div");
    DivTotalWinnings.setAttribute("style","background-color:black; text-align:center;");

    var TotalWinnings = document.createElement("h6");
    TotalWinnings.textContent = "Total:" + " " + PlayerId.TotalWinnings;
    TotalWinnings.setAttribute("style","color:white");

    var Nickname = document.createElement("h6");
    Nickname.textContent = "Nickname:" + " " + PlayerId.Nickname;
    Nickname.setAttribute("style","background-color:#343a40 !important;");

    var Name = document.createElement("h6");
    Name.textContent = "Name:" + " " + PlayerId.Name;
    Name.setAttribute("style","background-color:#343a40 !important;");

    var divCountryStuff = document.createElement("div");

    
    var Country = document.createElement("h6");
    Country.textContent = "Name:" + " " + PlayerId.Country;
    Country.setAttribute("style","background-color:#343a40 !important;");

    var ImgCountry = document.createElement("img");
    ImgCountry.src =PlayerId.ImgCountry;
    ImgCountry.setAttribute("style","float:right;");

    var VideoHighlight = document.createElement("iframe");
    VideoHighlight.src = PlayerId.VideoHighlight;~
    VideoHighlight.setAttribute("style","height:50%; width:100%;")

    console.log(VideoHighlight);

    divCountryStuff.appendChild(ImgCountry);
    divCountryStuff.appendChild(Country);
    
    var Role = document.createElement("h6");
    Role.textContent = "Name:" + " " + PlayerId.Role;
    Role.setAttribute("style","background-color:#343a40 !important;");

    var BirthDate = document.createElement("h6");
    BirthDate.textContent = "Name:" + " " + PlayerId.BirthDate;
    BirthDate.setAttribute("style","background-color:#343a40 !important;");

    var InstaPlayer = document.createElement("a");
    InstaPlayer.setAttribute("style","background-color:#343a40 !important;")
    InstaPlayer.href = PlayerId.Instagram;
    InstaPlayer.setAttribute("target","_blank");

    var InstagramIcon = document.createElement("img");
    InstagramIcon.src = "./Content/Images/InstaIcon.png";
    InstagramIcon.setAttribute("style","height:25px;width:25px;float:right;");

    InstaPlayer.appendChild(InstagramIcon);


    DivTotalWinnings.appendChild(TotalWinnings);

    // DivPhoto.appendChild(DivTotalWinnings);

    DivCol1.appendChild(DivPhoto);
    DivCol1.appendChild(DivTotalWinnings);

    DivCol2.appendChild(Nickname);
    DivCol2.appendChild(Name);
    DivCol2.appendChild(divCountryStuff);
    DivCol2.appendChild(Role);
    DivCol2.appendChild(BirthDate);
    DivCol2.appendChild(VideoHighlight);
    DivCol2.appendChild(InstaPlayer);


    // DivCol3.appendChild(InstaPlayer);

    // var DivContainerAchivements = document.createElement("div");
    // DivContainerAchivements.className = "container";

    PlayersDetails.appendChild(DivCol1);
    PlayersDetails.appendChild(DivCol2);
    // PlayersDetails.appendChild(DivCol3);


    var div = document.createElement("div");
    div.className= "DivAChiStats row";
    div.setAttribute("style","margin-top: 2%;margin-left: 1.4%;");

    var AchievementsTitle = document.createElement("h3");
    AchievementsTitle.className = "AchievementsTitle";
    AchievementsTitle.textContent = "Player Achivements";
    // AchievementsTitle.setAttribute("style","background-color:#32383e;text-align:center;color:white;");
    div.appendChild(AchievementsTitle);

    var tablehead = document.createElement("thead");

    var tr1 = document.createElement("tr");

    var table = document.createElement("table");
    table.className = "table table-dark";
    table.setAttribute("style","border-collapse: collapse; ")

    var thName = document.createElement("th");
    // thName.className = "col";
    thName.textContent = "Tournament";

    var thPlacement = document.createElement("th");
    // thPlacement.className = "col";
    thPlacement.textContent = "Placement";

    tr1.appendChild(thName);
    tr1.appendChild(thPlacement);

    tablehead.appendChild(tr1);
    table.appendChild(tablehead);

    for (var i = 0; i < PlayerId.Achievements.length; i++){

        var pAchi = PlayerId.Achievements[i];

        var tBody = document.createElement("tbody");

        var tr2 = document.createElement("tr");

        var tdName = document.createElement("td");
        tdName.textContent = pAchi.Name;

        tr2.appendChild(tdName);

        var tdPlacement = document.createElement("td");
        tdPlacement.textContent =pAchi.Placement;

        tr2.appendChild(tdPlacement);

        tBody.appendChild(tr2);
        tBody.appendChild(tdName);
        tBody.appendChild(tdPlacement);

        // table.appendChild(tablehead);
        table.appendChild(tBody);

        div.appendChild(table);

        PlayersDetails.appendChild(div);
    }

    // PlayersDetails.appendChild(DivCol1);
    // PlayersDetails.appendChild(DivCol2);
    // PlayersDetails.appendChild(DivCol3);


    // var divS = document.createElement("div");
    // divS.setAttribute("style","margin-top: 2%;margin-left: 1.4%;");

    var StatiTitle = document.createElement("h3");
    StatiTitle.textContent = "Player Statistics";
    StatiTitle.className = "StatiTitle";
    // StatiTitle.setAttribute("style","background-color:#32383e;text-align:center;color:white;");
    div.appendChild(StatiTitle);

    var tableheads = document.createElement("thead");

    var tr11 = document.createElement("tr");

    var table1 = document.createElement("table");
    table1.className = "table table-dark";
    table1.setAttribute("style","margin-bottom:5%");

    var thRating = document.createElement("th");
    // thRating.className = "col";
    thRating.textContent = "Rating";

    var thHS = document.createElement("th");
    // thHS.className = "col";
    thHS.textContent = "HS";

    var thKillRounds = document.createElement("th");
    // thKillRounds.className = "col";
    thKillRounds.textContent = "KR";

    var thDeadthsRound = document.createElement("th");
    // thDeadthsRound.className = "col";
    thDeadthsRound.textContent = "DR";

    var thRoundsContributed = document.createElement("th");
    // thRoundsContributed.className = "col";
    thRoundsContributed.textContent = "RoundsContributed";

    var thMapsPlayed = document.createElement("th");
    // thMapsPlayed.className = "col";
    thMapsPlayed.textContent = "MP";

    var thTotalKills = document.createElement("th");
    // thTotalKills.className = "col";
    thTotalKills.textContent = "TK";

    var thTotalDeaths = document.createElement("th");
    // thTotalDeaths.className = "col";
    thTotalDeaths.textContent = "TD";

    tr11.appendChild(thRating);
    tr11.appendChild(thHS);
    tr11.appendChild(thKillRounds);
    tr11.appendChild(thDeadthsRound);
    tr11.appendChild(thRoundsContributed);
    tr11.appendChild(thMapsPlayed);
    tr11.appendChild(thTotalKills);
    tr11.appendChild(thTotalDeaths);


    tableheads.appendChild(tr11);
    table1.appendChild(tableheads);

    for(var i = 0; i < PlayerId.Statistics.length;i++){

        var pStati = PlayerId.Statistics[i];

        var sBody = document.createElement("tbody");

        var StasTr2 = document.createElement("tr");

        var tdRating = document.createElement("td");
        tdRating.textContent = "Rating:" + " " + pStati.Rating;

        StasTr2.appendChild(tdRating);

        var tdHS = document.createElement("td");
        tdHS.textContent ="Heahshot(%):" +  " "+pStati.HS;

        StasTr2.appendChild(tdHS);

        var thKillRounds = document.createElement("td");
        thKillRounds.textContent ="Kill Rounds(%):" + " " +pStati.KillsRound;

        StasTr2.appendChild(thKillRounds);

        var tdDeadthsRound = document.createElement("td");
        tdDeadthsRound.textContent ="DeadthsRound(%):" + " "+  pStati.DeadthsRound+"%";

        StasTr2.appendChild(tdDeadthsRound);

        var tdRoundsContributed  = document.createElement("td");
        tdRoundsContributed.textContent ="RoundContributed" + " "+ pStati.RoundsContributed;

        StasTr2.appendChild(tdRoundsContributed);

        var tdMapsPlayed = document.createElement("td");
        tdMapsPlayed.textContent = "MapsPlayed:" + " " +pStati.MapsPlayed;

        StasTr2.appendChild(tdMapsPlayed);

        var tdTotalKills = document.createElement("td");
        tdTotalKills.textContent ="TotalKills:" + " "+ pStati.TotalKills;

        StasTr2.appendChild(tdTotalKills);

        var tdDeadths = document.createElement("td");
        tdDeadths.textContent ="TotalDeaths:" + " "+ pStati.TotalDeaths;

        StasTr2.appendChild(tdDeadths);


        sBody.appendChild(StasTr2);

        table1.appendChild(sBody);

        div.appendChild(table1)

        PlayersDetails.appendChild(div);
    }

}

// Ecran de todos os jogadores
function EcranPlayers(type, str) {
    return GetPlayers(type, str)
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
