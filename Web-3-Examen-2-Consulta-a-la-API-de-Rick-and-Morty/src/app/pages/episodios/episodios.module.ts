import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EpisodiosRoutingModule } from './episodios-routing.module';
import { EpisodiosComponent } from './episodios.component';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';


@NgModule({
  declarations: [
    EpisodiosComponent
  ],
  imports: [
    CommonModule,
    EpisodiosRoutingModule,
    MatTableModule,
    MatPaginatorModule
  ]
})
export class EpisodiosModule { }
