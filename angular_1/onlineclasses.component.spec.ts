import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OnlineclassesComponent } from './onlineclasses.component';

describe('OnlineclassesComponent', () => {
  let component: OnlineclassesComponent;
  let fixture: ComponentFixture<OnlineclassesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OnlineclassesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OnlineclassesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
