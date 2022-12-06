import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AtlanticComponent } from './atlantic.component';

describe('AtlanticComponent', () => {
  let component: AtlanticComponent;
  let fixture: ComponentFixture<AtlanticComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AtlanticComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AtlanticComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
