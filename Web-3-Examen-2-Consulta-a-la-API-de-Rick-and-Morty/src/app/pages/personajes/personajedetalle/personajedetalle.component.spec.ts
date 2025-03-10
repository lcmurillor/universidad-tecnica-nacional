import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonajedetalleComponent } from './personajedetalle.component';

describe('PersonajedetalleComponent', () => {
  let component: PersonajedetalleComponent;
  let fixture: ComponentFixture<PersonajedetalleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonajedetalleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonajedetalleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
