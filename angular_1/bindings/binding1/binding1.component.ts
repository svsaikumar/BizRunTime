import { Component } from "@angular/core";

@Component({
    selector:'binding1',
    template:`
    <h1>heading</h1>
    <h1 style='color:blue;font-size:60px'>
        Hello h1(inline)
    </h1>
    <h1>Hello h1</h1>
    <div>I am from Div</div>
    <span>I am from span</span>
    <h1>Hello from h1</h1>
    <div>I am from Div</div>
    <span>I am from span</span>

    `,
    styles:['h1{color:green;font-size = 90px}',
            'div{color:blue;font-size =60px}',
            'span{color:red; font-size=40px}'
    ]
})

export class Binding1Component
{

}