import { Injectable } from '@angular/core';
import { Patient } from 'src/app/models/patient';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PatientsService {

  url = "https://localhost:44398/api/patients";
  patients: Patient[];
  patient: Patient;

  constructor(private http: HttpClient) { }

  get() {
    this.http.get(this.url).toPromise().then(result => {
      this.patients = result as Patient[];
    });
  }

  search(search: string) {
    this.http.get(this.url + search).toPromise().then(result => {
      this.patients = result as Patient[];
    });
  }

  post() {
    return this.http.post(this.url, this.patient);
  }

  put() {
    return this.http.put(this.url, this.patient);
  }

  delete(id: any) {
    return this.http.delete(this.url + "/" + id);
  }
}