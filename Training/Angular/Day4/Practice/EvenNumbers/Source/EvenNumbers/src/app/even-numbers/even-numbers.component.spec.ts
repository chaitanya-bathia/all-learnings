import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EvenNumbersComponent } from './even-numbers.component';

describe('EvenNumbersComponent', () => {
  let component: EvenNumbersComponent;
  let fixture: ComponentFixture<EvenNumbersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EvenNumbersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EvenNumbersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
