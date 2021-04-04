import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BikeService } from 'src/app/servicios/bike.service';

@Component({
  selector: 'app-load-warranty',
  templateUrl: './load-warranty.component.html',
  styleUrls: ['./load-warranty.component.css']
})
export class LoadWarrantyComponent implements OnInit{

  models = [
    'Road Bike',
    'Mountain Bike',
    'Hybrid/Commuter Bike',
    'Cyclocross Bike',
    'Folding Bike',
  ]
  bikeForm: FormGroup;
  validMessage: string = "";

  constructor(private bikeService: BikeService) {
    
    this.bikeForm = new FormGroup({
      name: new FormControl('', [Validators.minLength(5), Validators.maxLength(50)]),
      email: new FormControl('', Validators.email),
      phone: new FormControl('', Validators.required),
      model: new FormControl('', Validators.required),
      serialNumber: new FormControl('', Validators.required),
      purchasePrice: new FormControl('', Validators.required),
      purchaseDate: new FormControl('', Validators.required),
      contact: new FormControl('', Validators.required),
    });
  }

  ngOnInit(): void {
  }

  submitRegistration(){
    if(this.bikeForm.valid){
      this.bikeService.createdBikeRegistration(this.bikeForm.value).subscribe(
        data => {
          this.bikeForm.reset();
          alert("Formulario enviado correctamente");
        }
      );
    }else{
      alert("Formulario inválido o incompleto");
    }
  }
}
