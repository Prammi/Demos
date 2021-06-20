import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AppError } from 'src/models/AppError';
import { Product } from 'src/models/Product';
import { Productsservice2Service } from '../productsservice2.service';

@Component({
  selector: 'app-prodcut-form',
  templateUrl: './prodcut-form.component.html',
  styleUrls: ['./prodcut-form.component.css']
})
export class ProdcutFormComponent implements OnInit {
  id: number;
  product: Product;
  addNew: boolean;
  @ViewChild('f') productForm: NgForm;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private service: Productsservice2Service
  ) {
    this.product = new Product();
    this.addNew = true;
  }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const id = params.get('id');
      if (id) {
        this.id = +id;
        this.service.getProduct(this.id).subscribe(
          (product: Product) => {
            console.log('Success! Get Product Successful!');
            this.product = product;
            this.addNew = false;
          },
          (error: AppError) => {
            console.log('Failed! Error occurred when getting product.', error);
          }
        );
      }
    });
  }

  onSubmit() {
    this.product.name = this.productForm.value.name;
    this.product.description = this.productForm.value.description;
    this.product.price = +this.productForm.value.price;
    this.product.isAvailable = this.productForm.value.isAvailable
      ? this.productForm.value.isAvailable
      : false;

    if (this.addNew) {
      this.service.addProduct(this.product).subscribe(
        (product: Product) => {
          debugger;
          console.log('Success! Add product successful.', product);
          this.router.navigate(['/products2']);
        },
        (error: AppError) => {
          console.log('Failed! Error occurred while adding a product.', error);
        }
      );
    } else {
      this.service.updateProduct(this.id, this.product).subscribe(
        (product: Product) => {
          debugger;
          console.log('Success! Update product successful.', product);
          this.router.navigate(['/products2']);
        },
        (error: AppError) => {
          console.log(
            'Failed! Error occurred while updating a product.',
            error
          );
        }
      );
    }
  }
}
