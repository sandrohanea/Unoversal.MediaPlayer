function umpSetSource(element, sourceUrl, contentType) {
    // We need to load video.js with requires but we don't the package directory name where Uno stored it.
    const arr = Array.prototype.slice.call(document.getElementsByTagName('script'))
    const videoJsScript = arr.find(s => s.src.endsWith('video.js'));
    require([videoJsScript.src], function (videojs) {
        let player = videojs(element)
        player.src([{ type: contentType, src: sourceUrl }]);
    });
}