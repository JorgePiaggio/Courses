import { Component, OnInit } from '@angular/core';
import { BikeObject } from 'src/app/models/modelo';
import { BikeService } from 'src/app/services/bike.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  public bikes: BikeObject[];
  validMessage: string = "";

  constructor(
    private bikeService: BikeService
    ) { }

  ngOnInit(): void {
    this.getBikesBackend();
  }

  getBikesBackend(){
    this.bikeService.getBikes().subscribe(
      data => { this.bikes = data; },
      err => { console.log(err); }
    );
  }

  deleteBike(id:number){
    this.bikeService.deleteBike(id).subscribe(
      data => { 
        this.validMessage= "Bici borrada con éxito";
        this.getBikesBackend(); },
      err => { 
        console.log(err); 
        this.validMessage= "Error. Bici no borrada"
      }
    );
  }







}
