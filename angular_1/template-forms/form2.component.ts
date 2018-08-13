import { Component } from "@angular/core";

@Component({

    selector:'form2',
    template:
    `
    <form>
        <div class="form-group">
            First Name:<input id="firstName" type="text" class="form-control"/>
        </div>
        <input type="submit" class="btn btn-primary"/>
    </form>
    
    `
})

export class Form2Component
{
    
}