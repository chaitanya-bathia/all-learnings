import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PacificComponent } from './pacific.component';

describe('PacificComponent', () => {
  let component: PacificComponent;
  let fixture: ComponentFixture<PacificComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PacificComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PacificComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
