import { Component, OnInit } from '@angular/core';
import { AppError } from 'src/models/AppError';
import { Product } from 'src/models/Product';
import { Productsservice2Service } from '../productsservice2.service';


@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent  {

  products: Product[] = [];
  error: AppError;

  constructor(private service: Productsservice2Service) {}

  // ngOnInit() {
  //   debugger;
  //   console.log('in products');
  //   this.service.getProducts().subscribe(
  //     (products: Product[]) => {
  //       console.log('Success! Get Products Successful! (via Observable)');
  //       this.products = products;
  //     },
  //     (error: AppError) => {
  //       this.error = error;
  //       console.log(
  //         'Failed! Error occurred when getting products. (via Observable)',
  //         error
  //       );
  //     }
  //   );
  // }

  // xngOnInit() {
  //   this.service
  //     .getProductsPromise()
  //     .then((products: Product[]) => {
  //       console.log('Success! Get Products Successful! (via Promise)');
  //       this.products = products;
  //     })
  //     .catch((error: AppError) => {
  //       this.error = error;
  //       console.log(
  //         'Failed! Error occurred when getting products. (via Promise)',
  //         error
  //       );
  //     });
  // }

  // onDelete(productId) {
  //   if (confirm('Are you sure?')) {
  //     this.service.deleteProduct(productId).subscribe(
  //       () => {
  //         console.log('Success! Delete Product Successful!');
  //         this.products = this.products.filter(
  //           product => product.id !== productId
  //         );
  //       },
  //       (error: AppError) => {
  //         this.error = error;
  //         console.log('Failed! Error occurred when deleting product.', error);
  //       }
  //     );
  //   }
  // }
}
