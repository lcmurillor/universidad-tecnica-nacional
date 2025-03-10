import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RestaurantRoutingModule } from './restaurant-routing.module';
import { RestaurantComponent } from './restaurant.component';
import { SliderComponent } from '../slider/slider.component';
import { MaterialModule } from 'src/app/material.module';
import { TreeComponent } from '../tree/tree.component';
import { GridComponent } from '../grid/grid.component';
import { NavmenuComponent } from '../navmenu/navmenu.component';
import { MatcardComponent } from '../matcard/matcard.component';
import { HeaderComponent } from '../../header/header.component';



@NgModule({
  declarations: [RestaurantComponent, 
    SliderComponent,
    TreeComponent,
    GridComponent,
    NavmenuComponent,
    MatcardComponent],
    
  imports: [
    CommonModule,
    RestaurantRoutingModule,
    MaterialModule,
  ]
})
export class RestaurantModule { }
