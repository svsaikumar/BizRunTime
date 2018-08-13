import { BrowserModule } from '@angular/platform-browser';

import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { Hello1Component } from './hello1/hello1.component';
import { Hello2Component } from './hello2/hello2.component';
import { Hello3Component } from './hello3/hello3.component';
import { Hello4Component } from './hello4/hello4.component';
import { Hello7Component } from './hello7/hello7.component';
import { Hello8Component, A } from './hello8/hello8.component';
import { Hello9Component } from '../hello9/hello9.component';
import { Person } from '../hello9/Person';
import { Hello10Component } from './hello10/hello10.component';
import { Hello11Component } from './hello11/hello11.component';
import { Binding1Component } from './bindings/binding1/binding1.component';
import { Binding2Component } from './bindings/binding2/binding2.component';
import { Binding3Component } from './bindings/binding3/binding3.component';
import { Binding4Component } from './bindings/binding4/binding4.component';
import { Binding5Component } from './bindings/binding5/binding5.component';
import { Binding6Component } from './bindings/binding6/binding6.component';
import { Binding7Component } from './bindings/binding7/binding7.component';
import { Directive1Component } from './directives/directive1.component';
import { Directive2component } from './directives/directive2.component';
import { Directive3Component } from './directives/directive3.component';
import { Directive4Component } from './directives/directive4.component';
import { Directive5Component } from './directives/directive5.component';
import { Directive6Component } from './directives/directive6.component';
import { Directive7Component } from './directives/directive7.component';
import { Directive8Component } from './directives/directive8.component';
import { Directive9Component } from './directives/directive9.component';
import { Form1Component } from './template-forms/form1.component';
import { Form2Component } from './template-forms/form2.component';
import { Form3Component } from './template-forms/form3.component';
import { Form4Component } from './template-forms/form4.component';


@NgModule({
  declarations: [
    AppComponent,
   
    
    Hello2Component,
    Hello1Component,
    Hello3Component,
    Hello4Component,
    Hello7Component,
    Hello8Component,
    Hello9Component,
    Hello10Component,
    Hello11Component,

    Binding1Component,
    Binding2Component,
    Binding3Component,
    Binding4Component,
    Binding5Component,
    Binding6Component,
    Binding7Component,
   
    Directive1Component,
    Directive2component,
    Directive3Component,
    Directive4Component,
    Directive5Component,
    Directive6Component,
    Directive7Component,
    Directive8Component,
    Directive9Component,
    Form1Component,
    Form2Component,
    Form3Component,
    Form4Component


  ],
  imports: [
    BrowserModule,
    FormsModule,
  ],
  providers: [A,Person],
  bootstrap: [AppComponent]
})
export class AppModule { }
