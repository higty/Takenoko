import { $ } from "./HtmlElementQuery.js";
class HtmlElementQueryPage {
    initialize() {
        this.setTopPanel();
        this.setTopPanel_2();
        this.setChildPanel();
        this.setTextPanel();
        this.setAttribute_Event();
        document.getElementById("HideButton").addEventListener("click", this.hideButton_Click.bind(this));
        document.getElementById("ShowButton").addEventListener("click", this.showPanel_Click.bind(this));
        this.addEventListnerToTextPanel();
    }
    setTopPanel() {
        const q = $("body > div");
        q.setStyle("background-color", "#fff4e0");
        q.setStyle("padding", "10px");
    }
    setTopPanel_2() {
        const q = $("#ViewPanel2");
        q.setStyle("background-color", "#ffa022");
        q.setStyle("padding", "10px");
    }
    setChildPanel() {
        const q = $("div .panel");
        q.setStyle("background-color", "#ffe0e8");
        q.setStyle("color", "#fffff");
        q.setStyle("width", "200px");
        q.setStyle("margin-bottom", "10px");
        q.setStyle("padding", "10px");
    }
    setTextPanel() {
        const q = $(".text-panel");
        q.setStyle("background-color", "#cccccc");
        q.setStyle("padding", "10px");
        q.setStyle("margin-bottom", "4px");
    }
    setAttribute_Event() {
        const q = $(".text-panel");
        q.setAttribute("event-panel", "true");
    }
    hideButton_Click(e) {
        this.hidePanel();
    }
    hidePanel() {
        const q = $("[event-panel]");
        q.hide();
    }
    showPanel_Click(e) {
        this.showPanel();
    }
    showPanel() {
        const q = $("[event-panel]");
        q.removeStyle("display");
    }
    addEventListnerToTextPanel() {
        const q = $(".text-panel");
        q.click(this.textPanel_Click.bind(this));
        q.mouseover(this.textPanel_Mouseover.bind(this));
        q.mouseout(this.textPanel_Mouseout.bind(this));
    }
    textPanel_Click(e) {
        const element = e.srcElement;
        const q = $(element);
        alert(q.getInnerText());
    }
    textPanel_Mouseover(e) {
        const element = e.srcElement;
        const q = $(element);
        q.setStyle("font-size", "32px");
    }
    textPanel_Mouseout(e) {
        const element = e.srcElement;
        const q = $(element);
        q.removeStyle("font-size");
    }
}
document.addEventListener("DOMContentLoaded", function () {
    const page = new HtmlElementQueryPage();
    page.initialize();
});
//# sourceMappingURL=HtmlElementQueryPage.js.map