import { Component, OnInit } from '@angular/core';
import { PatientFilter } from 'src/app/filters/patient.filter';
import { Patient } from 'src/app/models/patient';
import { PatientsService } from 'src/app/services/patients.service';

@Component({
  selector: 'app-patient-list',
  templateUrl: './patient-list.component.html',
  styleUrls: ['./patient-list.component.css']
})
export class PatientListComponent implements OnInit {

  pageNumber: number = 1;
  pageSize: number = 2;
  patientName: string = "";
  fileNo: number = 0;
  phoneNumber: string = "";

  constructor(public service: PatientsService) { }

  ngOnInit(): void {
    this.pageNumber = 1;
    this.pageSize = 2;
    this.patientName = "";
    this.fileNo = 0;
    this.phoneNumber = "";
    this.search();
  }

  viewPatientDetails(patient: Patient) {
    this.service.patient = patient;
  }

  search() {
    this.service.search(new PatientFilter(this.pageNumber, this.pageSize, this.patientName, this.fileNo, this.phoneNumber).search);
  }

  deletePatient(id: any) {
    this.service.delete(id).subscribe(() => {
      this.search()
    })
  }

  incrementPageNumber() {
    this.pageNumber++;
    this.search();
  }

  decrementPageNumber() {
    this.pageNumber--;
    this.search();
  }

}