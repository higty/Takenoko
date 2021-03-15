export function $(value) {
    return new HtmlElementQuery(value);
}
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
    HtmlElementQuery.prototype.getValue = function () {
        if (this._elementList.length > 0) {
            var element = this._elementList[0];
            if (element === null) {
                return "";
            }
            if (element.value == null) {
                return "";
            }
            return element.value;
        }
        return "";
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
    HtmlElementQuery.prototype.addEventListenerToAllElement = function (eventName, callback) {
        for (var i = 0; i < this._elementList.length; i++) {
            var element = this._elementList[i];
            element.addEventListener(eventName, callback);
        }
    };
    HtmlElementQuery.prototype.click = function (callback) {
        this.addEventListenerToAllElement("click", callback);
    };
    HtmlElementQuery.prototype.mouseover = function (callback) {
        this.addEventListenerToAllElement("mouseover", callback);
    };
    HtmlElementQuery.prototype.mouseout = function (callback) {
        this.addEventListenerToAllElement("mouseout", callback);
    };
    HtmlElementQuery.prototype.focus = function (callback) {
        this.addEventListenerToAllElement("focus", callback);
    };
    return HtmlElementQuery;
}());
export { HtmlElementQuery };
//# sourceMappingURL=HtmlElementQuery.js.map