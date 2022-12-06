import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IndiaUSAComponent } from './india-usa.component';

describe('IndiaUSAComponent', () => {
  let component: IndiaUSAComponent;
  let fixture: ComponentFixture<IndiaUSAComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IndiaUSAComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(IndiaUSAComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
