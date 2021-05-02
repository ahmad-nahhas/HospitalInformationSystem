import { Component, OnInit } from '@angular/core';
import { Patient } from 'src/app/models/patient';
import { PatientsService } from 'src/app/services/patients.service';

@Component({
  selector: 'app-patient-list',
  templateUrl: './patient-list.component.html',
  styleUrls: ['./patient-list.component.css']
})
export class PatientListComponent implements OnInit {

  constructor(public service: PatientsService) { }

  ngOnInit(): void {
    this.service.get();
  }

  viewPatientDetails(patient: Patient) {
    this.service.patient = patient;
  }

  deletePatient(id: any) {
    this.service.delete(id).subscribe(() => {
      this.service.get()
    })
  }

}