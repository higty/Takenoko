var HtmlElementQuery = /** @class */ (function () {
    function HtmlElementQuery(selector) {
        this._elementList = new Array();
        var ee = document.querySelectorAll(selector);
        for (var i = 0; i < ee.length; i++) {
            this._elementList.push(ee[i]);
        }
    }
    HtmlElementQuery.prototype.setStyle = function (name, value) {
        for (var i = 0; i < this._elementList.length; i++) {
            var element = this._elementList[i];
            element.style[name] = value;
        }
    };
    return HtmlElementQuery;
}());
export { HtmlElementQuery };
//# sourceMappingURL=HtmlElementQuery.js.map