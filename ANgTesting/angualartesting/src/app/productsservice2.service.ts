import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { from, Observable, throwError } from 'rxjs';
import { AppError } from 'src/models/AppError';
import { Product } from 'src/models/Product';
import 'rxjs/Rx';
import { map, filter, switchMap, catchError } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class Productsservice2Service {

  private apiUrl = 'http://localhost:3000/products';
  private products: Product[] = [];

  constructor(private http: HttpClient) {}

  getProducts(): Observable<Product[]> {
    // return this.http.get(this.apiUrl)
    // .map((response) => <Product[]>());
    return this.http.get<Product[]>(this.apiUrl);
     // return new  Observable<Product[]>();
    
  }

  // getProductsPromise(): Promise<Product[]> {
      
  //   // return this.http
  //   //   .get(this.apiUrl)
  //   //  .pipe(map(resp=>resp.json),catchError(this.handleError))

  //   return this.http.get<Product[]>(this.apiUrl);
  // }

  getProduct(id: number) {
    return this.http
      .get<Product>(`${this.apiUrl}/${id}`);
     
     
  }

  addProduct(product: Product) {
    return this.http
      .post<Product>(this.apiUrl, product);
      
     
  }

  updateProduct(id: number, product: Product) {
    return this.http
      .patch<Product>(`${this.apiUrl}/${id}`, product)
      // .pipe(map((response) => response.json()))
    
  }

  deleteProduct(id: number) {
    return this.http
      .delete<Product>(`${this.apiUrl}/${id}`)
      
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
