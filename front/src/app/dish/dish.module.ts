import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { DishComponent } from './dish.component';
import { DishService } from './service/dish.service';
import { DishFormComponent } from './dish-form/dish-form.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule
  ],
  providers: [DishService],
  declarations: [DishComponent, DishFormComponent],
  exports: [DishComponent]
})
export class DishModule { }
