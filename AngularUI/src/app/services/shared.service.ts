import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PatientFilter } from '../filters/patient.filter';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  constructor(private http: HttpClient) { }

  private readonly Url = "https://localhost:44398/api/patients";

  get(): Observable<any> {
    return this.http.get(this.Url);
  }

  getFiltered(filter: PatientFilter): Observable<any> {
    return this.http.get(this.Url +
      "/search?PageNumber=" + filter.getPageNumber() +
      "&PageSize=" + filter.getPageSize() +
      "&Name=" + filter.getPatientName() +
      "&FileNo=" + filter.getFileNo() +
      "&PhoneNumber=" + filter.getPhoneNumber());
  }

  post(patient: any): Observable<any> {
    return this.http.post(this.Url, patient);
  }

  put(patient: any): Observable<any> {
    return this.http.put(this.Url, patient);
  }

  delete(id: any): Observable<any> {
    return this.http.delete(this.Url + "/" + id);
  }
}