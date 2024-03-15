import { Product } from './../interfaces/product';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';
// import { HttpResponseProductModel } from '../interfaces/httpresponseproductsmodels';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  // private appURL: string;
  // private controllerURL: string;
   

  constructor(private http: HttpClient) {
    // this.appURL = "https://localhost:7039/";
    // this.controllerURL = "api/dbReciplastk/";
    
  }


  // ShowAllProducts(): Observable<HttpResponseProductModel>{
  //   return this.http.get<HttpResponseProductModel>('https://localhost:7039/api/dbReciplastk/showAllInfo');
  // }

  SearchProduct(infoProduct: Product): Observable<Product>{
    return this.http.get<Product>('https://localhost:7039/api/dbReciplastk/');
  }

  ShowListProducts(): Observable<Array<Product>>{
    
    return this.http.get<Array<Product>>('https://localhost:7039/api/dbReciplastk/showAllListProducts');
  }

  CreateNewProducts(infoProduct: Product): Observable<boolean>{
    //this.http.post('${this.appURL}${this.controllerURL}')
    return this.http.post<boolean>('https://localhost:7039/api/dbReciplastk/createNewProduct', infoProduct);
  }


}
