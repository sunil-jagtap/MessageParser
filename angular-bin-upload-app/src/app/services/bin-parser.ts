import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

export interface ParsedMessage {
  sequenceNumber: number;
  message: string;
}

@Injectable({
  providedIn: 'root',
})
export class BinParserService {
  private apiUrl = 'http://localhost:5077/BinParser/upload';

  constructor(private http: HttpClient) {}

  uploadFile(file: File): Observable<ParsedMessage[]> {
    const formData = new FormData();
    formData.append('file', file, file.name);
    return this.http.post<ParsedMessage[]>(this.apiUrl, formData).pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: HttpErrorResponse) {
    let errorMsg = 'Unknown error occurred';
    if (error.error instanceof ErrorEvent) {
      errorMsg = `Error: ${error.error.message}`;
    } else {
      errorMsg = `Server error: ${error.status}, message: ${error.message}`;
    }
    return throwError(() => new Error(errorMsg));
  }
}
