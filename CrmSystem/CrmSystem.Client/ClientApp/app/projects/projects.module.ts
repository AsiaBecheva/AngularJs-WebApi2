import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProjectsComponent } from './projects.component';
import { projectsRouting } from './projects.routing';

@NgModule({
    imports: [projectsRouting],
    declarations: [ProjectsComponent]
})
export class ProjectsModule {

}