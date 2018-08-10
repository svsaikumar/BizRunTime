import { Component } from "@angular/core";

@Component({

    selector:'binding2',
    template:`
        <h1 class='s1' style='color:blue; font-size:60px'>
            Hello h1(inline)
        </h1>
        <h1 clas='s1'>Hello h1</h1>
        <div class='s1'>I am from Div</div>
        <span class='s1'>I am from span</span>
        <p class='s1'>I am from para</p>
        <h1 class='s1'>I am from para</p>
        <span class='s1'>I am from span</span>
    
    
    `
    ,
    styles:['.s1{color:green; font-size=90px}']
})
export class Binding2Component
{

}