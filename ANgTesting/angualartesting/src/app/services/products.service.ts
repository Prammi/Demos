import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { Observable, throwError } from 'rxjs';
import { AppError } from 'src/models/AppError';
import { Product } from 'src/models/Product';
import 'rxjs/Rx';
import { map, filter, switchMap, catchError } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'  // <- ADD THIS
})
export class ProductsService {
  private apiUrl = 'http://localhost:3000/products';
  private products: Product[] = [];

  constructor(private http: Http) {}

  getProducts(): Observable<Product[]> {
    return this.http
      .get(this.apiUrl)
      .pipe(map((response) => response.json()))
    
  }

  getProductsPromise(): Promise<Product[]> {
      
    return this.http
      .get(this.apiUrl)
      .pipe(map((response) => response.json()))
      .toPromise();
  }

  getProduct(id: number) {
    return this.http
      .get(`${this.apiUrl}/${id}`)
      .pipe(map((response) => response.json()),catchError(this.handleError))
     
  }

  addProduct(product: Product) {
    return this.http
      .post(this.apiUrl, product)
      .pipe(map((response) => response.json()))
     
  }

  updateProduct(id: number, product: Product) {
    return this.http
      .patch(`${this.apiUrl}/${id}`, product)
      .pipe(map((response) => response.json()))
    
  }

  deleteProduct(id: number) {
    return this.http
      .delete(`${this.apiUrl}/${id}`)
      .pipe(map((response) => response.json()))
      
  }
 
   handleError(error) {
   let errorMessage = '';
   if (error.error instanceof ErrorEvent) {
     // client-side error
     errorMessage = `Error: ${error.error.message}`;
   } else {
     // server-side error
     errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
   }
   window.alert(errorMessage);
   return throwError(errorMessage);
 }
}