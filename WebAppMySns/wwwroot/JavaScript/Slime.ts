class Canvas {
    private _panel = document.getElementById("Canvas") as HTMLElement;

    public initialize() {
        document.getElementById("SlimeButton").addEventListener("click", this.SlimeButton_Click.bind(this));
        document.getElementById("PeachSlimeButton").addEventListener("click", this.PeachSlimeButton_Click.bind(this));
        document.getElementById("MetalSlimeButton").addEventListener("click", this.MetalSlimeButton_Click.bind(this));
        document.getElementById("SizeSlider").addEventListener("change", this.SizeSlider_Change.bind(this));

        const div = this._panel;
        div.innerHTML = "";
        for (var i = 0; i < 255; i++) {
            const span = document.createElement("span") as HTMLElement;
            span.classList.add("dot");
            //span.innerText = div.children.length.toString();
            div.appendChild(span);
        }
    }

    private SlimeButton_Click() {
        const slime = new Slime();
        this.Draw(slime.getColorList());
    }
    private PeachSlimeButton_Click() {
        const s = new PeachSlime();
        this.Draw(s.getColorList());
    }
    private MetalSlimeButton_Click() {
        const s = new MetalSlime();
        this.Draw(s.getColorList());
    }
    private SizeSlider_Change(e: Event) {
        const v = parseInt((document.getElementById("SizeSlider") as HTMLInputElement).value);
        const div = this._panel;
        for (var i = 0; i < 255; i++) {
            let span = div.children[i] as HTMLElement;
            span.style["width"] = v + "px";
            span.style["height"] = v + "px";
        }
        div.style["width"] = (v * 15) + "px";
    }
    public Draw(colorList: Array<ColorData>) {
        const div = this._panel;
        for (var i = 0; i < colorList.length; i++) {
            var colorData = colorList[i];
            var span = div.children[colorData.index] as HTMLElement;
            span.style["background-color"] = colorData.color;
        }
    }
}


class Slime {
    private _ColorList = new Array<ColorData>();
    protected BodyColor = "#0b9baf";
    protected HighlightColor = "#dddddd";
    protected EyeColor = "#ffffff";
    protected MouseColor = "#da349c";

    private loadData() {
        this._ColorList = new Array<ColorData>();
        this.setColorList(this.getBodyColorList(), this.BodyColor);
        this.setColorList(this.getHighlightColorList(), this.HighlightColor);
        this.setColorList(this.getEyeColorList(), this.EyeColor);
        this.setColorList(this.getMouseColorList(), this.MouseColor);
    }
    private getBodyColorList(): Array<number> {
        const l = new Array<number>();
        l.push(7);
        l.push(22);
        l.push(37);

        l.push(51);
        l.push(52);
        l.push(53);

        //5
        for (var i = 65; i < 70; i++) {
            l.push(i);
        }
        //9
        for (var i = 78; i < 87; i++) {
            l.push(i);
        }
        //11
        for (var i = 92; i < 92 + 11; i++) {
            l.push(i);
        }
        //13
        for (var i = 106; i < 106 + 13; i++) {
            l.push(i);
        }
        //横幅全部
        for (var i = 120; i < 195; i++) {
            l.push(i);
        }
        //13
        for (var i = 196; i < 196 + 13; i++) {
            l.push(i);
        }
        //9
        for (var i = 213; i < 213 + 9; i++) {
            l.push(i);
        }

        for (var i = 0; i < l.length; i++) {
            l[i] = l[i] + 15;
        }
        return l;
    }
    private getHighlightColorList(): Array<number> {
        const l = new Array<number>();
        l.push(107);
        l.push(108);
        l.push(121);
        l.push(122);
        l.push(136);

        return l;
    }
    private getEyeColorList(): Array<number> {
        const l = new Array<number>();

        l.push(140);
        l.push(154);
        l.push(156);
        l.push(169);
        l.push(171);
        l.push(185);

        l.push(144);
        l.push(158);
        l.push(160);
        l.push(173);
        l.push(175);
        l.push(189);

        return l;
    }
    private getMouseColorList(): Array<number> {
        const l = new Array<number>();
        l.push(183);
        l.push(198);
        l.push(199);

        for (var i = 214; i < 221; i++) {
            l.push(i);
        }
        l.push(205);
        l.push(206);
        l.push(191);

        return l;
    }
    private setColorList(indexList: Array<number>, color: string) {
        for (var i = 0; i < indexList.length; i++) {
            let colorData = new ColorData();
            colorData.index = indexList[i];
            colorData.color = color;
            this._ColorList.push(colorData);
        }
    }

    public getColorList(): Array<ColorData> {
        this.loadData();
        return this._ColorList;
    }
}

class PeachSlime extends Slime {
    constructor() {
        super();
        this.BodyColor = "#fb9baf";
        this.HighlightColor = "#ffecfa";
    }
}

class MetalSlime extends Slime {
    constructor() {
        super();
        this.BodyColor = "#999999";
    }
}

class ColorData {
    public index: number;
    public color: string;
}
document.addEventListener("DOMContentLoaded", function () {
    const page = new Canvas();
    page.initialize();

});

