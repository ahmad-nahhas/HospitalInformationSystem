import { Component, Input, OnInit } from '@angular/core';
import { Patient } from 'src/app/models/patient';
import { SharedService } from 'src/app/services/shared.service';

@Component({
  selector: 'app-add-edit-patient',
  templateUrl: './add-edit-patient.component.html',
  styleUrls: ['./add-edit-patient.component.css']
})
export class AddEditPatientComponent implements OnInit {

  constructor(private service: SharedService) { }

  @Input() patient: Patient;

  ngOnInit(): void {
  }

  savePatient() {
    if (this.patient.id == null) {
      this.service.post(this.patient).subscribe(() => {
        alert("New Patient Added Successfully!");
      }, err => {
        alert("Please fill in at least the name, file no and citizen id fields!");
        console.log(err);
      })
    } else {
      this.service.put(this.patient).subscribe(() => {
        alert("Patient Information Updated Successfully!");
      }, err => {
        alert("Please fill in at least the name, file no and citizen id fields!");
        console.log(err);
      })
    }
  }
}
