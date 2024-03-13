import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RegisterUser, Usuario } from '../models/usuario';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SecurityService {
  private appURL: string;
  private controllerURL: string;

  constructor(private http: HttpClient) {
    this.appURL = "https://localhost:7039/";
    this.controllerURL = "/api/Login/"
  };

  CreateUser(user: RegisterUser): Observable<boolean>{
    return this.http.post<boolean>('https://localhost:7039/api/Login/registerUser', user);
  }

  LogIn(loginInfo: Usuario): Observable<boolean>{
  //   appURL: String = "https://localhost:7039/"
  //   controllerURL: string = "";
  //
    return this.http.get<boolean>('https://localhost:7039/api/Login/acceseAcount?user='+loginInfo.nombreUsuario+'&password='+loginInfo.password);
   };
}
