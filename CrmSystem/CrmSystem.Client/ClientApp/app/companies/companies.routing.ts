import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';
import { CompaniesComponent } from './companies.component';

export const companiesRoutes: Routes = [
    {
        path: 'companies',
        component: CompaniesComponent,
        data: {
            pageTitle: 'Companies page'
        }
    }
]

export const companiesRouting: ModuleWithProviders = RouterModule.forChild(companiesRoutes); 

