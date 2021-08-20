import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ImageService {
  allImages: any = []

  constructor() { }
  //este metodo me retorna una copia de una seccio del array
  getImages() {
    return this.allImages = imagesDetails.slice(0);
  }


  //este metodo me retornara un elemento en particular del array de bikes , ese
  // elemento debe coincidir con el id recibido por parametro
  getImage(id: number) {
    return imagesDetails.slice(0).find(image => image.id == id);
  }

}

//dentro de esta contantes tendremos la info de nuestras bikes
const imagesDetails = [
  { "id": 1, "brand": "juniorrs", "url": "assets/images/bknenes2.jpg" },
  { "id": 2, "brand": "juniorrs", "url": "assets/images/bknenes1.jpg" },
  { "id": 3, "brand": "juniorrs", "url": "assets/images/bknenes3.jpg" },
  { "id": 4, "brand": "juniorrs", "url": "assets/images/bknenes4.jpg" },
  { "id": 5, "brand": "bkeco", "url": "assets/images/bkeco1.jpg" },
  { "id": 6, "brand": "bkeco", "url": "assets/images/bkeco2.jpg" },
  { "id": 7, "brand": "bkeco", "url": "assets/images/bkeco3.jpg" },
  { "id": 8, "brand": "bkeco", "url": "assets/images/bkeco4.jpg" },
  { "id": 9, "brand": "bkmotor", "url": "assets/images/bkmotor1.jpg" },
  { "id": 10, "brand": "bkmotor", "url": "assets/images/bkmotor2.jpg" },
  { "id": 11, "brand": "bkmotor", "url": "assets/images/bkmotor3.jpg" },
  { "id": 12, "brand": "bkmotor", "url": "assets/images/bkmotor4.jpg" },
  { "id": 13, "brand": "bkmotor", "url": "assets/images/bkmotor5.jpg" },
  { "id": 14, "brand": "adultosrc", "url": "assets/images/bk1.jpg" },
  { "id": 15, "brand": "adultosrc", "url": "assets/images/bk2.jpg" },
  { "id": 16, "brand": "adultosrc", "url": "assets/images/bk3.jpg" },
  { "id": 17, "brand": "adultosrc", "url": "assets/images/bk4.jpg" },

];
