import { Component, OnChanges } from '@angular/core';
import { ImgGalleryService } from 'src/app/servicios/img-gallery.service';

@Component({
  selector: 'app-image-gallery',
  templateUrl: './image-gallery.component.html',
  styleUrls: ['./image-gallery.component.css']
})
export class ImageGalleryComponent implements OnChanges{
  bikes: any[] = [];
  category: string = '';

  constructor(private imgGal: ImgGalleryService) {
    this.bikes = this.imgGal.getAll(); 
  }

  ngOnInit(): void {
    this.bikes = this.imgGal.getAll();    console.dir(this.category);

  }

  ngOnChanges(){
    this.bikes = this.imgGal.getAll();
    console.log(this.category);
  }
}
