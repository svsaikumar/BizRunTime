import { Component } from '@angular/core';

@Component({

    selector:'hello4',
    template:`<p> i am from Hello4 component</p>
            title is {{title}} <br>
            name is {{name}} <br>
            age is {{age}} <br>
            email is  {{email}} <br>
            city is {{city}}
 
    `,
    styles:['p{color:red']

})


export class Hello4Component
{
    title="angular";
    name ="saikumar";
    age = 20;
    email = 'sai@gmail.com';
    city = 'banglore';

}