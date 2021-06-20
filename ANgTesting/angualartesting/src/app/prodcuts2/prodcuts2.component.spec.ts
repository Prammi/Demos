import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { Observable } from 'rxjs';
import { AppError } from 'src/models/AppError';
import { Product } from 'src/models/Product';
import { ProductsService } from '../services/products.service';

import { Prodcuts2Component } from './prodcuts2.component';

describe('Prodcuts2Component', () => {
  let component: Prodcuts2Component;
  let fixture: ComponentFixture<Prodcuts2Component>;
  let service: ProductsService;

  // beforeEach(async(() => {
  //   service = new ProductsService(null);
  //   TestBed.configureTestingModule({
  //     declarations: [ Prodcuts2Component ]
  //   })
  //   .compileComponents();
  // }));

  beforeEach(() => {
    service = new ProductsService(null);
    fixture = TestBed.createComponent(Prodcuts2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should get products', () => {
    const products: Product[] = [
      {
        id: 1,
        name: 'p1',
        description: 'p1 description',
        price: 10,
        isAvailable: true
      },
      {
        id: 2,
        name: 'p2',
        description: 'p2 description',
        price: 20,
        isAvailable: false
      },
      {
        id: 3,
        name: 'p3',
        description: 'p3 description',
        price: 30,
        isAvailable: true
      }
    ];
    component.ngOnInit();
    spyOn(service, 'getProducts').and.callFake(() => {
      return Observable.from([products]);
    });
    expect(service.getProducts).toHaveBeenCalled();
    expect(component.products).toEqual(products);
  });

  it('should set the error prop on fail of products', () => {
    const _error = new AppError("server-error");
    spyOn(service, 'getProducts').and.returnValue(Observable.throwError(_error));
    expect(component.error).not.toBeDefined();
    component.ngOnInit();
    expect(component.error).toBeDefined();
    expect(component.error.originalError).toEqual("server-error");
  })
});
