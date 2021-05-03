export class PatientFilter {

    pageNumber = 1;
    pageSize = 8;
    patientName = "";
    fileNo = 0;
    phoneNumber = "";

    constructor(pageNumber = 1, pageSize = 8, patientName = "", fileNo = 0, phoneNumber = "") {

        this.pageNumber = pageNumber > 0 ? pageNumber : 1;
        this.pageSize = pageSize > 8 ? 8 : pageSize;
        this.patientName = patientName == null ? "" : patientName;
        this.fileNo = fileNo > 0 ? fileNo : 0;
        this.phoneNumber = phoneNumber == null ? "" : phoneNumber;
    }
}