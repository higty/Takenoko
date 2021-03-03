export class HtmlElementQuery {
    private _elementList = new Array<Element>();

    constructor(value: string | Element | Array<Element>) {
        if (typeof value === "string") {
            const ee = document.querySelectorAll(value);
            for (var i = 0; i < ee.length; i++) {
                this._elementList.push(ee[i]);
            }
        }
        else if (value instanceof Element) {
            this._elementList.push(value);
        }
        else if (Array.isArray(value)) {
            for (var i = 0; i < value.length; i++) {
                this._elementList.push(value[i]);
            }
        }
    }

    public setStyle(name: string, value: string) {
        for (var i = 0; i < this._elementList.length; i++) {
            let element = this._elementList[i] as HTMLElement;
            element.style[name] = value;
        }
    }
    public removeStyle(name: string) {
        for (var i = 0; i < this._elementList.length; i++) {
            let element = this._elementList[i] as HTMLElement;
            element.style[name] = null;
        }
    }
    public setAttribute(name: string, value: string) {
        for (var i = 0; i < this._elementList.length; i++) {
            let element = this._elementList[i] as HTMLElement;
            element.setAttribute(name, value);
        }
    }

    public getInnerText() {
        if (this._elementList.length > 0) {
            let element = this._elementList[0] as HTMLElement;
            return element.textContent;
        }
        return "";
    }

    public hide() {
        for (var i = 0; i < this._elementList.length; i++) {
            let element = this._elementList[i] as HTMLElement;
            element.style["display"] = "none";
        }
    }

    public click(callback: EventListenerOrEventListenerObject) {
        for (var i = 0; i < this._elementList.length; i++) {
            let element = this._elementList[i] as HTMLElement;
            element.addEventListener("click", callback);
        }
    }
}