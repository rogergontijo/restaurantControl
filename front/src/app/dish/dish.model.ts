import { Restaurant } from './../restaurant/restaurant.model';

export class Dish {

    public id: number;
    public nome: string;
    public preco: string;
    public restaurantId: number;
    public restaurant: Restaurant;

}
