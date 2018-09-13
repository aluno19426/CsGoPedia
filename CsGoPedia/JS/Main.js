document.addEventListener("DOMContentLoaded", function main(e) {

    inic();
});

function inic() {
    MainPage();
    //ClearEcran();
    //c
}

/* function Clean(){

    var Clean = document.getElementById("Clean");

    Clean.addEventListener("click",function(e){



    });
} */


function MainPage() {

    /* var Card = document.getElementById("Card");
    Card.classList.add("hidden"); */

    var DivVideos = document.getElementById("DivVideos");
    var DivMedia = document.getElementById("Media");
    // var DivFooter = document.getElementById("DivFooter");

    var DivVideo1 = document.createElement("div");
    DivVideo1.className="col-md-4";
    var DivVideo2 = document.createElement("div");
    DivVideo2.className="col-md-4";
    var DivVideo3 = document.createElement("div");
    DivVideo3.className="col-md-4";
    var DivVideo4 = document.createElement("div");
    DivVideo4.className="col-md-4";
    var DivVideo5 = document.createElement("div");
    DivVideo5.className="col-md-4";
    var DivVideo6 = document.createElement("div");
    DivVideo6.className="col-md-4";

    var Video1 = document.createElement("iframe");
    var Video2 = document.createElement("iframe");
    var Video3 = document.createElement("iframe");
    var Video4 = document.createElement("iframe");
    var Video5 = document.createElement("iframe");
    var Video6 = document.createElement("iframe");

    var SteamImg = document.createElement("img");
    var Steam = document.createElement("a");
    var InstagramImg = document.createElement("img");
    var Instagram = document.createElement("a");
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

    SteamImg.src = "./Content/Images/SteamIcon.png";
    //SteamImg.className = "col-4";
    SteamImg.setAttribute("style", "height:24px;");
    SteamImg.setAttribute("style", "width:24px;");
    Steam.textContent = "https://steamcommunity.com/id/retiredjustforfun";
    Steam.href = "https://steamcommunity.com/id/retiredjustforfun";
    Steam.className = "col-4";
    //Steam.setAttribute("style","text-align:center;")

    InstagramImg.src = "./Content/Images/InstaIcon.png";
    InstagramImg.setAttribute("style", "height:24px;");
    InstagramImg.setAttribute("style", "width:24px;");
    Instagram.textContent = "https://www.instagram.com/diogommp/";
    Instagram.href = "https://www.instagram.com/diogommp/";

    Me.src = "./Content/Images/Me.jpg";
    //Me.setAttribute("style", "margin-left: auto;margin-right: auto;display: flex;")
    Me.className = "MePhoto";

    DivVideos.appendChild(DivVideo1);
    DivVideos.appendChild(DivVideo2);
    DivVideos.appendChild(DivVideo3);
    DivVideos.appendChild(DivVideo4);
    DivVideos.appendChild(DivVideo5);
    DivVideos.appendChild(DivVideo6);
    DivMedia.appendChild(Me);
    /*     DivFooter.appendChild(SteamImg);
        DivFooter.appendChild(Steam);
        DivFooter.appendChild(InstagramImg);
        DivFooter.appendChild(Instagram); */

    var RedirectPlayers = document.getElementById("RedirectPlayers");
    var TitleMiddlePage = document.getElementById("TitleMiddlePage");
    RedirectPlayers.addEventListener("click", function (e) {
        Video1.classList.add("hidden");
        Video2.classList.add("hidden");
        Video3.classList.add("hidden");
        Video4.classList.add("hidden");
        Video5.classList.add("hidden");
        Video6.classList.add("hidden");
        DivVideos.classList.add("hidden");
        Video1.classList.add("hidden");
        Video2.classList.add("hidden");
        Video3.classList.add("hidden");
        Video4.classList.add("hidden");
        Video5.classList.add("hidden");
        Video6.classList.add("hidden");
        DivMedia.classList.add("hidden");
        TitleMiddlePage.classList.add("hidden");
        EcranPlayers();
    });
}



function ShowPlayers(Players) {


    var AllPlayers = document.getElementById("AllPlayers");


    for (var i = 0; i < Players.length; i++) {

        var Player = Players[i]; 

        var MainCard = document.createElement("div");
        MainCard.className = "col-md-3 col-sm-4 filtr-item col-md-offset-1";
        //MainCard.className=" col-md-3 col-md-offset-1";
        //MainCard.style.marginBottom="1%";
        MainCard.setAttribute("style","margin-bottom:3%;")

        var DivCard = document.createElement("div");
        DivCard.className = "card border-dark";
        
        var DivCardHeader = document.createElement("div");
        DivCardHeader.className="card-header bg-dark text-light";

        var Name = document.createElement("h5");
        Name.textContent = Player.Name;
        Name.className="row";
        DivCardHeader.appendChild(Name);
        //console.log(Title);

        var img = document.createElement("img");
        img.className="card-img-top";
        img.src = Player.Photo;
        //img.style.height = "100%";

        DivCardHeader.appendChild(img);

        var CardBody = document.createElement("div");
        CardBody.className="card-body row";
        
        var Texto = document.createElement("p");
        Texto.className="card-text";
        //Texto.textContent = "Country" + Player.Coutry;
        

        var CountryImg = document.createElement("img");
        CountryImg.src = Player.ImgCountry;
        CountryImg.setAttribute("style","text-align:left");

        var DivFooter = document.createElement("div");
        DivFooter.className="card-footer";

        DivFooter.appendChild(CountryImg);
        
        var Nickname = document.createElement("h6");
        Nickname.textContent ="Nickname:" + " " + Player.Nickname;

        var Team = document.createElement("h4");
        Team.textContent = "Team:" + " " + Player.Team;

        CardBody.appendChild(Nickname);
        CardBody.appendChild(Team);
        
        var Button = document.createElement("button");
        Button.className="btn btn-dark btn-sm";
        Button.textContent = "click for more";
        Button.setAttribute("style","margin-left: 2%;float:right")
        
        DivFooter.appendChild(Button);

        DivCard.appendChild(DivCardHeader);
        DivCard.appendChild(CardBody);
        DivCard.appendChild(DivFooter);

/*         DivFooter.appendChild(Button);

        CardBody.appendChild(CountryImg);
        
        DivCardHeader.appendChild(Title);
        DivCardHeader.appendChild(CardBody);
        MainCard.appendChild(CardBody);
        DivCard.appendChild(DivCardHeader);
        MainCard.appendChild(DivCard);
        MainCard.appendChild(img); */
        MainCard.appendChild(DivCard);
        AllPlayers.appendChild(MainCard);

        ClearEcran();
    }
}

function EcranPlayers() {

    return GetPlayers()

        .then(function (Players) {
            ShowPlayers(Players);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}
