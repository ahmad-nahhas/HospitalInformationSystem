import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Guid } from 'guid-typescript';
import { Observable } from 'rxjs';
import { Filter } from '../filters/filter';
import { Patient } from '../models/patient';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  constructor(private http: HttpClient) { }

  private readonly url = "https://localhost:44398/api/patients";

  getAll(): Observable<Patient[]> {
    return this.http.get<Patient[]>(this.url);
  }

  getFiltered(filter: Filter, applyPagination = true): Observable<Patient[]> {
    return applyPagination ? (this.http.get<Patient[]>(this.url + filter.toString())) :
      this.http.get<Patient[]>(this.url + filter.toString(), { headers: { usePagination: 'false' } });
  }

  post(patient: Patient): Observable<Patient> {
    return this.http.post<Patient>(this.url, patient);
  }

  put(patient: Patient): Observable<Patient> {
    return this.http.put<Patient>(this.url, patient);
  }

  delete(id: Guid): Observable<Patient> {
    return this.http.delete<Patient>(this.url + "/" + id);
  }
}
