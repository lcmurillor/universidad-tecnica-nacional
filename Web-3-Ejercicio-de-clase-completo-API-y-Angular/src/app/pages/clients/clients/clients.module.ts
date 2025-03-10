import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientsRoutingModule } from './clients-routing.module';
import { ClientsComponent } from './clients.component';
import { MaterialModule } from 'src/app/material.module';
import { MatPaginatorModule } from '@angular/material/paginator';


@NgModule({
  declarations: [
    ClientsComponent
  ],
  imports: [
    CommonModule,
    ClientsRoutingModule,
    MaterialModule,
    MatPaginatorModule
  ]
})
export class ClientsModule { }
