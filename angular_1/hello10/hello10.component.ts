import { Component } from "@angular/core";

@Component({
    selector:'hello10',
    template:`{{test()}}`,

})


export class Hello10Component
{
    test()
    {
        return "from test() " +  this.test1() + this.test1('abc') + "\n" ;
    }
    test1(arg0?)
    {
        if(arg0 == null)
        {
            return "no value";
        }
        return "from test1()"
    }
} 