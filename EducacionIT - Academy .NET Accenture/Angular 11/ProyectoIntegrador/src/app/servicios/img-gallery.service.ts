import { Injectable } from '@angular/core';
import { LoadWarrantyComponent } from '../componentes/load-warranty/load-warranty.component';

const imgPath = '../../assets/img/list/';

@Injectable({
  providedIn: 'root'
})
export class ImgGalleryService {
  imageList:any = [];
  constructor(){ }

  getImg(id: number){ 
    return this.getAll().slice(0).find(v => v?.id == id); 
  }

  getAll(){
    return this.imageList = images.slice(0);
  }
}

const models = [
  'Road Bike',
  'Mountain Bike',
  'Hybrid/Commuter Bike',
  'Cyclocross Bike',
  'Folding Bike',
]
const images = [
  {
    "id": 1,
    "modelo": models[0],
    "url": imgPath + 'road1.jpg'
  },
  {
    "id": 2,
    "modelo": models[0],
    "url": imgPath + 'road2.jpg'
  },
  {
    "id": 3,
    "modelo": models[0],
    "url": imgPath + 'road3.jpg'
  },
  {
    "id": 4,
    "modelo": models[0],
    "url": imgPath + 'road4.webp'
  },
  {
    "id": 5,
    "modelo": models[1],
    "url": imgPath + 'mount1.jpg'
  },
  {
    "id": 6,
    "modelo": models[1],
    "url": imgPath + 'mount2.jpg'
  },
  {
    "id": 7,
    "modelo": models[1],
    "url": imgPath + 'mount3.jpg'
  },
  {
    "id": 8,
    "modelo": models[1],
    "url": imgPath + 'mount4.jpg'
  },
  {
    "id": 9,
    "modelo": models[2],
    "url": imgPath + 'hyb1.jpg'
  },
  {
    "id": 10,
    "modelo": models[2],
    "url": imgPath + 'hyb2.jpg'
  },
  {
    "id": 11,
    "modelo": models[2],
    "url": imgPath + 'hyb3.jpg'
  },
  {
    "id": 12,
    "modelo": models[2],
    "url": imgPath + 'hyb4.jpg'
  },
  {
    "id": 13,
    "modelo": models[3],
    "url": imgPath + 'cyc1.jpg'
  },
  {
    "id": 14,
    "modelo": models[3],
    "url": imgPath + 'cyc2.jpg'
  },
  {
    "id": 15,
    "modelo": models[3],
    "url": imgPath + 'cyc3.jpg'
  },
  {
    "id": 16,
    "modelo": models[3],
    "url": imgPath + 'cyc4.jpg'
  },
  {
    "id": 17,
    "modelo": models[3],
    "url": imgPath + 'cyc5.jpg'
  },
  {
    "id": 18,
    "modelo": models[4],
    "url": imgPath + 'pleg.jpg'
  },
  {
    "id": 19,
    "modelo": models[4],
    "url": imgPath + 'pleg2.jpg'
  }
];
