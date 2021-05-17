export class Filter {

    constructor(public pageNumber = 1, public pageSize = 6, public patientName = "", public fileNo = null, public phoneNumber = "") { }

    public toString() {
        return "/search?PageNumber=" + ((this.pageNumber <= 0 || (this.pageNumber == null)) ? 1 : this.pageNumber) +
            "&PageSize=" + ((this.pageSize > 6 || (this.pageSize == null)) ? 6 : this.pageSize) +
            "&Name=" + ((this.patientName == null) ? "" : this.patientName) +
            "&FileNo=" + ((this.fileNo < 0 || this.fileNo == null) ? 0 : this.fileNo) +
            "&PhoneNumber=" + ((this.phoneNumber == null) ? "" : this.phoneNumber);
    }
}