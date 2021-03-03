import { HtmlElementQuery } from "./HtmlElementQuery.js";
var HtmlElementQueryPage = /** @class */ (function () {
    function HtmlElementQueryPage() {
    }
    HtmlElementQueryPage.prototype.initialize = function () {
        var q = new HtmlElementQuery("div");
        q.setStyle("background-color", "#ff0000");
        q.setStyle("color", "#fffff");
        q.setStyle("width", "200px");
        q.setStyle("margin-bottom", "10px");
        q.setStyle("padding", "10px");
    };
    return HtmlElementQueryPage;
}());
document.addEventListener("DOMContentLoaded", function () {
    var page = new HtmlElementQueryPage();
    page.initialize();
});
//# sourceMappingURL=HtmlElementQueryPage.js.map