function test() {
    console.log("i am from test");
}
test();
function test1(text) {
    console.log(text);
}
test1("helo");
function test2(text, data) {
    console.log(text);
    console.log(data);
}
test2("hello", 10);
function test3(num1, num2) {
    return num1 + num2;
}
var total = test3(10, 20);
console.log("sum is:" + total);
