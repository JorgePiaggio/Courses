import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filterimages'
})
//generamos un pipe para realizar una transformacion visual de nuestra data
//este en particular filtra la bikes
export class FilterimagesPipe implements PipeTransform {

  transform(items: any[], bike: string): any {
    if (bike === 'all') {
      //retorno el array sin filtrar
      return items;
    } else {
      //filtro las bikes
      return items.filter(item => {
        return item.brand === bike;
      });
    }
  }

}
