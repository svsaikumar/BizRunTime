var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var parent1 = /** @class */ (function () {
    function parent1() {
    }
    parent1.prototype.test1 = function () {
        console.log("i am from parent");
    };
    return parent1;
}());
var child1 = /** @class */ (function (_super) {
    __extends(child1, _super);
    function child1() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    child1.prototype.test1 = function () {
        console.log(" i am child1");
    };
    return child1;
}(parent1));
var p1 = new parent1();
p1.test1();
var p2 = new child1();
p2.test1();
