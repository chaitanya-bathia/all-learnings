import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GreaterComponent } from './greater.component';

describe('GreaterComponent', () => {
  let component: GreaterComponent;
  let fixture: ComponentFixture<GreaterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GreaterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GreaterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
