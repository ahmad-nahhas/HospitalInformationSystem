export class PaginationFilter {

    pageNumber = 1;
    pageSize = 2;

    constructor(pageNumber: number = 1, pageSize: number = 2) {
        this.pageNumber = pageNumber;
        this.pageSize = pageSize > 2 ? 2 : pageSize;
    }
}