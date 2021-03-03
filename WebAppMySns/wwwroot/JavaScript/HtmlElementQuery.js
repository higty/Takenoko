var HtmlElementQuery = /** @class */ (function () {
    function HtmlElementQuery(value) {
        this._elementList = new Array();
        if (typeof value === "string") {
            var ee = document.querySelectorAll(value);
            for (var i = 0; i < ee.length; i++) {
                this._elementList.push(ee[i]);
            }
        }
        else if (value instanceof Element) {
            this._elementList.push(value);
        }
        else if (Array.isArray(value)) {
            for (var i = 0; i < value.length; i++) {
                this._elementList.push(value[i]);
            }
        }
    }
    HtmlElementQuery.prototype.setStyle = function (name, value) {
        for (var i = 0; i < this._elementList.length; i++) {
            var element = this._elementList[i];
            element.style[name] = value;
        }
    };
    HtmlElementQuery.prototype.removeStyle = function (name) {
        for (var i = 0; i < this._elementList.length; i++) {
            var element = this._elementList[i];
            element.style[name] = null;
        }
    };
    HtmlElementQuery.prototype.setAttribute = function (name, value) {
        for (var i = 0; i < this._elementList.length; i++) {
            var element = this._elementList[i];
            element.setAttribute(name, value);
        }
    };
    HtmlElementQuery.prototype.getInnerText = function () {
        if (this._elementList.length > 0) {
            var element = this._elementList[0];
            return element.textContent;
        }
        return "";
    };
    HtmlElementQuery.prototype.hide = function () {
        for (var i = 0; i < this._elementList.length; i++) {
            var element = this._elementList[i];
            element.style["display"] = "none";
        }
    };
    HtmlElementQuery.prototype.click = function (callback) {
        for (var i = 0; i < this._elementList.length; i++) {
            var element = this._elementList[i];
            element.addEventListener("click", callback);
        }
    };
    return HtmlElementQuery;
}());
export { HtmlElementQuery };
//# sourceMappingURL=HtmlElementQuery.js.map