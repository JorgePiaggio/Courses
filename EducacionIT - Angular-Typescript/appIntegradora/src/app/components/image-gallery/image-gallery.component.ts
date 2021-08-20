import { Component, OnInit } from '@angular/core';
import { ImageService } from 'src/app/services/image.service';

@Component({
  selector: 'app-image-gallery',
  templateUrl: './image-gallery.component.html',
  styleUrls: ['./image-gallery.component.css']
})
export class ImageGalleryComponent implements OnInit {

  //atributos de la clase
  allImages: imageBikeObject[] = [];
  filterBy: string = 'all';

  constructor(private imageService: ImageService) {
    //invocamos al metodo del servicio inyectado para que nos retorne el listado de images
    this.allImages = this.imageService.getImages();
    console.log(this.allImages);
  }

  ngOnInit(): void {
  }

}

export interface imageBikeObject {
  id: number;
  brand: string;
  url: string;
}
