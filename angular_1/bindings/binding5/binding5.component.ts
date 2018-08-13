import { Component } from "@angular/core";

@Component({

    selector:'binding5',
    template:
    `
    p1:<p style='color:blue;font-size:60px'>
        Hello from p1(inline)
        </p>

    p2:<p [style]="test1">Hello from p2 (inline)</p>
    p3: <p style="{{test1}}">Hello from p3 (inline)</p>
    p4 : <p [style.color]="test2">Hello from p4 (inline)</p>
    p5 : <p style.color ="{{test2}}">Hello from p5 (inline)</p>
    p6 : <p [style.font-size] = "test3">Hello from p6 (inline)</p>
    p7 : <p style.font-size="{{test3}}">Hello from p7 (inline)</p>
    p8 : <p [style.color]="test2" [style.font-size]="test3">
                Hello from p8 (inline)
                </p>
    p9:<p style.color="{{test2}}" style.font-size="{{test3}}">
    Hello from p9 (inline)</p>
    
    `
})


export class Binding5Component
{
    test1: string ="color:green";
    test2: string = "green";
    test3: string= "150px";
}