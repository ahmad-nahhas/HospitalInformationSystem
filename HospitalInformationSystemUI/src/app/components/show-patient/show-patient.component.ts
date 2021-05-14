import { Component, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { Filter } from 'src/app/filters/filter';
import { Patient } from 'src/app/models/patient';
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

  patient: Patient;
  patientList: Patient[] = [];
  filter = new Filter();
  recordsCount = 0;
  totalPages = 0;

  ngOnInit(): void {
    this.search();
  }

  addClick() {
    this.patient = new Patient();
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
      this.service.delete(id).subscribe(() => {
        this.search();
        // alert("The patient's record has been removed successfully!");
      }, err => {
        console.log(err)
      })
    }
  }

  closeClick() {
    this.activateAddEditPatientComp = false;
    this.search();
  }

  previous() {
    if (this.filter.pageNumber > 1) {
      this.filter.pageNumber--;
      this.search();
    }
  }

  next() {
    if (this.filter.pageNumber < this.totalPages) {
      this.filter.pageNumber++;
      this.search();
    }
  }

  search() {
    this.service.getFiltered(this.filter).subscribe(res => {
      this.patientList = res;
    }, err => {
      console.log(err);
    });

    this.getRecordsCount();
  }

  getRecordsCount() {
    this.service.getFiltered(this.filter, false).subscribe(res => {
      this.recordsCount = res.length;
      this.totalPages = Math.ceil(this.recordsCount / this.filter.pageSize);
    }, err => {
      console.log(err);
    });
    this.pagesCount();
  }

  pagesCount() {
    return new Array(this.totalPages);
  }

  getPage(pageNumber: number) {
    this.filter.pageNumber = pageNumber;
    this.search();
  }
}