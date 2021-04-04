import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

const httpOption = {
  headers: new HttpHeaders ({'Content-Type':'application/json'})
}

@Injectable({
  providedIn: 'root'
})
export class BikeService {

  constructor(private http: HttpClient) { }
    // funcion q retorna listado de bikes
    getBikes(){
      return this.http.get("/server/api/v1/bikes");
    }

    getBike(id: number){
      return this.http.get("/server/api/v1/bikes/" + id);
    }

    // funcion q agrega bici a la lista
    createdBikeRegistration(bike: any){
      let body = JSON.stringify(bike);
      return this.http.post("/server/api/v1/bikes", body, httpOption);
    }
  
}
