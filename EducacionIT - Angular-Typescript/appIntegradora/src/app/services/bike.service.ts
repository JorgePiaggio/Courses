import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BikeObject } from '../models/modelo';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-type': 'application/json' })
}

@Injectable({
  providedIn: 'root'
})
export class BikeService {

  
  constructor(
    private httpClient: HttpClient
    ) { }

  getBike(id: number): Observable<BikeObject[]>{
    return this.httpClient.get<BikeObject[]>('/server/api/v1/bikes/' + id);
  }

  getBikes(): Observable<BikeObject[]>{
    return this.httpClient.get<BikeObject[]>('/server/api/v1/bikes/');
  }

  addBike(bike: any){
    return this.httpClient.post('/server/api/v1/bikes/', bike, httpOptions);
  }

  deleteBike(id:number): Observable<boolean>{
    return this.httpClient.get<boolean>(`/server/api/v1/bikes/borrar/${id}`);
  }
}
