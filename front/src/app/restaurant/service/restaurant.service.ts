import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class RestaurantService {

  private api = 'http://localhost:49902/api/restaurants/';

  constructor(private httpService: HttpClient) { }

  getAll() {
    return this.httpService.get(this.api);
  }

  getById(id: number) {
    return this.httpService.get(this.api + id);
  }

  Post(restaurant: any) {
    return this.httpService.post(this.api, restaurant);
  }

  Put(restaurant: any) {
    return this.httpService.put(this.api, restaurant);
  }

  Delete(id: number) {
    return this.httpService.delete(this.api + id);
  }
}
