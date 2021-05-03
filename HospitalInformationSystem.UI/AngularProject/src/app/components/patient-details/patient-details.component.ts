import { Component, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { PatientFilter } from 'src/app/filters/patient.filter';
import { Gender } from 'src/app/models/gender';
import { PatientsService } from 'src/app/services/patients.service';

@Component({
  selector: 'app-patient-details',
  templateUrl: './patient-details.component.html',
  styleUrls: ['./patient-details.component.css']
})
export class PatientDetailsComponent implements OnInit {

  genderKeys = [0, 1];
  genderValues = Gender;

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
        this.service.search(new PatientFilter().search)
      }, error => {
        console.log(error)
      })
    } else {
      this.service.put().subscribe(() => {
        this.service.search(new PatientFilter().search)
      }, error => {
        console.log(error)
      })
    }
  }

}