import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ImgGalleryService } from 'src/app/servicios/img-gallery.service';

@Component({
  selector: 'app-image-details',
  templateUrl: './image-details.component.html',
  styleUrls: ['./image-details.component.css']
})
export class ImageDetailsComponent implements OnInit {
                                                // ActivatedRoute: para poder usar los parametros
  constructor(private imgGal: ImgGalleryService, private activatedRoute: ActivatedRoute) { }
  image : any;

  // snapshot = current route
  ngOnInit(): void {
    this.image = this.imgGal.getImg(this.activatedRoute.snapshot.params['id']);
  }

}
