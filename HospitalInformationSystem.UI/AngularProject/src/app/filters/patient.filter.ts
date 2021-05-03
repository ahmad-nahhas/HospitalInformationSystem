export class PatientFilter {

    search: string;

    constructor(pageNumber = 1, pageSize = 2, patientName = "", fileNo = 0, phoneNumber = "") {

        this.search = "/search?PageNumber=" + (pageNumber > 0 ? pageNumber : 1) +
            "&PageSize=" + (pageSize > 2 ? 2 : pageSize) +
            "&Name=" + (patientName == null ? "" : patientName) +
            "&FileNo=" + (fileNo == null ? 0 : fileNo) +
            "&PhoneNumber=" + (phoneNumber == null ? "" : phoneNumber);
    }
}