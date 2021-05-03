import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowPatientComponent } from './show-patient.component';

describe('ShowPatientComponent', () => {
  let component: ShowPatientComponent;
  let fixture: ComponentFixture<ShowPatientComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowPatientComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowPatientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
