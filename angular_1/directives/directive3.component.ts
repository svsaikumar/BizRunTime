import { Component } from "@angular/core";

@Component({
    selector:'directive3',
    template:
    `
    <div *ngIf="coursesAvailable(); else noCourses">courses available
    </div>
    <ng-template #noCourses>
        no courses available
    </ng-template>
    `
})


export class Directive3Component
{
    courses=['java', 'j2ee', 'c'];
    coursesAvailable() : boolean
    {
        return this.courses.length > 0;
    }
}