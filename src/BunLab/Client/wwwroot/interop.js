window.getNavigatorProperty = function (propertyName) {
    return window.navigator[propertyName].toString()
}

window.initClipboard = function (selector){
    new ClipboardJS(selector || '.can-copied')
}
