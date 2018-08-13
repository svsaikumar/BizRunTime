import { Component } from "@angular/core";

@Component({
    selector:'directive2',
    template:
    `
        <div *ngIf="coursesAvailable()">
            courses available
        </div>

        <div *ngIf="!coursesAvailable()">
            no courses available
        </div>
    
    `
})

export class Directive2component
{
    courses = ['Java', 'J2EE', 'ANGULAR']

    coursesAvailable() : boolean
    {
        return this.courses.length > 0;
    }
}