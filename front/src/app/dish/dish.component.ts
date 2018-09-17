import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Subscription } from 'rxjs/Subscription';
import { Dish } from './dish.model';
import { DishService } from './service/dish.service';

@Component({
  selector: 'app-dish',
  templateUrl: './dish.component.html',
  styleUrls: ['./dish.component.css']
})
export class DishComponent implements OnInit {

  dish: Dish;
  dishes: Dish[];
  inscricao: Subscription;

  constructor(
    private dishService: DishService,
    private route: ActivatedRoute,
    private router: Router
    ) {
      this.dish = new Dish();
    }

  ngOnInit() {
    this.getAll();
  }

  getAll() {
    this.dishService.getAll().subscribe(
      (dishItem: Dish[]) => {
        this.dishes = dishItem.slice();
      }
    );
  }

  onRowClick(id: number) {
    this.router.navigate(['/dish', id]);
  }

  onCadastrarNovo() {
    this.router.navigate(['/dish/novo']);
  }
}
