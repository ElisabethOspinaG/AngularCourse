import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../interfaces/product';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private appURL: string;
  private controllerURL: string;

  constructor(private http: HttpClient) {
    this.appURL = "https://localhost:7039/";
    this.controllerURL = "api/dbReciplastk/";
  }

  ShowListProducts(infoProducts: Product): Observable<boolean>{
    //this.http.get('${this.appURL}${this.controllerURL}')
    return this.http.get<boolean>('https://localhost:7039/api/dbReciplastk/showAllInfo')
  }

  CreateProducts(infoProducts: Product): Observable<boolean>{
    //this.http.get('${this.appURL}${this.controllerURL}')
    return this.http.post<boolean>('https://localhost:7039/api/dbReciplastk/showAllInfo', infoProducts);
  }

  // CreateProducts(infoProducts: Product): Observable<modeloHttp>{
  //   //this.http.get('${this.appURL}${this.controllerURL}')
  //   return this.http.post<modeloHttp>('https://localhost:7039/api/dbReciplastk/showAllInfo', infoProducts);
  // }
}
