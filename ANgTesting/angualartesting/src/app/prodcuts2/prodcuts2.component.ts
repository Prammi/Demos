import { Component, OnInit } from '@angular/core';
import { AppError } from 'src/models/AppError';
import { Product } from 'src/models/Product';
import { Productsservice2Service } from '../productsservice2.service';

@Component({
  selector: 'app-prodcuts2',
  templateUrl: './prodcuts2.component.html',
  styleUrls: ['./prodcuts2.component.css']
})
export class Prodcuts2Component implements OnInit {

  products: Product[] = [];
  error: AppError;
private _service:Productsservice2Service;
  constructor(service:Productsservice2Service) {
    this._service=service;
  }
   ngOnInit() {
    debugger;
    console.log('in products');
    this._service.getProducts().subscribe(
      (products: Product[]) => {
        console.log('Success! Get Products Successful! (via Observable)');
        this.products = products;
      },
      (error: AppError) => {
        this.error = error;
        console.log(
          'Failed! Error occurred when getting products. (via Observable)',
          error
        );
      }
    );
  }




}
