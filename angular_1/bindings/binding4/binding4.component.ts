import { Component } from "@angular/core";

@Component({
    selector:'binding4',
    template:
    `
    <p [class]="test">Para content</p>
    <div [class] = "test1">Div content </div>
    <span [class] = "test2">span content</span>

    `,
    styles:['.c1{color:blue; font-size:20px}',
            '.c2{color:red;font-size:60px}',
            '.c3{color:green; font-size:120px}',
            '.c4{background-color:black}'
        ]
  
    ,
})
 
export class Binding4Component
{ 
    test  : string = "c1";
    test1 : string = "c2";
    test2 : string = "c3 c4";
}