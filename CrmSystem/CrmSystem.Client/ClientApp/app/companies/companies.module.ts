import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { companiesRouting } from './companies.routing';
import { CompaniesComponent } from './companies.component';

@NgModule({
    imports: [companiesRouting],
    declarations: [CompaniesComponent]
})
export class CompaniesModule {

}