import { Component } from "@angular/core";

@Component({
selector:'binding7',
template:`
<button (click) = "sayHello()">Click Me </button><br>
<div (click) = "sayHello()">From DIV</div>
<select (change)="sayHello()">
    <option value="1">OPTION1</option>
    <option value="2">OPTION2</option>
    <option value="3">OPTION3</option>
    <option value="4">OPTION4</option>
</select><br>
<input type="text" (blur)="sayHello()"/>

`
 
})


export class Binding7Component
{
    sayHello()
    {
        console.log("from sayHello()");
    }
}