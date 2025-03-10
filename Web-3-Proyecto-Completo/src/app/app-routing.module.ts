import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{ path: 'home', loadChildren: () => import('./pages/home/home.module').then(m => m.HomeModule) }, 
                        { path: 'new-user', loadChildren: () => import('./pages/new-user/new-user.module').then(m => m.NewUserModule) },
                        { path: 'new-restaurant', loadChildren: () => import('./pages/new-restaurant/new-restaurant.module').then(m => m.NewRestaurantModule) },
                        { path: 'update-user', loadChildren: () => import('./pages/update-user/update-user.module').then(m => m.UpdateUserModule) },
                        { path: 'restaurant/:id', loadChildren: () => import('./shared/components/restaurant/restaurant/restaurant.module').then(m => m.RestaurantModule) }
                      ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
