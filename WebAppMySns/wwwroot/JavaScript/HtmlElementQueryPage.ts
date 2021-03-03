import { HtmlElementQuery } from "./HtmlElementQuery.js";

class HtmlElementQueryPage {
    public initialize() {
        this.setTopPanel();
        this.setTopPanel_2();
        this.setChildPanel();
        this.setTextPanel();

        this.setAttribute_Event();

        document.getElementById("HideButton").addEventListener("click", this.hideButton_Click.bind(this));
        document.getElementById("ShowButton").addEventListener("click", this.showPanel_Click.bind(this));

        this.addEventListnerToTextPanel();
    }
    private setTopPanel() {
        const q = new HtmlElementQuery("body > div");
        q.setStyle("background-color", "#fff4e0");
        q.setStyle("padding", "10px");
    }
    private setTopPanel_2() {
        const q = new HtmlElementQuery("#ViewPanel2");
        q.setStyle("background-color", "#ffa022");
        q.setStyle("padding", "10px");
    }
    private setChildPanel() {
        const q = new HtmlElementQuery("div .panel");
        q.setStyle("background-color", "#ffe0e8");
        q.setStyle("color", "#fffff");
        q.setStyle("width", "200px");
        q.setStyle("margin-bottom", "10px");
        q.setStyle("padding", "10px");
    }
    private setTextPanel() {
        const q = new HtmlElementQuery(".text-panel");
        q.setStyle("background-color", "#cccccc");
        q.setStyle("padding", "10px");
        q.setStyle("margin-bottom", "4px");
    }

    private setAttribute_Event() {
        const q = new HtmlElementQuery(".text-panel");
        q.setAttribute("event-panel", "true");
    }

    private hideButton_Click(e: Event) {
        this.hidePanel();
    }
    private hidePanel() {
        const q = new HtmlElementQuery("[event-panel]");
        q.hide();
    }
    private showPanel_Click(e: Event) {
        this.showPanel();
    }
    private showPanel() {
        const q = new HtmlElementQuery("[event-panel]");
        q.removeStyle("display");
    }
    private addEventListnerToTextPanel() {
        const q = new HtmlElementQuery(".text-panel");
        q.click(this.textPanel_Click.bind(this));
    }
    private textPanel_Click(e: Event) {
        const element = e.srcElement as Element;
        const q = new HtmlElementQuery(element);
       
        alert(q.getInnerText());
    }
}


document.addEventListener("DOMContentLoaded", function () {
    const page = new HtmlElementQueryPage();
    page.initialize();
});
