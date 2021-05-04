import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AddEditPatientComponent } from './components/add-edit-patient/add-edit-patient.component';
import { ShowPatientComponent } from './components/show-patient/show-patient.component';
import { HttpClientModule } from '@angular/common/http';
import { SharedService } from './services/shared.service';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AddEditPatientComponent,
    ShowPatientComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
