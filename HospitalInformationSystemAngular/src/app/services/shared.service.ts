import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { PatientFilter } from '../filters/patient.filter';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  constructor(private http: HttpClient) { }

  readonly Url = "https://localhost:44398/api/patients";

  get(): Observable<any> {
    return this.http.get(this.Url);
  }

  getFiltered(filter: PatientFilter): Observable<any> {
    return this.http.get(this.Url +
      "/search?PageNumber=" + filter.pageNumber +
      "&PageSize=" + filter.pageSize +
      "&Name=" + filter.patientName +
      "&FileNo=" + filter.fileNo +
      "&PhoneNumber" + filter.phoneNumber);
  }

  post(patient: any) {
    return this.http.post(this.Url, patient);
  }

  put(patient: any) {
    return this.http.put(this.Url, patient);
  }

  delete(id: any) {
    return this.http.delete(this.Url + "/" + id);
  }
}