import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { throwError } from "rxjs";
import { catchError } from "rxjs/operators";
import { City } from "src/models/City";

@Injectable({
    providedIn: 'root'
  })
export class CityService {

    private apiUrl = 'http://localhost:3000/City';

    constructor(private http: HttpClient) { }
    getCities() {
        return this.http.get<City[]>(`${this.apiUrl}`).pipe(
            catchError((error: HttpErrorResponse) => {
              return throwError(
                `Error retrieving city data. ${error.statusText || "Unknown"} `
              );
            })
          );
    }



    addCity(_city: City) {
        return this.http
            .post<City>(this.apiUrl, _city);

    }
}