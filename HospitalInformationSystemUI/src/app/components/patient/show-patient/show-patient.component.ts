import { Component, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { PatientFilter } from 'src/app/filters/patient.filter';
import { Patient } from 'src/app/models/patient';
import { SharedService } from 'src/app/services/shared.service';

@Component({
  selector: 'app-show-patient',
  templateUrl: './show-patient.component.html',
  styleUrls: ['./show-patient.component.css']
})
export class ShowPatientComponent implements OnInit {

  constructor(private service: SharedService) { }

  patientList: any = [];
  modalTitle: string = "";
  activateAddEditPatientComp: boolean = false;
  patient: any;

  ngOnInit(): void {
    this.refreshList();
  }

  addClick() {
    this.patient = {
      name: "",
      fileNo: 0,
      citizenId: "",
      birthDate: null,
      gender: null,
      natinality: "",
      phoneNumber: "",
      email: "",
      contactPerson: "",
      contactRelation: "",
      contactPhone: "",
      country: "",
      city: "",
      street: "",
      address1: "",
      address2: "",
      firstVisitDate: null,
      recordCreationDate: new Date(),
    }

    this.modalTitle = "Add Patient";
    this.activateAddEditPatientComp = true;
  }

  editClick(patient: Patient) {
    this.patient = patient;

    this.modalTitle = "Edit Patient";
    this.activateAddEditPatientComp = true;
  }

  deleteClick(id: Guid) {
    if (confirm("Are you sure you want to delete this patient's record?")) {
      this.service.delete(id).subscribe(error => {
        console.log(error);
      });
      this.refreshList();
    }
  }

  closeClick() {
    this.activateAddEditPatientComp = false;
    this.refreshList();
  }

  refreshList() {
    this.service.getFiltered(new PatientFilter()).subscribe(patients => {
      this.patientList = patients;
    }, error => {
      console.log(error)
    });
  }

}