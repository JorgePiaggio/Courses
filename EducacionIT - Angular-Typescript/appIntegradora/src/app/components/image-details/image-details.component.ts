import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ImageService } from 'src/app/services/image.service';

@Component({
  selector: 'app-image-details',
  templateUrl: './image-details.component.html',
  styleUrls: ['./image-details.component.css']
})
export class ImageDetailsComponent implements OnInit {

image: any;

  constructor(
    private route: ActivatedRoute,
    private imgService: ImageService
  ) { }

  ngOnInit(): void {
    this.buscarImagen(this.route.snapshot.params['id']);
  }

  buscarImagen(id: number){
    this.image = this.imgService.getImage(id);
  }

}
