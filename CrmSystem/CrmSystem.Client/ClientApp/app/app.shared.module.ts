import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './navmenu/navmenu.component';
//import { HomeComponent } from './home/home.component';
import { HomeModule } from './home/home.module';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        //HomeComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        HomeModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            //{ path: 'home', component: HomeComponent },
            { path: '**', redirectTo: 'home' },
        ])
    ]
})
export class AppModuleShared {
}
