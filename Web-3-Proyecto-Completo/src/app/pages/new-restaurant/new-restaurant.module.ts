import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NewRestaurantRoutingModule } from './new-restaurant-routing.module';
import { NewRestaurantComponent } from './new-restaurant.component';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatStepperModule } from '@angular/material/stepper';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [NewRestaurantComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  imports: [
    CommonModule,
    NewRestaurantRoutingModule,
    MatIconModule,
    MatInputModule,
    MatStepperModule,
    ReactiveFormsModule,
    MatButtonModule,
    HttpClientModule
  ]
})
export class NewRestaurantModule {
  telefonos:string[];
 }
