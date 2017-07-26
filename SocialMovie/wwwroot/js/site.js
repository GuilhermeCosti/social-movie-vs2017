// setup the video element and attach it to the Dash player
function setupVideo(protocol, domain, port, path, file, ext, id) {
    //var url = "http://socialmovie.sytes.net:4000/nightofthelivingdead/stream.mpd";
    var url = protocol + "://" + domain + ":" + port + "/" + path + "/" + file + "." + ext;
    var player = dashjs.MediaPlayer().create();
    player.initialize(document.querySelector(`#video_${id}`), url, true);
}