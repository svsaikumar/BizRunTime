import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello1',
  template: `<p>{{country}}</p>, {{getHello()}}
  <p>ok character</p>
  `,
  styles: ['p{color:red}']
})
export class Hello1Component implements OnInit {

  country="Bharat";
  getHello()
  {
    return "from getHello()"
  }
  
  constructor() { }

  ngOnInit() {
  }

}
