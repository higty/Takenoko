import { $ } from "./HtmlElementQuery.js";
var HtmlElementQueryPage = /** @class */ (function () {
    function HtmlElementQueryPage() {
    }
    HtmlElementQueryPage.prototype.initialize = function () {
        this.setTopPanel();
        this.setTopPanel_2();
        this.setChildPanel();
        this.setTextPanel();
        this.setAttribute_Event();
        document.getElementById("HideButton").addEventListener("click", this.hideButton_Click.bind(this));
        document.getElementById("ShowButton").addEventListener("click", this.showPanel_Click.bind(this));
        this.addEventListnerToTextPanel();
    };
    HtmlElementQueryPage.prototype.setTopPanel = function () {
        var q = $("body > div");
        q.setStyle("background-color", "#fff4e0");
        q.setStyle("padding", "10px");
    };
    HtmlElementQueryPage.prototype.setTopPanel_2 = function () {
        var q = $("#ViewPanel2");
        q.setStyle("background-color", "#ffa022");
        q.setStyle("padding", "10px");
    };
    HtmlElementQueryPage.prototype.setChildPanel = function () {
        var q = $("div .panel");
        q.setStyle("background-color", "#ffe0e8");
        q.setStyle("color", "#fffff");
        q.setStyle("width", "200px");
        q.setStyle("margin-bottom", "10px");
        q.setStyle("padding", "10px");
    };
    HtmlElementQueryPage.prototype.setTextPanel = function () {
        var q = $(".text-panel");
        q.setStyle("background-color", "#cccccc");
        q.setStyle("padding", "10px");
        q.setStyle("margin-bottom", "4px");
    };
    HtmlElementQueryPage.prototype.setAttribute_Event = function () {
        var q = $(".text-panel");
        q.setAttribute("event-panel", "true");
    };
    HtmlElementQueryPage.prototype.hideButton_Click = function (e) {
        this.hidePanel();
    };
    HtmlElementQueryPage.prototype.hidePanel = function () {
        var q = $("[event-panel]");
        q.hide();
    };
    HtmlElementQueryPage.prototype.showPanel_Click = function (e) {
        this.showPanel();
    };
    HtmlElementQueryPage.prototype.showPanel = function () {
        var q = $("[event-panel]");
        q.removeStyle("display");
    };
    HtmlElementQueryPage.prototype.addEventListnerToTextPanel = function () {
        var q = $(".text-panel");
        q.click(this.textPanel_Click.bind(this));
        q.mouseover(this.textPanel_Mouseover.bind(this));
        q.mouseout(this.textPanel_Mouseout.bind(this));
    };
    HtmlElementQueryPage.prototype.textPanel_Click = function (e) {
        var element = e.srcElement;
        var q = $(element);
        alert(q.getInnerText());
    };
    HtmlElementQueryPage.prototype.textPanel_Mouseover = function (e) {
        var element = e.srcElement;
        var q = $(element);
        q.setStyle("font-size", "32px");
    };
    HtmlElementQueryPage.prototype.textPanel_Mouseout = function (e) {
        var element = e.srcElement;
        var q = $(element);
        q.removeStyle("font-size");
    };
    return HtmlElementQueryPage;
}());
document.addEventListener("DOMContentLoaded", function () {
    var page = new HtmlElementQueryPage();
    page.initialize();
});
//# sourceMappingURL=HtmlElementQueryPage.js.map