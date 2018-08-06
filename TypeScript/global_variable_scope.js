var global_scope = "hello";
var global = /** @class */ (function () {
    function global() {
    }
    global.prototype.test = function () {
        console.log(global_scope);
    };
    return global;
}());
var g = new global();
g.test();
