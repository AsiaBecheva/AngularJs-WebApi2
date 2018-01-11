import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';
import { SalesComponent } from './sales.component';

export const salesRoute: Routes = [
    {
        path: 'sales',
        component: SalesComponent,
        data: {
            pageTitle: 'Sales page'
        }
    }
]

export const salesRouting: ModuleWithProviders = RouterModule.forChild(salesRoute);