var global_scope = "hello";
class global1
{
    test() : void{
        console.log(global_scope)
    }
}
var g = new global1();
g.test();