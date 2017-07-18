// setup the video element and attach it to the Dash player
function setupVideo() {
    var url = "http://189.79.94.43:4000/sintel/stream.mpd";
    var player = dashjs.MediaPlayer().create();
    player.initialize(document.querySelector("#videoPlayer"), url, true);
}