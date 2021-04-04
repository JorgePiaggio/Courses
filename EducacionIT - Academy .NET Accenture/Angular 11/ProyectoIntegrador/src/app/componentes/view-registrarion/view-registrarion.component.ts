import { Component, OnInit } from '@angular/core';
import { BikeService } from 'src/app/servicios/bike.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-view-registrarion',
  templateUrl: './view-registrarion.component.html',
  styleUrls: ['./view-registrarion.component.css']
})
export class ViewRegistrarionComponent implements OnInit {
  public bikeRegister: any;

  constructor(private bikeService: BikeService, private activatedRoute​ : ​ ActivatedRoute) { }

  
  ngOnInit(): void {      
    this.getRegister(this.activatedRoute​.snapshot.params.id);
  }

  getRegister(id: number){
    this.bikeService.getBike(id).subscribe(
      data => {
        this.bikeRegister = data;
      }
    )
  }
}
