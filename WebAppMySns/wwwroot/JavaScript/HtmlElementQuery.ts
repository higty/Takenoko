export class HtmlElementQuery {
    private _elementList = new Array<Element>();

    constructor(selector: string) {
        const ee = document.querySelectorAll(selector);
        for (var i = 0; i < ee.length; i++) {
            this._elementList.push(ee[i]);
        }
    }

    public setStyle(name: string, value: string) {
        for (var i = 0; i < this._elementList.length; i++) {
            let element = this._elementList[i] as HTMLElement;
            element.style[name] = value;
        }
    }

}