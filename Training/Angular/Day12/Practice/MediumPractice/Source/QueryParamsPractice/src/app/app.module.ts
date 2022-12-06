import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { IndiaUSAComponent } from './india-usa/india-usa.component';
import { AtlanticComponent } from './atlantic/atlantic.component';
import { PacificComponent } from './pacific/pacific.component';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes=[
  {path:'',redirectTo:'india-usa', pathMatch:'full'},
  {path:'india-usa',component: IndiaUSAComponent, children:[
    {path:'atlantic',component:AtlanticComponent},
    {path:'pacific',component:PacificComponent}
  ]}
]


@NgModule({
  declarations: [
    AppComponent,
    IndiaUSAComponent,
    AtlanticComponent,
    PacificComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
