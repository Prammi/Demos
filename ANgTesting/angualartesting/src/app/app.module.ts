import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

import { Productsservice2Service } from './productsservice2.service';


import { AppComponent } from './app.component';
import { AppNavComponent } from './app-nav/app-nav.component';
import { HomeComponent } from './home/home.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { ProdcutFormComponent } from './prodcut-form/prodcut-form.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { ProductsComponent } from './products/products.component';
import { SomecomponentComponent } from './somecomponent/somecomponent.component';
import { Prodcuts2Component } from './prodcuts2/prodcuts2.component';
import { CityService } from 'src/simpletests/city.service';
import { LoginComponent } from './login/login.component';


const appRoutes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'products2', component: Prodcuts2Component },
  { path: 'products/new', component: ProdcutFormComponent },
  { path: 'products/:id', component: ProductDetailComponent },
  { path: 'products/:id/edit', component: ProdcutFormComponent },
  { path: 'not-found', component: NotFoundComponent },
  { path: '', component: HomeComponent },
  { path: '**', redirectTo: '/not-found' }
];

@NgModule({
  declarations: [
    AppComponent,
    AppNavComponent,
    ProductsComponent,
    HomeComponent,
    NotFoundComponent,
    ProdcutFormComponent,ProductDetailComponent, SomecomponentComponent, Prodcuts2Component, LoginComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
   
    RouterModule.forRoot(appRoutes),
  ],
  providers: [Productsservice2Service,CityService],
  bootstrap: [AppComponent]
})
export class AppModule { }
// npx json-server --watch server-api.json