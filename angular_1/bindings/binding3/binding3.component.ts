import { Component } from "@angular/core";

@Component({
    selector:'binding3',
    template:
    `
    <p [style.color]="test ? 'blue' : 'green'">Para content</p>
    <div [style.color]="test1">Div content</div>
    <span [style.font-size] = "test" [style.color]="test1">
    span content
    </span>
    `
})

export class Binding3Component
{
    test  : boolean = true;
    test1 : string = "red";
    test2 : string ="50px";

}