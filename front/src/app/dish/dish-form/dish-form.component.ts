import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs/Subscription';

import { DishService } from './../service/dish.service';
import { Dish } from '../dish.model';
import { Restaurant } from '../../restaurant/restaurant.model';
import { RestaurantService } from './../../restaurant/service/restaurant.service';

@Component({
  selector: 'app-dish-form',
  templateUrl: './dish-form.component.html',
  styleUrls: ['./dish-form.component.css']
})
export class DishFormComponent implements OnInit, OnDestroy {

  dish: Dish;
  inscricao: Subscription = new Subscription();
  id: number;
  restaurants: Restaurant[];
  itemToDelete: Dish;
  isInsert: boolean;

  constructor(
    private dishService: DishService,
    private restaurantService: RestaurantService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.dish = new Dish();
    this.itemToDelete = new Dish();
    this.isInsert = true;
   }

  ngOnInit() {
    if (this.route.snapshot.params['id']) {
      this.isInsert = false;
      this.inscricao = this.route.params.subscribe(
        (params: any) => {
          this.id = params['id'];
        }
      );
      this.dishService.getById(this.id).subscribe(
        (param: Dish) => {
          this.dish = param;
        }
      );
    }

    this.restaurantService.getAll().subscribe(
      (params: Restaurant[]) => {
        this.restaurants = params;
      }
    );
  }

  onCancelarClick() {
    this.router.navigate(['/dish']);
  }

  onGravarClick() {
    const sucesso = () => {
      this.router.navigate(['/dish']);
    };

    if (this.isInsert) {
      this.dishService.Post(this.dish).subscribe(
        () => { sucesso(); }
      );
      return;
    }

    this.dishService.Put(this.dish).subscribe(
      () => { sucesso(); }
    );
  }

  onExcluirClick(id: number) {
    const sucesso = () => {
      this.router.navigate(['/dish']);
    };

    this.dishService.getById(id).subscribe(
      (item: Dish) => {
        this.itemToDelete = item;
        this.dishService.Delete(this.itemToDelete.id).subscribe (
          () => {
            sucesso();
          }
        );
      }
    );
  }

  ngOnDestroy() {
    this.inscricao.unsubscribe();
  }
}
