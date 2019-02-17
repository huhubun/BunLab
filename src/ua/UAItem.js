export class UAItem {
    constructor(propertyName, docUrl) {
        this.propertyName = propertyName;
        this.docUrl = docUrl;
    }

    get value() {
        return navigator[this.propertyName]
    }
}