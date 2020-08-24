import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GetBicycleView } from '../models/GetBicycleView';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { AddBicycleView } from '../models/AddBicycleView';
import { UpdateBicycleView } from '../models/UpdateBicycleView';

@Injectable({
  providedIn: 'root'
})
export class BicycleService {

  constructor(private http: HttpClient) { }

  public getBicycles(): Observable<GetBicycleView[]> {
    return this.http.get<GetBicycleView[]>(environment.apiUrl + '/api/bicycle/getall');
  }
  public addBicycle(model: AddBicycleView): Observable<null> {
    return this.http.post<null>(environment.apiUrl + '/api/bicycle/add', model);
  }
  public deleteBicycle(id: string): Observable<null> {
    return this.http.delete<null>(environment.apiUrl + '/api/bicycle/delete/' + id);
  }
  public updateBicycle(bicycle: UpdateBicycleView): Observable<null> {
    return this.http.post<null>(environment.apiUrl + '/api/bicycle/update', bicycle);
  }
}
