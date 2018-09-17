import { Restaurant } from './../restaurant.model';
import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';

import { RestaurantService } from './../service/restaurant.service';

@Component({
  selector: 'app-restaurant-form',
  templateUrl: './restaurant-form.component.html',
  styleUrls: ['./restaurant-form.component.css']
})
export class RestaurantFormComponent implements OnInit, OnDestroy {

  restaurant: Restaurant;
  inscricao: Subscription = new Subscription();
  itemToDelete: Restaurant;
  id: number;
  isInsert: boolean;

  constructor(
    private restaurantService: RestaurantService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.restaurant = new Restaurant();
    this.itemToDelete = new Restaurant();
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
      this.restaurantService.getById(this.id).subscribe(
        (param: Restaurant) => {
        this.restaurant = param;
      });
    }
  }

  onCancelarClick() {
    this.router.navigate(['/restaurant']);
  }

  onGravarClick() {
    const sucesso = () => {
      this.router.navigate(['/restaurant']);
    };

    if (this.isInsert) {
      this.restaurantService.Post(this.restaurant).subscribe(
        () => { sucesso(); }
      );
      return;
    }

    this.restaurantService.Put(this.restaurant).subscribe(
      () => { sucesso(); }
    );
  }

  onExcluirClick(id: number) {
    const sucesso = () => {
      this.router.navigate(['/restaurant']);
    };

    this.restaurantService.getById(id).subscribe(
      (item: Restaurant) => {
        this.itemToDelete = item;
        this.restaurantService.Delete(this.itemToDelete.id).subscribe (
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
