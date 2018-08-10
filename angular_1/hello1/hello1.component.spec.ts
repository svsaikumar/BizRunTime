import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Hello1Component } from './hello1.component';

describe('Hello1Component', () => {
  let component: Hello1Component;
  let fixture: ComponentFixture<Hello1Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Hello1Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Hello1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
