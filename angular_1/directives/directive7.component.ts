import { Component } from "@angular/core";

@Component({
    selector:'directive7',
    template:
    `


    <ul>
        <li *ngFor="let c1 of courses">
                {{ "Course with " + c1.id + "  and name " + c1.name }}
        <li>
    <ul>   
    `
})
export class Directive7Component
{
    courses = [
                    {id: 1, name: 'java'},
                    {id: 2, name: 'j2ee'},
                    {id: 3, name: 'angular'},
                    {id: 4, name: 'hadoop'}
              ];
}