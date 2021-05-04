export class Filter {

    pageNumber = 1;
    pageSize = 6;
    patientName = "";
    fileNo = 0;
    phoneNumber = "";

    constructor(pageNumber = 1, pageSize = 6, patientName = "", fileNo = 0, phoneNumber = "") {

        this.pageNumber = pageNumber;
        this.pageSize = pageSize;
        this.patientName = patientName;
        this.fileNo = fileNo;
        this.phoneNumber = phoneNumber;
    }

    public toString() {
        return "/search?PageNumber=" + ((this.pageNumber <= 0 || (this.pageNumber == null)) ? 1 : this.pageNumber) +
            "&PageSize=" + ((this.pageSize > 6 || (this.pageSize == null)) ? 6 : this.pageSize) +
            "&Name=" + ((this.patientName == null) ? "" : this.patientName) +
            "&FileNo=" + ((this.fileNo < 0 || this.fileNo == null) ? 0 : this.fileNo) +
            "&PhoneNumber=" + ((this.phoneNumber == null) ? "" : this.phoneNumber);
    }
}