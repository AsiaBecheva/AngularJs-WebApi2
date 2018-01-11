import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { customerRouting } from './customers.routing';
import { CustomersComponent } from './customers.component';

@NgModule({
    imports: [customerRouting],
    declarations: [CustomersComponent]
})
export class CustomersModule {}
