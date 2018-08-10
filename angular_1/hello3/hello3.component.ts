import { Component }  from '@angular/core';



@Component({
    selector:'hello3',
    template:`<p>i am from hello3 component
    {{title}} <br>

    {{sayHello()}}
    
    `,
    styles:['{color:blue}']

})


export class Hello3Component
{
    title = "hello from Hello3Component";
    sayHello()
    {
        return "from sayHello()"
    }
}