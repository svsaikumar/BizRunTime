import { Component } from "@angular/core";

@Component({
    selector:'directive4',
    template:
    `
    <div *ngIf="coursesAvailable(); then coursesList else noCourses">
    </div>
    <ng-template #coursesList>courses available</ng-template>
    <ng-template #noCourses>
        no courses available
    </ng-template>
    `
})


export class Directive4Component
{
    courses=['java', 'j2ee', 'c'];
    coursesAvailable() : boolean
    {
        return this.courses.length > 0;
    }
}