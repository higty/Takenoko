export function $(value: string | Element | Array<Element>): HtmlElementQuery {
    return new HtmlElementQuery(value);
}

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

    public getValue(): string {
        if (this._elementList.length > 0) {
            const element = this._elementList[0] as HTMLInputElement;
            if (element === null) { return ""; }
            if (element.value == null) { return ""; }
            return element.value;
        }
        return "";
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

    private addEventListenerToAllElement(eventName: string, callback: EventListenerOrEventListenerObject) {
        for (var i = 0; i < this._elementList.length; i++) {
            let element = this._elementList[i] as HTMLElement;
            element.addEventListener(eventName, callback);
        }
    }
    public click(callback: EventListenerOrEventListenerObject) {
        this.addEventListenerToAllElement("click", callback);
    }
    public mouseover(callback: EventListenerOrEventListenerObject) {
        this.addEventListenerToAllElement("mouseover", callback);
    }
    public mouseout(callback: EventListenerOrEventListenerObject) {
        this.addEventListenerToAllElement("mouseout", callback);
    }
    public focus(callback: EventListenerOrEventListenerObject) {
        this.addEventListenerToAllElement("focus", callback);

    }
}