var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Canvas = /** @class */ (function () {
    function Canvas() {
        this._panel = document.getElementById("Canvas");
    }
    Canvas.prototype.initialize = function () {
        document.getElementById("SlimeButton").addEventListener("click", this.SlimeButton_Click.bind(this));
        document.getElementById("PeachSlimeButton").addEventListener("click", this.PeachSlimeButton_Click.bind(this));
        document.getElementById("MetalSlimeButton").addEventListener("click", this.MetalSlimeButton_Click.bind(this));
        document.getElementById("SizeSlider").addEventListener("change", this.SizeSlider_Change.bind(this));
        var div = this._panel;
        div.innerHTML = "";
        for (var i = 0; i < 255; i++) {
            var span = document.createElement("span");
            span.classList.add("dot");
            //span.innerText = div.children.length.toString();
            div.appendChild(span);
        }
    };
    Canvas.prototype.SlimeButton_Click = function () {
        var slime = new Slime();
        this.Draw(slime.getColorList());
    };
    Canvas.prototype.PeachSlimeButton_Click = function () {
        var s = new PeachSlime();
        this.Draw(s.getColorList());
    };
    Canvas.prototype.MetalSlimeButton_Click = function () {
        var s = new MetalSlime();
        this.Draw(s.getColorList());
    };
    Canvas.prototype.SizeSlider_Change = function (e) {
        var v = parseInt(document.getElementById("SizeSlider").value);
        var div = this._panel;
        for (var i = 0; i < 255; i++) {
            var span = div.children[i];
            span.style["width"] = v + "px";
            span.style["height"] = v + "px";
        }
        div.style["width"] = (v * 15) + "px";
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
        this.BodyColor = "#0b9baf";
        this.HighlightColor = "#dddddd";
        this.EyeColor = "#ffffff";
        this.MouseColor = "#da349c";
    }
    Slime.prototype.loadData = function () {
        this._ColorList = new Array();
        this.setColorList(this.getBodyColorList(), this.BodyColor);
        this.setColorList(this.getHighlightColorList(), this.HighlightColor);
        this.setColorList(this.getEyeColorList(), this.EyeColor);
        this.setColorList(this.getMouseColorList(), this.MouseColor);
    };
    Slime.prototype.getBodyColorList = function () {
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
    Slime.prototype.getHighlightColorList = function () {
        var l = new Array();
        l.push(107);
        l.push(108);
        l.push(121);
        l.push(122);
        l.push(136);
        return l;
    };
    Slime.prototype.getEyeColorList = function () {
        var l = new Array();
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
    Slime.prototype.getMouseColorList = function () {
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
        this.loadData();
        return this._ColorList;
    };
    return Slime;
}());
var PeachSlime = /** @class */ (function (_super) {
    __extends(PeachSlime, _super);
    function PeachSlime() {
        var _this = _super.call(this) || this;
        _this.BodyColor = "#fb9baf";
        _this.HighlightColor = "#ffecfa";
        return _this;
    }
    return PeachSlime;
}(Slime));
var MetalSlime = /** @class */ (function (_super) {
    __extends(MetalSlime, _super);
    function MetalSlime() {
        var _this = _super.call(this) || this;
        _this.BodyColor = "#999999";
        return _this;
    }
    return MetalSlime;
}(Slime));
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