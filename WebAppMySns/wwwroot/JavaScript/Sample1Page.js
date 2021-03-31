import { $ } from "./HtmlElementQuery.js";
class Sample1Page {
    initialize() {
        this.setPanel1();
        this.setPanel2();
        this.setPanel3();
        document.getElementById("ColorChangeButton").addEventListener("click", this.colorChangeButton_Click.bind(this));
    }
    setPanel1() {
        const q = $("#Panel1");
        q.setStyle("background-color", "#48d1cc");
    }
    setPanel2() {
        const q = $("#Panel2");
        q.setStyle("background-color", "#afeeee");
    }
    setPanel3() {
        const q = $("#Panel3");
    }
    colorChangeButton_Click(e) {
        const q = $("#ColorText");
        const q1 = $("#Panel3");
        const s = q.getValue();
        q1.setStyle("background-color", s);
    }
}
document.addEventListener("DOMContentLoaded", function () {
    const page = new Sample1Page();
    page.initialize();
});
//# sourceMappingURL=Sample1Page.js.map