import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentComponent } from './student/student.component';
import { StudentListComponent } from './student-list/student-list.component';

import { AuthService, AUTH_PROVIDERS } from './auth.service';
import { LoggedInGuardService } from './logged-in-guard.service';
import { StudentService } from './student.service';

@NgModule({
  declarations: [
    AppComponent,
    StudentComponent,
    StudentListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot([
      {path:'student', component:StudentComponent, canActivate:[LoggedInGuardService]},
      {path:'student-list',component:StudentListComponent}
    ])
  ],
  providers: [AUTH_PROVIDERS,LoggedInGuardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
