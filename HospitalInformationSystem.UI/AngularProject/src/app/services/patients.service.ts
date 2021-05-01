import { Injectable } from '@angular/core';
import { Patient } from 'src/app/models/patient';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PatientsService {

  url = "https://localhost:44398/api/patients";

  patients: Patient[];

  constructor(private http: HttpClient) { }

  getAll() {
    this.http.get(this.url).toPromise().then(res => {
      this.patients = res as Patient[];
    });
  }
}