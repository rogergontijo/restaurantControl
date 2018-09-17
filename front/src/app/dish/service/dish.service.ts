import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class DishService {

  private api = 'http://localhost:49902/api/dishes/';

  constructor(private httpService: HttpClient) {
  }

  getAll() {
    return this.httpService.get(this.api);
  }

  getById(id: number) {
    return this.httpService.get(this.api + id);
  }

  Post(dish: any) {
    return this.httpService.post(this.api, dish);
  }

  Put(dish: any) {
    return this.httpService.put(this.api, dish);
  }

  Delete(id: number) {
    return this.httpService.delete(this.api + id);
  }
}
