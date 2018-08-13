import { Component } from "@angular/core";

@Component({

selector:'directive1',
template:
`
    <div *ngIf="courses.length > 0"> courses available</div>
    <div *ngIf="courses.length == 0">no courses available</div>
`  
})

export class Directive1Component
{
    courses=["java", 'c', 'c++'];
    //courses =[]; 
}