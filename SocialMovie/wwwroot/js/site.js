// setup the video element and attach it to the Dash player
function setupVideo() {
    var url = "https://179.228.89.153:9443/split/video/stream.mpd";
    var player = dashjs.MediaPlayer().create();
    player.initialize(document.querySelector("#videoPlayer"), url, true);
}