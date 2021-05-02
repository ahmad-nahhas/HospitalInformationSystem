import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { PatientsService } from 'src/app/services/patients.service';

@Component({
  selector: 'app-patient-details',
  templateUrl: './patient-details.component.html',
  styleUrls: ['./patient-details.component.css']
})
export class PatientDetailsComponent implements OnInit {

  constructor(public service: PatientsService) { }

  ngOnInit(): void {
    this.service.patient = {
      id: null,
      name: null,
      fileNo: null,
      citizenId: null,
      birthDate: null,
      gender: null,
      natinality: null,
      phoneNumber: null,
      email: null,
      contactPerson: null,
      contactRelation: null,
      contactPhone: null,
      country: null,
      city: null,
      street: null,
      address1: null,
      address2: null,
      firstVisitDate: null,
      recordCreationDate: null
    }
  }

  SavePatient() {
    if (this.service.patient.id == null) {
      this.service.post().subscribe(() => {
        this.service.get()
      }, error => {
        console.log(error)
      })
    } else {
      this.service.put().subscribe(() => {
        this.service.get()
      }, error => {
        console.log(error)
      })
    }
  }

}