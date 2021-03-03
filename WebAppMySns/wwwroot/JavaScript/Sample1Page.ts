import { HtmlElementQuery } from "./HtmlElementQuery.js";

class Sample1Page {
    public initialize() {
        this.setPanel1();
        this.setPanel2();
        this.setPanel3();
        document.getElementById("ColorChangeButton").addEventListener("click", this.colorChangeButton_Click.bind(this));
    }
    private setPanel1() {
        const q = new HtmlElementQuery("#Panel1");
        q.setStyle("background-color", "#48d1cc");
    }
    private setPanel2() {
        const q = new HtmlElementQuery("#Panel2");
        q.setStyle("background-color", "#afeeee");
    }
    private setPanel3() {
        const q = new HtmlElementQuery("#Panel3");
    }
    private colorChangeButton_Click(e: Event) {
        const q = new HtmlElementQuery("#ColorText");
        const q1 = new HtmlElementQuery("#Panel3")
        const s = q.getValue();
        q1.setStyle("background-color", s);
    }
  
}
document.addEventListener("DOMContentLoaded", function () {
    const page = new Sample1Page();
        page.initialize();
    });
