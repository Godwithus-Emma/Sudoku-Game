function BackButtonPressed() {
    var _href = location.href;
    history.back();
    var p = new Promise((accept, reject) => {
        setTimeout(function () {
            var _url = location.href;
            if (_href == _url) {
                accept(false);
            }
            else {
                accept(true);
            }
        }, 20);
    });
    return p;
}
//# sourceMappingURL=JavaScriptFile.js.map
