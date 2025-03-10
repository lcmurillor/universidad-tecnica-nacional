import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SesionModalComponent } from './sesion-modal.component';

describe('SesionModalComponent', () => {
  let component: SesionModalComponent;
  let fixture: ComponentFixture<SesionModalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SesionModalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SesionModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
