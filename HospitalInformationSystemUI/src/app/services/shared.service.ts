import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PatientFilter } from '../filters/patient.filter';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly Url = "https://localhost:44398/api/patients";

  constructor(private http: HttpClient) { }

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

  delete(patientId: any) {
    return this.http.delete(this.Url + "/" + patientId);
  }
}