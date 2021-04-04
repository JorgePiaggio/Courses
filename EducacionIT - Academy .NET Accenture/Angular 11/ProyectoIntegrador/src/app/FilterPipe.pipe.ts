import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'FilterPipe'
})
export class FilterPipe implements PipeTransform {
    transform(items: any[], model: string): any {
        if (!model || '') {
            return items;
        }
        // filter items array, items which match and return true will be
        // kept, false will be filtered out
        return items.filter(item => {return item.modelo == model});
    }
}