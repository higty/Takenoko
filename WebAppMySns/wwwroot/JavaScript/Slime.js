var Canvas = /** @class */ (function () {
    function Canvas() {
        this._panel = document.getElementById("Canvas");
    }
    Canvas.prototype.initialize = function () {
        var bt = document.getElementById("StartButton");
        bt.addEventListener("click", this.StartButton_Click.bind(this));
        var div = this._panel;
        div.innerHTML = "";
        for (var i = 0; i < 255; i++) {
            var span = document.createElement("span");
            span.classList.add("dot");
            //span.innerText = div.children.length.toString();
            div.appendChild(span);
        }
    };
    Canvas.prototype.StartButton_Click = function () {
        var slime = new Slime();
        slime.loadData();
        this.Draw(slime.getColorList());
    };
    Canvas.prototype.Draw = function (colorList) {
        var div = this._panel;
        for (var i = 0; i < colorList.length; i++) {
            var colorData = colorList[i];
            var span = div.children[colorData.index];
            span.style["background-color"] = colorData.color;
        }
    };
    return Canvas;
}());
var Slime = /** @class */ (function () {
    function Slime() {
        this._ColorList = new Array();
        this.Blue = "#0b9baf";
        this.White = "#ffffff";
        this.Red = "#da349c";
    }
    Slime.prototype.loadData = function () {
        this._ColorList = new Array();
        this.setColorList(this.getBlueList(), this.Blue);
        this.setColorList(this.getWhiteList(), this.White);
        this.setColorList(this.getRedList(), this.Red);
    };
    Slime.prototype.getBlueList = function () {
        var l = new Array();
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
    };
    Slime.prototype.getWhiteList = function () {
        var l = new Array();
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
        return l;
    };
    Slime.prototype.getRedList = function () {
        var l = new Array();
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
    };
    Slime.prototype.setColorList = function (indexList, color) {
        for (var i = 0; i < indexList.length; i++) {
            var colorData = new ColorData();
            colorData.index = indexList[i];
            colorData.color = color;
            this._ColorList.push(colorData);
        }
    };
    Slime.prototype.getColorList = function () {
        return this._ColorList;
    };
    return Slime;
}());
var ColorData = /** @class */ (function () {
    function ColorData() {
    }
    return ColorData;
}());
document.addEventListener("DOMContentLoaded", function () {
    var page = new Canvas();
    page.initialize();
});
//# sourceMappingURL=Slime.js.map