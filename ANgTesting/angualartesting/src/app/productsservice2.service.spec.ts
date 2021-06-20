import { TestBed, inject } from '@angular/core/testing';
import { Productsservice2Service } from './productsservice2.service';

describe('Productsservice2Service', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [Productsservice2Service]
    });
  });

  it('should be created', inject([Productsservice2Service], (service: Productsservice2Service) => {
    expect(service).toBeTruthy();
  }));
});
