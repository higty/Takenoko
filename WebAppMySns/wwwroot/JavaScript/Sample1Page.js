import { HtmlElementQuery } from "./HtmlElementQuery.js";
var Sample1Page = /** @class */ (function () {
    function Sample1Page() {
    }
    Sample1Page.prototype.initialize = function () {
        this.setPanel1();
        this.setPanel2();
        this.setPanel3();
        document.getElementById("ColorChangeButton").addEventListener("click", this.colorChangeButton_Click.bind(this));
    };
    Sample1Page.prototype.setPanel1 = function () {
        var q = new HtmlElementQuery("#Panel1");
        q.setStyle("background-color", "#48d1cc");
    };
    Sample1Page.prototype.setPanel2 = function () {
        var q = new HtmlElementQuery("#Panel2");
        q.setStyle("background-color", "#afeeee");
    };
    Sample1Page.prototype.setPanel3 = function () {
        var q = new HtmlElementQuery("#Panel3");
    };
    Sample1Page.prototype.colorChangeButton_Click = function (e) {
        var q = new HtmlElementQuery("#ColorText");
        var q1 = new HtmlElementQuery("#Panel3");
        var s = q.getValue();
        q1.setStyle("background-color", s);
    };
    return Sample1Page;
}());
document.addEventListener("DOMContentLoaded", function () {
    var page = new Sample1Page();
    page.initialize();
});
//# sourceMappingURL=Sample1Page.js.map