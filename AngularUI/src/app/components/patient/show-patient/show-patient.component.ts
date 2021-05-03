import { Component, OnInit } from '@angular/core';
import { PatientFilter } from 'src/app/filters/patient.filter';
import { SharedService } from 'src/app/services/shared.service';

@Component({
  selector: 'app-show-patient',
  templateUrl: './show-patient.component.html',
  styleUrls: ['./show-patient.component.css']
})
export class ShowPatientComponent implements OnInit {

  constructor(private service: SharedService) { }

  modalTitle = "";
  activateAddEditPatientComp = false;
  patientList: any = [];
  patient: any;

  pageNumber = 1;
  pageSize = 8;
  patientName = "";
  fileNo = 0;
  phoneNumber = "";

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
      firstVisitDate: null
    }

    this.modalTitle = "Add Patient";
    this.activateAddEditPatientComp = true;
  }

  editClick(patient: any) {
    this.patient = patient;

    this.modalTitle = "Edit Patient";
    this.activateAddEditPatientComp = true;
  }

  deleteClick(id: any) {
    if (confirm("Are you sure you want to delete this patient's record?")) {
      this.service.delete(id).subscribe(() => { }, err => {
        alert(err.error);
      })

      this.refreshList();
    }
  }

  closeClick() {
    this.activateAddEditPatientComp = false;
    this.refreshList();
  }

  previous() {
    this.pageNumber = this.pageNumber > 1 ? this.pageNumber - 1 : 1;
    this.search();
  }

  next() {
    this.service.getFiltered(new PatientFilter(this.pageNumber + 1,
      this.pageSize, this.patientName, this.fileNo, this.phoneNumber)).subscribe(res => {
        if (res.length > 0) {
          this.pageNumber++;
          this.patientList = res;
        }
      }, err => {
        alert("This is last page!");
        console.log(err.error);
      });
  }

  search() {
    this.refreshList();
  }

  refreshList() {
    this.service.getFiltered(new PatientFilter(this.pageNumber, this.pageSize, this.patientName, this.fileNo, this.phoneNumber)).subscribe(res => {
      this.patientList = res;
    }, err => {
      console.log(err);
      alert(err.error);
    });
  }

}
