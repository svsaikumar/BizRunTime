var A = /** @class */ (function () {
    function A() {
    }
    A.prototype.test = function () {
        console.log("i am from test");
    };
    return A;
}());
var obj = new A();
obj.test();
