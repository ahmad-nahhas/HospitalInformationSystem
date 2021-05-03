export class PatientFilter {

    private _pageNumber = 1;
    private _pageSize = 6;
    private _patientName = "";
    private _fileNo = 0;
    private _phoneNumber = "";

    constructor(pageNumber = 1, pageSize = 6, patientName = "", fileNo = 0, phoneNumber = "") {

        this.setPageNumber(pageNumber);
        this.setPageSize(pageSize);
        this.setPatientName(patientName);
        this.setFileNo(fileNo);
        this.setPhoneNumber(phoneNumber);
    }

    setPageNumber(pageNumber: number) {
        this._pageNumber = pageNumber > 0 ? pageNumber : 1;
    }

    getPageNumber() {
        return (this._pageNumber <= 0 || this._pageNumber == null) ? 1 : this._pageNumber;
    }

    setPageSize(pageSize: number) {
        this._pageSize = pageSize > 6 ? 6 : pageSize;
    }

    getPageSize() {
        return (this._pageSize > 6 || this._pageSize == null) ? 6 : this._pageSize;
    }

    setPatientName(patientName: string) {
        this._patientName = patientName == null ? "" : patientName;
    }

    getPatientName() {
        return this._patientName == null ? "" : this._patientName;
    }

    setFileNo(fileNo: number) {
        this._fileNo = fileNo > 0 ? fileNo : 0;
    }

    getFileNo() {
        return (this._fileNo < 0 || this._fileNo == null) ? 0 : this._fileNo;
    }

    setPhoneNumber(phoneNumber: string) {
        this._phoneNumber = phoneNumber == null ? "" : phoneNumber;
    }

    getPhoneNumber() {
        return this._phoneNumber == null ? "" : this._phoneNumber;
    }
}