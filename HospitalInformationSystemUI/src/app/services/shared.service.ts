import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Guid } from 'guid-typescript';
import { Filter } from '../filters/filter';
import { Patient } from '../models/patient';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  constructor(private http: HttpClient) { }

  private readonly url = "https://localhost:44398/api/patients";

  getAll() {
    return this.http.get<Patient[]>(this.url);
  }

  getFiltered(filter: Filter, applyPagination = true) {
    return this.http.get<Patient[]>(this.url + filter.toString(), {
      headers: {
        usePagination: applyPagination ? 'true' : 'false'
      }
    });
  }

  post(patient: Patient) {
    return this.http.post<Patient>(this.url, patient);
  }

  put(patient: Patient) {
    return this.http.put<Patient>(this.url, patient);
  }

  delete(id: Guid) {
    return this.http.delete<Patient>(`${this.url}/${id}`);
  }
}
