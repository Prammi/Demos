import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdcutFormComponent } from './prodcut-form.component';

describe('ProdcutFormComponent', () => {
  let component: ProdcutFormComponent;
  let fixture: ComponentFixture<ProdcutFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProdcutFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProdcutFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
