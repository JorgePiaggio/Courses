import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BikeService } from 'src/app/services/bike.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  validMessage: string = "";
  models: string[] = [
    'modelo bike 1',
    'modelo bike pro 34',
    'modelo bike race',
    'modelo bike magica',
    'modelo bike mercedez',
    'modelo bike 36',
    'modelo bike 4567',
  ]

  bikeform: FormGroup; // este objeto encapsula un conjunto de controles del formulario y resguarda el estado del mismo

  constructor(
    private bikeService: BikeService
  ) {
    this.bikeform = new FormGroup({
      name: new FormControl('', Validators.pattern('@[A-Za-z0-9_]{1,15}')),
      email: new FormControl('', Validators.email),
      //validamos mediante un RegExp el formato del telefono
      //deberia ser como el siguiente : +54 3554 1522588989
      phone: new FormControl('', [Validators.required, Validators.pattern('\\+54\\s[0-9]{1,4}\\s15[0-9]{8}')]),
      model: new FormControl('', Validators.required),
      serialNumber: new FormControl('', Validators.required),
      purchasePrice: new FormControl('', [Validators.required, Validators.min(1000), Validators.max(100000)]),
      purchaseDate: new FormControl('', [Validators.required]),
      contact: new FormControl('', [Validators.required])
    })

    console.log('Que posee en su interior el objeto FormGroup??');
    console.dir(this.bikeform);
  }

  submitRegistration() {
    // console.log("Estos son los controles de nuestro formGroup ");
    // console.dir(this.bikeform.controls);

    // console.log("Es valido nuestro form ???");
    // console.dir(this.bikeform.valid);

    if(this.bikeform.valid){
      // console.log("Estos son los valores de nuestro formulario ");
      // console.dir(this.bikeform.value);
      this.bikeService.addBike(this.bikeform.value).subscribe(
        data => {       
          this.validMessage = 'Su Formulario Se Envio Con Exito';
          this.bikeform.reset(); 
        },
        err => {
          this.validMessage = 'Su Formulario no se pudo enviar';
        }
      );

    }else{
      this.validMessage = 'Su Formulario esta Incompleto';
    }

  }

  //creamos un getters para obtener las instancias de los form controls
  //de una manera mas prolija
  get controles(){
    return this.bikeform.controls;
  }

  ngOnInit(): void {
  }

}
