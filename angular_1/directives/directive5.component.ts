import { Component } from "@angular/core";

@Component({

selector:'directive5',
template:
`
    <div [hidden]="coursesAvailable()">
            courses Available
    </div>

    <div [hidden] ="!coursesAvailable()">
            courses Available
    </div>
`
})



export class Directive5Component
{
    courses =['JAVA', 'J2EE', 'ANGULAR'];
    coursesAvailable() : boolean
    {
        return this.courses.length > 0;
    }
}