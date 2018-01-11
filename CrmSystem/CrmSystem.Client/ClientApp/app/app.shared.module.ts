import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './navmenu/navmenu.component';
import { HomeModule } from './home/home.module';
import { CustomersModule } from './customers/customers.module';
import { CompaniesModule } from './companies/companies.module';
import { ProjectsModule } from './projects/projects.module';
import { SalesModule } from './sales/sales.module';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        HomeModule,
        CustomersModule,
        CompaniesModule,
        ProjectsModule,
        SalesModule, 
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: '**', redirectTo: 'home' },
        ])
    ]
})
export class AppModuleShared {
}
