class Slime {
    private _BlueList = new Array<number>();
    private _WhiteList = new Array<number>();
    private _RedList = new Array<number>();

    public Blue = "#0b9baf";
    public White = "#ffffff";
    public Red = "#da349c";

    public initialize() {
        const bt = document.getElementById("StartButton");
        bt.addEventListener("click", this.StartButton_Click.bind(this));

        this.initializeBlueList();
        this.initializeWhiteList();
        this.initializeRedList();
    }
    private initializeBlueList() {
        const l = this._BlueList;
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

    }
    private initializeWhiteList() {
        const l = this._WhiteList;
        l.push(107);
        l.push(108);
        l.push(121);
        l.push(122);
        l.push(136);

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
    }
    private initializeRedList() {
        const l = this._RedList;
        l.push(183);
        l.push(198);
        l.push(199);

        for (var i = 214; i < 221; i++) {
            l.push(i);
        }
        l.push(205);
        l.push(206);
        l.push(191);

    }

    private StartButton_Click() {
        const div = document.getElementById("SlimePanel");

        this.Blue = (document.getElementById("BlueTextBox") as HTMLInputElement).value;
        this.White = (document.getElementById("WhiteTextBox") as HTMLInputElement).value;
        this.Red = (document.getElementById("RedTextBox") as HTMLInputElement).value;

        div.innerHTML = "";
        for (var i = 0; i < 255; i++) {
            const span = document.createElement("span") as HTMLElement;
            span.classList.add("dot");
            //span.innerText = div.children.length.toString();
            div.appendChild(span);
        }
        for (var i = 0; i < this._BlueList.length; i++) {
            var index = this._BlueList[i];
            var span = div.children[index] as HTMLElement;
            span.style["background-color"] = this.Blue;
        }
        for (var i = 0; i < this._WhiteList.length; i++) {
            var index = this._WhiteList[i];
            var span = div.children[index] as HTMLElement;
            span.style["background-color"] = this.White;
        }
        for (var i = 0; i < this._RedList.length; i++) {
            var index = this._RedList[i];
            var span = div.children[index] as HTMLElement;
            span.style["background-color"] = this.Red;
        }
    }
}


document.addEventListener("DOMContentLoaded", function () {
    const page = new Slime();
    page.initialize();
});

