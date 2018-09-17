import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { RestaurantComponent } from './restaurant.component';
import { RestaurantService } from './service/restaurant.service';
import { RestaurantFormComponent } from './restaurant-form/restaurant-form.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule
  ],
  providers: [RestaurantService],
  declarations: [RestaurantComponent, RestaurantFormComponent],
  exports: [RestaurantComponent]
})
export class RestaurantModule { }
