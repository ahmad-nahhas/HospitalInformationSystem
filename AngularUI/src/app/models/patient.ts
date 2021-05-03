import { Guid } from "guid-typescript";
import { Gender } from "./gender";

export class Patient {
    id: Guid;
    name: string;
    fileNo: number;
    citizenId: string;
    birthDate: Date;
    gender: Gender;
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
}