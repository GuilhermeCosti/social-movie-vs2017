// setup the video element and attach it to the Dash player
function setupVideo() {
    var url = "movies/stream.mpd";
    var player = dashjs.MediaPlayer().create();
    player.initialize(document.querySelector("#videoPlayer"), url, true);
}