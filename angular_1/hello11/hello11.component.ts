import { Component } from "@angular/core";

class Test
{
    constructor(arg0?, arg1 ? )
    {

    }
}
@Component({

    selector:'hello11',
    template:`from hello11 component`,
})


export class Hello11Component
{
    test1()
    {
        var v1 = new Test('abc');  
        var v2 = new Test(100);
        var v3 = new Test();
        var v4 = new Test(100,200);
    }
}