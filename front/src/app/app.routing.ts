import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/compiler/src/core';

import { HomeComponent } from './home/home.component';
import { RestaurantComponent } from './restaurant/restaurant.component';
import { DishComponent } from './dish/dish.component';
import { DishFormComponent } from './dish/dish-form/dish-form.component';
import { RestaurantFormComponent } from './restaurant/restaurant-form/restaurant-form.component';

const APP_ROUTES: Routes = [
    { path: '', component: HomeComponent },
    { path: 'restaurant', component: RestaurantComponent },
    { path: 'restaurant/novo', component: RestaurantFormComponent },
    { path: 'restaurant/:id', component: RestaurantFormComponent },
    { path: 'dish', component: DishComponent },
    { path: 'dish/novo', component: DishFormComponent },
    { path: 'dish/:id', component: DishFormComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(APP_ROUTES);
