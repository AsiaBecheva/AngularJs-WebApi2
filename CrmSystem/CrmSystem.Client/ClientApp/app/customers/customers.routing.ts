import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';
import { CustomersComponent } from './customers.component';

export const customerRoutes: Routes = [
    {
        path: 'customers',
        component: CustomersComponent,
        data: {
            pageTitle: 'Customers'
        }
    }
]

export const customerRouting: ModuleWithProviders = RouterModule.forChild(customerRoutes);

