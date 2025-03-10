import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UsersComponent } from './users.component';
import { MaterialModule } from 'src/app/material.module';
import { MatPaginatorModule } from '@angular/material/paginator';
import { UsersRoutingModule } from './users-routing.module';
import { ModalUserComponent } from '../modal-user/modal-user.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    UsersComponent,
    ModalUserComponent
  ],
  imports: [
    CommonModule,
    UsersRoutingModule,
    MaterialModule,
    MatPaginatorModule,
    ReactiveFormsModule
  ]
})
export class UsersModule { }
