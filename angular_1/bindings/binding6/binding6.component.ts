import { Component } from "@angular/core";

@Component({
    selector:'binding6',
    template:   
    `
    p1 :<p class="c1">from p1 </p>
    p2 :<p class="c1 c2">from p2 </p>
    p3 :<p [class] = "test1">from p3 </p>
    p4 :<p class="{{test1}}"> from p4</p>
    p5 :<p [class] ="test2">from p5 </p>
    p6 : <p class="{{test2}}"> from p6 </p>
    p7 :<p [class] = "test1" [class]="test3">from p7 </p>
    p8 :<p class="{{test1}}" class="{{test3}}">from p8</p>
    p9 : <p [class] = "test3">from p9</p>
    p10 : <p class="{{test3}}">from p10</p>
        
    `,
    styles:[
        '.c1{color:blue}',
        '.c2{color:green}',
        '.c3{font-size:60px}',
    ]
})


export class Binding6Component
{
    test1 : string = "c1";
    test2 : string = "c2";
    test3 : string="c1 c3";

}