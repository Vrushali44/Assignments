import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HeadingClientComponent } from './heading-client.component';

describe('HeadingClientComponent', () => {
  let component: HeadingClientComponent;
  let fixture: ComponentFixture<HeadingClientComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HeadingClientComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HeadingClientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
