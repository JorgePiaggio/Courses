import { Component, OnInit } from '@angular/core';
import { BikeService } from 'src/app/servicios/bike.service';
import { faDollarSign } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  public bikes : any;
  faDollarSign = faDollarSign;
  
  constructor(private BikeService: BikeService) { }

  ngOnInit(): void {
    this.getAllBikes();
  }


  getAllBikes(){
    // retorna un observable
    this.BikeService.getBikes().subscribe(
      data => {this.bikes = data},
      err => {console.log(err)},
      () => console.log('se cargaron las bicis')
    );
  }

  
}
