import { Component, Input, OnInit } from '@angular/core';
import { SharedService } from 'src/app/services/shared.service';

@Component({
  selector: 'app-add-edit-patient',
  templateUrl: './add-edit-patient.component.html',
  styleUrls: ['./add-edit-patient.component.css']
})
export class AddEditPatientComponent implements OnInit {

  constructor(private service: SharedService) { }

  @Input() patient: any;
  genderVal = Gender;
  genderKey = [0, 1];

  ngOnInit(): void {
  }

  savePatient() {
    if (this.patient.id == null) {
      this.service.post(this.patient).subscribe(error => {
        console.log(error);
      })
    } else {
      this.service.put(this.patient).subscribe(error => {
        console.log(error);
      })
    }
  }

}
