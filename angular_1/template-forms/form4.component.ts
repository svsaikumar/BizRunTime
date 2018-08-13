import { Component } from "@angular/core";

@Component({
selector:'form4',
template:
`
    <form>
        <div class="form-group">
            First Name
                <input required
                    ngModel
                    name="firstName"
                    #firstName="ngModel"
                    type="text"
                    class="form-control"/>

                        <div class="alert alert-danger"
                            *ngIf="firstName.touched && !firstName.valid">
                            First Name is required
                        </div>
        </div>
        <div class="form-group">
            Address
            <textarea required
                    ngModel
                    name="Address"
                    #address="ngModel"
                    type="text"
                    class="form-control">
                </textarea>

                <div class="alert alert-danger"
                    *ngIf="address.touched && !address.valid">
                    address is required
                </div>
        </div>
        <input type="submit" class="btn btn-primary"/>
    </form>
`
})
export class Form4Component
{

}