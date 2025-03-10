import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-personajedetalle',
  templateUrl: './personajedetalle.component.html',
  styleUrls: ['./personajedetalle.component.css']
})
export class PersonajedetalleComponent implements OnInit {

  formato!: FormGroup;
  image!: string;
  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb: FormBuilder,

  ) { }

  ngOnInit(): void {
    this.cagarFormato()
    this.cargarDatos()
  }

  private cargarDatos(): void {
    this.formato.patchValue({
      id: this.data?.personaje?.id,
      name: this.data?.personaje?.name,
      status: this.data?.personaje?.status,
      species: this.data?.personaje?.species,
      gender: this.data?.personaje?.gender
    })
    this.image = this.data?.personaje?.image
  }


  private cagarFormato(): void {
    this.formato = this.fb.group({
      id: [''],
      name: [''],
      status: [''],
      species: [''],
      gender: ['']
    })
  }




}
