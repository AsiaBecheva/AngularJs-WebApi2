import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { salesRouting } from './sales.routing';
import { SalesComponent } from './sales.component';

@NgModule({
    imports: [salesRouting],
    declarations: [SalesComponent]
})

export class SalesModule {

}