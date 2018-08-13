import { Component } from "@angular/core";

@Component({

    selector:'form3',
    template:
    `
        <form>
            <div class="form-group">
                First Name:<input id="firstName" type="text" class="form-control"/>
            </div>
           
      
        <div class="form-group">
        Address
            <textarea id="address" type="text" class="form-control"></textarea> 
        </div>
        <input type="submit" class="btn btn-primary"/>
        </form> 
    `
})

export class Form3Component
{
    
}