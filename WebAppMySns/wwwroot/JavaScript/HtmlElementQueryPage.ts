import { HtmlElementQuery } from "./HtmlElementQuery.js";

class HtmlElementQueryPage {
    public initialize() {
        const q = new HtmlElementQuery("div");
        q.setStyle("background-color", "#ff0000");
        q.setStyle("color", "#fffff");
        q.setStyle("width", "200px");
        q.setStyle("margin-bottom", "10px");
        q.setStyle("padding", "10px");
    }
}


document.addEventListener("DOMContentLoaded", function () {
    const page = new HtmlElementQueryPage();
    page.initialize();
});
