import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewRegistrarionComponent } from './view-registrarion.component';

describe('ViewRegistrarionComponent', () => {
  let component: ViewRegistrarionComponent;
  let fixture: ComponentFixture<ViewRegistrarionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewRegistrarionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewRegistrarionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
