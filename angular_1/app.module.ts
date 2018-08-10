import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { Hello2Component } from './hello2/hello2.component';
import { Hello1Component } from './hello1/hello1.component';
import { Hello3Component } from './hello3/hello3.component';
import { Hello4Component } from './hello4/hello4.component';
import { Hello7Component } from './hello7/hello7.component';
import { Hello8Component, A } from './hello8/hello8.component';
import { Hello9Component } from '../hello9/hello9.component';
import { Person } from '../hello9/Person';
import { Hello10Component } from './hello10/hello10.component';
import { Binding1Component } from './bindings/binding1/binding1.component';

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
    Binding1Component
    
  ],
  imports: [
    BrowserModule
  ],
  providers: [A,Person],
  bootstrap: [AppComponent]
})
export class AppModule { }
