import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';
import { ProjectsComponent } from './projects.component';

export const projectsRoutes: Routes = [
    {
        path: 'projects',
        component: ProjectsComponent,
        data: {
            pageTitle: 'Projects page'
        }
    }
]

export const projectsRouting: ModuleWithProviders = RouterModule.forChild(projectsRoutes);
