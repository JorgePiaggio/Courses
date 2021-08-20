import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BikeService } from 'src/app/services/bike.service';

@Component({
  selector: 'app-view-registration',
  templateUrl: './view-registration.component.html',
  styleUrls: ['./view-registration.component.css']
})
export class ViewRegistrationComponent implements OnInit {

  bikeReg: any;

  constructor(
    private bikeService: BikeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.getBikeById(this.route.snapshot.params['id']);
  }

  getBikeById(id: number){
    this.bikeService.getBike(id).subscribe(
      data => {
        this.bikeReg = data
      },
      error => {
        console.log("Error. Chequee que la bici solicitada exista");
      }
    );
  }

}
