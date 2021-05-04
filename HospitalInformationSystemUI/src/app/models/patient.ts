import { Guid } from "guid-typescript";

export class Patient {
    id: Guid;
    name: string;
    fileNo: number;
    citizenId: string;
    birthDate: Date;
    gender: 0 | 1;
    natinality: string;
    phoneNumber: string;
    email: string;
    contactPerson: string;
    contactRelation: string;
    contactPhone: string;
    country: string;
    city: string;
    street: string;
    address1: string;
    address2: string;
    firstVisitDate: Date;
    recordCreationDate: Date;

    constructor(name = null, fileNo = null, citizenId = null, birthDate = null, gender = null, natinality = null, phoneNumber = null, email = null, contactPerson = null, contactRelation = null, contactPhone = null, country = null, city = null, street = null, address1 = null, address2 = null, firstVisitDate = null) {
        this.name = name;
        this.fileNo = fileNo;
        this.citizenId = citizenId;
        this.birthDate = birthDate;
        this.gender = gender;
        this.natinality = natinality;
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.contactPerson = contactPerson;
        this.contactRelation = contactRelation;
        this.contactPhone = contactPhone;
        this.country = country;
        this.city = city;
        this.street = street;
        this.address1 = address1;
        this.address2 = address2;
        this.firstVisitDate = firstVisitDate;
    }
}