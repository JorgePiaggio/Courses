import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoadWarrantyComponent } from './load-warranty.component';

describe('LoadWarrantyComponent', () => {
  let component: LoadWarrantyComponent;
  let fixture: ComponentFixture<LoadWarrantyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoadWarrantyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoadWarrantyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
