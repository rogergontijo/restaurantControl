import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { Subscription } from 'rxjs/Subscription';
import { RestaurantService } from './service/restaurant.service';
import { Restaurant } from './restaurant.model';


@Component({
  selector: 'app-restaurant',
  templateUrl: './restaurant.component.html',
  styleUrls: ['./restaurant.component.css']
})
export class RestaurantComponent implements OnInit {

  restaurant: Restaurant;
  restaurants: Restaurant[];
  inscricao: Subscription;

  constructor(
    private restaurantService: RestaurantService,
    private router: Router,
    private route: ActivatedRoute
  ) {
    this.restaurant = new Restaurant();
  }

  ngOnInit() {
    this.getAll();
  }

  onRowClick(id: number) {
    this.router.navigate(['/restaurant', id]);
  }

  onCadastrarNovo() {
    this.router.navigate(['/restaurant/novo']);
  }

  getAll() {
    this.restaurantService.getAll().subscribe (
      (restaurantItem: Restaurant[] ) => {
        this.restaurants = restaurantItem.slice();
      }
    );
  }
}
