var DELAY = 5;
var pause = false, button, timeOut, timeOutID;
var pageNames = ["page1.html",'page2.html','page3.html'];
var startPageName = "index.html";

var pageCurrentName = location.pathname.split("/").slice(-1);
var i, pageIndex;

for (i = 0; i< pageNames.length; i++){
    if(pageNames[i]==pageCurrentName){
        pageIndex = i;
        break;
    }
    else if (i == (pageNames.length-1)){
        pageIndex = -1;
    }
}

function NextPage() {
    location.assign(pageNames[pageIndex+1]);
}

timeout = DELAY;

function StartCountdown(){
    var countdown;

    countdown = document.getElementById("LeftTime");
    countdown.innerHTML = timeout;
    timeout--;

    if (timeout >= 0) {
        timeOutID = setTimeout(StartCountdown, 1000);
    }
    else {
        NextPage();
    }
}
if (document.getElementById('pause')!=null){
    document.getElementById('pause').onclick = function () {
        if (!pause){
          pause = true;
          button = document.getElementById('pause');
          button.innerHTML = "Continue";
          clearTimeout(timeOutID);
        }
        else {
          pause = false;
          button = document.getElementById('pause');
          button.innerHTML = "Pause";
          StartCountdown();
        }
      }
}

if (document.getElementById('previous')!=null) {
    document.getElementById('previous').onclick = function () {
        if (pageIndex != -1){
            location.assign(pageNames[pageIndex-1]);
        }
        else{
            alert("Unable to load previous page");
        }
    }
}

if (document.getElementById('start')!=null) {
    document.getElementById('start').onclick = function () {
        //location.assign(pageNames[0]);
        window.open(pageNames[0]);
    }
}

if (document.getElementById('close')!=null) {
    document.getElementById('close').onclick = function () {
        open(location, "_self").close();
    }
}
